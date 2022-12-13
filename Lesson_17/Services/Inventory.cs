using Lesson_17.Models.Domain;
using System.Text.Json;

namespace Lesson_17.Services
{
    public class Inventory
    {
        public List<Product> products;
        public Inventory(string jsonFile)
        {
            string jsonString = File.ReadAllText(jsonFile);
            products = JsonSerializer.Deserialize<List<Product>>(jsonString)!;
        }
    }
}
