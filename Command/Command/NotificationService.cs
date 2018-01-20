namespace Command
{
    using System;
    using System.Collections.Generic;

    class NotificationService
    {
        private readonly List<ITask> tasks;

        public NotificationService()
        {
            this.tasks = new List<ITask>();
        }

        public void AddTask(ITask task)
        {
            this.tasks.Add(task);
        }

        public void ExecuteTasks()
        {
            foreach (ITask task in tasks)
            {
                task.Execute();
            }

            tasks.Clear();
        }
    }
}
