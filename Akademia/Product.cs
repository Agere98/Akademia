namespace Akademia {

    public class Product {

        public string name;
        public decimal price;
        //public string Name { get; set; }
        //public virtual decimal Price { get; set; }

        public Product(string name, decimal price) {
            this.name = name;
            this.price = price;
            //Name = name;
            //Price = price;
        }
    }
}
