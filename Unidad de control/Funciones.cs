using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auxiliar;
using ALU;

namespace Unidad_de_control
{
    class Funciones
    {
        ALU16bits ALU = new ALU16bits();
        public void SumaNoRegistro(string regdest2, int bajo1, int bajo2, int bajo3, int bajo4, int bajo5, int bajo6, int bajo7, int bajo8,
            int alto1, int alto2, int alto3, int alto4, int alto5, int alto6, int alto7, int alto8)
        {
            if (regdest2 == "AX")
            {
                ALU.Suma(alto1, alto2, alto3, alto4, alto5, alto6, alto7, alto8, bajo1, bajo2, bajo3, bajo4, bajo5, bajo6, bajo7, bajo8);
                Auxi.AX[8] = Auxi.SR0;
                Auxi.AX[7] = Auxi.SR1;
                Auxi.AX[6] = Auxi.SR2;
                Auxi.AX[5] = Auxi.SR3;
                Auxi.AX[4] = Auxi.SR4;
                Auxi.AX[3] = Auxi.SR5;
                Auxi.AX[2] = Auxi.SR6;
                Auxi.AX[1] = Auxi.SR7;
            }
            else if (regdest2 == "BX")
            {
                ALU.Suma(alto1, alto2, alto3, alto4, alto5, alto6, alto7, alto8, bajo1, bajo2, bajo3, bajo4, bajo5, bajo6, bajo7, bajo8);
                Auxi.BX[8] = Auxi.SR0;
                Auxi.BX[7] = Auxi.SR1;
                Auxi.BX[6] = Auxi.SR2;
                Auxi.BX[5] = Auxi.SR3;
                Auxi.BX[4] = Auxi.SR4;
                Auxi.BX[3] = Auxi.SR5;
                Auxi.BX[2] = Auxi.SR6;
                Auxi.BX[1] = Auxi.SR7;
            }
            else if (regdest2 == "CX")
            {
                ALU.Suma(alto1, alto2, alto3, alto4, alto5, alto6, alto7, alto8, bajo1, bajo2, bajo3, bajo4, bajo5, bajo6, bajo7, bajo8);
                Auxi.CX[8] = Auxi.SR0;
                Auxi.CX[7] = Auxi.SR1;
                Auxi.CX[6] = Auxi.SR2;
                Auxi.CX[5] = Auxi.SR3;
                Auxi.CX[4] = Auxi.SR4;
                Auxi.CX[3] = Auxi.SR5;
                Auxi.CX[2] = Auxi.SR6;
                Auxi.CX[1] = Auxi.SR7;
            }
            else if (regdest2 == "DX")
            {
                ALU.Suma(alto1, alto2, alto3, alto4, alto5, alto6, alto7, alto8, bajo1, bajo2, bajo3, bajo4, bajo5, bajo6, bajo7, bajo8);
                Auxi.DX[8] = Auxi.SR0;
                Auxi.DX[7] = Auxi.SR1;
                Auxi.DX[6] = Auxi.SR2;
                Auxi.DX[5] = Auxi.SR3;
                Auxi.DX[4] = Auxi.SR4;
                Auxi.DX[3] = Auxi.SR5;
                Auxi.DX[2] = Auxi.SR6;
                Auxi.DX[1] = Auxi.SR7;
            }
        }

        public void SumaRegistro(string Rega, string Regb)
        {
            if ((Rega == ("AX")) && (Regb == ("AX"))) //1=7, 1=6, 1=5, 1=4, etc.
            {
                ALU.Suma(Auxiliar.Auxi.AX[1], Auxiliar.Auxi.AX[2], Auxiliar.Auxi.AX[3], Auxiliar.Auxi.AX[4], Auxiliar.Auxi.AX[5], Auxiliar.Auxi.AX[6], Auxiliar.Auxi.AX[7], Auxiliar.Auxi.AX[8], //Registro a
                    Auxiliar.Auxi.AX[1], Auxiliar.Auxi.AX[2], Auxiliar.Auxi.AX[3], Auxiliar.Auxi.AX[4], Auxiliar.Auxi.AX[5], Auxiliar.Auxi.AX[6], Auxiliar.Auxi.AX[7], Auxiliar.Auxi.AX[8]); //Registro b
                Auxiliar.Auxi.AX[8] = Auxiliar.Auxi.SR0;
                Auxiliar.Auxi.AX[7] = Auxiliar.Auxi.SR1;
                Auxiliar.Auxi.AX[6] = Auxiliar.Auxi.SR2;
                Auxiliar.Auxi.AX[5] = Auxiliar.Auxi.SR3;
                Auxiliar.Auxi.AX[4] = Auxiliar.Auxi.SR4;
                Auxiliar.Auxi.AX[3] = Auxiliar.Auxi.SR5;
                Auxiliar.Auxi.AX[2] = Auxiliar.Auxi.SR6;
                Auxiliar.Auxi.AX[1] = Auxiliar.Auxi.SR7;
            }
            else if ((Rega == ("AX")) && (Regb == ("BX")))
            {
                ALU.Suma(Auxiliar.Auxi.AX[1], Auxiliar.Auxi.AX[2], Auxiliar.Auxi.AX[3], Auxiliar.Auxi.AX[4], Auxiliar.Auxi.AX[5], Auxiliar.Auxi.AX[6], Auxiliar.Auxi.AX[7], Auxiliar.Auxi.AX[8], //Registro a
                   Auxiliar.Auxi.BX[1], Auxiliar.Auxi.BX[2], Auxiliar.Auxi.BX[3], Auxiliar.Auxi.BX[4], Auxiliar.Auxi.BX[5], Auxiliar.Auxi.BX[6], Auxiliar.Auxi.BX[7], Auxiliar.Auxi.BX[8]); //Registro b
                Auxiliar.Auxi.BX[8] = Auxiliar.Auxi.SR0;
                Auxiliar.Auxi.BX[7] = Auxiliar.Auxi.SR1;
                Auxiliar.Auxi.BX[6] = Auxiliar.Auxi.SR2;
                Auxiliar.Auxi.BX[5] = Auxiliar.Auxi.SR3;
                Auxiliar.Auxi.BX[4] = Auxiliar.Auxi.SR4;
                Auxiliar.Auxi.BX[3] = Auxiliar.Auxi.SR5;
                Auxiliar.Auxi.BX[2] = Auxiliar.Auxi.SR6;
                Auxiliar.Auxi.BX[1] = Auxiliar.Auxi.SR7;
            }
            else if ((Rega == ("AX")) && (Regb == ("CX")))
            {
                ALU.Suma(Auxiliar.Auxi.AX[1], Auxiliar.Auxi.AX[2], Auxiliar.Auxi.AX[3], Auxiliar.Auxi.AX[4], Auxiliar.Auxi.AX[5], Auxiliar.Auxi.AX[6], Auxiliar.Auxi.AX[7], Auxiliar.Auxi.AX[8], //Registro a
                   Auxiliar.Auxi.CX[1], Auxiliar.Auxi.CX[2], Auxiliar.Auxi.CX[3], Auxiliar.Auxi.CX[4], Auxiliar.Auxi.CX[5], Auxiliar.Auxi.CX[6], Auxiliar.Auxi.CX[7], Auxiliar.Auxi.CX[8]); //Registro b
                Auxiliar.Auxi.CX[8] = Auxiliar.Auxi.SR0;
                Auxiliar.Auxi.CX[7] = Auxiliar.Auxi.SR1;
                Auxiliar.Auxi.CX[6] = Auxiliar.Auxi.SR2;
                Auxiliar.Auxi.CX[5] = Auxiliar.Auxi.SR3;
                Auxiliar.Auxi.CX[4] = Auxiliar.Auxi.SR4;
                Auxiliar.Auxi.CX[3] = Auxiliar.Auxi.SR5;
                Auxiliar.Auxi.CX[2] = Auxiliar.Auxi.SR6;
                Auxiliar.Auxi.CX[1] = Auxiliar.Auxi.SR7;
            }
            else if ((Rega == ("AX")) && (Regb == ("DX")))
            {
                ALU.Suma(Auxiliar.Auxi.AX[1], Auxiliar.Auxi.AX[2], Auxiliar.Auxi.AX[3], Auxiliar.Auxi.AX[4], Auxiliar.Auxi.AX[5], Auxiliar.Auxi.AX[6], Auxiliar.Auxi.AX[7], Auxiliar.Auxi.AX[8], //Registro a
                   Auxiliar.Auxi.DX[1], Auxiliar.Auxi.DX[2], Auxiliar.Auxi.DX[3], Auxiliar.Auxi.DX[4], Auxiliar.Auxi.DX[5], Auxiliar.Auxi.DX[6], Auxiliar.Auxi.DX[7], Auxiliar.Auxi.DX[8]); //Registro b
                Auxiliar.Auxi.DX[8] = Auxiliar.Auxi.SR0;
                Auxiliar.Auxi.DX[7] = Auxiliar.Auxi.SR1;
                Auxiliar.Auxi.DX[6] = Auxiliar.Auxi.SR2;
                Auxiliar.Auxi.DX[5] = Auxiliar.Auxi.SR3;
                Auxiliar.Auxi.DX[4] = Auxiliar.Auxi.SR4;
                Auxiliar.Auxi.DX[3] = Auxiliar.Auxi.SR5;
                Auxiliar.Auxi.DX[2] = Auxiliar.Auxi.SR6;
                Auxiliar.Auxi.DX[1] = Auxiliar.Auxi.SR7;
            }
            else if ((Rega == ("BX")) && (Regb == ("AX")))
            {
                ALU.Suma(Auxiliar.Auxi.BX[1], Auxiliar.Auxi.BX[2], Auxiliar.Auxi.BX[3], Auxiliar.Auxi.BX[4], Auxiliar.Auxi.BX[5], Auxiliar.Auxi.BX[6], Auxiliar.Auxi.BX[7], Auxiliar.Auxi.BX[8],
                    Auxiliar.Auxi.AX[1], Auxiliar.Auxi.AX[2], Auxiliar.Auxi.AX[3], Auxiliar.Auxi.AX[4], Auxiliar.Auxi.AX[5], Auxiliar.Auxi.AX[6], Auxiliar.Auxi.AX[7], Auxiliar.Auxi.AX[8]);
                Auxiliar.Auxi.AX[8] = Auxiliar.Auxi.SR0;
                Auxiliar.Auxi.AX[7] = Auxiliar.Auxi.SR1;
                Auxiliar.Auxi.AX[6] = Auxiliar.Auxi.SR2;
                Auxiliar.Auxi.AX[5] = Auxiliar.Auxi.SR3;
                Auxiliar.Auxi.AX[4] = Auxiliar.Auxi.SR4;
                Auxiliar.Auxi.AX[3] = Auxiliar.Auxi.SR5;
                Auxiliar.Auxi.AX[2] = Auxiliar.Auxi.SR6;
                Auxiliar.Auxi.AX[1] = Auxiliar.Auxi.SR7;
            }
            else if ((Rega == ("BX")) && (Regb == ("BX")))
            {
                ALU.Suma(Auxiliar.Auxi.BX[1], Auxiliar.Auxi.BX[2], Auxiliar.Auxi.BX[3], Auxiliar.Auxi.BX[4], Auxiliar.Auxi.BX[5], Auxiliar.Auxi.BX[6], Auxiliar.Auxi.BX[7], Auxiliar.Auxi.BX[8],
                    Auxiliar.Auxi.BX[1], Auxiliar.Auxi.BX[2], Auxiliar.Auxi.BX[3], Auxiliar.Auxi.BX[4], Auxiliar.Auxi.BX[5], Auxiliar.Auxi.BX[6], Auxiliar.Auxi.BX[7], Auxiliar.Auxi.BX[8]);
                Auxiliar.Auxi.BX[8] = Auxiliar.Auxi.SR0;
                Auxiliar.Auxi.BX[7] = Auxiliar.Auxi.SR1;
                Auxiliar.Auxi.BX[6] = Auxiliar.Auxi.SR2;
                Auxiliar.Auxi.BX[5] = Auxiliar.Auxi.SR3;
                Auxiliar.Auxi.BX[4] = Auxiliar.Auxi.SR4;
                Auxiliar.Auxi.BX[3] = Auxiliar.Auxi.SR5;
                Auxiliar.Auxi.BX[2] = Auxiliar.Auxi.SR6;
                Auxiliar.Auxi.BX[1] = Auxiliar.Auxi.SR7;
            }
            else if ((Rega == ("BX")) && (Regb == ("CX")))
            {
                ALU.Suma(Auxiliar.Auxi.BX[1], Auxiliar.Auxi.BX[2], Auxiliar.Auxi.BX[3], Auxiliar.Auxi.BX[4], Auxiliar.Auxi.BX[5], Auxiliar.Auxi.BX[6], Auxiliar.Auxi.BX[7], Auxiliar.Auxi.BX[8],
                   Auxiliar.Auxi.CX[1], Auxiliar.Auxi.CX[2], Auxiliar.Auxi.CX[3], Auxiliar.Auxi.CX[4], Auxiliar.Auxi.CX[5], Auxiliar.Auxi.CX[6], Auxiliar.Auxi.CX[7], Auxiliar.Auxi.CX[8]); //Registro b
                Auxiliar.Auxi.CX[8] = Auxiliar.Auxi.SR0;
                Auxiliar.Auxi.CX[7] = Auxiliar.Auxi.SR1;
                Auxiliar.Auxi.CX[6] = Auxiliar.Auxi.SR2;
                Auxiliar.Auxi.CX[5] = Auxiliar.Auxi.SR3;
                Auxiliar.Auxi.CX[4] = Auxiliar.Auxi.SR4;
                Auxiliar.Auxi.CX[3] = Auxiliar.Auxi.SR5;
                Auxiliar.Auxi.CX[2] = Auxiliar.Auxi.SR6;
                Auxiliar.Auxi.CX[1] = Auxiliar.Auxi.SR7;
            }
            else if ((Rega == ("BX")) && (Regb == ("DX")))
            {
                ALU.Suma(Auxiliar.Auxi.BX[1], Auxiliar.Auxi.BX[2], Auxiliar.Auxi.BX[3], Auxiliar.Auxi.BX[4], Auxiliar.Auxi.BX[5], Auxiliar.Auxi.BX[6], Auxiliar.Auxi.BX[7], Auxiliar.Auxi.BX[8],
                   Auxiliar.Auxi.DX[1], Auxiliar.Auxi.DX[2], Auxiliar.Auxi.DX[3], Auxiliar.Auxi.DX[4], Auxiliar.Auxi.DX[5], Auxiliar.Auxi.DX[6], Auxiliar.Auxi.DX[7], Auxiliar.Auxi.DX[8]); //Registro b
                Auxiliar.Auxi.DX[8] = Auxiliar.Auxi.SR0;
                Auxiliar.Auxi.DX[7] = Auxiliar.Auxi.SR1;
                Auxiliar.Auxi.DX[6] = Auxiliar.Auxi.SR2;
                Auxiliar.Auxi.DX[5] = Auxiliar.Auxi.SR3;
                Auxiliar.Auxi.DX[4] = Auxiliar.Auxi.SR4;
                Auxiliar.Auxi.DX[3] = Auxiliar.Auxi.SR5;
                Auxiliar.Auxi.DX[2] = Auxiliar.Auxi.SR6;
                Auxiliar.Auxi.DX[1] = Auxiliar.Auxi.SR7;
            }
            else if ((Rega == ("CX")) && (Regb == ("AX")))
            {
                ALU.Suma(Auxiliar.Auxi.CX[1], Auxiliar.Auxi.CX[2], Auxiliar.Auxi.CX[3], Auxiliar.Auxi.CX[4], Auxiliar.Auxi.CX[5], Auxiliar.Auxi.CX[6], Auxiliar.Auxi.CX[7], Auxiliar.Auxi.CX[8],
                    Auxiliar.Auxi.AX[1], Auxiliar.Auxi.AX[2], Auxiliar.Auxi.AX[3], Auxiliar.Auxi.AX[4], Auxiliar.Auxi.AX[5], Auxiliar.Auxi.AX[6], Auxiliar.Auxi.AX[7], Auxiliar.Auxi.AX[8]); //Registro b
                Auxiliar.Auxi.AX[8] = Auxiliar.Auxi.SR0;
                Auxiliar.Auxi.AX[7] = Auxiliar.Auxi.SR1;
                Auxiliar.Auxi.AX[6] = Auxiliar.Auxi.SR2;
                Auxiliar.Auxi.AX[5] = Auxiliar.Auxi.SR3;
                Auxiliar.Auxi.AX[4] = Auxiliar.Auxi.SR4;
                Auxiliar.Auxi.AX[3] = Auxiliar.Auxi.SR5;
                Auxiliar.Auxi.AX[2] = Auxiliar.Auxi.SR6;
                Auxiliar.Auxi.AX[1] = Auxiliar.Auxi.SR7;
            }
            else if ((Rega == ("CX")) && (Regb == ("BX")))
            {
                ALU.Suma(Auxiliar.Auxi.CX[1], Auxiliar.Auxi.CX[2], Auxiliar.Auxi.CX[3], Auxiliar.Auxi.CX[4], Auxiliar.Auxi.CX[5], Auxiliar.Auxi.CX[6], Auxiliar.Auxi.CX[7], Auxiliar.Auxi.CX[8],
                    Auxiliar.Auxi.BX[1], Auxiliar.Auxi.BX[2], Auxiliar.Auxi.BX[3], Auxiliar.Auxi.BX[4], Auxiliar.Auxi.BX[5], Auxiliar.Auxi.BX[6], Auxiliar.Auxi.BX[7], Auxiliar.Auxi.BX[8]);
                Auxiliar.Auxi.BX[8] = Auxiliar.Auxi.SR0;
                Auxiliar.Auxi.BX[7] = Auxiliar.Auxi.SR1;
                Auxiliar.Auxi.BX[6] = Auxiliar.Auxi.SR2;
                Auxiliar.Auxi.BX[5] = Auxiliar.Auxi.SR3;
                Auxiliar.Auxi.BX[4] = Auxiliar.Auxi.SR4;
                Auxiliar.Auxi.BX[3] = Auxiliar.Auxi.SR5;
                Auxiliar.Auxi.BX[2] = Auxiliar.Auxi.SR6;
                Auxiliar.Auxi.BX[1] = Auxiliar.Auxi.SR7;
            }
            else if ((Rega == ("CX")) && (Regb == ("CX")))
            {
                ALU.Suma(Auxiliar.Auxi.CX[1], Auxiliar.Auxi.CX[2], Auxiliar.Auxi.CX[3], Auxiliar.Auxi.CX[4], Auxiliar.Auxi.CX[5], Auxiliar.Auxi.CX[6], Auxiliar.Auxi.CX[7], Auxiliar.Auxi.CX[8],
                    Auxiliar.Auxi.CX[1], Auxiliar.Auxi.CX[2], Auxiliar.Auxi.CX[3], Auxiliar.Auxi.CX[4], Auxiliar.Auxi.CX[5], Auxiliar.Auxi.CX[6], Auxiliar.Auxi.CX[7], Auxiliar.Auxi.CX[8]); //Registro b
                Auxiliar.Auxi.CX[8] = Auxiliar.Auxi.SR0;
                Auxiliar.Auxi.CX[7] = Auxiliar.Auxi.SR1;
                Auxiliar.Auxi.CX[6] = Auxiliar.Auxi.SR2;
                Auxiliar.Auxi.CX[5] = Auxiliar.Auxi.SR3;
                Auxiliar.Auxi.CX[4] = Auxiliar.Auxi.SR4;
                Auxiliar.Auxi.CX[3] = Auxiliar.Auxi.SR5;
                Auxiliar.Auxi.CX[2] = Auxiliar.Auxi.SR6;
                Auxiliar.Auxi.CX[1] = Auxiliar.Auxi.SR7;
            }
            else if ((Rega == ("CX")) && (Regb == ("DX")))
            {
                ALU.Suma(Auxiliar.Auxi.CX[1], Auxiliar.Auxi.CX[2], Auxiliar.Auxi.CX[3], Auxiliar.Auxi.CX[4], Auxiliar.Auxi.CX[5], Auxiliar.Auxi.CX[6], Auxiliar.Auxi.CX[7], Auxiliar.Auxi.CX[8],
                    Auxiliar.Auxi.DX[1], Auxiliar.Auxi.DX[2], Auxiliar.Auxi.DX[3], Auxiliar.Auxi.DX[4], Auxiliar.Auxi.DX[5], Auxiliar.Auxi.DX[6], Auxiliar.Auxi.DX[7], Auxiliar.Auxi.DX[8]); //Registro b
                Auxiliar.Auxi.DX[8] = Auxiliar.Auxi.SR0;
                Auxiliar.Auxi.DX[7] = Auxiliar.Auxi.SR1;
                Auxiliar.Auxi.DX[6] = Auxiliar.Auxi.SR2;
                Auxiliar.Auxi.DX[5] = Auxiliar.Auxi.SR3;
                Auxiliar.Auxi.DX[4] = Auxiliar.Auxi.SR4;
                Auxiliar.Auxi.DX[3] = Auxiliar.Auxi.SR5;
                Auxiliar.Auxi.DX[2] = Auxiliar.Auxi.SR6;
                Auxiliar.Auxi.DX[1] = Auxiliar.Auxi.SR7;
            }
            else if ((Rega == ("DX")) && (Regb == ("AX")))
            {
                ALU.Suma(Auxiliar.Auxi.DX[1], Auxiliar.Auxi.DX[2], Auxiliar.Auxi.DX[3], Auxiliar.Auxi.DX[4], Auxiliar.Auxi.DX[5], Auxiliar.Auxi.DX[6], Auxiliar.Auxi.DX[7], Auxiliar.Auxi.DX[8],
                    Auxiliar.Auxi.AX[1], Auxiliar.Auxi.AX[2], Auxiliar.Auxi.AX[3], Auxiliar.Auxi.AX[4], Auxiliar.Auxi.AX[5], Auxiliar.Auxi.AX[6], Auxiliar.Auxi.AX[7], Auxiliar.Auxi.AX[8]); //Registro b
                Auxiliar.Auxi.AX[8] = Auxiliar.Auxi.SR0;
                Auxiliar.Auxi.AX[7] = Auxiliar.Auxi.SR1;
                Auxiliar.Auxi.AX[6] = Auxiliar.Auxi.SR2;
                Auxiliar.Auxi.AX[5] = Auxiliar.Auxi.SR3;
                Auxiliar.Auxi.AX[4] = Auxiliar.Auxi.SR4;
                Auxiliar.Auxi.AX[3] = Auxiliar.Auxi.SR5;
                Auxiliar.Auxi.AX[2] = Auxiliar.Auxi.SR6;
                Auxiliar.Auxi.AX[1] = Auxiliar.Auxi.SR7;
            }
            else if ((Rega == ("DX")) && (Regb == ("BX")))
            {
                ALU.Suma(Auxiliar.Auxi.DX[1], Auxiliar.Auxi.DX[2], Auxiliar.Auxi.DX[3], Auxiliar.Auxi.DX[4], Auxiliar.Auxi.DX[5], Auxiliar.Auxi.DX[6], Auxiliar.Auxi.DX[7], Auxiliar.Auxi.DX[8],
                    Auxiliar.Auxi.BX[1], Auxiliar.Auxi.BX[2], Auxiliar.Auxi.BX[3], Auxiliar.Auxi.BX[4], Auxiliar.Auxi.BX[5], Auxiliar.Auxi.BX[6], Auxiliar.Auxi.BX[7], Auxiliar.Auxi.BX[8]);
                Auxiliar.Auxi.BX[8] = Auxiliar.Auxi.SR0;
                Auxiliar.Auxi.BX[7] = Auxiliar.Auxi.SR1;
                Auxiliar.Auxi.BX[6] = Auxiliar.Auxi.SR2;
                Auxiliar.Auxi.BX[5] = Auxiliar.Auxi.SR3;
                Auxiliar.Auxi.BX[4] = Auxiliar.Auxi.SR4;
                Auxiliar.Auxi.BX[3] = Auxiliar.Auxi.SR5;
                Auxiliar.Auxi.BX[2] = Auxiliar.Auxi.SR6;
                Auxiliar.Auxi.BX[1] = Auxiliar.Auxi.SR7;
            }
            else if ((Rega == ("DX")) && (Regb == ("CX")))
            {
                ALU.Suma(Auxiliar.Auxi.DX[1], Auxiliar.Auxi.DX[2], Auxiliar.Auxi.DX[3], Auxiliar.Auxi.DX[4], Auxiliar.Auxi.DX[5], Auxiliar.Auxi.DX[6], Auxiliar.Auxi.DX[7], Auxiliar.Auxi.DX[8],
                    Auxiliar.Auxi.CX[1], Auxiliar.Auxi.CX[2], Auxiliar.Auxi.CX[3], Auxiliar.Auxi.CX[4], Auxiliar.Auxi.CX[5], Auxiliar.Auxi.CX[6], Auxiliar.Auxi.CX[7], Auxiliar.Auxi.CX[8]); //Registro b
                Auxiliar.Auxi.CX[8] = Auxiliar.Auxi.SR0;
                Auxiliar.Auxi.CX[7] = Auxiliar.Auxi.SR1;
                Auxiliar.Auxi.CX[6] = Auxiliar.Auxi.SR2;
                Auxiliar.Auxi.CX[5] = Auxiliar.Auxi.SR3;
                Auxiliar.Auxi.CX[4] = Auxiliar.Auxi.SR4;
                Auxiliar.Auxi.CX[3] = Auxiliar.Auxi.SR5;
                Auxiliar.Auxi.CX[2] = Auxiliar.Auxi.SR6;
                Auxiliar.Auxi.CX[1] = Auxiliar.Auxi.SR7;
            }
            else if ((Rega == ("DX")) && (Regb == ("DX")))
            {
                ALU.Suma(Auxiliar.Auxi.DX[1], Auxiliar.Auxi.DX[2], Auxiliar.Auxi.DX[3], Auxiliar.Auxi.DX[4], Auxiliar.Auxi.DX[5], Auxiliar.Auxi.DX[6], Auxiliar.Auxi.DX[7], Auxiliar.Auxi.DX[8],
                    Auxiliar.Auxi.DX[1], Auxiliar.Auxi.DX[2], Auxiliar.Auxi.DX[3], Auxiliar.Auxi.DX[4], Auxiliar.Auxi.DX[5], Auxiliar.Auxi.DX[6], Auxiliar.Auxi.DX[7], Auxiliar.Auxi.DX[8]); //Registro b
                Auxiliar.Auxi.DX[8] = Auxiliar.Auxi.SR0;
                Auxiliar.Auxi.DX[7] = Auxiliar.Auxi.SR1;
                Auxiliar.Auxi.DX[6] = Auxiliar.Auxi.SR2;
                Auxiliar.Auxi.DX[5] = Auxiliar.Auxi.SR3;
                Auxiliar.Auxi.DX[4] = Auxiliar.Auxi.SR4;
                Auxiliar.Auxi.DX[3] = Auxiliar.Auxi.SR5;
                Auxiliar.Auxi.DX[2] = Auxiliar.Auxi.SR6;
                Auxiliar.Auxi.DX[1] = Auxiliar.Auxi.SR7;
            }
        }

