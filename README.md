# Command API
##### by Chinedu Dara

> This is an API to store commands I use regularly and mostly forget. This is built on __.net core__

To utilize this app you should have postman installed.

* To Build:
```
dotnet build
```

* To Run Migrations (Create the database):
```
dotnet ef database update
```

* To Run: (on VS Code)
```
dotnet run
```


API Routes

| Method | Route | Description |
| - | - | - |
| GET: | [/api/commands](/ "Example: localhost:5000/api/commands") | Get all stored commands
| GET: | [/api/commands/id](/ "Example: localhost:5000/api/commands/1") | Get command by Id
| POST: | [/api/commands](/ "Example: localhost:5000/api/commands") | Create a new command
| PUT: | [/api/commands/id](/ "Example: localhost:5000/api/commands") | Update an existing command by Id
| DELETE: | [/api/delete/id](/ "Example: localhost:5000/api/commands/4") | Delete a command by Id


Object Structure
```javascript
{
"id": 1,
"howto": "Build Application",
"platform": ".Net Core",
"commandLine": "dotnet build"
}
```