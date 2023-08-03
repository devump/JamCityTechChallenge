namespace JamCityChallenge.Domain
{
    public class Employee
    {
        public EmployeePosition position;
        public EmployeeSeniority seniority;

        public Employee(EmployeePosition position, EmployeeSeniority seniority)
        {
            this.position = position;
            this.seniority = seniority;
        }

        public bool CheckPosition(string positionToCheck)
        {
            return position.Equals(new EmployeePosition(positionToCheck));
        }

        public bool CheckSeniority(string seniorityToCheck)
        {
            return seniority.Equals(new EmployeeSeniority(seniorityToCheck));
        }
    }
}