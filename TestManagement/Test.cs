using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestManagement
{
    partial class Test
    {
        private int TestID;
        private string TestName;
        private string TestType;
        private string TestFileName;
        private DateTime TestDateCreated;
        private DateTime TestDateModified;

        public Test(int testId, string name, string type, DateTime dateCreated, DateTime dateModified)
        {
            TestID = testId;
            TestName = name;
            TestType = type;
            //this.fileName = fileName;
            TestDateCreated = dateCreated;
            TestDateModified = dateModified;
        }
    }

    

}
