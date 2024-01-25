using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FamilyTree familyTree = new FamilyTree();

            FamilyMember grandparent1 = new FamilyMember("John", 1950);
            FamilyMember grandparent2 = new FamilyMember("Jane", 1955);
            FamilyMember parent1 = new FamilyMember("Alice", 1980);
            FamilyMember uncle = new FamilyMember("Bob", 1982);
            FamilyMember parent2 = new FamilyMember("Luck", 1975);
            FamilyMember child1 = new FamilyMember("Charlie", 2005);
            FamilyMember child2 = new FamilyMember("Diana", 2008);

            familyTree.AddPerson(grandparent1);
            familyTree.CreateRelationship(grandparent1, grandparent2);
            familyTree.AddChild(grandparent1, parent1);
            familyTree.AddChild(grandparent2, uncle);
            familyTree.CreateRelationship(parent1, parent2);
            familyTree.AddChild(parent1, child1);
            familyTree.AddChild(parent2, child2);

            Console.WriteLine("All descendants of Alice:");
            var descendantsOfAlice = familyTree.GetDescendants(parent1);
            foreach (var descendant in descendantsOfAlice)
            {
                Console.WriteLine(descendant);
            }

            Console.WriteLine("\nRelatives born in 1980:");
            var relatives1980 = familyTree.GetRelativesByYearOfBirth(1980);
            foreach (var relative in relatives1980)
            {
                Console.WriteLine(relative);
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach(var member in familyTree)
            {
                Console.WriteLine(member);
            }
        }
    }
    
}
