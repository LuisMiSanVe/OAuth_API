> [Ver en ingles/See in english](https://github.com/LuisMiSanVe/OAuth_API/tree/main)
# 🔐 C# REST API con OAuth 2.0
[![image](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)](https://dotnet.microsoft.com/en-us/languages/csharp)
[![image](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet)
[![image](https://img.shields.io/badge/Swagger-85EA2D?style=for-the-badge&logo=Swagger&logoColor=white)](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)
[![image](https://img.shields.io/badge/JWT-000000?style=for-the-badge&logo=JSON%20web%20tokens&logoColor=white)](https://jwt.io/introduction)
[![image](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white)](https://visualstudio.microsoft.com/)

REST API tematizada de Clientes con OAuth 2.0 implementado y un Servidor de Identidad integrado (como una clase) con jerarquia de usuarios.
## 📝 Explicación de OAuth 2.0
OAuth 2.0 es un protocolo basado en la verificación por tokens. Su implementación requiere un Servidor de Autentificación (Servidor OAuth) y el Servidor de Recursos.
Como se puede ver en la imagen, el proceso se diferencia en dos partes, la verde sería la autentificación donde el protocolo de OAuth 2.0 está en funcionamiento y la parte naranja, donde la autorización ocurre.\
<img src="https://github.com/LuisMiSanVe/LuisMiSanVe/blob/main/Resources/OauthAPI/oauthprocess.png" width="500" alt="Explicación del proceso del protocolo OAuth 2.0">

Fuente: [Oracle](https://docs.oracle.com/cd/B31315_01/191000/BDI%20Implementation%20Guide/Output/oauth.htm)
## 📖 Sobre el proyecto
Es una plantilla funcional con dos secciones (Controladores):
- Login: contiene el endpoint de Inicio de Sesión, donde debes poner las credenciales de tu usuario para conseguir un token de sesión.
- Endpoints: contiene el resto de endpoints de la API, incluye dos, uno puede ejecutarlo cualquier usuario pero el otro requiere de permisos de Administrador.
## 📂 Archivos
Los archivos principales del proyecto son:
- [Program.cs](https://github.com/LuisMiSanVe/OAuth_API/blob/main/OAuth_API/Program.cs): tiene la configuración principal y funciona como el Servidor de Recursos.
- [Users.cs](https://github.com/LuisMiSanVe/OAuth_API/blob/main/OAuth_API/Users.cs): clase provisional con los usuarios y los permisos de estos declarados.
> [!WARNING]
> Los usuarios están hardcodeados, es recomendable reemplazarlo con una base de datos de usuarios real.
- [Model/Client.cs](https://github.com/LuisMiSanVe/OAuth_API/blob/main/OAuth_API/Model/Client.cs): es el la plantilla o esquema del objeto que devuelve la API.
- [Controllers/EndpointsController.cs](https://github.com/LuisMiSanVe/OAuth_API/blob/main/OAuth_API/Controllers/EndpointsController.cs): El controlador que contiene los endpoints.
- [Controllers/LoginController.cs](https://github.com/LuisMiSanVe/OAuth_API/blob/main/OAuth_API/Controllers/LoginController.cs): El controlador que contiene el endpoint de Inicio de Sesión, que funciona como el Servidor de Autentificación.
## 🚀 Explicación de uso del proyecto
Usando la imagen de arriba como guía, la parte verde, como expliqué antes, es el proceso de autentificación, este ocurre cuando el usuario inicia sesión correctamente y consigue un token tipo JWT Bearer.\
Mientras que la parte naranja, el proceso de autorización, ocurre cuando el usuario, con la sesión ya activa, intenta acceder un endpoint, y si el token es válido, devuelve el recurso solicitado por el endpoint.\
Este repositorio está pensado para ser una plantilla para tu nueva REST API securizada.

## 💻 Tecnologías usadas
- Lenguaje de programación: [C#](https://dotnet.microsoft.com/es-es/languages/csharp)
- Framework: [ASP.NET Core](https://dotnet.microsoft.com/es-es/apps/aspnet) (Proyecto creado con el Framework [.Net](https://dotnet.microsoft.com/es-es/learn/dotnet/what-is-dotnet) 8.0)
- NuGets:
  - [Swashbuckle.AspNetCore](https://github.com/domaindrivendev/Swashbuckle.AspNetCore) (6.4.0)
  - [Swashbuckle.AspNetCore.Annotations](https://github.com/domaindrivendev/Swashbuckle.AspNetCore?tab=readme-ov-file#swashbuckleaspnetcoreannotations) (6.6.2)
  - [Microsoft.AspNetCore.authentication.JwtBearer](https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.JwtBearer) (8.0.6)
- Otros:
  - [OAuth 2.0](https://oauth.net/2/) (Protocol)
  - [JWT Bearer](https://jwt.io/introduction) (Token type)
- IDE Recomendado: [Visual Studio](https://visualstudio.microsoft.com/) 2022
