using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASE05.Clases
{
    public partial class LabelText01 : UserControl
    {

        public string _Etiqueta
        {
            get { return lblEtiqueta.Text; }
            set { lblEtiqueta.Text = value; }
        }
        public bool _Validable { get; set; }
        public string _Nombre_campo { get; set; }
        public string _Nombre_tabla { get; set; }
        public string _MensajeError { get; set; }
        public string _Mask
        {
            get { return TxtDato.Mask; }
            set { TxtDato.Mask = value; }
        }
        public string _Text
        {
            get { return TxtDato.Text; }
            set { TxtDato.Text = value; }
        }

        public bool _ReadOnly
        {
            get => TxtDato.ReadOnly;
            set => TxtDato.ReadOnly = value;
        }
        //
        public LabelText01()
        {
            InitializeComponent();
        }

        private void TxtDato_Click(object sender, EventArgs e)
        {
            TxtDato.SelectionStart = TxtDato.Text.Length;
            //TxtDato.SelectionLength = 0;
        }

        private void LabelText01_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled == false)
            {
                this.Enabled = true;
                TxtDato.Enabled = false;
                lblEtiqueta.Enabled = true;
            }
        }
    }
}
