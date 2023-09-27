namespace KB11799_BlazorWasmApp1.Data;

public class ProductsDataService
{
    public Task<Product[]> GetProductsAsync()
    {
        return Task.FromResult(new List<Product>()
        {
            new () { ProductID = 0, ProductName = "えんぴつ", StockedAmount = 50 },
            new () { ProductID = 1, ProductName = "3色ボールペン", StockedAmount = 31 },
            new () { ProductID = 2, ProductName = "のり", StockedAmount = 37 },
            new () { ProductID = 3, ProductName = "定規", StockedAmount = 6 },
            new () { ProductID = 4, ProductName = "リングファイル", StockedAmount = 62 },
            new () { ProductID = 5, ProductName = "ノート", StockedAmount = 59 },
            new () { ProductID = 6, ProductName = "筆箱", StockedAmount = 94 },
            new () { ProductID = 7, ProductName = "消しゴム", StockedAmount = 4 },
            new () { ProductID = 8, ProductName = "マジックペン", StockedAmount = 21 },
            new () { ProductID = 9, ProductName = "ネックストラップ", StockedAmount = 38 }
        }.ToArray());
    }
}
