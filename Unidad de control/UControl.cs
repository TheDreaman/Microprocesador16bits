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
        Funciones F = new Funciones();
        public void VerificarInstruccion(int ins1, int ins2, int ins3, int ins4, int BorW, int RegDes1, int RegDes2, int Fromreg, 
            int WaReg1, int WaReg2, int WaReg3, int WaReg4, int WaReg5, int WaReg6, int WaReg7, int WaReg8, 
            int Bajo1, int Bajo2, int Bajo3, int Bajo4, int Bajo5, int Bajo6, int Bajo7, int Bajo8, 
            int Alto1, int Alto2, int Alto3, int Alto4, int Alto5, int Alto6, int Alto7, int Alto8)
        {
            if ((ins1 == 0) && (ins2 == 0) && (ins3 == 0) && (ins4 == 0)) 
            {
                if (BorW==1) //Byte=1, Word=0, solo mostrar 2 lineas de codigo
                {
                    //Suma
                    if (Fromreg == 1) //Viene de Reg=1, No viene de Reg=0
                    {
                        string RegOrigen = QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8); 
                        string RegDestino = QueRegistro2(RegDes1, RegDes2); 
                        F.SumaRegistro(RegOrigen, RegDestino);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 2;
                    }
                    else
                    {
                        string RegDestino2 = QueRegistro2(RegDes1, RegDes2);
                        F.SumaNoRegistro(RegDestino2, Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8, Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 2;
                    }
                }
                else //mostrar 3 lineas de codigo
                {
                    if (Fromreg == 1)
                    {
                        string RegOrigen = QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8); 
                        string RegDestino = QueRegistro2(RegDes1, RegDes2); 
                        F.SumaRegistro(RegOrigen, RegDestino);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 3;
                    }
                    else
                    {
                        string RegDestino2 = QueRegistro2(RegDes1, RegDes2);
                        F.SumaNoRegistro(RegDestino2, Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8, Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 3;
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
                        string RegOrigen = QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8); 
                        string RegDestino = QueRegistro2(RegDes1, RegDes2); 
                        F.RestaRegistro(RegOrigen, RegDestino);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 2;
                    }
                    else
                    {
                        string RegDestino2 = QueRegistro2(RegDes1, RegDes2);
                        F.RestaNoRegistro(RegDestino2, Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8, Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 2;
                    }
                }
                else //mostrar 3 lineas de codigo
                {
                    if (Fromreg == 1)
                    {
                        string RegOrigen = QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8); 
                        string RegDestino = QueRegistro2(RegDes1, RegDes2); 
                        F.RestaRegistro(RegOrigen, RegDestino);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 3;
                    }
                    else
                    {
                        string RegDestino2 = QueRegistro2(RegDes1, RegDes2);
                        F.RestaNoRegistro(RegDestino2, Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8, Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 3;
                    }
                }
            }
            else if ((ins1 == 0) && (ins2 == 0) && (ins3 == 1) && (ins4 == 0))
            {
                //AND
                if (BorW == 1) //Byte=1, Word=0, solo mostrar 2 lineas de codigo
                {
                    if (Fromreg == 1) //Viene de Reg=1, No viene de Reg=0
                    {
                        string RegOrigen = QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8); 
                        string RegDestino = QueRegistro2(RegDes1, RegDes2); 
                        F.ANDRegistro(RegOrigen, RegDestino);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 2;
                    }
                    else
                    {
                        string RegDestino2 = QueRegistro2(RegDes1, RegDes2);
                        F.ANDNoRegistro(RegDestino2, Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8, Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 2;
                    }
                }
                else //mostrar 3 lineas de codigo
                {
                    if (Fromreg == 1)
                    {
                        string RegOrigen = QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8); 
                        string RegDestino = QueRegistro2(RegDes1, RegDes2); 
                        F.ANDRegistro(RegOrigen, RegDestino);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 3;
                    }
                    else
                    {
                        string RegDestino2 = QueRegistro2(RegDes1, RegDes2);
                        F.ANDNoRegistro(RegDestino2, Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8, Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 3;
                    }
                }
            }
            else if ((ins1 == 0) && (ins2 == 0) && (ins3 == 1) && (ins4 == 1))
            {
                //OR
                if (BorW == 1) //Byte=1, Word=0, solo mostrar 2 lineas de codigo
                {
                    if (Fromreg == 1) //Viene de Reg=1, No viene de Reg=0
                    {
                        string RegOrigen = QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8); 
                        string RegDestino = QueRegistro2(RegDes1, RegDes2); 
                        F.ORRegistro(RegOrigen, RegDestino);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 2;
                    }
                    else
                    {
                        string RegDestino2 = QueRegistro2(RegDes1, RegDes2);
                        F.ORNoRegistro(RegDestino2, Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8, Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 2;
                    }
                }
                else //mostrar 3 lineas de codigo
                {
                    if (Fromreg == 1)
                    {
                        string RegOrigen = QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8); 
                        string RegDestino = QueRegistro2(RegDes1, RegDes2); 
                        F.ORRegistro(RegOrigen, RegDestino);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 3;
                    }
                    else
                    {
                        string RegDestino2 = QueRegistro2(RegDes1, RegDes2);
                        F.ORNoRegistro(RegDestino2, Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8, Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 3;
                    }
                }
            }
            else if ((ins1 == 0) && (ins2 == 1) && (ins3 == 0) && (ins4 == 0))
            {
                //XOR
                if (BorW == 1) //Byte=1, Word=0, solo mostrar 2 lineas de codigo
                {
                    if (Fromreg == 1) //Viene de Reg=1, No viene de Reg=0
                    {
                        string RegOrigen = QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8); 
                        string RegDestino = QueRegistro2(RegDes1, RegDes2); 
                        F.XORRegistro(RegOrigen, RegDestino);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 2;
                    }
                    else
                    {
                        string RegDestino2 = QueRegistro2(RegDes1, RegDes2);
                        F.XORNoRegistro(RegDestino2, Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8, Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 2;
                    }
                }
                else //mostrar 3 lineas de codigo
                {
                    if (Fromreg == 1)
                    {
                        string RegOrigen = QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8); 
                        string RegDestino = QueRegistro2(RegDes1, RegDes2); 
                        F.XORRegistro(RegOrigen, RegDestino);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 3;
                    }
                    else
                    {
                        string RegDestino2 = QueRegistro2(RegDes1, RegDes2);
                        F.XORNoRegistro(RegDestino2, Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8, Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 3;
                    }
                }
            }
            else if ((ins1 == 0) && (ins2 == 1) && (ins3 == 0) && (ins4 == 1))
            {
                //XNOR
                if (BorW == 1) //Byte=1, Word=0, solo mostrar 2 lineas de codigo
                {
                    if (Fromreg == 1) //Viene de Reg=1, No viene de Reg=0
                    {
                        string RegOrigen = QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8); 
                        string RegDestino = QueRegistro2(RegDes1, RegDes2); 
                        F.XNORRegistro(RegOrigen, RegDestino);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 2;
                    }
                    else
                    {
                        string RegDestino2 = QueRegistro2(RegDes1, RegDes2);
                        F.XNORNoRegistro(RegDestino2, Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8, Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 2;
                    }
                }
                else //mostrar 3 lineas de codigo
                {
                    if (Fromreg == 1)
                    {
                        string RegOrigen = QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8); 
                        string RegDestino = QueRegistro2(RegDes1, RegDes2); 
                        F.XNORRegistro(RegOrigen, RegDestino);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 3;
                    }
                    else
                    {
                        string RegDestino2 = QueRegistro2(RegDes1, RegDes2);
                        F.XNORNoRegistro(RegDestino2, Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8, Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 3;
                    }
                }
            }
            else if ((ins1 == 0) && (ins2 == 1) && (ins3 == 1) && (ins4 == 0))
            {
                //NOT
                if (BorW == 1) //Byte=1, Word=0, solo mostrar 2 lineas de codigo
                {
                    if (Fromreg == 1) //Viene de Reg=1, No viene de Reg=0
                    {
                        string RegOrigen = QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8); 
                        string RegDestino = QueRegistro2(RegDes1, RegDes2); 
                        F.NOTRegistro(RegOrigen, RegDestino);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 2;
                    }
                    else
                    {
                        string RegDestino2 = QueRegistro2(RegDes1, RegDes2);
                        F.NOTNoRegistro(RegDestino2, Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8, Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 2;
                    }
                }
                else //mostrar 3 lineas de codigo
                {
                    if (Fromreg == 1)
                    {
                        string RegOrigen = QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8); 
                        string RegDestino = QueRegistro2(RegDes1, RegDes2); 
                        F.NOTRegistro(RegOrigen, RegDestino);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 3;
                    }
                    else
                    {
                        string RegDestino2 = QueRegistro2(RegDes1, RegDes2);
                        F.NOTNoRegistro(RegDestino2, Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8, Alto1, Alto2, Alto3, Alto4, Alto5, Alto6, Alto7, Alto8);
                        Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 3;
                    }
                }
            }
            else if ((ins1 == 0) && (ins2 == 1) && (ins3 == 1) && (ins4 == 1))
            {
                //MOVI (direccionamiento inmediato)
                string RegDestino2 = QueRegistro2(RegDes1, RegDes2);
                F.MOVI(RegDestino2, Bajo1, Bajo2, Bajo3, Bajo4, Bajo5, Bajo6, Bajo7, Bajo8);
                Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 2;
            }
            else if ((ins1 == 1) && (ins2 == 0) && (ins3 == 0) && (ins4 == 0))
            {
                //MOVxR (direccionamiento por registro)
                if (BorW == 1)
                {
                    string RegOrigen = QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8); 
                    string RegDestino = QueRegistro2(RegDes1, RegDes2); 
                    F.MOVxR(RegOrigen, RegDestino);
                    Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 2;
                }
                else
                {
                    string RegOrigen = QueRegistro4(WaReg5, WaReg6, WaReg7, WaReg8); 
                    string RegDestino = QueRegistro2(RegDes1, RegDes2); 
                    F.MOVxR(RegOrigen, RegDestino);
                    Auxiliar.Auxi.IP = Auxiliar.Auxi.IP + 3;
                }
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

        
    }
}
