using System;
using System.Linq;
using System.Linq.Expressions;
using RegistroPrestamo.DAL;
using RegistroPrestamo.Entidades;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RegistroPrestamo.BLL{

    public class PrestamoBLL{

        public static bool Guardar(Prestamo prestamo){
           if(!Existe(prestamo.PrestamoId))
                return Insertar(prestamo);
           else
                return Modificar(prestamo);
        }
        
        private static bool Insertar(Prestamo prestamo){

             bool paso = false;
             Contexto contexto = new Contexto();

            try{
                //Agregar a la entidad que se desea ingresar al contexto
                contexto.Prestamo.Add(prestamo);
                paso = contexto.SaveChanges()>0;
            }
            catch(Exception){
                throw;
            }
            finally{
                contexto.Dispose();
            }
            return paso;

        }

        private static bool Modificar(Prestamo prestamo){

            bool paso = false;
            Contexto contexto = new Contexto();

            try{
                //Marcar la entidad como modificada para que 
                //el contexto sepa como proceder
                contexto.Entry(prestamo).State= EntityState.Modified;
                paso = contexto.SaveChanges()>0;
            }
            catch(Exception){
                throw;
            }
            finally{
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Eliminar(int id){
            
            bool paso = false;
            Contexto contexto = new Contexto();

            try{
                //Buscar La entidad que se desea eliminar
                var prestamo = contexto.Prestamo.Find(id);

                if(prestamo != null){
                    contexto.Prestamo.Remove(prestamo);//Removemos la entidad
                    paso = contexto.SaveChanges() >0;
                }
            }
            catch(Exception){
                throw;
            }
            finally{
                contexto.Dispose();
            }

            return paso;
        }

        public static Prestamo Buscar(int id){

            Contexto contexto = new Contexto();
            Prestamo prestamo = new Prestamo();

            try{
                prestamo =contexto.Prestamo.Find(id);

            }
            catch(Exception){
                throw;
            }
            finally{
                contexto.Dispose();
            }

            return prestamo;

        }

        public static bool Existe(int id){

            Contexto contexto = new Contexto();
            bool encontrado = false;

            try{
                encontrado = contexto.Prestamo.Any(e => e.PrestamoId ==id);
            }
            catch(Exception){
                throw;
            }
            finally{
                contexto.Dispose();
            }

            return encontrado;
        }

        public static List<Prestamo> GetList(Expression<Func<Prestamo, bool>> criterio){
            
            List<Prestamo> lista = new List<Prestamo>();
            Contexto contexto = new Contexto();

            try{
                //obtener la lista y filtrarla segun el criterio recibido por parametro
                lista = contexto.Prestamo.Where(criterio).ToList();

            }
            catch(Exception){
                throw;
            }
            finally{
                contexto.Dispose();
            }
            return lista;
        }
    }
}