using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auxiliar;
using ALU;


namespace Unidad_de_control
{
    public class UControl
    {
        ALU16bits ALU = new ALU16bits();
        public void VerificarInstruccion(int ins1, int ins2, int ins3, int ins4, int BorW, int RegDes1, int RegDes2, int Fromreg, 
            int WaReg1, int WaReg2, int WaReg3, int WaReg4, int WaReg5, int WaReg6, int WaReg7, int WaReg8, 
            int Bajo1, int Bajo2, int Bajo3, int Bajo4, int Bajo5, int Bajo6, int Bajo7, int Bajo8, 
            int Alto1, int Alto2, int Alto3, int Alto4, int Alto5, int Alto6, int Alto7, int Alto8)
        {
            if ((ins1 == 0) && (ins2 == 0) && (ins3 == 0) && (ins4 == 0))
            {
                //Suma
                if (BorW==1) //Byte=1, Word=0, solo mostrar 2 lineas de codigo
                {
                    if (Fromreg == 1) //Viene de Reg=1, No viene de Reg=0
                    {
                        string RegOrigen = QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8); //pedir datos de ax
                        string RegDestino = QueRegistro2(RegDes1, RegDes2); //guardarlos en bx
                        SumaRegistro(RegOrigen, RegDestino);
                        Auxiliar.Auxiliar.IP = Auxiliar.Auxiliar.IP + 2;
                    }
                    else
                    {
                        string RegDestino2 = QueRegistro2(RegDes1, RegDes2);
                        SumaNoRegistro(RegDestino2, Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8, Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        Auxiliar.Auxiliar.IP = Auxiliar.Auxiliar.IP + 2;
                    }
                }
                else //mostrar 3 lineas de codigo
                {
                    if (Fromreg == 1)
                    {
                        string RegOrigen = QueRegistro4(WaReg1, WaReg2, WaReg3, WaReg4); //pedir datos de ax
                        string RegDestino = QueRegistro2(RegDes1, RegDes2); //guardarlos en bx
                        SumaRegistro(RegOrigen, RegDestino);
                        Auxiliar.Auxiliar.IP = Auxiliar.Auxiliar.IP + 3;
                    }
                    else
                    {
                        string RegDestino2 = QueRegistro2(RegDes1, RegDes2);
                        SumaNoRegistro(RegDestino2, Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8, Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        Auxiliar.Auxiliar.IP = Auxiliar.Auxiliar.IP + 3;
                    }
                }
            }
            else if ((ins1 == 0) && (ins2 == 0) && (ins3 == 0) && (ins4 == 1))
            {
                //Resta
                if (BorW == 1) //Byte=1, Word=0, solo mostrar 2 lineas de codigo
                {
                    if (Fromreg == 1) //Viene de Reg=1, No viene de Reg=0
                    {
                        string RegOrigen = QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8); //pedir datos de ax
                        string RegDestino = QueRegistro2(RegDes1, RegDes2); //guardarlos en bx
                        RestaRegistro(RegOrigen, RegDestino);
                        Auxiliar.Auxiliar.IP = Auxiliar.Auxiliar.IP + 2;
                    }
                    else
                    {
                        string RegDestino2 = QueRegistro2(RegDes1, RegDes2);
                        RestaNoRegistro(RegDestino2, Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8, Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        Auxiliar.Auxiliar.IP = Auxiliar.Auxiliar.IP + 2;
                    }
                }
                else //mostrar 3 lineas de codigo
                {
                    if (Fromreg == 1)
                    {
                        string RegOrigen = QueRegistro4(WaReg1, WaReg2, WaReg3, WaReg4); //pedir datos de ax
                        string RegDestino = QueRegistro2(RegDes1, RegDes2); //guardarlos en bx
                        RestaRegistro(RegOrigen, RegDestino);
                        Auxiliar.Auxiliar.IP = Auxiliar.Auxiliar.IP + 3;
                    }
                    else
                    {
                        string RegDestino2 = QueRegistro2(RegDes1, RegDes2);
                        RestaNoRegistro(RegDestino2, Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8, Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        Auxiliar.Auxiliar.IP = Auxiliar.Auxiliar.IP + 3;
                    }
                }
            }
            else if ((ins1 == 0) && (ins2 == 0) && (ins3 == 1) && (ins4 == 0))
            {
                //AND

            }
            else if ((ins1 == 0) && (ins2 == 0) && (ins3 == 1) && (ins4 == 1))
            {
                //OR
            }
            else if ((ins1 == 0) && (ins2 == 1) && (ins3 == 0) && (ins4 == 0))
            {
                //XOR
            }
            else if ((ins1 == 0) && (ins2 == 1) && (ins3 == 0) && (ins4 == 1))
            {
                //XNOR

            }
            else if ((ins1 == 0) && (ins2 == 1) && (ins3 == 1) && (ins4 == 0))
            {
                //NOT
            }
            else if ((ins1 == 0) && (ins2 == 1) && (ins3 == 1) && (ins4 == 1))
            {
                //MOVI (onamiento inmediato)
            }
            else if ((ins1 == 1) && (ins2 == 0) && (ins3 == 0) && (ins4 == 0))
            {
                //MOVxR (direccionamiento por registro)
            }
        }

        public string QueRegistro4(int WaReg5, int WaReg6, int WaReg7, int WaReg8)
        {
            if((WaReg5 == 0) && (WaReg6 == 0) && (WaReg7 == 0) && (WaReg8 == 0))
            {
                //AX
                return ("AX");
            }
            else if((WaReg5 == 0) && (WaReg6 == 0) && (WaReg7 == 0) && (WaReg8 == 1))
            {
                //BX
                return ("BX");
            }
            else if ((WaReg5 == 0) && (WaReg6 == 0) && (WaReg7 == 1) && (WaReg8 == 0))
            {
                //CX
                return ("CX");
            }
            else if ((WaReg5 == 0) && (WaReg6 == 0) && (WaReg7 == 1) && (WaReg8 == 1))
            {
                //DX
                return ("DX");
            }
            else
            {
                return null;
            }
        }

        public string QueRegistro2(int RegDes1, int RegDes2)
        {
            if ((RegDes1 == 0) && (RegDes2 == 0))
            {
                //AX
                return ("AX");
            }
            else if ((RegDes1 == 0) && (RegDes2 == 1))
            {
                //BX
                return ("BX");
            }
            else if ((RegDes1 == 1) && (RegDes2 == 0))
            {
                //CX
                return ("CX");
            }
            else if ((RegDes1 == 1) && (RegDes2 == 1))
            {
                //DX
                return ("DX");
            }
            else
            {
                return null;
            }
        }

        public void SumaNoRegistro(string regdest2, int bajo1, int bajo2, int bajo3, int bajo4, int bajo5, int bajo6, int bajo7, int bajo8, 
            int alto1, int alto2, int alto3, int alto4, int alto5, int alto6, int alto7, int alto8)
        {
            if (regdest2 == "AX")
            {
                ALU.Suma(alto1, alto2, alto3, alto4, alto5, alto6, alto7, alto8, bajo1, bajo2, bajo3, bajo4, bajo5, bajo6, bajo7, bajo8);
                Auxiliar.Auxiliar.AX[8] = Auxiliar.Auxiliar.SR0;
                Auxiliar.Auxiliar.AX[7] = Auxiliar.Auxiliar.SR1;
                Auxiliar.Auxiliar.AX[6] = Auxiliar.Auxiliar.SR2;
                Auxiliar.Auxiliar.AX[5] = Auxiliar.Auxiliar.SR3;
                Auxiliar.Auxiliar.AX[4] = Auxiliar.Auxiliar.SR4;
                Auxiliar.Auxiliar.AX[3] = Auxiliar.Auxiliar.SR5;
                Auxiliar.Auxiliar.AX[2] = Auxiliar.Auxiliar.SR6;
                Auxiliar.Auxiliar.AX[1] = Auxiliar.Auxiliar.SR7;
            }
            else if (regdest2 == "BX")
            {
                ALU.Suma(alto1, alto2, alto3, alto4, alto5, alto6, alto7, alto8, bajo1, bajo2, bajo3, bajo4, bajo5, bajo6, bajo7, bajo8);
                Auxiliar.Auxiliar.BX[8] = Auxiliar.Auxiliar.SR0;
                Auxiliar.Auxiliar.BX[7] = Auxiliar.Auxiliar.SR1;
                Auxiliar.Auxiliar.BX[6] = Auxiliar.Auxiliar.SR2;
                Auxiliar.Auxiliar.BX[5] = Auxiliar.Auxiliar.SR3;
                Auxiliar.Auxiliar.BX[4] = Auxiliar.Auxiliar.SR4;
                Auxiliar.Auxiliar.BX[3] = Auxiliar.Auxiliar.SR5;
                Auxiliar.Auxiliar.BX[2] = Auxiliar.Auxiliar.SR6;
                Auxiliar.Auxiliar.BX[1] = Auxiliar.Auxiliar.SR7;
            }
            else if (regdest2 == "CX")
            {
                ALU.Suma(alto1, alto2, alto3, alto4, alto5, alto6, alto7, alto8, bajo1, bajo2, bajo3, bajo4, bajo5, bajo6, bajo7, bajo8);
                Auxiliar.Auxiliar.CX[8] = Auxiliar.Auxiliar.SR0;
                Auxiliar.Auxiliar.CX[7] = Auxiliar.Auxiliar.SR1;
                Auxiliar.Auxiliar.CX[6] = Auxiliar.Auxiliar.SR2;
                Auxiliar.Auxiliar.CX[5] = Auxiliar.Auxiliar.SR3;
                Auxiliar.Auxiliar.CX[4] = Auxiliar.Auxiliar.SR4;
                Auxiliar.Auxiliar.CX[3] = Auxiliar.Auxiliar.SR5;
                Auxiliar.Auxiliar.CX[2] = Auxiliar.Auxiliar.SR6;
                Auxiliar.Auxiliar.CX[1] = Auxiliar.Auxiliar.SR7;
            }
            else if (regdest2 == "DX")
            {
                ALU.Suma(alto1, alto2, alto3, alto4, alto5, alto6, alto7, alto8, bajo1, bajo2, bajo3, bajo4, bajo5, bajo6, bajo7, bajo8);
                Auxiliar.Auxiliar.DX[8] = Auxiliar.Auxiliar.SR0;
                Auxiliar.Auxiliar.DX[7] = Auxiliar.Auxiliar.SR1;
                Auxiliar.Auxiliar.DX[6] = Auxiliar.Auxiliar.SR2;
                Auxiliar.Auxiliar.DX[5] = Auxiliar.Auxiliar.SR3;
                Auxiliar.Auxiliar.DX[4] = Auxiliar.Auxiliar.SR4;
                Auxiliar.Auxiliar.DX[3] = Auxiliar.Auxiliar.SR5;
                Auxiliar.Auxiliar.DX[2] = Auxiliar.Auxiliar.SR6;
                Auxiliar.Auxiliar.DX[1] = Auxiliar.Auxiliar.SR7;
            }
        }

        public void SumaRegistro(string Rega, string Regb)
        {
            if ((Rega==("AX")) && (Regb == ("AX"))) //1=7, 1=6, 1=5, 1=4, etc.
            {
                ALU.Suma(Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8], //Registro a
                    Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8]); //Registro b
                Auxiliar.Auxiliar.AX[8] = Auxiliar.Auxiliar.SR0;
                Auxiliar.Auxiliar.AX[7] = Auxiliar.Auxiliar.SR1;
                Auxiliar.Auxiliar.AX[6] = Auxiliar.Auxiliar.SR2;
                Auxiliar.Auxiliar.AX[5] = Auxiliar.Auxiliar.SR3;
                Auxiliar.Auxiliar.AX[4] = Auxiliar.Auxiliar.SR4;
                Auxiliar.Auxiliar.AX[3] = Auxiliar.Auxiliar.SR5;
                Auxiliar.Auxiliar.AX[2] = Auxiliar.Auxiliar.SR6;
                Auxiliar.Auxiliar.AX[1] = Auxiliar.Auxiliar.SR7;
            }
            else if ((Rega == ("AX")) && (Regb == ("BX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8], //Registro a
                   Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8]); //Registro b
                Auxiliar.Auxiliar.BX[8] = Auxiliar.Auxiliar.SR0;
                Auxiliar.Auxiliar.BX[7] = Auxiliar.Auxiliar.SR1;
                Auxiliar.Auxiliar.BX[6] = Auxiliar.Auxiliar.SR2;
                Auxiliar.Auxiliar.BX[5] = Auxiliar.Auxiliar.SR3;
                Auxiliar.Auxiliar.BX[4] = Auxiliar.Auxiliar.SR4;
                Auxiliar.Auxiliar.BX[3] = Auxiliar.Auxiliar.SR5;
                Auxiliar.Auxiliar.BX[2] = Auxiliar.Auxiliar.SR6;
                Auxiliar.Auxiliar.BX[1] = Auxiliar.Auxiliar.SR7;
            }
            else if ((Rega == ("AX")) && (Regb == ("CX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8], //Registro a
                   Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8]); //Registro b
                Auxiliar.Auxiliar.CX[8] = Auxiliar.Auxiliar.SR0;
                Auxiliar.Auxiliar.CX[7] = Auxiliar.Auxiliar.SR1;
                Auxiliar.Auxiliar.CX[6] = Auxiliar.Auxiliar.SR2;
                Auxiliar.Auxiliar.CX[5] = Auxiliar.Auxiliar.SR3;
                Auxiliar.Auxiliar.CX[4] = Auxiliar.Auxiliar.SR4;
                Auxiliar.Auxiliar.CX[3] = Auxiliar.Auxiliar.SR5;
                Auxiliar.Auxiliar.CX[2] = Auxiliar.Auxiliar.SR6;
                Auxiliar.Auxiliar.CX[1] = Auxiliar.Auxiliar.SR7;
            }
            else if ((Rega == ("AX")) && (Regb == ("DX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8], //Registro a
                   Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8]); //Registro b
                Auxiliar.Auxiliar.DX[8] = Auxiliar.Auxiliar.SR0;
                Auxiliar.Auxiliar.DX[7] = Auxiliar.Auxiliar.SR1;
                Auxiliar.Auxiliar.DX[6] = Auxiliar.Auxiliar.SR2;
                Auxiliar.Auxiliar.DX[5] = Auxiliar.Auxiliar.SR3;
                Auxiliar.Auxiliar.DX[4] = Auxiliar.Auxiliar.SR4;
                Auxiliar.Auxiliar.DX[3] = Auxiliar.Auxiliar.SR5;
                Auxiliar.Auxiliar.DX[2] = Auxiliar.Auxiliar.SR6;
                Auxiliar.Auxiliar.DX[1] = Auxiliar.Auxiliar.SR7;
            }
            else if ((Rega == ("BX")) && (Regb == ("AX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8],
                    Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8]);
                Auxiliar.Auxiliar.AX[8] = Auxiliar.Auxiliar.SR0;
                Auxiliar.Auxiliar.AX[7] = Auxiliar.Auxiliar.SR1;
                Auxiliar.Auxiliar.AX[6] = Auxiliar.Auxiliar.SR2;
                Auxiliar.Auxiliar.AX[5] = Auxiliar.Auxiliar.SR3;
                Auxiliar.Auxiliar.AX[4] = Auxiliar.Auxiliar.SR4;
                Auxiliar.Auxiliar.AX[3] = Auxiliar.Auxiliar.SR5;
                Auxiliar.Auxiliar.AX[2] = Auxiliar.Auxiliar.SR6;
                Auxiliar.Auxiliar.AX[1] = Auxiliar.Auxiliar.SR7;
            }
            else if ((Rega == ("BX")) && (Regb == ("BX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8],
                    Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8]);
                Auxiliar.Auxiliar.BX[8] = Auxiliar.Auxiliar.SR0;
                Auxiliar.Auxiliar.BX[7] = Auxiliar.Auxiliar.SR1;
                Auxiliar.Auxiliar.BX[6] = Auxiliar.Auxiliar.SR2;
                Auxiliar.Auxiliar.BX[5] = Auxiliar.Auxiliar.SR3;
                Auxiliar.Auxiliar.BX[4] = Auxiliar.Auxiliar.SR4;
                Auxiliar.Auxiliar.BX[3] = Auxiliar.Auxiliar.SR5;
                Auxiliar.Auxiliar.BX[2] = Auxiliar.Auxiliar.SR6;
                Auxiliar.Auxiliar.BX[1] = Auxiliar.Auxiliar.SR7;
            }
            else if ((Rega == ("BX")) && (Regb == ("CX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8],
                   Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8]); //Registro b
                Auxiliar.Auxiliar.CX[8] = Auxiliar.Auxiliar.SR0;
                Auxiliar.Auxiliar.CX[7] = Auxiliar.Auxiliar.SR1;
                Auxiliar.Auxiliar.CX[6] = Auxiliar.Auxiliar.SR2;
                Auxiliar.Auxiliar.CX[5] = Auxiliar.Auxiliar.SR3;
                Auxiliar.Auxiliar.CX[4] = Auxiliar.Auxiliar.SR4;
                Auxiliar.Auxiliar.CX[3] = Auxiliar.Auxiliar.SR5;
                Auxiliar.Auxiliar.CX[2] = Auxiliar.Auxiliar.SR6;
                Auxiliar.Auxiliar.CX[1] = Auxiliar.Auxiliar.SR7;
            }
            else if ((Rega == ("BX")) && (Regb == ("DX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8],
                   Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8]); //Registro b
                Auxiliar.Auxiliar.DX[8] = Auxiliar.Auxiliar.SR0;
                Auxiliar.Auxiliar.DX[7] = Auxiliar.Auxiliar.SR1;
                Auxiliar.Auxiliar.DX[6] = Auxiliar.Auxiliar.SR2;
                Auxiliar.Auxiliar.DX[5] = Auxiliar.Auxiliar.SR3;
                Auxiliar.Auxiliar.DX[4] = Auxiliar.Auxiliar.SR4;
                Auxiliar.Auxiliar.DX[3] = Auxiliar.Auxiliar.SR5;
                Auxiliar.Auxiliar.DX[2] = Auxiliar.Auxiliar.SR6;
                Auxiliar.Auxiliar.DX[1] = Auxiliar.Auxiliar.SR7;
            }
            else if ((Rega == ("CX")) && (Regb == ("AX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8],
                    Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8]); //Registro b
                Auxiliar.Auxiliar.AX[8] = Auxiliar.Auxiliar.SR0;
                Auxiliar.Auxiliar.AX[7] = Auxiliar.Auxiliar.SR1;
                Auxiliar.Auxiliar.AX[6] = Auxiliar.Auxiliar.SR2;
                Auxiliar.Auxiliar.AX[5] = Auxiliar.Auxiliar.SR3;
                Auxiliar.Auxiliar.AX[4] = Auxiliar.Auxiliar.SR4;
                Auxiliar.Auxiliar.AX[3] = Auxiliar.Auxiliar.SR5;
                Auxiliar.Auxiliar.AX[2] = Auxiliar.Auxiliar.SR6;
                Auxiliar.Auxiliar.AX[1] = Auxiliar.Auxiliar.SR7;
            }
            else if ((Rega == ("CX")) && (Regb == ("BX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8],
                    Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8]);
                Auxiliar.Auxiliar.BX[8] = Auxiliar.Auxiliar.SR0;
                Auxiliar.Auxiliar.BX[7] = Auxiliar.Auxiliar.SR1;
                Auxiliar.Auxiliar.BX[6] = Auxiliar.Auxiliar.SR2;
                Auxiliar.Auxiliar.BX[5] = Auxiliar.Auxiliar.SR3;
                Auxiliar.Auxiliar.BX[4] = Auxiliar.Auxiliar.SR4;
                Auxiliar.Auxiliar.BX[3] = Auxiliar.Auxiliar.SR5;
                Auxiliar.Auxiliar.BX[2] = Auxiliar.Auxiliar.SR6;
                Auxiliar.Auxiliar.BX[1] = Auxiliar.Auxiliar.SR7;
            }
            else if ((Rega == ("CX")) && (Regb == ("CX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8],
                    Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8]); //Registro b
                Auxiliar.Auxiliar.CX[8] = Auxiliar.Auxiliar.SR0;
                Auxiliar.Auxiliar.CX[7] = Auxiliar.Auxiliar.SR1;
                Auxiliar.Auxiliar.CX[6] = Auxiliar.Auxiliar.SR2;
                Auxiliar.Auxiliar.CX[5] = Auxiliar.Auxiliar.SR3;
                Auxiliar.Auxiliar.CX[4] = Auxiliar.Auxiliar.SR4;
                Auxiliar.Auxiliar.CX[3] = Auxiliar.Auxiliar.SR5;
                Auxiliar.Auxiliar.CX[2] = Auxiliar.Auxiliar.SR6;
                Auxiliar.Auxiliar.CX[1] = Auxiliar.Auxiliar.SR7;
            }
            else if ((Rega == ("CX")) && (Regb == ("DX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8],
                    Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8]); //Registro b
                Auxiliar.Auxiliar.DX[8] = Auxiliar.Auxiliar.SR0;
                Auxiliar.Auxiliar.DX[7] = Auxiliar.Auxiliar.SR1;
                Auxiliar.Auxiliar.DX[6] = Auxiliar.Auxiliar.SR2;
                Auxiliar.Auxiliar.DX[5] = Auxiliar.Auxiliar.SR3;
                Auxiliar.Auxiliar.DX[4] = Auxiliar.Auxiliar.SR4;
                Auxiliar.Auxiliar.DX[3] = Auxiliar.Auxiliar.SR5;
                Auxiliar.Auxiliar.DX[2] = Auxiliar.Auxiliar.SR6;
                Auxiliar.Auxiliar.DX[1] = Auxiliar.Auxiliar.SR7;
            }
            else if ((Rega == ("DX")) && (Regb == ("AX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8],
                    Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8]); //Registro b
                Auxiliar.Auxiliar.AX[8] = Auxiliar.Auxiliar.SR0;
                Auxiliar.Auxiliar.AX[7] = Auxiliar.Auxiliar.SR1;
                Auxiliar.Auxiliar.AX[6] = Auxiliar.Auxiliar.SR2;
                Auxiliar.Auxiliar.AX[5] = Auxiliar.Auxiliar.SR3;
                Auxiliar.Auxiliar.AX[4] = Auxiliar.Auxiliar.SR4;
                Auxiliar.Auxiliar.AX[3] = Auxiliar.Auxiliar.SR5;
                Auxiliar.Auxiliar.AX[2] = Auxiliar.Auxiliar.SR6;
                Auxiliar.Auxiliar.AX[1] = Auxiliar.Auxiliar.SR7;
            }
            else if ((Rega == ("DX")) && (Regb == ("BX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8],
                    Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8]);
                Auxiliar.Auxiliar.BX[8] = Auxiliar.Auxiliar.SR0;
                Auxiliar.Auxiliar.BX[7] = Auxiliar.Auxiliar.SR1;
                Auxiliar.Auxiliar.BX[6] = Auxiliar.Auxiliar.SR2;
                Auxiliar.Auxiliar.BX[5] = Auxiliar.Auxiliar.SR3;
                Auxiliar.Auxiliar.BX[4] = Auxiliar.Auxiliar.SR4;
                Auxiliar.Auxiliar.BX[3] = Auxiliar.Auxiliar.SR5;
                Auxiliar.Auxiliar.BX[2] = Auxiliar.Auxiliar.SR6;
                Auxiliar.Auxiliar.BX[1] = Auxiliar.Auxiliar.SR7;
            }
            else if ((Rega == ("DX")) && (Regb == ("CX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8],
                    Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8]); //Registro b
                Auxiliar.Auxiliar.CX[8] = Auxiliar.Auxiliar.SR0;
                Auxiliar.Auxiliar.CX[7] = Auxiliar.Auxiliar.SR1;
                Auxiliar.Auxiliar.CX[6] = Auxiliar.Auxiliar.SR2;
                Auxiliar.Auxiliar.CX[5] = Auxiliar.Auxiliar.SR3;
                Auxiliar.Auxiliar.CX[4] = Auxiliar.Auxiliar.SR4;
                Auxiliar.Auxiliar.CX[3] = Auxiliar.Auxiliar.SR5;
                Auxiliar.Auxiliar.CX[2] = Auxiliar.Auxiliar.SR6;
                Auxiliar.Auxiliar.CX[1] = Auxiliar.Auxiliar.SR7;
            }
            else if ((Rega == ("DX")) && (Regb == ("DX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8],
                    Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8]); //Registro b
                Auxiliar.Auxiliar.DX[8] = Auxiliar.Auxiliar.SR0;
                Auxiliar.Auxiliar.DX[7] = Auxiliar.Auxiliar.SR1;
                Auxiliar.Auxiliar.DX[6] = Auxiliar.Auxiliar.SR2;
                Auxiliar.Auxiliar.DX[5] = Auxiliar.Auxiliar.SR3;
                Auxiliar.Auxiliar.DX[4] = Auxiliar.Auxiliar.SR4;
                Auxiliar.Auxiliar.DX[3] = Auxiliar.Auxiliar.SR5;
                Auxiliar.Auxiliar.DX[2] = Auxiliar.Auxiliar.SR6;
                Auxiliar.Auxiliar.DX[1] = Auxiliar.Auxiliar.SR7;
            }
        }

