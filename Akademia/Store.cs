using System;

namespace Akademia {

    public class Store {

        private Checkout[] checkouts;

        public Store(Checkout[] checkouts) {
            this.checkouts = checkouts;
        }

        public void Shop() {

            Console.WriteLine("Witamy!");

            // Zbieranie produktów do koszyka
            Product[] cart = {
                new Product("Masło", 3.99m),
                new Product("Kabanosy XXL", 4.49m),
                new Vegetable("Papryka czerwona", 7.99m, .34f),
                new Product("Karkówka wieprzowa", 8.16m)
            };

            // Wybieranie kasy
            Checkout checkout = GetCheckout();
            checkout.Start();

            // Skanownie produktów
            foreach (var product in cart) {
                Sleep(400);
                checkout.Scan(product);
            }

            // Dokonywanie płatności
            while (!checkout.MakePayment()) ;

            Console.WriteLine("Dziękujemy i zapraszamy ponownie!");
        }

        private Checkout GetCheckout() {
            if (checkouts == null || checkouts.Length == 0)
                throw new InvalidOperationException("Brak dostępnych kas");

            Console.WriteLine($"Wybierz kasę (0-{checkouts.Length - 1}):");
            while (true) {
                string read = Console.ReadLine();
                if (!int.TryParse(read, out int index) || index < 0 || index >= checkouts.Length) {
                    Console.WriteLine($"Nieprawidłowy numer kasy. Spróbuj ponownie (0-{checkouts.Length - 1}):");
                    continue;
                }

                return checkouts[index];
            }
        }

        private void Sleep(int milliseconds) {
            System.Threading.Thread.Sleep(milliseconds);
        }
    }
}
