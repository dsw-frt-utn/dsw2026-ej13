using Dsw2026Ej13.Domain;
using Dsw2026Ej13.Library;
using Dsw2026Ej13.Services;
using System.Diagnostics;

namespace Dsw2026Ej13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de precios ARS -> USD");
            var stopwatch = Stopwatch.StartNew();
            var service = new ExchangeService();
            service.UpdatePrices();
            stopwatch.Stop();
            Console.WriteLine($"Tiempo de ejecución: {stopwatch.ElapsedMilliseconds}");
        }
    }
}
