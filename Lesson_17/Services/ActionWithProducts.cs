using Lesson_17.Models.Domain;

namespace Lesson_17.Services
{
    public class ActionWithProducts
    {
        Inventory inventory;
        public ActionWithProducts(Inventory inventory)
        {
            this.inventory = inventory;
        }

        public void AddProduct(Product product)
        {
            inventory.products.Add(product);
        }

        public void AddSomeProducts(List<Product> products)
        {
            foreach (Product product in products)
            {
                inventory.products.Add(product);
            }
        }

        public List<Product> GetAllProducts()
        {
            return inventory.products;
        }

        public Product Get(int id)
        {
            return inventory.products.Single(x => x.Id == id);
        }

        public void ReplaceProduct(Product productNew)
        {
            Product product = Get(productNew.Id);

            product.Name = productNew.Name;
            product.Price = productNew.Price;
            product.Quantity = productNew.Quantity;
            product.Type = productNew.Type;

        }

        public void DeleteProduct(int id)
        {
            Product product = Get(id);
            inventory.products.Remove(product);
        }

        public decimal SummAllProducts()
        {
            decimal result = 0;
            foreach (Product product in inventory.products)
            {
                result += product.Price;
            }

            return result;
        }

        public decimal SummProductsOnType(TypeProducts type)
        {
            decimal result = 0;
            foreach (Product product in inventory.products)
            {
                if (product.Type == type)
                {
                    result += product.Price;
                }
            }

            return result;
        }
    }
}