        public void RestaNoRegistro(string regdest2, int bajo1, int bajo2, int bajo3, int bajo4, int bajo5, int bajo6, int bajo7, int bajo8,
            int alto1, int alto2, int alto3, int alto4, int alto5, int alto6, int alto7, int alto8)
        {
            if (regdest2 == "AX")
            {
                ALU.Resta(alto1, alto2, alto3, alto4, alto5, alto6, alto7, alto8, bajo1, bajo2, bajo3, bajo4, bajo5, bajo6, bajo7, bajo8);
                Auxiliar.Auxi.AX[8] = Auxiliar.Auxi.RR0;
                Auxiliar.Auxi.AX[7] = Auxiliar.Auxi.RR1;
                Auxiliar.Auxi.AX[6] = Auxiliar.Auxi.RR2;
                Auxiliar.Auxi.AX[5] = Auxiliar.Auxi.RR3;
                Auxiliar.Auxi.AX[4] = Auxiliar.Auxi.RR4;
                Auxiliar.Auxi.AX[3] = Auxiliar.Auxi.RR5;
                Auxiliar.Auxi.AX[2] = Auxiliar.Auxi.RR6;
                Auxiliar.Auxi.AX[1] = Auxiliar.Auxi.RR7;
            }
            else if (regdest2 == "BX")
            {
                ALU.Resta(alto1, alto2, alto3, alto4, alto5, alto6, alto7, alto8, bajo1, bajo2, bajo3, bajo4, bajo5, bajo6, bajo7, bajo8);
                Auxiliar.Auxi.BX[8] = Auxiliar.Auxi.RR0;
                Auxiliar.Auxi.BX[7] = Auxiliar.Auxi.RR1;
                Auxiliar.Auxi.BX[6] = Auxiliar.Auxi.RR2;
                Auxiliar.Auxi.BX[5] = Auxiliar.Auxi.RR3;
                Auxiliar.Auxi.BX[4] = Auxiliar.Auxi.RR4;
                Auxiliar.Auxi.BX[3] = Auxiliar.Auxi.RR5;
                Auxiliar.Auxi.BX[2] = Auxiliar.Auxi.RR6;
                Auxiliar.Auxi.BX[1] = Auxiliar.Auxi.RR7;
            }
            else if (regdest2 == "CX")
            {
                ALU.Resta(alto1, alto2, alto3, alto4, alto5, alto6, alto7, alto8, bajo1, bajo2, bajo3, bajo4, bajo5, bajo6, bajo7, bajo8);
                Auxiliar.Auxi.CX[8] = Auxiliar.Auxi.RR0;
                Auxiliar.Auxi.CX[7] = Auxiliar.Auxi.RR1;
                Auxiliar.Auxi.CX[6] = Auxiliar.Auxi.RR2;
                Auxiliar.Auxi.CX[5] = Auxiliar.Auxi.RR3;
                Auxiliar.Auxi.CX[4] = Auxiliar.Auxi.RR4;
                Auxiliar.Auxi.CX[3] = Auxiliar.Auxi.RR5;
                Auxiliar.Auxi.CX[2] = Auxiliar.Auxi.RR6;
                Auxiliar.Auxi.CX[1] = Auxiliar.Auxi.RR7;
            }
            else if (regdest2 == "DX")
            {
                ALU.Resta(alto1, alto2, alto3, alto4, alto5, alto6, alto7, alto8, bajo1, bajo2, bajo3, bajo4, bajo5, bajo6, bajo7, bajo8);
                Auxiliar.Auxi.DX[8] = Auxiliar.Auxi.RR0;
                Auxiliar.Auxi.DX[7] = Auxiliar.Auxi.RR1;
                Auxiliar.Auxi.DX[6] = Auxiliar.Auxi.RR2;
                Auxiliar.Auxi.DX[5] = Auxiliar.Auxi.RR3;
                Auxiliar.Auxi.DX[4] = Auxiliar.Auxi.RR4;
                Auxiliar.Auxi.DX[3] = Auxiliar.Auxi.RR5;
                Auxiliar.Auxi.DX[2] = Auxiliar.Auxi.RR6;
                Auxiliar.Auxi.DX[1] = Auxiliar.Auxi.RR7;
            }
        }

