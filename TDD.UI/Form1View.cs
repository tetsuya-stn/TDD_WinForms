using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDD.UI
{
	public partial class Form1View : Form
	{
		private Form1VIewModel _viewModel = new Form1VIewModel(new DBAccess());
		public Form1View()
		{
			InitializeComponent();

			textBox1.DataBindings.Add("Text", _viewModel, "textBox1Text");
			textBox2.DataBindings.Add("Text", _viewModel, "textBox2Text");
			labelResult.DataBindings.Add("Text", _viewModel, "labelResultText");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//_viewModel.textBox1Text = textBox1.Text;
			//_viewModel.textBox2Text = textBox2.Text;

			_viewModel.CalculationAction();

			//this.labelResult.Text = _viewModel.labelResultText;
		}
	}
}
