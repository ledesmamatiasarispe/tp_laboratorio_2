using System;

namespace Trabajo_Practico_1
{
    public class Numero
    {
        private double numero;

        /// <summary>
        /// El constructor por defecto (sin parámetros) asignará valor 0 al atributo numero.
        /// </summary>
        public Numero() : this(0)
        {
            this.numero = 0;
        }

        public Numero(double numero) 
        {
            this.numero = numero;
        }
        public Numero(string numero)
        {
            double numeroParseado;
            if(  double.TryParse(numero,out numeroParseado) )
            {
                this.numero = numeroParseado;


            }else { this.numero = 0; }
            
        }

        /// <summary>
        /// ValidarNumero comprobará que el valor recibido sea numérico, y lo retornará en
        /// formato double. Caso contrario, retornará 0.
        /// </summary>
        private static double ValidarNumero(string strNumero)
        {
            double retorno = 0;
            Double.TryParse(strNumero, out retorno);
            return retorno;
        }

        /// <summary>
        /// La propiedad SetNumero asignará un valor al atributo número, previa validación.
        /// </summary>
        public string setNumero
        {
            set
            {
                if (value.GetType() == Type.GetType("System.String"))
                    numero = ValidarNumero(value);
            }
        }

        /// <summary>
        /// El método privado EsBinario validará que la cadena de caracteres esté compuesta
        /// SOLAMENTE por caracteres '0' o '1'.
        ///  </summary>
        private static bool EsBinario(string cadena)
        {
            bool esBinario = true;
            foreach (char numero in cadena)
            {
                if (numero < '0' || numero > '1')
                {
                    esBinario = false;
                    break;
                }
            }
            return esBinario;
        }

        /// <summary>
        /// este metodo transforma un numero de una base numerica a otra
        /// </summary>
        /// <param name="numero">es el numero ingresado a transformar,Atencion! este metodo
        /// no revisa que el numero pertenesca a la base correcta</param>
        /// <param name="BaseActual">la base de el numero ingresado como parametro 0</param>
        /// <param name="BaseDestino"> es la base a la que se va a convertir el numero ingresado</param>
        /// <returns></returns>
        private static long ConvertirBase(long numero, int BaseActual, int BaseDestino)
        {
            long resultado = 0;
            long digito = 0;
            for (int potenciaDePosicion = 0; numero > 0; potenciaDePosicion++)
            {
                digito = numero % BaseDestino;
                resultado += digito * (long)Math.Pow(BaseActual, potenciaDePosicion);
                numero /= BaseDestino;
            }
            return resultado;
        }

        /// <summary>
        ///  El método BinarioDecimal validará que se trate de un binario y luego
        /// convertirá ese número binario a decimal, en caso de ser posible.Caso
        /// contrario retornará "Valor inválido".
        /// </summary>
        /// <param name="numeroBinario"></param>
        /// <returns></returns>
        public static string BinarioDecimal(string numeroBinario)
        {
            string respuesta = "valor inválido";
            if (numeroBinario != null && numeroBinario != "")
            {
                Console.WriteLine(numeroBinario);
                if (Numero.EsBinario(numeroBinario))
                {
                    long numeroParseado;
                    if (long.TryParse(numeroBinario, out numeroParseado))
                    {
                        respuesta = ConvertirBase(numeroParseado, 2, 10).ToString();
                    }
                }
            }
            return respuesta;
        }

        /// <summary>
        /// Ambas opciones del método DecimalBinario convertirán un número
        /// decimal a binario, en caso de ser posible.Caso contrario retornará "Valor
        ///inválido".
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(string numero)
        {
            string respuesta = "valor inválido";

            double numeroParseado;

            if (double.TryParse(numero, out numeroParseado))
            {
                respuesta = DecimalBinario(numeroParseado);
            }

            return respuesta;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="numero"> max 524287</param>
        /// <returns></returns>
        public static string DecimalBinario(double numero)
        {
            return ConvertirBase((long)numero, 10, 2).ToString();
        }

        public static double operator -(Numero numero1, Numero numero2)
        {
            return numero1.numero - numero2.numero;
        }

        public static double operator +(Numero numero1, Numero numero2)
        {
            return numero1.numero + numero2.numero;
        }

        public static double operator /(Numero numero1, Numero numero2)
        {
            double resultado = double.MinValue;

            if (numero2.numero != 0)
            {
                resultado = numero1.numero / numero2.numero;
            }

            return resultado;
        }

        public static double operator *(Numero numero1, Numero numero2)
        {
            return numero1.numero * numero2.numero;
        }
    }
}