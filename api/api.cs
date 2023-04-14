using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace api
{
    public class Api
    {
        public static HttpClient apiclient { get; set; }
        public static void InitializeClient()
        {
            apiclient = new HttpClient();
            apiclient.DefaultRequestHeaders.Accept.Clear();
            apiclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        
    }
}
