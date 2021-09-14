
namespace CLASE05.Formularios.TipoFactura
{
    partial class Frm_ABM_TipoFactura
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid_TipoFactura = new CLASE05.Clases.Grid01();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_blan_patron = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_patron = new System.Windows.Forms.MaskedTextBox();
            this.rb_n_TipoFactura = new System.Windows.Forms.RadioButton();
            this.rb_id_TipoFactura = new System.Windows.Forms.RadioButton();
            this.txt_id_TipoFactura = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_TipoFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_id_TipoFactura);
            this.groupBox1.Controls.Add(this.rb_id_TipoFactura);
            this.groupBox1.Controls.Add(this.rb_n_TipoFactura);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_blan_patron);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_patron);
            this.groupBox1.Controls.SetChildIndex(this.btn_buscar, 0);
            this.groupBox1.Controls.SetChildIndex(this.txt_patron, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.btn_blan_patron, 0);
            this.groupBox1.Controls.SetChildIndex(this.label4, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_n_TipoFactura, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_id_TipoFactura, 0);
            this.groupBox1.Controls.SetChildIndex(this.txt_id_TipoFactura, 0);
            this.groupBox1.Controls.SetChildIndex(this.label3, 0);
            // 
            // btn_buscar
            // 
            this.toolTip1.SetToolTip(this.btn_buscar, "Realizar Busqueda");
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_alta
            // 
            this.btn_alta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.BorderSize = 0;
            this.btn_alta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.toolTip1.SetToolTip(this.btn_alta, "Permite Ingresar al Formulario de Altas de Tipos de Factura");
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.toolTip1.SetToolTip(this.btn_modificar, "Permite ingresar al Formulario de Modificación de Tipos de Factura");
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.FlatAppearance.BorderSize = 0;
            this.btn_borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.toolTip1.SetToolTip(this.btn_borrar, "Permite ingresar al formulario de bajas de Tipos de Factura");
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Size = new System.Drawing.Size(239, 31);
            this.label1.Text = "TIPOS DE FACTURA";
            // 
            // btn_consultar
            // 
            this.btn_consultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.FlatAppearance.BorderSize = 0;
            this.btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.toolTip1.SetToolTip(this.btn_consultar, "Permite ingresar al Formulario de Consultas de Tipos de Factura\r\n");
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(632, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(562, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(597, 2);
            // 
            // grid_TipoFactura
            // 
            this.grid_TipoFactura._formatoLetraHeader = System.Drawing.FontStyle.Bold;
            this.grid_TipoFactura._tamannoLetraHeader = 9;
            this.grid_TipoFactura.AllowUserToAddRows = false;
            this.grid_TipoFactura.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_TipoFactura.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_TipoFactura.BackgroundColor = System.Drawing.Color.Silver;
            this.grid_TipoFactura.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.grid_TipoFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_TipoFactura.Location = new System.Drawing.Point(12, 200);
            this.grid_TipoFactura.Name = "grid_TipoFactura";
            this.grid_TipoFactura.ReadOnly = true;
            this.grid_TipoFactura.Size = new System.Drawing.Size(645, 184);
            this.grid_TipoFactura.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Buscar por:";
            // 
            // btn_blan_patron
            // 
            this.btn_blan_patron.BackColor = System.Drawing.Color.Transparent;
            this.btn_blan_patron.BackgroundImage = global::CLASE05.Properties.Resources.btn_eliminar__7_;
            this.btn_blan_patron.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_blan_patron.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_blan_patron.FlatAppearance.BorderSize = 0;
            this.btn_blan_patron.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_blan_patron.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_blan_patron.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_blan_patron.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_blan_patron.Location = new System.Drawing.Point(275, 26);
            this.btn_blan_patron.Name = "btn_blan_patron";
            this.btn_blan_patron.Size = new System.Drawing.Size(36, 35);
            this.btn_blan_patron.TabIndex = 25;
            this.btn_blan_patron.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_blan_patron, "Limpiar Filtros");
            this.btn_blan_patron.UseVisualStyleBackColor = false;
            this.btn_blan_patron.Click += new System.EventHandler(this.btn_blan_patron_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Patrón de Búsqueda";
            // 
            // txt_patron
            // 
            this.txt_patron.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_patron.Enabled = false;
            this.txt_patron.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patron.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_patron.Location = new System.Drawing.Point(142, 34);
            this.txt_patron.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.txt_patron.Name = "txt_patron";
            this.txt_patron.Size = new System.Drawing.Size(129, 25);
            this.txt_patron.TabIndex = 20;
            // 
            // rb_n_TipoFactura
            // 
            this.rb_n_TipoFactura.AutoSize = true;
            this.rb_n_TipoFactura.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_n_TipoFactura.Location = new System.Drawing.Point(357, 59);
            this.rb_n_TipoFactura.Name = "rb_n_TipoFactura";
            this.rb_n_TipoFactura.Size = new System.Drawing.Size(126, 21);
            this.rb_n_TipoFactura.TabIndex = 29;
            this.rb_n_TipoFactura.TabStop = true;
            this.rb_n_TipoFactura.Text = "Nombre Factura";
            this.rb_n_TipoFactura.UseVisualStyleBackColor = true;
            // 
            // rb_id_TipoFactura
            // 
            this.rb_id_TipoFactura.AutoSize = true;
            this.rb_id_TipoFactura.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_id_TipoFactura.Location = new System.Drawing.Point(357, 34);
            this.rb_id_TipoFactura.Name = "rb_id_TipoFactura";
            this.rb_id_TipoFactura.Size = new System.Drawing.Size(138, 21);
            this.rb_id_TipoFactura.TabIndex = 30;
            this.rb_id_TipoFactura.TabStop = true;
            this.rb_id_TipoFactura.Text = "ID Tipo de Factura";
            this.rb_id_TipoFactura.UseVisualStyleBackColor = true;
            // 
            // txt_id_TipoFactura
            // 
            this.txt_id_TipoFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_id_TipoFactura.Enabled = false;
            this.txt_id_TipoFactura.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_TipoFactura.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txt_id_TipoFactura.Location = new System.Drawing.Point(142, 65);
            this.txt_id_TipoFactura.Mask = "99999";
            this.txt_id_TipoFactura.Name = "txt_id_TipoFactura";
            this.txt_id_TipoFactura.Size = new System.Drawing.Size(48, 25);
            this.txt_id_TipoFactura.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "ID Tipo de Factura";
            // 
            // Frm_ABM_TipoFactura
            // 
            this._PosiciónVisible = true;
            this._titulo = "TIPOS DE FACTURA";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 439);
            this.Controls.Add(this.grid_TipoFactura);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_ABM_TipoFactura";
            this.Text = "Frm_TipoFactura";
            this.Load += new System.EventHandler(this.Frm_ABM_TipoFactura_Load);
            this.Controls.SetChildIndex(this.grid_TipoFactura, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btn_alta, 0);
            this.Controls.SetChildIndex(this.btn_modificar, 0);
            this.Controls.SetChildIndex(this.btn_borrar, 0);
            this.Controls.SetChildIndex(this.btn_consultar, 0);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_TipoFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.Grid01 grid_TipoFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_blan_patron;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_patron;
        private System.Windows.Forms.RadioButton rb_n_TipoFactura;
        private System.Windows.Forms.RadioButton rb_id_TipoFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txt_id_TipoFactura;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}