using Microsoft.EntityFrameworkCore;
using Parcial1_PA2.DAL;
using Parcial1_PA2.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_PA2.Controllers
{
    public class ProductoController 
    {
        public bool Guardar(Productos producto)
        {
            Contexto db = new Contexto();
            bool paso = false;

            db.Productos.Add(producto);
            paso = db.SaveChanges() > 0;
            return paso;
        }

        public bool Modificar(Productos producto)
        {
            Contexto db = new Contexto();
            bool paso = false;

            db.Productos.Add(producto).State = EntityState.Modified;
            paso = db.SaveChanges() > 0;

            return paso;
        }

        public Productos Buscar(int id)
        {
            Contexto db = new Contexto();
            Productos producto = new Productos();

            try
            {
                producto = db.Productos.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return producto;
        }

        public bool Eliminar(int id)
        {
            Contexto db = new Contexto();
            bool paso = false;
            Productos producto = new Productos();

            try
            {
                producto = db.Productos.Find(id);
                db.Entry(producto).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }



    }
}
