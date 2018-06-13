namespace Sistema
{
    partial class FRM_Incidentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Incidentes));
            this.Visual_Datos = new System.Windows.Forms.DataGridView();
            this.BRR_Superior = new System.Windows.Forms.ToolStrip();
            this.BTM_Regresar = new System.Windows.Forms.ToolStripButton();
            this.BTN_Salir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.Visual_Datos)).BeginInit();
            this.BRR_Superior.SuspendLayout();
            this.SuspendLayout();
            // 
            // Visual_Datos
            // 
            this.Visual_Datos.AllowUserToAddRows = false;
            this.Visual_Datos.AllowUserToDeleteRows = false;
            this.Visual_Datos.AllowUserToOrderColumns = true;
            this.Visual_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Visual_Datos.Location = new System.Drawing.Point(12, 40);
            this.Visual_Datos.Name = "Visual_Datos";
            this.Visual_Datos.ReadOnly = true;
            this.Visual_Datos.Size = new System.Drawing.Size(556, 266);
            this.Visual_Datos.TabIndex = 0;
            // 
            // BRR_Superior
            // 
            this.BRR_Superior.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BRR_Superior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTM_Regresar,
            this.BTN_Salir});
            this.BRR_Superior.Location = new System.Drawing.Point(0, 0);
            this.BRR_Superior.Name = "BRR_Superior";
            this.BRR_Superior.Size = new System.Drawing.Size(580, 25);
            this.BRR_Superior.TabIndex = 78;
            this.BRR_Superior.Text = "toolStrip1";
            // 
            // BTM_Regresar
            // 
            this.BTM_Regresar.BackColor = System.Drawing.Color.Transparent;
            this.BTM_Regresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTM_Regresar.Image = global::Sistema.Properties.Resources._60710;
            this.BTM_Regresar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTM_Regresar.Name = "BTM_Regresar";
            this.BTM_Regresar.Size = new System.Drawing.Size(72, 22);
            this.BTM_Regresar.Text = "Regresar";
            this.BTM_Regresar.Click += new System.EventHandler(this.BTM_Regresar_Click);
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
            // FRM_Incidentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 325);
            this.Controls.Add(this.BRR_Superior);
            this.Controls.Add(this.Visual_Datos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Incidentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Incidentes";
            ((System.ComponentModel.ISupportInitialize)(this.Visual_Datos)).EndInit();
            this.BRR_Superior.ResumeLayout(false);
            this.BRR_Superior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Visual_Datos;
        private System.Windows.Forms.ToolStrip BRR_Superior;
        private System.Windows.Forms.ToolStripButton BTM_Regresar;
        private System.Windows.Forms.ToolStripButton BTN_Salir;

    }
}