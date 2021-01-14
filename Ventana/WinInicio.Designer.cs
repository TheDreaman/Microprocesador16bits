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
            this.IMGSiguiente = new System.Windows.Forms.PictureBox();
            this.IMGPlay = new System.Windows.Forms.PictureBox();
            this.TXBAx = new System.Windows.Forms.TextBox();
            this.TXBBx = new System.Windows.Forms.TextBox();
            this.TXBCx = new System.Windows.Forms.TextBox();
            this.TXBDx = new System.Windows.Forms.TextBox();
            this.TXBIP = new System.Windows.Forms.TextBox();
            this.TXBZero = new System.Windows.Forms.TextBox();
            this.TXBCarry = new System.Windows.Forms.TextBox();
            this.TXBOnlyFans = new System.Windows.Forms.TextBox();
            this.LBLAx = new System.Windows.Forms.Label();
            this.LBLBx = new System.Windows.Forms.Label();
            this.LBLCx = new System.Windows.Forms.Label();
            this.LBLDx = new System.Windows.Forms.Label();
            this.LBLIP = new System.Windows.Forms.Label();
            this.LBLZero = new System.Windows.Forms.Label();
            this.LBLCarry = new System.Windows.Forms.Label();
            this.LBLOnlyFans = new System.Windows.Forms.Label();
            this.TXBMBR = new System.Windows.Forms.TextBox();
            this.TXBMAR = new System.Windows.Forms.TextBox();
            this.LBLMAR = new System.Windows.Forms.Label();
            this.LBLMBR = new System.Windows.Forms.Label();
            this.LBLPC = new System.Windows.Forms.Label();
            this.LBLIR = new System.Windows.Forms.Label();
            this.TXBPC = new System.Windows.Forms.TextBox();
            this.TXBIR = new System.Windows.Forms.TextBox();
            this.PNLTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTNMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGPlay)).BeginInit();
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
            this.TXBMostrar.Location = new System.Drawing.Point(193, 42);
            this.TXBMostrar.Multiline = true;
            this.TXBMostrar.Name = "TXBMostrar";
            this.TXBMostrar.ReadOnly = true;
            this.TXBMostrar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBMostrar.Size = new System.Drawing.Size(595, 396);
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
            // IMGSiguiente
            // 
            this.IMGSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IMGSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("IMGSiguiente.Image")));
            this.IMGSiguiente.Location = new System.Drawing.Point(87, 71);
            this.IMGSiguiente.Name = "IMGSiguiente";
            this.IMGSiguiente.Size = new System.Drawing.Size(40, 40);
            this.IMGSiguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IMGSiguiente.TabIndex = 3;
            this.IMGSiguiente.TabStop = false;
            this.IMGSiguiente.Click += new System.EventHandler(this.IMGSiguiente_Click);
            // 
            // IMGPlay
            // 
            this.IMGPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IMGPlay.Image = ((System.Drawing.Image)(resources.GetObject("IMGPlay.Image")));
            this.IMGPlay.Location = new System.Drawing.Point(21, 71);
            this.IMGPlay.Name = "IMGPlay";
            this.IMGPlay.Size = new System.Drawing.Size(40, 40);
            this.IMGPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IMGPlay.TabIndex = 4;
            this.IMGPlay.TabStop = false;
            this.IMGPlay.Click += new System.EventHandler(this.IMGPlay_Click);
            // 
            // TXBAx
            // 
            this.TXBAx.Location = new System.Drawing.Point(87, 133);
            this.TXBAx.Name = "TXBAx";
            this.TXBAx.ReadOnly = true;
            this.TXBAx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBAx.Size = new System.Drawing.Size(69, 20);
            this.TXBAx.TabIndex = 5;
            // 
            // TXBBx
            // 
            this.TXBBx.Location = new System.Drawing.Point(87, 159);
            this.TXBBx.Name = "TXBBx";
            this.TXBBx.ReadOnly = true;
            this.TXBBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBBx.Size = new System.Drawing.Size(69, 20);
            this.TXBBx.TabIndex = 6;
            // 
            // TXBCx
            // 
            this.TXBCx.Location = new System.Drawing.Point(87, 185);
            this.TXBCx.Name = "TXBCx";
            this.TXBCx.ReadOnly = true;
            this.TXBCx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBCx.Size = new System.Drawing.Size(69, 20);
            this.TXBCx.TabIndex = 7;
            // 
            // TXBDx
            // 
            this.TXBDx.Location = new System.Drawing.Point(87, 211);
            this.TXBDx.Name = "TXBDx";
            this.TXBDx.ReadOnly = true;
            this.TXBDx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBDx.Size = new System.Drawing.Size(69, 20);
            this.TXBDx.TabIndex = 8;
            // 
            // TXBIP
            // 
            this.TXBIP.Location = new System.Drawing.Point(87, 237);
            this.TXBIP.Name = "TXBIP";
            this.TXBIP.ReadOnly = true;
            this.TXBIP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBIP.Size = new System.Drawing.Size(69, 20);
            this.TXBIP.TabIndex = 9;
            // 
            // TXBZero
            // 
            this.TXBZero.Location = new System.Drawing.Point(87, 263);
            this.TXBZero.Name = "TXBZero";
            this.TXBZero.ReadOnly = true;
            this.TXBZero.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBZero.Size = new System.Drawing.Size(69, 20);
            this.TXBZero.TabIndex = 10;
            // 
            // TXBCarry
            // 
            this.TXBCarry.Location = new System.Drawing.Point(87, 289);
            this.TXBCarry.Name = "TXBCarry";
            this.TXBCarry.ReadOnly = true;
            this.TXBCarry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBCarry.Size = new System.Drawing.Size(69, 20);
            this.TXBCarry.TabIndex = 11;
            // 
            // TXBOnlyFans
            // 
            this.TXBOnlyFans.Location = new System.Drawing.Point(87, 315);
            this.TXBOnlyFans.Name = "TXBOnlyFans";
            this.TXBOnlyFans.ReadOnly = true;
            this.TXBOnlyFans.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBOnlyFans.Size = new System.Drawing.Size(69, 20);
            this.TXBOnlyFans.TabIndex = 12;
            // 
            // LBLAx
            // 
            this.LBLAx.AutoSize = true;
            this.LBLAx.ForeColor = System.Drawing.Color.White;
            this.LBLAx.Location = new System.Drawing.Point(57, 136);
            this.LBLAx.Name = "LBLAx";
            this.LBLAx.Size = new System.Drawing.Size(24, 13);
            this.LBLAx.TabIndex = 13;
            this.LBLAx.Text = "AX:";
            // 
            // LBLBx
            // 
            this.LBLBx.AutoSize = true;
            this.LBLBx.ForeColor = System.Drawing.Color.White;
            this.LBLBx.Location = new System.Drawing.Point(57, 162);
            this.LBLBx.Name = "LBLBx";
            this.LBLBx.Size = new System.Drawing.Size(24, 13);
            this.LBLBx.TabIndex = 14;
            this.LBLBx.Text = "BX:";
            // 
            // LBLCx
            // 
            this.LBLCx.AutoSize = true;
            this.LBLCx.ForeColor = System.Drawing.Color.White;
            this.LBLCx.Location = new System.Drawing.Point(57, 188);
            this.LBLCx.Name = "LBLCx";
            this.LBLCx.Size = new System.Drawing.Size(24, 13);
            this.LBLCx.TabIndex = 15;
            this.LBLCx.Text = "CX:";
            // 
            // LBLDx
            // 
            this.LBLDx.AutoSize = true;
            this.LBLDx.ForeColor = System.Drawing.Color.White;
            this.LBLDx.Location = new System.Drawing.Point(57, 214);
            this.LBLDx.Name = "LBLDx";
            this.LBLDx.Size = new System.Drawing.Size(25, 13);
            this.LBLDx.TabIndex = 16;
            this.LBLDx.Text = "DX:";
            // 
            // LBLIP
            // 
            this.LBLIP.AutoSize = true;
            this.LBLIP.ForeColor = System.Drawing.Color.White;
            this.LBLIP.Location = new System.Drawing.Point(57, 240);
            this.LBLIP.Name = "LBLIP";
            this.LBLIP.Size = new System.Drawing.Size(20, 13);
            this.LBLIP.TabIndex = 17;
            this.LBLIP.Text = "IP:";
            // 
            // LBLZero
            // 
            this.LBLZero.AutoSize = true;
            this.LBLZero.ForeColor = System.Drawing.Color.White;
            this.LBLZero.Location = new System.Drawing.Point(57, 266);
            this.LBLZero.Name = "LBLZero";
            this.LBLZero.Size = new System.Drawing.Size(17, 13);
            this.LBLZero.TabIndex = 18;
            this.LBLZero.Text = "Z:";
            // 
            // LBLCarry
            // 
            this.LBLCarry.AutoSize = true;
            this.LBLCarry.ForeColor = System.Drawing.Color.White;
            this.LBLCarry.Location = new System.Drawing.Point(57, 292);
            this.LBLCarry.Name = "LBLCarry";
            this.LBLCarry.Size = new System.Drawing.Size(24, 13);
            this.LBLCarry.TabIndex = 19;
            this.LBLCarry.Text = "CY:";
            // 
            // LBLOnlyFans
            // 
            this.LBLOnlyFans.AutoSize = true;
            this.LBLOnlyFans.ForeColor = System.Drawing.Color.White;
            this.LBLOnlyFans.Location = new System.Drawing.Point(57, 318);
            this.LBLOnlyFans.Name = "LBLOnlyFans";
            this.LBLOnlyFans.Size = new System.Drawing.Size(24, 13);
            this.LBLOnlyFans.TabIndex = 20;
            this.LBLOnlyFans.Text = "OF:";
            // 
            // TXBMBR
            // 
            this.TXBMBR.Location = new System.Drawing.Point(58, 365);
            this.TXBMBR.Name = "TXBMBR";
            this.TXBMBR.ReadOnly = true;
            this.TXBMBR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBMBR.Size = new System.Drawing.Size(129, 20);
            this.TXBMBR.TabIndex = 22;
            // 
            // TXBMAR
            // 
            this.TXBMAR.Location = new System.Drawing.Point(58, 339);
            this.TXBMAR.Name = "TXBMAR";
            this.TXBMAR.ReadOnly = true;
            this.TXBMAR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBMAR.Size = new System.Drawing.Size(129, 20);
            this.TXBMAR.TabIndex = 21;
            // 
            // LBLMAR
            // 
            this.LBLMAR.AutoSize = true;
            this.LBLMAR.ForeColor = System.Drawing.Color.White;
            this.LBLMAR.Location = new System.Drawing.Point(9, 342);
            this.LBLMAR.Name = "LBLMAR";
            this.LBLMAR.Size = new System.Drawing.Size(34, 13);
            this.LBLMAR.TabIndex = 23;
            this.LBLMAR.Text = "MAR:";
            // 
            // LBLMBR
            // 
            this.LBLMBR.AutoSize = true;
            this.LBLMBR.ForeColor = System.Drawing.Color.White;
            this.LBLMBR.Location = new System.Drawing.Point(18, 368);
            this.LBLMBR.Name = "LBLMBR";
            this.LBLMBR.Size = new System.Drawing.Size(34, 13);
            this.LBLMBR.TabIndex = 24;
            this.LBLMBR.Text = "MBR:";
            // 
            // LBLPC
            // 
            this.LBLPC.AutoSize = true;
            this.LBLPC.ForeColor = System.Drawing.Color.White;
            this.LBLPC.Location = new System.Drawing.Point(24, 394);
            this.LBLPC.Name = "LBLPC";
            this.LBLPC.Size = new System.Drawing.Size(24, 13);
            this.LBLPC.TabIndex = 25;
            this.LBLPC.Text = "PC:";
            // 
            // LBLIR
            // 
            this.LBLIR.AutoSize = true;
            this.LBLIR.ForeColor = System.Drawing.Color.White;
            this.LBLIR.Location = new System.Drawing.Point(27, 420);
            this.LBLIR.Name = "LBLIR";
            this.LBLIR.Size = new System.Drawing.Size(21, 13);
            this.LBLIR.TabIndex = 26;
            this.LBLIR.Text = "IR:";
            // 
            // TXBPC
            // 
            this.TXBPC.Location = new System.Drawing.Point(58, 391);
            this.TXBPC.Name = "TXBPC";
            this.TXBPC.ReadOnly = true;
            this.TXBPC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBPC.Size = new System.Drawing.Size(129, 20);
            this.TXBPC.TabIndex = 27;
            // 
            // TXBIR
            // 
            this.TXBIR.Location = new System.Drawing.Point(58, 417);
            this.TXBIR.Name = "TXBIR";
            this.TXBIR.ReadOnly = true;
            this.TXBIR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBIR.Size = new System.Drawing.Size(129, 20);
            this.TXBIR.TabIndex = 28;
            // 
            // WinInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXBIR);
            this.Controls.Add(this.TXBPC);
            this.Controls.Add(this.LBLIR);
            this.Controls.Add(this.LBLPC);
            this.Controls.Add(this.LBLMBR);
            this.Controls.Add(this.LBLMAR);
            this.Controls.Add(this.TXBMBR);
            this.Controls.Add(this.TXBMAR);
            this.Controls.Add(this.LBLOnlyFans);
            this.Controls.Add(this.LBLCarry);
            this.Controls.Add(this.LBLZero);
            this.Controls.Add(this.LBLIP);
            this.Controls.Add(this.LBLDx);
            this.Controls.Add(this.LBLCx);
            this.Controls.Add(this.LBLBx);
            this.Controls.Add(this.LBLAx);
            this.Controls.Add(this.TXBOnlyFans);
            this.Controls.Add(this.TXBCarry);
            this.Controls.Add(this.TXBZero);
            this.Controls.Add(this.TXBIP);
            this.Controls.Add(this.TXBDx);
            this.Controls.Add(this.TXBCx);
            this.Controls.Add(this.TXBBx);
            this.Controls.Add(this.TXBAx);
            this.Controls.Add(this.IMGPlay);
            this.Controls.Add(this.IMGSiguiente);
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
            ((System.ComponentModel.ISupportInitialize)(this.IMGSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGPlay)).EndInit();
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
        private System.Windows.Forms.PictureBox IMGSiguiente;
        private System.Windows.Forms.PictureBox IMGPlay;
        private System.Windows.Forms.TextBox TXBAx;
        private System.Windows.Forms.TextBox TXBBx;
        private System.Windows.Forms.TextBox TXBCx;
        private System.Windows.Forms.TextBox TXBDx;
        private System.Windows.Forms.TextBox TXBIP;
        private System.Windows.Forms.TextBox TXBZero;
        private System.Windows.Forms.TextBox TXBCarry;
        private System.Windows.Forms.TextBox TXBOnlyFans;
        private System.Windows.Forms.Label LBLAx;
        private System.Windows.Forms.Label LBLBx;
        private System.Windows.Forms.Label LBLCx;
        private System.Windows.Forms.Label LBLDx;
        private System.Windows.Forms.Label LBLIP;
        private System.Windows.Forms.Label LBLZero;
        private System.Windows.Forms.Label LBLCarry;
        private System.Windows.Forms.Label LBLOnlyFans;
        private System.Windows.Forms.TextBox TXBMBR;
        private System.Windows.Forms.TextBox TXBMAR;
        private System.Windows.Forms.Label LBLMAR;
        private System.Windows.Forms.Label LBLMBR;
        private System.Windows.Forms.Label LBLPC;
        private System.Windows.Forms.Label LBLIR;
        private System.Windows.Forms.TextBox TXBPC;
        private System.Windows.Forms.TextBox TXBIR;
    }
}

