using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCRUDApp
{
    public class MemberManager
    {
        List<Member> members = new List<Member>();

        public void CreateMember(string name, string email, string phone)
        {
            var Member = new Member { Name = name, Email = email, Phone = phone };
            members.Add(Member);
            Console.WriteLine("Member created successfuly");
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
