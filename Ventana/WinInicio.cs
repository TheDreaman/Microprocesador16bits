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

namespace Ventana
{
    public partial class WinInicio : Form
    {
        public int[] Alto = new int[5];
        public int[] Bajo = new int[5];
        public int[] WhatReg = new int[5];
        public int FromReg;
        public int[] ToReg = new int[3];
        public int BorW;
        public int[] Instruction = new int[5];
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
            Stream fs = new FileStream("./Ejemplo.txt", FileMode.Open, FileAccess.Read);
            int y = 1;
            int tres = 1;
            int tres2 = 1;
            int uno = 1;
            long tamaño = fs.Length;
            for (long x = 0; x < tamaño; x++)
            {
                fs.Seek(x, SeekOrigin.Begin);
                int val = fs.ReadByte();
                string valUTF = ($"{(char)val}");
                int valINT = (int)char.GetNumericValue((char)val);
                if (y<5)
                {
                    Instruction[tres] = valINT;
                    tres++;
                }
                else if(y==5)
                {
                    BorW = valINT;
                    tres = 1;
                }
                else if (y>5 && y<8)
                {
                    ToReg[uno] = valINT;
                    uno++;
                }
                else if (y==8)
                {
                    FromReg = valINT;
                    uno = 1;
                }
                else if (y>8 && y<13)
                {
                    if(FromReg==1)
                    {
                        WhatReg[tres] = valINT;
                    }
                    else
                    {
                        Bajo[tres] = valINT;
                    }
                    tres++;
                }
                else if (y>12 && y<17)
                {
                    Alto[tres2] = valINT;
                    tres2++;
                }
                else if(y==17)
                {
                    tres = 1;
                    tres2 = 1;
                    uno = 1;
                }
                else if (y==18)
                {
                    string ins = ("Instruccion : " + Instruction[1] + Instruction[2] + Instruction[3] + Instruction[4] + Environment.NewLine);
                    string borw = ("Byte o Word : " + BorW + Environment.NewLine);
                    string toreg = ("Al registro : " + ToReg[1] + ToReg[2] + Environment.NewLine);
                    string fromreg = ("Viene de Registro? : " + FromReg + Environment.NewLine);
                    string whatreg = ("Si la anterior fue si, cual? : " + WhatReg[1] + WhatReg[2] + WhatReg[3] + WhatReg[4] + Environment.NewLine);
                    string bajo = ("Bajo : " + Bajo[1] + Bajo[2] + Bajo[3] + Bajo[4] + Environment.NewLine);
                    string alto = ("Alto : " + Alto[1] + Alto[2] + Alto[3] + Alto[4] + Environment.NewLine);
                    TXBMostrar.Text += ("" + ins + borw + toreg + fromreg + whatreg + bajo + alto);
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
