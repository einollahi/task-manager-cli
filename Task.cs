using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_TaskManagerCli
{
    enum Status
    {
        Todo = 0,
        InProgress = 1,
        Done = 2,
    }

    internal class Task
    {
        static int counter = 1;

        public int Id { get; set; }
        public string Title { get; set; }
        public Status Status { get; set; } = Status.Todo;

        public Task(String title) {
            Id = counter++;
            Title = title;
        }

    }
}
