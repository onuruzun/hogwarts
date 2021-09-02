# Hogwarts 🧙‍♂️

The project was written in .NET Core 5.0 version and is divided into 4 layers.

- **hogwarts-api**
- **hogwarts-bll**
- **hogwarts-repository**
- **hogwarts-test**

# 🎉 Build 🎉

**`docker-compose up -d`**

pgadmin: http://localhost:5050/
api: https://localhost:1907/swagger/index.html

## DB Migrations! 👀

- **`cd /hogwarts-api`**
- **`dotnet ef migrations add hogwartsmigration`**
- **`dotnet ef database update hogwartsmigration`**

## Tech Stack, Structure

- .NET Core 5.0 Web API,
- PostgreSQL,
- Docker,
- Swagger
- AutoMapper,
- EF Core
- Generic Design Pattern,
- Repository Pattern,
- Dependency Injection

#

### Author

- **Onur Uzun** - [GitHub](https://github.com/onuruzun), [Twitter](https://twitter.com/onuriart)
