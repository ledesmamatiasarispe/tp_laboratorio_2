using System;
using System.Diagnostics;
using entidades;
using Trabajo_Practico_1;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {

            //Stopwatch medirTiempo = new Stopwatch();


            Console.WriteLine("Hello World!");

            string[] ArrayDeCAdenas = { null, "+", "-", "*", "/", "", "afasdg5s64rga31dv5a1s6df" };


          

            foreach(string operador in ArrayDeCAdenas)
            {

                Console.WriteLine("el operador es = " + operador);
                Console.WriteLine(Calculadora.Operar(new Numero(5), new Numero(5), operador));


            }







            /*
            string numero1 = "0111";

            medirTiempo.Start();
            string numero2 = Numero.BinarioDecimal(numero1);
            medirTiempo.Stop();

            Console.WriteLine($"tiempo : {medirTiempo.Elapsed.TotalMilliseconds} ms");
            Console.WriteLine(numero1);
            Console.WriteLine(numero2);
            Console.WriteLine("funcion copiada");
            medirTiempo.Restart();
            
            */

            /*

            do
            {
                
                medirTiempo.Start();
                Console.WriteLine("numero = {0}", Numero.DecimalBinario(Console.ReadLine()));
                medirTiempo.Stop();
                Console.WriteLine($"tiempo : {medirTiempo.Elapsed.TotalMilliseconds} ms");

            } while (true);
            */
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


    }
}
