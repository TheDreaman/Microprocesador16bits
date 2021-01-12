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
        public void Verificar(int a7, int a6, int a5, int a4, int a3, int a2, int a1, int a0, int b7, int b6, int b5, int b4, int b3, int b2, int b1, int b0,int a, int b,int c)
        {
            if ((Auxiliar.Auxiliar.T1 == 0) && (Auxiliar.Auxiliar.T2 == 0) && (Auxiliar.Auxiliar.T3 == 0) && (Auxiliar.Auxiliar.T4 == 0))
            {
                //suma
                ALU16bits ver = new ALU16bits();
                ver.Suma(a7, a6, a5, a4, a3, a2, a1, a0, b7, b6, b5, b4, b3, b2, b1, b0);
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
        
    }
}
