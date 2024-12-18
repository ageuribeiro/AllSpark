using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllSpark.Domain.Entities
{
    public sealed class User
    {
        public int Id { get; private set; }
        public int AcademyId { get; private set; }
        public int RuleId { get; private set; }
        public string ? FirstName { get; private set; }
        public string ? LastName { get; private set; }
        public string? Email { get; private set; }
        public string? Password { get; private set; }

        public User(int academyId, int ruleId, string firstName, string lastName, string email, string pass)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = pass;
            AcademyId = academyId;
            RuleId = ruleId;
        }

        public User(int id, int academyId, int ruleId, string firstName, string lastName, string email, string pass)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = pass;
            AcademyId = academyId;
            RuleId = ruleId;
        }
        public ICollection<Academy> ? Academies { get; set; }
        public ICollection<Rule> ? Rules { get; set; }
        
    }
}