        public void RestaRegistro(string Rega, string Regb) //a=origen, b=destino
        {
            if ((Rega == ("AX")) && (Regb == ("AX"))) //1=7, 1=6, 1=5, 1=4, etc.
            {
                ALU.Resta(Auxiliar.Auxi.AX[1], Auxiliar.Auxi.AX[2], Auxiliar.Auxi.AX[3], Auxiliar.Auxi.AX[4], Auxiliar.Auxi.AX[5], Auxiliar.Auxi.AX[6], Auxiliar.Auxi.AX[7], Auxiliar.Auxi.AX[8], //Registro a
                    Auxiliar.Auxi.AX[1], Auxiliar.Auxi.AX[2], Auxiliar.Auxi.AX[3], Auxiliar.Auxi.AX[4], Auxiliar.Auxi.AX[5], Auxiliar.Auxi.AX[6], Auxiliar.Auxi.AX[7], Auxiliar.Auxi.AX[8]); //Registro b
                Auxiliar.Auxi.AX[8] = Auxiliar.Auxi.RR0;
                Auxiliar.Auxi.AX[7] = Auxiliar.Auxi.RR1;
                Auxiliar.Auxi.AX[6] = Auxiliar.Auxi.RR2;
                Auxiliar.Auxi.AX[5] = Auxiliar.Auxi.RR3;
                Auxiliar.Auxi.AX[4] = Auxiliar.Auxi.RR4;
                Auxiliar.Auxi.AX[3] = Auxiliar.Auxi.RR5;
                Auxiliar.Auxi.AX[2] = Auxiliar.Auxi.RR6;
                Auxiliar.Auxi.AX[1] = Auxiliar.Auxi.RR7;
            }
            else if ((Rega == ("AX")) && (Regb == ("BX")))
            {
                ALU.Resta(Auxiliar.Auxi.AX[1], Auxiliar.Auxi.AX[2], Auxiliar.Auxi.AX[3], Auxiliar.Auxi.AX[4], Auxiliar.Auxi.AX[5], Auxiliar.Auxi.AX[6], Auxiliar.Auxi.AX[7], Auxiliar.Auxi.AX[8],
                    Auxiliar.Auxi.BX[1], Auxiliar.Auxi.BX[2], Auxiliar.Auxi.BX[3], Auxiliar.Auxi.BX[4], Auxiliar.Auxi.BX[5], Auxiliar.Auxi.BX[6], Auxiliar.Auxi.BX[7], Auxiliar.Auxi.BX[8]);
                Auxiliar.Auxi.BX[8] = Auxiliar.Auxi.RR0;
                Auxiliar.Auxi.BX[7] = Auxiliar.Auxi.RR1;
                Auxiliar.Auxi.BX[6] = Auxiliar.Auxi.RR2;
                Auxiliar.Auxi.BX[5] = Auxiliar.Auxi.RR3;
                Auxiliar.Auxi.BX[4] = Auxiliar.Auxi.RR4;
                Auxiliar.Auxi.BX[3] = Auxiliar.Auxi.RR5;
                Auxiliar.Auxi.BX[2] = Auxiliar.Auxi.RR6;
                Auxiliar.Auxi.BX[1] = Auxiliar.Auxi.RR7;//AQUI ME QUEDE
            }
            else if ((Rega == ("AX")) && (Regb == ("CX")))
            {
                ALU.Resta(Auxiliar.Auxi.AX[1], Auxiliar.Auxi.AX[2], Auxiliar.Auxi.AX[3], Auxiliar.Auxi.AX[4], Auxiliar.Auxi.AX[5], Auxiliar.Auxi.AX[6], Auxiliar.Auxi.AX[7], Auxiliar.Auxi.AX[8],
                    Auxiliar.Auxi.CX[1], Auxiliar.Auxi.CX[2], Auxiliar.Auxi.CX[3], Auxiliar.Auxi.CX[4], Auxiliar.Auxi.CX[5], Auxiliar.Auxi.CX[6], Auxiliar.Auxi.CX[7], Auxiliar.Auxi.CX[8]);
                Auxiliar.Auxi.CX[8] = Auxiliar.Auxi.RR0;
                Auxiliar.Auxi.CX[7] = Auxiliar.Auxi.RR1;
                Auxiliar.Auxi.CX[6] = Auxiliar.Auxi.RR2;
                Auxiliar.Auxi.CX[5] = Auxiliar.Auxi.RR3;
                Auxiliar.Auxi.CX[4] = Auxiliar.Auxi.RR4;
                Auxiliar.Auxi.CX[3] = Auxiliar.Auxi.RR5;
                Auxiliar.Auxi.CX[2] = Auxiliar.Auxi.RR6;
                Auxiliar.Auxi.CX[1] = Auxiliar.Auxi.RR7;
            }
            else if ((Rega == ("AX")) && (Regb == ("DX")))
            {
                ALU.Resta(Auxiliar.Auxi.AX[1], Auxiliar.Auxi.AX[2], Auxiliar.Auxi.AX[3], Auxiliar.Auxi.AX[4], Auxiliar.Auxi.AX[5], Auxiliar.Auxi.AX[6], Auxiliar.Auxi.AX[7], Auxiliar.Auxi.AX[8],
                    Auxiliar.Auxi.DX[1], Auxiliar.Auxi.DX[2], Auxiliar.Auxi.DX[3], Auxiliar.Auxi.DX[4], Auxiliar.Auxi.DX[5], Auxiliar.Auxi.DX[6], Auxiliar.Auxi.DX[7], Auxiliar.Auxi.DX[8]);
                Auxiliar.Auxi.DX[8] = Auxiliar.Auxi.RR0;
                Auxiliar.Auxi.DX[7] = Auxiliar.Auxi.RR1;
                Auxiliar.Auxi.DX[6] = Auxiliar.Auxi.RR2;
                Auxiliar.Auxi.DX[5] = Auxiliar.Auxi.RR3;
                Auxiliar.Auxi.DX[4] = Auxiliar.Auxi.RR4;
                Auxiliar.Auxi.DX[3] = Auxiliar.Auxi.RR5;
                Auxiliar.Auxi.DX[2] = Auxiliar.Auxi.RR6;
                Auxiliar.Auxi.DX[1] = Auxiliar.Auxi.RR7;
            }
            else if ((Rega == ("BX")) && (Regb == ("AX")))
            {
                ALU.Resta(Auxiliar.Auxi.BX[1], Auxiliar.Auxi.BX[2], Auxiliar.Auxi.BX[3], Auxiliar.Auxi.BX[4], Auxiliar.Auxi.BX[5], Auxiliar.Auxi.BX[6], Auxiliar.Auxi.BX[7], Auxiliar.Auxi.BX[8],
                    Auxiliar.Auxi.AX[1], Auxiliar.Auxi.AX[2], Auxiliar.Auxi.AX[3], Auxiliar.Auxi.AX[4], Auxiliar.Auxi.AX[5], Auxiliar.Auxi.AX[6], Auxiliar.Auxi.AX[7], Auxiliar.Auxi.AX[8]);
                Auxiliar.Auxi.AX[8] = Auxiliar.Auxi.RR0;
                Auxiliar.Auxi.AX[7] = Auxiliar.Auxi.RR1;
                Auxiliar.Auxi.AX[6] = Auxiliar.Auxi.RR2;
                Auxiliar.Auxi.AX[5] = Auxiliar.Auxi.RR3;
                Auxiliar.Auxi.AX[4] = Auxiliar.Auxi.RR4;
                Auxiliar.Auxi.AX[3] = Auxiliar.Auxi.RR5;
                Auxiliar.Auxi.AX[2] = Auxiliar.Auxi.RR6;
                Auxiliar.Auxi.AX[1] = Auxiliar.Auxi.RR7;
            }
            else if ((Rega == ("BX")) && (Regb == ("BX")))
            {
                ALU.Resta(Auxiliar.Auxi.BX[1], Auxiliar.Auxi.BX[2], Auxiliar.Auxi.BX[3], Auxiliar.Auxi.BX[4], Auxiliar.Auxi.BX[5], Auxiliar.Auxi.BX[6], Auxiliar.Auxi.BX[7], Auxiliar.Auxi.BX[8],
                    Auxiliar.Auxi.BX[1], Auxiliar.Auxi.BX[2], Auxiliar.Auxi.BX[3], Auxiliar.Auxi.BX[4], Auxiliar.Auxi.BX[5], Auxiliar.Auxi.BX[6], Auxiliar.Auxi.BX[7], Auxiliar.Auxi.BX[8]);
                Auxiliar.Auxi.BX[8] = Auxiliar.Auxi.RR0;
                Auxiliar.Auxi.BX[7] = Auxiliar.Auxi.RR1;
                Auxiliar.Auxi.BX[6] = Auxiliar.Auxi.RR2;
                Auxiliar.Auxi.BX[5] = Auxiliar.Auxi.RR3;
                Auxiliar.Auxi.BX[4] = Auxiliar.Auxi.RR4;
                Auxiliar.Auxi.BX[3] = Auxiliar.Auxi.RR5;
                Auxiliar.Auxi.BX[2] = Auxiliar.Auxi.RR6;
                Auxiliar.Auxi.BX[1] = Auxiliar.Auxi.RR7;
            }
            else if ((Rega == ("BX")) && (Regb == ("CX")))
            {
                ALU.Resta(Auxiliar.Auxi.BX[1], Auxiliar.Auxi.BX[2], Auxiliar.Auxi.BX[3], Auxiliar.Auxi.BX[4], Auxiliar.Auxi.BX[5], Auxiliar.Auxi.BX[6], Auxiliar.Auxi.BX[7], Auxiliar.Auxi.BX[8],
                    Auxiliar.Auxi.CX[1], Auxiliar.Auxi.CX[2], Auxiliar.Auxi.CX[3], Auxiliar.Auxi.CX[4], Auxiliar.Auxi.CX[5], Auxiliar.Auxi.CX[6], Auxiliar.Auxi.CX[7], Auxiliar.Auxi.CX[8]);
                Auxiliar.Auxi.CX[8] = Auxiliar.Auxi.RR0;
                Auxiliar.Auxi.CX[7] = Auxiliar.Auxi.RR1;
                Auxiliar.Auxi.CX[6] = Auxiliar.Auxi.RR2;
                Auxiliar.Auxi.CX[5] = Auxiliar.Auxi.RR3;
                Auxiliar.Auxi.CX[4] = Auxiliar.Auxi.RR4;
                Auxiliar.Auxi.CX[3] = Auxiliar.Auxi.RR5;
                Auxiliar.Auxi.CX[2] = Auxiliar.Auxi.RR6;
                Auxiliar.Auxi.CX[1] = Auxiliar.Auxi.RR7;
            }
            else if ((Rega == ("BX")) && (Regb == ("DX")))
            {
                ALU.Resta(Auxiliar.Auxi.BX[1], Auxiliar.Auxi.BX[2], Auxiliar.Auxi.BX[3], Auxiliar.Auxi.BX[4], Auxiliar.Auxi.BX[5], Auxiliar.Auxi.BX[6], Auxiliar.Auxi.BX[7], Auxiliar.Auxi.BX[8],
                    Auxiliar.Auxi.DX[1], Auxiliar.Auxi.DX[2], Auxiliar.Auxi.DX[3], Auxiliar.Auxi.DX[4], Auxiliar.Auxi.DX[5], Auxiliar.Auxi.DX[6], Auxiliar.Auxi.DX[7], Auxiliar.Auxi.DX[8]);
                Auxiliar.Auxi.DX[8] = Auxiliar.Auxi.RR0;
                Auxiliar.Auxi.DX[7] = Auxiliar.Auxi.RR1;
                Auxiliar.Auxi.DX[6] = Auxiliar.Auxi.RR2;
                Auxiliar.Auxi.DX[5] = Auxiliar.Auxi.RR3;
                Auxiliar.Auxi.DX[4] = Auxiliar.Auxi.RR4;
                Auxiliar.Auxi.DX[3] = Auxiliar.Auxi.RR5;
                Auxiliar.Auxi.DX[2] = Auxiliar.Auxi.RR6;
                Auxiliar.Auxi.DX[1] = Auxiliar.Auxi.RR7;
            }
            else if ((Rega == ("CX")) && (Regb == ("AX")))
            {
                ALU.Resta(Auxiliar.Auxi.CX[1], Auxiliar.Auxi.CX[2], Auxiliar.Auxi.CX[3], Auxiliar.Auxi.CX[4], Auxiliar.Auxi.CX[5], Auxiliar.Auxi.CX[6], Auxiliar.Auxi.CX[7], Auxiliar.Auxi.CX[8],
                    Auxiliar.Auxi.AX[1], Auxiliar.Auxi.AX[2], Auxiliar.Auxi.AX[3], Auxiliar.Auxi.AX[4], Auxiliar.Auxi.AX[5], Auxiliar.Auxi.AX[6], Auxiliar.Auxi.AX[7], Auxiliar.Auxi.AX[8]);
                Auxiliar.Auxi.AX[8] = Auxiliar.Auxi.RR0;
                Auxiliar.Auxi.AX[7] = Auxiliar.Auxi.RR1;
                Auxiliar.Auxi.AX[6] = Auxiliar.Auxi.RR2;
                Auxiliar.Auxi.AX[5] = Auxiliar.Auxi.RR3;
                Auxiliar.Auxi.AX[4] = Auxiliar.Auxi.RR4;
                Auxiliar.Auxi.AX[3] = Auxiliar.Auxi.RR5;
                Auxiliar.Auxi.AX[2] = Auxiliar.Auxi.RR6;
                Auxiliar.Auxi.AX[1] = Auxiliar.Auxi.RR7;
            }
            else if ((Rega == ("CX")) && (Regb == ("BX")))
            {
                ALU.Resta(Auxiliar.Auxi.CX[1], Auxiliar.Auxi.CX[2], Auxiliar.Auxi.CX[3], Auxiliar.Auxi.CX[4], Auxiliar.Auxi.CX[5], Auxiliar.Auxi.CX[6], Auxiliar.Auxi.CX[7], Auxiliar.Auxi.CX[8],
                    Auxiliar.Auxi.BX[1], Auxiliar.Auxi.BX[2], Auxiliar.Auxi.BX[3], Auxiliar.Auxi.BX[4], Auxiliar.Auxi.BX[5], Auxiliar.Auxi.BX[6], Auxiliar.Auxi.BX[7], Auxiliar.Auxi.BX[8]);
                Auxiliar.Auxi.BX[8] = Auxiliar.Auxi.RR0;
                Auxiliar.Auxi.BX[7] = Auxiliar.Auxi.RR1;
                Auxiliar.Auxi.BX[6] = Auxiliar.Auxi.RR2;
                Auxiliar.Auxi.BX[5] = Auxiliar.Auxi.RR3;
                Auxiliar.Auxi.BX[4] = Auxiliar.Auxi.RR4;
                Auxiliar.Auxi.BX[3] = Auxiliar.Auxi.RR5;
                Auxiliar.Auxi.BX[2] = Auxiliar.Auxi.RR6;
                Auxiliar.Auxi.BX[1] = Auxiliar.Auxi.RR7;
            }
            else if ((Rega == ("CX")) && (Regb == ("CX")))
            {
                ALU.Resta(Auxiliar.Auxi.CX[1], Auxiliar.Auxi.CX[2], Auxiliar.Auxi.CX[3], Auxiliar.Auxi.CX[4], Auxiliar.Auxi.CX[5], Auxiliar.Auxi.CX[6], Auxiliar.Auxi.CX[7], Auxiliar.Auxi.CX[8],
                    Auxiliar.Auxi.CX[1], Auxiliar.Auxi.CX[2], Auxiliar.Auxi.CX[3], Auxiliar.Auxi.CX[4], Auxiliar.Auxi.CX[5], Auxiliar.Auxi.CX[6], Auxiliar.Auxi.CX[7], Auxiliar.Auxi.CX[8]);
                Auxiliar.Auxi.CX[8] = Auxiliar.Auxi.RR0;
                Auxiliar.Auxi.CX[7] = Auxiliar.Auxi.RR1;
                Auxiliar.Auxi.CX[6] = Auxiliar.Auxi.RR2;
                Auxiliar.Auxi.CX[5] = Auxiliar.Auxi.RR3;
                Auxiliar.Auxi.CX[4] = Auxiliar.Auxi.RR4;
                Auxiliar.Auxi.CX[3] = Auxiliar.Auxi.RR5;
                Auxiliar.Auxi.CX[2] = Auxiliar.Auxi.RR6;
                Auxiliar.Auxi.CX[1] = Auxiliar.Auxi.RR7;
            }
            else if ((Rega == ("CX")) && (Regb == ("DX")))
            {
                ALU.Resta(Auxiliar.Auxi.CX[1], Auxiliar.Auxi.CX[2], Auxiliar.Auxi.CX[3], Auxiliar.Auxi.CX[4], Auxiliar.Auxi.CX[5], Auxiliar.Auxi.CX[6], Auxiliar.Auxi.CX[7], Auxiliar.Auxi.CX[8],
                    Auxiliar.Auxi.DX[1], Auxiliar.Auxi.DX[2], Auxiliar.Auxi.DX[3], Auxiliar.Auxi.DX[4], Auxiliar.Auxi.DX[5], Auxiliar.Auxi.DX[6], Auxiliar.Auxi.DX[7], Auxiliar.Auxi.DX[8]);
                Auxiliar.Auxi.DX[8] = Auxiliar.Auxi.RR0;
                Auxiliar.Auxi.DX[7] = Auxiliar.Auxi.RR1;
                Auxiliar.Auxi.DX[6] = Auxiliar.Auxi.RR2;
                Auxiliar.Auxi.DX[5] = Auxiliar.Auxi.RR3;
                Auxiliar.Auxi.DX[4] = Auxiliar.Auxi.RR4;
                Auxiliar.Auxi.DX[3] = Auxiliar.Auxi.RR5;
                Auxiliar.Auxi.DX[2] = Auxiliar.Auxi.RR6;
                Auxiliar.Auxi.DX[1] = Auxiliar.Auxi.RR7;
            }
            else if ((Rega == ("DX")) && (Regb == ("AX")))
            {
                ALU.Resta(Auxiliar.Auxi.DX[1], Auxiliar.Auxi.DX[2], Auxiliar.Auxi.DX[3], Auxiliar.Auxi.DX[4], Auxiliar.Auxi.DX[5], Auxiliar.Auxi.DX[6], Auxiliar.Auxi.DX[7], Auxiliar.Auxi.DX[8],
                    Auxiliar.Auxi.AX[1], Auxiliar.Auxi.AX[2], Auxiliar.Auxi.AX[3], Auxiliar.Auxi.AX[4], Auxiliar.Auxi.AX[5], Auxiliar.Auxi.AX[6], Auxiliar.Auxi.AX[7], Auxiliar.Auxi.AX[8]);
                Auxiliar.Auxi.AX[8] = Auxiliar.Auxi.RR0;
                Auxiliar.Auxi.AX[7] = Auxiliar.Auxi.RR1;
                Auxiliar.Auxi.AX[6] = Auxiliar.Auxi.RR2;
                Auxiliar.Auxi.AX[5] = Auxiliar.Auxi.RR3;
                Auxiliar.Auxi.AX[4] = Auxiliar.Auxi.RR4;
                Auxiliar.Auxi.AX[3] = Auxiliar.Auxi.RR5;
                Auxiliar.Auxi.AX[2] = Auxiliar.Auxi.RR6;
                Auxiliar.Auxi.AX[1] = Auxiliar.Auxi.RR7;
            }
            else if ((Rega == ("DX")) && (Regb == ("BX")))
            {
                ALU.Resta(Auxiliar.Auxi.DX[1], Auxiliar.Auxi.DX[2], Auxiliar.Auxi.DX[3], Auxiliar.Auxi.DX[4], Auxiliar.Auxi.DX[5], Auxiliar.Auxi.DX[6], Auxiliar.Auxi.DX[7], Auxiliar.Auxi.DX[8],
                    Auxiliar.Auxi.BX[1], Auxiliar.Auxi.BX[2], Auxiliar.Auxi.BX[3], Auxiliar.Auxi.BX[4], Auxiliar.Auxi.BX[5], Auxiliar.Auxi.BX[6], Auxiliar.Auxi.BX[7], Auxiliar.Auxi.BX[8]);
                Auxiliar.Auxi.BX[8] = Auxiliar.Auxi.RR0;
                Auxiliar.Auxi.BX[7] = Auxiliar.Auxi.RR1;
                Auxiliar.Auxi.BX[6] = Auxiliar.Auxi.RR2;
                Auxiliar.Auxi.BX[5] = Auxiliar.Auxi.RR3;
                Auxiliar.Auxi.BX[4] = Auxiliar.Auxi.RR4;
                Auxiliar.Auxi.BX[3] = Auxiliar.Auxi.RR5;
                Auxiliar.Auxi.BX[2] = Auxiliar.Auxi.RR6;
                Auxiliar.Auxi.BX[1] = Auxiliar.Auxi.RR7;
            }
            else if ((Rega == ("DX")) && (Regb == ("CX")))
            {
                ALU.Resta(Auxiliar.Auxi.DX[1], Auxiliar.Auxi.DX[2], Auxiliar.Auxi.DX[3], Auxiliar.Auxi.DX[4], Auxiliar.Auxi.DX[5], Auxiliar.Auxi.DX[6], Auxiliar.Auxi.DX[7], Auxiliar.Auxi.DX[8],
                    Auxiliar.Auxi.CX[1], Auxiliar.Auxi.CX[2], Auxiliar.Auxi.CX[3], Auxiliar.Auxi.CX[4], Auxiliar.Auxi.CX[5], Auxiliar.Auxi.CX[6], Auxiliar.Auxi.CX[7], Auxiliar.Auxi.CX[8]);
                Auxiliar.Auxi.CX[8] = Auxiliar.Auxi.RR0;
                Auxiliar.Auxi.CX[7] = Auxiliar.Auxi.RR1;
                Auxiliar.Auxi.CX[6] = Auxiliar.Auxi.RR2;
                Auxiliar.Auxi.CX[5] = Auxiliar.Auxi.RR3;
                Auxiliar.Auxi.CX[4] = Auxiliar.Auxi.RR4;
                Auxiliar.Auxi.CX[3] = Auxiliar.Auxi.RR5;
                Auxiliar.Auxi.CX[2] = Auxiliar.Auxi.RR6;
                Auxiliar.Auxi.CX[1] = Auxiliar.Auxi.RR7;
            }
            else if ((Rega == ("DX")) && (Regb == ("DX")))
            {
                ALU.Resta(Auxiliar.Auxi.DX[1], Auxiliar.Auxi.DX[2], Auxiliar.Auxi.DX[3], Auxiliar.Auxi.DX[4], Auxiliar.Auxi.DX[5], Auxiliar.Auxi.DX[6], Auxiliar.Auxi.DX[7], Auxiliar.Auxi.DX[8],
                    Auxiliar.Auxi.DX[1], Auxiliar.Auxi.DX[2], Auxiliar.Auxi.DX[3], Auxiliar.Auxi.DX[4], Auxiliar.Auxi.DX[5], Auxiliar.Auxi.DX[6], Auxiliar.Auxi.DX[7], Auxiliar.Auxi.DX[8]);
                Auxiliar.Auxi.DX[8] = Auxiliar.Auxi.RR0;
                Auxiliar.Auxi.DX[7] = Auxiliar.Auxi.RR1;
                Auxiliar.Auxi.DX[6] = Auxiliar.Auxi.RR2;
                Auxiliar.Auxi.DX[5] = Auxiliar.Auxi.RR3;
                Auxiliar.Auxi.DX[4] = Auxiliar.Auxi.RR4;
                Auxiliar.Auxi.DX[3] = Auxiliar.Auxi.RR5;
                Auxiliar.Auxi.DX[2] = Auxiliar.Auxi.RR6;
                Auxiliar.Auxi.DX[1] = Auxiliar.Auxi.RR7;
            }
        }

