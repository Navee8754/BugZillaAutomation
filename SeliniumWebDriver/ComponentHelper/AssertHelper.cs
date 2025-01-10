using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeliniumWebDriver.ComponentHelper
{
    public class AssertHelper
    {
        public static void AreEqual(string expected, string actual) 
        {
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual);
            }
            catch (AssertFailedException ex)
            {
                // Log the error, rethrow, or handle the exception
                Console.WriteLine($"Assertion failed: Expected '{expected}', but got '{actual}'");
                throw;
            }
        }
        public static void IsTrue(bool condition)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(condition);
        }
    }
}
