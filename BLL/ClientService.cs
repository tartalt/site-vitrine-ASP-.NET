using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL.Client;
using DAL.Repos;
using Models.Auth;


namespace BLL
{
    public class ClientService
    {
        ClientRepo clientrepo = new ClientRepo();

        public void CreateClient(ClientCreateVM clientCreateVM)
        {
            Client Client = new Client();
            Client.Name = clientCreateVM.Name;
            Client.Email = clientCreateVM.Email;
            Client.Password = clientCreateVM.Password;
            clientrepo.Create(Client);
        }

        public ClientDetailVM DetailsClient(int id)
        {
            Client client = clientrepo.Read(id);
            var detail = new ClientDetailVM
            {
                Email = client.Email,
                Name = client.Name,
                
                Id = client.Id
            };
            return detail;
        }
        public void UpdateClient(ClientUpdateVM clientUpdateVM)
        {
            Client Client = new Client();
            Client.Name = clientUpdateVM.Name;
            Client.Email = clientUpdateVM.Email;
            Client.Password = clientUpdateVM.Password;
            clientrepo.Update(Client);
        }
        public UserSession? VerifierCompte(UserAuthVM obj)
        {
            var result = clientrepo.All()
                        .FirstOrDefault(a => a.Password == obj.MotPasse && a.Email == obj.Email);
            if (result != null)
            {
                UserSession userSession = new UserSession();
                userSession.AdresseMail = result.Email;
                userSession.Id = result.Id;
                userSession.Nom = result.Name;
                
              

                return userSession;
            }
            return null;
        }


    }
}