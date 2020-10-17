using System;
using System.Linq;
using System.Linq.Expressions;
using RegistroPrestamo.DAL;
using RegistroPrestamo.Entidades;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RegistroPrestamo.BLL
{
    public class MorasBLL
    {
        public static bool Guardar(Moras moras)
        {
            if (!Existe(moras.MoraId))
                return Insertar(moras);
            else
                return Modificar(moras);
        }

        private static bool Insertar(Moras moras)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                //Agregar a la entidad que se desea ingresar al contexto
                contexto.Moras.Add(moras);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;

        }

        private static bool Modificar(Moras moras)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete FROM MorasDetalle Where MoraId={moras.MoraId}");

                foreach (var item in moras.Detalle)
                {
                    contexto.Entry(item).State = EntityState.Added;
                }
                
                contexto.Entry(moras).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Eliminar(int id)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                //Buscar La entidad que se desea eliminar
                var moras = contexto.Moras.Find(id);

                if (moras != null)
                {
                    contexto.Moras.Remove(moras);//Removemos la entidad
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static Moras Buscar(int id)
        {

            Contexto contexto = new Contexto();
            Moras moras = new Moras();

            try
            {
                 moras = contexto.Moras.Include(x => x.Detalle)
                    .Where(x => x.MoraId == id)
                    .SingleOrDefault();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return moras;

        }

        public static bool Existe(int id)
        {

            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Moras.Any(e => e.MoraId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        public static List<Moras> GetList(Expression<Func<Moras, bool>> criterio)
        {

            List<Moras> lista = new List<Moras>();
            Contexto contexto = new Contexto();

            try
            {
                //obtener la lista y filtrarla segun el criterio recibido por parametro
                lista = contexto.Moras.Where(criterio).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
    }
}
