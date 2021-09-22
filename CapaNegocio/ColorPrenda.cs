using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class ColorPrenda
    {
        #region VM
        private int id;
        private string colorName;

        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string ColorName { get => colorName; set => colorName = value; }

        #endregion

        #region BUILDERS
        public ColorPrenda(int id, string colorName)
        {
            this.id = id;
            this.colorName = colorName;
        }

        public ColorPrenda()
        {
            id = 0;
            colorName = "";
        }

        #endregion

        #region METHODS
        public override string ToString()
        {
            return string.Concat(colorName);
        }

        public void Guardar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            eColor color = new eColor();

            if (this.id == 0)
            {
                CargarFilaColor(color);
                dc.eColor.InsertOnSubmit(color);
            }
            else
            {
                color = (from x in dc.eColor where x.id == this.id select x).FirstOrDefault();
                CargarFilaColor(color);
            }
            dc.SubmitChanges();
        }

        public void Eliminar() {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var encontrado = (from x in dc.eColor where x.id == this.id select x).FirstOrDefault();
            if (encontrado != null)
            {
                dc.eColor.DeleteOnSubmit(encontrado);
                dc.SubmitChanges();
            }
            else
                throw new Exception("No se pudo eliminar el color, el id " + this.id + " no fue encontrado.");
        }
        public void CargarFilaColor(eColor _color)
        {
            _color.id = this.Id;
            _color.colorName = this.ColorName;
        }
        public static List<ColorPrenda> Buscar(string buscado = "")
        {
            buscado = buscado.ToLower();
            List<ColorPrenda> resultados = new List<ColorPrenda>();
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var filas = from x in dc.eColor
                        where x.colorName.ToLower().Contains(buscado)
                        select x;

            if (filas != null)
            {
                foreach (var f in filas)
                {
                    resultados.Add(new ColorPrenda(f.id, f.colorName));
                }
            }
            return resultados;
        }
        public static ColorPrenda BuscarPorId(int idBuscado)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var enc = (from x in dc.eColor where x.id == idBuscado select x).FirstOrDefault();
            if (enc != null)
                return new ColorPrenda(enc.id, enc.colorName);
            return null;
        }
        #endregion
    }
}
