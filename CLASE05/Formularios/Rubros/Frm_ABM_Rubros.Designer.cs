
namespace CLASE05.Formularios.Rubros
{
    partial class Frm_ABM_Rubros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid_Rubros = new CLASE05.Clases.Grid01();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_blan_patron = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_patron = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id_Rubro = new System.Windows.Forms.MaskedTextBox();
            this.rb_id_Rubro = new System.Windows.Forms.RadioButton();
            this.rb_n_Rubro = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Rubros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_id_Rubro);
            this.groupBox1.Controls.Add(this.rb_id_Rubro);
            this.groupBox1.Controls.Add(this.rb_n_Rubro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_blan_patron);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_patron);
            this.groupBox1.Controls.SetChildIndex(this.btn_buscar, 0);
            this.groupBox1.Controls.SetChildIndex(this.txt_patron, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.btn_blan_patron, 0);
            this.groupBox1.Controls.SetChildIndex(this.label4, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_n_Rubro, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_id_Rubro, 0);
            this.groupBox1.Controls.SetChildIndex(this.txt_id_Rubro, 0);
            this.groupBox1.Controls.SetChildIndex(this.label3, 0);
            // 
            // btn_buscar
            // 
            this.toolTip1.SetToolTip(this.btn_buscar, "Realizar Busqueda");
            // 
            // btn_alta
            // 
            this.btn_alta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.BorderSize = 0;
            this.btn_alta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.toolTip1.SetToolTip(this.btn_alta, "Permite Ingresar al Formulario de Altas de Rubros\r\n");
            // 
            // btn_modificar
            // 
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.toolTip1.SetToolTip(this.btn_modificar, "Permite ingresar al Formulario de Modificación de Rubros");
            // 
            // btn_borrar
            // 
            this.btn_borrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.FlatAppearance.BorderSize = 0;
            this.btn_borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.toolTip1.SetToolTip(this.btn_borrar, "Permite ingresar al formulario de bajas de Rubros");
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.Text = "RUBROS";
            // 
            // btn_consultar
            // 
            this.btn_consultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.FlatAppearance.BorderSize = 0;
            this.btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.toolTip1.SetToolTip(this.btn_consultar, "Permite ingresar al Formulario de Consultas de Rubros\r\n");
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            // 
            // grid_Rubros
            // 
            this.grid_Rubros._formatoLetraHeader = System.Drawing.FontStyle.Bold;
            this.grid_Rubros._tamannoLetraHeader = 9;
            this.grid_Rubros.AllowUserToAddRows = false;
            this.grid_Rubros.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_Rubros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_Rubros.BackgroundColor = System.Drawing.Color.Silver;
            this.grid_Rubros.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.grid_Rubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Rubros.Location = new System.Drawing.Point(12, 199);
            this.grid_Rubros.Name = "grid_Rubros";
            this.grid_Rubros.ReadOnly = true;
            this.grid_Rubros.Size = new System.Drawing.Size(645, 184);
            this.grid_Rubros.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 32;
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
            this.btn_blan_patron.Location = new System.Drawing.Point(274, 24);
            this.btn_blan_patron.Name = "btn_blan_patron";
            this.btn_blan_patron.Size = new System.Drawing.Size(36, 35);
            this.btn_blan_patron.TabIndex = 31;
            this.btn_blan_patron.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_blan_patron, "Limpiar Filtros");
            this.btn_blan_patron.UseVisualStyleBackColor = false;
            this.btn_blan_patron.Click += new System.EventHandler(this.btn_blan_patron_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Patrón de Búsqueda";
            // 
            // txt_patron
            // 
            this.txt_patron.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_patron.Enabled = false;
            this.txt_patron.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patron.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_patron.Location = new System.Drawing.Point(141, 32);
            this.txt_patron.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.txt_patron.Name = "txt_patron";
            this.txt_patron.Size = new System.Drawing.Size(129, 25);
            this.txt_patron.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "ID Rubro";
            // 
            // txt_id_Rubro
            // 
            this.txt_id_Rubro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_id_Rubro.Enabled = false;
            this.txt_id_Rubro.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_Rubro.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txt_id_Rubro.Location = new System.Drawing.Point(141, 62);
            this.txt_id_Rubro.Mask = "99999";
            this.txt_id_Rubro.Name = "txt_id_Rubro";
            this.txt_id_Rubro.Size = new System.Drawing.Size(48, 25);
            this.txt_id_Rubro.TabIndex = 35;
            // 
            // rb_id_Rubro
            // 
            this.rb_id_Rubro.AutoSize = true;
            this.rb_id_Rubro.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_id_Rubro.Location = new System.Drawing.Point(356, 31);
            this.rb_id_Rubro.Name = "rb_id_Rubro";
            this.rb_id_Rubro.Size = new System.Drawing.Size(81, 21);
            this.rb_id_Rubro.TabIndex = 34;
            this.rb_id_Rubro.TabStop = true;
            this.rb_id_Rubro.Text = "ID Rubro";
            this.rb_id_Rubro.UseVisualStyleBackColor = true;
            // 
            // rb_n_Rubro
            // 
            this.rb_n_Rubro.AutoSize = true;
            this.rb_n_Rubro.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_n_Rubro.Location = new System.Drawing.Point(356, 56);
            this.rb_n_Rubro.Name = "rb_n_Rubro";
            this.rb_n_Rubro.Size = new System.Drawing.Size(118, 21);
            this.rb_n_Rubro.TabIndex = 33;
            this.rb_n_Rubro.TabStop = true;
            this.rb_n_Rubro.Text = "Nombre Rubro";
            this.rb_n_Rubro.UseVisualStyleBackColor = true;
            // 
            // Frm_ABM_Rubros
            // 
            this._PosiciónVisible = true;
            this._titulo = "RUBROS";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 439);
            this.Controls.Add(this.grid_Rubros);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_ABM_Rubros";
            this.Text = "Frm_ABM_Rubros";
            this.Load += new System.EventHandler(this.Frm_ABM_Rubros_Load);
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
            this.Controls.SetChildIndex(this.grid_Rubros, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Rubros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.Grid01 grid_Rubros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_blan_patron;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_patron;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txt_id_Rubro;
        private System.Windows.Forms.RadioButton rb_id_Rubro;
        private System.Windows.Forms.RadioButton rb_n_Rubro;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}