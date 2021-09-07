namespace CLASE05.Formularios.Usuarios
{
    partial class Frm_Usuario_Modificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Usuario_Modificaciones));
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Size = new System.Drawing.Size(308, 29);
            this.lbl_titulo.Text = "Modificación de Usuarios";
            // 
            // cmb_perfiles
            // 
            this.cmb_perfiles.DisplayMember = "nombre";
            this.cmb_perfiles.ValueMember = "id_perfil";
            // 
            // cmb_estadosUsuarios
            // 
            this.cmb_estadosUsuarios.DisplayMember = "n_estado_usuario";
            this.cmb_estadosUsuarios.ValueMember = "id_estado_usuario";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderSize = 0;
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderSize = 0;
            // 
            // Frm_Usuario_Modificaciones
            // 
            this._PosiciónVisible = true;
            this._Titulo = "Modificación de Usuarios";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(420, 415);
            this.Location = new System.Drawing.Point(512, 161);
            this.Name = "Frm_Usuario_Modificaciones";
            this.Load += new System.EventHandler(this.Frm_Usuario_Modificaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
