﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class DetalleVenta
    {
        #region VM
        private int idDetalleVenta;
        private Producto producto;
        private Venta venta;
        private double precio;
        #endregion

        #region PROPERTIES
        [Browsable(false)]
        public int IdDetalleVenta { get => idDetalleVenta; set => idDetalleVenta = value; }
        public double Precio { get => precio; set => precio = value; }
        public Producto Producto { get => producto; set => producto = value; }
        [Browsable(false)]
        public Venta Venta { get => venta; set => venta = value; }
        #endregion

        #region BUILDER
        public DetalleVenta(int idDetalleVenta, Producto producto, Venta venta, double precio)
        {
            this.idDetalleVenta = idDetalleVenta;
            this.producto = producto;
            this.venta = venta;
            this.precio = precio;
        }

        public DetalleVenta()
        {
            idDetalleVenta = 0;
            producto = null;
            venta = null;
            precio = 0.0;
        }
        #endregion

        #region METHODS
        public void Guardar(DCDataContext dcOriginal, eVenta eV)
        {
            DCDataContext dc = dcOriginal;
            eDetalleVenta detalle = new eDetalleVenta();

            if (this.idDetalleVenta == 0)
            {
                detalle.eVenta = eV;
                detalle.idProducto = this.Producto.IdProducto;
                detalle.precio = this.Precio;
                dc.eDetalleVenta.InsertOnSubmit(detalle);
            }
            else
            {
                detalle = (from x in dc.eDetalleVenta where x.id == this.idDetalleVenta select x).FirstOrDefault();
                
                detalle.idProducto = this.producto.IdProducto;
                detalle.idVenta = this.venta.IdVenta;
                detalle.precio = this.Precio;
            }
        }
        public static IQueryable BuscarIQ(string buscado)
        {
            buscado = buscado.ToLower();
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var filas = from x in dc.eDetalleVenta
                        where x.id.ToString().Contains(buscado) ||
                        x.eProducto.eTipoPrenda.tipo.Contains(buscado) ||
                        x.eVenta.nombreCliente.Contains(buscado) ||
                        x.eVenta.apellidoCliente.Contains(buscado) ||
                        x.eVenta.fecha.ToString().Contains(buscado) ||
                        x.precio.ToString().Contains(buscado)
                        select new
                        {
                            ID = x.id,
                            Cliente = x.eVenta.nombreCliente + ", " + x.eVenta.apellidoCliente.ToUpper(),
                            Fecha = x.eVenta.fecha,
                            Producto = x.eProducto.eTipoPrenda.tipo + " en " + x.eProducto.eColor.colorName,
                            Precio = "$ " + (int)x.precio,
                        };
            return filas;
        }

        public static List<DetalleVenta> Buscar(int idVenta)
        {
            List<DetalleVenta> resultados = new List<DetalleVenta>();

            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());

            var filas = from x in dc.eDetalleVenta
                        where x.idVenta == idVenta
                        select x;

            if (filas != null)
            {
                foreach (var f in filas)
                {
                    resultados.Add(new DetalleVenta(f.id, Producto.BuscarPorId(f.idProducto), Venta.BuscarPorId(f.idVenta), f.precio));
                }
            }

            return resultados;

        }
        #endregion
    }
}
