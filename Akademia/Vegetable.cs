namespace Akademia {

    public class Vegetable : Product, ISoldByWeight {

        public float Weight { get; set; }

        public override decimal Price {
            get {
                // Cena = cena za kilogram * waga
                return decimal.Round(base.Price * (decimal)Weight, 2);
            }
        }

        public Vegetable(string name, decimal price, float weight) : base(name, price) {
            Weight = weight;
        }

        public decimal GetPricePerKilogram() {
            return base.Price;
        }
    }
}
