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
        int y55 = 1;
        int tres55 = 1;
        int tres66 = 1;
        int uno55 = 1;
        int zz = 0;
        long x55 = 0;
        
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
                Auxi.URLtxt = openFileDialog1.FileName;
                LBLTxtname.Text = ("" + Path.GetFileName(Auxi.URLtxt));
                MsgBox msg = new MsgBox();
                msg.mensaje.Text = "Archivo ingresado";
                msg.ShowDialog();
                IMGPlay.Visible = true;
                IMGSiguiente.Visible = true;
                Clear();              
            }       

        }

        private void IMGSiguiente_Click(object sender, EventArgs e)
        {
            IMGPlay.Visible = false;
            if (Auxi.URLtxt == null)
            {
                MsgBox msg = new MsgBox();
                msg.mensaje.Text = "Ingrese un archivo antes";
                msg.ShowDialog();
            }
            else
            {
                zz = zz + 26;
                Stream fs = new FileStream(Auxi.URLtxt, FileMode.Open, FileAccess.Read);
                //Auxi.IP = 0;
                //Auxi.IP2 = 1;
                //long tamaño = fs.Length;
                while (x55 < zz)
                {
                    fs.Seek(x55, SeekOrigin.Begin);
                    int val = fs.ReadByte();
                    string valUTF = ($"{(char)val}");
                    int valINT = (int)char.GetNumericValue((char)val);
                    if (y55 < 5)
                    {
                        Instruction[tres55] = valINT;
                        tres55++;
                    }
                    else if (y55 == 5)
                    {
                        BorW = valINT;
                        tres55 = 1;
                    }
                    else if (y55 > 5 && y55 < 8)
                    {
                        ToReg[uno55] = valINT;
                        uno55++;
                    }
                    else if (y55 == 8)
                    {
                        FromReg = valINT;
                        uno55 = 1;
                    }
                    else if (y55 > 8 && y55 < 17)
                    {
                        if (FromReg == 1)
                        {
                            WhatReg[tres55] = valINT;
                        }
                        else
                        {
                            Bajo[tres55] = valINT;
                        }
                        tres55++;
                    }
                    else if (y55 > 16 && y55 < 25)
                    {
                        Alto[tres66] = valINT;
                        tres66++;
                    }
                    else if (y55 == 25)
                    {
                        tres55 = 1;
                        tres66 = 1;
                        uno55 = 1;
                        Auxi.MAR++;
                    }
                    y55++;
                    x55++;
                }
                //x55 = x55 + 26;
                if (Instruction[1]==-1)
                {
                    MsgBox msg = new MsgBox();
                    msg.mensaje.Text = "Fin de Programa";
                    msg.ShowDialog();
                    IMGSiguiente.Visible = false;
                }
                else
                {
                    UControl ucontrol = new UControl();
                    ucontrol.VerificarInstruccion(Instruction[1], Instruction[2], Instruction[3], Instruction[4], BorW, ToReg[1], ToReg[2], FromReg,
                        WhatReg[1], WhatReg[2], WhatReg[3], WhatReg[4], WhatReg[5], WhatReg[6], WhatReg[7], WhatReg[8],
                        Bajo[1], Bajo[2], Bajo[3], Bajo[4], Bajo[5], Bajo[6], Bajo[7], Bajo[8],
                        Alto[1], Alto[2], Alto[3], Alto[4], Alto[5], Alto[6], Alto[7], Alto[8]);
                    Traduce(Instruction[1], Instruction[2], Instruction[3], Instruction[4], BorW, ToReg[1], ToReg[2], FromReg,
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
                        TXBIR.Text = ("" + Auxi.IP2);
                        TXBPC.Text = ("" + (Auxi.IP2 + 1));
                        TXBMostrar.Text += ("" + Auxiliar.Auxi.IP2 + ": " + ins + borw + toreg + fromreg + Environment.NewLine);
                        Auxiliar.Auxi.IP2++;
                        if (FromReg == 1)
                        {
                            TXBIR.Text = ("" + Auxi.IP2);
                            TXBPC.Text = ("" + (Auxi.IP2 + 1));
                            TXBMostrar.Text += ("" + Auxiliar.Auxi.IP2 + ": " + whatreg + Environment.NewLine);
                            TXBMBR.Text = ("" + ins + borw + toreg + fromreg + whatreg);
                            Auxi.IP2++;
                        }
                        else
                        {
                            TXBIR.Text = ("" + Auxi.IP2);
                            TXBPC.Text = ("" + (Auxi.IP2 + 1));
                            TXBMostrar.Text += ("" + Auxiliar.Auxi.IP2 + ": " + bajo + Environment.NewLine);
                            TXBMBR.Text = ("" + ins + borw + toreg + fromreg + bajo);
                            Auxiliar.Auxi.IP2++;
                        }

                    }
                    else
                    {
                        TXBIR.Text = ("" + Auxi.IP2);
                        TXBPC.Text = ("" + (Auxi.IP2 + 1));
                        TXBMostrar.Text += ("" + Auxiliar.Auxi.IP2 + ": " + ins + borw + toreg + fromreg + Environment.NewLine);
                        Auxiliar.Auxi.IP2++;
                        if (FromReg == 1)
                        {
                            TXBIR.Text = ("" + Auxi.IP2);
                            TXBPC.Text = ("" + (Auxi.IP2 + 1));
                            TXBMostrar.Text += ("" + Auxiliar.Auxi.IP2 + ": " + whatreg + Environment.NewLine);
                            Auxiliar.Auxi.IP2++;
                            TXBIR.Text = ("" + Auxi.IP2);
                            TXBPC.Text = ("" + (Auxi.IP2 + 1));
                            TXBMostrar.Text += ("" + Auxiliar.Auxi.IP2 + ": " + alto + Environment.NewLine);
                            Auxiliar.Auxi.IP2++;
                            TXBMBR.Text = ("" + ins + borw + toreg + fromreg + whatreg + alto);
                        }
                        else
                        {
                            TXBIR.Text = ("" + Auxi.IP2);
                            TXBPC.Text = ("" + (Auxi.IP2 + 1));
                            TXBMostrar.Text += ("" + Auxiliar.Auxi.IP2 + ": " + bajo + Environment.NewLine);
                            Auxiliar.Auxi.IP2++;
                            TXBIR.Text = ("" + Auxi.IP2);
                            TXBPC.Text = ("" + (Auxi.IP2 + 1));
                            TXBMostrar.Text += ("" + Auxiliar.Auxi.IP2 + ": " + alto + Environment.NewLine);
                            Auxiliar.Auxi.IP2++;
                            TXBMBR.Text = ("" + ins + borw + toreg + fromreg + bajo + alto);
                        }
                    }
                    //imprime y sustituye txt de ip
                    TXBIP.Text = ("" + Auxi.IP);
                    TXBZero.Text = ("" + Auxi.Z);
                    TXBOnlyFans.Text = ("" + Auxi.OF);
                    TXBCarry.Text = ("" + Auxiliar.Auxi.CY);
                    TXBMAR.Text = ("" + Auxi.MAR);
                    TXBAx.Text = ("" + Auxi.AX[1] + Auxi.AX[2] + Auxi.AX[3] + Auxi.AX[4] + Auxi.AX[5] + Auxi.AX[6] + Auxi.AX[7] + Auxi.AX[8]);
                    TXBBx.Text = ("" + Auxi.BX[1] + Auxi.BX[2] + Auxi.BX[3] + Auxi.BX[4] + Auxi.BX[5] + Auxi.BX[6] + Auxi.BX[7] + Auxi.BX[8]);
                    TXBCx.Text = ("" + Auxi.CX[1] + Auxi.CX[2] + Auxi.CX[3] + Auxi.CX[4] + Auxi.CX[5] + Auxi.CX[6] + Auxi.CX[7] + Auxi.CX[8]);
                    TXBDx.Text = ("" + Auxi.DX[1] + Auxi.DX[2] + Auxi.DX[3] + Auxi.DX[4] + Auxi.DX[5] + Auxi.DX[6] + Auxi.DX[7] + Auxi.DX[8]);
                    y55 = 1;
                    fs.Close();
                }
            }
        }

        private void IMGPlay_Click(object sender, EventArgs e)
        {
            if (Auxi.URLtxt == null)
            {
                MsgBox msg = new MsgBox();
                msg.mensaje.Text = "Ingrese un archivo antes";
                msg.ShowDialog();
            }
            else
            {
                Stream fs = new FileStream(Auxi.URLtxt, FileMode.Open, FileAccess.Read);
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
                        Auxi.MAR++;
                    }
                    else if (y == 26)
                    {
                        UControl ucontrol = new UControl();

                        ucontrol.VerificarInstruccion(Instruction[1], Instruction[2], Instruction[3], Instruction[4], BorW, ToReg[1], ToReg[2], FromReg,
                            WhatReg[1], WhatReg[2], WhatReg[3], WhatReg[4], WhatReg[5], WhatReg[6], WhatReg[7], WhatReg[8],
                            Bajo[1], Bajo[2], Bajo[3], Bajo[4], Bajo[5], Bajo[6], Bajo[7], Bajo[8],
                            Alto[1], Alto[2], Alto[3], Alto[4], Alto[5], Alto[6], Alto[7], Alto[8]);
                        Traduce(Instruction[1], Instruction[2], Instruction[3], Instruction[4], BorW, ToReg[1], ToReg[2], FromReg,
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
                            TXBIR.Text = ("" + Auxi.IP2);
                            TXBPC.Text = ("" + (Auxi.IP2 + 1));
                            TXBMostrar.Text += ("" + Auxiliar.Auxi.IP2 + ": " + ins + borw + toreg + fromreg + Environment.NewLine);
                            Auxiliar.Auxi.IP2++;
                            if (FromReg == 1)
                            {
                                TXBIR.Text = ("" + Auxi.IP2);
                                TXBPC.Text = ("" + (Auxi.IP2 + 1));
                                TXBMostrar.Text += ("" + Auxiliar.Auxi.IP2 + ": " + whatreg + Environment.NewLine);
                                TXBMBR.Text = ("" + ins + borw + toreg + fromreg + whatreg);
                                Auxi.IP2++;
                            }
                            else
                            {
                                TXBIR.Text = ("" + Auxi.IP2);
                                TXBPC.Text = ("" + (Auxi.IP2 + 1));
                                TXBMostrar.Text += ("" + Auxiliar.Auxi.IP2 + ": " + bajo + Environment.NewLine);
                                TXBMBR.Text = ("" + ins + borw + toreg + fromreg + bajo);
                                Auxiliar.Auxi.IP2++;
                            }

                        }
                        else
                        {
                            TXBIR.Text = ("" + Auxi.IP2);
                            TXBPC.Text = ("" + (Auxi.IP2 + 1));
                            TXBMostrar.Text += ("" + Auxiliar.Auxi.IP2 + ": " + ins + borw + toreg + fromreg + Environment.NewLine);
                            Auxiliar.Auxi.IP2++;
                            if (FromReg == 1)
                            {
                                TXBIR.Text = ("" + Auxi.IP2);
                                TXBPC.Text = ("" + (Auxi.IP2 + 1));
                                TXBMostrar.Text += ("" + Auxiliar.Auxi.IP2 + ": " + whatreg + Environment.NewLine);
                                Auxiliar.Auxi.IP2++;
                                TXBIR.Text = ("" + Auxi.IP2);
                                TXBPC.Text = ("" + (Auxi.IP2 + 1));
                                TXBMostrar.Text += ("" + Auxiliar.Auxi.IP2 + ": " + alto + Environment.NewLine);
                                Auxiliar.Auxi.IP2++;
                                TXBMBR.Text = ("" + ins + borw + toreg + fromreg + whatreg + alto);
                            }
                            else
                            {
                                TXBIR.Text = ("" + Auxi.IP2);
                                TXBPC.Text = ("" + (Auxi.IP2 + 1));
                                TXBMostrar.Text += ("" + Auxiliar.Auxi.IP2 + ": " + bajo + Environment.NewLine);
                                Auxiliar.Auxi.IP2++;
                                TXBIR.Text = ("" + Auxi.IP2);
                                TXBPC.Text = ("" + (Auxi.IP2 + 1));
                                TXBMostrar.Text += ("" + Auxiliar.Auxi.IP2 + ": " + alto + Environment.NewLine);
                                Auxiliar.Auxi.IP2++;
                                TXBMBR.Text = ("" + ins + borw + toreg + fromreg + bajo + alto);
                            }
                        }
                        //imprime y sustituye txt de ip
                        TXBIP.Text = ("" + Auxiliar.Auxi.IP);
                        TXBZero.Text = ("" + Auxi.Z);
                        TXBOnlyFans.Text = ("" + Auxi.OF);
                        TXBCarry.Text = ("" + Auxiliar.Auxi.CY);
                        TXBMAR.Text = ("" + Auxi.MAR);
                        TXBAx.Text = ("" + Auxi.AX[1] + Auxi.AX[2] + Auxi.AX[3] + Auxi.AX[4] + Auxi.AX[5] + Auxi.AX[6] + Auxi.AX[7] + Auxi.AX[8]);
                        TXBBx.Text = ("" + Auxi.BX[1] + Auxi.BX[2] + Auxi.BX[3] + Auxi.BX[4] + Auxi.BX[5] + Auxi.BX[6] + Auxi.BX[7] + Auxi.BX[8]);
                        TXBCx.Text = ("" + Auxi.CX[1] + Auxi.CX[2] + Auxi.CX[3] + Auxi.CX[4] + Auxi.CX[5] + Auxi.CX[6] + Auxi.CX[7] + Auxi.CX[8]);
                        TXBDx.Text = ("" + Auxi.DX[1] + Auxi.DX[2] + Auxi.DX[3] + Auxi.DX[4] + Auxi.DX[5] + Auxi.DX[6] + Auxi.DX[7] + Auxi.DX[8]);
                        y = 0;
                    }
                    y++;
                }
                fs.Close();
            }
            MsgBox msg2 = new MsgBox();
            msg2.mensaje.Text = "Fin de Programa";
            msg2.ShowDialog();
            IMGSiguiente.Visible = false;
            IMGPlay.Visible = false;
        }

        private void Clear()
        {
            y55 = 1;
            tres55 = 1;
            tres66 = 1;
            uno55 = 1;
            zz = 0;
            x55 = 0;
            TXBAx.Text = ("");
            TXBBx.Text = ("");
            TXBCx.Text = ("");
            TXBDx.Text = ("");
            TXBIP.Text = ("");
            TXBZero.Text = ("");
            TXBCarry.Text = ("");
            TXBOnlyFans.Text = ("");
            TXBIR.Text = ("");
            TXBPC.Text = ("");
            TXBMAR.Text = ("");
            TXBMBR.Text = ("");
            TXBMostrar.Text = ("");
            TXBMostrar2.Text = ("");
            Auxi.IP = 0;
            Auxi.IP2 = 0;
            Auxi.AX[1] = Auxi.AX[2] = Auxi.AX[3] = Auxi.AX[4] = Auxi.AX[5] = Auxi.AX[6] = Auxi.AX[7] = Auxi.AX[8] = 0;
            Auxi.BX[1] = Auxi.BX[2] = Auxi.BX[3] = Auxi.BX[4] = Auxi.BX[5] = Auxi.BX[6] = Auxi.BX[7] = Auxi.BX[8] = 0;
            Auxi.CX[1] = Auxi.CX[2] = Auxi.CX[3] = Auxi.CX[4] = Auxi.CX[5] = Auxi.CX[6] = Auxi.CX[7] = Auxi.CX[8] = 0;
            Auxi.DX[1] = Auxi.DX[2] = Auxi.DX[3] = Auxi.DX[4] = Auxi.DX[5] = Auxi.DX[6] = Auxi.DX[7] = Auxi.DX[8] = 0;
            Auxi.Z = 0;
            Auxi.CY = 0;
            Auxi.OF = 0;
            Auxi.MAR = 0;
        }

        private void Traduce(int ins1, int ins2, int ins3, int ins4, int BorW, int RegDes1, int RegDes2, int Fromreg,
            int WaReg1, int WaReg2, int WaReg3, int WaReg4, int WaReg5, int WaReg6, int WaReg7, int WaReg8,
            int Bajo1, int Bajo2, int Bajo3, int Bajo4, int Bajo5, int Bajo6, int Bajo7, int Bajo8,
            int Alto1, int Alto2, int Alto3, int Alto4, int Alto5, int Alto6, int Alto7, int Alto8)
        {
            UControl U = new UControl();
            if (ins1 == 0 && ins2 == 0 && ins3 == 0 && ins4 == 0)
            {
                TXBMostrar2.Text += ("ADD ");
                if (RegDes1 == 0 && RegDes2 == 0)
                {
                    TXBMostrar2.Text += ("AX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 0 && RegDes2 == 1)
                {
                    TXBMostrar2.Text += ("BX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 1 && RegDes2 == 0)
                {
                    TXBMostrar2.Text += ("CX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 1 && RegDes2 == 1)
                {
                    TXBMostrar2.Text += ("DX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
            }
            else if (ins1 == 0 && ins2 == 0 && ins3 == 0 && ins4 == 1)
            {
                TXBMostrar2.Text += ("SUB ");
                if (RegDes1 == 0 && RegDes2 == 0)
                {
                    TXBMostrar2.Text += ("AX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 0 && RegDes2 == 1)
                {
                    TXBMostrar2.Text += ("BX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 1 && RegDes2 == 0)
                {
                    TXBMostrar2.Text += ("CX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 1 && RegDes2 == 1)
                {
                    TXBMostrar2.Text += ("DX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
            }
            else if (ins1 == 0 && ins2 == 0 && ins3 == 1 && ins4 == 0)
            {
                TXBMostrar2.Text += ("AND ");
                if (RegDes1 == 0 && RegDes2 == 0)
                {
                    TXBMostrar2.Text += ("AX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 0 && RegDes2 == 1)
                {
                    TXBMostrar2.Text += ("BX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 1 && RegDes2 == 0)
                {
                    TXBMostrar2.Text += ("CX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 1 && RegDes2 == 1)
                {
                    TXBMostrar2.Text += ("DX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
            }
            else if (ins1 == 0 && ins2 == 0 && ins3 == 1 && ins4 == 1)
            {
                TXBMostrar2.Text += ("OR ");
                if (RegDes1 == 0 && RegDes2 == 0)
                {
                    TXBMostrar2.Text += ("AX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 0 && RegDes2 == 1)
                {
                    TXBMostrar2.Text += ("BX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 1 && RegDes2 == 0)
                {
                    TXBMostrar2.Text += ("CX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 1 && RegDes2 == 1)
                {
                    TXBMostrar2.Text += ("DX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
            }
            else if (ins1 == 0 && ins2 == 1 && ins3 == 0 && ins4 == 0)
            {
                TXBMostrar2.Text += ("XOR ");
                if (RegDes1 == 0 && RegDes2 == 0)
                {
                    TXBMostrar2.Text += ("AX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 0 && RegDes2 == 1)
                {
                    TXBMostrar2.Text += ("BX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 1 && RegDes2 == 0)
                {
                    TXBMostrar2.Text += ("CX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 1 && RegDes2 == 1)
                {
                    TXBMostrar2.Text += ("DX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
            }
            else if (ins1 == 0 && ins2 == 1 && ins3 == 0 && ins4 == 1)
            {
                TXBMostrar2.Text += ("XNOR ");
                if (RegDes1 == 0 && RegDes2 == 0)
                {
                    TXBMostrar2.Text += ("AX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 0 && RegDes2 == 1)
                {
                    TXBMostrar2.Text += ("BX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 1 && RegDes2 == 0)
                {
                    TXBMostrar2.Text += ("CX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 1 && RegDes2 == 1)
                {
                    TXBMostrar2.Text += ("DX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
            }
            else if (ins1 == 0 && ins2 == 1 && ins3 == 1 && ins4 == 0)
            {
                TXBMostrar2.Text += ("NOT ");
                if (RegDes1 == 0 && RegDes2 == 0)
                {
                    TXBMostrar2.Text += ("AX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 0 && RegDes2 == 1)
                {
                    TXBMostrar2.Text += ("BX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 1 && RegDes2 == 0)
                {
                    TXBMostrar2.Text += ("CX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 1 && RegDes2 == 1)
                {
                    TXBMostrar2.Text += ("DX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
            }
            else if (ins1 == 0 && ins2 == 1 && ins3 == 1 && ins4 == 1)
            {
                TXBMostrar2.Text += ("MOVI ");
                if (RegDes1 == 0 && RegDes2 == 0)
                {
                    TXBMostrar2.Text += ("AX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 0 && RegDes2 == 1)
                {
                    TXBMostrar2.Text += ("BX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 1 && RegDes2 == 0)
                {
                    TXBMostrar2.Text += ("CX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 1 && RegDes2 == 1)
                {
                    TXBMostrar2.Text += ("DX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
            }
            else if (ins1 == 1 && ins2 == 0 && ins3 == 0 && ins4 == 0)
            {
                TXBMostrar2.Text += ("MOVxR ");
                if (RegDes1 == 0 && RegDes2 == 0)
                {
                    TXBMostrar2.Text += ("AX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 0 && RegDes2 == 1)
                {
                    TXBMostrar2.Text += ("BX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 1 && RegDes2 == 0)
                {
                    TXBMostrar2.Text += ("CX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
                else if (RegDes1 == 1 && RegDes2 == 1)
                {
                    TXBMostrar2.Text += ("DX, ");
                    if (Fromreg == 1)
                    {
                        string RegOrigen = U.QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8);
                        TXBMostrar2.Text += ("" + RegOrigen + Environment.NewLine);
                    }
                    else
                    {
                        string Dec = BinADec(Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8,
                            Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        TXBMostrar2.Text += ("" + Dec + Environment.NewLine);
                    }
                }
            }
            else
            {
                TXBMostrar2.Text += ("Instruccion invalida");
            }
        }

        private string BinADec(int Bajo1, int Bajo2, int Bajo3, int Bajo4, int Bajo5, int Bajo6, int Bajo7, int Bajo8,
            int Alto1, int Alto2, int Alto3, int Alto4, int Alto5, int Alto6, int Alto7, int Alto8)
        {
            long total = ((Bajo8 * 1) + (Bajo7 * 2) + (Bajo6 * 4) + (Bajo5 * 8) + (Bajo4 * 16) + (Bajo3 * 32) + (Bajo2 * 64) + (Bajo1 * 128) +
                (Alto8 * 256) + (Alto7 * 512) + (Alto6 * 1024) + (Alto5 * 2048) + (Alto4 * 4096) + (Alto3 * 8192) + (Alto2 * 16384) + (Alto1 * 32768));
            return (""+total);
        }
    }
}
