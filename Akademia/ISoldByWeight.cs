namespace Akademia {

    interface ISoldByWeight {

        float Weight { get; set; }

        decimal GetPricePerKilogram();
    }
}
