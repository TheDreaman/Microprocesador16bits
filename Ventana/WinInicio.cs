using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using Auxiliar;
using Unidad_de_control;

namespace Ventana
{
    public partial class WinInicio : Form
    {
        public int[] Alto = new int[9];
        public int[] Bajo = new int[9];
        public int[] WhatReg = new int[9];
        public int FromReg;
        public int[] ToReg = new int[3];
        public int BorW;
        public int[] Instruction = new int[9];
        public WinInicio()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PNLTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void WinInicio_Load(object sender, EventArgs e)
        {

        }

        private void BTNClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BTNCargar_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Archivos txt (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Auxiliar.Auxi.URLtxt = openFileDialog1.FileName;
                
            }       

        }

        private void IMGSiguiente_Click(object sender, EventArgs e)
        {

        }

        private void IMGPlay_Click(object sender, EventArgs e)
        {
            Stream fs = new FileStream("./Ejemplo.txt", FileMode.Open, FileAccess.Read);
            int y = 1;
            int tres = 1;
            int tres2 = 1;
            int uno = 1;
            Auxiliar.Auxi.IP = 0;
            Auxiliar.Auxi.IP2 = 1;
            long tamaño = fs.Length;
            for (long x = 0; x < tamaño; x++)
            {
                fs.Seek(x, SeekOrigin.Begin);
                int val = fs.ReadByte();
                string valUTF = ($"{(char)val}");
                int valINT = (int)char.GetNumericValue((char)val);
                if (y < 5)
                {
                    Instruction[tres] = valINT;
                    tres++;
                }
                else if (y == 5)
                {
                    BorW = valINT;
                    tres = 1;
                }
                else if (y > 5 && y < 8)
                {
                    ToReg[uno] = valINT;
                    uno++;
                }
                else if (y == 8)
                {
                    FromReg = valINT;
                    uno = 1;
                }
                else if (y > 8 && y < 17)
                {
                    if (FromReg == 1)
                    {
                        WhatReg[tres] = valINT;
                    }
                    else
                    {
                        Bajo[tres] = valINT;
                    }
                    tres++;
                }
                else if (y > 16 && y < 25)
                {
                    Alto[tres2] = valINT;
                    tres2++;
                }
                else if (y == 25)
                {
                    tres = 1;
                    tres2 = 1;
                    uno = 1;
                }
                else if (y == 26)
                {
                    UControl ucontrol = new UControl();
                    
                    ucontrol.VerificarInstruccion(Instruction[1], Instruction[2], Instruction[3], Instruction[4], BorW, ToReg[1], ToReg[2], FromReg,
                        WhatReg[1], WhatReg[2], WhatReg[3], WhatReg[4], WhatReg[5], WhatReg[6], WhatReg[7], WhatReg[8],
                        Bajo[1], Bajo[2], Bajo[3], Bajo[4], Bajo[5], Bajo[6], Bajo[7], Bajo[8],
                        Alto[1], Alto[2], Alto[3], Alto[4], Alto[5], Alto[6], Alto[7], Alto[8]);
                    //imprime lineas de codigo
                    string ins = ("" + Instruction[1] + Instruction[2] + Instruction[3] + Instruction[4]);
                    string borw = ("" + BorW);
                    string toreg = ("" + ToReg[1] + ToReg[2]);
                    string fromreg = ("" + FromReg);
                    string whatreg = ("" + WhatReg[1] + WhatReg[2] + WhatReg[3] + WhatReg[4] + WhatReg[5] + WhatReg[6] + WhatReg[7] + WhatReg[8]);
                    string bajo = ("" + Bajo[1] + Bajo[2] + Bajo[3] + Bajo[4] + Bajo[5] + Bajo[6] + Bajo[7] + Bajo[8]);
                    string alto = ("" + Alto[1] + Alto[2] + Alto[3] + Alto[4] + Alto[5] + Alto[6] + Alto[7] + Alto[8]);

                    if (BorW == 1)//1=Byte, 0=Word
                    {
                        TXBMostrar.Text += ("" + Auxiliar.Auxi.IP2 + ":" + ins + borw + toreg + fromreg + Environment.NewLine);
                        Auxiliar.Auxi.IP2++;
                        if (FromReg == 1)
                        {
                            TXBMostrar.Text += ("" + Auxiliar.Auxi.IP2 + ":" + whatreg + Environment.NewLine);
                            TXBMAR.Text = ("" + ins + borw + toreg + fromreg + whatreg);
                            Auxiliar.Auxi.IP2++;
                        }
                        else
                        {
                            TXBMostrar.Text += ("" + Auxiliar.Auxi.IP2 + ":" + bajo + Environment.NewLine);
                            TXBMAR.Text = ("" + ins + borw + toreg + fromreg + bajo);
                            Auxiliar.Auxi.IP2++;
                        }

                    }
                    else
                    {
                        TXBMostrar.Text += ("" + Auxiliar.Auxi.IP2 + ":" + ins + borw + toreg + fromreg + Environment.NewLine);
                        Auxiliar.Auxi.IP2++;
                        if (FromReg == 1)
                        {
                            TXBMostrar.Text += ("" + Auxiliar.Auxi.IP2 + ":" + whatreg + Environment.NewLine);
                            Auxiliar.Auxi.IP2++;
                            TXBMostrar.Text += ("" + Auxiliar.Auxi.IP2 + ":" + alto + Environment.NewLine);
                            Auxiliar.Auxi.IP2++;
                            TXBMAR.Text = ("" + ins + borw + toreg + fromreg + alto);
                        }
                        else
                        {
                            TXBMostrar.Text += ("" + Auxiliar.Auxi.IP2 + ":" + bajo + Environment.NewLine);
                            Auxiliar.Auxi.IP2++;
                            TXBMostrar.Text += ("" + Auxiliar.Auxi.IP2 + ":" + alto + Environment.NewLine);
                            Auxiliar.Auxi.IP2++;
                            TXBMAR.Text = ("" + ins + borw + toreg + fromreg + alto);
                        }
                    }
                    //imprime y sustituye txt de ip
                    TXBIP.Text = ("" + Auxiliar.Auxi.IP);
                    TXBCarry.Text = ("" + Auxiliar.Auxi.CY);
                    TXBAx.Text = ("" + Auxi.AX[1] + Auxi.AX[2] + Auxi.AX[3] + Auxi.AX[4] + Auxi.AX[5] + Auxi.AX[6] + Auxi.AX[7] + Auxi.AX[8]);
                    TXBBx.Text = ("" + Auxi.BX[1] + Auxi.BX[2] + Auxi.BX[3] + Auxi.BX[4] + Auxi.BX[5] + Auxi.BX[6] + Auxi.BX[7] + Auxi.BX[8]);
                    TXBCx.Text = ("" + Auxi.CX[1] + Auxi.CX[2] + Auxi.CX[3] + Auxi.CX[4] + Auxi.CX[5] + Auxi.CX[6] + Auxi.CX[7] + Auxi.CX[8]);
                    TXBDx.Text = ("" + Auxi.DX[1] + Auxi.DX[2] + Auxi.DX[3] + Auxi.DX[4] + Auxi.DX[5] + Auxi.DX[6] + Auxi.DX[7] + Auxi.DX[8]);
                    y = 0;
                }
                //string cadena = ($"Posición {x+1}: " + valUTF + Instruction[1] + Instruction[2] + Instruction[3] + Instruction[4] + Environment.NewLine);
                //TXBMostrar.Text += cadena;
                y++;
            }
            fs.Close();
        }
    }
}
