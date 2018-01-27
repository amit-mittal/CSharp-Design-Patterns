namespace Template
{
    public class Aws : Cloud
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
            return "Aws";
        }
    }
}
