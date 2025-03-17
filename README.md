# Requisitos ⚠️

 Se requiere instalar estos componentes para correr el proyecto exitosamente:
 - dotnet-sdk-8.0.407-win-x64
 - dotnet-hosting-8.0.14-win
 - visual studio code o algún editor de código

 Para iniciar el servidor ejecutar el siguiente comando:

 ```bash
    dotnet restore
    dotnet run --launch-profile https
 ```
 Nota: El proyecto se desarrolló con .NET 7.0.

# Arquitectura  👷

    Este proyecto sigue un patrón MVC sin Vista, con el objetivo de crear un CRUD sencillo. La arquitectura está compuesta por:

 - Modelo de datos: Representa la estructura de la información con la que trabaja la aplicación.
 - Controlador: Maneja las solicitudes HTTP, ejecuta la lógica de negocio y maneja las respuestas.
 - Conexión a la base de datos: Inicialmente se usó una base de datos local con SQL Server. Posteriormente, se migró a una base de datos en la nube en Microsoft SQL Server.

# Despligue 🛫

    El servidor y la base de datos se encuentran alojados en somee.com debido a las siguientes razones:

 - La sencillez con la que pude desplegar mi api y mi base de datos, hizo somee.com la mejor elección.
 - Somee.com ofrece precios competitivos, ideales para proyectos pequeños y medianos, con planes más accesibles.
 - La plataforma proporciona una interfaz fácil de usar para gestionar tu backend y base de datos, permitiendo una escalabilidad flexible sin la complejidad de servicios más grandes.
 - Al ser una plataforma más pequeña, somee.com ofrece soporte especializado y atención directa, con tiempos de respuesta rápidos y sin la burocracia de grandes proveedores.

# Documentación 📖

https://taskapi.somee.com/Swagger/index.html