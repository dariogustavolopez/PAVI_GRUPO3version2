using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASE05.Clases;
using CLASE05.Negocios;


namespace CLASE05.Formularios.Rubros
{
    public partial class Frm_Consulta_Rubro : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public Frm_Consulta_Rubro()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Consulta_Rubro_Load(object sender, EventArgs e)
        {
            NE_Rubros usu = new NE_Rubros();
            CargarFormulario(usu.RecuperarRubro(id_rubro));
        }

        private void CargarFormulario(DataTable tabla)
        {
            txt_id_rubro._Text = tabla.Rows[0]["id_rubro"].ToString();
            txt_n_rubro._Text = tabla.Rows[0]["nombre"].ToString();
            txt_n_rubro.Enabled = false;

        }
    }
}
