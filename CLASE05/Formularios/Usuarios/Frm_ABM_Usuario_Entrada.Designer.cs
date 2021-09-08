namespace CLASE05.Formularios.Usuarios
{
    partial class Frm_ABM_Usuario_Entrada
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid_usuarios = new CLASE05.Clases.Grid01();
            this.txt_patron = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id_usuario = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_blan_patron = new System.Windows.Forms.Button();
            this.rb_nombres = new System.Windows.Forms.RadioButton();
            this.rb_apellido = new System.Windows.Forms.RadioButton();
            this.rb_n_usuario = new System.Windows.Forms.RadioButton();
            this.rb_id_usuario = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rb_id_usuario);
            this.groupBox1.Controls.Add(this.rb_nombres);
            this.groupBox1.Controls.Add(this.btn_blan_patron);
            this.groupBox1.Controls.Add(this.rb_apellido);
            this.groupBox1.Controls.Add(this.rb_n_usuario);
            this.groupBox1.Controls.Add(this.txt_id_usuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_patron);
            this.groupBox1.Location = new System.Drawing.Point(13, 71);
            this.groupBox1.Size = new System.Drawing.Size(642, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Controls.SetChildIndex(this.btn_buscar, 0);
            this.groupBox1.Controls.SetChildIndex(this.txt_patron, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.txt_id_usuario, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_n_usuario, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_apellido, 0);
            this.groupBox1.Controls.SetChildIndex(this.btn_blan_patron, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_nombres, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_id_usuario, 0);
            this.groupBox1.Controls.SetChildIndex(this.label4, 0);
            // 
            // btn_buscar
            // 
            this.btn_buscar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_buscar.Location = new System.Drawing.Point(557, 90);
            this.btn_buscar.Size = new System.Drawing.Size(79, 27);
            this.btn_buscar.TabIndex = 5;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_alta
            // 
            this.btn_alta.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_alta.FlatAppearance.BorderSize = 0;
            this.btn_alta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.TabIndex = 7;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.TabIndex = 8;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackgroundImage = global::CLASE05.Properties.Resources.btn_eliminar__2_;
            this.btn_borrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_borrar.FlatAppearance.BorderSize = 0;
            this.btn_borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.TabIndex = 9;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(164, 31);
            this.label1.Text = "ABM Usuario";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(627, 4);
            this.btn_cerrar.TabStop = false;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(557, 4);
            this.btn_minimizar.TabStop = false;
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(592, 4);
            this.btn_maximizar.TabStop = false;
            // 
            // grid_usuarios
            // 
            this.grid_usuarios._formatoLetraHeader = System.Drawing.FontStyle.Bold;
            this.grid_usuarios._tamannoLetraHeader = 9;
            this.grid_usuarios.AllowUserToAddRows = false;
            this.grid_usuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_usuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_usuarios.BackgroundColor = System.Drawing.Color.Silver;
            this.grid_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_usuarios.Location = new System.Drawing.Point(13, 204);
            this.grid_usuarios.Name = "grid_usuarios";
            this.grid_usuarios.ReadOnly = true;
            this.grid_usuarios.Size = new System.Drawing.Size(642, 178);
            this.grid_usuarios.TabIndex = 6;
            // 
            // txt_patron
            // 
            this.txt_patron.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_patron.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patron.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_patron.Location = new System.Drawing.Point(142, 47);
            this.txt_patron.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.txt_patron.Name = "txt_patron";
            this.txt_patron.Size = new System.Drawing.Size(129, 25);
            this.txt_patron.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txt_patron, "Escriba un patrón de búsqueda que tenga que ver con la selección del tipo de búsq" +
        "ueda");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patrón de Búsqueda";
            // 
            // txt_id_usuario
            // 
            this.txt_id_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_id_usuario.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_usuario.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txt_id_usuario.Location = new System.Drawing.Point(142, 85);
            this.txt_id_usuario.Mask = "99999";
            this.txt_id_usuario.Name = "txt_id_usuario";
            this.txt_id_usuario.Size = new System.Drawing.Size(43, 25);
            this.txt_id_usuario.TabIndex = 4;
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
            this.btn_blan_patron.Location = new System.Drawing.Point(275, 39);
            this.btn_blan_patron.Name = "btn_blan_patron";
            this.btn_blan_patron.Size = new System.Drawing.Size(36, 35);
            this.btn_blan_patron.TabIndex = 8;
            this.btn_blan_patron.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_blan_patron, "Limpiar el patrón de búsqueda");
            this.btn_blan_patron.UseVisualStyleBackColor = false;
            this.btn_blan_patron.Click += new System.EventHandler(this.btn_blan_patron_Click);
            // 
            // rb_nombres
            // 
            this.rb_nombres.AutoSize = true;
            this.rb_nombres.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_nombres.Location = new System.Drawing.Point(538, 53);
            this.rb_nombres.Name = "rb_nombres";
            this.rb_nombres.Size = new System.Drawing.Size(80, 21);
            this.rb_nombres.TabIndex = 3;
            this.rb_nombres.TabStop = true;
            this.rb_nombres.Text = "nombres";
            this.rb_nombres.UseVisualStyleBackColor = true;
            this.rb_nombres.CheckedChanged += new System.EventHandler(this.rb_nombres_CheckedChanged);
            // 
            // rb_apellido
            // 
            this.rb_apellido.AutoSize = true;
            this.rb_apellido.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_apellido.Location = new System.Drawing.Point(451, 53);
            this.rb_apellido.Name = "rb_apellido";
            this.rb_apellido.Size = new System.Drawing.Size(76, 21);
            this.rb_apellido.TabIndex = 2;
            this.rb_apellido.TabStop = true;
            this.rb_apellido.Text = "apellido";
            this.rb_apellido.UseVisualStyleBackColor = true;
            this.rb_apellido.CheckedChanged += new System.EventHandler(this.rb_apellido_CheckedChanged);
            // 
            // rb_n_usuario
            // 
            this.rb_n_usuario.AutoSize = true;
            this.rb_n_usuario.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_n_usuario.Location = new System.Drawing.Point(358, 53);
            this.rb_n_usuario.Name = "rb_n_usuario";
            this.rb_n_usuario.Size = new System.Drawing.Size(86, 21);
            this.rb_n_usuario.TabIndex = 1;
            this.rb_n_usuario.TabStop = true;
            this.rb_n_usuario.Text = "n_usuario";
            this.rb_n_usuario.UseVisualStyleBackColor = true;
            this.rb_n_usuario.CheckedChanged += new System.EventHandler(this.rb_n_usuario_CheckedChanged);
            // 
            // rb_id_usuario
            // 
            this.rb_id_usuario.AutoSize = true;
            this.rb_id_usuario.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_id_usuario.Location = new System.Drawing.Point(46, 86);
            this.rb_id_usuario.Name = "rb_id_usuario";
            this.rb_id_usuario.Size = new System.Drawing.Size(90, 21);
            this.rb_id_usuario.TabIndex = 4;
            this.rb_id_usuario.TabStop = true;
            this.rb_id_usuario.Text = "id_usuario";
            this.rb_id_usuario.UseVisualStyleBackColor = true;
            this.rb_id_usuario.CheckedChanged += new System.EventHandler(this.rb_id_usuario_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Buscar por:";
            // 
            // Frm_ABM_Usuario_Entrada
            // 
            this._PosiciónVisible = true;
            this._titulo = "ABM Usuario";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(666, 440);
            this.Controls.Add(this.grid_usuarios);
            this.Location = new System.Drawing.Point(32, 58);
            this.Name = "Frm_ABM_Usuario_Entrada";
            this.Load += new System.EventHandler(this.Frm_ABM_Usuario_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btn_alta, 0);
            this.Controls.SetChildIndex(this.btn_modificar, 0);
            this.Controls.SetChildIndex(this.btn_borrar, 0);
            this.Controls.SetChildIndex(this.grid_usuarios, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.Grid01 grid_usuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_patron;
        private System.Windows.Forms.MaskedTextBox txt_id_usuario;
        private System.Windows.Forms.RadioButton rb_nombres;
        private System.Windows.Forms.RadioButton rb_apellido;
        private System.Windows.Forms.RadioButton rb_n_usuario;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_blan_patron;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_id_usuario;
    }
}
