namespace Sistema
{
    partial class FRM_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Principal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTN_Salir = new System.Windows.Forms.ToolStripButton();
            this.BTN_Cerrar_Sesion = new System.Windows.Forms.ToolStripButton();
            this.LBL_usuario = new System.Windows.Forms.ToolStripLabel();
            this.Reportes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BTN_Int = new System.Windows.Forms.Button();
            this.BTN_RFC = new System.Windows.Forms.Button();
            this.BTN_Problemas = new System.Windows.Forms.Button();
            this.BTN_Incidentes = new System.Windows.Forms.Button();
            this.BTN_Reportes = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_Salir,
            this.BTN_Cerrar_Sesion,
            this.LBL_usuario});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(336, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BTN_Salir
            // 
            this.BTN_Salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BTN_Salir.Image = global::Sistema.Properties.Resources._32178;
            this.BTN_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_Salir.Name = "BTN_Salir";
            this.BTN_Salir.Size = new System.Drawing.Size(49, 22);
            this.BTN_Salir.Text = "Salir";
            this.BTN_Salir.Click += new System.EventHandler(this.BTN_Salir_Click);
            // 
            // BTN_Cerrar_Sesion
            // 
            this.BTN_Cerrar_Sesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_Cerrar_Sesion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Cerrar_Sesion.Image = global::Sistema.Properties.Resources._73432;
            this.BTN_Cerrar_Sesion.ImageTransparentColor = System.Drawing.Color.White;
            this.BTN_Cerrar_Sesion.Name = "BTN_Cerrar_Sesion";
            this.BTN_Cerrar_Sesion.Size = new System.Drawing.Size(108, 22);
            this.BTN_Cerrar_Sesion.Text = "Cerrar sesion";
            this.BTN_Cerrar_Sesion.Click += new System.EventHandler(this.BTN_Cerrar_Sesion_Click);
            // 
            // LBL_usuario
            // 
            this.LBL_usuario.Name = "LBL_usuario";
            this.LBL_usuario.Size = new System.Drawing.Size(19, 22);
            this.LBL_usuario.Text = "00";
            this.LBL_usuario.TextChanged += new System.EventHandler(this.LBL_usuario_TextChanged);
            // 
            // Reportes
            // 
            this.Reportes.Location = new System.Drawing.Point(236, 41);
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(58, 23);
            this.Reportes.TabIndex = 6;
            this.Reportes.Text = "Reportes";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(39, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuarios";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(236, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Zonas";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(42, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Capturista";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(39, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Incidentes";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(236, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Problemas";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(141, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "RFC";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(136, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Interacciones";
            // 
            // BTN_Int
            // 
            this.BTN_Int.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Int.Image = global::Sistema.Properties.Resources._48643;
            this.BTN_Int.Location = new System.Drawing.Point(136, 159);
            this.BTN_Int.Name = "BTN_Int";
            this.BTN_Int.Size = new System.Drawing.Size(59, 56);
            this.BTN_Int.TabIndex = 16;
            this.BTN_Int.UseVisualStyleBackColor = false;
            this.BTN_Int.Click += new System.EventHandler(this.BTN_Int_Click);
            // 
            // BTN_RFC
            // 
            this.BTN_RFC.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_RFC.Image = global::Sistema.Properties.Resources._66720;
            this.BTN_RFC.Location = new System.Drawing.Point(144, 266);
            this.BTN_RFC.Name = "BTN_RFC";
            this.BTN_RFC.Size = new System.Drawing.Size(54, 60);
            this.BTN_RFC.TabIndex = 14;
            this.BTN_RFC.UseVisualStyleBackColor = false;
            this.BTN_RFC.Click += new System.EventHandler(this.BTN_RFC_Click);
            // 
            // BTN_Problemas
            // 
            this.BTN_Problemas.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Problemas.Image = global::Sistema.Properties.Resources._13826;
            this.BTN_Problemas.Location = new System.Drawing.Point(239, 266);
            this.BTN_Problemas.Name = "BTN_Problemas";
            this.BTN_Problemas.Size = new System.Drawing.Size(54, 60);
            this.BTN_Problemas.TabIndex = 12;
            this.BTN_Problemas.UseVisualStyleBackColor = false;
            this.BTN_Problemas.Click += new System.EventHandler(this.BTN_Problemas_Click);
            // 
            // BTN_Incidentes
            // 
            this.BTN_Incidentes.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Incidentes.Image = global::Sistema.Properties.Resources._1626;
            this.BTN_Incidentes.Location = new System.Drawing.Point(42, 266);
            this.BTN_Incidentes.Name = "BTN_Incidentes";
            this.BTN_Incidentes.Size = new System.Drawing.Size(54, 60);
            this.BTN_Incidentes.TabIndex = 10;
            this.BTN_Incidentes.UseVisualStyleBackColor = false;
            this.BTN_Incidentes.Click += new System.EventHandler(this.BTN_Incidentes_Click);
            // 
            // BTN_Reportes
            // 
            this.BTN_Reportes.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Reportes.Image = global::Sistema.Properties.Resources._40386;
            this.BTN_Reportes.Location = new System.Drawing.Point(236, 67);
            this.BTN_Reportes.Name = "BTN_Reportes";
            this.BTN_Reportes.Size = new System.Drawing.Size(58, 65);
            this.BTN_Reportes.TabIndex = 5;
            this.BTN_Reportes.UseVisualStyleBackColor = false;
            this.BTN_Reportes.Click += new System.EventHandler(this.BTN_Reportes_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Image = global::Sistema.Properties.Resources._48277;
            this.button4.Location = new System.Drawing.Point(236, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 56);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Image = global::Sistema.Properties.Resources._13759;
            this.button3.Location = new System.Drawing.Point(42, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 60);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::Sistema.Properties.Resources._1326;
            this.button1.Location = new System.Drawing.Point(42, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 56);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FRM_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(336, 338);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BTN_Int);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BTN_RFC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTN_Problemas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTN_Incidentes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reportes);
            this.Controls.Add(this.BTN_Reportes);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FRM_Principal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Reportes;

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BTN_Salir;
        private System.Windows.Forms.ToolStripButton BTN_Cerrar_Sesion;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button BTN_Reportes;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button BTN_Incidentes;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button BTN_Problemas;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button BTN_RFC;
        public System.Windows.Forms.ToolStripLabel LBL_usuario;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button BTN_Int;
    }
}