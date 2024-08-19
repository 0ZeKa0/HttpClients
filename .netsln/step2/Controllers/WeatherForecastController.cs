using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace step2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public async Task<ActionResult> SendRequest()
        {
            using (HttpClient client = new HttpClient())
            {
                // URL'yi belirtin
                string url = "https://example.com/api/resource"; // API URL'sini buraya ekleyin

                // Authorization ba�l���n� ekleyin
                client.DefaultRequestHeaders.Add("Authorization", "key"); // Authorization key'i buraya ekleyin

                // POST iste�ini g�nderin
                HttpResponseMessage response = await client.PostAsync(url, null);

                // Yan�t� al�n ve metin olarak okuyun
                string responseText = await response.Content.ReadAsStringAsync();

                // Alternatif olarak, yan�t� Content olarak d�nd�rebilirsiniz
                return Content(responseText);
            }
        }
    }
}
