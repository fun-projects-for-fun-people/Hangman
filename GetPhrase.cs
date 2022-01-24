using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class GetPhrase
    {   
        public static async Task<PhraseModel> LoadPhrase()
        {
            string url = "http://quotes.stormconsultancy.co.uk/random.json";

            using (System.Net.Http.HttpResponseMessage response = await ApiClass.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    PhraseModel phrase = await response.Content.ReadAsAsync<PhraseModel>();

                    return phrase;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
