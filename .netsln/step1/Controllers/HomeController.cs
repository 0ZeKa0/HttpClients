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

                    var formData = new Dictionary<string, string>
                {
                    { "FormKey", "givenformkeywashere" },   // FormKey değerini buraya ekleyin
                    { "Name", "Zehra Karakaya" },     // İsim değeri
                    { "Email", "zehrakarakayabm@gmail.com" }, // Email değeri
                    { "PhoneNumber", "1234567890" },  // Telefon numarası
                    { "GitAccount", "https://github.com/0ZeKa0" } // GitHub hesabı
                };

                    var content = new FormUrlEncodedContent(formData);

                    HttpResponseMessage response = await client.PostAsync(url, content);

                    string statusCode = response.StatusCode.ToString();
                    string responseText = await response.Content.ReadAsStringAsync();

                    return Content($"Status Code: {statusCode}\nResponse Text: {responseText}");
                }
            
        }
    }

}
}
