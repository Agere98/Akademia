using System;

namespace Akademia {

    class StaffedCheckout : Checkout {

        public override bool MakePayment() {

            // Wyświetlenie sumy
            PrintTotal();

            // Wybór metody płatności
            int paymentMethod = ChoosePaymentMethod();
            if (paymentMethod == 1)
                return CashPayment();
            if (paymentMethod == 2)
                return CreditCardPayment();

            return false;
        }

        private int ChoosePaymentMethod() {
            Console.WriteLine("Wybierz metodę płatności (1 - gotówka, 2 - karta):");
            while (true) {
                string read = Console.ReadLine();
                if (!int.TryParse(read, out int method) || method < 0 || method > 2) {
                    Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie (1 - gotówka, 2 - karta):");
                    continue;
                }

                return method;
            }
        }

        private bool CreditCardPayment() {
            Console.WriteLine($"Płatność kartą - pobrano {Total}zł");
            return true;
        }

        private bool CashPayment() {
            Console.WriteLine("Płatność gotówką - podaj kwotę:");
            decimal cash = GetCash();
            if (cash < Total) {
                Console.WriteLine($"Niewłaściwa kwota, spróbuj ponownie");
                return false;
            }
            Console.WriteLine($"Płatność zaakceptowana - wydano {cash - Total}zł reszty");
            return true;
        }

        private decimal GetCash() {
            string read = Console.ReadLine();
            if (decimal.TryParse(read, out decimal cash)) {
                return cash;
            }
            return 0m;
        }
    }
}
