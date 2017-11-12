using System;
using System.Collections.Generic;

namespace SiebelRepositorySearch
{
    public class result
    {
        public result(string objectname,string name,string subobject,string subobject1,string subobject2,string subobject3)
        {
            this.ObjectName = objectname;
            this.Name = name;
            this.SubObject = subobject;
            this.SubObject1 = subobject1;
            this.SubObject2 = subobject2;
            this.SubObject3 = subobject3;
        }
        public string ObjectName
        {
            get { return objectname; }
            set { objectname = value; }
        }
        private string objectname;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string name;
        public string SubObject
        {
            get { return subobject; }
            set { subobject = value; }
        }
        private string subobject;
        public string SubObject1
        {
            get { return subobject1; }
            set { subobject1 = value; }
        }
        private string subobject1;
        public string SubObject2
        {
            get { return subobject2; }
            set { subobject2 = value; }
        }
        private string subobject2;
        public string SubObject3
        {
            get { return subobject3; }
            set { subobject3 = value; }
        }
        private string subobject3;
        static internal List<result> Getresult()
        {
       //     if (result.AllSongs.Count >  0)
            return result.AllSongs;
        }
        static private List<result> AllSongs = new List<result>();
    }
}