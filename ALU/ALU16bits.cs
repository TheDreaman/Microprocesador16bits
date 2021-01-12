using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Auxiliar;

namespace ALU
{
    public class ALU16bits
    {
        //Auxiliar aux = new Auxiliar;
        public void Suma(int a7, int a6, int a5, int a4, int a3, int a2, int a1, int a0, int b7, int b6, int b5, int b4, int b3, int b2, int b1, int b0) //Sumador completo 8bits
        {
            int x = XOR(a0, b0);
            int y = AND(a0, b0);
            int Cin = 0;
            int y2 = AND(x, Cin);
            Auxiliar.Auxiliar.SR0 = XOR(x, Cin);  //Resultado 0
            Auxiliar.Auxiliar.SC0 = OR(y, y2);  //Acarreo 0
            x = XOR(a1, b1);
            y = AND(a1, b1);
            Cin = Auxiliar.Auxiliar.SC0;
            y2 = AND(x, Cin);
            Auxiliar.Auxiliar.SR1 = XOR(x, Cin);  //Resultado 1
            Auxiliar.Auxiliar.SC1 = OR(y, y2);  //Acarreo 1
            x = XOR(a2, b2);
            y = AND(a2, b2);
            Cin = Auxiliar.Auxiliar.SC1;
            y2 = AND(x, Cin);
            Auxiliar.Auxiliar.SR2 = XOR(x, Cin);  //Resultado 2
            Auxiliar.Auxiliar.SC2 = OR(y, y2);  //Acarreo 2
            x = XOR(a3, b3);
            y = AND(a3, b3);
            Cin = Auxiliar.Auxiliar.SC2;
            y2 = AND(x, Cin);
            Auxiliar.Auxiliar.SR3 = XOR(x, Cin);  //Resultado 3
            Auxiliar.Auxiliar.SC3 = OR(y, y2);  //Acarreo 3
            x = XOR(a4, b4);
            y = AND(a4, b4);
            Cin = Auxiliar.Auxiliar.SC3;
            y2 = AND(x, Cin);
            Auxiliar.Auxiliar.SR4 = XOR(x, Cin);  //Resultado 4
            Auxiliar.Auxiliar.SC4 = OR(y, y2);  //Acarreo 4
            x = XOR(a5, b5);
            y = AND(a5, b5);
            Cin = Auxiliar.Auxiliar.SC4;
            y2 = AND(x, Cin);
            Auxiliar.Auxiliar.SR5 = XOR(x, Cin);  //Resultado 5
            Auxiliar.Auxiliar.SC5 = OR(y, y2);  //Acarreo 5
            x = XOR(a6, b6);
            y = AND(a6, b6);
            Cin = Auxiliar.Auxiliar.SC5;
            y2 = AND(x, Cin);
            Auxiliar.Auxiliar.SR6 = XOR(x, Cin);  //Resultado 6
            Auxiliar.Auxiliar.SC6 = OR(y, y2);  //Acarreo 6
            x = XOR(a7, b7);
            y = AND(a7, b7);
            Cin = Auxiliar.Auxiliar.SC6;
            y2 = AND(x, Cin);
            Auxiliar.Auxiliar.SR7 = XOR(x, Cin);  //Resultado 7
            Auxiliar.Auxiliar.SC7 = OR(y, y2);  //Acarreo 7
        }

