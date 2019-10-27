namespace Akademia {

    public interface ISoldByWeight {

        float Weight { get; set; }

        decimal GetPricePerKilogram();
    }
}
