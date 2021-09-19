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

        private void Frm_Baja_TipoFactura_Load(object sender, EventArgs e)
        {
            NE_TipoFactura usu = new NE_TipoFactura();
            CargarFormulario(usu.RecuperarTipoFactura(id_tipo_factura));
        }

        private void CargarFormulario(DataTable tabla)
        {
            txt_id_TipoFactura._Text = tabla.Rows[0]["id_tipo_factura"].ToString();
            txt_n_TipoFactura._Text = tabla.Rows[0]["nombre"].ToString();

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_TipoFactura usu = new NE_TipoFactura();

                usu.id_tipo_factura = txt_id_TipoFactura._Text;

                if (MessageBox.Show("¿Está seguro de que desea eliminar al Tipo de Factura: " + txt_n_TipoFactura._Text + "?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    usu.Borrar();
                    MessageBox.Show("Se eliminó correctamente el Tipo de Factura: " + txt_n_TipoFactura._Text, "Importante");
                    this.Dispose();
                }
                else
                    MessageBox.Show("Eliminación cancelada");

            }
        }
    }
}
