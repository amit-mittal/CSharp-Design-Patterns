namespace Command
{
    class EmailTask : ITask
    {
        private readonly User user;
        private readonly string message;

        public EmailTask(User user, string message)
        {
            this.user = user;
            this.message = message;
        }

        public void Execute()
        {
            this.user.SendEmail(this.message);
        }
    }
}
