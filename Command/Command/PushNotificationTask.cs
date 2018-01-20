namespace Command
{
    class PushNotificationTask : ITask
    {
        private readonly User user;
        private readonly string message;

        public PushNotificationTask(User user, string message)
        {
            this.user = user;
            this.message = message;
        }

        public void Execute()
        {
            this.user.SendPushNotification(this.message);
        }
    }
}
