using Dsw2026Ej13.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2026Ej13.Services;

internal class DataService
{
    public static List<Product>? GetProductsFromFile()
    {
        var data = File.ReadAllText("Data\\Products.json");
        return System.Text.Json
        .JsonSerializer
            .Deserialize<List<Product>>(data);
    }
}
