using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoAPI.Entities.Sevices
{
    internal class ContatoServices
    {
        public async Task<Contato> Integracao(int id)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://localhost:7041/Contato/{id}");
            var jsonString = await response.Content.ReadAsStringAsync();

            // Converte o Json recebido para o objeto Contato
            Contato jsonObject = JsonConvert.DeserializeObject<Contato>(jsonString);

            if(jsonObject.Nome != null)
            {
                return jsonObject;
            }
            else
            {
                return new Contato
                {
                    Verificacao = true
                };
            }
        }
    }
}
