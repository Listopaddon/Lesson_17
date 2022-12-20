namespace Lesson_17.Models.Domain
{
    public class Chemicals : Product
    {
        public Chemicals(int id, string name, decimal price, int quantity) : base(id, name, price, quantity, TypeProducts.Chemicals) { }
    }
}
