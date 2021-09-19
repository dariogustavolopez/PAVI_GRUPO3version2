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
    public partial class Frm_Baja_Rubro : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public Frm_Baja_Rubro()
        {
            InitializeComponent();
        }

        private void Frm_Baja_Rubro_Load(object sender, EventArgs e)
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

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_Rubros usu = new NE_Rubros();

                usu.id_rubro = txt_id_rubro._Text;

                if (MessageBox.Show("¿Está seguro de que desea eliminar el rubro: " + txt_n_rubro._Text + "?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    usu.Borrar();
                    MessageBox.Show("Se eliminó correctamente el rubro: " + txt_n_rubro._Text, "Importante");
                    this.Dispose();
                }
                else
                    MessageBox.Show("Eliminación cancelada");

            }
        }
    }
}
