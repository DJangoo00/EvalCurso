# Ssekeleton 2.0 API

Introduccion y descripcion del proyecto


[![GitHub](https://badgen.net/badge/icon/github?icon=github&label)](https://github.com)
[![.NET](https://img.shields.io/badge/--512BD4?logo=.net&logoColor=ffffff)](https://dotnet.microsoft.com/)
[![NuGet](https://badgen.net/badge/icon/nuget?icon=nuget&label)](https://https://nuget.org/)
[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://learn.microsoft.com/es-es/dotnet/csharp/)
[![GitHub](https://img.shields.io/badge/MySQL-005C84?style=for-the-badge&logo=mysql&logoColor=white)](https://www.mysql.com/)

**Table of Contents**📑

[TOCM]

[TOC]

## Requerimientos Funcionales 🌟

Listado de requerimientos

## Consultas Propuestas 📋

1. Listado de consultas propuestas

## Versiones Disponibles 📈
Versiones implementadas

1. V1.0
    Caracteristicas de esta version.

2. V1.1
    Caracteristicas de esta version.


## Uso 🕹

Descripcion del uso

**Versionado**
Para la implementacion de las versiones se puede realizar desde Header como en la imagen o desde Query con la key ver=1.0
![](./Readme_Img/V1.1.png.png)


**Paginado**
Para realizar la paginación se va al apartado de "Query" y se ingresa lo siguiente:
![](./Readme_Img/paginado.png.png)


### Endpoints de Usuario ⚙️
**Método**: `POST`

#### 1. Registro de Usuario 🎉
Este endpoint permite a los usuarios registrarse en el sistema.

**Endpoint**: `http://localhost:5051/api/User/register`
**Version**: `1.0`
```JSON
{
    "nombre": "<nombre_de_usuario>",
    "password": "<password>",
    "correo": "<Email>"
}

```

#### 2. Generacion de Tokken ⏳
Una vez registrado el usuario tendrá que ingresar para recibir un token, este será ingresado al siguiente Endpoint que es el de Refresh Token.

**Endpoint**: `http://localhost:5051/api/User/token`
**Version**: `1.0`
```JSON
{
    "nombre": "<nombre_de_usuario>",
    "password": "<password>"
}
```

####  3. Refresh Token ♻️
Este endpoint permite actualizar el token el cual expira cada minuto.

Se dejan los mismos datos en el Body y luego se ingresa al "Auth", "Bearer", allí se ingresa el token obtenido en el anterior Endpoint.

**Endpoint**: `http://localhost:5051/api/User/refresh-token`
**Version**: `1.0`

#### 4. Asignacion de Rol 📜
Permite asignarle un rol diferente al usuario del predeterminado el cual es "empleado".

**Endpoint**: `http://localhost:5051/api/User/addrole`
**Version**: `1.0`

```JSON
{
    "nombre": "<nombre_de_usuario>",
    "password": "<password>",
    "role": "<role>"
}
```

**Otros Endpoints**

- Obtener Todos los Usuarios: GET. 🧲
**Endpoint**: `http://localhost:5051/api//User`

- Obtener Usuario por ID: GET. 🧲
**Endpoint**: `http://localhost:5051/api/User/{id}`

- Actualizar Usuario: PUT. ⛓
**Endpoint**: `http://localhost:5051/api/User/{id}`

- Eliminar Usuario: DELETE. 🗑
**Endpoint**: `http://localhost:5051/api/User/{id}`


### Endpoints Especificos ✅
Para el desarrollo de las consultas se analizaron las variables de estas para dar flexibilidad al desarrollo de estas.
**Método**: `GET`


#### 1. Listado de endpoints especificos.
**Version**: `1.0`
**Endpoint**: `URL de endpoint`

**Version**: `1.1`
**Endpoint**: `URL de endpoint`



## Tecnologias 💻

-   NetCore 7.0
-   MySQL
-   GitHub

### Lenguajes Usados 💬

-   C#

### Dependencias Usadas 📦

-   "AspNetCoreRateLimit" Version="5.0.0"
-   "AutoMapper.Extensions.Microsoft.DependencyInjection" Version="12.0.1"
-   "Microsoft.AspNetCore.Authentication.JwtBearer" Version="7.0.12"
-   "Microsoft.AspNetCore.Mvc.Versioning" Version="5.1.0"
-   "Microsoft.AspNetCore.OpenApi" Version="7.0.12"
-   "Microsoft.EntityFrameworkCore" Version="7.0.12"
-   "Microsoft.EntityFrameworkCore.Design" Version="7.0.12">
-   "Microsoft.Extensions.DependencyInjection" Version="7.0.0"
-   "Swashbuckle.AspNetCore" Version="6.5.0"
-   "System.IdentityModel.Tokens.Jwt" Version="7.0.3"
-   "Microsoft.IdentityModel.Tokens" Version="7.0.3"
-   "Serilog.AspNetCore" Version="7.0.0"
-   "FluentValidation.AspNetCore" Version="11.3.0"
-   "itext7.pdfhtml" Version="5.0.1"
-   "Pomelo.EntityFrameworkCore.MySql" Version="7.0.0"
-   "CsvHelper" Version="30.0.1"

## Estructura de la DataBase 🧱

> Estructura General.

![](./Readme_Img/DB-structure.png)