using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using ProjectOmega.Data.Models.Client;

namespace ProjectOmega.Repositories.ClientsRepository
{
    public class ClientsRepository : IClientsRepository
    {
        public ClientModel GetById(long id)
        {
           var responseFromFile = GetFromFile(@"C:\Users\Maciek\Desktop\raks.txt");
           ClientModel client = JsonConvert.DeserializeObject<ClientModel>(responseFromFile);
           return client;
        }

        public IEnumerable<ClientModel> GetAll()
        {
            var responseFromFile = GetFromFile(@"C:\Users\Maciek\Desktop\raksList.txt");
            List<ClientModel> clients = JsonConvert.DeserializeObject<List<ClientModel>>(responseFromFile);
            return clients;
        }

        public string GetFromFile(string path)
        {
            string responseFromFile;
            using (StreamReader sr = new StreamReader(path))
            {
                responseFromFile = sr.ReadToEnd();
            }
            return responseFromFile;
        }

        public string GetFromApi(string routePath)
        {
            WebRequest request = WebRequest.Create(routePath);
            request.UseDefaultCredentials = true;
            request.PreAuthenticate = true;
            request.Credentials = CredentialCache.DefaultCredentials;

            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();
            return responseFromServer;
        }
    }
}
