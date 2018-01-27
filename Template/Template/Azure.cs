namespace Template
{
    class Azure : Cloud
    {
        protected override bool Deploy(string template)
        {
            return true;
        }

        protected override bool GetResult()
        {
            return true;
        }

        protected override string GetTemplate()
        {
            return "Azure";
        }
    }
}
