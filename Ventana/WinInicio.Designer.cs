namespace Ventana
{
    partial class WinInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinInicio));
            this.PNLTop = new System.Windows.Forms.Panel();
            this.BTNMin = new System.Windows.Forms.PictureBox();
            this.BTNClose = new System.Windows.Forms.PictureBox();
            this.TXBMostrar = new System.Windows.Forms.TextBox();
            this.BTNCargar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PNLTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTNMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNClose)).BeginInit();
            this.SuspendLayout();
            // 
            // PNLTop
            // 
            this.PNLTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.PNLTop.Controls.Add(this.BTNMin);
            this.PNLTop.Controls.Add(this.BTNClose);
            this.PNLTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNLTop.Location = new System.Drawing.Point(0, 0);
            this.PNLTop.Name = "PNLTop";
            this.PNLTop.Size = new System.Drawing.Size(800, 25);
            this.PNLTop.TabIndex = 0;
            this.PNLTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PNLTop_MouseDown);
            // 
            // BTNMin
            // 
            this.BTNMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNMin.Image = ((System.Drawing.Image)(resources.GetObject("BTNMin.Image")));
            this.BTNMin.Location = new System.Drawing.Point(749, 3);
            this.BTNMin.Name = "BTNMin";
            this.BTNMin.Size = new System.Drawing.Size(21, 21);
            this.BTNMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTNMin.TabIndex = 1;
            this.BTNMin.TabStop = false;
            this.BTNMin.Click += new System.EventHandler(this.BTNMin_Click);
            // 
            // BTNClose
            // 
            this.BTNClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNClose.Image = ((System.Drawing.Image)(resources.GetObject("BTNClose.Image")));
            this.BTNClose.Location = new System.Drawing.Point(776, 3);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(21, 21);
            this.BTNClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTNClose.TabIndex = 0;
            this.BTNClose.TabStop = false;
            this.BTNClose.Click += new System.EventHandler(this.BTNClose_Click);
            // 
            // TXBMostrar
            // 
            this.TXBMostrar.Location = new System.Drawing.Point(148, 42);
            this.TXBMostrar.Multiline = true;
            this.TXBMostrar.Name = "TXBMostrar";
            this.TXBMostrar.ReadOnly = true;
            this.TXBMostrar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBMostrar.Size = new System.Drawing.Size(640, 396);
            this.TXBMostrar.TabIndex = 1;
            // 
            // BTNCargar
            // 
            this.BTNCargar.Location = new System.Drawing.Point(12, 42);
            this.BTNCargar.Name = "BTNCargar";
            this.BTNCargar.Size = new System.Drawing.Size(130, 23);
            this.BTNCargar.TabIndex = 2;
            this.BTNCargar.Text = "Cargar";
            this.BTNCargar.UseVisualStyleBackColor = true;
            this.BTNCargar.Click += new System.EventHandler(this.BTNCargar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // WinInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNCargar);
            this.Controls.Add(this.TXBMostrar);
            this.Controls.Add(this.PNLTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WinInicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.WinInicio_Load);
            this.PNLTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BTNMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PNLTop;
        private System.Windows.Forms.PictureBox BTNMin;
        private System.Windows.Forms.PictureBox BTNClose;
        private System.Windows.Forms.TextBox TXBMostrar;
        private System.Windows.Forms.Button BTNCargar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

