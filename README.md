# 🔐 C# REST API with OAuth 2.0
It's an client-themed REST API Template with OAuth 2.0 implemented in a built-in Identity Server (as a class) with user hierarchy.
## 📝 OAuth 2.0 Explanation
OAuth 2.0 is an token-based authentication protocol. It's implementation consists in having an Authentication Server (OAuth Server) and a Resource Server.
As you can see in the image, the process is split in two, the green part would be the authentication part where the OAuth 2.0 protocol takes place and the orange one, where the authorization takes place.\
<img src="/RepositoryResources/oauthprocess.png" width="500" alt="OAuth 2.0 Protocol Explanation Process">
## 📖 About the project
This is a functional Template where you have 2 sections (controllers):
- Login: it contains the Login Endpoint, where you need to introduce your user credentials in order to get a session Token.
- Endpoints: it contains the rest of endpoints of the API, it only includes two, one can be executed with a non-admin account but the other one requires administrator permissions.
## 📂 Files
The main files of the project are:
- [Program.cs](https://github.com/LuisMiSanVe/OAuth_API/blob/oauthonly/OAuth_API/Program.cs): has the main configuration of the project and works as the Resource Server.
- [Users.cs](https://github.com/LuisMiSanVe/OAuth_API/blob/oauthonly/OAuth_API/Users.cs): provisional class that have declared the different users and it's permissions.
> [!WARNING]
> Users are hardcoded, is recomendable to replace it with an actual database of users.
- [Model/Client.cs](https://github.com/LuisMiSanVe/OAuth_API/blob/oauthonly/OAuth_API/Model/Client.cs): is the scheme or model of the object that our endpoint retrieve.
- [Controllers/EndpointsController.cs](https://github.com/LuisMiSanVe/OAuth_API/blob/oauthonly/OAuth_API/Controllers/EndpointsController.cs): It's the controller where the endspoints are contained.
- [Controllers/LoginController.cs](https://github.com/LuisMiSanVe/OAuth_API/blob/oauthonly/OAuth_API/Controllers/LoginController.cs): It's the controller where the Login endpoint is contained and works as the Authentication Server.
## 🚀 Project Usage Explanation
Using the image above as guiance, the green part, as I said earlier, is the authentication process, it happens when a client logs in successfully and gets an JWT Bearer-type Token.\
Meanwhile the orange part, the authorization process, ocurs when the client, already logged in, tries to access a endpoint, and if the token is valid, it returns the resources given by the endpoint.\
This repository is meant to be used as a template for your new securized REST API.
> This is a summary of the [Documentation](/RepositoryResources/Documentation.pdf) which includes a short guide.
## 💻 Technologies used
- Programming Lenguage: [C#](https://dotnet.microsoft.com/en-us/languages/csharp)
- Framework: [ASP.NET Core](https://dotnet.microsoft.com/en-us/apps/aspnet) (Project made with [.Net](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet) 8.0 Framework)
- NuGets:
  - [Swashbuckle.AspNetCore](https://github.com/domaindrivendev/Swashbuckle.AspNetCore) (6.4.0)
  - [Swashbuckle.AspNetCore.Annotations](https://github.com/domaindrivendev/Swashbuckle.AspNetCore?tab=readme-ov-file#swashbuckleaspnetcoreannotations) (6.6.2)
  - [Microsoft.AspNetCore.authentication.JwtBearer](https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.JwtBearer) (8.0.6)
- Other:
  - [OAuth 2.0](https://oauth.net/2/) (Protocol)
  - [JWT Bearer](https://jwt.io/introduction) (Token type)
- Recommended IDE: [Visual Studio](https://visualstudio.microsoft.com/) 2022
