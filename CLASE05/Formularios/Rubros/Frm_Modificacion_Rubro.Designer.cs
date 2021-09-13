
namespace CLASE05.Formularios.Rubros
{
    partial class Frm_Modificacion_Rubro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_n_Rubro_viejo = new CLASE05.Clases.LabelText02();
            this.txt_n_Rubro_nuevo = new CLASE05.Clases.LabelText02();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(395, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(325, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(360, 2);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_n_Rubro_viejo);
            this.panel1.Controls.Add(this.txt_n_Rubro_nuevo);
            this.panel1.Controls.Add(this.btn_aceptar);
            this.panel1.Location = new System.Drawing.Point(10, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 288);
            this.panel1.TabIndex = 32;
            // 
            // txt_n_Rubro_viejo
            // 
            this.txt_n_Rubro_viejo._Ancho = 30;
            this.txt_n_Rubro_viejo._Decimales = 2;
            this.txt_n_Rubro_viejo._Etiqueta = "Nombre Rubro Ant.";
            this.txt_n_Rubro_viejo._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_n_Rubro_viejo._MensajeError = "El nombre del rubro está vácio";
            this.txt_n_Rubro_viejo._Nombre_campo = "n_rubro";
            this.txt_n_Rubro_viejo._Nombre_tabla = null;
            this.txt_n_Rubro_viejo._ReadOnly = false;
            this.txt_n_Rubro_viejo._Text = "";
            this.txt_n_Rubro_viejo._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_n_Rubro_viejo._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_n_Rubro_viejo._Validable = true;
            this.txt_n_Rubro_viejo.BackColor = System.Drawing.Color.Transparent;
            this.txt_n_Rubro_viejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n_Rubro_viejo.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_n_Rubro_viejo.Location = new System.Drawing.Point(-1, 34);
            this.txt_n_Rubro_viejo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_n_Rubro_viejo.Name = "txt_n_Rubro_viejo";
            this.txt_n_Rubro_viejo.Size = new System.Drawing.Size(353, 53);
            this.txt_n_Rubro_viejo.TabIndex = 23;
            // 
            // txt_n_Rubro_nuevo
            // 
            this.txt_n_Rubro_nuevo._Ancho = 30;
            this.txt_n_Rubro_nuevo._Decimales = 2;
            this.txt_n_Rubro_nuevo._Etiqueta = "Nombre Rubro New.";
            this.txt_n_Rubro_nuevo._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_n_Rubro_nuevo._MensajeError = "El nombre del rubro está vácio";
            this.txt_n_Rubro_nuevo._Nombre_campo = "n_rubro";
            this.txt_n_Rubro_nuevo._Nombre_tabla = null;
            this.txt_n_Rubro_nuevo._ReadOnly = false;
            this.txt_n_Rubro_nuevo._Text = "";
            this.txt_n_Rubro_nuevo._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_n_Rubro_nuevo._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_n_Rubro_nuevo._Validable = true;
            this.txt_n_Rubro_nuevo.BackColor = System.Drawing.Color.Transparent;
            this.txt_n_Rubro_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n_Rubro_nuevo.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_n_Rubro_nuevo.Location = new System.Drawing.Point(0, 95);
            this.txt_n_Rubro_nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_n_Rubro_nuevo.Name = "txt_n_Rubro_nuevo";
            this.txt_n_Rubro_nuevo.Size = new System.Drawing.Size(353, 53);
            this.txt_n_Rubro_nuevo.TabIndex = 14;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_aceptar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_aceptar.Location = new System.Drawing.Point(156, 238);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(95, 31);
            this.btn_aceptar.TabIndex = 22;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(5, 38);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(216, 31);
            this.lbl_titulo.TabIndex = 31;
            this.lbl_titulo.Text = "Actualizar Rubros";
            // 
            // Frm_Modificacion_Rubro
            // 
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 384);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Frm_Modificacion_Rubro";
            this.Text = "Frm_Modificacion_Rubro";
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public Clases.LabelText02 txt_n_Rubro_viejo;
        public Clases.LabelText02 txt_n_Rubro_nuevo;
        public System.Windows.Forms.Button btn_aceptar;
        public System.Windows.Forms.Label lbl_titulo;
    }
}