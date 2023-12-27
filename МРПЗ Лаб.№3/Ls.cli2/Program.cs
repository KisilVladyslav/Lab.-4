using L3.Domain;

var taskController = new TaskController();


var positiveTaskType = "Positive";
var negativeTaskType = "Negative";

taskController.AddTaskCategory(positiveTaskType);
taskController.AddTaskCategory(negativeTaskType);

int index = 0;

var Tasks = Enumerable
    .Range(0, 10)
    .Select(x => new L3.Domain.Task
    {
        Title = $"Title: {index}",
        Description = $"Title: {index++}",
        Category = positiveTaskType,
    })
    .ToList();

Tasks.AddRange(Enumerable
    .Range(0, 10)
    .Select(x => new L3.Domain.Task
    {
        Title = $"Title: {index}",
        Description = $"Title: {index++}",
        Category = negativeTaskType,
        IsFavourite = true,
    })
    .ToList());

foreach (var task in Tasks)
{
    taskController.AddTask(task);
}

foreach (var task in taskController.GetAllFavoriteTasksOrderedDescending())
{
    Console.WriteLine(task);
}

foreach (var task in taskController.GetAllTasksByCategoryOrderedDescending(positiveTaskType))
{
    Console.WriteLine(task);
}