using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.Test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var val = TDD.UI.Calculation.Sum(2, 5);
			Assert.AreEqual(7, val);
		}
	}
}