        public void RestaNoRegistro(string regdest2, int bajo1, int bajo2, int bajo3, int bajo4, int bajo5, int bajo6, int bajo7, int bajo8,
            int alto1, int alto2, int alto3, int alto4, int alto5, int alto6, int alto7, int alto8)
        {
            if (regdest2 == "AX")
            {
                ALU.Resta(alto1, alto2, alto3, alto4, alto5, alto6, alto7, alto8, bajo1, bajo2, bajo3, bajo4, bajo5, bajo6, bajo7, bajo8);
                Auxiliar.Auxiliar.AX[8] = Auxiliar.Auxiliar.RR0;
                Auxiliar.Auxiliar.AX[7] = Auxiliar.Auxiliar.RR1;
                Auxiliar.Auxiliar.AX[6] = Auxiliar.Auxiliar.RR2;
                Auxiliar.Auxiliar.AX[5] = Auxiliar.Auxiliar.RR3;
                Auxiliar.Auxiliar.AX[4] = Auxiliar.Auxiliar.RR4;
                Auxiliar.Auxiliar.AX[3] = Auxiliar.Auxiliar.RR5;
                Auxiliar.Auxiliar.AX[2] = Auxiliar.Auxiliar.RR6;
                Auxiliar.Auxiliar.AX[1] = Auxiliar.Auxiliar.RR7;
            }
            else if (regdest2 == "BX")
            {
                ALU.Resta(alto1, alto2, alto3, alto4, alto5, alto6, alto7, alto8, bajo1, bajo2, bajo3, bajo4, bajo5, bajo6, bajo7, bajo8);
                Auxiliar.Auxiliar.BX[8] = Auxiliar.Auxiliar.RR0;
                Auxiliar.Auxiliar.BX[7] = Auxiliar.Auxiliar.RR1;
                Auxiliar.Auxiliar.BX[6] = Auxiliar.Auxiliar.RR2;
                Auxiliar.Auxiliar.BX[5] = Auxiliar.Auxiliar.RR3;
                Auxiliar.Auxiliar.BX[4] = Auxiliar.Auxiliar.RR4;
                Auxiliar.Auxiliar.BX[3] = Auxiliar.Auxiliar.RR5;
                Auxiliar.Auxiliar.BX[2] = Auxiliar.Auxiliar.RR6;
                Auxiliar.Auxiliar.BX[1] = Auxiliar.Auxiliar.RR7;
            }
            else if (regdest2 == "CX")
            {
                ALU.Resta(alto1, alto2, alto3, alto4, alto5, alto6, alto7, alto8, bajo1, bajo2, bajo3, bajo4, bajo5, bajo6, bajo7, bajo8);
                Auxiliar.Auxiliar.CX[8] = Auxiliar.Auxiliar.RR0;
                Auxiliar.Auxiliar.CX[7] = Auxiliar.Auxiliar.RR1;
                Auxiliar.Auxiliar.CX[6] = Auxiliar.Auxiliar.RR2;
                Auxiliar.Auxiliar.CX[5] = Auxiliar.Auxiliar.RR3;
                Auxiliar.Auxiliar.CX[4] = Auxiliar.Auxiliar.RR4;
                Auxiliar.Auxiliar.CX[3] = Auxiliar.Auxiliar.RR5;
                Auxiliar.Auxiliar.CX[2] = Auxiliar.Auxiliar.RR6;
                Auxiliar.Auxiliar.CX[1] = Auxiliar.Auxiliar.RR7;
            }
            else if (regdest2 == "DX")
            {
                ALU.Resta(alto1, alto2, alto3, alto4, alto5, alto6, alto7, alto8, bajo1, bajo2, bajo3, bajo4, bajo5, bajo6, bajo7, bajo8);
                Auxiliar.Auxiliar.DX[8] = Auxiliar.Auxiliar.RR0;
                Auxiliar.Auxiliar.DX[7] = Auxiliar.Auxiliar.RR1;
                Auxiliar.Auxiliar.DX[6] = Auxiliar.Auxiliar.RR2;
                Auxiliar.Auxiliar.DX[5] = Auxiliar.Auxiliar.RR3;
                Auxiliar.Auxiliar.DX[4] = Auxiliar.Auxiliar.RR4;
                Auxiliar.Auxiliar.DX[3] = Auxiliar.Auxiliar.RR5;
                Auxiliar.Auxiliar.DX[2] = Auxiliar.Auxiliar.RR6;
                Auxiliar.Auxiliar.DX[1] = Auxiliar.Auxiliar.RR7;
            }
        }

