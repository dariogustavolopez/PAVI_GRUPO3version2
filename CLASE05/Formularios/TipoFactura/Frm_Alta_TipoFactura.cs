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
using CLASE05.Clases;

namespace CLASE05.Formularios.TipoFactura
{
    public partial class Frm_Alta_TipoFactura : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public Frm_Alta_TipoFactura()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //N1  validar los datos del formulario
            //N1 la validacion de todo ok => realizo validación especifica
            //----N2 -------si la validacion especifica da ok => grabo
            //----N2 -------la validacion especifica da error => ir a corregir el error
            //N1 si validacion da error => ir a corregir el error
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                // VALIDACION ESPECIFICA
                //if (_TE.ValidarEmail(txt_email._Text) == TratamientosEspeciales.RespuestaValidacion.Error)
                //{
                //    MessageBox.Show("El formato de correo es invalido");
                //    txt_email.Focus();
                //    return;
                //}
                // GRABAR NUEVO REGISTRO
                NE_TipoFactura usu = new NE_TipoFactura();


                usu.id_tipo_factura = txt_id_factura._Text;
                usu.nombre = txt_n_TipoFactura._Text;

                usu.Insertar();
                MessageBox.Show("Se grabó correctamente", "Importante");
                this.Dispose();
            }
        }

        private void Frm_Alta_TipoFactura_Activated(object sender, EventArgs e)
        {
            this.txt_n_TipoFactura.Focus();
        }
    }
}


