
namespace CLASE05.Formularios.InicioSistema
{
    partial class Frm_Log
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
            this.gb_login = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.flowLayoutPanel_contraseña = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_usuario = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.gb_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_login
            // 
            this.gb_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.gb_login.Controls.Add(this.label1);
            this.gb_login.Controls.Add(this.label3);
            this.gb_login.Controls.Add(this.btn_Login);
            this.gb_login.Controls.Add(this.flowLayoutPanel_contraseña);
            this.gb_login.Controls.Add(this.flowLayoutPanel_usuario);
            this.gb_login.Controls.Add(this.txt_clave);
            this.gb_login.Controls.Add(this.txt_usuario);
            this.gb_login.Controls.Add(this.lbl_Contraseña);
            this.gb_login.Controls.Add(this.lbl_Usuario);
            this.gb_login.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_login.Location = new System.Drawing.Point(1, 26);
            this.gb_login.Name = "gb_login";
            this.gb_login.Size = new System.Drawing.Size(555, 210);
            this.gb_login.TabIndex = 0;
            this.gb_login.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(236, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "User Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(110, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "______________________________________________";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Login.Location = new System.Drawing.Point(181, 152);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(236, 37);
            this.btn_Login.TabIndex = 7;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // flowLayoutPanel_contraseña
            // 
            this.flowLayoutPanel_contraseña.BackgroundImage = global::CLASE05.Properties.Resources.images;
            this.flowLayoutPanel_contraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel_contraseña.Location = new System.Drawing.Point(423, 107);
            this.flowLayoutPanel_contraseña.Name = "flowLayoutPanel_contraseña";
            this.flowLayoutPanel_contraseña.Size = new System.Drawing.Size(26, 29);
            this.flowLayoutPanel_contraseña.TabIndex = 5;
            // 
            // flowLayoutPanel_usuario
            // 
            this.flowLayoutPanel_usuario.BackgroundImage = global::CLASE05.Properties.Resources.images__1_;
            this.flowLayoutPanel_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel_usuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel_usuario.Location = new System.Drawing.Point(423, 58);
            this.flowLayoutPanel_usuario.Name = "flowLayoutPanel_usuario";
            this.flowLayoutPanel_usuario.Size = new System.Drawing.Size(26, 27);
            this.flowLayoutPanel_usuario.TabIndex = 4;
            // 
            // txt_clave
            // 
            this.txt_clave.AcceptsTab = true;
            this.txt_clave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_clave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_clave.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.txt_clave.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txt_clave.Location = new System.Drawing.Point(181, 107);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.PasswordChar = '*';
            this.txt_clave.Size = new System.Drawing.Size(236, 29);
            this.txt_clave.TabIndex = 2;
            this.txt_clave.UseSystemPasswordChar = true;
            // 
            // txt_usuario
            // 
            this.txt_usuario.AcceptsTab = true;
            this.txt_usuario.AccessibleDescription = "";
            this.txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F);
            this.txt_usuario.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txt_usuario.Location = new System.Drawing.Point(181, 58);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(236, 27);
            this.txt_usuario.TabIndex = 1;
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Contraseña.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Contraseña.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Contraseña.Location = new System.Drawing.Point(91, 109);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(84, 21);
            this.lbl_Contraseña.TabIndex = 1;
            this.lbl_Contraseña.Text = "Password";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Usuario.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Usuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Usuario.Location = new System.Drawing.Point(91, 59);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(88, 21);
            this.lbl_Usuario.TabIndex = 0;
            this.lbl_Usuario.Text = "Username";
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_salir.Location = new System.Drawing.Point(532, 1);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(24, 25);
            this.btn_salir.TabIndex = 10;
            this.btn_salir.Text = "X";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Frm_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(557, 237);
            this.Controls.Add(this.gb_login);
            this.Controls.Add(this.btn_salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Log";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Log";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gb_login.ResumeLayout(false);
            this.gb_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_login;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.Label lbl_Usuario;
        public System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_contraseña;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_usuario;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_salir;
    }
}