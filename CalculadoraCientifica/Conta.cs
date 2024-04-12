using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCientifica
{
    public class Conta
    {

        public Double Somar(Double num1, Double num2, String operador)
        {

            Double resultado = 0;


            if (operador == "+")
            {
                resultado = (num1 + num2);
            }
            else if (operador == "-")
            {
                resultado = (num1 - num2);
            }
            else if (operador == "X")
            {
                resultado = (num1 * num2);
            }
            else if (operador == "/")
            {
                resultado = (num1 / num2);
            }


            return resultado;
        }


        public String mSeno(String v)
        {
            double sin = double.Parse(v);
            return Math.Sin((sin * Math.PI) / 180) + "";
        }

        public String mCos(String vdisplay)
        {
            double sin = double.Parse(vdisplay);
            return Math.Cos((sin * Math.PI) / 180) + "";
        }

        public Double mDecimal(String display)
        {

            int i, tamanho, n = 0;

            String texto = display;
            tamanho = texto.Length;
            for (i = 0; i <= (texto.Length) - 1; i++)
            {
                tamanho--;
                if (texto[i] == '1')
                    n = n + (int)Math.Pow(2, tamanho);
            }
            display = (n).ToString();

            return n;
        }

        public String mBinario(String display)
        {

            int n, r;
            String b = "";
            n = int.Parse(display);
            while (n > 0)
            {
                r = n % 2;
                n = n / 2;
                if (r == 0)
                    b = "0" + b;
                else
                    b = "1" + b;
            }
            display = b;

            return display;
        }

        public String mInverte(String display)
        {
            Double v = 0;
            v = Convert.ToDouble(display);
            v = v * -1;
            display = "" + v;

            return display;
        }

    }


 

}
