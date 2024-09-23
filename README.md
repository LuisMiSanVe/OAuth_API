# C# REST API with OAuth 2.0
It's an client-themed REST API Template with OAuth 2.0 implemented in a built-in Identity Server (as a class) with user hierarchy.
## OAuth 2.0 Explanation
OAuth 2.0 is an token-based authentication protocol. It's implementation consists in having an Authentication Server (OAuth Server) and a Resource Server.
As you can see in the image, the process is split in two, the green part would be the authentication part where the OAuth 2.0 protocol takes place and the orange one, where the authorization takes place.
![OAuth 2.0 Protocol Explanation Process](https://github.com/LuisMiSanVe/OAuth_API/blob/main/RepositoryResources/oauthprocess.png)
## About the project
This is a functional Template where you have 2 sections (controllers):
- Login: it contains the Login Endpoint, where you need to introduce your user credentials in order to get a session Token.
- Endpoints: it contains the rest of endpoints of the API, it only includes two, one can be executed with a non-admin account but the other one requires administrator permissions.
## Files
The main files of the project are:
- Program.cs: has the main configuration of the project and works as the Resource Server.
- Users.cs: provisional class that have declared the different users and it's permissions.
> [!WARNING]
> Users are hardcoded, is recomendable to replace it with an actual database of users server.
- Model/Client.cs: is the scheme or model of the object that our endpoint retrieve.
- Controllers/EndpointsController.cs: It's the controller where the endspoints are contained.
- Controllers/LoginController.cs: It's the controller where the Login endpoint is contained and works as the Authentication Server.
## Project Usage Explanation
Using the image above as guiance, the green part, as I said earlier, is the authentication process, it happens when a client logs in successfully and gets an Token.
Meanwhile the orange part, the authorization process, ocurs when the client, already logged in, tries to access a endpoint, and if the token is valid, it returns the resources given by the endpoint.
> This is a summary of the [Documentation]() which has a guide included.
