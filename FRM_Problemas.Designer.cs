namespace Sistema
{
    partial class FRM_Problemas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Problemas));
            this.BRR_Superior = new System.Windows.Forms.ToolStrip();
            this.BTM_Regresar = new System.Windows.Forms.ToolStripButton();
            this.BTN_Salir = new System.Windows.Forms.ToolStripButton();
            this.Visual_Datos = new System.Windows.Forms.DataGridView();
            this.BRR_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Visual_Datos)).BeginInit();
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
            this.BRR_Superior.Size = new System.Drawing.Size(452, 25);
            this.BRR_Superior.TabIndex = 79;
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
            // Visual_Datos
            // 
            this.Visual_Datos.AllowUserToAddRows = false;
            this.Visual_Datos.AllowUserToDeleteRows = false;
            this.Visual_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Visual_Datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Visual_Datos.Location = new System.Drawing.Point(0, 25);
            this.Visual_Datos.Name = "Visual_Datos";
            this.Visual_Datos.ReadOnly = true;
            this.Visual_Datos.Size = new System.Drawing.Size(452, 340);
            this.Visual_Datos.TabIndex = 80;
            // 
            // FRM_Problemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 365);
            this.Controls.Add(this.Visual_Datos);
            this.Controls.Add(this.BRR_Superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Problemas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Problemas";
            this.BRR_Superior.ResumeLayout(false);
            this.BRR_Superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Visual_Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip BRR_Superior;
        private System.Windows.Forms.ToolStripButton BTM_Regresar;
        private System.Windows.Forms.ToolStripButton BTN_Salir;
        private System.Windows.Forms.DataGridView Visual_Datos;
    }
}