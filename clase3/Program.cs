using System;

namespace clase3
{
    public class Program
    {
        // Para todas
        static string textoEntrada = "Ingrese ";
        static string textoSalida = "Fin de actividad. Presione una tecla para continuar.";

        // Actividad 1
        static int maximo, cantNumeros = 3;
        static int[] numeros = { 0,0,0 };

        // Actividad 2
        static double a, b, c;
        static double raiz1, raiz2;
        static bool tieneRaiz1 = false, tieneRaiz2 = false;

        // Actividad 3
        static int a3, b3, act3Resultado;

        // Actividad 4
        static int numero;
        static bool act4Resultado;

        // Actividad 5
        static int numPrimoHasta;

        // Actividad 6
        static int pago;
        static double tasaInteres = 0.015, deuda = 1000;

        static void Main(string[] args)
        {
            Actividad1();
            Actividad2();
            Actividad3();
            Actividad4();
            Actividad5();
            Actividad6();
        }

        private static void Actividad1()
        {
            Actividad1_Ingreso();
            Actividad1_Comparacion();
            Actividad1_MostrarResultado();
            Salida();
        }

        private static void Actividad1_Ingreso()
        {
            for (int i = 0; i < cantNumeros; i++)
            {
                Console.Clear();
                numeros[i] = IngresaValorInt(textoEntrada + "un numero. (" + (i+1).ToString() + " de " + cantNumeros.ToString() + ')');
            }
        }
        private static void Actividad1_Comparacion()
        {
            for (int i = 1; i < cantNumeros; i++)
            {
                maximo = ObtenerValorMasGrande(numeros[i-1], numeros[i]);
            }
        }
        private static void Actividad1_MostrarResultado()
        {
            Console.Clear();
            Console.WriteLine("El numero mas grande ingresado es: " + maximo.ToString());
        }
        
        private static void Actividad2()
        {
            Actividad2_Ingreso();
            Actividad2_Calculo();
            Actividad2_MostrarResultado();
            Salida();
        }

        private static void Actividad2_Ingreso()
        {
            Console.Clear();
            a = IngresaValorDouble(textoEntrada + "valor de a");
            b = IngresaValorDouble(textoEntrada + "valor de b");
            c = IngresaValorDouble(textoEntrada + "valor de c");
        }
        private static void Actividad2_Calculo()
        {
            double disc, deno;
            if (a == 0)
            {
                raiz1 = (-c / b); // Es lineal, tiene una sola raiz
                tieneRaiz1 = true;
            }
            else
            {
                disc = (b * b) - (4 * a * c);
                deno = 2 * a;
                if (disc > 0)
                {
                    raiz1 = (-b / deno) + (Math.Sqrt(disc) / deno);
                    tieneRaiz1 = true;
                    raiz2 = (-b / deno) - (Math.Sqrt(disc) / deno);
                    tieneRaiz2 = true;
                }
                else if (disc == 0)
                {
                    raiz1 = -b / deno;
                    tieneRaiz1 = true;
                }
                else
                {
                    raiz1 = -b / deno;
                    tieneRaiz1 = true;
                    raiz2 = ((Math.Sqrt((4 * a * c) - (b * b))) / deno);
                    tieneRaiz2 = true;
                }
            }
        }
        private static void Actividad2_MostrarResultado()
        {
            Console.Clear();
            if(tieneRaiz1)
                Console.WriteLine("El valor de la raiz x1 es: " + raiz1.ToString());
            if (tieneRaiz2)
                Console.WriteLine("El valor de la raiz x2 es: " + raiz2.ToString());
        }

        private static void Actividad3()
        {
            Actividad3_Ingreso();
            Actividad3_Calculo();
            Actividad3_MostrarResultado();
            Salida();
        }

        private static void Actividad3_Ingreso()
        {
            Console.Clear();
            a3 = IngresaValorInt(textoEntrada + "valor de a");
            b3 = IngresaValorInt(textoEntrada + "valor de b");
        }
        private static void Actividad3_Calculo()
        {
            if (b3 == 0)
                act3Resultado = 1;
            else if (b3 == 1)
                act3Resultado = a3;
            else
            {
                act3Resultado = a3;
                for (int i = 2; i < b3; i++)
                {
                    act3Resultado *= a3;
                }
            }
        }
        private static void Actividad3_MostrarResultado()
        {
            Console.WriteLine("El resultado por productos sucesivos de " + a3.ToString() + " elevado a " + b3.ToString() + " es: " + act3Resultado.ToString());
        }

        private static void Actividad4()
        {
            Actividad4_Ingreso();
            Actividad4_Calculo();
            Actividad4_MostrarResultado();
            Salida();
        }

        private static void Actividad4_Ingreso()
        {
            numero = IngresaValorInt(textoEntrada + " numero para evaluar si es primo o no:");
        }
        private static void Actividad4_Calculo()
        {
            act4Resultado = EsPrimo(numero);
        }
        private static void Actividad4_MostrarResultado()
        {
            if (act4Resultado)
                Console.WriteLine("El numero " + numero.ToString() + " es primo.");
            else
                Console.WriteLine("El numero " + numero.ToString() + " NO es primo.");
        }

        private static void Actividad5()
        {
            Actividad5_Ingreso();
            Actividad5_CalcularYMostrar();
            Salida();
        }

        private static void Actividad5_Ingreso()
        {
            numPrimoHasta = IngresaValorInt(textoEntrada + " un numero para mostrar los numeros primos entre 1 y dicho numero.");
        }
        private static void Actividad5_CalcularYMostrar()
        {
            Console.Clear();
            bool hayPrimos = false;
            Console.WriteLine("Los numeros primos entre 1 y " + numPrimoHasta.ToString() + " son:");
            for(int i=1; i <= numPrimoHasta; i++)
            {
                if (EsPrimo(i))
                {
                    hayPrimos = true;
                    Console.WriteLine(i.ToString());
                } 
            }

            if (!hayPrimos)
            {
                Console.Clear();
                Console.WriteLine("No hay numeros primos que listar.");
            }

        }

        private static void Actividad6()
        {
            Actividad6_Ingreso();
            Actividad6_CalcularYMostrar();
            Salida();
        }

        private static void Actividad6_Ingreso()
        {
            do
            {
                Console.Clear();
                pago = IngresaValorInt(textoEntrada + " pago:");
            } while (pago < 1);
        }

        private static void Actividad6_CalcularYMostrar()
        {
            double interes;
            int mes = 1, totalPago = 0;
            while(deuda > 0)
            {
                totalPago += pago;
                interes = deuda * tasaInteres;
                deuda = (deuda - pago + interes);
                Console.WriteLine("Mes: {0}        saldo: {1:C}  			total pagado: {2:C}",mes, deuda, totalPago);
                mes++;
            }
        }

        private static int ObtenerValorMasGrande(int v1, int v2)
        {
            if (v1 > v2)
                return v1;
            else
                return v2;
        }

        private static int IngresaValorInt(string title)
        {
            Console.WriteLine(textoEntrada + title);
            return int.Parse(Console.ReadLine());
        }
        private static double IngresaValorDouble(string title)
        {
            Console.WriteLine(textoEntrada + title);
            return double.Parse(Console.ReadLine());
        }
        private static bool EsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
        private static void Salida()
        {
            Console.WriteLine(textoSalida);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
