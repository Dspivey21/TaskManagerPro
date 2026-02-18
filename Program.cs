using TaskManagerPro;

var tasks = new List<ITask>
{
    new ReTask("Exercise", 3),
    new SimpleTask("Email professor"),
    new SimpleTask("Buy groceries"),
    new TimedTask("Study algorithms", 45)
};

foreach (var task in tasks)
{
    task.Display();
}

tasks[0].Complete();
tasks[0].Complete();
tasks[0].Complete();
Console.WriteLine("\nAfter completing the first task:\n");
foreach (var task in tasks)
{
    task.Display();
}


