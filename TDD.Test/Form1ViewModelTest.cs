using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TDD.UI;

namespace TDD.Test
{
	[TestClass]
	public class UnitTest2
	{
		[TestMethod]
		public void シナリオ()
		{
			var mock = new Mock<IDBAccess>();
			mock.Setup(x => x.GetDBValue()).Returns(100);

			var viewModel = new Form1VIewModel(mock.Object);
			Assert.AreEqual("", viewModel.textBox1Text);
			Assert.AreEqual("", viewModel.textBox2Text);
			Assert.AreEqual("", viewModel.labelResultText);

			viewModel.textBox1Text = "2";
			viewModel.textBox2Text = "5";
			viewModel.CalculationAction();
			Assert.AreEqual("107", viewModel.labelResultText);
		}
	}
}
