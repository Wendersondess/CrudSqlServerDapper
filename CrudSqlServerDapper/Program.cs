
using CrudSqlServerDapper.Controllers;

var clientController = new ClienteController();
clientController.CreateClient();

Console.ReadLine();