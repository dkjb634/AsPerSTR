using NUnit.Framework;
using System.Reflection;
using System;
using System.IO;

namespace AsPerSTR
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCallResourcesFromSameProject()
        {
            var resName = Assembly.GetExecutingAssembly().GetManifestResourceNames()[0];

            bool Success = (Assembly.GetExecutingAssembly()
                .GetManifestResourceStream("AsPerSTR.FolderWithFile.File.txt.gz") != null) 
                && resName =="AsPerSTR.FolderWithFile.File.txt.gz";

            if (Success) Assert.Pass();
            Assert.Fail();
        }
    }
}