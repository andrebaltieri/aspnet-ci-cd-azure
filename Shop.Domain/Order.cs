using System;

namespace Shop.Domain
{
    public class Order
    {
        public Order(decimal price)
        {
            Id = Guid.NewGuid();
            Number = Id.ToString().Substring(0, 8).ToLower();
            Price = price;

            if (price <= 0)
                throw new ArgumentException("Preço inválido");
        }

        public Guid Id { get; private set; }
        public string Number { get; set; }
        public decimal Price { get; private set; }
    }
}
