using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class TipoPrenda
    {
        #region VM
        private int id;
        private string tipo;
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        #endregion

        #region BUILDERS
        public TipoPrenda(int id, string tipo)
        {
            this.id = id;
            this.tipo = tipo;
        }
        public TipoPrenda()
        {
            id = 0;
            tipo = "";
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return string.Concat(tipo);
        }

        public void Eliminar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var encontrado = (from x in dc.eTipoPrenda where x.id == this.id select x).FirstOrDefault();
            if (encontrado != null)
            {
                dc.eTipoPrenda.DeleteOnSubmit(encontrado);
                dc.SubmitChanges();
            }
            else
                throw new Exception("No se pudo eliminar la prenda, el id " + this.id + " no fue encontrado.");
        }

        public void Guardar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            eTipoPrenda tipo = new eTipoPrenda();

            if (this.id == 0)
            {
                CargarFilaTipoPrenda(tipo);
                dc.eTipoPrenda.InsertOnSubmit(tipo);
            }
            else 
            {
                tipo = (from x in dc.eTipoPrenda where x.id == this.id select x).FirstOrDefault();
                CargarFilaTipoPrenda(tipo);
            }
            dc.SubmitChanges();
        }

        public void CargarFilaTipoPrenda(eTipoPrenda _tipoPrenda)
        {
            _tipoPrenda.id = this.Id;
            _tipoPrenda.tipo = this.Tipo;
        }

        public static List<TipoPrenda> Buscar(string buscado = "")
        {
            buscado = buscado.ToLower();
            List<TipoPrenda> resultados = new List<TipoPrenda>();
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var filas = from x in dc.eTipoPrenda
                        where x.tipo.ToLower().Contains(buscado)
                        select x;

            if (filas != null)
            {
                foreach (var f in filas)
                {
                    resultados.Add(new TipoPrenda(f.id, f.tipo));
                }
            }

            return resultados;
        }

        public static TipoPrenda BuscarPorId(int idBuscado)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var enc = (from x in dc.eTipoPrenda where x.id == idBuscado select x).FirstOrDefault();
            if (enc != null)
                return new TipoPrenda(enc.id, enc.tipo);
            return null;
        }
        #endregion
    }
}
