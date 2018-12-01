using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectOmega.DAL.Firebird
{
    class Program
    {
        private static readonly ProjectOmega.DAL.Firebird.ClientsRepository.ClientsRepository _clientsRepository = new ProjectOmega.DAL.Firebird.ClientsRepository.ClientsRepository();

        static void Main(string[] args)
        {

            var client = _clientsRepository.GetById(5);
            Console.WriteLine(client.SHORT_NAME, client.STREET);
        
            Console.ReadLine();
        }
    }
}
