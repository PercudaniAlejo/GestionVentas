using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class Producto
    {
        #region VM
        private int idProducto;
        private double precio;
        private string descripcion;
        private ColorPrenda colorName;
        private TipoPrenda tipo;
        #endregion

        #region PROPERTIES
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Descipcion { get => descripcion; set => descripcion = value; }
        public ColorPrenda ColorName { get => colorName; set => colorName = value; }
        public TipoPrenda Tipo { get => tipo; set => tipo = value; }
        #endregion

        #region BUILDERS
        public Producto(int idProducto, double precio, string descripcion, ColorPrenda colorName, TipoPrenda tipo) {
            this.idProducto = idProducto;
            this.precio = precio;
            this.descripcion = descripcion;
            this.colorName = colorName;
            this.tipo = tipo;
        }
        public Producto() {
            idProducto = 0;
            precio = 0.0;
            descripcion = "";
            colorName = null;
            tipo = null;
        }
        #endregion

        #region METHODS

        public override string ToString() {
            return string.Concat(tipo + " - " + colorName);
        }
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
            prod.precio = this.Precio;
            prod.descripcion = this.Descipcion;
            prod.idColor = this.colorName.Id;
            prod.idTipoPrenda = this.tipo.Id;
        }
        public static IQueryable BuscarIQ(string buscado) {
            buscado = buscado.ToLower();
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var filas = from x in dc.eProducto
                        where x.id.ToString().Contains(buscado) ||
                        x.precio.ToString().Contains(buscado) ||
                        x.eTipoPrenda.tipo.Contains(buscado) ||
                        x.eColor.id.ToString().Contains(buscado)
                        select new
                        {
                            ID = x.id,
                            Prenda = x.eTipoPrenda.tipo,
                            Color = x.eColor.colorName,
                            Precio = "$ " + (int)x.precio,
                            Descripcion = x.descripcion
                        };
            return filas;
        }
        public static List<Producto> Buscar(string buscado = "")
        {
            buscado = buscado.ToLower();
            List<Producto> resultados = new List<Producto>();
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var filas = from x in dc.eProducto
                        where x.id.ToString().Contains(buscado) ||
                        x.precio.ToString().Contains(buscado)
                        select x;

            if (filas != null)
            {
                foreach (var f in filas)
                {
                    resultados.Add(new Producto(f.id, f.precio, f.descripcion, ColorPrenda.BuscarPorId(f.idColor), TipoPrenda.BuscarPorId(f.idTipoPrenda)));
                }
            }
            return resultados;
        }
        public void Eliminar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var encontrado = (from x in dc.eProducto where x.id == this.idProducto select x).FirstOrDefault();
            if (encontrado != null)
            {
                dc.eProducto.DeleteOnSubmit(encontrado);
                dc.SubmitChanges();
            }
            else
                throw new Exception("No se pudo eliminar el producto, el id " + this.idProducto + " no fue encontrado.");
        }
        public static Producto BuscarPorId(int idBuscado) {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var enc = (from x in dc.eProducto where x.id == idBuscado select x).FirstOrDefault();
            if (enc != null)
                return new Producto(enc.id, enc.precio, enc.descripcion, ColorPrenda.BuscarPorId(enc.idColor), TipoPrenda.BuscarPorId(enc.idTipoPrenda));
            return null;
        }
        #endregion
    }
}
