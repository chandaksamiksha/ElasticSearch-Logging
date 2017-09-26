using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackageLog;

namespace Package.Log.Test
{
    [TestClass]
    public class InputTest
    {
        [TestMethod]
        public void Check_Properties_Of_Input_Class()
        {
            Input input = new Input("Nest",5);
            Assert.IsTrue(input.packageName.Equals("Nest"));
            Assert.IsTrue(input.packageVersion.Equals(5));

            Input input1 = new Input("NuGet", 3);
            Assert.IsTrue(input1.packageName.Equals("NuGet"));
            Assert.IsTrue(input1.packageVersion.Equals(3));

            Input input2 = new Input("Lucene.net", 2);
            Assert.IsTrue(input2.packageName.Equals("Lucene.net"));
            Assert.IsTrue(input2.packageVersion.Equals(2));

            Input input3 = new Input("Elastic Search", 1);
            Assert.IsTrue(input3.packageName.Equals("Elastic Search"));
            Assert.IsTrue(input3.packageVersion.Equals(1));
        }

        public void Check_The_Values_Of_Index()
        {
            Input input = new Input("NuGet", 3);
            Input input1 = new Input("Lucene.net", 2);
            Input input2 = new Input("Elastic Search", 1);
        }
    }
}
