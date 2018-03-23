using System;
using System.Collections.Generic;
using System.Text;



 class Parent
 {
     private string name;
     private string birthDay;

     public Parent(string name,string birthDay)
     {
         Name = name;
         Birthday = birthDay;
     }
     public string Name
     {
         get { return name; }
         set { name = value; }
     }
     public string Birthday
     {
         get { return birthDay; }
         set { birthDay = value; }
     }
     public override string ToString()
     {
         return $"{this.name}{this.birthDay}";
     }
}
  
