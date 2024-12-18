using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllSpark.Domain.Entities
{
    public sealed class Rule
    {
        public int Id { get; private set; }
        public string ? Name { get; private set; }
        public string? Description { get; private set; }

        public Rule(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public Rule(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
