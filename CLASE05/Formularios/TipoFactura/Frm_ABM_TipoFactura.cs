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

        ///BOTON DE BUSQUEDA
        private void btn_buscar_Click(object sender, EventArgs e)
        {

            NE_TipoFactura usu = new NE_TipoFactura();

            string columna = "";

            if (txt_patron.Text != string.Empty)
            {
                if (rb_n_TipoFactura.Checked == true)
                    columna = rb_n_TipoFactura.Text;

                grid_TipoFactura.Cargar(usu.BuscarTipoFactura(txt_patron.Text, columna));
                if (grid_TipoFactura.Rows.Count == 0)
                    MessageBox.Show("No se encontró ningún Tipo de Factura", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_id_TipoFactura.Text != string.Empty)
            {
                grid_TipoFactura.Cargar(usu.BuscarTipoFactura(txt_id_TipoFactura.Text));
                if (grid_TipoFactura.Rows.Count == 0)
                    MessageBox.Show("No se encontró ningúna Factura", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            // btn_buscar.Enabled = false;

        }

        ///ALTA
        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_Alta_TipoFactura frm_alta = new Frm_Alta_TipoFactura();
            frm_alta.ShowDialog();
        }

        ///MODIFICACION
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (grid_TipoFactura.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar Tipo de Factura", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_TipoFactura.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un Tipo de Factura", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            
            Frm_Modificacion_TipoFactura frm_modificacion = new Frm_Modificacion_TipoFactura();
            //frm_modificacion. = grid_TipoFactura.CurrentRow.Cells[0].Value.ToString();
            frm_modificacion.ShowDialog();
        }

        ///BAJA
        private void btn_borrar_Click(object sender, EventArgs e)
        {
            Frm_Baja_TipoFactura frm_baja = new Frm_Baja_TipoFactura();
            frm_baja.ShowDialog();
        }

        ///CONSULTA
        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (grid_TipoFactura.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar usuarios", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_TipoFactura.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un usuario", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Consulta_TipoFactura frm_consulta = new Frm_Consulta_TipoFactura();
            //frm_consulta.id_tipo_factura = grid_TipoFactura.CurrentRow.Cells[0].Value.ToString();
            frm_consulta.ShowDialog();
        }

        ///BORRAR
        private void btn_blan_patron_Click(object sender, EventArgs e)
        {
            this.txt_patron.Text = string.Empty;
            this.txt_id_TipoFactura.Text = string.Empty;
            txt_id_TipoFactura.Enabled = false;
            txt_patron.Enabled = false;
            grid_TipoFactura.Rows.Clear();
        }

        private void rb_n_TipoFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_n_TipoFactura.Checked == true)
            {
                txt_id_TipoFactura.Enabled = false;
                txt_patron.Clear();
                txt_patron.Enabled = true;
            }
        }

        private void rb_id_TipoFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_id_TipoFactura.Checked == true)
            {
                txt_patron.Enabled = false;
                txt_id_TipoFactura.Clear();
                txt_id_TipoFactura.Enabled = true;
            }
        }

        private void txt_patron_Click(object sender, EventArgs e)
        {
            txt_patron.SelectionStart = txt_patron.Text.Length;
        }

        private void txt_id_TipoFactura_Click(object sender, EventArgs e)
        {
            txt_id_TipoFactura.SelectionStart = txt_id_TipoFactura.Text.Length;

        }
    }
}
