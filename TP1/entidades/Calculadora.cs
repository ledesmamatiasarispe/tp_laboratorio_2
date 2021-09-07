using Trabajo_Practico_1;

namespace Trabajo_Practico_1
{
    public static class Calculadora
    {
        public static double Operar(Numero numero1, Numero numero2, string operador)
        {
            double resultado = 0;
            if (operador != null && operador != "")
            {
                operador = ValidarOperador(operador[0]);
                switch (operador)
                {
                    case "+":
                        resultado = numero1 + numero2;
                        break;

                    case "-":
                        resultado = numero1 - numero2;
                        break;

                    case "*":
                        resultado = numero1 * numero2;
                        break;

                    case "/":
                        resultado = numero1 / numero2;
                        break;
                }
            }

            return resultado;
        }

        private static string ValidarOperador(char operador)
        {
            string respuesta = "+";
            if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                respuesta = operador.ToString();
            }
            return respuesta;
        }
    }
}