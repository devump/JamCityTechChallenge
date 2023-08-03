namespace JamCityChallenge.Domain
{
    public class EmployeeSeniority
    {
        public string key;
        public string name;

        public EmployeeSeniority(string name)
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
            if (obj is EmployeeSeniority seniority && seniority.key.Equals(key))
            {
                return true;
            }
            return false;
        }
    }
}