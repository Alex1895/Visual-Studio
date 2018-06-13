namespace Sistema
{
    partial class FRM_Usuarioos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Usuarioos));
            this.BRR_Superior = new System.Windows.Forms.ToolStrip();
            this.BTM_Regresar = new System.Windows.Forms.ToolStripButton();
            this.BTN_Salir = new System.Windows.Forms.ToolStripButton();
            this.BTN_Nuevo = new System.Windows.Forms.Button();
            this.BTN_Editar = new System.Windows.Forms.Button();
            this.BTN_Eliminar = new System.Windows.Forms.Button();
            this.BTN_Guardar = new System.Windows.Forms.Button();
            this.LBL_Usuario = new System.Windows.Forms.Label();
            this.LBL_Contra = new System.Windows.Forms.Label();
            this.LBL_Nombre = new System.Windows.Forms.Label();
            this.LBL_Ape = new System.Windows.Forms.Label();
            this.LBL_TipUsu = new System.Windows.Forms.Label();
            this.TXT_Usuario = new System.Windows.Forms.TextBox();
            this.TXT_Contra = new System.Windows.Forms.TextBox();
            this.TXT_Ape = new System.Windows.Forms.TextBox();
            this.CMB_TipUsu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_Ape2 = new System.Windows.Forms.TextBox();
            this.TXT_Nombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BRR_Superior.SuspendLayout();
            this.SuspendLayout();
            // 
            // BRR_Superior
            // 
            this.BRR_Superior.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BRR_Superior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTM_Regresar,
            this.BTN_Salir});
            this.BRR_Superior.Location = new System.Drawing.Point(0, 0);
            this.BRR_Superior.Name = "BRR_Superior";
            this.BRR_Superior.Size = new System.Drawing.Size(599, 25);
            this.BRR_Superior.TabIndex = 2;
            this.BRR_Superior.Text = "toolStrip1";
            this.BRR_Superior.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.BRR_SuperiorItemClicked);
            // 
            // BTM_Regresar
            // 
            this.BTM_Regresar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTM_Regresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTM_Regresar.Image = global::Sistema.Properties.Resources._60710;
            this.BTM_Regresar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTM_Regresar.Name = "BTM_Regresar";
            this.BTM_Regresar.Size = new System.Drawing.Size(77, 22);
            this.BTM_Regresar.Text = "Regresar";
            this.BTM_Regresar.Click += new System.EventHandler(this.BTM_RegresarClick);
            // 
            // BTN_Salir
            // 
            this.BTN_Salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BTN_Salir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Salir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_Salir.Image = global::Sistema.Properties.Resources._32178;
            this.BTN_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_Salir.Name = "BTN_Salir";
            this.BTN_Salir.Size = new System.Drawing.Size(51, 22);
            this.BTN_Salir.Text = "Salir";
            this.BTN_Salir.Click += new System.EventHandler(this.BTN_SalirClick);
            // 
            // BTN_Nuevo
            // 
            this.BTN_Nuevo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_Nuevo.Location = new System.Drawing.Point(12, 264);
            this.BTN_Nuevo.Name = "BTN_Nuevo";
            this.BTN_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.BTN_Nuevo.TabIndex = 3;
            this.BTN_Nuevo.Text = "Nuevo";
            this.BTN_Nuevo.UseVisualStyleBackColor = false;
            this.BTN_Nuevo.Click += new System.EventHandler(this.BTN_NuevoClick);
            // 
            // BTN_Editar
            // 
            this.BTN_Editar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_Editar.Location = new System.Drawing.Point(93, 264);
            this.BTN_Editar.Name = "BTN_Editar";
            this.BTN_Editar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Editar.TabIndex = 4;
            this.BTN_Editar.Text = "Editar";
            this.BTN_Editar.UseVisualStyleBackColor = false;
            this.BTN_Editar.Click += new System.EventHandler(this.BTN_EditarClick);
            // 
            // BTN_Eliminar
            // 
            this.BTN_Eliminar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_Eliminar.Location = new System.Drawing.Point(174, 264);
            this.BTN_Eliminar.Name = "BTN_Eliminar";
            this.BTN_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Eliminar.TabIndex = 5;
            this.BTN_Eliminar.Text = "Eliminar";
            this.BTN_Eliminar.UseVisualStyleBackColor = false;
            this.BTN_Eliminar.Click += new System.EventHandler(this.BTN_EliminarClick);
            // 
            // BTN_Guardar
            // 
            this.BTN_Guardar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_Guardar.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Guardar.Location = new System.Drawing.Point(255, 264);
            this.BTN_Guardar.Name = "BTN_Guardar";
            this.BTN_Guardar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Guardar.TabIndex = 6;
            this.BTN_Guardar.Text = "Guardar";
            this.BTN_Guardar.UseVisualStyleBackColor = false;
            this.BTN_Guardar.Click += new System.EventHandler(this.BTN_GuardarClick);
            // 
            // LBL_Usuario
            // 
            this.LBL_Usuario.AutoSize = true;
            this.LBL_Usuario.BackColor = System.Drawing.SystemColors.Control;
            this.LBL_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Usuario.ForeColor = System.Drawing.Color.Black;
            this.LBL_Usuario.Location = new System.Drawing.Point(9, 94);
            this.LBL_Usuario.Name = "LBL_Usuario";
            this.LBL_Usuario.Size = new System.Drawing.Size(50, 13);
            this.LBL_Usuario.TabIndex = 76;
            this.LBL_Usuario.Text = "Usuario";
            // 
            // LBL_Contra
            // 
            this.LBL_Contra.AutoSize = true;
            this.LBL_Contra.BackColor = System.Drawing.SystemColors.Control;
            this.LBL_Contra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Contra.ForeColor = System.Drawing.Color.Black;
            this.LBL_Contra.Location = new System.Drawing.Point(9, 118);
            this.LBL_Contra.Name = "LBL_Contra";
            this.LBL_Contra.Size = new System.Drawing.Size(71, 13);
            this.LBL_Contra.TabIndex = 77;
            this.LBL_Contra.Text = "Contraseña";
            this.LBL_Contra.Click += new System.EventHandler(this.LBL_ContraClick);
            // 
            // LBL_Nombre
            // 
            this.LBL_Nombre.AutoSize = true;
            this.LBL_Nombre.BackColor = System.Drawing.SystemColors.Control;
            this.LBL_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Nombre.ForeColor = System.Drawing.Color.Black;
            this.LBL_Nombre.Location = new System.Drawing.Point(12, 170);
            this.LBL_Nombre.Name = "LBL_Nombre";
            this.LBL_Nombre.Size = new System.Drawing.Size(64, 13);
            this.LBL_Nombre.TabIndex = 78;
            this.LBL_Nombre.Text = "Nombre(s)";
            // 
            // LBL_Ape
            // 
            this.LBL_Ape.AutoSize = true;
            this.LBL_Ape.BackColor = System.Drawing.SystemColors.Control;
            this.LBL_Ape.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Ape.ForeColor = System.Drawing.Color.Black;
            this.LBL_Ape.Location = new System.Drawing.Point(12, 196);
            this.LBL_Ape.Name = "LBL_Ape";
            this.LBL_Ape.Size = new System.Drawing.Size(100, 13);
            this.LBL_Ape.TabIndex = 79;
            this.LBL_Ape.Text = "Apellido Paterno";
            // 
            // LBL_TipUsu
            // 
            this.LBL_TipUsu.AutoSize = true;
            this.LBL_TipUsu.BackColor = System.Drawing.SystemColors.Control;
            this.LBL_TipUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TipUsu.ForeColor = System.Drawing.Color.Black;
            this.LBL_TipUsu.Location = new System.Drawing.Point(314, 86);
            this.LBL_TipUsu.Name = "LBL_TipUsu";
            this.LBL_TipUsu.Size = new System.Drawing.Size(95, 13);
            this.LBL_TipUsu.TabIndex = 80;
            this.LBL_TipUsu.Text = "Tipo de usuario";
            this.LBL_TipUsu.Click += new System.EventHandler(this.LBL_TipUsuClick);
            // 
            // TXT_Usuario
            // 
            this.TXT_Usuario.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TXT_Usuario.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TXT_Usuario.Location = new System.Drawing.Point(127, 92);
            this.TXT_Usuario.Name = "TXT_Usuario";
            this.TXT_Usuario.Size = new System.Drawing.Size(100, 20);
            this.TXT_Usuario.TabIndex = 81;
            // 
            // TXT_Contra
            // 
            this.TXT_Contra.Location = new System.Drawing.Point(127, 118);
            this.TXT_Contra.Name = "TXT_Contra";
            this.TXT_Contra.PasswordChar = '*';
            this.TXT_Contra.Size = new System.Drawing.Size(100, 20);
            this.TXT_Contra.TabIndex = 82;
            this.TXT_Contra.TextChanged += new System.EventHandler(this.TXT_ContraTextChanged);
            // 
            // TXT_Ape
            // 
            this.TXT_Ape.Location = new System.Drawing.Point(127, 193);
            this.TXT_Ape.Name = "TXT_Ape";
            this.TXT_Ape.Size = new System.Drawing.Size(100, 20);
            this.TXT_Ape.TabIndex = 84;
            // 
            // CMB_TipUsu
            // 
            this.CMB_TipUsu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CMB_TipUsu.FormattingEnabled = true;
            this.CMB_TipUsu.Items.AddRange(new object[] {
            "ADMIN",
            "CAPTURISTA"});
            this.CMB_TipUsu.Location = new System.Drawing.Point(415, 86);
            this.CMB_TipUsu.Name = "CMB_TipUsu";
            this.CMB_TipUsu.Size = new System.Drawing.Size(100, 21);
            this.CMB_TipUsu.TabIndex = 85;
            this.CMB_TipUsu.SelectedIndexChanged += new System.EventHandler(this.CMB_TipUsu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 86;
            this.label1.Text = "Apellido Materno";
            this.label1.Click += new System.EventHandler(this.Label1Click);
            // 
            // TXT_Ape2
            // 
            this.TXT_Ape2.Location = new System.Drawing.Point(127, 219);
            this.TXT_Ape2.Name = "TXT_Ape2";
            this.TXT_Ape2.Size = new System.Drawing.Size(100, 20);
            this.TXT_Ape2.TabIndex = 87;
            this.TXT_Ape2.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
            // 
            // TXT_Nombre
            // 
            this.TXT_Nombre.Location = new System.Drawing.Point(127, 167);
            this.TXT_Nombre.Name = "TXT_Nombre";
            this.TXT_Nombre.Size = new System.Drawing.Size(100, 20);
            this.TXT_Nombre.TabIndex = 83;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(336, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 89;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 91;
            this.label2.Text = "Validar Contraseña\r\n  ";
            this.label2.Click += new System.EventHandler(this.Label2Click);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(415, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 92;
            this.label3.Text = "* Campo Obligatorio";
            // 
            // FRM_Usuarioos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(599, 298);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TXT_Ape2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CMB_TipUsu);
            this.Controls.Add(this.TXT_Ape);
            this.Controls.Add(this.TXT_Nombre);
            this.Controls.Add(this.TXT_Contra);
            this.Controls.Add(this.TXT_Usuario);
            this.Controls.Add(this.LBL_TipUsu);
            this.Controls.Add(this.LBL_Ape);
            this.Controls.Add(this.LBL_Nombre);
            this.Controls.Add(this.LBL_Contra);
            this.Controls.Add(this.LBL_Usuario);
            this.Controls.Add(this.BTN_Guardar);
            this.Controls.Add(this.BTN_Eliminar);
            this.Controls.Add(this.BTN_Editar);
            this.Controls.Add(this.BTN_Nuevo);
            this.Controls.Add(this.BRR_Superior);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Usuarioos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Usuarios";
            this.Load += new System.EventHandler(this.FRM_UsuariosLoad);
            this.BRR_Superior.ResumeLayout(false);
            this.BRR_Superior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TXT_Ape2;
        private System.Windows.Forms.Label label1;

        #endregion

        private System.Windows.Forms.ToolStrip BRR_Superior;
        private System.Windows.Forms.ToolStripButton BTM_Regresar;
        private System.Windows.Forms.ToolStripButton BTN_Salir;
        private System.Windows.Forms.Button BTN_Nuevo;
        private System.Windows.Forms.Button BTN_Editar;
        private System.Windows.Forms.Button BTN_Eliminar;
        private System.Windows.Forms.Button BTN_Guardar;
        private System.Windows.Forms.Label LBL_Usuario;
        private System.Windows.Forms.Label LBL_Contra;
        private System.Windows.Forms.Label LBL_Nombre;
        private System.Windows.Forms.Label LBL_Ape;
        private System.Windows.Forms.Label LBL_TipUsu;
        private System.Windows.Forms.TextBox TXT_Usuario;
        private System.Windows.Forms.TextBox TXT_Contra;
        private System.Windows.Forms.TextBox TXT_Nombre;
        private System.Windows.Forms.TextBox TXT_Ape;
        private System.Windows.Forms.ComboBox CMB_TipUsu;


        
        
        
        void LBL_TipUsuClick(object sender, System.EventArgs e)
        {
        	
        }
        
        void BRR_SuperiorItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {

        }
    }
}