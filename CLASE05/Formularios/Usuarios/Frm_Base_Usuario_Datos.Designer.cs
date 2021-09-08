namespace CLASE05.Formularios.Usuarios
{
    partial class Frm_Base_Usuario_Datos
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
            this.txt_id_usuario = new CLASE05.Clases.LabelText02();
            this.txt_n_usuario = new CLASE05.Clases.LabelText02();
            this.txt_password = new CLASE05.Clases.LabelText02();
            this.cmb_perfiles = new CLASE05.Clases.ComboBox01();
            this.txt_email = new CLASE05.Clases.LabelText02();
            this.txt_apellido = new CLASE05.Clases.LabelText02();
            this.txt_nombres = new CLASE05.Clases.LabelText02();
            this.txt_cuil = new CLASE05.Clases.LabelText02();
            this.cmb_estadosUsuarios = new CLASE05.Clases.ComboBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(383, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(313, 2);
            this.btn_minimizar.Visible = false;
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(348, 2);
            this.btn_maximizar.Visible = false;
            // 
            // txt_id_usuario
            // 
            this.txt_id_usuario._Ancho = 2;
            this.txt_id_usuario._Decimales = 0;
            this.txt_id_usuario._Etiqueta = "Id Usuario";
            this.txt_id_usuario._Mask = "99";
            this.txt_id_usuario._MensajeError = null;
            this.txt_id_usuario._Nombre_campo = "id_usuario";
            this.txt_id_usuario._Nombre_tabla = null;
            this.txt_id_usuario._ReadOnly = false;
            this.txt_id_usuario._Text = "";
            this.txt_id_usuario._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_id_usuario._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_id_usuario._Validable = false;
            this.txt_id_usuario.BackColor = System.Drawing.Color.Transparent;
            this.txt_id_usuario.Enabled = false;
            this.txt_id_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_usuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_id_usuario.Location = new System.Drawing.Point(13, 81);
            this.txt_id_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_usuario.Name = "txt_id_usuario";
            this.txt_id_usuario.Size = new System.Drawing.Size(181, 28);
            this.txt_id_usuario.TabIndex = 0;
            // 
            // txt_n_usuario
            // 
            this.txt_n_usuario._Ancho = 30;
            this.txt_n_usuario._Decimales = 2;
            this.txt_n_usuario._Etiqueta = "Nombre Usuario";
            this.txt_n_usuario._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_n_usuario._MensajeError = "El nombre del usuario está vácio";
            this.txt_n_usuario._Nombre_campo = "n_usuario";
            this.txt_n_usuario._Nombre_tabla = null;
            this.txt_n_usuario._ReadOnly = false;
            this.txt_n_usuario._Text = "";
            this.txt_n_usuario._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_n_usuario._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_n_usuario._Validable = true;
            this.txt_n_usuario.BackColor = System.Drawing.Color.Transparent;
            this.txt_n_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n_usuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_n_usuario.Location = new System.Drawing.Point(13, 108);
            this.txt_n_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_n_usuario.Name = "txt_n_usuario";
            this.txt_n_usuario.Size = new System.Drawing.Size(374, 28);
            this.txt_n_usuario.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password._Ancho = 10;
            this.txt_password._Decimales = 2;
            this.txt_password._Etiqueta = "Password";
            this.txt_password._Mask = "CCCCCCCCCC";
            this.txt_password._MensajeError = "El password esta vácio";
            this.txt_password._Nombre_campo = null;
            this.txt_password._Nombre_tabla = null;
            this.txt_password._ReadOnly = false;
            this.txt_password._Text = "";
            this.txt_password._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_password._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_password._Validable = true;
            this.txt_password.BackColor = System.Drawing.Color.Transparent;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_password.Location = new System.Drawing.Point(13, 135);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(228, 28);
            this.txt_password.TabIndex = 2;
            // 
            // cmb_perfiles
            // 
            this.cmb_perfiles._ComboSinSeleccion = true;
            this.cmb_perfiles._MensajeError = "Falta seleccionar el perfil";
            this.cmb_perfiles._Nombre_campo = null;
            this.cmb_perfiles._Nombre_tabla = null;
            this.cmb_perfiles._tabla_cargar_combo = "perfiles";
            this.cmb_perfiles._tabla_cargar_descriptor = "nombre";
            this.cmb_perfiles._tabla_cargar_pk = "id_perfil";
            this.cmb_perfiles._Validable = true;
            this.cmb_perfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cmb_perfiles.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.cmb_perfiles.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmb_perfiles.FormattingEnabled = true;
            this.cmb_perfiles.Location = new System.Drawing.Point(166, 166);
            this.cmb_perfiles.Name = "cmb_perfiles";
            this.cmb_perfiles.Size = new System.Drawing.Size(165, 25);
            this.cmb_perfiles.TabIndex = 3;
            // 
            // txt_email
            // 
            this.txt_email._Ancho = 40;
            this.txt_email._Decimales = 2;
            this.txt_email._Etiqueta = "Correo Electrónico";
            this.txt_email._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_email._MensajeError = "El correo electrónico está vácio";
            this.txt_email._Nombre_campo = "email";
            this.txt_email._Nombre_tabla = null;
            this.txt_email._ReadOnly = false;
            this.txt_email._Text = "";
            this.txt_email._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_email._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_email._Validable = true;
            this.txt_email.BackColor = System.Drawing.Color.Transparent;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_email.Location = new System.Drawing.Point(13, 194);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(374, 28);
            this.txt_email.TabIndex = 4;
            // 
            // txt_apellido
            // 
            this.txt_apellido._Ancho = 30;
            this.txt_apellido._Decimales = 2;
            this.txt_apellido._Etiqueta = "Apellido";
            this.txt_apellido._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_apellido._MensajeError = "El apellido está vácio";
            this.txt_apellido._Nombre_campo = "apellido";
            this.txt_apellido._Nombre_tabla = null;
            this.txt_apellido._ReadOnly = false;
            this.txt_apellido._Text = "";
            this.txt_apellido._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_apellido._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_apellido._Validable = true;
            this.txt_apellido.BackColor = System.Drawing.Color.Transparent;
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_apellido.Location = new System.Drawing.Point(13, 224);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(374, 28);
            this.txt_apellido.TabIndex = 5;
            // 
            // txt_nombres
            // 
            this.txt_nombres._Ancho = 30;
            this.txt_nombres._Decimales = 2;
            this.txt_nombres._Etiqueta = "Nombres";
            this.txt_nombres._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_nombres._MensajeError = "El nombre está vácio";
            this.txt_nombres._Nombre_campo = "nombres";
            this.txt_nombres._Nombre_tabla = null;
            this.txt_nombres._ReadOnly = false;
            this.txt_nombres._Text = "";
            this.txt_nombres._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_nombres._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_nombres._Validable = true;
            this.txt_nombres.BackColor = System.Drawing.Color.Transparent;
            this.txt_nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombres.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_nombres.Location = new System.Drawing.Point(13, 253);
            this.txt_nombres.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(374, 28);
            this.txt_nombres.TabIndex = 6;
            // 
            // txt_cuil
            // 
            this.txt_cuil._Ancho = 11;
            this.txt_cuil._Decimales = 2;
            this.txt_cuil._Etiqueta = "CUIL";
            this.txt_cuil._Mask = "99-99999999-9";
            this.txt_cuil._MensajeError = "Falta el CUIL";
            this.txt_cuil._Nombre_campo = null;
            this.txt_cuil._Nombre_tabla = null;
            this.txt_cuil._ReadOnly = false;
            this.txt_cuil._Text = "";
            this.txt_cuil._TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txt_cuil._TipoDato = CLASE05.Clases.LabelText02.TipoDato.mascaraEditada;
            this.txt_cuil._Validable = true;
            this.txt_cuil.BackColor = System.Drawing.Color.Transparent;
            this.txt_cuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuil.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_cuil.Location = new System.Drawing.Point(13, 282);
            this.txt_cuil.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cuil.Name = "txt_cuil";
            this.txt_cuil.Size = new System.Drawing.Size(249, 28);
            this.txt_cuil.TabIndex = 7;
            // 
            // cmb_estadosUsuarios
            // 
            this.cmb_estadosUsuarios._ComboSinSeleccion = true;
            this.cmb_estadosUsuarios._MensajeError = "Falta la selección de Estado Usuario";
            this.cmb_estadosUsuarios._Nombre_campo = null;
            this.cmb_estadosUsuarios._Nombre_tabla = null;
            this.cmb_estadosUsuarios._tabla_cargar_combo = "estadosusuarios";
            this.cmb_estadosUsuarios._tabla_cargar_descriptor = "n_estado_usuario";
            this.cmb_estadosUsuarios._tabla_cargar_pk = "id_estado_usuario";
            this.cmb_estadosUsuarios._Validable = true;
            this.cmb_estadosUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cmb_estadosUsuarios.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.cmb_estadosUsuarios.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmb_estadosUsuarios.FormattingEnabled = true;
            this.cmb_estadosUsuarios.Location = new System.Drawing.Point(165, 313);
            this.cmb_estadosUsuarios.Name = "cmb_estadosUsuarios";
            this.cmb_estadosUsuarios.Size = new System.Drawing.Size(166, 25);
            this.cmb_estadosUsuarios.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(114, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Perfil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(48, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Estado Usuario";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.Silver;
            this.lbl_titulo.Location = new System.Drawing.Point(57, 20);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(81, 31);
            this.lbl_titulo.TabIndex = 12;
            this.lbl_titulo.Text = "Titulo";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_aceptar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_aceptar.Location = new System.Drawing.Point(158, 372);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(95, 31);
            this.btn_aceptar.TabIndex = 9;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            // 
            // Frm_Base_Usuario_Datos
            // 
            this._FormularioMovil = true;
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(420, 415);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_estadosUsuarios);
            this.Controls.Add(this.txt_cuil);
            this.Controls.Add(this.txt_nombres);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.cmb_perfiles);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_n_usuario);
            this.Controls.Add(this.txt_id_usuario);
            this.Location = new System.Drawing.Point(310, 126);
            this.Name = "Frm_Base_Usuario_Datos";
            this.Load += new System.EventHandler(this.Frm_Usuario_Load);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.txt_id_usuario, 0);
            this.Controls.SetChildIndex(this.txt_n_usuario, 0);
            this.Controls.SetChildIndex(this.txt_password, 0);
            this.Controls.SetChildIndex(this.cmb_perfiles, 0);
            this.Controls.SetChildIndex(this.txt_email, 0);
            this.Controls.SetChildIndex(this.txt_apellido, 0);
            this.Controls.SetChildIndex(this.txt_nombres, 0);
            this.Controls.SetChildIndex(this.txt_cuil, 0);
            this.Controls.SetChildIndex(this.cmb_estadosUsuarios, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.Controls.SetChildIndex(this.btn_aceptar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_aceptar;
        public System.Windows.Forms.Label lbl_titulo;
        public Clases.ComboBox01 cmb_perfiles;
        public Clases.LabelText02 txt_id_usuario;
        public Clases.LabelText02 txt_n_usuario;
        public Clases.LabelText02 txt_password;
        public Clases.LabelText02 txt_email;
        public Clases.LabelText02 txt_apellido;
        public Clases.LabelText02 txt_nombres;
        public Clases.LabelText02 txt_cuil;
        public Clases.ComboBox01 cmb_estadosUsuarios;
    }
}
