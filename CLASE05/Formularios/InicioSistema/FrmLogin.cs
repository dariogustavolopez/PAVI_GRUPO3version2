using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASE05.Negocios;

namespace CLASE05.Formularios.InicioSistema
{
    public partial class FrmLogin : Form
    {
        public string Pp_usuario
        {
            get { return this.txt_usuario.Text; }
            set { this.txt_usuario.Text = value; }
        }
        public string Pp_clave
        {
            get { return this.txt_clave.Text; }
            set { this.txt_clave.Text = value; }
        }

       
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if(txt_usuario.Text =="")
            {
                MessageBox.Show("Falta carga el nombre del usuario", "Importante"
                              , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if(txt_clave.Text =="")
            {
                MessageBox.Show("Falta carga la clave del usuario", "Importante"
               , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            NE_Usuarios usuario = new NE_Usuarios();

            if (usuario.Validar(txt_usuario.Text, txt_clave.Text)== NE_Usuarios.Validacion.correcta)
            {
                MessageBox.Show("Validación Correcta", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
                MessageBox.Show("Validación Incorrecta", "", MessageBoxButtons.OK,  MessageBoxIcon.Stop);

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_usuario.Text = "";
            txt_clave.Text = "";
            this.Close();
        }

    }
}
