using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FinanaceManagementApp
{
    internal static class Menu
    {
        //Gastos Medicos
        private static decimal prepaga = 40000;
        //Gastos de la casa
        private static decimal alquiler = 40000;
        private static decimal serviciosPublicos = 50000;
        private static decimal internet = 10000;
        private static decimal totalGastosCasa = alquiler + serviciosPublicos + internet;
        //Ocio
        private static decimal salidas = 30000;
        private static decimal netflix = 10000;
        private static decimal totalOcio = salidas + netflix;
        //Ahorro
        private static decimal ahorro = 5000;
        //Educacion
        private static decimal educacion = 10000;
        //Gastos Totales
        private static decimal gastosTotales = prepaga + totalGastosCasa + totalOcio + ahorro + educacion;

        public static void Mostrar()
        {
            while (true)
            {
                Console.WriteLine("Registre sus ingresos por favor");
                var ingresos = Console.ReadLine();
                var val = Decimal.TryParse(ingresos, out var ing);
                if (!val)
                {
                    Console.WriteLine("Debe ingresar un valor numerico, intente de nuevo.");
                    continue;
                }

                Elegir(ing);
                break;
            }
        }

        private static void Elegir(decimal ingreso)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Elija una opción");
                Console.WriteLine("1-Gastos médicos");
                Console.WriteLine("2-Gastos de la casa.");
                Console.WriteLine("3-Ocio");
                Console.WriteLine("4-Ahorro");
                Console.WriteLine("5-Educación");
                Console.WriteLine("6-Total de expensas");
                Console.WriteLine("7-Salir");

                var opcion = Console.ReadLine();

                var val = Decimal.TryParse(opcion, out var op);

                if (!val)
                {
                    Console.WriteLine("Ingrese un valor numérico");
                    continue;
                }
                else if (op == 1)
                {
                    MostrarGastosMedicos(prepaga);
                    continue;
                }
                else if (op == 2)
                {
                    MostrarGastosCasa(alquiler, serviciosPublicos, internet, totalGastosCasa);
                    continue;

                }
                else if (op == 3)
                {
                    MostrarOcio(salidas, netflix, totalOcio);
                    continue;
                }
                else if (op == 4)
                {
                    MostrarAhorro(ahorro);
                    continue;

                }
                else if (op == 5)
                {
                    MostrarEducacion(educacion);
                    continue;
                }
                else if (op == 6)
                {
                    MostrarTotalExpensas(ingreso, gastosTotales);
                    continue;
                }
                else if (op == 7)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Ingrese un valor de 1 a 7");
                    continue;
                }
            }

        }

        private static void MostrarGastosMedicos(decimal prepaga)
        {
            Console.Clear();
            Console.WriteLine("Prepaga: " + prepaga);
            Console.ReadKey();
        }
        private static void MostrarGastosCasa(decimal alquiler, decimal serviciosPublicos, decimal internet, decimal totalGastosCasa)
        {
            Console.Clear();
            Console.WriteLine("Alquiler: "  + alquiler.ToString());
            Console.WriteLine("servicios publicos: " + serviciosPublicos.ToString());
            Console.WriteLine("Internet: " + internet.ToString());
            Console.WriteLine("Gastos de la casa totales: " + totalGastosCasa.ToString());
            Console.ReadKey();
        }
        private static void MostrarOcio(decimal salidas, decimal netflix, decimal totalOcio)
        {
            Console.Clear();
            Console.WriteLine("Salidas: " + salidas.ToString());
            Console.WriteLine("Netflix: " + salidas.ToString());
            Console.WriteLine("Total Ocio: " + totalOcio.ToString());
            Console.ReadKey();
        }
        private static void MostrarAhorro(decimal ahorro)
        {
            Console.Clear();
            Console.WriteLine("Ahorro: " + ahorro.ToString());
            Console.ReadKey();
        }
        private static void MostrarEducacion(decimal educacion)
        {
            Console.Clear();
            Console.WriteLine("Educacion: " + educacion.ToString());
            Console.ReadKey();
        }
        private static void MostrarTotalExpensas(decimal ingreso, decimal totales)
        {
            Console.Clear();
            Console.WriteLine("Sus gatos totales son: " + totales.ToString());

            if (ingreso == totales)
            {
                Console.WriteLine("Debe gastar menos en su casa");
            }
            if(ingreso > totales)
            {
                Console.WriteLine("Feclicidades, usted gasta menos de lo que gana");
            }
            if (ingreso < totales)
            {
                Console.WriteLine("Debe mejorar sus finanzas");
            }
            Console.ReadKey();
        }

    }
}
