> [See in spanish/Ver en español](https://github.com/LuisMiSanVe/OAuth_API/tree/spanish)
# 🔐 C# REST API with OAuth 2.0
[![image](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)](https://dotnet.microsoft.com/en-us/languages/csharp)
[![image](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet)
[![image](https://img.shields.io/badge/Swagger-85EA2D?style=for-the-badge&logo=Swagger&logoColor=white)](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)
[![image](https://img.shields.io/badge/JWT-000000?style=for-the-badge&logo=JSON%20web%20tokens&logoColor=white)](https://jwt.io/introduction)
[![image](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white)](https://visualstudio.microsoft.com/)

It's an client-themed REST API Template with OAuth 2.0 implemented in a built-in Identity Server (as a class) with user hierarchy.
## 📝 OAuth 2.0 Explanation
OAuth 2.0 is an token-based authentication protocol. It's implementation consists in having an Authentication Server (OAuth Server) and a Resource Server.
As you can see in the image, the process is split in two, the green part would be the authentication part where the OAuth 2.0 protocol takes place and the orange one, where the authorization takes place.\
<img src="https://github.com/LuisMiSanVe/LuisMiSanVe/blob/main/Resources/OauthAPI/oauthprocess.png" width="500" alt="OAuth 2.0 Protocol Explanation Process">
## 📖 About the project
This is a functional Template where you have 2 sections (controllers):
- Login: it contains the Login Endpoint, where you need to introduce your user credentials in order to get a session Token.
- Endpoints: it contains the rest of endpoints of the API, it only includes two, one can be executed with a non-admin account but the other one requires administrator permissions.
## 📂 Files
The main files of the project are:
- [Program.cs](https://github.com/LuisMiSanVe/OAuth_API/blob/main/OAuth_API/Program.cs): has the main configuration of the project and works as the Resource Server.
- [Users.cs](https://github.com/LuisMiSanVe/OAuth_API/blob/main/OAuth_API/Users.cs): provisional class that have declared the different users and it's permissions.
> [!WARNING]
> Users are hardcoded, is recomendable to replace it with an actual database of users.
- [Model/Client.cs](https://github.com/LuisMiSanVe/OAuth_API/blob/main/OAuth_API/Model/Client.cs): is the scheme or model of the object that our endpoint retrieve.
- [Controllers/EndpointsController.cs](https://github.com/LuisMiSanVe/OAuth_API/blob/main/OAuth_API/Controllers/EndpointsController.cs): It's the controller where the endspoints are contained.
- [Controllers/LoginController.cs](https://github.com/LuisMiSanVe/OAuth_API/blob/main/OAuth_API/Controllers/LoginController.cs): It's the controller where the Login endpoint is contained and works as the Authentication Server.
## 🚀 Project Usage Explanation
Using the image above as guiance, the green part, as I said earlier, is the authentication process, it happens when a client logs in successfully and gets an JWT Bearer-type Token.\
Meanwhile the orange part, the authorization process, ocurs when the client, already logged in, tries to access a endpoint, and if the token is valid, it returns the resources given by the endpoint.\
This repository is meant to be used as a template for your new securized REST API.
> This is a summary of the [Documentation](https://github.com/LuisMiSanVe/LuisMiSanVe/blob/main/Resources/OauthAPI/Documentation.pdf) which includes a short guide.

## 🎨 Customization Options
A bunch of the Swashbuckle's Swagger customization options are included in the template.\
Such as having more than one Swagger Document, Custom names for Controllers and Endpoints, a searchbox and even custom CSS.\
The majority of these options can be changed in [OAuth_API/Program.cs](https://github.com/LuisMiSanVe/OAuth_API/blob/main/OAuth_API/Program.cs) on the `app.UseSwaggerUI(options =>` lambda expresion.\
In order to add custom files like images or style sheets, you'll need to place them in the special folder [wwwroot](https://github.com/LuisMiSanVe/OAuth_API/tree/main/OAuth_API/wwwroot). An empty .css file is already created.
> If you're only interested in the security configurations, use the [oauthonly](https://github.com/LuisMiSanVe/OAuth_API/tree/oauthonly) branch.
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
