using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AndreevVY.Sprint5.Task4.V24.Lib;

using System.IO;

namespace Tyuiu.AndreevVY.Sprint5.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\sokma\source\repos\Tyuiu.AndreevVY.Sprint5\Tyuiu.AndreevVY.Sprint5.Task4.V24\bin\Debug\InPutDataFileTask4V24.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
