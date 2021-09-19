using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    class Producto
    {
        #region VM
        private int idProducto;
        private string nombre;
        private double precio;
        private string descripcion;
        #endregion

        #region PROPERTIES
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Descipcion { get => descripcion; set => descripcion = value; }
        #endregion

        #region BUILDERS
        public Producto(int idProducto, string nombre, double precio, string descripcion) {
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.precio = precio;
            this.descripcion = descripcion;
        }

        public Producto() {
            idProducto = 0;
            nombre = "";
            precio = 0.0;
            descripcion = "";
        }
        #endregion

        #region METHODS
        public void Guardar() {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            eProducto prod = new eProducto();

            if (this.idProducto == 0){
                CargarFilaProducto(prod);
                dc.eProducto.InsertOnSubmit(prod);
            }
            else{
                prod = (from x in dc.eProducto where x.id == this.idProducto select x).FirstOrDefault();
                CargarFilaProducto(prod);
            }
            dc.SubmitChanges();
        }

        public void CargarFilaProducto(eProducto prod)
        {
            prod.id = this.IdProducto;
            prod.nombre = this.Nombre;
            prod.precio = this.Precio;
            prod.descripcion = this.Descipcion;
        }

        public static IQueryable Buscar(string buscado) {
            buscado = buscado.ToLower();
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var filas = from x in dc.eProducto
                        where x.id.ToString().Contains(buscado) ||
                        x.nombre.Contains(buscado) ||
                        x.precio.ToString().Contains(buscado)
                        select new
                        {
                            ID = x.id,
                            Cliente = x.nombre,
                            Precio = "$ " + (int)x.precio,
                            Descripcion = x.descripcion
                        };
            return filas;
        }
        #endregion


    }
}
