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
              
                string url = "https://example.com/api/resource"; // API URL'sini buraya ekleyin

               
                client.DefaultRequestHeaders.Add("Authorization", "key"); // Authorization key'i buraya ekleyin

                
                HttpResponseMessage response = await client.PostAsync(url, null);

               
                string responseText = await response.Content.ReadAsStringAsync();

                // Alternatif olarak, yanýtý Content olarak döndürebilirsiniz
                return Content(responseText);
            }
        }
    }
}
