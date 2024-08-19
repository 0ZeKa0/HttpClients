using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace step1.Controllers
{
   
        public class FormController : Controller
        {
            // GET: Form/SubmitForm
            public async Task<ActionResult> SubmitForm()
            {
                // HttpClient'ı kullanarak POST isteği yapma
                using (HttpClient client = new HttpClient())
                {
                    // API URL'sini belirtin
                    string url = "https://example.com/api/submit"; // API URL'sini buraya ekleyin

                    // Form verilerini hazırlayın
                    var formData = new Dictionary<string, string>
                {
                    { "FormKey", "givenformkeywashere" },   // FormKey değerini buraya ekleyin
                    { "Name", "Zehra Karakaya" },     // İsim değeri
                    { "Email", "zehrakarakayabm@gmail.com" }, // Email değeri
                    { "PhoneNumber", "1234567890" },  // Telefon numarası
                    { "GitAccount", "https://github.com/0ZeKa0" } // GitHub hesabı
                };

                    // Form verilerini URL-encoded formatına çevirin
                    var content = new FormUrlEncodedContent(formData);

                    // POST isteğini gönderin
                    HttpResponseMessage response = await client.PostAsync(url, content);

                    // Yanıt durum kodunu ve içeriğini alın
                    string statusCode = response.StatusCode.ToString();
                    string responseText = await response.Content.ReadAsStringAsync();

                    // Yanıtı ViewBag ile View'a gönderebilirsiniz, fakat burada sadece Controller ile yapılacağı için direkt response döndürüyoruz.
                    return Content($"Status Code: {statusCode}\nResponse Text: {responseText}");
                }
            
        }
    }

}
}