        public void ANDNoRegistro(string regdest2, int bajo1, int bajo2, int bajo3, int bajo4, int bajo5, int bajo6, int bajo7, int bajo8,
            int alto1, int alto2, int alto3, int alto4, int alto5, int alto6, int alto7, int alto8)
        {
            if (regdest2 == "AX")
            {
                Auxi.AX[8] = ALU.AND(alto8, bajo8);
                Auxi.AX[7] = ALU.AND(alto7, bajo7);
                Auxi.AX[6] = ALU.AND(alto6, bajo6);
                Auxi.AX[5] = ALU.AND(alto5, bajo5);
                Auxi.AX[4] = ALU.AND(alto4, bajo4);
                Auxi.AX[3] = ALU.AND(alto3, bajo3);
                Auxi.AX[2] = ALU.AND(alto2, bajo2);
                Auxi.AX[1] = ALU.AND(alto1, bajo1);
            }
            else if (regdest2 == "BX")
            {
                Auxi.BX[8] = ALU.AND(alto8, bajo8);
                Auxi.BX[7] = ALU.AND(alto7, bajo7);
                Auxi.BX[6] = ALU.AND(alto6, bajo6);
                Auxi.BX[5] = ALU.AND(alto5, bajo5);
                Auxi.BX[4] = ALU.AND(alto4, bajo4);
                Auxi.BX[3] = ALU.AND(alto3, bajo3);
                Auxi.BX[2] = ALU.AND(alto2, bajo2);
                Auxi.BX[1] = ALU.AND(alto1, bajo1);
            }
            else if (regdest2 == "CX")
            {
                Auxi.CX[8] = ALU.AND(alto8, bajo8);
                Auxi.CX[7] = ALU.AND(alto7, bajo7);
                Auxi.CX[6] = ALU.AND(alto6, bajo6);
                Auxi.CX[5] = ALU.AND(alto5, bajo5);
                Auxi.CX[4] = ALU.AND(alto4, bajo4);
                Auxi.CX[3] = ALU.AND(alto3, bajo3);
                Auxi.CX[2] = ALU.AND(alto2, bajo2);
                Auxi.CX[1] = ALU.AND(alto1, bajo1);
            }
            else if (regdest2 == "DX")
            {
                Auxi.DX[8] = ALU.AND(alto8, bajo8);
                Auxi.DX[7] = ALU.AND(alto7, bajo7);
                Auxi.DX[6] = ALU.AND(alto6, bajo6);
                Auxi.DX[5] = ALU.AND(alto5, bajo5);
                Auxi.DX[4] = ALU.AND(alto4, bajo4);
                Auxi.DX[3] = ALU.AND(alto3, bajo3);
                Auxi.DX[2] = ALU.AND(alto2, bajo2);
                Auxi.DX[1] = ALU.AND(alto1, bajo1);
            }
        }

        public void ANDRegistro(string Rega, string Regb)
        {
            if ((Rega == ("AX")) && (Regb == ("AX"))) //1=7, 1=6, 1=5, 1=4, etc.
            {
                Auxi.AX[8] = ALU.AND(Auxi.AX[8], Auxi.AX[8]);
                Auxi.AX[7] = ALU.AND(Auxi.AX[7], Auxi.AX[7]);
                Auxi.AX[6] = ALU.AND(Auxi.AX[6], Auxi.AX[6]);
                Auxi.AX[5] = ALU.AND(Auxi.AX[5], Auxi.AX[5]);
                Auxi.AX[4] = ALU.AND(Auxi.AX[4], Auxi.AX[4]);
                Auxi.AX[3] = ALU.AND(Auxi.AX[3], Auxi.AX[3]);
                Auxi.AX[2] = ALU.AND(Auxi.AX[2], Auxi.AX[2]);
                Auxi.AX[1] = ALU.AND(Auxi.AX[1], Auxi.AX[1]);
            }
            else if ((Rega == ("AX")) && (Regb == ("BX")))
            {
                Auxi.BX[8] = ALU.AND(Auxi.AX[8], Auxi.BX[8]);
                Auxi.BX[7] = ALU.AND(Auxi.AX[7], Auxi.BX[7]);
                Auxi.BX[6] = ALU.AND(Auxi.AX[6], Auxi.BX[6]);
                Auxi.BX[5] = ALU.AND(Auxi.AX[5], Auxi.BX[5]);
                Auxi.BX[4] = ALU.AND(Auxi.AX[4], Auxi.BX[4]);
                Auxi.BX[3] = ALU.AND(Auxi.AX[3], Auxi.BX[3]);
                Auxi.BX[2] = ALU.AND(Auxi.AX[2], Auxi.BX[2]);
                Auxi.BX[1] = ALU.AND(Auxi.AX[1], Auxi.BX[1]);
            }
            else if ((Rega == ("AX")) && (Regb == ("CX")))
            {
                Auxi.CX[8] = ALU.AND(Auxi.AX[8], Auxi.CX[8]);
                Auxi.CX[7] = ALU.AND(Auxi.AX[7], Auxi.CX[7]);
                Auxi.CX[6] = ALU.AND(Auxi.AX[6], Auxi.CX[6]);
                Auxi.CX[5] = ALU.AND(Auxi.AX[5], Auxi.CX[5]);
                Auxi.CX[4] = ALU.AND(Auxi.AX[4], Auxi.CX[4]);
                Auxi.CX[3] = ALU.AND(Auxi.AX[3], Auxi.CX[3]);
                Auxi.CX[2] = ALU.AND(Auxi.AX[2], Auxi.CX[2]);
                Auxi.CX[1] = ALU.AND(Auxi.AX[1], Auxi.CX[1]);
            }
            else if ((Rega == ("AX")) && (Regb == ("DX")))
            {
                Auxi.DX[8] = ALU.AND(Auxi.AX[8], Auxi.DX[8]);
                Auxi.DX[7] = ALU.AND(Auxi.AX[7], Auxi.DX[7]);
                Auxi.DX[6] = ALU.AND(Auxi.AX[6], Auxi.DX[6]);
                Auxi.DX[5] = ALU.AND(Auxi.AX[5], Auxi.DX[5]);
                Auxi.DX[4] = ALU.AND(Auxi.AX[4], Auxi.DX[4]);
                Auxi.DX[3] = ALU.AND(Auxi.AX[3], Auxi.DX[3]);
                Auxi.DX[2] = ALU.AND(Auxi.AX[2], Auxi.DX[2]);
                Auxi.DX[1] = ALU.AND(Auxi.AX[1], Auxi.DX[1]);
            }
            else if ((Rega == ("BX")) && (Regb == ("AX")))
            {
                Auxi.AX[8] = ALU.AND(Auxi.BX[8], Auxi.AX[8]);
                Auxi.AX[7] = ALU.AND(Auxi.BX[7], Auxi.AX[7]);
                Auxi.AX[6] = ALU.AND(Auxi.BX[6], Auxi.AX[6]);
                Auxi.AX[5] = ALU.AND(Auxi.BX[5], Auxi.AX[5]);
                Auxi.AX[4] = ALU.AND(Auxi.BX[4], Auxi.AX[4]);
                Auxi.AX[3] = ALU.AND(Auxi.BX[3], Auxi.AX[3]);
                Auxi.AX[2] = ALU.AND(Auxi.BX[2], Auxi.AX[2]);
                Auxi.AX[1] = ALU.AND(Auxi.BX[1], Auxi.AX[1]);
            }
            else if ((Rega == ("BX")) && (Regb == ("BX")))
            {
                Auxi.BX[8] = ALU.AND(Auxi.BX[8], Auxi.BX[8]);
                Auxi.BX[7] = ALU.AND(Auxi.BX[7], Auxi.BX[7]);
                Auxi.BX[6] = ALU.AND(Auxi.BX[6], Auxi.BX[6]);
                Auxi.BX[5] = ALU.AND(Auxi.BX[5], Auxi.BX[5]);
                Auxi.BX[4] = ALU.AND(Auxi.BX[4], Auxi.BX[4]);
                Auxi.BX[3] = ALU.AND(Auxi.BX[3], Auxi.BX[3]);
                Auxi.BX[2] = ALU.AND(Auxi.BX[2], Auxi.BX[2]);
                Auxi.BX[1] = ALU.AND(Auxi.BX[1], Auxi.BX[1]);
            }
            else if ((Rega == ("BX")) && (Regb == ("CX")))
            {
                Auxi.CX[8] = ALU.AND(Auxi.BX[8], Auxi.CX[8]);
                Auxi.CX[7] = ALU.AND(Auxi.BX[7], Auxi.CX[7]);
                Auxi.CX[6] = ALU.AND(Auxi.BX[6], Auxi.CX[6]);
                Auxi.CX[5] = ALU.AND(Auxi.BX[5], Auxi.CX[5]);
                Auxi.CX[4] = ALU.AND(Auxi.BX[4], Auxi.CX[4]);
                Auxi.CX[3] = ALU.AND(Auxi.BX[3], Auxi.CX[3]);
                Auxi.CX[2] = ALU.AND(Auxi.BX[2], Auxi.CX[2]);
                Auxi.CX[1] = ALU.AND(Auxi.BX[1], Auxi.CX[1]);
            }
            else if ((Rega == ("BX")) && (Regb == ("DX")))
            {
                Auxi.DX[8] = ALU.AND(Auxi.BX[8], Auxi.DX[8]);
                Auxi.DX[7] = ALU.AND(Auxi.BX[7], Auxi.DX[7]);
                Auxi.DX[6] = ALU.AND(Auxi.BX[6], Auxi.DX[6]);
                Auxi.DX[5] = ALU.AND(Auxi.BX[5], Auxi.DX[5]);
                Auxi.DX[4] = ALU.AND(Auxi.BX[4], Auxi.DX[4]);
                Auxi.DX[3] = ALU.AND(Auxi.BX[3], Auxi.DX[3]);
                Auxi.DX[2] = ALU.AND(Auxi.BX[2], Auxi.DX[2]);
                Auxi.DX[1] = ALU.AND(Auxi.BX[1], Auxi.DX[1]);
            }
            else if ((Rega == ("CX")) && (Regb == ("AX")))
            {
                Auxi.AX[8] = ALU.AND(Auxi.CX[8], Auxi.AX[8]);
                Auxi.AX[7] = ALU.AND(Auxi.CX[7], Auxi.AX[7]);
                Auxi.AX[6] = ALU.AND(Auxi.CX[6], Auxi.AX[6]);
                Auxi.AX[5] = ALU.AND(Auxi.CX[5], Auxi.AX[5]);
                Auxi.AX[4] = ALU.AND(Auxi.CX[4], Auxi.AX[4]);
                Auxi.AX[3] = ALU.AND(Auxi.CX[3], Auxi.AX[3]);
                Auxi.AX[2] = ALU.AND(Auxi.CX[2], Auxi.AX[2]);
                Auxi.AX[1] = ALU.AND(Auxi.CX[1], Auxi.AX[1]);
            }
            else if ((Rega == ("CX")) && (Regb == ("BX")))
            {
                Auxi.BX[8] = ALU.AND(Auxi.CX[8], Auxi.BX[8]);
                Auxi.BX[7] = ALU.AND(Auxi.CX[7], Auxi.BX[7]);
                Auxi.BX[6] = ALU.AND(Auxi.CX[6], Auxi.BX[6]);
                Auxi.BX[5] = ALU.AND(Auxi.CX[5], Auxi.BX[5]);
                Auxi.BX[4] = ALU.AND(Auxi.CX[4], Auxi.BX[4]);
                Auxi.BX[3] = ALU.AND(Auxi.CX[3], Auxi.BX[3]);
                Auxi.BX[2] = ALU.AND(Auxi.CX[2], Auxi.BX[2]);
                Auxi.BX[1] = ALU.AND(Auxi.CX[1], Auxi.BX[1]);
            }
            else if ((Rega == ("CX")) && (Regb == ("CX")))
            {
                Auxi.CX[8] = ALU.AND(Auxi.CX[8], Auxi.CX[8]);
                Auxi.CX[7] = ALU.AND(Auxi.CX[7], Auxi.CX[7]);
                Auxi.CX[6] = ALU.AND(Auxi.CX[6], Auxi.CX[6]);
                Auxi.CX[5] = ALU.AND(Auxi.CX[5], Auxi.CX[5]);
                Auxi.CX[4] = ALU.AND(Auxi.CX[4], Auxi.CX[4]);
                Auxi.CX[3] = ALU.AND(Auxi.CX[3], Auxi.CX[3]);
                Auxi.CX[2] = ALU.AND(Auxi.CX[2], Auxi.CX[2]);
                Auxi.CX[1] = ALU.AND(Auxi.CX[1], Auxi.CX[1]);
            }
            else if ((Rega == ("CX")) && (Regb == ("DX")))
            {
                Auxi.DX[8] = ALU.AND(Auxi.CX[8], Auxi.DX[8]);
                Auxi.DX[7] = ALU.AND(Auxi.CX[7], Auxi.DX[7]);
                Auxi.DX[6] = ALU.AND(Auxi.CX[6], Auxi.DX[6]);
                Auxi.DX[5] = ALU.AND(Auxi.CX[5], Auxi.DX[5]);
                Auxi.DX[4] = ALU.AND(Auxi.CX[4], Auxi.DX[4]);
                Auxi.DX[3] = ALU.AND(Auxi.CX[3], Auxi.DX[3]);
                Auxi.DX[2] = ALU.AND(Auxi.CX[2], Auxi.DX[2]);
                Auxi.DX[1] = ALU.AND(Auxi.CX[1], Auxi.DX[1]);
            }
            else if ((Rega == ("DX")) && (Regb == ("AX")))
            {
                Auxi.AX[8] = ALU.AND(Auxi.DX[8], Auxi.AX[8]);
                Auxi.AX[7] = ALU.AND(Auxi.DX[7], Auxi.AX[7]);
                Auxi.AX[6] = ALU.AND(Auxi.DX[6], Auxi.AX[6]);
                Auxi.AX[5] = ALU.AND(Auxi.DX[5], Auxi.AX[5]);
                Auxi.AX[4] = ALU.AND(Auxi.DX[4], Auxi.AX[4]);
                Auxi.AX[3] = ALU.AND(Auxi.DX[3], Auxi.AX[3]);
                Auxi.AX[2] = ALU.AND(Auxi.DX[2], Auxi.AX[2]);
                Auxi.AX[1] = ALU.AND(Auxi.DX[1], Auxi.AX[1]);
            }
            else if ((Rega == ("DX")) && (Regb == ("BX")))
            {
                Auxi.BX[8] = ALU.AND(Auxi.DX[8], Auxi.BX[8]);
                Auxi.BX[7] = ALU.AND(Auxi.DX[7], Auxi.BX[7]);
                Auxi.BX[6] = ALU.AND(Auxi.DX[6], Auxi.BX[6]);
                Auxi.BX[5] = ALU.AND(Auxi.DX[5], Auxi.BX[5]);
                Auxi.BX[4] = ALU.AND(Auxi.DX[4], Auxi.BX[4]);
                Auxi.BX[3] = ALU.AND(Auxi.DX[3], Auxi.BX[3]);
                Auxi.BX[2] = ALU.AND(Auxi.DX[2], Auxi.BX[2]);
                Auxi.BX[1] = ALU.AND(Auxi.DX[1], Auxi.BX[1]);
            }
            else if ((Rega == ("DX")) && (Regb == ("CX")))
            {
                Auxi.CX[8] = ALU.AND(Auxi.DX[8], Auxi.CX[8]);
                Auxi.CX[7] = ALU.AND(Auxi.DX[7], Auxi.CX[7]);
                Auxi.CX[6] = ALU.AND(Auxi.DX[6], Auxi.CX[6]);
                Auxi.CX[5] = ALU.AND(Auxi.DX[5], Auxi.CX[5]);
                Auxi.CX[4] = ALU.AND(Auxi.DX[4], Auxi.CX[4]);
                Auxi.CX[3] = ALU.AND(Auxi.DX[3], Auxi.CX[3]);
                Auxi.CX[2] = ALU.AND(Auxi.DX[2], Auxi.CX[2]);
                Auxi.CX[1] = ALU.AND(Auxi.DX[1], Auxi.CX[1]);
            }
            else if ((Rega == ("DX")) && (Regb == ("DX")))
            {
                Auxi.DX[8] = ALU.AND(Auxi.DX[8], Auxi.DX[8]);
                Auxi.DX[7] = ALU.AND(Auxi.DX[7], Auxi.DX[7]);
                Auxi.DX[6] = ALU.AND(Auxi.DX[6], Auxi.DX[6]);
                Auxi.DX[5] = ALU.AND(Auxi.DX[5], Auxi.DX[5]);
                Auxi.DX[4] = ALU.AND(Auxi.DX[4], Auxi.DX[4]);
                Auxi.DX[3] = ALU.AND(Auxi.DX[3], Auxi.DX[3]);
                Auxi.DX[2] = ALU.AND(Auxi.DX[2], Auxi.DX[2]);
                Auxi.DX[1] = ALU.AND(Auxi.DX[1], Auxi.DX[1]);
            }
        }

        public void ORNoRegistro(string regdest2, int bajo1, int bajo2, int bajo3, int bajo4, int bajo5, int bajo6, int bajo7, int bajo8,
            int alto1, int alto2, int alto3, int alto4, int alto5, int alto6, int alto7, int alto8)
        {
            if (regdest2 == "AX")
            {
                Auxi.AX[8] = ALU.OR(alto8, bajo8);
                Auxi.AX[7] = ALU.OR(alto7, bajo7);
                Auxi.AX[6] = ALU.OR(alto6, bajo6);
                Auxi.AX[5] = ALU.OR(alto5, bajo5);
                Auxi.AX[4] = ALU.OR(alto4, bajo4);
                Auxi.AX[3] = ALU.OR(alto3, bajo3);
                Auxi.AX[2] = ALU.OR(alto2, bajo2);
                Auxi.AX[1] = ALU.OR(alto1, bajo1);
            }
            else if (regdest2 == "BX")
            {
                Auxi.BX[8] = ALU.OR(alto8, bajo8);
                Auxi.BX[7] = ALU.OR(alto7, bajo7);
                Auxi.BX[6] = ALU.OR(alto6, bajo6);
                Auxi.BX[5] = ALU.OR(alto5, bajo5);
                Auxi.BX[4] = ALU.OR(alto4, bajo4);
                Auxi.BX[3] = ALU.OR(alto3, bajo3);
                Auxi.BX[2] = ALU.OR(alto2, bajo2);
                Auxi.BX[1] = ALU.OR(alto1, bajo1);
            }
            else if (regdest2 == "CX")
            {
                Auxi.CX[8] = ALU.OR(alto8, bajo8);
                Auxi.CX[7] = ALU.OR(alto7, bajo7);
                Auxi.CX[6] = ALU.OR(alto6, bajo6);
                Auxi.CX[5] = ALU.OR(alto5, bajo5);
                Auxi.CX[4] = ALU.OR(alto4, bajo4);
                Auxi.CX[3] = ALU.OR(alto3, bajo3);
                Auxi.CX[2] = ALU.OR(alto2, bajo2);
                Auxi.CX[1] = ALU.OR(alto1, bajo1);
            }
            else if (regdest2 == "DX")
            {
                Auxi.DX[8] = ALU.OR(alto8, bajo8);
                Auxi.DX[7] = ALU.OR(alto7, bajo7);
                Auxi.DX[6] = ALU.OR(alto6, bajo6);
                Auxi.DX[5] = ALU.OR(alto5, bajo5);
                Auxi.DX[4] = ALU.OR(alto4, bajo4);
                Auxi.DX[3] = ALU.OR(alto3, bajo3);
                Auxi.DX[2] = ALU.OR(alto2, bajo2);
                Auxi.DX[1] = ALU.OR(alto1, bajo1);
            }
        }

