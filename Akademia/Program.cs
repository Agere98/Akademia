namespace Akademia {

    class Program {

        static void Main(string[] args) {

            var store = new Store(new Checkout[] {
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
