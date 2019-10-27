namespace Akademia {

    class Program {

        static void Main(string[] args) {

            Store store = new Store(new Checkout[6] {
                new StaffedCheckout(),
                new StaffedCheckout(),
                new StaffedCheckout(),
                new StaffedCheckout(),
                new SelfCheckout(),
                new SelfCheckout()
            });

            store.Shop();

            System.Console.ReadKey();
        }
    }
}