        public void ORRegistro(string Rega, string Regb)
        {
            if ((Rega == ("AX")) && (Regb == ("AX"))) //1=7, 1=6, 1=5, 1=4, etc.
            {
                Auxi.AX[8] = ALU.OR(Auxi.AX[8], Auxi.AX[8]);
                Auxi.AX[7] = ALU.OR(Auxi.AX[7], Auxi.AX[7]);
                Auxi.AX[6] = ALU.OR(Auxi.AX[6], Auxi.AX[6]);
                Auxi.AX[5] = ALU.OR(Auxi.AX[5], Auxi.AX[5]);
                Auxi.AX[4] = ALU.OR(Auxi.AX[4], Auxi.AX[4]);
                Auxi.AX[3] = ALU.OR(Auxi.AX[3], Auxi.AX[3]);
                Auxi.AX[2] = ALU.OR(Auxi.AX[2], Auxi.AX[2]);
                Auxi.AX[1] = ALU.OR(Auxi.AX[1], Auxi.AX[1]);
            }
            else if ((Rega == ("AX")) && (Regb == ("BX")))
            {
                Auxi.BX[8] = ALU.OR(Auxi.AX[8], Auxi.BX[8]);
                Auxi.BX[7] = ALU.OR(Auxi.AX[7], Auxi.BX[7]);
                Auxi.BX[6] = ALU.OR(Auxi.AX[6], Auxi.BX[6]);
                Auxi.BX[5] = ALU.OR(Auxi.AX[5], Auxi.BX[5]);
                Auxi.BX[4] = ALU.OR(Auxi.AX[4], Auxi.BX[4]);
                Auxi.BX[3] = ALU.OR(Auxi.AX[3], Auxi.BX[3]);
                Auxi.BX[2] = ALU.OR(Auxi.AX[2], Auxi.BX[2]);
                Auxi.BX[1] = ALU.OR(Auxi.AX[1], Auxi.BX[1]);
            }
            else if ((Rega == ("AX")) && (Regb == ("CX")))
            {
                Auxi.CX[8] = ALU.OR(Auxi.AX[8], Auxi.CX[8]);
                Auxi.CX[7] = ALU.OR(Auxi.AX[7], Auxi.CX[7]);
                Auxi.CX[6] = ALU.OR(Auxi.AX[6], Auxi.CX[6]);
                Auxi.CX[5] = ALU.OR(Auxi.AX[5], Auxi.CX[5]);
                Auxi.CX[4] = ALU.OR(Auxi.AX[4], Auxi.CX[4]);
                Auxi.CX[3] = ALU.OR(Auxi.AX[3], Auxi.CX[3]);
                Auxi.CX[2] = ALU.OR(Auxi.AX[2], Auxi.CX[2]);
                Auxi.CX[1] = ALU.OR(Auxi.AX[1], Auxi.CX[1]);
            }
            else if ((Rega == ("AX")) && (Regb == ("DX")))
            {
                Auxi.DX[8] = ALU.OR(Auxi.AX[8], Auxi.DX[8]);
                Auxi.DX[7] = ALU.OR(Auxi.AX[7], Auxi.DX[7]);
                Auxi.DX[6] = ALU.OR(Auxi.AX[6], Auxi.DX[6]);
                Auxi.DX[5] = ALU.OR(Auxi.AX[5], Auxi.DX[5]);
                Auxi.DX[4] = ALU.OR(Auxi.AX[4], Auxi.DX[4]);
                Auxi.DX[3] = ALU.OR(Auxi.AX[3], Auxi.DX[3]);
                Auxi.DX[2] = ALU.OR(Auxi.AX[2], Auxi.DX[2]);
                Auxi.DX[1] = ALU.OR(Auxi.AX[1], Auxi.DX[1]);
            }
            else if ((Rega == ("BX")) && (Regb == ("AX")))
            {
                Auxi.AX[8] = ALU.OR(Auxi.BX[8], Auxi.AX[8]);
                Auxi.AX[7] = ALU.OR(Auxi.BX[7], Auxi.AX[7]);
                Auxi.AX[6] = ALU.OR(Auxi.BX[6], Auxi.AX[6]);
                Auxi.AX[5] = ALU.OR(Auxi.BX[5], Auxi.AX[5]);
                Auxi.AX[4] = ALU.OR(Auxi.BX[4], Auxi.AX[4]);
                Auxi.AX[3] = ALU.OR(Auxi.BX[3], Auxi.AX[3]);
                Auxi.AX[2] = ALU.OR(Auxi.BX[2], Auxi.AX[2]);
                Auxi.AX[1] = ALU.OR(Auxi.BX[1], Auxi.AX[1]);
            }
            else if ((Rega == ("BX")) && (Regb == ("BX")))
            {
                Auxi.BX[8] = ALU.OR(Auxi.BX[8], Auxi.BX[8]);
                Auxi.BX[7] = ALU.OR(Auxi.BX[7], Auxi.BX[7]);
                Auxi.BX[6] = ALU.OR(Auxi.BX[6], Auxi.BX[6]);
                Auxi.BX[5] = ALU.OR(Auxi.BX[5], Auxi.BX[5]);
                Auxi.BX[4] = ALU.OR(Auxi.BX[4], Auxi.BX[4]);
                Auxi.BX[3] = ALU.OR(Auxi.BX[3], Auxi.BX[3]);
                Auxi.BX[2] = ALU.OR(Auxi.BX[2], Auxi.BX[2]);
                Auxi.BX[1] = ALU.OR(Auxi.BX[1], Auxi.BX[1]);
            }
            else if ((Rega == ("BX")) && (Regb == ("CX")))
            {
                Auxi.CX[8] = ALU.OR(Auxi.BX[8], Auxi.CX[8]);
                Auxi.CX[7] = ALU.OR(Auxi.BX[7], Auxi.CX[7]);
                Auxi.CX[6] = ALU.OR(Auxi.BX[6], Auxi.CX[6]);
                Auxi.CX[5] = ALU.OR(Auxi.BX[5], Auxi.CX[5]);
                Auxi.CX[4] = ALU.OR(Auxi.BX[4], Auxi.CX[4]);
                Auxi.CX[3] = ALU.OR(Auxi.BX[3], Auxi.CX[3]);
                Auxi.CX[2] = ALU.OR(Auxi.BX[2], Auxi.CX[2]);
                Auxi.CX[1] = ALU.OR(Auxi.BX[1], Auxi.CX[1]);
            }
            else if ((Rega == ("BX")) && (Regb == ("DX")))
            {
                Auxi.DX[8] = ALU.OR(Auxi.BX[8], Auxi.DX[8]);
                Auxi.DX[7] = ALU.OR(Auxi.BX[7], Auxi.DX[7]);
                Auxi.DX[6] = ALU.OR(Auxi.BX[6], Auxi.DX[6]);
                Auxi.DX[5] = ALU.OR(Auxi.BX[5], Auxi.DX[5]);
                Auxi.DX[4] = ALU.OR(Auxi.BX[4], Auxi.DX[4]);
                Auxi.DX[3] = ALU.OR(Auxi.BX[3], Auxi.DX[3]);
                Auxi.DX[2] = ALU.OR(Auxi.BX[2], Auxi.DX[2]);
                Auxi.DX[1] = ALU.OR(Auxi.BX[1], Auxi.DX[1]);
            }
            else if ((Rega == ("CX")) && (Regb == ("AX")))
            {
                Auxi.AX[8] = ALU.OR(Auxi.CX[8], Auxi.AX[8]);
                Auxi.AX[7] = ALU.OR(Auxi.CX[7], Auxi.AX[7]);
                Auxi.AX[6] = ALU.OR(Auxi.CX[6], Auxi.AX[6]);
                Auxi.AX[5] = ALU.OR(Auxi.CX[5], Auxi.AX[5]);
                Auxi.AX[4] = ALU.OR(Auxi.CX[4], Auxi.AX[4]);
                Auxi.AX[3] = ALU.OR(Auxi.CX[3], Auxi.AX[3]);
                Auxi.AX[2] = ALU.OR(Auxi.CX[2], Auxi.AX[2]);
                Auxi.AX[1] = ALU.OR(Auxi.CX[1], Auxi.AX[1]);
            }
            else if ((Rega == ("CX")) && (Regb == ("BX")))
            {
                Auxi.BX[8] = ALU.OR(Auxi.CX[8], Auxi.BX[8]);
                Auxi.BX[7] = ALU.OR(Auxi.CX[7], Auxi.BX[7]);
                Auxi.BX[6] = ALU.OR(Auxi.CX[6], Auxi.BX[6]);
                Auxi.BX[5] = ALU.OR(Auxi.CX[5], Auxi.BX[5]);
                Auxi.BX[4] = ALU.OR(Auxi.CX[4], Auxi.BX[4]);
                Auxi.BX[3] = ALU.OR(Auxi.CX[3], Auxi.BX[3]);
                Auxi.BX[2] = ALU.OR(Auxi.CX[2], Auxi.BX[2]);
                Auxi.BX[1] = ALU.OR(Auxi.CX[1], Auxi.BX[1]);
            }
            else if ((Rega == ("CX")) && (Regb == ("CX")))
            {
                Auxi.CX[8] = ALU.OR(Auxi.CX[8], Auxi.CX[8]);
                Auxi.CX[7] = ALU.OR(Auxi.CX[7], Auxi.CX[7]);
                Auxi.CX[6] = ALU.OR(Auxi.CX[6], Auxi.CX[6]);
                Auxi.CX[5] = ALU.OR(Auxi.CX[5], Auxi.CX[5]);
                Auxi.CX[4] = ALU.OR(Auxi.CX[4], Auxi.CX[4]);
                Auxi.CX[3] = ALU.OR(Auxi.CX[3], Auxi.CX[3]);
                Auxi.CX[2] = ALU.OR(Auxi.CX[2], Auxi.CX[2]);
                Auxi.CX[1] = ALU.OR(Auxi.CX[1], Auxi.CX[1]);
            }
            else if ((Rega == ("CX")) && (Regb == ("DX")))
            {
                Auxi.DX[8] = ALU.OR(Auxi.CX[8], Auxi.DX[8]);
                Auxi.DX[7] = ALU.OR(Auxi.CX[7], Auxi.DX[7]);
                Auxi.DX[6] = ALU.OR(Auxi.CX[6], Auxi.DX[6]);
                Auxi.DX[5] = ALU.OR(Auxi.CX[5], Auxi.DX[5]);
                Auxi.DX[4] = ALU.OR(Auxi.CX[4], Auxi.DX[4]);
                Auxi.DX[3] = ALU.OR(Auxi.CX[3], Auxi.DX[3]);
                Auxi.DX[2] = ALU.OR(Auxi.CX[2], Auxi.DX[2]);
                Auxi.DX[1] = ALU.OR(Auxi.CX[1], Auxi.DX[1]);
            }
            else if ((Rega == ("DX")) && (Regb == ("AX")))
            {
                Auxi.AX[8] = ALU.OR(Auxi.DX[8], Auxi.AX[8]);
                Auxi.AX[7] = ALU.OR(Auxi.DX[7], Auxi.AX[7]);
                Auxi.AX[6] = ALU.OR(Auxi.DX[6], Auxi.AX[6]);
                Auxi.AX[5] = ALU.OR(Auxi.DX[5], Auxi.AX[5]);
                Auxi.AX[4] = ALU.OR(Auxi.DX[4], Auxi.AX[4]);
                Auxi.AX[3] = ALU.OR(Auxi.DX[3], Auxi.AX[3]);
                Auxi.AX[2] = ALU.OR(Auxi.DX[2], Auxi.AX[2]);
                Auxi.AX[1] = ALU.OR(Auxi.DX[1], Auxi.AX[1]);
            }
            else if ((Rega == ("DX")) && (Regb == ("BX")))
            {
                Auxi.BX[8] = ALU.OR(Auxi.DX[8], Auxi.BX[8]);
                Auxi.BX[7] = ALU.OR(Auxi.DX[7], Auxi.BX[7]);
                Auxi.BX[6] = ALU.OR(Auxi.DX[6], Auxi.BX[6]);
                Auxi.BX[5] = ALU.OR(Auxi.DX[5], Auxi.BX[5]);
                Auxi.BX[4] = ALU.OR(Auxi.DX[4], Auxi.BX[4]);
                Auxi.BX[3] = ALU.OR(Auxi.DX[3], Auxi.BX[3]);
                Auxi.BX[2] = ALU.OR(Auxi.DX[2], Auxi.BX[2]);
                Auxi.BX[1] = ALU.OR(Auxi.DX[1], Auxi.BX[1]);
            }
            else if ((Rega == ("DX")) && (Regb == ("CX")))
            {
                Auxi.CX[8] = ALU.OR(Auxi.DX[8], Auxi.CX[8]);
                Auxi.CX[7] = ALU.OR(Auxi.DX[7], Auxi.CX[7]);
                Auxi.CX[6] = ALU.OR(Auxi.DX[6], Auxi.CX[6]);
                Auxi.CX[5] = ALU.OR(Auxi.DX[5], Auxi.CX[5]);
                Auxi.CX[4] = ALU.OR(Auxi.DX[4], Auxi.CX[4]);
                Auxi.CX[3] = ALU.OR(Auxi.DX[3], Auxi.CX[3]);
                Auxi.CX[2] = ALU.OR(Auxi.DX[2], Auxi.CX[2]);
                Auxi.CX[1] = ALU.OR(Auxi.DX[1], Auxi.CX[1]);
            }
            else if ((Rega == ("DX")) && (Regb == ("DX")))
            {
                Auxi.DX[8] = ALU.OR(Auxi.DX[8], Auxi.DX[8]);
                Auxi.DX[7] = ALU.OR(Auxi.DX[7], Auxi.DX[7]);
                Auxi.DX[6] = ALU.OR(Auxi.DX[6], Auxi.DX[6]);
                Auxi.DX[5] = ALU.OR(Auxi.DX[5], Auxi.DX[5]);
                Auxi.DX[4] = ALU.OR(Auxi.DX[4], Auxi.DX[4]);
                Auxi.DX[3] = ALU.OR(Auxi.DX[3], Auxi.DX[3]);
                Auxi.DX[2] = ALU.OR(Auxi.DX[2], Auxi.DX[2]);
                Auxi.DX[1] = ALU.OR(Auxi.DX[1], Auxi.DX[1]);
            }
        }

        public void XORNoRegistro(string regdest2, int bajo1, int bajo2, int bajo3, int bajo4, int bajo5, int bajo6, int bajo7, int bajo8,
            int alto1, int alto2, int alto3, int alto4, int alto5, int alto6, int alto7, int alto8)
        {
            if (regdest2 == "AX")
            {
                Auxi.AX[8] = ALU.XOR(alto8, bajo8);
                Auxi.AX[7] = ALU.XOR(alto7, bajo7);
                Auxi.AX[6] = ALU.XOR(alto6, bajo6);
                Auxi.AX[5] = ALU.XOR(alto5, bajo5);
                Auxi.AX[4] = ALU.XOR(alto4, bajo4);
                Auxi.AX[3] = ALU.XOR(alto3, bajo3);
                Auxi.AX[2] = ALU.XOR(alto2, bajo2);
                Auxi.AX[1] = ALU.XOR(alto1, bajo1);
            }
            else if (regdest2 == "BX")
            {
                Auxi.BX[8] = ALU.XOR(alto8, bajo8);
                Auxi.BX[7] = ALU.XOR(alto7, bajo7);
                Auxi.BX[6] = ALU.XOR(alto6, bajo6);
                Auxi.BX[5] = ALU.XOR(alto5, bajo5);
                Auxi.BX[4] = ALU.XOR(alto4, bajo4);
                Auxi.BX[3] = ALU.XOR(alto3, bajo3);
                Auxi.BX[2] = ALU.XOR(alto2, bajo2);
                Auxi.BX[1] = ALU.XOR(alto1, bajo1);
            }
            else if (regdest2 == "CX")
            {
                Auxi.CX[8] = ALU.XOR(alto8, bajo8);
                Auxi.CX[7] = ALU.XOR(alto7, bajo7);
                Auxi.CX[6] = ALU.XOR(alto6, bajo6);
                Auxi.CX[5] = ALU.XOR(alto5, bajo5);
                Auxi.CX[4] = ALU.XOR(alto4, bajo4);
                Auxi.CX[3] = ALU.XOR(alto3, bajo3);
                Auxi.CX[2] = ALU.XOR(alto2, bajo2);
                Auxi.CX[1] = ALU.XOR(alto1, bajo1);
            }
            else if (regdest2 == "DX")
            {
                Auxi.DX[8] = ALU.XOR(alto8, bajo8);
                Auxi.DX[7] = ALU.XOR(alto7, bajo7);
                Auxi.DX[6] = ALU.XOR(alto6, bajo6);
                Auxi.DX[5] = ALU.XOR(alto5, bajo5);
                Auxi.DX[4] = ALU.XOR(alto4, bajo4);
                Auxi.DX[3] = ALU.XOR(alto3, bajo3);
                Auxi.DX[2] = ALU.XOR(alto2, bajo2);
                Auxi.DX[1] = ALU.XOR(alto1, bajo1);
            }
        }

