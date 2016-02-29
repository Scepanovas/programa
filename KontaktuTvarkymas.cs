using RestSharp;
using spammaster.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace spammaster
{

    public class KontaktuTvarkymas
    {
        public List<Kontaktai> GetContacts(int pageSize, int page)
        {
            var client = new RestClient("https://api.sendgrid.com/v3/contactdb");
            var request = new RestRequest("recipients", Method.GET);
            if (pageSize < 1 || pageSize > 1000) pageSize = 100;
            if (page < 1) page = 1;
            request.AddParameter("page_size", pageSize); // adds to POST or URL querystring based on Method
            request.AddParameter("page", page); // adds to POST or URL querystring based on Method

            // add HTTP Headers
            request.AddHeader("Authorization", String.Format("Bearer {0}", Settings.Default["key"]));

            // automatically deserialize result
            // return content type is sniffed but can be explicitly set via RestClient.AddHandler();
            IRestResponse<RecipientsList> response2 = client.Execute<RecipientsList>(request);

            if (response2.Data != null && response2.Data.recipients != null)
                return response2.Data.recipients.ToList();
            else
                return null;
        }
        public List<Kontaktai> GetContactsFromList(int listId)
        {
            var client = new RestClient("https://api.sendgrid.com/v3/contactdb");
            //client.Authenticator = new HttpBasicAuthenticator(username, password);

            var request = new RestRequest("lists/" + listId + "/recipients", Method.GET); // ?page_size=100&page=1
            request.AddParameter("page_size", "100"); // adds to POST or URL querystring based on Method
            request.AddParameter("page", "1"); // adds to POST or URL querystring based on Method
            //request.AddUrlSegment("page", "1"); // replaces matching token in request.Resource

            // add HTTP Headers
            request.AddHeader("Authorization", String.Format("Bearer {0}", Settings.Default["key"]));

            // execute the request
            //IRestResponse response = client.Execute(request);
            //var content = response.Content; // raw content as string

            // OR automatically deserialize result
            // return content type is sniffed but can be explicitly set via RestClient.AddHandler();
            IRestResponse<RecipientsList> response2 = client.Execute<RecipientsList>(request);
            var h = response2.Headers;
            //var recipients = response2.Data.recipients;

            if (response2.Data != null)
                return response2.Data.recipients.ToList();
            else
                return new List<Kontaktai>();
        }



        /// <param name="contact"> </param>
        /// <returns></returns>
        public EditContactsResponse EditContact(Kontaktai contact)
        {
            Kontaktai[] contactArray = new Kontaktai[] { contact };

            var client = new RestClient("https://api.sendgrid.com/v3/contactdb");
            //client.Authenticator = new HttpBasicAuthenticator(username, password);

            var request = new RestRequest("recipients");
            if (String.IsNullOrEmpty(contact.id))
                request.Method = Method.POST;
            else
                request.Method = Method.PATCH;

            request.AddHeader("Authorization", String.Format("Bearer {0}", Settings.Default["key"]));

            request.RequestFormat = DataFormat.Json;
            request.AddBody(contactArray);

            //// execute the request
            IRestResponse response = client.Execute(request);
            //var content = response.Content; // raw content as string

            EditContactsResponse contentJson = Newtonsoft.Json.JsonConvert.DeserializeObject<EditContactsResponse>(response.Content);

            return contentJson;
        }

        public String DeleteContact(Kontaktai contact)
        {
            string[] contactIdArray = new string[] { contact.id };

            var client = new RestClient("https://api.sendgrid.com/v3/contactdb");
            //client.Authenticator = new HttpBasicAuthenticator(username, password);

            var request = new RestRequest("recipients", Method.DELETE);
            // add HTTP Headers
            request.AddHeader("Authorization", String.Format("Bearer {0}", Settings.Default["key"]));

            request.RequestFormat = DataFormat.Json;
            request.AddBody(contactIdArray);

            // execute the request
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return String.Empty;
            }
            else
                return response.StatusDescription;
        }

    }
}
