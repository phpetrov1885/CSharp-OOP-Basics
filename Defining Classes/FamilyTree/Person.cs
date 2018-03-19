using System;
using System.Collections.Generic;
using System.Text;


    public class Person
    {
        private string name;
        private string birthDay;
        private List<Person> parents;
        private List<Person> children;

        public Person()
        {
            this.parents=new List<Person>();
            this.children=new List<Person>();
        }

        public Person(string name) : this ()
        {
            this.Name = name;
        }
    

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string BirthDay
        {
            get { return birthDay; }
            set { birthDay = value; }
        }

        public List<Person> Parents
        {
            get { return parents; }
            set { parents = value; }
        }

        public List<Person> Children
        {
            get { return children; }
            set { children = value; }
        }

        public override string ToString()
        {
            return $"{this.Name} {this.birthDay}";
        }
    }

