namespace Lesson_17.Models.Domain
{
    public class Chemicals : Product
    {
        public Chemicals(string name, decimal price, int quantity) : base(name, price, quantity, TypeProducts.Chemicals) { }
    }
}
