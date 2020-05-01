
using System.Globalization;

namespace ToDoOrder.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price{ get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
            Price = product.Price;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return $"{Product.Name}, R${Price.ToString("F2",CultureInfo.InvariantCulture)}, Quantity: {Quantity}, SubTotal: R${SubTotal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
