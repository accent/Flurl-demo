using Flurl.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlurlDemo
{
    public class Client
    {
        public async Task<T> GetDataUsingFlurl<T>(string url)
        {
            return await url.GetJsonAsync<T>();
        }
    }
}
