namespace JamCityChallenge.Domain
{
    public class EmployeePosition
    {
        private string key;
        private string name;

        public EmployeePosition(string name)
        {
            key = name.Replace(" ", "");
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public override int GetHashCode()
        {
            return key.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is EmployeePosition position && position.key.Equals(key))
            {
                return true;
            }
            return false;
        }
    }
}