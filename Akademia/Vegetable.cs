namespace Akademia {

    public class Vegetable : Product/*, ISoldByWeight*/ {

        public float weight;

        //public float Weight { get; set; }
        
        //public override decimal Price {
        //    get {
        //        // Cena = cena za kilogram * waga
        //        return decimal.Round(base.Price * (decimal)Weight, 2);
        //    }
        //    set {
        //        // Przypisywanie ceny za kilogram
        //        base.Price = value;
        //    }
        //}

        public Vegetable(string name, decimal price, float weight) : base(name, price) {
            this.weight = weight;
        }

        //public decimal GetPricePerKilogram() {
        //    return base.price;
        //}
    }
}
