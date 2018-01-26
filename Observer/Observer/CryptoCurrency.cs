namespace Observer
{
    using System;
    using System.Collections.Generic;

    public abstract class CryptoCurrency
    {
        private readonly List<User> users;
        protected int value;

        protected CryptoCurrency(int initialValue)
        {
            this.value = initialValue;
            this.users = new List<User>();
        }

        public int Value => this.value;

        public void AddUser(User user)
        {
            Console.WriteLine("New user registered!!");
            this.users.Add(user);
        }

        public void UpdateState(int change)
        {
            this.UpdateStateImpl(change);
            foreach (User user in this.users)
            {
                user.Notify();
            }
        }

        protected abstract void UpdateStateImpl(int change);
    }
}