        public void XORRegistro(string Rega, string Regb)
        {
            if ((Rega == ("AX")) && (Regb == ("AX"))) //1=7, 1=6, 1=5, 1=4, etc.
            {
                Auxi.AX[8] = ALU.XOR(Auxi.AX[8], Auxi.AX[8]);
                Auxi.AX[7] = ALU.XOR(Auxi.AX[7], Auxi.AX[7]);
                Auxi.AX[6] = ALU.XOR(Auxi.AX[6], Auxi.AX[6]);
                Auxi.AX[5] = ALU.XOR(Auxi.AX[5], Auxi.AX[5]);
                Auxi.AX[4] = ALU.XOR(Auxi.AX[4], Auxi.AX[4]);
                Auxi.AX[3] = ALU.XOR(Auxi.AX[3], Auxi.AX[3]);
                Auxi.AX[2] = ALU.XOR(Auxi.AX[2], Auxi.AX[2]);
                Auxi.AX[1] = ALU.XOR(Auxi.AX[1], Auxi.AX[1]);
            }
            else if ((Rega == ("AX")) && (Regb == ("BX")))
            {
                Auxi.BX[8] = ALU.XOR(Auxi.AX[8], Auxi.BX[8]);
                Auxi.BX[7] = ALU.XOR(Auxi.AX[7], Auxi.BX[7]);
                Auxi.BX[6] = ALU.XOR(Auxi.AX[6], Auxi.BX[6]);
                Auxi.BX[5] = ALU.XOR(Auxi.AX[5], Auxi.BX[5]);
                Auxi.BX[4] = ALU.XOR(Auxi.AX[4], Auxi.BX[4]);
                Auxi.BX[3] = ALU.XOR(Auxi.AX[3], Auxi.BX[3]);
                Auxi.BX[2] = ALU.XOR(Auxi.AX[2], Auxi.BX[2]);
                Auxi.BX[1] = ALU.XOR(Auxi.AX[1], Auxi.BX[1]);
            }
            else if ((Rega == ("AX")) && (Regb == ("CX")))
            {
                Auxi.CX[8] = ALU.XOR(Auxi.AX[8], Auxi.CX[8]);
                Auxi.CX[7] = ALU.XOR(Auxi.AX[7], Auxi.CX[7]);
                Auxi.CX[6] = ALU.XOR(Auxi.AX[6], Auxi.CX[6]);
                Auxi.CX[5] = ALU.XOR(Auxi.AX[5], Auxi.CX[5]);
                Auxi.CX[4] = ALU.XOR(Auxi.AX[4], Auxi.CX[4]);
                Auxi.CX[3] = ALU.XOR(Auxi.AX[3], Auxi.CX[3]);
                Auxi.CX[2] = ALU.XOR(Auxi.AX[2], Auxi.CX[2]);
                Auxi.CX[1] = ALU.XOR(Auxi.AX[1], Auxi.CX[1]);
            }
            else if ((Rega == ("AX")) && (Regb == ("DX")))
            {
                Auxi.DX[8] = ALU.XOR(Auxi.AX[8], Auxi.DX[8]);
                Auxi.DX[7] = ALU.XOR(Auxi.AX[7], Auxi.DX[7]);
                Auxi.DX[6] = ALU.XOR(Auxi.AX[6], Auxi.DX[6]);
                Auxi.DX[5] = ALU.XOR(Auxi.AX[5], Auxi.DX[5]);
                Auxi.DX[4] = ALU.XOR(Auxi.AX[4], Auxi.DX[4]);
                Auxi.DX[3] = ALU.XOR(Auxi.AX[3], Auxi.DX[3]);
                Auxi.DX[2] = ALU.XOR(Auxi.AX[2], Auxi.DX[2]);
                Auxi.DX[1] = ALU.XOR(Auxi.AX[1], Auxi.DX[1]);
            }
            else if ((Rega == ("BX")) && (Regb == ("AX")))
            {
                Auxi.AX[8] = ALU.XOR(Auxi.BX[8], Auxi.AX[8]);
                Auxi.AX[7] = ALU.XOR(Auxi.BX[7], Auxi.AX[7]);
                Auxi.AX[6] = ALU.XOR(Auxi.BX[6], Auxi.AX[6]);
                Auxi.AX[5] = ALU.XOR(Auxi.BX[5], Auxi.AX[5]);
                Auxi.AX[4] = ALU.XOR(Auxi.BX[4], Auxi.AX[4]);
                Auxi.AX[3] = ALU.XOR(Auxi.BX[3], Auxi.AX[3]);
                Auxi.AX[2] = ALU.XOR(Auxi.BX[2], Auxi.AX[2]);
                Auxi.AX[1] = ALU.XOR(Auxi.BX[1], Auxi.AX[1]);
            }
            else if ((Rega == ("BX")) && (Regb == ("BX")))
            {
                Auxi.BX[8] = ALU.XOR(Auxi.BX[8], Auxi.BX[8]);
                Auxi.BX[7] = ALU.XOR(Auxi.BX[7], Auxi.BX[7]);
                Auxi.BX[6] = ALU.XOR(Auxi.BX[6], Auxi.BX[6]);
                Auxi.BX[5] = ALU.XOR(Auxi.BX[5], Auxi.BX[5]);
                Auxi.BX[4] = ALU.XOR(Auxi.BX[4], Auxi.BX[4]);
                Auxi.BX[3] = ALU.XOR(Auxi.BX[3], Auxi.BX[3]);
                Auxi.BX[2] = ALU.XOR(Auxi.BX[2], Auxi.BX[2]);
                Auxi.BX[1] = ALU.XOR(Auxi.BX[1], Auxi.BX[1]);
            }
            else if ((Rega == ("BX")) && (Regb == ("CX")))
            {
                Auxi.CX[8] = ALU.XOR(Auxi.BX[8], Auxi.CX[8]);
                Auxi.CX[7] = ALU.XOR(Auxi.BX[7], Auxi.CX[7]);
                Auxi.CX[6] = ALU.XOR(Auxi.BX[6], Auxi.CX[6]);
                Auxi.CX[5] = ALU.XOR(Auxi.BX[5], Auxi.CX[5]);
                Auxi.CX[4] = ALU.XOR(Auxi.BX[4], Auxi.CX[4]);
                Auxi.CX[3] = ALU.XOR(Auxi.BX[3], Auxi.CX[3]);
                Auxi.CX[2] = ALU.XOR(Auxi.BX[2], Auxi.CX[2]);
                Auxi.CX[1] = ALU.XOR(Auxi.BX[1], Auxi.CX[1]);
            }
            else if ((Rega == ("BX")) && (Regb == ("DX")))
            {
                Auxi.DX[8] = ALU.XOR(Auxi.BX[8], Auxi.DX[8]);
                Auxi.DX[7] = ALU.XOR(Auxi.BX[7], Auxi.DX[7]);
                Auxi.DX[6] = ALU.XOR(Auxi.BX[6], Auxi.DX[6]);
                Auxi.DX[5] = ALU.XOR(Auxi.BX[5], Auxi.DX[5]);
                Auxi.DX[4] = ALU.XOR(Auxi.BX[4], Auxi.DX[4]);
                Auxi.DX[3] = ALU.XOR(Auxi.BX[3], Auxi.DX[3]);
                Auxi.DX[2] = ALU.XOR(Auxi.BX[2], Auxi.DX[2]);
                Auxi.DX[1] = ALU.XOR(Auxi.BX[1], Auxi.DX[1]);
            }
            else if ((Rega == ("CX")) && (Regb == ("AX")))
            {
                Auxi.AX[8] = ALU.XOR(Auxi.CX[8], Auxi.AX[8]);
                Auxi.AX[7] = ALU.XOR(Auxi.CX[7], Auxi.AX[7]);
                Auxi.AX[6] = ALU.XOR(Auxi.CX[6], Auxi.AX[6]);
                Auxi.AX[5] = ALU.XOR(Auxi.CX[5], Auxi.AX[5]);
                Auxi.AX[4] = ALU.XOR(Auxi.CX[4], Auxi.AX[4]);
                Auxi.AX[3] = ALU.XOR(Auxi.CX[3], Auxi.AX[3]);
                Auxi.AX[2] = ALU.XOR(Auxi.CX[2], Auxi.AX[2]);
                Auxi.AX[1] = ALU.XOR(Auxi.CX[1], Auxi.AX[1]);
            }
            else if ((Rega == ("CX")) && (Regb == ("BX")))
            {
                Auxi.BX[8] = ALU.XOR(Auxi.CX[8], Auxi.BX[8]);
                Auxi.BX[7] = ALU.XOR(Auxi.CX[7], Auxi.BX[7]);
                Auxi.BX[6] = ALU.XOR(Auxi.CX[6], Auxi.BX[6]);
                Auxi.BX[5] = ALU.XOR(Auxi.CX[5], Auxi.BX[5]);
                Auxi.BX[4] = ALU.XOR(Auxi.CX[4], Auxi.BX[4]);
                Auxi.BX[3] = ALU.XOR(Auxi.CX[3], Auxi.BX[3]);
                Auxi.BX[2] = ALU.XOR(Auxi.CX[2], Auxi.BX[2]);
                Auxi.BX[1] = ALU.XOR(Auxi.CX[1], Auxi.BX[1]);
            }
            else if ((Rega == ("CX")) && (Regb == ("CX")))
            {
                Auxi.CX[8] = ALU.XOR(Auxi.CX[8], Auxi.CX[8]);
                Auxi.CX[7] = ALU.XOR(Auxi.CX[7], Auxi.CX[7]);
                Auxi.CX[6] = ALU.XOR(Auxi.CX[6], Auxi.CX[6]);
                Auxi.CX[5] = ALU.XOR(Auxi.CX[5], Auxi.CX[5]);
                Auxi.CX[4] = ALU.XOR(Auxi.CX[4], Auxi.CX[4]);
                Auxi.CX[3] = ALU.XOR(Auxi.CX[3], Auxi.CX[3]);
                Auxi.CX[2] = ALU.XOR(Auxi.CX[2], Auxi.CX[2]);
                Auxi.CX[1] = ALU.XOR(Auxi.CX[1], Auxi.CX[1]);
            }
            else if ((Rega == ("CX")) && (Regb == ("DX")))
            {
                Auxi.DX[8] = ALU.XOR(Auxi.CX[8], Auxi.DX[8]);
                Auxi.DX[7] = ALU.XOR(Auxi.CX[7], Auxi.DX[7]);
                Auxi.DX[6] = ALU.XOR(Auxi.CX[6], Auxi.DX[6]);
                Auxi.DX[5] = ALU.XOR(Auxi.CX[5], Auxi.DX[5]);
                Auxi.DX[4] = ALU.XOR(Auxi.CX[4], Auxi.DX[4]);
                Auxi.DX[3] = ALU.XOR(Auxi.CX[3], Auxi.DX[3]);
                Auxi.DX[2] = ALU.XOR(Auxi.CX[2], Auxi.DX[2]);
                Auxi.DX[1] = ALU.XOR(Auxi.CX[1], Auxi.DX[1]);
            }
            else if ((Rega == ("DX")) && (Regb == ("AX")))
            {
                Auxi.AX[8] = ALU.XOR(Auxi.DX[8], Auxi.AX[8]);
                Auxi.AX[7] = ALU.XOR(Auxi.DX[7], Auxi.AX[7]);
                Auxi.AX[6] = ALU.XOR(Auxi.DX[6], Auxi.AX[6]);
                Auxi.AX[5] = ALU.XOR(Auxi.DX[5], Auxi.AX[5]);
                Auxi.AX[4] = ALU.XOR(Auxi.DX[4], Auxi.AX[4]);
                Auxi.AX[3] = ALU.XOR(Auxi.DX[3], Auxi.AX[3]);
                Auxi.AX[2] = ALU.XOR(Auxi.DX[2], Auxi.AX[2]);
                Auxi.AX[1] = ALU.XOR(Auxi.DX[1], Auxi.AX[1]);
            }
            else if ((Rega == ("DX")) && (Regb == ("BX")))
            {
                Auxi.BX[8] = ALU.XOR(Auxi.DX[8], Auxi.BX[8]);
                Auxi.BX[7] = ALU.XOR(Auxi.DX[7], Auxi.BX[7]);
                Auxi.BX[6] = ALU.XOR(Auxi.DX[6], Auxi.BX[6]);
                Auxi.BX[5] = ALU.XOR(Auxi.DX[5], Auxi.BX[5]);
                Auxi.BX[4] = ALU.XOR(Auxi.DX[4], Auxi.BX[4]);
                Auxi.BX[3] = ALU.XOR(Auxi.DX[3], Auxi.BX[3]);
                Auxi.BX[2] = ALU.XOR(Auxi.DX[2], Auxi.BX[2]);
                Auxi.BX[1] = ALU.XOR(Auxi.DX[1], Auxi.BX[1]);
            }
            else if ((Rega == ("DX")) && (Regb == ("CX")))
            {
                Auxi.CX[8] = ALU.XOR(Auxi.DX[8], Auxi.CX[8]);
                Auxi.CX[7] = ALU.XOR(Auxi.DX[7], Auxi.CX[7]);
                Auxi.CX[6] = ALU.XOR(Auxi.DX[6], Auxi.CX[6]);
                Auxi.CX[5] = ALU.XOR(Auxi.DX[5], Auxi.CX[5]);
                Auxi.CX[4] = ALU.XOR(Auxi.DX[4], Auxi.CX[4]);
                Auxi.CX[3] = ALU.XOR(Auxi.DX[3], Auxi.CX[3]);
                Auxi.CX[2] = ALU.XOR(Auxi.DX[2], Auxi.CX[2]);
                Auxi.CX[1] = ALU.XOR(Auxi.DX[1], Auxi.CX[1]);
            }
            else if ((Rega == ("DX")) && (Regb == ("DX")))
            {
                Auxi.DX[8] = ALU.XOR(Auxi.DX[8], Auxi.DX[8]);
                Auxi.DX[7] = ALU.XOR(Auxi.DX[7], Auxi.DX[7]);
                Auxi.DX[6] = ALU.XOR(Auxi.DX[6], Auxi.DX[6]);
                Auxi.DX[5] = ALU.XOR(Auxi.DX[5], Auxi.DX[5]);
                Auxi.DX[4] = ALU.XOR(Auxi.DX[4], Auxi.DX[4]);
                Auxi.DX[3] = ALU.XOR(Auxi.DX[3], Auxi.DX[3]);
                Auxi.DX[2] = ALU.XOR(Auxi.DX[2], Auxi.DX[2]);
                Auxi.DX[1] = ALU.XOR(Auxi.DX[1], Auxi.DX[1]);
            }
        }

        public void XNORNoRegistro(string regdest2, int bajo1, int bajo2, int bajo3, int bajo4, int bajo5, int bajo6, int bajo7, int bajo8,
            int alto1, int alto2, int alto3, int alto4, int alto5, int alto6, int alto7, int alto8)
        {
            if (regdest2 == "AX")
            {
                Auxi.AX[8] = ALU.XNOR(alto8, bajo8);
                Auxi.AX[7] = ALU.XNOR(alto7, bajo7);
                Auxi.AX[6] = ALU.XNOR(alto6, bajo6);
                Auxi.AX[5] = ALU.XNOR(alto5, bajo5);
                Auxi.AX[4] = ALU.XNOR(alto4, bajo4);
                Auxi.AX[3] = ALU.XNOR(alto3, bajo3);
                Auxi.AX[2] = ALU.XNOR(alto2, bajo2);
                Auxi.AX[1] = ALU.XNOR(alto1, bajo1);
            }
            else if (regdest2 == "BX")
            {
                Auxi.BX[8] = ALU.XNOR(alto8, bajo8);
                Auxi.BX[7] = ALU.XNOR(alto7, bajo7);
                Auxi.BX[6] = ALU.XNOR(alto6, bajo6);
                Auxi.BX[5] = ALU.XNOR(alto5, bajo5);
                Auxi.BX[4] = ALU.XNOR(alto4, bajo4);
                Auxi.BX[3] = ALU.XNOR(alto3, bajo3);
                Auxi.BX[2] = ALU.XNOR(alto2, bajo2);
                Auxi.BX[1] = ALU.XNOR(alto1, bajo1);
            }
            else if (regdest2 == "CX")
            {
                Auxi.CX[8] = ALU.XNOR(alto8, bajo8);
                Auxi.CX[7] = ALU.XNOR(alto7, bajo7);
                Auxi.CX[6] = ALU.XNOR(alto6, bajo6);
                Auxi.CX[5] = ALU.XNOR(alto5, bajo5);
                Auxi.CX[4] = ALU.XNOR(alto4, bajo4);
                Auxi.CX[3] = ALU.XNOR(alto3, bajo3);
                Auxi.CX[2] = ALU.XNOR(alto2, bajo2);
                Auxi.CX[1] = ALU.XNOR(alto1, bajo1);
            }
            else if (regdest2 == "DX")
            {
                Auxi.DX[8] = ALU.XNOR(alto8, bajo8);
                Auxi.DX[7] = ALU.XNOR(alto7, bajo7);
                Auxi.DX[6] = ALU.XNOR(alto6, bajo6);
                Auxi.DX[5] = ALU.XNOR(alto5, bajo5);
                Auxi.DX[4] = ALU.XNOR(alto4, bajo4);
                Auxi.DX[3] = ALU.XNOR(alto3, bajo3);
                Auxi.DX[2] = ALU.XNOR(alto2, bajo2);
                Auxi.DX[1] = ALU.XNOR(alto1, bajo1);
            }
        }

