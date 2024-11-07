> [Ver en ingles/See in english](https://github.com/LuisMiSanVe/OAuth_API/tree/main)
# 🔐 C# REST API con OAuth 2.0
REST API tematizada de Clientes con OAuth 2.0 implementado y un Servidor de Identidad integrado (como una clase) con jerarquia de usuarios.
## 📝 Explicación de OAuth 2.0
OAuth 2.0 es un protocolo basado en la verificación por tokens. Su implementación requiere un Servidor de Autentificación (Servidor OAuth) y el Servidor de Recursos.
Como se puede ver en la imagen, el proceso se diferencia en dos partes, la verde sería la autentificación donde el protocolo de OAuth 2.0 está en funcionamiento y la parte naranja, donde la autorización ocurre.\
<img src="/RepositoryResources/oauthprocess.png" width="500" alt="Explicación del proceso del protocolo OAuth 2.0">
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
> Este es un resumen de la [Documentación](/RepositoryResources/Documentation.pdf) que incluye una pequeña guia.

## 🎨 Opciones de Personalización
Muchas de las opciones del Swagger de Swashbuckle están incluidos en la plantilla.\
Cosas como tener más de un documento de Swagger, nombres personalizados para controladores y endpoints, una barra de busqueda e incluso CSS personalizables.\
La mayoría de estas opciones pueden ser cambiadas en [OAuth_API/Program.cs](https://github.com/LuisMiSanVe/OAuth_API/blob/main/OAuth_API/Program.cs) dentro de la expresión lambda `app.UseSwaggerUI(options =>`.<br> 
Para añadir ficheros personalizados como imagenes o hojas de estilo, necesitarás ponerlas en la carpeta especial [wwwroot](https://github.com/LuisMiSanVe/OAuth_API/tree/main/OAuth_API/wwwroot). Un archivo .css vacio ya viene creado.
> Si solo te interesan las configuraciones de securización, usa la rama de [oauthonly](https://github.com/LuisMiSanVe/OAuth_API/tree/oauthonly) (Solo ingles).
## 💻 Tecnologías usadas
- Lenguaje de programación: C#
- Framework: ASP.NET Core (Proyecto creado con el Framework .Net 8.0)
- NuGets:
  - Swashbuckle.AspNetCore (6.4.0)
  - Swashbuckle.AspNetCore.Annotations (6.6.2)
  - Microsoft.AspNetCore.authentication.JwtBearer (8.0.6)
- Otros:
  - OAuth 2.0 (Protocolo)
  - JWT Bearer (Tipo de Token)
- IDE Recomendado: Visual Studio 2022
