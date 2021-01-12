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
        public void Verificar(int a7, int a6, int a5, int a4, int a3, int a2, int a1, int a0, int b7, int b6, int b5, int b4, int b3, int b2, int b1, int b0,int a, int b,int c)
        {
            if ((Auxiliar.Auxiliar.T1 == 0) && (Auxiliar.Auxiliar.T2 == 0) && (Auxiliar.Auxiliar.T3 == 0) && (Auxiliar.Auxiliar.T4 == 0))
            {
                //suma
                ALU16bits ver = new ALU16bits();
                //ver.Suma(a7, a6, a5, a4, a3, a2, a1, a0, b7, b6, b5, b4, b3, b2, b1, b0);
            }
            else if ((Auxiliar.Auxiliar.T1 == 0) && (Auxiliar.Auxiliar.T2 == 0) && (Auxiliar.Auxiliar.T3 == 0) && (Auxiliar.Auxiliar.T4 == 1))
            {
                //resta
                ALU16bits ver = new ALU16bits();
                ver.Resta(a7, a6, a5, a4, a3, a2, a1, a0, b7, b6, b5, b4, b3, b2, b1, b0);

            }
            else if ((Auxiliar.Auxiliar.T1 == 0) && (Auxiliar.Auxiliar.T2 == 0) && (Auxiliar.Auxiliar.T3 == 1) && (Auxiliar.Auxiliar.T4 == 0))
            {
                //AND
                ALU16bits ver = new ALU16bits();
                ver.AND(a, b);

            }
            else if ((Auxiliar.Auxiliar.T1 == 0) && (Auxiliar.Auxiliar.T2 == 0) && (Auxiliar.Auxiliar.T3 == 1) && (Auxiliar.Auxiliar.T4 == 1))
            {
                //OR
                ALU16bits ver = new ALU16bits();
                ver.OR(a, b);
            }
            else if ((Auxiliar.Auxiliar.T1 == 0) && (Auxiliar.Auxiliar.T2 == 1) && (Auxiliar.Auxiliar.T3 == 0) && (Auxiliar.Auxiliar.T4 == 0))
            {
                //XOR
                ALU16bits ver = new ALU16bits();
                ver.XOR(a, b);
            }
            else if ((Auxiliar.Auxiliar.T1 == 0) && (Auxiliar.Auxiliar.T2 == 1) && (Auxiliar.Auxiliar.T3 == 0) && (Auxiliar.Auxiliar.T4 == 1))
            {
                //XNOR
                ALU16bits ver = new ALU16bits();
                ver.XNOR(a, b);

            }
            else if ((Auxiliar.Auxiliar.T1 == 0) && (Auxiliar.Auxiliar.T2 == 1) && (Auxiliar.Auxiliar.T3 == 1) && (Auxiliar.Auxiliar.T4 == 0))
            {
                //NOT
                ALU16bits ver = new ALU16bits();
                ver.NOT(a);
            }
            else if ((Auxiliar.Auxiliar.T1 == 0) && (Auxiliar.Auxiliar.T2 == 1) && (Auxiliar.Auxiliar.T3 == 1) && (Auxiliar.Auxiliar.T4 == 1))
            {
                //OR3
                ALU16bits ver = new ALU16bits();
                ver.OR3(a, b, c);  //llamar al metodo
            }
        }

        public void VerificarInstruccion(int ins1, int ins2, int ins3, int ins4, int BorW, int RegDes1, int RegDes2, int Fromreg, int WaReg1, int WaReg2, int WaReg3, int WaReg4, int Bajo1, int Bajo2, int Bajo3, int Bajo4, int Alto1, int Alto2, int Alto3, int Alto4)
        {
            if ((ins1 == 0) && (ins2 == 0) && (ins3 == 0) && (ins4 == 0))
            {
                //Suma
                if (BorW==1) //Byte=1, Word=0, solo mostrar 2 lineas de codigo
                {
                    if (Fromreg == 1) //Viene de Reg=1, No viene de Reg=0
                    {
                        string RegOrigen = QueRegistro4(WaReg1, WaReg2, WaReg3, WaReg4); //pedir datos de ax
                        string RegDestino = QueRegistro2(RegDes1, RegDes2); //guardarlos en bx
                        SumaRegistro(RegOrigen, RegDestino);
                        Auxiliar.Auxiliar.IP = Auxiliar.Auxiliar.IP + 2;
                    }
                    else
                    {
                        string RegDestino2 = QueRegistro2(RegDes1, RegDes2);
                        SumaNoRegistro(RegDestino2, Bajo1, Bajo2, Bajo3, Bajo4, Alto1, Alto2, Alto3, Alto4);
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
                        SumaNoRegistro(RegDestino2, Bajo1, Bajo2, Bajo3, Bajo4, Alto1, Alto2, Alto3, Alto4);
                        Auxiliar.Auxiliar.IP = Auxiliar.Auxiliar.IP + 3;
                    }
                }
            }
            else if ((Auxiliar.Auxiliar.T1 == 0) && (Auxiliar.Auxiliar.T2 == 0) && (Auxiliar.Auxiliar.T3 == 0) && (Auxiliar.Auxiliar.T4 == 1))
            {
                //Resta

            }
            else if ((Auxiliar.Auxiliar.T1 == 0) && (Auxiliar.Auxiliar.T2 == 0) && (Auxiliar.Auxiliar.T3 == 1) && (Auxiliar.Auxiliar.T4 == 0))
            {
                //AND

            }
            else if ((Auxiliar.Auxiliar.T1 == 0) && (Auxiliar.Auxiliar.T2 == 0) && (Auxiliar.Auxiliar.T3 == 1) && (Auxiliar.Auxiliar.T4 == 1))
            {
                //OR
                ALU16bits ver = new ALU16bits();
                //ver.OR(a, b);
            }
            else if ((Auxiliar.Auxiliar.T1 == 0) && (Auxiliar.Auxiliar.T2 == 1) && (Auxiliar.Auxiliar.T3 == 0) && (Auxiliar.Auxiliar.T4 == 0))
            {
                //XOR
                ALU16bits ver = new ALU16bits();
                //ver.XOR(a, b);
            }
            else if ((Auxiliar.Auxiliar.T1 == 0) && (Auxiliar.Auxiliar.T2 == 1) && (Auxiliar.Auxiliar.T3 == 0) && (Auxiliar.Auxiliar.T4 == 1))
            {
                //XNOR
                ALU16bits ver = new ALU16bits();
                //ver.XNOR(a, b);

            }
            else if ((Auxiliar.Auxiliar.T1 == 0) && (Auxiliar.Auxiliar.T2 == 1) && (Auxiliar.Auxiliar.T3 == 1) && (Auxiliar.Auxiliar.T4 == 0))
            {
                //NOT
                ALU16bits ver = new ALU16bits();
                //ver.NOT(a);
            }
            else if ((Auxiliar.Auxiliar.T1 == 0) && (Auxiliar.Auxiliar.T2 == 1) && (Auxiliar.Auxiliar.T3 == 1) && (Auxiliar.Auxiliar.T4 == 1))
            {
                //OR3
                ALU16bits ver = new ALU16bits();
                //ver.OR3(a, b, c);  //llamar al metodo
            }
        }

        public string QueRegistro4(int WaReg1, int WaReg2, int WaReg3, int WaReg4)
        {
            if((WaReg1 == 0) && (WaReg2 == 0) && (WaReg3 == 0) && (WaReg4 == 0))
            {
                //AX
                return ("AX");
            }
            else if((WaReg1 == 0) && (WaReg2 == 0) && (WaReg3 == 0) && (WaReg4 == 1))
            {
                //BX
                return ("BX");
            }
            else if ((WaReg1 == 0) && (WaReg2 == 0) && (WaReg3 == 1) && (WaReg4 == 0))
            {
                //CX
                return ("CX");
            }
            else if ((WaReg1 == 0) && (WaReg2 == 0) && (WaReg3 == 1) && (WaReg4 == 1))
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

        public void SumaNoRegistro(string regdest2, int bajo1, int bajo2, int bajo3, int bajo4, int alto1, int alto2, int alto3, int alto4)
        {
            if (regdest2 == "AX")
            {
                ALU.Suma(alto1, alto2, alto3, alto4, bajo1, bajo2, bajo3, bajo4,
                    Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8], //Registro b
                    Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8]);
            }
            else if (regdest2 == "BX")
            {
                ALU.Suma(alto1, alto2, alto3, alto4, bajo1, bajo2, bajo3, bajo4,
                    Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8], //Registro b
                   Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8]);
            }
            else if (regdest2 == "CX")
            {
                ALU.Suma(alto1, alto2, alto3, alto4, bajo1, bajo2, bajo3, bajo4,
                    Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8], //Registro b
                   Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8]);
            }
            else if (regdest2 == "DX")
            {
                ALU.Suma(alto1, alto2, alto3, alto4, bajo1, bajo2, bajo3, bajo4,
                    Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8], //Registro b
                   Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8]);
            }
        }

        public void SumaRegistro(string Rega, string Regb)
        {
            if ((Rega==("AX")) && (Regb == ("AX"))) //1=7, 1=6, 1=5, 1=4, etc.
            {
                ALU.Suma(Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8], //Registro a
                    Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8], //Registro b
                    Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8]); //Donde se va a guardar
            }
            else if ((Rega == ("AX")) && (Regb == ("BX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8], //Registro a
                   Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8], //Registro b
                   Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8]); //Donde se va a guardar
            }
            else if ((Rega == ("AX")) && (Regb == ("CX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8], //Registro a
                   Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8], //Registro b
                   Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8]); //Donde se va a guardar
            }
            else if ((Rega == ("AX")) && (Regb == ("DX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8], //Registro a
                   Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8], //Registro b
                   Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8]); //Donde se va a guardar
            }
            else if ((Rega == ("BX")) && (Regb == ("AX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8],
                    Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8],
                    Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8]);
            }
            else if ((Rega == ("BX")) && (Regb == ("BX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8],
                    Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8],
                    Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8]);
            }
            else if ((Rega == ("BX")) && (Regb == ("CX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8],
                   Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8], //Registro b
                   Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8]);
            }
            else if ((Rega == ("BX")) && (Regb == ("DX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8],
                   Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8], //Registro b
                   Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8]); //Donde se va a guardar
            }
            else if ((Rega == ("CX")) && (Regb == ("AX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8],
                    Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8], //Registro b
                    Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8]); //Donde se va a guardar
            }
            else if ((Rega == ("CX")) && (Regb == ("BX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8],
                    Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8],
                    Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8]);
            }
            else if ((Rega == ("CX")) && (Regb == ("CX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8],
                    Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8], //Registro b
                    Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8]);
            }
            else if ((Rega == ("CX")) && (Regb == ("DX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8],
                    Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8], //Registro b
                    Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8]);
            }
            else if ((Rega == ("DX")) && (Regb == ("AX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8],
                    Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8], //Registro b
                    Auxiliar.Auxiliar.AX[1], Auxiliar.Auxiliar.AX[2], Auxiliar.Auxiliar.AX[3], Auxiliar.Auxiliar.AX[4], Auxiliar.Auxiliar.AX[5], Auxiliar.Auxiliar.AX[6], Auxiliar.Auxiliar.AX[7], Auxiliar.Auxiliar.AX[8]); //Donde se va a guardar
            }
            else if ((Rega == ("DX")) && (Regb == ("BX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8],
                    Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8],
                    Auxiliar.Auxiliar.BX[1], Auxiliar.Auxiliar.BX[2], Auxiliar.Auxiliar.BX[3], Auxiliar.Auxiliar.BX[4], Auxiliar.Auxiliar.BX[5], Auxiliar.Auxiliar.BX[6], Auxiliar.Auxiliar.BX[7], Auxiliar.Auxiliar.BX[8]);
            }
            else if ((Rega == ("DX")) && (Regb == ("CX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8],
                    Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8], //Registro b
                    Auxiliar.Auxiliar.CX[1], Auxiliar.Auxiliar.CX[2], Auxiliar.Auxiliar.CX[3], Auxiliar.Auxiliar.CX[4], Auxiliar.Auxiliar.CX[5], Auxiliar.Auxiliar.CX[6], Auxiliar.Auxiliar.CX[7], Auxiliar.Auxiliar.CX[8]);
            }
            else if ((Rega == ("DX")) && (Regb == ("DX")))
            {
                ALU.Suma(Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8],
                    Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8], //Registro b
                    Auxiliar.Auxiliar.DX[1], Auxiliar.Auxiliar.DX[2], Auxiliar.Auxiliar.DX[3], Auxiliar.Auxiliar.DX[4], Auxiliar.Auxiliar.DX[5], Auxiliar.Auxiliar.DX[6], Auxiliar.Auxiliar.DX[7], Auxiliar.Auxiliar.DX[8]);
            }
        }
    }
}
