using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api
{
    public class gettingurl
    {

        public static async Task<pricemodel> geturl()
        {
            string url = "https://api.kucoin.com/api/v1/market/stats?symbol=BTC-USDT";
            using (HttpResponseMessage response = await Api.apiclient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    resultsmodel result = await response.Content.ReadAsAsync<resultsmodel>();
                    return result.data;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
                
            
        }
    }
}
