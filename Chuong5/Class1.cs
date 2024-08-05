

namespace Chuong5
{
    public class Item
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Item()
        {
            
        }

        public double TotalValue()
        {
            return Price * Quantity;
        }
        public void input()
        {
            Console.WriteLine("moi ban nhap id");
            Id = Console.ReadLine();
            Console.WriteLine("moi ban nhap ten");
            Name = Console.ReadLine();
            Console.WriteLine("moi ban nhap gia");
            Price = double.Parse(Console.ReadLine());
            Console.WriteLine("moi ban nhap so luong");
            Quantity = int.Parse(Console.ReadLine());
            

        }

        public void output()
        {
            Console.WriteLine($"Id: {Id}, \t Name: {Name}, \t Price: {Price}, \t Quantity: {Quantity} \t Total: {Price*Quantity}");

        }
    }
}
