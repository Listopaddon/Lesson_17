namespace Lesson_17.Models.Domain
{
    public class Wood : Product
    {
        public Wood(string name, decimal price, int quantity) : base(name, price, quantity, TypeProducts.Wood) { }
    }
}
