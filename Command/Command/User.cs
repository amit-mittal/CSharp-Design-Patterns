namespace Command
{
    using System;

    class User
    {
        public User(string name, string userDetails)
        {
            this.Name = name;
            this.UserDetails = userDetails;
        }

        public string Name { get; }

        public string UserDetails { get; }

        public void SendEmail(string message)
        {
            Console.WriteLine($"Message '{message}' sent via email to '{this.Name}'");
        }

        public void SendPushNotification(string message)
        {
            Console.WriteLine($"Message '{message}' sent via push notification to '{this.Name}'");
        }
    }
}
