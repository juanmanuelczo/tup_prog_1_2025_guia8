using System.ComponentModel.Design;
using System.Numerics;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region declarar variable
            int contador, acumulador;
            int cantidad=0;
            int maximo=0, minimo=0;
            double promedio = 0;
            #endregion
            #region Iniciar contador y acumulador
            contador = 0;
            acumulador = 0;
            #endregion
            #region solicitud de cantidad de ingresos;
            Console.WriteLine("Ingrese la cantidad de números a entrar");
            cantidad = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region Iterar
            for (int n = 0; n < cantidad; n++)
            {
                #region Solicitar valores
                int num=0;
                Console.WriteLine("Ingrese el número entero");
                num = Convert.ToInt32(Console.ReadLine());
                #endregion
             
                #region acumular valor
                acumulador = acumulador + num;
                #endregion
              
                
                #region Verificar valor mayor
                if (num > maximo || n==0)
                { 
                    maximo = num; 
                }
                #endregion

                #region Verificar valor minimo
                if (num < minimo || n == 0)
                {
                    minimo = num;
                }
                #endregion
            }
            #endregion
            #region Verificar si hubo ingresos
            if (cantidad > 0) 
            {
                promedio = acumulador / cantidad;
            }
            #endregion
            #region Mostrar máximo, mínimo y promedio
            if (cantidad > 0)
            {
                Console.WriteLine($"El valor máximo es {maximo}");
                Console.WriteLine($"El valor mínimo es {minimo}");
                Console.WriteLine($"El promedio es {promedio}");
            }
            else
            {
                Console.WriteLine("No se ingresaron valores");
            }
            #endregion
        }
    }
}
