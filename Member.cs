namespace SimpleCRUDApp
{
    public class Member
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}, Phone: {Phone}";
        }
    }
}
