using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLASE05.Clases;
using System.Data;
using System.Windows.Forms;

namespace CLASE05.Negocios
{
    class NE_TipoFactura
    {
        public enum Validacion { correcta, incorrecta }

        public string id_tipo_factura { get; set; }
        public string nombre { get; set; }
    
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public Validacion Validar(string nombre)
        {
            string sql = @"SELECT * FROM tipo_factura
                         WHERE nombre = '" + nombre + "'";

            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelect(sql);

            if (tabla.Rows.Count == 1)
            {
                return Validacion.correcta;
            }
            else
            {
                return Validacion.incorrecta;
            }
        }

        public int RecuperarId(string nombre)
        {
            string sql = @"SELECT id_tipo_factura FROM tipo_factura
                         WHERE nombre = '" + nombre + "'";

            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelect(sql);

            if (tabla.Rows.Count == 1)
                return int.Parse(tabla.Rows[0][0].ToString());
            else
                return 0;
        }

        public DataTable BuscarTipoFactura(string patron, string columna)
        {
            string sql = @"SELECT id_tipo_factura, nombre
                          FROM tipo_factura WHERE " + columna + " like '%" + patron + "%'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarTipoFactura(string id_tipo_factura)
        {
            string sql = @"SELECT id_tipo_factura, nombre
                          FROM tipo_factura WHERE id_tipo_factura = " + id_tipo_factura;

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarTipoFactura(string id_tipo_factura)
        {
            string sql = @"SELECT * 
                          FROM tipo_factura WHERE id_tipo_factura = " + id_tipo_factura;

            return _BD.EjecutarSelect(sql);
        }

        public void Insertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO tipo_factura (nombre) VALUES (";
            sqlInsert += "'" + nombre + "')";

            //MessageBox.Show(sqlInsert);
            _BD.Insertar(sqlInsert);
        }
        public void Modificar()
        {
            string sqlUpdate = "";

            sqlUpdate = "UPDATE tipo_factura SET ";
            sqlUpdate += "nombre = '" + nombre + "'";
            sqlUpdate += " WHERE id_tipo_factura = " + id_tipo_factura;

            _BD.Modificar(sqlUpdate);
        }

        public void Borrar()
        {
            string sqlDelete = "DELETE FROM tipo_factura WHERE id_tipo_factura = " + id_tipo_factura;

            _BD.Borrar(sqlDelete);
        }

    }
}
