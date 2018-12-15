
using System;
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
            #region api
            //WebRequest request = WebRequest.Create("");
            //WebResponse response = request.GetResponse();
            //Stream dataStream = response.GetResponseStream();
            //StreamReader reader = new StreamReader(dataStream);
            //string responseFromServer = reader.ReadToEnd();
            #endregion
            #region file
            string responseFromFile;
            using (StreamReader sr = new StreamReader(@"C:\Users\Maciek\Desktop\raks.txt"))
            {
                responseFromFile = sr.ReadToEnd();
            }
            #endregion
            ClientModel client = JsonConvert.DeserializeObject<ClientModel>(responseFromFile);
            return client;
        }

        public IEnumerable<ClientModel> GetAll()
        {
            #region file
            string responseFromFile;
            using (StreamReader sr = new StreamReader(@"C:\Users\Maciek\Desktop\raksList.txt"))
            {
                responseFromFile = sr.ReadToEnd();
            }
            #endregion

            List<ClientModel> clients = JsonConvert.DeserializeObject<List<ClientModel>>(responseFromFile);
            return clients;

        }
    }
}
