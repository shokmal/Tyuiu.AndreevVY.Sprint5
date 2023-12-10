using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.AndreevVY.Sprint5.Task3.V22.Lib;

namespace Tyuiu.AndreevVY.Sprint5.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\sokma\source\repos\Tyuiu.AndreevVY.Sprint5\Tyuiu.AndreevVY.Sprint5.Task3.V22\bin\Debug\OutPutFileTask3.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
