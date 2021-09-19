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
    public partial class Frm_Modificacion_TipoFactura : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public Frm_Modificacion_TipoFactura()
        {
            InitializeComponent();
        }

        private void Frm_Modificacion_TipoFactura_Load(object sender, EventArgs e)
        {
            NE_TipoFactura usu = new NE_TipoFactura();
            CargarFormulario(usu.RecuperarTipoFactura(id_tipo_factura));
        }

        private void CargarFormulario(DataTable tabla)
        {
            txt_n_TipoFactura_viejo._Text = tabla.Rows[0]["nombre"].ToString();

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                //// VALIDACION ESPECIFICA
                //if (_TE.ValidarEmail(txt_email._Text) == TratamientosEspeciales.RespuestaValidacion.Error)
                //{
                //    MessageBox.Show("El formato de correo es invalido");
                //    txt_email.Focus();
                //    return;
                //}

                // GRABAR NUEVO REGISTRO
                NE_TipoFactura usu = new NE_TipoFactura();

                usu.nombre = txt_n_TipoFactura_nuevo._Text;

                usu.Modificar();
                MessageBox.Show("Se modificó correctamente el Tipo de Factura a:" + txt_n_TipoFactura_nuevo._Text, "Importante");

            }

            this.Close();
        }
    }
}
