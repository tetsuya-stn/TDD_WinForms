using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD.UI;

namespace TDD.Test
{
	[TestClass]
	public class UnitTest2
	{
		[TestMethod]
		public void シナリオ()
		{
			var viewModel = new Form1VIewModel();
			Assert.AreEqual("", viewModel.textBox1Text);
			Assert.AreEqual("", viewModel.textBox2Text);
			Assert.AreEqual("", viewModel.labelResultText);

			viewModel.textBox1Text = "2";
			viewModel.textBox2Text = "5";
			viewModel.CalculationAction();
			Assert.AreEqual("7", viewModel.labelResultText);
		}
	}
}
