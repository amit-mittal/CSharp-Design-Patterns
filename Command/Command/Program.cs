namespace Command
{
    using System;

    /// <summary>
    /// This is Client.
    /// Notification Service is Invoker which can be a separate service.
    /// And ExecuteTasks might be getting handled separately.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var notificationService = new NotificationService();

            var user1 = new User("Ed", "Random-Details-1");
            var user2 = new User("Edd", "Random-Details-2");
            var user3 = new User("Eddy", "Random-Details-3");

            // First Iteration
            notificationService.AddTask(new EmailTask(user1, "How are you sir?"));
            notificationService.AddTask(new PushNotificationTask(user3, "Follow up needed?"));

            notificationService.ExecuteTasks();

            // Second Iteration
            notificationService.AddTask(new EmailTask(user1, "Second Message"));
            notificationService.AddTask(new PushNotificationTask(user1, "Discount Offer"));
            notificationService.AddTask(new PushNotificationTask(user2, "Discount Offer"));

            notificationService.ExecuteTasks();

            notificationService.AddTask(new PushNotificationTask(user3, "Discount Offer"));

            Console.ReadKey();
        }
    }
}
