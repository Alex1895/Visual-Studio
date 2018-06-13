namespace Sistema
{
    partial class FRM_Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Login));
            this.BTN_Entrar = new System.Windows.Forms.Button();
            this.BTN_Salir = new System.Windows.Forms.Button();
            this.LBL_Usuario = new System.Windows.Forms.Label();
            this.LBL_Contraseña = new System.Windows.Forms.Label();
            this.TXT_Usuario = new System.Windows.Forms.TextBox();
            this.TXT_Contraseña = new System.Windows.Forms.TextBox();
            this.PAN_Login = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PAN_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Entrar
            // 
            this.BTN_Entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Entrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_Entrar.Location = new System.Drawing.Point(24, 196);
            this.BTN_Entrar.Name = "BTN_Entrar";
            this.BTN_Entrar.Size = new System.Drawing.Size(79, 27);
            this.BTN_Entrar.TabIndex = 0;
            this.BTN_Entrar.Text = "Entrar";
            this.BTN_Entrar.UseVisualStyleBackColor = true;
            this.BTN_Entrar.Click += new System.EventHandler(this.BTN_Entrar_Click);
            // 
            // BTN_Salir
            // 
            this.BTN_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Salir.Location = new System.Drawing.Point(152, 196);
            this.BTN_Salir.Name = "BTN_Salir";
            this.BTN_Salir.Size = new System.Drawing.Size(81, 27);
            this.BTN_Salir.TabIndex = 1;
            this.BTN_Salir.Text = "Salir";
            this.BTN_Salir.UseVisualStyleBackColor = true;
            this.BTN_Salir.Click += new System.EventHandler(this.BTN_Salir_Click);
            // 
            // LBL_Usuario
            // 
            this.LBL_Usuario.AutoSize = true;
            this.LBL_Usuario.BackColor = System.Drawing.SystemColors.Control;
            this.LBL_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Usuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LBL_Usuario.Location = new System.Drawing.Point(105, 42);
            this.LBL_Usuario.Name = "LBL_Usuario";
            this.LBL_Usuario.Size = new System.Drawing.Size(62, 16);
            this.LBL_Usuario.TabIndex = 2;
            this.LBL_Usuario.Text = "Usuario";
            // 
            // LBL_Contraseña
            // 
            this.LBL_Contraseña.AutoSize = true;
            this.LBL_Contraseña.BackColor = System.Drawing.SystemColors.Control;
            this.LBL_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Contraseña.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LBL_Contraseña.Location = new System.Drawing.Point(93, 122);
            this.LBL_Contraseña.Name = "LBL_Contraseña";
            this.LBL_Contraseña.Size = new System.Drawing.Size(87, 16);
            this.LBL_Contraseña.TabIndex = 3;
            this.LBL_Contraseña.Text = "Contraseña";
            // 
            // TXT_Usuario
            // 
            this.TXT_Usuario.Location = new System.Drawing.Point(36, 73);
            this.TXT_Usuario.Name = "TXT_Usuario";
            this.TXT_Usuario.Size = new System.Drawing.Size(197, 20);
            this.TXT_Usuario.TabIndex = 4;
            // 
            // TXT_Contraseña
            // 
            this.TXT_Contraseña.Location = new System.Drawing.Point(36, 151);
            this.TXT_Contraseña.Name = "TXT_Contraseña";
            this.TXT_Contraseña.PasswordChar = '*';
            this.TXT_Contraseña.Size = new System.Drawing.Size(197, 20);
            this.TXT_Contraseña.TabIndex = 5;
            // 
            // PAN_Login
            // 
            this.PAN_Login.BackColor = System.Drawing.SystemColors.Control;
            this.PAN_Login.Controls.Add(this.TXT_Contraseña);
            this.PAN_Login.Controls.Add(this.TXT_Usuario);
            this.PAN_Login.Controls.Add(this.LBL_Contraseña);
            this.PAN_Login.Controls.Add(this.LBL_Usuario);
            this.PAN_Login.Controls.Add(this.BTN_Salir);
            this.PAN_Login.Controls.Add(this.BTN_Entrar);
            this.PAN_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PAN_Login.Location = new System.Drawing.Point(0, 0);
            this.PAN_Login.Name = "PAN_Login";
            this.PAN_Login.Size = new System.Drawing.Size(272, 235);
            this.PAN_Login.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FRM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 235);
            this.Controls.Add(this.PAN_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.PAN_Login.ResumeLayout(false);
            this.PAN_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Entrar;
        private System.Windows.Forms.Button BTN_Salir;
        private System.Windows.Forms.Label LBL_Usuario;
        private System.Windows.Forms.Label LBL_Contraseña;
        private System.Windows.Forms.TextBox TXT_Usuario;
        private System.Windows.Forms.TextBox TXT_Contraseña;
        private System.Windows.Forms.Panel PAN_Login;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

