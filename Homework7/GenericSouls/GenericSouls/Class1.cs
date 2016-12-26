using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSouls
{
    class TestingCollection: IComparable
    {
        private string name;
        private byte age;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public byte Age 
        {
            set { age = value; }
            get { return age; }
        }

        public TestingCollection(string name, byte age)
        {
            this.name = name;
            this.age = age;
        }



        public int CompareTo(object obj)
        {
            TestingCollection that = obj as TestingCollection;
            return this.Age.CompareTo(that.Age);
        }

        public override string ToString()
        {
            string i = this.name+ " || "+ this.age ;     
            return i;
        }
    }
}
