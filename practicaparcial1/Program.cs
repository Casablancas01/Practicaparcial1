using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaparcial1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HECHO SIN VER LO QUE HIZO EL PROFESOR 
            //    try
            //    {
            //        Console.WriteLine("Ingrese la hora de su reloj:");
            //        var hora = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Ingrese los minutos de su reloj:");
            //        var minutos = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Ingrese los segundos de su reloj:");
            //        var segundos = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Indique si la hora es AM o PM: ");
            //        string etapadia = Console.ReadLine();


            //        if (hora > 12 || hora < 0)
            //        {
            //            Console.WriteLine("oh! datos mas ingresado, por favor ingrese una hora correspondiente.");
            //        }
            //        else if (minutos > 60 || minutos < 0)
            //        {
            //            Console.WriteLine("oh! datos mas ingresado, por favor ingrese los minutos correspondiente.");
            //        }
            //        else if (segundos > 60 || minutos < 0)
            //        {
            //            Console.WriteLine("oh! datos mas ingresado, por favor ingrese los segundos correspondiente.");
            //        }
            //        else if (etapadia.ToUpper() != "AM" && etapadia.ToUpper() != "PM")
            //        {
            //            Console.WriteLine("Por favor ingrese un formato AM o PM");
            //        }
            //        else if (etapadia.ToUpper() == "PM" && hora == 0)
            //        {
            //            Console.WriteLine(@"La hora indicada no puede ser ""0"" y PM.");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Su hora ingresada es {hora}:{minutos.ToString("0,0")}:{segundos.ToString("0,0")} {etapadia.ToUpper()}");
            //            if (etapadia.ToUpper() == "PM")
            //            {
            //                Console.WriteLine($"La hora en formato 24hs es: {transformador(hora)}:{minutos}:{segundos} HS");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"La hora en formato 24hs es: {hora}:{minutos.ToString("0,0")}:{segundos.ToString("0,0")}HS");
            //            }
            //        }

            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Debe ingresar datos en fomrato enteros.");
            //    }

            //    Console.ReadKey();
            //}
            //private static int transformador(int hora)
            //{
            //    int resultado;
            //    if (hora == 12)
            //    {
            //        resultado = hora - 12;
            //    }
            //    else
            //    {
            //        resultado = hora + 12;
            //    }
            //    return resultado;

            //HECHO DESPUES DE VER LO RESULETO POR EL PROFESOR
            try
            {

                Console.Write("Ingrese la hora: ");
                var hora = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese los minutos: ");
                var minutos = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese los segundos segundos: ");
                var segundos = Convert.ToInt32(Console.ReadLine());
                Console.Write("Indique la etapa del del dia: ");
                string indicador = Console.ReadLine();

                if (validarhora(hora) && validarmin(minutos) && validarsegundos(segundos) && validarindicador(indicador,hora))
                {
                    if (indicador.ToUpper() == "PM" && hora == 12)
                    {
                        respuesta12hs(hora, minutos, segundos, indicador);                       
                    }
                    else
                    {
                        respuesta24hs(hora, minutos, segundos, indicador);                       
                    }

                }
                else
                {
                    Console.WriteLine("Algo salio mal.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Por favor ingresar los datos en el formato solicitado.");
            }
            Console.ReadKey();

        }

        private static void respuesta24hs(int hora, int minutos, int segundos, string indicador)
        {
            int hora24hs = crear24hs(hora);
            Console.WriteLine($"su hora es: {hora.ToString("0,0")}:{minutos.ToString("0,0")}:{segundos.ToString("0,0")} {indicador.ToUpper()}");
            Console.WriteLine($"su hora 24hs es: {hora24hs.ToString("0,0")}:{minutos.ToString("0,0")}:{segundos.ToString("0,0")} HS");

        }

        private static void respuesta12hs(int hora,int minutos, int segundos,string indicador)
        {
            Console.WriteLine($"su hora es: {hora.ToString("0,0")}:{minutos.ToString("0,0")}:{segundos.ToString("0,0")} {indicador.ToUpper()}");
            Console.WriteLine($"su hora 24hs es: {hora.ToString("0,0")}:{minutos.ToString("0,0")}:{segundos.ToString("0,0")} HS");
        }

        private static int crear24hs(int hora)
        {
            int resultado;
            if (hora == 12)
            {
                resultado = hora - 12;
            }
            else
            {
                resultado = hora + 12;
            }
           
                return resultado;
        }
        private static bool validarindicador(string indicador,int hora)=> indicador.ToUpper() == "AM" || indicador.ToUpper() == "PM" && hora != 0;
        private static bool validarsegundos(int segundos) => segundos >= 0 && segundos <= 59;
        private static bool validarmin(int minutos)=> minutos <= 59 && minutos >= 0;
        private static bool validarhora(int hora)=> hora >= 1 && hora <= 12;
       
    
    }
}
