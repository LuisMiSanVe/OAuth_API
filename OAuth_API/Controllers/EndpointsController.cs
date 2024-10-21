using Microsoft.AspNetCore.Mvc;
using OAuth_API.Model;
using Microsoft.AspNetCore.Authorization;
using Swashbuckle.AspNetCore.Annotations;

namespace OAuth_API.Controllers
{
    [Tags("Default Endspoints")] // Name of the Controller that will be displayed on the Swagger Document
    //[Authorize] // All of Controller's Endpoints need to log in
    [ApiController]
    [ApiExplorerSettings(GroupName = "main")] // Document where the Controller belongs to (Remove/Comment to make Controller appear in all Documents)
    [Route("[controller]")]
    public class EndpointsController : ControllerBase
    {
        #region GET

        [Authorize]
        [SwaggerResponse(200, ContentTypes = new string[] { "Client" })] // Custom return type to avoid Swagger to display the object attributes.
        [SwaggerResponse(401, Description = "Needs to login")]
        [SwaggerResponse(403, Description = "Needs to login as Administrator")]
        [Route("api/[controller]/GetClients")]
        [SwaggerOperation(Summary = "Get Clients", Description = "[Needs to log in with an normal account at least]\n\nIf specified, throws the client with that code (if it exists); otherwise, throws all clients.")]
        [ActionName("GetClients")] // Name of the Endpoint that will be displayed on the Swagger Document
        [HttpGet]
        public Client GetClients(string? code)
        {
            Client resultado = new Client();

            List<GetClient> Result = new List<GetClient>();
            string Error = "";

            try
            {
                GetClient client1 = new GetClient();
                client1.code = "1";
                client1.name = "Client 01";
                client1.street = "1's street";
                client1.city = "Madrid";
                client1.countrycode = "ES";
                client1.phone = "+34 111 111 111";

                GetClient client2 = new GetClient();
                client2.code = "2";
                client2.name = "Client 02";
                client2.street = "2's street";
                client2.city = "Barcelona";
                client2.countrycode = "ES";
                client2.phone = "+34 222 222 222";

                GetClient[] clients = { client1, client2 };

                foreach(GetClient client in clients)
                    if (code == null || client.code == code)
                        Result.Add(client);
            }
            catch (Exception ex)
            {
                Error = "Error: " + ex.Message + "" + ex.StackTrace;
            }

            resultado.clients = Result.ToArray();
            resultado.error = Error;

            return resultado;
        }

        [Authorize("Admin")]
        [SwaggerResponse(200, ContentTypes = new string[] { "Client" })] // Custom return type to avoid Swagger to display the object attributes.
        [SwaggerResponse(401, Description = "Needs to login")]
        [SwaggerResponse(403, Description = "Needs to login as Administrator")]
        [Route("api/[controller]/GetClientsAdmin")]
        [SwaggerOperation(Summary = "Get Clients Admin", Description = "[Needs to log in with an Administrator account at least]\n\nIf specified, throws the client with that code (if it exists); otherwise, throws all clients.")]
        [ActionName("GetClientsAdmin")] // Name of the Endpoint that will be displayed on the Swagger Document
        [HttpGet]
        public Client GetClientsAdmin(string? code)
        {
            Client resultado = new Client();

            List<GetClient> Result = new List<GetClient>();
            string Error = "";

            try
            {
                GetClient client1 = new GetClient();
                client1.code = "1";
                client1.name = "Client 01";
                client1.street = "1's street";
                client1.city = "Madrid";
                client1.countrycode = "ES";
                client1.phone = "+34 111 111 111";

                GetClient client2 = new GetClient();
                client2.code = "2";
                client2.name = "Client 02";
                client2.street = "2's street";
                client2.city = "Barcelona";
                client2.countrycode = "ES";
                client2.phone = "+34 222 222 222";

                GetClient[] clients = { client1, client2 };

                foreach (GetClient client in clients)
                    if (code == null || client.code == code)
                        Result.Add(client);
            }
            catch (Exception ex)
            {
                Error = "Error: " + ex.Message + "" + ex.StackTrace;
            }

            resultado.clients = Result.ToArray();
            resultado.error = Error;

            return resultado;
        }

        #endregion GET
    }
}
