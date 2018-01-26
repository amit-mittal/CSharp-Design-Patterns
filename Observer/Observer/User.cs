namespace Observer
{
    public abstract class User
    {
        protected CryptoCurrency currency;

        public User(CryptoCurrency currency)
        {
            this.currency = currency;
            this.currency.AddUser(this);
        }

        public abstract void Notify();
    }
}
