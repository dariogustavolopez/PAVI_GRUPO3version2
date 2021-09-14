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

namespace CLASE05.Formularios.TipoFactura
{
    public partial class Frm_ABM_TipoFactura : CLASE05.Formularios.FrmBASE.FrmBase_ABM_Entrada
    {
        public Frm_ABM_TipoFactura()
        {
            InitializeComponent();
        }

        private void Frm_ABM_TipoFactura_Load(object sender, EventArgs e)
        {
            this.grid_TipoFactura.Formatear("ID Tipo Factura, 100, C; Nombre Tipo Factura, 250, I");
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

            NE_Usuarios usu = new NE_Usuarios();

            string columna = "";

            if (txt_patron.Text != string.Empty)
            {
                if (rb_n_TipoFactura.Checked == true)
                    columna = rb_n_TipoFactura.Text;

                grid_TipoFactura.Cargar(usu.BuscarUsuario(txt_patron.Text, columna));
                if (grid_TipoFactura.Rows.Count == 0)
                    MessageBox.Show("No se encontró ningún usuario", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_id_TipoFactura.Text != string.Empty)
            {
                grid_TipoFactura.Cargar(usu.BuscarUsuario(txt_id_TipoFactura.Text));
                if (grid_TipoFactura.Rows.Count == 0)
                    MessageBox.Show("No se encontró ningún usuario", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            // btn_buscar.Enabled = false;
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_Alta_TipoFactura frm_alta = new Frm_Alta_TipoFactura();
            frm_alta.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Frm_Modificacion_TipoFactura frm_modificacion = new Frm_Modificacion_TipoFactura();
            frm_modificacion.ShowDialog();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            Frm_Baja_TipoFactura frm_baja = new Frm_Baja_TipoFactura();
            frm_baja.ShowDialog();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_Consulta_TipoFactura frm_consulta = new Frm_Consulta_TipoFactura();
            frm_consulta.ShowDialog();
        }

        private void btn_blan_patron_Click(object sender, EventArgs e)
        {
            this.txt_patron.Text = string.Empty;
            this.txt_id_TipoFactura.Text = string.Empty;
            txt_id_TipoFactura.Enabled = false;
            txt_patron.Enabled = false;
        }

        
    }
}
