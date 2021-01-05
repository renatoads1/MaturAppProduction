using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Matur.Services
{
    public class UserService : Service
    {
        public async Task<string> GetUser(string email, string password ) {

            //HttpResponseMessage  resopese = await _client.GetAsync($"{BaseUri} ?user={email}&senha={password}");
            HttpResponseMessage  resopese = await _client.GetAsync($"{BaseUri}Autenticacaos?user={email}&password={password}");
            if (resopese.IsSuccessStatusCode == true) {
                //ler conteudo
                string content = await resopese.Content.ReadAsStringAsync();
                //deserializa para objeto user
                //User content = await resopese.Content.ReadAsAsync<User>();
                //deserializar json
                return content;
            }
            return "";
        }
    }
}
