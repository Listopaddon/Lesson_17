﻿namespace Lesson_17.Models.Domain
{
    [Serializable]
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public TypeProducts Type { get; set; }

        public Product() { }
        public Product(int id ,string name, decimal price, int quantity, TypeProducts type)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
            Type = type;
        }
    }
}
