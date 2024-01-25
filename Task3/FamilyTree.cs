using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class FamilyTree
    {
        private List<FamilyMember> allFamily = new List<FamilyMember>();
        private FamilyMember oldestMember;
        public void AddPerson(FamilyMember person)
        {
            if(allFamily.Count == 0)
            {
                oldestMember = person;
            }
            allFamily.Add(person);
        }
        public void AddChild(FamilyMember parent, FamilyMember child)
        {
            if (allFamily.Contains(parent))
            {
                parent.Children.Add(child);
                if(allFamily.Contains(parent.Partner))
                {
                    parent.Partner.Children.Add(child);
                }
                else
                {
                    Console.WriteLine("wetyhj");
                    Console.WriteLine(allFamily.Count);
                }
                AddPerson(child);
            }
            else
            {
                throw new ArgumentException("parent does not exist in this family");
            }
        }
        public void RemovePerson(FamilyMember person)
        {
            if (allFamily.Contains(person))
            {
                allFamily.Remove(person);
            }
            else
            {
                throw new ArgumentException("person does not exist in this family");
            }
        }
        public List<FamilyMember> GetDescendants(FamilyMember person)
        {
            if (allFamily.Contains(person))
            {
                List<FamilyMember> descendants = new List<FamilyMember>();
                GetDescendantsRecursive(person, descendants);
                descendants.Remove(person);
                return descendants;
            }
            else
            {
                throw new ArgumentException("person does not exist in this family");
            }
        }

        public FamilyMember[] GetRelativesByYearOfBirth(int year)
        {
            return allFamily.Where(p => p.YearOfBirth == year).ToArray();
        }

        public void CreateRelationship(FamilyMember familyMember, FamilyMember partner)
        {
            if (allFamily.Contains(familyMember))
            {
                familyMember.Partner = partner;
                partner.Partner = familyMember;
                allFamily.Add(partner);
            }
            else
            {
                throw new ArgumentException("such person does not exist in family");
            }
        }
        private void GetDescendantsRecursive(FamilyMember person, List<FamilyMember> descendants)
        {
            descendants.Add(person);
            foreach (var child in person.Children)
            {
                GetDescendantsRecursive(child, descendants);
            }
        }
        

        //method from first failed attempt
        public void Reset()
        {

        }
        public FamilyMember Current { get; private set; }
        public FamilyMember MoveNext()
        {
            return null;
        }

        public IEnumerator<FamilyMember> GetEnumerator()
        {
            foreach (FamilyMember member in GetMembersRecursively(oldestMember))
            {
                yield return member;
            }
        }
        public IEnumerable<FamilyMember> GetMembersRecursively(FamilyMember oldestPersonToSearch)
        {
            if (oldestPersonToSearch != null)
            {
                yield return oldestPersonToSearch;

                if (oldestPersonToSearch.Partner != null)
                {
                    yield return oldestPersonToSearch.Partner;
                }

                if (oldestPersonToSearch.Children.Count > 0)
                {
                    foreach (var child in oldestPersonToSearch.Children)
                    {
                        foreach (var member in GetMembersRecursively(child))
                        {
                            yield return member;
                        }
                    }
                }
            }
        }

        public void Print()
        {
            foreach(var member in allFamily)
            {
                Console.WriteLine(member);
            }
        }
    }
}
