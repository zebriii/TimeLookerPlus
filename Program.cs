using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main()
    {

        Console.Title = "TimeLooker - Select Menu";


        while (true)
        {
            Console.WriteLine("+---------------------+");
            Console.WriteLine("| 1: Date Info");
            Console.WriteLine("| 2: Network Ping");
            Console.WriteLine("| 3: Exit");
            Console.WriteLine("+---------------------+");
            Console.Write("-> You: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ShowDateInfo();
                    break;
                case "2":
                    CheckNetworkPing();
                    break;
                case "3":
                    Console.WriteLine("Goodbye.");
                    return; // termina el programa
                case "gaster":
                    Console.WriteLine("...");
                    return;
                case "ejemplo":
                    CodeEjemplo();
                    break;
                case "example":
                    CodeExample();
                    break;
                case "salir":
                    Console.WriteLine("Closing console");
                    return;
                case "menu":
                    Console.WriteLine("Back to menu");
                    return;
                case "gneral":  
                    Console.WriteLine("Gneral");
                    return;
                case "no":
                    Console.WriteLine("No");
                    return;
                default:
                    Console.WriteLine("Option its not valid.");
                    break;
            }

            Console.WriteLine(); // línea en blanco para separar iteraciones
        }
    }
    
    static void CodeEjemplo()
        {
            Console.WriteLine("+ Ejemplo");
        }
    static void CodeExample()
        {
            Console.WriteLine("+ Example");
        }
    static void ShowDateInfo()
        {
            
        Console.Title = "TimeLooker - TimeLooking.";


        DateTime ahora = DateTime.Now;
        TimeZoneInfo zonaHoraria = TimeZoneInfo.Local;
  
        Console.WriteLine("                     TimeLooker+");
        Console.WriteLine("+-----------------------------------------------------------------------------------+");
        Console.WriteLine("| PC Actual Date Format: " + ahora.ToString("dddd, dd MMMM yyyy"));
        Console.WriteLine("| PC Actual Hour: " + ahora.ToString("HH:mm:ss"));
        Console.WriteLine("| PC Configure Time Zone : " + zonaHoraria.DisplayName);
        Console.WriteLine("| PC Actual Day : " + ahora.Day);
        Console.WriteLine("| PC Actual Month : " + ahora.Month);
        Console.WriteLine("| PC Actual Year : " + ahora.Year);
        bool internet = CheckInternetConnection();
        Console.WriteLine("| PC Haves Internet? : " + (internet ? "True" : "False"));
        Console.Write("+-----------------------------------------------------------------------------------+");
    }

    static bool CheckInternetConnection()
    {
        try
        {
            using (var ping = new Ping())
            {
                PingReply reply = ping.Send("9.9.9.9", 3000);
                return (reply.Status == IPStatus.Success);
            }
        }
        catch
        {
            return false;
        }
    }    

    static void CheckNetworkPing()
    {
        try
        {
            Ping ping = new Ping();
            PingReply reply = ping.Send("8.8.8.8", 3000);

            if (reply.Status == IPStatus.Success)
            {
                Console.WriteLine("Ping exitoso a 8.8.8.8");
            }
            else
            {
                Console.WriteLine("No se pudo hacer ping a 8.8.8.8");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error en el ping: " + ex.Message);
        }
    }
}
