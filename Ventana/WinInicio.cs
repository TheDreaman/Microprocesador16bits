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
                Auxiliar.Auxiliar.URLtxt = openFileDialog1.FileName;
                
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
            Auxiliar.Auxiliar.IP = 0;
            Auxiliar.Auxiliar.IP2 = 1;
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
                        TXBMostrar.Text += ("" + Auxiliar.Auxiliar.IP2 + ":" + ins + borw + toreg + fromreg + Environment.NewLine);
                        Auxiliar.Auxiliar.IP2++;
                        if (FromReg == 1)
                        {
                            TXBMostrar.Text += ("" + Auxiliar.Auxiliar.IP2 + ":" + whatreg + Environment.NewLine);
                            Auxiliar.Auxiliar.IP2++;
                        }
                        else
                        {
                            TXBMostrar.Text += ("" + Auxiliar.Auxiliar.IP2 + ":" + bajo + Environment.NewLine);
                            Auxiliar.Auxiliar.IP2++;
                        }

                    }
                    else
                    {
                        TXBMostrar.Text += ("" + Auxiliar.Auxiliar.IP2 + ":" + ins + borw + toreg + fromreg + Environment.NewLine);
                        Auxiliar.Auxiliar.IP2++;
                        if (FromReg == 1)
                        {
                            TXBMostrar.Text += ("" + Auxiliar.Auxiliar.IP2 + ":" + whatreg + Environment.NewLine);
                            Auxiliar.Auxiliar.IP2++;
                            TXBMostrar.Text += ("" + Auxiliar.Auxiliar.IP2 + ":" + alto + Environment.NewLine);
                            Auxiliar.Auxiliar.IP2++;
                        }
                        else
                        {
                            TXBMostrar.Text += ("" + Auxiliar.Auxiliar.IP2 + ":" + bajo + Environment.NewLine);
                            Auxiliar.Auxiliar.IP2++;
                            TXBMostrar.Text += ("" + Auxiliar.Auxiliar.IP2 + ":" + alto + Environment.NewLine);
                            Auxiliar.Auxiliar.IP2++;
                        }
                    }
                    //imprime y sustituye txt de ip
                    TXBIP.Text = ("" + Auxiliar.Auxiliar.IP);
                    TXBCarry.Text = ("" + Auxiliar.Auxiliar.CY);
                    TXBAx.Text = ("" + Auxiliar.Auxiliar.AX[1] + Auxiliar.Auxiliar.AX[2] + Auxiliar.Auxiliar.AX[3] + Auxiliar.Auxiliar.AX[4] + Auxiliar.Auxiliar.AX[5] + Auxiliar.Auxiliar.AX[6] + Auxiliar.Auxiliar.AX[7] + Auxiliar.Auxiliar.AX[8]);
                    TXBBx.Text = ("" + Auxiliar.Auxiliar.BX[1] + Auxiliar.Auxiliar.BX[2] + Auxiliar.Auxiliar.BX[3] + Auxiliar.Auxiliar.BX[4] + Auxiliar.Auxiliar.BX[5] + Auxiliar.Auxiliar.BX[6] + Auxiliar.Auxiliar.BX[7] + Auxiliar.Auxiliar.BX[8]);
                    TXBCx.Text = ("" + Auxiliar.Auxiliar.CX[1] + Auxiliar.Auxiliar.CX[2] + Auxiliar.Auxiliar.CX[3] + Auxiliar.Auxiliar.CX[4] + Auxiliar.Auxiliar.CX[5] + Auxiliar.Auxiliar.CX[6] + Auxiliar.Auxiliar.CX[7] + Auxiliar.Auxiliar.CX[8]);
                    TXBDx.Text = ("" + Auxiliar.Auxiliar.DX[1] + Auxiliar.Auxiliar.DX[2] + Auxiliar.Auxiliar.DX[3] + Auxiliar.Auxiliar.DX[4] + Auxiliar.Auxiliar.DX[5] + Auxiliar.Auxiliar.DX[6] + Auxiliar.Auxiliar.DX[7] + Auxiliar.Auxiliar.DX[8]);
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
