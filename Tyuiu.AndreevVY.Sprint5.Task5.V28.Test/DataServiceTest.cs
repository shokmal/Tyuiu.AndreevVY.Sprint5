using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AndreevVY.Sprint5.Task5.V28.Lib;

using System.IO;

namespace Tyuiu.AndreevVY.Sprint5.Task5.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\sokma\source\repos\Tyuiu.AndreevVY.Sprint5\Tyuiu.AndreevVY.Sprint5.Task5.V28\bin\Debug\InPutDataFileTask5V28.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
