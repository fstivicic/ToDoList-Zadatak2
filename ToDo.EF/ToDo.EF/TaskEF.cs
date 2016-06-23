using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ToDo.EF
{
    public class TaskEF
    {
        ToDoListEntities ctx = new ToDoListEntities();

        public List<Task> fetchKind(string Flag)
        {
            List<Task> tasks = ctx.Task.Where(t => t.Flag.Equals(Flag)).ToList();
            tasks.Reverse();
            return tasks;
        }

        public string fetchDetails(int id)
        {
            return ctx.Task.Where(t => t.ID.Equals(id)).Select(t => t.Details).First().ToString();
        }

        public void Insert(Task task)
        {
            ctx.Task.Add(task);
            ctx.SaveChanges();           
        }

        public Task fetchTask(int id)
        {
            return ctx.Task.Where(t => t.ID.Equals(id)).First();
        }

        public void Update(Task task) {
            Task oldTask = ctx.Task.Where(t => t.ID.Equals(task.ID)).First();
            oldTask.Flag = task.Flag;
            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            Task oldTask = ctx.Task.Where(t => t.ID == id).Single();
            ctx.Task.Remove(oldTask);
            ctx.SaveChanges();
        }
    }
}