        public void Resta(int a7, int a6, int a5, int a4, int a3, int a2, int a1, int a0, int b7, int b6, int b5, int b4, int b3, int b2, int b1, int b0) //Sumador completo 8bits
        {
            int Cin = 0;
            int x = XOR(a0, b0);
            int y = AND(NOT(a0), b0);
            int z = AND(NOT(a0), Cin);
            int w = AND(b0, Cin);
            int R0 = XOR(x, Cin);  //Resultado 0
            int Cout0 = OR3(y, z, w);  //Acarreo 0
            Cin = Cout0;
            x = XOR(a1, b1);
            y = AND(NOT(a1), b1);
            z = AND(NOT(a1), Cin);
            w = AND(b1, Cin);
            int R1 = XOR(x, Cin);  //Resultado 1
            int Cout1 = OR3(y, z, w);  //Acarreo 1
            Cin = Cout1;
            x = XOR(a2, b2);
            y = AND(NOT(a2), b2);
            z = AND(NOT(a2), Cin);
            w = AND(b2, Cin);
            int R2 = XOR(x, Cin);  //Resultado 2
            int Cout2 = OR3(y, z, w);  //Acarreo 2
            Cin = Cout2;
            x = XOR(a3, b3);
            y = AND(NOT(a3), b3);
            z = AND(NOT(a3), Cin);
            w = AND(b3, Cin);
            int R3 = XOR(x, Cin);  //Resultado 3
            int Cout3 = OR3(y, z, w);  //Acarreo 3
            Cin = Cout3;
            x = XOR(a4, b4);
            y = AND(NOT(a4), b4);
            z = AND(NOT(a4), Cin);
            w = AND(b4, Cin);
            int R4 = XOR(x, Cin);  //Resultado 4
            int Cout4 = OR3(y, z, w);  //Acarreo 4
            Cin = Cout4;
            x = XOR(a5, b5);
            y = AND(NOT(a5), b5);
            z = AND(NOT(a5), Cin);
            w = AND(b5, Cin);
            int R5 = XOR(x, Cin);  //Resultado 5
            int Cout5 = OR3(y, z, w);  //Acarreo 5
            Cin = Cout5;
            x = XOR(a6, b6);
            y = AND(NOT(a6), b6);
            z = AND(NOT(a6), Cin);
            w = AND(b6, Cin);
            int R6 = XOR(x, Cin);  //Resultado 6
            int Cout6 = OR3(y, z, w);  //Acarreo 6
            Cin = Cout6;
            x = XOR(a7, b7);
            y = AND(NOT(a7), b7);
            z = AND(NOT(a7), Cin);
            w = AND(b7, Cin);
            int R7 = XOR(x, Cin);  //Resultado 7
            int Cout7 = OR3(y, z, w);  //Acarreo 7
        }

        public int XOR(int a, int b)
        {
            if(a==0 && b==0)
            {
                return 1;
            }
            else if(a==0 && b==1)
            {
                return 1;
            }
            else if (a==1 && b==0)
            {
                return 1;
            }
            else if (a==1 && b==1)
            {
                return 0;
            }
            else
            {
                return 0;
            }
        }

        public int XNOR(int a, int b)
        {
            int x = XOR(a, b);
            int r = NOT(x);
            return r;
        }

        public int NOT(int a)
        {
            if(a==0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int AND(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                return 0;
            }
            else if (a == 0 && b == 1)
            {
                return 0;
            }
            else if (a == 1 && b == 0)
            {
                return 0;
            }
            else if (a == 1 && b == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int OR(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                return 0;
            }
            else if (a == 0 && b == 1)
            {
                return 1;
            }
            else if (a == 1 && b == 0)
            {
                return 1;
            }
            else if (a == 1 && b == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int OR3(int a, int b, int c)
        {
            if (a == 0 && b == 0 && c == 0)
            {
                return 0;
            }
            else if (a == 0 && b == 0 && c == 1)
            {
                return 1;
            }
            else if (a == 0 && b == 1 && c == 0)
            {
                return 1;
            }
            else if (a == 0 && b == 1 && c == 1)
            {
                return 1;
            }
            else if (a == 1 && b == 0 && c == 0)
            {
                return 1;
            }
            else if (a == 1 && b == 0 && c == 1)
            {
                return 1;
            }
            else if (a == 1 && b == 1 && c == 0)
            {
                return 1;
            }
            else if (a == 1 && b == 1 && c == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


    }
}
