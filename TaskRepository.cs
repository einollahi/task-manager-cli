using System.Text.Json;
using System.IO;
using System.IO.Enumeration;

namespace _01_TaskManagerCli
{
    internal class TaskRepository
    {
        private readonly List<Task> _tasks = new List<Task>();

        public TaskRepository(FileService _fileService) { }

        public void Add(String title) {
            var task = new Task(title);
            _tasks.Add(task);
            Save();
        }

        public void Update(Task task) {
            var founded = _tasks.Find(t => t.Id == task.Id);
            if (founded != null)
            {
                founded.Title = task.Title;
                Save();
            }
        }

        public void Delete(int id) {
            _tasks.RemoveAll(t => t.Id == id);
            Save();
        }

        public void MarkTodo(Task task)
        {
            task.Status = Status.Todo;
            Save();
        }

        public void MarkInProgress(Task task)
        {
            task.Status = Status.InProgress;
            Save();
        }

        public void MarkCompleted(Task task)
        {
            task.Status = Status.Done;
        }

        public List<Task> Tasks() { 
            return _tasks;
        }

        private void Save()
        {
            _fileService.Save(_tasks);
        }
        
    }
}
