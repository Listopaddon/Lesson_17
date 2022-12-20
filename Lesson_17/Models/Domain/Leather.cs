namespace Lesson_17.Models.Domain
{
    public class Leather : Product
    {
        public Leather(int id,string name, decimal price, int quantity) : base(id,name, price, quantity, TypeProducts.Leather) { }
    }
}
