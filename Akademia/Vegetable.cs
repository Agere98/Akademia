namespace Akademia {

    public class Vegetable : Product {

        public float weight;

        public Vegetable(string name, decimal price, float weight) : base(name, price) {
            this.weight = weight;
        }
    }
}
