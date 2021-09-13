using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASE05.Formularios.Rubros
{
    public partial class Frm_ABM_Rubros : CLASE05.Formularios.FrmBASE.FrmBase_ABM_Entrada
    {
        public Frm_ABM_Rubros()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_Alta_Rubro frm_alta = new Frm_Alta_Rubro();
            frm_alta.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Frm_Modificacion_Rubro frm_modificacion = new Frm_Modificacion_Rubro();
            frm_modificacion.ShowDialog();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            Frm_Baja_Rubro frm_baja = new Frm_Baja_Rubro();
            frm_baja.ShowDialog();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_Consulta_Rubro frm_consulta = new Frm_Consulta_Rubro();
            frm_consulta.ShowDialog();
        }
    }
}
