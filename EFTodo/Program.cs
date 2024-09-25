using Microsoft.EntityFrameworkCore;
using var context = new TodoContext();
Console.WriteLine("----- Création des todos -----");


var task1 = new Todo
{
    Id = 1,
    Task = "Wash the dishes",
    Completed = true
};
var task2 = new Todo
{
    Id = 2,
    Task = "Clean the house",
    Completed = false
};
var task3 = new Todo
{
    Id = 3,
    Task = "Mow the lawn",
    Completed = false
};

context.Todo.Add(task1);
context.Todo.Add(task2);
context.Todo.Add(task3);
context.SaveChanges();

var tasks = context.Todo.ToList();

Console.WriteLine("----- Liste de tous les todos -----");
foreach (var task in tasks)
    Console.WriteLine($"Todo {task.Id}, task: {task.Task}, completed: {task.Completed}");


Console.WriteLine("----- Liste de tous les todos non terminés -----");
foreach (var task in tasks)
{
    if (task.Completed == false)
        Console.WriteLine($"Todo {task.Id}, task: {task.Task}, completed: {task.Completed}");
}

foreach (var task in tasks)
{
    if (!task.Completed)
        task.Completed = true;
}
context.SaveChanges();

Console.WriteLine("----- Liste de tous les todos -----");
foreach (var task in tasks)
{
    Console.WriteLine($"Todo {task.Id}, task: {task.Task}, completed: {task.Completed}");
}
Console.WriteLine("----- Liste de tous les todos non terminés -----");
foreach (var task in tasks)
{
    if (task.Completed == false)
        Console.WriteLine($"Todo {task.Id}, task: {task.Task}, completed: {task.Completed}");
}

Console.WriteLine("----- Suppression des todos -----");

foreach (var task in tasks)
{
    context.Todo.Remove(task);
    context.SaveChanges();
}




Console.WriteLine("----- Liste de tous les todos -----");
foreach (var task in tasks)
{
    Console.WriteLine($"Todo {task.Id}, task: {task.Task}, completed: {task.Completed}");
}
Console.WriteLine("----- Liste de tous les todos non terminés -----");
foreach (var task in tasks)
{
    if (task.Completed == false)
        Console.WriteLine($"Todo {task.Id}, task: {task.Task}, completed: {task.Completed}");
}