        public void RestaRegistro(string Rega, string Regb)
        {
            if ((Rega == ("AX")) && (Regb == ("AX"))) //1=7, 1=6, 1=5, 1=4, etc.
            {
                ALU.Resta(Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8], //Registro a
                    Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8]); //Registro b
                Auxiliar.Auxiliar.AX[8] = Auxiliar.Auxiliar.RR0;
                Auxiliar.Auxiliar.AX[7] = Auxiliar.Auxiliar.RR1;
                Auxiliar.Auxiliar.AX[6] = Auxiliar.Auxiliar.RR2;
                Auxiliar.Auxiliar.AX[5] = Auxiliar.Auxiliar.RR3;
                Auxiliar.Auxiliar.AX[4] = Auxiliar.Auxiliar.RR4;
                Auxiliar.Auxiliar.AX[3] = Auxiliar.Auxiliar.RR5;
                Auxiliar.Auxiliar.AX[2] = Auxiliar.Auxiliar.RR6;
                Auxiliar.Auxiliar.AX[1] = Auxiliar.Auxiliar.RR7;
            }
            else if ((Rega == ("AX")) && (Regb == ("BX")))
            {
                ALU.Resta(Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8], //Registro b
                Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8]); //Registro a
                Auxiliar.Auxiliar.BX[8] = Auxiliar.Auxiliar.RR0;
                Auxiliar.Auxiliar.BX[7] = Auxiliar.Auxiliar.RR1;
                Auxiliar.Auxiliar.BX[6] = Auxiliar.Auxiliar.RR2;
                Auxiliar.Auxiliar.BX[5] = Auxiliar.Auxiliar.RR3;
                Auxiliar.Auxiliar.BX[4] = Auxiliar.Auxiliar.RR4;
                Auxiliar.Auxiliar.BX[3] = Auxiliar.Auxiliar.RR5;
                Auxiliar.Auxiliar.BX[2] = Auxiliar.Auxiliar.RR6;
                Auxiliar.Auxiliar.BX[1] = Auxiliar.Auxiliar.RR7;//AQUI ME QUEDE
            }
            else if ((Rega == ("AX")) && (Regb == ("CX")))
            {
                ALU.Resta(Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8], //Registro b 
                   Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8]);//Registro a 
                Auxiliar.Auxiliar.CX[8] = Auxiliar.Auxiliar.RR0;
                Auxiliar.Auxiliar.CX[7] = Auxiliar.Auxiliar.RR1;
                Auxiliar.Auxiliar.CX[6] = Auxiliar.Auxiliar.RR2;
                Auxiliar.Auxiliar.CX[5] = Auxiliar.Auxiliar.RR3;
                Auxiliar.Auxiliar.CX[4] = Auxiliar.Auxiliar.RR4;
                Auxiliar.Auxiliar.CX[3] = Auxiliar.Auxiliar.RR5;
                Auxiliar.Auxiliar.CX[2] = Auxiliar.Auxiliar.RR6;
                Auxiliar.Auxiliar.CX[1] = Auxiliar.Auxiliar.RR7;
            }
            else if ((Rega == ("AX")) && (Regb == ("DX")))
            {
                ALU.Resta(Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8] ,//Registro b 
                   Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8]);//Registro a 
                Auxiliar.Auxiliar.DX[8] = Auxiliar.Auxiliar.RR0;
                Auxiliar.Auxiliar.DX[7] = Auxiliar.Auxiliar.RR1;
                Auxiliar.Auxiliar.DX[6] = Auxiliar.Auxiliar.RR2;
                Auxiliar.Auxiliar.DX[5] = Auxiliar.Auxiliar.RR3;
                Auxiliar.Auxiliar.DX[4] = Auxiliar.Auxiliar.RR4;
                Auxiliar.Auxiliar.DX[3] = Auxiliar.Auxiliar.RR5;
                Auxiliar.Auxiliar.DX[2] = Auxiliar.Auxiliar.RR6;
                Auxiliar.Auxiliar.DX[1] = Auxiliar.Auxiliar.RR7;
            }
            else if ((Rega == ("BX")) && (Regb == ("AX")))
            {
                ALU.Resta(Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8],
                    Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8]);
                Auxiliar.Auxiliar.AX[8] = Auxiliar.Auxiliar.RR0;
                Auxiliar.Auxiliar.AX[7] = Auxiliar.Auxiliar.RR1;
                Auxiliar.Auxiliar.AX[6] = Auxiliar.Auxiliar.RR2;
                Auxiliar.Auxiliar.AX[5] = Auxiliar.Auxiliar.RR3;
                Auxiliar.Auxiliar.AX[4] = Auxiliar.Auxiliar.RR4;
                Auxiliar.Auxiliar.AX[3] = Auxiliar.Auxiliar.RR5;
                Auxiliar.Auxiliar.AX[2] = Auxiliar.Auxiliar.RR6;
                Auxiliar.Auxiliar.AX[1] = Auxiliar.Auxiliar.RR7;
            }
            else if ((Rega == ("BX")) && (Regb == ("BX")))
            {
                ALU.Resta(Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8],
                    Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8]);
                Auxiliar.Auxiliar.BX[8] = Auxiliar.Auxiliar.RR0;
                Auxiliar.Auxiliar.BX[7] = Auxiliar.Auxiliar.RR1;
                Auxiliar.Auxiliar.BX[6] = Auxiliar.Auxiliar.RR2;
                Auxiliar.Auxiliar.BX[5] = Auxiliar.Auxiliar.RR3;
                Auxiliar.Auxiliar.BX[4] = Auxiliar.Auxiliar.RR4;
                Auxiliar.Auxiliar.BX[3] = Auxiliar.Auxiliar.RR5;
                Auxiliar.Auxiliar.BX[2] = Auxiliar.Auxiliar.RR6;
                Auxiliar.Auxiliar.BX[1] = Auxiliar.Auxiliar.RR7;
            }
            else if ((Rega == ("BX")) && (Regb == ("CX")))
            {
                ALU.Resta(Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8], //Registro b
                   Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8]);
                Auxiliar.Auxiliar.CX[8] = Auxiliar.Auxiliar.RR0;
                Auxiliar.Auxiliar.CX[7] = Auxiliar.Auxiliar.RR1;
                Auxiliar.Auxiliar.CX[6] = Auxiliar.Auxiliar.RR2;
                Auxiliar.Auxiliar.CX[5] = Auxiliar.Auxiliar.RR3;
                Auxiliar.Auxiliar.CX[4] = Auxiliar.Auxiliar.RR4;
                Auxiliar.Auxiliar.CX[3] = Auxiliar.Auxiliar.RR5;
                Auxiliar.Auxiliar.CX[2] = Auxiliar.Auxiliar.RR6;
                Auxiliar.Auxiliar.CX[1] = Auxiliar.Auxiliar.RR7;
            }
            else if ((Rega == ("BX")) && (Regb == ("DX")))
            {
                ALU.Resta(Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8], //Registro b
                   Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8]);
                Auxiliar.Auxiliar.DX[8] = Auxiliar.Auxiliar.RR0;
                Auxiliar.Auxiliar.DX[7] = Auxiliar.Auxiliar.RR1;
                Auxiliar.Auxiliar.DX[6] = Auxiliar.Auxiliar.RR2;
                Auxiliar.Auxiliar.DX[5] = Auxiliar.Auxiliar.RR3;
                Auxiliar.Auxiliar.DX[4] = Auxiliar.Auxiliar.RR4;
                Auxiliar.Auxiliar.DX[3] = Auxiliar.Auxiliar.RR5;
                Auxiliar.Auxiliar.DX[2] = Auxiliar.Auxiliar.RR6;
                Auxiliar.Auxiliar.DX[1] = Auxiliar.Auxiliar.RR7;
            }
            else if ((Rega == ("CX")) && (Regb == ("AX")))
            {
                ALU.Resta(Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8], //Registro b
                    Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8]);
                Auxiliar.Auxiliar.AX[8] = Auxiliar.Auxiliar.RR0;
                Auxiliar.Auxiliar.AX[7] = Auxiliar.Auxiliar.RR1;
                Auxiliar.Auxiliar.AX[6] = Auxiliar.Auxiliar.RR2;
                Auxiliar.Auxiliar.AX[5] = Auxiliar.Auxiliar.RR3;
                Auxiliar.Auxiliar.AX[4] = Auxiliar.Auxiliar.RR4;
                Auxiliar.Auxiliar.AX[3] = Auxiliar.Auxiliar.RR5;
                Auxiliar.Auxiliar.AX[2] = Auxiliar.Auxiliar.RR6;
                Auxiliar.Auxiliar.AX[1] = Auxiliar.Auxiliar.RR7;
            }
            else if ((Rega == ("CX")) && (Regb == ("BX")))
            {
                ALU.Resta(Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8],
                    Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8]);
                Auxiliar.Auxiliar.BX[8] = Auxiliar.Auxiliar.RR0;
                Auxiliar.Auxiliar.BX[7] = Auxiliar.Auxiliar.RR1;
                Auxiliar.Auxiliar.BX[6] = Auxiliar.Auxiliar.RR2;
                Auxiliar.Auxiliar.BX[5] = Auxiliar.Auxiliar.RR3;
                Auxiliar.Auxiliar.BX[4] = Auxiliar.Auxiliar.RR4;
                Auxiliar.Auxiliar.BX[3] = Auxiliar.Auxiliar.RR5;
                Auxiliar.Auxiliar.BX[2] = Auxiliar.Auxiliar.RR6;
                Auxiliar.Auxiliar.BX[1] = Auxiliar.Auxiliar.RR7;
            }
            else if ((Rega == ("CX")) && (Regb == ("CX")))
            {
                ALU.Resta(Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8],
                    Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8]); //Registro b
                Auxiliar.Auxiliar.CX[8] = Auxiliar.Auxiliar.RR0;
                Auxiliar.Auxiliar.CX[7] = Auxiliar.Auxiliar.RR1;
                Auxiliar.Auxiliar.CX[6] = Auxiliar.Auxiliar.RR2;
                Auxiliar.Auxiliar.CX[5] = Auxiliar.Auxiliar.RR3;
                Auxiliar.Auxiliar.CX[4] = Auxiliar.Auxiliar.RR4;
                Auxiliar.Auxiliar.CX[3] = Auxiliar.Auxiliar.RR5;
                Auxiliar.Auxiliar.CX[2] = Auxiliar.Auxiliar.RR6;
                Auxiliar.Auxiliar.CX[1] = Auxiliar.Auxiliar.RR7;
            }
            else if ((Rega == ("CX")) && (Regb == ("DX")))
            {
                ALU.Resta(Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8], //Registro b
                    Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8]);
                Auxiliar.Auxiliar.DX[8] = Auxiliar.Auxiliar.RR0;
                Auxiliar.Auxiliar.DX[7] = Auxiliar.Auxiliar.RR1;
                Auxiliar.Auxiliar.DX[6] = Auxiliar.Auxiliar.RR2;
                Auxiliar.Auxiliar.DX[5] = Auxiliar.Auxiliar.RR3;
                Auxiliar.Auxiliar.DX[4] = Auxiliar.Auxiliar.RR4;
                Auxiliar.Auxiliar.DX[3] = Auxiliar.Auxiliar.RR5;
                Auxiliar.Auxiliar.DX[2] = Auxiliar.Auxiliar.RR6;
                Auxiliar.Auxiliar.DX[1] = Auxiliar.Auxiliar.RR7;
            }
            else if ((Rega == ("DX")) && (Regb == ("AX")))
            {
                ALU.Resta(Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8], //Registro b
                    Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8]);
                Auxiliar.Auxiliar.AX[8] = Auxiliar.Auxiliar.RR0;
                Auxiliar.Auxiliar.AX[7] = Auxiliar.Auxiliar.RR1;
                Auxiliar.Auxiliar.AX[6] = Auxiliar.Auxiliar.RR2;
                Auxiliar.Auxiliar.AX[5] = Auxiliar.Auxiliar.RR3;
                Auxiliar.Auxiliar.AX[4] = Auxiliar.Auxiliar.RR4;
                Auxiliar.Auxiliar.AX[3] = Auxiliar.Auxiliar.RR5;
                Auxiliar.Auxiliar.AX[2] = Auxiliar.Auxiliar.RR6;
                Auxiliar.Auxiliar.AX[1] = Auxiliar.Auxiliar.RR7;
            }
            else if ((Rega == ("DX")) && (Regb == ("BX")))
            {
                ALU.Resta(Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8],
                    Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8]);
                Auxiliar.Auxiliar.BX[8] = Auxiliar.Auxiliar.RR0;
                Auxiliar.Auxiliar.BX[7] = Auxiliar.Auxiliar.RR1;
                Auxiliar.Auxiliar.BX[6] = Auxiliar.Auxiliar.RR2;
                Auxiliar.Auxiliar.BX[5] = Auxiliar.Auxiliar.RR3;
                Auxiliar.Auxiliar.BX[4] = Auxiliar.Auxiliar.RR4;
                Auxiliar.Auxiliar.BX[3] = Auxiliar.Auxiliar.RR5;
                Auxiliar.Auxiliar.BX[2] = Auxiliar.Auxiliar.RR6;
                Auxiliar.Auxiliar.BX[1] = Auxiliar.Auxiliar.RR7;
            }
            else if ((Rega == ("DX")) && (Regb == ("CX")))
            {
                ALU.Resta(Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8], //Registro b
                    Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8]);
                Auxiliar.Auxiliar.CX[8] = Auxiliar.Auxiliar.RR0;
                Auxiliar.Auxiliar.CX[7] = Auxiliar.Auxiliar.RR1;
                Auxiliar.Auxiliar.CX[6] = Auxiliar.Auxiliar.RR2;
                Auxiliar.Auxiliar.CX[5] = Auxiliar.Auxiliar.RR3;
                Auxiliar.Auxiliar.CX[4] = Auxiliar.Auxiliar.RR4;
                Auxiliar.Auxiliar.CX[3] = Auxiliar.Auxiliar.RR5;
                Auxiliar.Auxiliar.CX[2] = Auxiliar.Auxiliar.RR6;
                Auxiliar.Auxiliar.CX[1] = Auxiliar.Auxiliar.RR7;
            }
            else if ((Rega == ("DX")) && (Regb == ("DX")))
            {
                ALU.Resta(Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8],
                    Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8]); //Registro b
                Auxiliar.Auxiliar.DX[8] = Auxiliar.Auxiliar.RR0;
                Auxiliar.Auxiliar.DX[7] = Auxiliar.Auxiliar.RR1;
                Auxiliar.Auxiliar.DX[6] = Auxiliar.Auxiliar.RR2;
                Auxiliar.Auxiliar.DX[5] = Auxiliar.Auxiliar.RR3;
                Auxiliar.Auxiliar.DX[4] = Auxiliar.Auxiliar.RR4;
                Auxiliar.Auxiliar.DX[3] = Auxiliar.Auxiliar.RR5;
                Auxiliar.Auxiliar.DX[2] = Auxiliar.Auxiliar.RR6;
                Auxiliar.Auxiliar.DX[1] = Auxiliar.Auxiliar.RR7;
            }
        }
    }
}
