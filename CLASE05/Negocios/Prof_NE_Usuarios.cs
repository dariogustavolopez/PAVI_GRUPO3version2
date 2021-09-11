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
    class Prof_NE_Usuarios
    {
        public enum Validacion { correcta, incorrecta }

        public string id_usuario { get; set; }
        public string id_perfil { get; set; }
        public string n_usario { get; set; }
        public string passsword { get; set; }
        public string email { get; set; }
        public string apellido { get; set; }
        public string nombres { get; set; }
        public string cuil { get; set; }
        public string id_estado { get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public Validacion Validar(string nombre, string password)
        {
            string sql = @"SELECT * FROM Usuarios
                         WHERE n_usuario = '" + nombre + "'"
                         + " AND password = " + password;

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
        public int RecuperarId(string nombre, string password)
        {
            string sql = @"SELECT id_usuario FROM Usuarios
                         WHERE n_usuario = '" + nombre + "'"
                        + " AND password = " + password;

            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelect(sql);

            if (tabla.Rows.Count == 1)
                return int.Parse(tabla.Rows[0][0].ToString());
            else
                return 0;
        }
        public DataTable BuscarUsuario(string patron, string columna)
        {
            string sql = @"SELECT id_usuario, n_usuario, apellido, nombres 
                          FROM usuarios WHERE " + columna + " like '%" + patron + "%'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarUsuario(string id_usuario)
        {
            string sql = @"SELECT id_usuario, n_usuario, apellido, nombres 
                          FROM usuarios WHERE id_usuario = " + id_usuario;

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarUsuario(string id_usuario)
        {
            string sql = @"SELECT * 
                          FROM usuarios WHERE id_usuario = " + id_usuario;

            return _BD.EjecutarSelect(sql);
        }
        public void Isertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO usuarios (id_perfil, n_usuario, password, email
                               , apellido, nombres, cuil, id_estado) VALUES (";
            sqlInsert += id_perfil;
            sqlInsert += ", '" + n_usario + "'";
            sqlInsert += ", '" + passsword + "'";
            sqlInsert += ", '" + email + "'";
            sqlInsert += ", '" + apellido + "'";
            sqlInsert += ", '" + nombres + "'";
            sqlInsert += ", '" + cuil + "'";
            sqlInsert += ", " + id_estado + ")";

            //MessageBox.Show(sqlInsert);
            _BD.Insertar(sqlInsert);
        }

    }
}
    