        public void XNORRegistro(string Rega, string Regb)
        {
            if ((Rega == ("AX")) && (Regb == ("AX"))) //1=7, 1=6, 1=5, 1=4, etc.
            {
                Auxi.AX[8] = ALU.XNOR(Auxi.AX[8], Auxi.AX[8]);
                Auxi.AX[7] = ALU.XNOR(Auxi.AX[7], Auxi.AX[7]);
                Auxi.AX[6] = ALU.XNOR(Auxi.AX[6], Auxi.AX[6]);
                Auxi.AX[5] = ALU.XNOR(Auxi.AX[5], Auxi.AX[5]);
                Auxi.AX[4] = ALU.XNOR(Auxi.AX[4], Auxi.AX[4]);
                Auxi.AX[3] = ALU.XNOR(Auxi.AX[3], Auxi.AX[3]);
                Auxi.AX[2] = ALU.XNOR(Auxi.AX[2], Auxi.AX[2]);
                Auxi.AX[1] = ALU.XNOR(Auxi.AX[1], Auxi.AX[1]);
            }
            else if ((Rega == ("AX")) && (Regb == ("BX")))
            {
                Auxi.BX[8] = ALU.XNOR(Auxi.AX[8], Auxi.BX[8]);
                Auxi.BX[7] = ALU.XNOR(Auxi.AX[7], Auxi.BX[7]);
                Auxi.BX[6] = ALU.XNOR(Auxi.AX[6], Auxi.BX[6]);
                Auxi.BX[5] = ALU.XNOR(Auxi.AX[5], Auxi.BX[5]);
                Auxi.BX[4] = ALU.XNOR(Auxi.AX[4], Auxi.BX[4]);
                Auxi.BX[3] = ALU.XNOR(Auxi.AX[3], Auxi.BX[3]);
                Auxi.BX[2] = ALU.XNOR(Auxi.AX[2], Auxi.BX[2]);
                Auxi.BX[1] = ALU.XNOR(Auxi.AX[1], Auxi.BX[1]);
            }
            else if ((Rega == ("AX")) && (Regb == ("CX")))
            {
                Auxi.CX[8] = ALU.XNOR(Auxi.AX[8], Auxi.CX[8]);
                Auxi.CX[7] = ALU.XNOR(Auxi.AX[7], Auxi.CX[7]);
                Auxi.CX[6] = ALU.XNOR(Auxi.AX[6], Auxi.CX[6]);
                Auxi.CX[5] = ALU.XNOR(Auxi.AX[5], Auxi.CX[5]);
                Auxi.CX[4] = ALU.XNOR(Auxi.AX[4], Auxi.CX[4]);
                Auxi.CX[3] = ALU.XNOR(Auxi.AX[3], Auxi.CX[3]);
                Auxi.CX[2] = ALU.XNOR(Auxi.AX[2], Auxi.CX[2]);
                Auxi.CX[1] = ALU.XNOR(Auxi.AX[1], Auxi.CX[1]);
            }
            else if ((Rega == ("AX")) && (Regb == ("DX")))
            {
                Auxi.DX[8] = ALU.XNOR(Auxi.AX[8], Auxi.DX[8]);
                Auxi.DX[7] = ALU.XNOR(Auxi.AX[7], Auxi.DX[7]);
                Auxi.DX[6] = ALU.XNOR(Auxi.AX[6], Auxi.DX[6]);
                Auxi.DX[5] = ALU.XNOR(Auxi.AX[5], Auxi.DX[5]);
                Auxi.DX[4] = ALU.XNOR(Auxi.AX[4], Auxi.DX[4]);
                Auxi.DX[3] = ALU.XNOR(Auxi.AX[3], Auxi.DX[3]);
                Auxi.DX[2] = ALU.XNOR(Auxi.AX[2], Auxi.DX[2]);
                Auxi.DX[1] = ALU.XNOR(Auxi.AX[1], Auxi.DX[1]);
            }
            else if ((Rega == ("BX")) && (Regb == ("AX")))
            {
                Auxi.AX[8] = ALU.XNOR(Auxi.BX[8], Auxi.AX[8]);
                Auxi.AX[7] = ALU.XNOR(Auxi.BX[7], Auxi.AX[7]);
                Auxi.AX[6] = ALU.XNOR(Auxi.BX[6], Auxi.AX[6]);
                Auxi.AX[5] = ALU.XNOR(Auxi.BX[5], Auxi.AX[5]);
                Auxi.AX[4] = ALU.XNOR(Auxi.BX[4], Auxi.AX[4]);
                Auxi.AX[3] = ALU.XNOR(Auxi.BX[3], Auxi.AX[3]);
                Auxi.AX[2] = ALU.XNOR(Auxi.BX[2], Auxi.AX[2]);
                Auxi.AX[1] = ALU.XNOR(Auxi.BX[1], Auxi.AX[1]);
            }
            else if ((Rega == ("BX")) && (Regb == ("BX")))
            {
                Auxi.BX[8] = ALU.XNOR(Auxi.BX[8], Auxi.BX[8]);
                Auxi.BX[7] = ALU.XNOR(Auxi.BX[7], Auxi.BX[7]);
                Auxi.BX[6] = ALU.XNOR(Auxi.BX[6], Auxi.BX[6]);
                Auxi.BX[5] = ALU.XNOR(Auxi.BX[5], Auxi.BX[5]);
                Auxi.BX[4] = ALU.XNOR(Auxi.BX[4], Auxi.BX[4]);
                Auxi.BX[3] = ALU.XNOR(Auxi.BX[3], Auxi.BX[3]);
                Auxi.BX[2] = ALU.XNOR(Auxi.BX[2], Auxi.BX[2]);
                Auxi.BX[1] = ALU.XNOR(Auxi.BX[1], Auxi.BX[1]);
            }
            else if ((Rega == ("BX")) && (Regb == ("CX")))
            {
                Auxi.CX[8] = ALU.XNOR(Auxi.BX[8], Auxi.CX[8]);
                Auxi.CX[7] = ALU.XNOR(Auxi.BX[7], Auxi.CX[7]);
                Auxi.CX[6] = ALU.XNOR(Auxi.BX[6], Auxi.CX[6]);
                Auxi.CX[5] = ALU.XNOR(Auxi.BX[5], Auxi.CX[5]);
                Auxi.CX[4] = ALU.XNOR(Auxi.BX[4], Auxi.CX[4]);
                Auxi.CX[3] = ALU.XNOR(Auxi.BX[3], Auxi.CX[3]);
                Auxi.CX[2] = ALU.XNOR(Auxi.BX[2], Auxi.CX[2]);
                Auxi.CX[1] = ALU.XNOR(Auxi.BX[1], Auxi.CX[1]);
            }
            else if ((Rega == ("BX")) && (Regb == ("DX")))
            {
                Auxi.DX[8] = ALU.XNOR(Auxi.BX[8], Auxi.DX[8]);
                Auxi.DX[7] = ALU.XNOR(Auxi.BX[7], Auxi.DX[7]);
                Auxi.DX[6] = ALU.XNOR(Auxi.BX[6], Auxi.DX[6]);
                Auxi.DX[5] = ALU.XNOR(Auxi.BX[5], Auxi.DX[5]);
                Auxi.DX[4] = ALU.XNOR(Auxi.BX[4], Auxi.DX[4]);
                Auxi.DX[3] = ALU.XNOR(Auxi.BX[3], Auxi.DX[3]);
                Auxi.DX[2] = ALU.XNOR(Auxi.BX[2], Auxi.DX[2]);
                Auxi.DX[1] = ALU.XNOR(Auxi.BX[1], Auxi.DX[1]);
            }
            else if ((Rega == ("CX")) && (Regb == ("AX")))
            {
                Auxi.AX[8] = ALU.XNOR(Auxi.CX[8], Auxi.AX[8]);
                Auxi.AX[7] = ALU.XNOR(Auxi.CX[7], Auxi.AX[7]);
                Auxi.AX[6] = ALU.XNOR(Auxi.CX[6], Auxi.AX[6]);
                Auxi.AX[5] = ALU.XNOR(Auxi.CX[5], Auxi.AX[5]);
                Auxi.AX[4] = ALU.XNOR(Auxi.CX[4], Auxi.AX[4]);
                Auxi.AX[3] = ALU.XNOR(Auxi.CX[3], Auxi.AX[3]);
                Auxi.AX[2] = ALU.XNOR(Auxi.CX[2], Auxi.AX[2]);
                Auxi.AX[1] = ALU.XNOR(Auxi.CX[1], Auxi.AX[1]);
            }
            else if ((Rega == ("CX")) && (Regb == ("BX")))
            {
                Auxi.BX[8] = ALU.XNOR(Auxi.CX[8], Auxi.BX[8]);
                Auxi.BX[7] = ALU.XNOR(Auxi.CX[7], Auxi.BX[7]);
                Auxi.BX[6] = ALU.XNOR(Auxi.CX[6], Auxi.BX[6]);
                Auxi.BX[5] = ALU.XNOR(Auxi.CX[5], Auxi.BX[5]);
                Auxi.BX[4] = ALU.XNOR(Auxi.CX[4], Auxi.BX[4]);
                Auxi.BX[3] = ALU.XNOR(Auxi.CX[3], Auxi.BX[3]);
                Auxi.BX[2] = ALU.XNOR(Auxi.CX[2], Auxi.BX[2]);
                Auxi.BX[1] = ALU.XNOR(Auxi.CX[1], Auxi.BX[1]);
            }
            else if ((Rega == ("CX")) && (Regb == ("CX")))
            {
                Auxi.CX[8] = ALU.XNOR(Auxi.CX[8], Auxi.CX[8]);
                Auxi.CX[7] = ALU.XNOR(Auxi.CX[7], Auxi.CX[7]);
                Auxi.CX[6] = ALU.XNOR(Auxi.CX[6], Auxi.CX[6]);
                Auxi.CX[5] = ALU.XNOR(Auxi.CX[5], Auxi.CX[5]);
                Auxi.CX[4] = ALU.XNOR(Auxi.CX[4], Auxi.CX[4]);
                Auxi.CX[3] = ALU.XNOR(Auxi.CX[3], Auxi.CX[3]);
                Auxi.CX[2] = ALU.XNOR(Auxi.CX[2], Auxi.CX[2]);
                Auxi.CX[1] = ALU.XNOR(Auxi.CX[1], Auxi.CX[1]);
            }
            else if ((Rega == ("CX")) && (Regb == ("DX")))
            {
                Auxi.DX[8] = ALU.XNOR(Auxi.CX[8], Auxi.DX[8]);
                Auxi.DX[7] = ALU.XNOR(Auxi.CX[7], Auxi.DX[7]);
                Auxi.DX[6] = ALU.XNOR(Auxi.CX[6], Auxi.DX[6]);
                Auxi.DX[5] = ALU.XNOR(Auxi.CX[5], Auxi.DX[5]);
                Auxi.DX[4] = ALU.XNOR(Auxi.CX[4], Auxi.DX[4]);
                Auxi.DX[3] = ALU.XNOR(Auxi.CX[3], Auxi.DX[3]);
                Auxi.DX[2] = ALU.XNOR(Auxi.CX[2], Auxi.DX[2]);
                Auxi.DX[1] = ALU.XNOR(Auxi.CX[1], Auxi.DX[1]);
            }
            else if ((Rega == ("DX")) && (Regb == ("AX")))
            {
                Auxi.AX[8] = ALU.XNOR(Auxi.DX[8], Auxi.AX[8]);
                Auxi.AX[7] = ALU.XNOR(Auxi.DX[7], Auxi.AX[7]);
                Auxi.AX[6] = ALU.XNOR(Auxi.DX[6], Auxi.AX[6]);
                Auxi.AX[5] = ALU.XNOR(Auxi.DX[5], Auxi.AX[5]);
                Auxi.AX[4] = ALU.XNOR(Auxi.DX[4], Auxi.AX[4]);
                Auxi.AX[3] = ALU.XNOR(Auxi.DX[3], Auxi.AX[3]);
                Auxi.AX[2] = ALU.XNOR(Auxi.DX[2], Auxi.AX[2]);
                Auxi.AX[1] = ALU.XNOR(Auxi.DX[1], Auxi.AX[1]);
            }
            else if ((Rega == ("DX")) && (Regb == ("BX")))
            {
                Auxi.BX[8] = ALU.XNOR(Auxi.DX[8], Auxi.BX[8]);
                Auxi.BX[7] = ALU.XNOR(Auxi.DX[7], Auxi.BX[7]);
                Auxi.BX[6] = ALU.XNOR(Auxi.DX[6], Auxi.BX[6]);
                Auxi.BX[5] = ALU.XNOR(Auxi.DX[5], Auxi.BX[5]);
                Auxi.BX[4] = ALU.XNOR(Auxi.DX[4], Auxi.BX[4]);
                Auxi.BX[3] = ALU.XNOR(Auxi.DX[3], Auxi.BX[3]);
                Auxi.BX[2] = ALU.XNOR(Auxi.DX[2], Auxi.BX[2]);
                Auxi.BX[1] = ALU.XNOR(Auxi.DX[1], Auxi.BX[1]);
            }
            else if ((Rega == ("DX")) && (Regb == ("CX")))
            {
                Auxi.CX[8] = ALU.XNOR(Auxi.DX[8], Auxi.CX[8]);
                Auxi.CX[7] = ALU.XNOR(Auxi.DX[7], Auxi.CX[7]);
                Auxi.CX[6] = ALU.XNOR(Auxi.DX[6], Auxi.CX[6]);
                Auxi.CX[5] = ALU.XNOR(Auxi.DX[5], Auxi.CX[5]);
                Auxi.CX[4] = ALU.XNOR(Auxi.DX[4], Auxi.CX[4]);
                Auxi.CX[3] = ALU.XNOR(Auxi.DX[3], Auxi.CX[3]);
                Auxi.CX[2] = ALU.XNOR(Auxi.DX[2], Auxi.CX[2]);
                Auxi.CX[1] = ALU.XNOR(Auxi.DX[1], Auxi.CX[1]);
            }
            else if ((Rega == ("DX")) && (Regb == ("DX")))
            {
                Auxi.DX[8] = ALU.XNOR(Auxi.DX[8], Auxi.DX[8]);
                Auxi.DX[7] = ALU.XNOR(Auxi.DX[7], Auxi.DX[7]);
                Auxi.DX[6] = ALU.XNOR(Auxi.DX[6], Auxi.DX[6]);
                Auxi.DX[5] = ALU.XNOR(Auxi.DX[5], Auxi.DX[5]);
                Auxi.DX[4] = ALU.XNOR(Auxi.DX[4], Auxi.DX[4]);
                Auxi.DX[3] = ALU.XNOR(Auxi.DX[3], Auxi.DX[3]);
                Auxi.DX[2] = ALU.XNOR(Auxi.DX[2], Auxi.DX[2]);
                Auxi.DX[1] = ALU.XNOR(Auxi.DX[1], Auxi.DX[1]);
            }
        }

        public void NOTNoRegistro(string regdest2, int bajo1, int bajo2, int bajo3, int bajo4, int bajo5, int bajo6, int bajo7, int bajo8,
            int alto1, int alto2, int alto3, int alto4, int alto5, int alto6, int alto7, int alto8)
        {
            if (regdest2 == "AX")
            {
                Auxi.AX[8] = ALU.NOT(bajo8);
                Auxi.AX[7] = ALU.NOT(bajo7);
                Auxi.AX[6] = ALU.NOT(bajo6);
                Auxi.AX[5] = ALU.NOT(bajo5);
                Auxi.AX[4] = ALU.NOT(bajo4);
                Auxi.AX[3] = ALU.NOT(bajo3);
                Auxi.AX[2] = ALU.NOT(bajo2);
                Auxi.AX[1] = ALU.NOT(bajo1);
            }
            else if (regdest2 == "BX")
            {
                Auxi.BX[8] = ALU.NOT(bajo8);
                Auxi.BX[7] = ALU.NOT(bajo7);
                Auxi.BX[6] = ALU.NOT(bajo6);
                Auxi.BX[5] = ALU.NOT(bajo5);
                Auxi.BX[4] = ALU.NOT(bajo4);
                Auxi.BX[3] = ALU.NOT(bajo3);
                Auxi.BX[2] = ALU.NOT(bajo2);
                Auxi.BX[1] = ALU.NOT(bajo1);
            }
            else if (regdest2 == "CX")
            {
                Auxi.CX[8] = ALU.NOT(bajo8);
                Auxi.CX[7] = ALU.NOT(bajo7);
                Auxi.CX[6] = ALU.NOT(bajo6);
                Auxi.CX[5] = ALU.NOT(bajo5);
                Auxi.CX[4] = ALU.NOT(bajo4);
                Auxi.CX[3] = ALU.NOT(bajo3);
                Auxi.CX[2] = ALU.NOT(bajo2);
                Auxi.CX[1] = ALU.NOT(bajo1);
            }
            else if (regdest2 == "DX")
            {
                Auxi.DX[8] = ALU.NOT(bajo8);
                Auxi.DX[7] = ALU.NOT(bajo7);
                Auxi.DX[6] = ALU.NOT(bajo6);
                Auxi.DX[5] = ALU.NOT(bajo5);
                Auxi.DX[4] = ALU.NOT(bajo4);
                Auxi.DX[3] = ALU.NOT(bajo3);
                Auxi.DX[2] = ALU.NOT(bajo2);
                Auxi.DX[1] = ALU.NOT(bajo1);
            }
        }

