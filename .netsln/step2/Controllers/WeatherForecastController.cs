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

                // Authorization baþlýðýný ekleyin
                client.DefaultRequestHeaders.Add("Authorization", "key"); // Authorization key'i buraya ekleyin

                // POST isteðini gönderin
                HttpResponseMessage response = await client.PostAsync(url, null);

                // Yanýtý alýn ve metin olarak okuyun
                string responseText = await response.Content.ReadAsStringAsync();

                // Alternatif olarak, yanýtý Content olarak döndürebilirsiniz
                return Content(responseText);
            }
        }
    }
}
