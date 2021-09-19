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
    public partial class Frm_Baja_TipoFactura : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public Frm_Baja_TipoFactura()
        {
            InitializeComponent();
        }

        //private void Frm_Baja_TipoFactura_Load(object sender, EventArgs e)
        //{
        //    NE_TipoFactura usu = new NE_TipoFactura();
        //    CargarFormulario(usu.RecuperarTipoFactura(id_tipo_factura));
        //}

        //private void CargarFormulario(DataTable tabla)
        //{
        //    txt_id_usuario._Text = tabla.Rows[0]["id_usuario"].ToString();
        //    txt_n_usuario._Text = tabla.Rows[0]["n_usuario"].ToString();
        //    txt_password._Text = tabla.Rows[0]["password"].ToString();

        //}
    }
}
