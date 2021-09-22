using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class Venta
    {
        #region VM
        private int idVenta;
        private string nombreCliente;
        private string apellidoCliente;
        private DateTime fecha;
        private string observaciones;
        private double precio;
        #endregion

        #region PROPERTIES
        public int IdVenta { get => idVenta; set => idVenta = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidoCliente { get => apellidoCliente; set => apellidoCliente = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public double Precio { get => precio; set => precio = value; }
        #endregion

        #region BUILDERS
        public Venta(int idVenta, string nombreCliente, string apellidoCliente, DateTime fecha, string observaciones, double precio)
        {
            this.idVenta = idVenta;
            this.nombreCliente = nombreCliente;
            this.apellidoCliente = apellidoCliente;
            this.fecha = fecha;
            this.observaciones = observaciones;
            this.precio = precio;
        }

        public Venta() {
            idVenta = 0;
            nombreCliente = "";
            apellidoCliente = "";
            fecha = DateTime.Today;
            observaciones = "";
            precio = 0.0;
        }
        #endregion

        #region METHODS
        public void Guardar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            eVenta venta = new eVenta();

            if (this.idVenta == 0)
            {
                CargarFilaVenta(venta);
                dc.eVenta.InsertOnSubmit(venta);
            }
            else
            {
                venta = (from x in dc.eVenta where x.id == this.idVenta select x).FirstOrDefault();
                CargarFilaVenta(venta);
            }
            dc.SubmitChanges();
        }

        public void CargarFilaVenta(eVenta venta)
        {
            venta.id = this.IdVenta;
            venta.nombreCliente = this.NombreCliente;
            venta.apellidoCliente = this.ApellidoCliente;
            venta.fecha = this.Fecha;
            venta.observaciones = this.Observaciones;
            venta.precio = this.Precio;
        }

        public static IQueryable Buscar(string buscado)
        {
            buscado = buscado.ToLower();
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var filas = from x in dc.eVenta
                        where x.id.ToString().Contains(buscado) ||
                        x.nombreCliente.Contains(buscado) ||
                        x.apellidoCliente.Contains(buscado) ||
                        x.fecha.ToString().Contains(buscado) ||
                        x.precio.ToString().Contains(buscado)
                        select new
                        {
                            ID = x.id,
                            Cliente = x.nombreCliente + ", " + x.apellidoCliente.ToUpper(),
                            Fecha = x.fecha,
                            Precio = "$ " + (int)x.precio,
                            Observaciones = x.observaciones
                        };
            return filas;
        }

        #endregion
    }
}
