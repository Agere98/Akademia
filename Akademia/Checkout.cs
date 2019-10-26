using System;

namespace Akademia {

    abstract class Checkout {

        public decimal Total { get; private set; }

        public void Start() {
            Console.WriteLine("Skanowanie produktów...");
            Total = 0;
        }

        public virtual void Scan(Product product) {
            Console.WriteLine($"\t{product.Name, -32}  {product.GetHashCode(), 8}  {product.Price, 6}");

            // W przypadku produktów sprzedawanych na wagę wyświetl szczegółowe informacje
            if (product is ISoldByWeight soldByWeight) {
                Console.WriteLine($"\t{$"{soldByWeight.Weight, 5}kg * {soldByWeight.GetPricePerKilogram()}zł/kg", 50}");
            }

            Total += product.Price;
        }

        protected void PrintTotal() {
            Console.WriteLine($"\t{"Suma:", 40}  {Total, 8}");
        }

        public abstract bool MakePayment();
    }
}
