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
            this.TXBMostrar2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBLTxtname = new System.Windows.Forms.Label();
            this.PNLTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTNMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // PNLTop
            // 
            this.PNLTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(0)))), ((int)(((byte)(73)))));
            this.PNLTop.Controls.Add(this.LBLTxtname);
            this.PNLTop.Controls.Add(this.BTNMin);
            this.PNLTop.Controls.Add(this.BTNClose);
            this.PNLTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNLTop.Location = new System.Drawing.Point(0, 0);
            this.PNLTop.Name = "PNLTop";
            this.PNLTop.Size = new System.Drawing.Size(500, 25);
            this.PNLTop.TabIndex = 0;
            this.PNLTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PNLTop_MouseDown);
            // 
            // BTNMin
            // 
            this.BTNMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNMin.Image = ((System.Drawing.Image)(resources.GetObject("BTNMin.Image")));
            this.BTNMin.Location = new System.Drawing.Point(449, 3);
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
            this.BTNClose.Location = new System.Drawing.Point(476, 3);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(21, 21);
            this.BTNClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTNClose.TabIndex = 0;
            this.BTNClose.TabStop = false;
            this.BTNClose.Click += new System.EventHandler(this.BTNClose_Click);
            // 
            // TXBMostrar
            // 
            this.TXBMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.TXBMostrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXBMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXBMostrar.ForeColor = System.Drawing.Color.White;
            this.TXBMostrar.Location = new System.Drawing.Point(224, 63);
            this.TXBMostrar.Multiline = true;
            this.TXBMostrar.Name = "TXBMostrar";
            this.TXBMostrar.ReadOnly = true;
            this.TXBMostrar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBMostrar.Size = new System.Drawing.Size(131, 261);
            this.TXBMostrar.TabIndex = 1;
            // 
            // BTNCargar
            // 
            this.BTNCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(0)))), ((int)(((byte)(73)))));
            this.BTNCargar.FlatAppearance.BorderSize = 0;
            this.BTNCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BTNCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCargar.Font = new System.Drawing.Font("DIN", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCargar.ForeColor = System.Drawing.Color.White;
            this.BTNCargar.Location = new System.Drawing.Point(0, 31);
            this.BTNCargar.Name = "BTNCargar";
            this.BTNCargar.Size = new System.Drawing.Size(218, 26);
            this.BTNCargar.TabIndex = 2;
            this.BTNCargar.Text = "Cargar";
            this.BTNCargar.UseVisualStyleBackColor = false;
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
            this.IMGSiguiente.Location = new System.Drawing.Point(53, 63);
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
            this.IMGPlay.Location = new System.Drawing.Point(120, 63);
            this.IMGPlay.Name = "IMGPlay";
            this.IMGPlay.Size = new System.Drawing.Size(40, 40);
            this.IMGPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IMGPlay.TabIndex = 4;
            this.IMGPlay.TabStop = false;
            this.IMGPlay.Click += new System.EventHandler(this.IMGPlay_Click);
            // 
            // TXBAx
            // 
            this.TXBAx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.TXBAx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXBAx.ForeColor = System.Drawing.Color.White;
            this.TXBAx.Location = new System.Drawing.Point(132, 123);
            this.TXBAx.Name = "TXBAx";
            this.TXBAx.ReadOnly = true;
            this.TXBAx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBAx.Size = new System.Drawing.Size(55, 13);
            this.TXBAx.TabIndex = 5;
            // 
            // TXBBx
            // 
            this.TXBBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.TXBBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXBBx.ForeColor = System.Drawing.Color.White;
            this.TXBBx.Location = new System.Drawing.Point(132, 149);
            this.TXBBx.Name = "TXBBx";
            this.TXBBx.ReadOnly = true;
            this.TXBBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBBx.Size = new System.Drawing.Size(55, 13);
            this.TXBBx.TabIndex = 6;
            // 
            // TXBCx
            // 
            this.TXBCx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.TXBCx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXBCx.ForeColor = System.Drawing.Color.White;
            this.TXBCx.Location = new System.Drawing.Point(132, 175);
            this.TXBCx.Name = "TXBCx";
            this.TXBCx.ReadOnly = true;
            this.TXBCx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBCx.Size = new System.Drawing.Size(55, 13);
            this.TXBCx.TabIndex = 7;
            // 
            // TXBDx
            // 
            this.TXBDx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.TXBDx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXBDx.ForeColor = System.Drawing.Color.White;
            this.TXBDx.Location = new System.Drawing.Point(132, 201);
            this.TXBDx.Name = "TXBDx";
            this.TXBDx.ReadOnly = true;
            this.TXBDx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBDx.Size = new System.Drawing.Size(55, 13);
            this.TXBDx.TabIndex = 8;
            // 
            // TXBIP
            // 
            this.TXBIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.TXBIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXBIP.ForeColor = System.Drawing.Color.White;
            this.TXBIP.Location = new System.Drawing.Point(67, 123);
            this.TXBIP.Name = "TXBIP";
            this.TXBIP.ReadOnly = true;
            this.TXBIP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBIP.Size = new System.Drawing.Size(26, 13);
            this.TXBIP.TabIndex = 9;
            // 
            // TXBZero
            // 
            this.TXBZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.TXBZero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXBZero.ForeColor = System.Drawing.Color.White;
            this.TXBZero.Location = new System.Drawing.Point(67, 149);
            this.TXBZero.Name = "TXBZero";
            this.TXBZero.ReadOnly = true;
            this.TXBZero.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBZero.Size = new System.Drawing.Size(26, 13);
            this.TXBZero.TabIndex = 10;
            // 
            // TXBCarry
            // 
            this.TXBCarry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.TXBCarry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXBCarry.ForeColor = System.Drawing.Color.White;
            this.TXBCarry.Location = new System.Drawing.Point(67, 175);
            this.TXBCarry.Name = "TXBCarry";
            this.TXBCarry.ReadOnly = true;
            this.TXBCarry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBCarry.Size = new System.Drawing.Size(26, 13);
            this.TXBCarry.TabIndex = 11;
            // 
            // TXBOnlyFans
            // 
            this.TXBOnlyFans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.TXBOnlyFans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXBOnlyFans.ForeColor = System.Drawing.Color.White;
            this.TXBOnlyFans.Location = new System.Drawing.Point(67, 201);
            this.TXBOnlyFans.Name = "TXBOnlyFans";
            this.TXBOnlyFans.ReadOnly = true;
            this.TXBOnlyFans.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBOnlyFans.Size = new System.Drawing.Size(26, 13);
            this.TXBOnlyFans.TabIndex = 12;
            // 
            // LBLAx
            // 
            this.LBLAx.AutoSize = true;
            this.LBLAx.ForeColor = System.Drawing.Color.White;
            this.LBLAx.Location = new System.Drawing.Point(106, 123);
            this.LBLAx.Name = "LBLAx";
            this.LBLAx.Size = new System.Drawing.Size(24, 13);
            this.LBLAx.TabIndex = 13;
            this.LBLAx.Text = "AX:";
            // 
            // LBLBx
            // 
            this.LBLBx.AutoSize = true;
            this.LBLBx.ForeColor = System.Drawing.Color.White;
            this.LBLBx.Location = new System.Drawing.Point(106, 149);
            this.LBLBx.Name = "LBLBx";
            this.LBLBx.Size = new System.Drawing.Size(24, 13);
            this.LBLBx.TabIndex = 14;
            this.LBLBx.Text = "BX:";
            // 
            // LBLCx
            // 
            this.LBLCx.AutoSize = true;
            this.LBLCx.ForeColor = System.Drawing.Color.White;
            this.LBLCx.Location = new System.Drawing.Point(107, 175);
            this.LBLCx.Name = "LBLCx";
            this.LBLCx.Size = new System.Drawing.Size(24, 13);
            this.LBLCx.TabIndex = 15;
            this.LBLCx.Text = "CX:";
            // 
            // LBLDx
            // 
            this.LBLDx.AutoSize = true;
            this.LBLDx.ForeColor = System.Drawing.Color.White;
            this.LBLDx.Location = new System.Drawing.Point(107, 201);
            this.LBLDx.Name = "LBLDx";
            this.LBLDx.Size = new System.Drawing.Size(25, 13);
            this.LBLDx.TabIndex = 16;
            this.LBLDx.Text = "DX:";
            // 
            // LBLIP
            // 
            this.LBLIP.AutoSize = true;
            this.LBLIP.ForeColor = System.Drawing.Color.White;
            this.LBLIP.Location = new System.Drawing.Point(45, 123);
            this.LBLIP.Name = "LBLIP";
            this.LBLIP.Size = new System.Drawing.Size(20, 13);
            this.LBLIP.TabIndex = 17;
            this.LBLIP.Text = "IP:";
            // 
            // LBLZero
            // 
            this.LBLZero.AutoSize = true;
            this.LBLZero.ForeColor = System.Drawing.Color.White;
            this.LBLZero.Location = new System.Drawing.Point(48, 149);
            this.LBLZero.Name = "LBLZero";
            this.LBLZero.Size = new System.Drawing.Size(17, 13);
            this.LBLZero.TabIndex = 18;
            this.LBLZero.Text = "Z:";
            // 
            // LBLCarry
            // 
            this.LBLCarry.AutoSize = true;
            this.LBLCarry.ForeColor = System.Drawing.Color.White;
            this.LBLCarry.Location = new System.Drawing.Point(41, 175);
            this.LBLCarry.Name = "LBLCarry";
            this.LBLCarry.Size = new System.Drawing.Size(24, 13);
            this.LBLCarry.TabIndex = 19;
            this.LBLCarry.Text = "CY:";
            // 
            // LBLOnlyFans
            // 
            this.LBLOnlyFans.AutoSize = true;
            this.LBLOnlyFans.ForeColor = System.Drawing.Color.White;
            this.LBLOnlyFans.Location = new System.Drawing.Point(41, 201);
            this.LBLOnlyFans.Name = "LBLOnlyFans";
            this.LBLOnlyFans.Size = new System.Drawing.Size(24, 13);
            this.LBLOnlyFans.TabIndex = 20;
            this.LBLOnlyFans.Text = "OF:";
            // 
            // TXBMBR
            // 
            this.TXBMBR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.TXBMBR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXBMBR.ForeColor = System.Drawing.Color.White;
            this.TXBMBR.Location = new System.Drawing.Point(58, 311);
            this.TXBMBR.Name = "TXBMBR";
            this.TXBMBR.ReadOnly = true;
            this.TXBMBR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBMBR.Size = new System.Drawing.Size(149, 13);
            this.TXBMBR.TabIndex = 22;
            // 
            // TXBMAR
            // 
            this.TXBMAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.TXBMAR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXBMAR.ForeColor = System.Drawing.Color.White;
            this.TXBMAR.Location = new System.Drawing.Point(109, 279);
            this.TXBMAR.Name = "TXBMAR";
            this.TXBMAR.ReadOnly = true;
            this.TXBMAR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBMAR.Size = new System.Drawing.Size(55, 13);
            this.TXBMAR.TabIndex = 21;
            // 
            // LBLMAR
            // 
            this.LBLMAR.AutoSize = true;
            this.LBLMAR.ForeColor = System.Drawing.Color.White;
            this.LBLMAR.Location = new System.Drawing.Point(69, 279);
            this.LBLMAR.Name = "LBLMAR";
            this.LBLMAR.Size = new System.Drawing.Size(34, 13);
            this.LBLMAR.TabIndex = 23;
            this.LBLMAR.Text = "MAR:";
            // 
            // LBLMBR
            // 
            this.LBLMBR.AutoSize = true;
            this.LBLMBR.ForeColor = System.Drawing.Color.White;
            this.LBLMBR.Location = new System.Drawing.Point(18, 311);
            this.LBLMBR.Name = "LBLMBR";
            this.LBLMBR.Size = new System.Drawing.Size(34, 13);
            this.LBLMBR.TabIndex = 24;
            this.LBLMBR.Text = "MBR:";
            // 
            // LBLPC
            // 
            this.LBLPC.AutoSize = true;
            this.LBLPC.ForeColor = System.Drawing.Color.White;
            this.LBLPC.Location = new System.Drawing.Point(82, 253);
            this.LBLPC.Name = "LBLPC";
            this.LBLPC.Size = new System.Drawing.Size(24, 13);
            this.LBLPC.TabIndex = 25;
            this.LBLPC.Text = "PC:";
            // 
            // LBLIR
            // 
            this.LBLIR.AutoSize = true;
            this.LBLIR.ForeColor = System.Drawing.Color.White;
            this.LBLIR.Location = new System.Drawing.Point(82, 227);
            this.LBLIR.Name = "LBLIR";
            this.LBLIR.Size = new System.Drawing.Size(21, 13);
            this.LBLIR.TabIndex = 26;
            this.LBLIR.Text = "IR:";
            // 
            // TXBPC
            // 
            this.TXBPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.TXBPC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXBPC.ForeColor = System.Drawing.Color.White;
            this.TXBPC.Location = new System.Drawing.Point(109, 253);
            this.TXBPC.Name = "TXBPC";
            this.TXBPC.ReadOnly = true;
            this.TXBPC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBPC.Size = new System.Drawing.Size(55, 13);
            this.TXBPC.TabIndex = 27;
            // 
            // TXBIR
            // 
            this.TXBIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.TXBIR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXBIR.ForeColor = System.Drawing.Color.White;
            this.TXBIR.Location = new System.Drawing.Point(109, 227);
            this.TXBIR.Name = "TXBIR";
            this.TXBIR.ReadOnly = true;
            this.TXBIR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBIR.Size = new System.Drawing.Size(55, 13);
            this.TXBIR.TabIndex = 28;
            // 
            // TXBMostrar2
            // 
            this.TXBMostrar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.TXBMostrar2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXBMostrar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXBMostrar2.ForeColor = System.Drawing.Color.White;
            this.TXBMostrar2.Location = new System.Drawing.Point(361, 63);
            this.TXBMostrar2.Multiline = true;
            this.TXBMostrar2.Name = "TXBMostrar2";
            this.TXBMostrar2.ReadOnly = true;
            this.TXBMostrar2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXBMostrar2.Size = new System.Drawing.Size(139, 260);
            this.TXBMostrar2.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(260, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DIN", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(392, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Instrucción";
            // 
            // LBLTxtname
            // 
            this.LBLTxtname.AutoSize = true;
            this.LBLTxtname.Font = new System.Drawing.Font("DIN", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTxtname.ForeColor = System.Drawing.Color.White;
            this.LBLTxtname.Location = new System.Drawing.Point(12, 6);
            this.LBLTxtname.Name = "LBLTxtname";
            this.LBLTxtname.Size = new System.Drawing.Size(0, 14);
            this.LBLTxtname.TabIndex = 32;
            // 
            // WinInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(500, 330);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXBMostrar2);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.WinInicio_Load);
            this.PNLTop.ResumeLayout(false);
            this.PNLTop.PerformLayout();
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
        public System.Windows.Forms.TextBox TXBZero;
        public System.Windows.Forms.TextBox TXBMostrar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBLTxtname;
    }
}

