using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class FamilyMember
    {
        public FamilyMember(string name, int birthYear)
        {
            YearOfBirth = birthYear;
            Name = name;
            Children = new List<FamilyMember>();
            Partner = null;
        }
        public int YearOfBirth { get; }
        public string Name { get; }
        public FamilyMember Partner { get; set; }
        public List<FamilyMember> Children { get; set; }
        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() == typeof(FamilyMember))
            {
                FamilyMember other = (FamilyMember)obj;
                return other.YearOfBirth == this.YearOfBirth && other.Name == this.Name;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return $"{Name} ({YearOfBirth})";
        }
    }
}
