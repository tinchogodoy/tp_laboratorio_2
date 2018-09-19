using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        private double ValidarNumero(string strNumero)
        {
            double validado;
            if (strNumero != "")
            {
                validado = Convert.ToDouble(strNumero);
            }
            else
            {
                validado = Convert.ToDouble("0");
            }
            return validado;
        }

        private string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string numero)
        {
            this.SetNumero = numero;
        }

        public static string BinarioDecimal(string binario)
        {
            double numero = 0, exponente = 0;
            for(int i = binario.Length-1; i >= 0; i--)
            {
                if (binario[i] == '0' || binario[i] == '1')
                {
                    if (binario[i] == '1')
                    {
                        numero = numero + Math.Pow(2, exponente);
                    }
                        
                }
                else
                {
                    return string.Format("Valor Invalido");
                }
                exponente++;
            }
            return numero.ToString();
        }

        public static string DecimalBinario(string numeroStr)
        {
            double numero = Convert.ToDouble(numeroStr);
            return DecimalBinario(numero);
        }

        public static string DecimalBinario(double numero)
        {
            string binario = "";
            while (numero > 0)
            {
                if (numero % 2 == 0)
                {
                    binario = "0" + binario;
                }
                else
                {
                    binario = "1" + binario;
                }
                numero = (int)numero / 2;
            }
            return binario;
        }

        public static double operator -(Numero nUno, Numero nDos)
        {
            if (!(nUno is null) && !(nDos is null))
            {
                return nUno.numero - nDos.numero;
            }
            return 0;
        }

        public static double operator +(Numero nUno, Numero nDos)
        {
            if (!(nUno is null) && !(nDos is null))
            {
                return nUno.numero + nDos.numero;
            }
            return 0;
        }

        public static double operator /(Numero nUno, Numero nDos)
        {
            if (!(nUno is null) && !(nDos is null))
            {
                return nUno.numero / nDos.numero;
            }

            return 0;
        }

        public static double operator *(Numero nUno, Numero nDos)
        {
            if (!(nUno is null) && !(nDos is null))
            {
                return nUno.numero * nDos.numero;
            }
            return 0;
        }
        
    }

}
