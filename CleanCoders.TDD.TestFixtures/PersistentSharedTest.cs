﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCoders.TDD.TestFixtures
{
    [TestClass]
    public class PersistentSharedTest
    {
        public PersistentSharedTest()
        {
            Console.Out.WriteLine("construct");
        }


        [ClassInitialize]
        public static void SuiteSetup(TestContext testContext)
        {
            Console.Out.WriteLine("Suite setup");
        }

        [ClassCleanup]
        public static void SuiteTeardown()
        {
            Console.Out.WriteLine("Suite teardown");
        }

        [TestInitialize]
        public void SetUp()
        {
            Console.Out.WriteLine("setup");
        }

        [TestCleanup]
        public void TearDown() {
            Console.Out.WriteLine("teardown");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Console.Out.WriteLine("test1");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Console.Out.WriteLine("test2");
        }
    }
}
