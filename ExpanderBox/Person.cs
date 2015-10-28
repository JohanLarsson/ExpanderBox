namespace ExpanderBox
{
    public class Person
    {
        public Person(string firstName, string lastname)
        {
            FirstName = firstName;
            Lastname = lastname;
        }

        public string FirstName { get; }

        public string Lastname { get; }
    }
}
