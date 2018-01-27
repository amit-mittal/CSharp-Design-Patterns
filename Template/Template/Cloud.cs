namespace Template
{
    using System;

    public abstract class Cloud
    {
        /// <summary>
        /// This is the function which won't be overridden in derived classes.
        /// </summary>
        public void DoWork()
        {
            string t = this.GetTemplate();
            Console.WriteLine($"Got template as {t}");

            bool r = this.Deploy(t);
            Console.WriteLine($"Deploying template {t}. Result: {r}");
            if (r)
            {
                while(!this.GetResult())
                {
                    Console.WriteLine("Still waiting for result!!");
                }
            }
            else
            {
                Console.WriteLine("Failed to deploy!!");
            }
        }

        // Below functions shouldn't be accessible outside.
        protected abstract string GetTemplate();

        protected abstract bool Deploy(string template);

        protected abstract bool GetResult();
    }
}
