namespace SimpleCRUDApp
{
    public class MemberManager
    {
        List<Member> members = new List<Member>();

        public void CreateMember(string name, string email, string phone)
        {
            if ((string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone)))
            {
                Console.WriteLine("Name, email or Phone cannot be empty");
                return;
            }

            if (!isValidEmail(email))
            {
                Console.WriteLine("Email invalid format");
                return;
            }

            var Member = new Member { Name = name, Email = email, Phone = phone };
            members.Add(Member);
            Console.WriteLine("Member created successfuly");
        }

        private bool isValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        //Sera pesquisado por um termo
        public void searchMember(string searchTerm)
        {
            var result = members.Where(m => m.Name.Contains(searchTerm) || m.Email.Contains(searchTerm) || m.Phone.Contains(searchTerm));
            if (result.Count() == 0)
            {
                Console.WriteLine("no members found");
            }
            else
            {
                foreach(var member in members)
                {
                    Console.WriteLine(member);
                }
            }
        }

        public void SortMember(string criteria)
        {
            switch (criteria)
            {
                case "name":
                    members = members.OrderBy(m => m.Name).ToList();
                    break;
                case "email":
                    members = members.OrderBy(m => m.Email).ToList();
                    break; 
            }
        }

        public void ReadMembers()
        {
            if (members.Count == 0)
            {
                Console.WriteLine("No member found");
            }
            else
            {
                foreach (var Member in members)
                {
                    Console.WriteLine(Member);
                }
            }
        }

        public void UpdateMember(string email, string newName, string newEmail, string newPhone)
        {
            var member = members.Find(m => m.Email == email);
            if (member != null)
            {
                member.Name = newName;
                member.Email = newEmail;
                member.Phone = newPhone;
                Console.WriteLine("Member Update successfuly");
            }
            else
            {
                Console.WriteLine("Member not found");
            }
        }

        public void DeleteMember(string email)
        {
            var member = members.FirstOrDefault(m => m.Email == email);
            if (member != null)
            {
                members.Remove(member);
                Console.WriteLine("Member Remove successfuly");
            }
            else
            {
                Console.WriteLine("Member not Found");
            }
        }

    }
}
