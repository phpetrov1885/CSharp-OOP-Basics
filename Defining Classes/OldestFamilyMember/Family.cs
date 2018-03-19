using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Family
{
    private List<Person> familyMembers;

    public Family()
    {
        familyMembers=new List<Person>();
    }
    public List<Person> FamilyMembers
    {
        get { return familyMembers; }
        set { familyMembers = value; }
    }

    public void AddMember(Person familyMember)
    {
        familyMembers.Add(familyMember);
    }

    public Person GetOdestMember()
    {
       return familyMembers.OrderByDescending(s => s.Age).FirstOrDefault();
    }
}