        public void NOTRegistro(string Rega, string Regb)
        {
            if ((Rega == ("AX")) && (Regb == ("AX"))) //1=7, 1=6, 1=5, 1=4, etc.
            {
                Auxi.AX[8] = ALU.NOT(Auxi.AX[8]);
                Auxi.AX[7] = ALU.NOT(Auxi.AX[7]);
                Auxi.AX[6] = ALU.NOT(Auxi.AX[6]);
                Auxi.AX[5] = ALU.NOT(Auxi.AX[5]);
                Auxi.AX[4] = ALU.NOT(Auxi.AX[4]);
                Auxi.AX[3] = ALU.NOT(Auxi.AX[3]);
                Auxi.AX[2] = ALU.NOT(Auxi.AX[2]);
                Auxi.AX[1] = ALU.NOT(Auxi.AX[1]);
            }
            else if ((Rega == ("AX")) && (Regb == ("BX")))
            {
                Auxi.BX[8] = ALU.NOT(Auxi.AX[8]);
                Auxi.BX[7] = ALU.NOT(Auxi.AX[7]);
                Auxi.BX[6] = ALU.NOT(Auxi.AX[6]);
                Auxi.BX[5] = ALU.NOT(Auxi.AX[5]);
                Auxi.BX[4] = ALU.NOT(Auxi.AX[4]);
                Auxi.BX[3] = ALU.NOT(Auxi.AX[3]);
                Auxi.BX[2] = ALU.NOT(Auxi.AX[2]);
                Auxi.BX[1] = ALU.NOT(Auxi.AX[1]);
            }
            else if ((Rega == ("AX")) && (Regb == ("CX")))
            {
                Auxi.CX[8] = ALU.NOT(Auxi.AX[8]);
                Auxi.CX[7] = ALU.NOT(Auxi.AX[7]);
                Auxi.CX[6] = ALU.NOT(Auxi.AX[6]);
                Auxi.CX[5] = ALU.NOT(Auxi.AX[5]);
                Auxi.CX[4] = ALU.NOT(Auxi.AX[4]);
                Auxi.CX[3] = ALU.NOT(Auxi.AX[3]);
                Auxi.CX[2] = ALU.NOT(Auxi.AX[2]);
                Auxi.CX[1] = ALU.NOT(Auxi.AX[1]);
            }
            else if ((Rega == ("AX")) && (Regb == ("DX")))
            {
                Auxi.DX[8] = ALU.NOT(Auxi.AX[8]);
                Auxi.DX[7] = ALU.NOT(Auxi.AX[7]);
                Auxi.DX[6] = ALU.NOT(Auxi.AX[6]);
                Auxi.DX[5] = ALU.NOT(Auxi.AX[5]);
                Auxi.DX[4] = ALU.NOT(Auxi.AX[4]);
                Auxi.DX[3] = ALU.NOT(Auxi.AX[3]);
                Auxi.DX[2] = ALU.NOT(Auxi.AX[2]);
                Auxi.DX[1] = ALU.NOT(Auxi.AX[1]);
            }
            else if ((Rega == ("BX")) && (Regb == ("AX")))
            {
                Auxi.AX[8] = ALU.NOT(Auxi.BX[8]);
                Auxi.AX[7] = ALU.NOT(Auxi.BX[7]);
                Auxi.AX[6] = ALU.NOT(Auxi.BX[6]);
                Auxi.AX[5] = ALU.NOT(Auxi.BX[5]);
                Auxi.AX[4] = ALU.NOT(Auxi.BX[4]);
                Auxi.AX[3] = ALU.NOT(Auxi.BX[3]);
                Auxi.AX[2] = ALU.NOT(Auxi.BX[2]);
                Auxi.AX[1] = ALU.NOT(Auxi.BX[1]);
            }
            else if ((Rega == ("BX")) && (Regb == ("BX")))
            {
                Auxi.BX[8] = ALU.NOT(Auxi.BX[8]);
                Auxi.BX[7] = ALU.NOT(Auxi.BX[7]);
                Auxi.BX[6] = ALU.NOT(Auxi.BX[6]);
                Auxi.BX[5] = ALU.NOT(Auxi.BX[5]);
                Auxi.BX[4] = ALU.NOT(Auxi.BX[4]);
                Auxi.BX[3] = ALU.NOT(Auxi.BX[3]);
                Auxi.BX[2] = ALU.NOT(Auxi.BX[2]);
                Auxi.BX[1] = ALU.NOT(Auxi.BX[1]);
            }
            else if ((Rega == ("BX")) && (Regb == ("CX")))
            {
                Auxi.CX[8] = ALU.NOT(Auxi.BX[8]);
                Auxi.CX[7] = ALU.NOT(Auxi.BX[7]);
                Auxi.CX[6] = ALU.NOT(Auxi.BX[6]);
                Auxi.CX[5] = ALU.NOT(Auxi.BX[5]);
                Auxi.CX[4] = ALU.NOT(Auxi.BX[4]);
                Auxi.CX[3] = ALU.NOT(Auxi.BX[3]);
                Auxi.CX[2] = ALU.NOT(Auxi.BX[2]);
                Auxi.CX[1] = ALU.NOT(Auxi.BX[1]);
            }
            else if ((Rega == ("BX")) && (Regb == ("DX")))
            {
                Auxi.DX[8] = ALU.NOT(Auxi.BX[8]);
                Auxi.DX[7] = ALU.NOT(Auxi.BX[7]);
                Auxi.DX[6] = ALU.NOT(Auxi.BX[6]);
                Auxi.DX[5] = ALU.NOT(Auxi.BX[5]);
                Auxi.DX[4] = ALU.NOT(Auxi.BX[4]);
                Auxi.DX[3] = ALU.NOT(Auxi.BX[3]);
                Auxi.DX[2] = ALU.NOT(Auxi.BX[2]);
                Auxi.DX[1] = ALU.NOT(Auxi.BX[1]);
            }
            else if ((Rega == ("CX")) && (Regb == ("AX")))
            {
                Auxi.AX[8] = ALU.NOT(Auxi.CX[8]);
                Auxi.AX[7] = ALU.NOT(Auxi.CX[7]);
                Auxi.AX[6] = ALU.NOT(Auxi.CX[6]);
                Auxi.AX[5] = ALU.NOT(Auxi.CX[5]);
                Auxi.AX[4] = ALU.NOT(Auxi.CX[4]);
                Auxi.AX[3] = ALU.NOT(Auxi.CX[3]);
                Auxi.AX[2] = ALU.NOT(Auxi.CX[2]);
                Auxi.AX[1] = ALU.NOT(Auxi.CX[1]);
            }
            else if ((Rega == ("CX")) && (Regb == ("BX")))
            {
                Auxi.BX[8] = ALU.NOT(Auxi.CX[8]);
                Auxi.BX[7] = ALU.NOT(Auxi.CX[7]);
                Auxi.BX[6] = ALU.NOT(Auxi.CX[6]);
                Auxi.BX[5] = ALU.NOT(Auxi.CX[5]);
                Auxi.BX[4] = ALU.NOT(Auxi.CX[4]);
                Auxi.BX[3] = ALU.NOT(Auxi.CX[3]);
                Auxi.BX[2] = ALU.NOT(Auxi.CX[2]);
                Auxi.BX[1] = ALU.NOT(Auxi.CX[1]);
            }
            else if ((Rega == ("CX")) && (Regb == ("CX")))
            {
                Auxi.CX[8] = ALU.NOT(Auxi.CX[8]);
                Auxi.CX[7] = ALU.NOT(Auxi.CX[7]);
                Auxi.CX[6] = ALU.NOT(Auxi.CX[6]);
                Auxi.CX[5] = ALU.NOT(Auxi.CX[5]);
                Auxi.CX[4] = ALU.NOT(Auxi.CX[4]);
                Auxi.CX[3] = ALU.NOT(Auxi.CX[3]);
                Auxi.CX[2] = ALU.NOT(Auxi.CX[2]);
                Auxi.CX[1] = ALU.NOT(Auxi.CX[1]);
            }
            else if ((Rega == ("CX")) && (Regb == ("DX")))
            {
                Auxi.DX[8] = ALU.NOT(Auxi.CX[8]);
                Auxi.DX[7] = ALU.NOT(Auxi.CX[7]);
                Auxi.DX[6] = ALU.NOT(Auxi.CX[6]);
                Auxi.DX[5] = ALU.NOT(Auxi.CX[5]);
                Auxi.DX[4] = ALU.NOT(Auxi.CX[4]);
                Auxi.DX[3] = ALU.NOT(Auxi.CX[3]);
                Auxi.DX[2] = ALU.NOT(Auxi.CX[2]);
                Auxi.DX[1] = ALU.NOT(Auxi.CX[1]);
            }
            else if ((Rega == ("DX")) && (Regb == ("AX")))
            {
                Auxi.AX[8] = ALU.NOT(Auxi.DX[8]);
                Auxi.AX[7] = ALU.NOT(Auxi.DX[7]);
                Auxi.AX[6] = ALU.NOT(Auxi.DX[6]);
                Auxi.AX[5] = ALU.NOT(Auxi.DX[5]);
                Auxi.AX[4] = ALU.NOT(Auxi.DX[4]);
                Auxi.AX[3] = ALU.NOT(Auxi.DX[3]);
                Auxi.AX[2] = ALU.NOT(Auxi.DX[2]);
                Auxi.AX[1] = ALU.NOT(Auxi.DX[1]);
            }
            else if ((Rega == ("DX")) && (Regb == ("BX")))
            {
                Auxi.BX[8] = ALU.NOT(Auxi.DX[8]);
                Auxi.BX[7] = ALU.NOT(Auxi.DX[7]);
                Auxi.BX[6] = ALU.NOT(Auxi.DX[6]);
                Auxi.BX[5] = ALU.NOT(Auxi.DX[5]);
                Auxi.BX[4] = ALU.NOT(Auxi.DX[4]);
                Auxi.BX[3] = ALU.NOT(Auxi.DX[3]);
                Auxi.BX[2] = ALU.NOT(Auxi.DX[2]);
                Auxi.BX[1] = ALU.NOT(Auxi.DX[1]);
            }
            else if ((Rega == ("DX")) && (Regb == ("CX")))
            {
                Auxi.CX[8] = ALU.NOT(Auxi.DX[8]);
                Auxi.CX[7] = ALU.NOT(Auxi.DX[7]);
                Auxi.CX[6] = ALU.NOT(Auxi.DX[6]);
                Auxi.CX[5] = ALU.NOT(Auxi.DX[5]);
                Auxi.CX[4] = ALU.NOT(Auxi.DX[4]);
                Auxi.CX[3] = ALU.NOT(Auxi.DX[3]);
                Auxi.CX[2] = ALU.NOT(Auxi.DX[2]);
                Auxi.CX[1] = ALU.NOT(Auxi.DX[1]);
            }
            else if ((Rega == ("DX")) && (Regb == ("DX")))
            {
                Auxi.DX[8] = ALU.NOT(Auxi.DX[8]);
                Auxi.DX[7] = ALU.NOT(Auxi.DX[7]);
                Auxi.DX[6] = ALU.NOT(Auxi.DX[6]);
                Auxi.DX[5] = ALU.NOT(Auxi.DX[5]);
                Auxi.DX[4] = ALU.NOT(Auxi.DX[4]);
                Auxi.DX[3] = ALU.NOT(Auxi.DX[3]);
                Auxi.DX[2] = ALU.NOT(Auxi.DX[2]);
                Auxi.DX[1] = ALU.NOT(Auxi.DX[1]);
            }
        }

        public void MOVI(string regdest2, int bajo1, int bajo2, int bajo3, int bajo4, int bajo5, int bajo6, int bajo7, int bajo8)
        {
            if (regdest2 == "AX")
            {
                Auxi.AX[8] = bajo8;
                Auxi.AX[7] = bajo7;
                Auxi.AX[6] = bajo6;
                Auxi.AX[5] = bajo5;
                Auxi.AX[4] = bajo4;
                Auxi.AX[3] = bajo3;
                Auxi.AX[2] = bajo2;
                Auxi.AX[1] = bajo1;
            }
            else if (regdest2 == "BX")
            {
                Auxi.BX[8] = bajo8;
                Auxi.BX[7] = bajo7;
                Auxi.BX[6] = bajo6;
                Auxi.BX[5] = bajo5;
                Auxi.BX[4] = bajo4;
                Auxi.BX[3] = bajo3;
                Auxi.BX[2] = bajo2;
                Auxi.BX[1] = bajo1;
            }
            else if (regdest2 == "CX")
            {
                Auxi.CX[8] = bajo8;
                Auxi.CX[7] = bajo7;
                Auxi.CX[6] = bajo6;
                Auxi.CX[5] = bajo5;
                Auxi.CX[4] = bajo4;
                Auxi.CX[3] = bajo3;
                Auxi.CX[2] = bajo2;
                Auxi.CX[1] = bajo1;
            }
            else if (regdest2 == "DX")
            {
                Auxi.DX[8] = bajo8;
                Auxi.DX[7] = bajo7;
                Auxi.DX[6] = bajo6;
                Auxi.DX[5] = bajo5;
                Auxi.DX[4] = bajo4;
                Auxi.DX[3] = bajo3;
                Auxi.DX[2] = bajo2;
                Auxi.DX[1] = bajo1;
            }
        }

        public void MOVxR(string Rega, string Regb)
        {
            if ((Rega == ("AX")) && (Regb == ("AX"))) //1=7, 1=6, 1=5, 1=4, etc.
            {
                Auxi.AX[8] = Auxi.AX[8];
                Auxi.AX[7] = Auxi.AX[7];
                Auxi.AX[6] = Auxi.AX[6];
                Auxi.AX[5] = Auxi.AX[5];
                Auxi.AX[4] = Auxi.AX[4];
                Auxi.AX[3] = Auxi.AX[3];
                Auxi.AX[2] = Auxi.AX[2];
                Auxi.AX[1] = Auxi.AX[1];
            }
            else if ((Rega == ("AX")) && (Regb == ("BX")))
            {
                Auxi.AX[8] = Auxi.BX[8];
                Auxi.AX[7] = Auxi.BX[7];
                Auxi.AX[6] = Auxi.BX[6];
                Auxi.AX[5] = Auxi.BX[5];
                Auxi.AX[4] = Auxi.BX[4];
                Auxi.AX[3] = Auxi.BX[3];
                Auxi.AX[2] = Auxi.BX[2];
                Auxi.AX[1] = Auxi.BX[1];
            }
            else if ((Rega == ("AX")) && (Regb == ("CX")))
            {
                Auxi.AX[8] = Auxi.CX[8];
                Auxi.AX[7] = Auxi.CX[7];
                Auxi.AX[6] = Auxi.CX[6];
                Auxi.AX[5] = Auxi.CX[5];
                Auxi.AX[4] = Auxi.CX[4];
                Auxi.AX[3] = Auxi.CX[3];
                Auxi.AX[2] = Auxi.CX[2];
                Auxi.AX[1] = Auxi.CX[1];
            }
            else if ((Rega == ("AX")) && (Regb == ("DX")))
            {
                Auxi.AX[8] = Auxi.DX[8];
                Auxi.AX[7] = Auxi.DX[7];
                Auxi.AX[6] = Auxi.DX[6];
                Auxi.AX[5] = Auxi.DX[5];
                Auxi.AX[4] = Auxi.DX[4];
                Auxi.AX[3] = Auxi.DX[3];
                Auxi.AX[2] = Auxi.DX[2];
                Auxi.AX[1] = Auxi.DX[1];
            }
            else if ((Rega == ("BX")) && (Regb == ("AX")))
            {
                Auxi.BX[8] = Auxi.AX[8];
                Auxi.BX[7] = Auxi.AX[7];
                Auxi.BX[6] = Auxi.AX[6];
                Auxi.BX[5] = Auxi.AX[5];
                Auxi.BX[4] = Auxi.AX[4];
                Auxi.BX[3] = Auxi.AX[3];
                Auxi.BX[2] = Auxi.AX[2];
                Auxi.BX[1] = Auxi.AX[1];
            }
            else if ((Rega == ("BX")) && (Regb == ("BX")))
            {
                Auxi.BX[8] = Auxi.BX[8];
                Auxi.BX[7] = Auxi.BX[7];
                Auxi.BX[6] = Auxi.BX[6];
                Auxi.BX[5] = Auxi.BX[5];
                Auxi.BX[4] = Auxi.BX[4];
                Auxi.BX[3] = Auxi.BX[3];
                Auxi.BX[2] = Auxi.BX[2];
                Auxi.BX[1] = Auxi.BX[1];
            }
            else if ((Rega == ("BX")) && (Regb == ("CX")))
            {
                Auxi.BX[8] = Auxi.CX[8];
                Auxi.BX[7] = Auxi.CX[7];
                Auxi.BX[6] = Auxi.CX[6];
                Auxi.BX[5] = Auxi.CX[5];
                Auxi.BX[4] = Auxi.CX[4];
                Auxi.BX[3] = Auxi.CX[3];
                Auxi.BX[2] = Auxi.CX[2];
                Auxi.BX[1] = Auxi.CX[1];
            }
            else if ((Rega == ("BX")) && (Regb == ("DX")))
            {
                Auxi.BX[8] = Auxi.DX[8];
                Auxi.BX[7] = Auxi.DX[7];
                Auxi.BX[6] = Auxi.DX[6];
                Auxi.BX[5] = Auxi.DX[5];
                Auxi.BX[4] = Auxi.DX[4];
                Auxi.BX[3] = Auxi.DX[3];
                Auxi.BX[2] = Auxi.DX[2];
                Auxi.BX[1] = Auxi.DX[1];
            }
            else if ((Rega == ("CX")) && (Regb == ("AX")))
            {
                Auxi.CX[8] = Auxi.AX[8];
                Auxi.CX[7] = Auxi.AX[7];
                Auxi.CX[6] = Auxi.AX[6];
                Auxi.CX[5] = Auxi.AX[5];
                Auxi.CX[4] = Auxi.AX[4];
                Auxi.CX[3] = Auxi.AX[3];
                Auxi.CX[2] = Auxi.AX[2];
                Auxi.CX[1] = Auxi.AX[1];
            }
            else if ((Rega == ("CX")) && (Regb == ("BX")))
            {
                Auxi.CX[8] = Auxi.BX[8];
                Auxi.CX[7] = Auxi.BX[7];
                Auxi.CX[6] = Auxi.BX[6];
                Auxi.CX[5] = Auxi.BX[5];
                Auxi.CX[4] = Auxi.BX[4];
                Auxi.CX[3] = Auxi.BX[3];
                Auxi.CX[2] = Auxi.BX[2];
                Auxi.CX[1] = Auxi.BX[1];
            }
            else if ((Rega == ("CX")) && (Regb == ("CX")))
            {
                Auxi.CX[8] = Auxi.CX[8];
                Auxi.CX[7] = Auxi.CX[7];
                Auxi.CX[6] = Auxi.CX[6];
                Auxi.CX[5] = Auxi.CX[5];
                Auxi.CX[4] = Auxi.CX[4];
                Auxi.CX[3] = Auxi.CX[3];
                Auxi.CX[2] = Auxi.CX[2];
                Auxi.CX[1] = Auxi.CX[1];
            }
            else if ((Rega == ("CX")) && (Regb == ("DX")))
            {
                Auxi.CX[8] = Auxi.DX[8];
                Auxi.CX[7] = Auxi.DX[7];
                Auxi.CX[6] = Auxi.DX[6];
                Auxi.CX[5] = Auxi.DX[5];
                Auxi.CX[4] = Auxi.DX[4];
                Auxi.CX[3] = Auxi.DX[3];
                Auxi.CX[2] = Auxi.DX[2];
                Auxi.CX[1] = Auxi.DX[1];
            }
            else if ((Rega == ("DX")) && (Regb == ("AX")))
            {
                Auxi.DX[8] = Auxi.AX[8];
                Auxi.DX[7] = Auxi.AX[7];
                Auxi.DX[6] = Auxi.AX[6];
                Auxi.DX[5] = Auxi.AX[5];
                Auxi.DX[4] = Auxi.AX[4];
                Auxi.DX[3] = Auxi.AX[3];
                Auxi.DX[2] = Auxi.AX[2];
                Auxi.DX[1] = Auxi.AX[1];
            }
            else if ((Rega == ("DX")) && (Regb == ("BX")))
            {
                Auxi.DX[8] = Auxi.BX[8];
                Auxi.DX[7] = Auxi.BX[7];
                Auxi.DX[6] = Auxi.BX[6];
                Auxi.DX[5] = Auxi.BX[5];
                Auxi.DX[4] = Auxi.BX[4];
                Auxi.DX[3] = Auxi.BX[3];
                Auxi.DX[2] = Auxi.BX[2];
                Auxi.DX[1] = Auxi.BX[1];
            }
            else if ((Rega == ("DX")) && (Regb == ("CX")))
            {
                Auxi.DX[8] = Auxi.CX[8];
                Auxi.DX[7] = Auxi.CX[7];
                Auxi.DX[6] = Auxi.CX[6];
                Auxi.DX[5] = Auxi.CX[5];
                Auxi.DX[4] = Auxi.CX[4];
                Auxi.DX[3] = Auxi.CX[3];
                Auxi.DX[2] = Auxi.CX[2];
                Auxi.DX[1] = Auxi.CX[1];
            }
            else if ((Rega == ("DX")) && (Regb == ("DX")))
            {
                Auxi.DX[8] = Auxi.DX[8];
                Auxi.DX[7] = Auxi.DX[7];
                Auxi.DX[6] = Auxi.DX[6];
                Auxi.DX[5] = Auxi.DX[5];
                Auxi.DX[4] = Auxi.DX[4];
                Auxi.DX[3] = Auxi.DX[3];
                Auxi.DX[2] = Auxi.DX[2];
                Auxi.DX[1] = Auxi.DX[1];
            }
        }
    }
}
