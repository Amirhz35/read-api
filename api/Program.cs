using api;


Api.InitializeClient();

var priceinfo = await gettingurl.geturl();

Console.WriteLine($"name: {priceinfo.symbol}\n buy price: {priceinfo.buy}\n sell price: {priceinfo.sell}\n " +
    $"highest price: {priceinfo.high}\n lowest price: {priceinfo.low}\n average price: {priceinfo.averagePrice}\n lastest price: {priceinfo.last} ");
