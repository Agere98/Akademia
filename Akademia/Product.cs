namespace Akademia {

    public class Product {

        public string Name { get; set; }
        public virtual decimal Price { get; set; }

        public Product(string name, decimal price) {
            Name = name;
            Price = price;
        }
    }
}
