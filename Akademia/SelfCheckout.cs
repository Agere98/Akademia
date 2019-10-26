using System;

namespace Akademia {

    class SelfCheckout : Checkout {

        public override bool MakePayment() {

            // Wyświetlenie sumy
            PrintTotal();

            // Kasa samoobsługowa - płatność tylko kartą
            return CreditCardPayment();
        }

        private bool CreditCardPayment() {
            Console.WriteLine($"Płatność kartą - pobrano {Total}zł");
            return true;
        }

        public override void Scan(Product product) {
            base.Scan(product);
            Console.WriteLine("Włóż towar do pojemnika");
        }
    }
}
