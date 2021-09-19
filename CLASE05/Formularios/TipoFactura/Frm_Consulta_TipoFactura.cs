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

namespace CLASE05.Formularios.TipoFactura
{
    public partial class Frm_Consulta_TipoFactura : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public Frm_Consulta_TipoFactura()
        {
            InitializeComponent();
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Frm_Consulta_TipoFactura_Load(object sender, EventArgs e)
        {
            NE_TipoFactura usu = new NE_TipoFactura();
            //CargarFormulario(usu.RecuperarTipoFactura(id_tipo_factura));
        }
        private void CargarFormulario(DataTable tabla)
        {
            txt_id_factura._Text = tabla.Rows[0]["id_usuario"].ToString();
            txt_n_TipoFactura._Text = tabla.Rows[0]["n_usuario"].ToString();

        }
    }
}
