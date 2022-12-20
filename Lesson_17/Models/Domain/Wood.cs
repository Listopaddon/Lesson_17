namespace Lesson_17.Models.Domain
{
    public class Wood : Product
    {
        public Wood(int id, string name, decimal price, int quantity) : base(id,name, price, quantity, TypeProducts.Wood) { }
    }
}
