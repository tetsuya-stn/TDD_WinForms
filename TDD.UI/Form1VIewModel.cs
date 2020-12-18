using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.UI
{
	public class Form1VIewModel: ViewModelBase
	{
		private IDBAccess _db;
		private string _textBox1Text = string.Empty;
		private string _textBox2Text = string.Empty;
		private string _labelResultText = string.Empty;

		public Form1VIewModel(IDBAccess db)
		{
			_db = db;
		}

		public string textBox1Text
		{
			get { return _textBox1Text; }
			set
			{
				SetProperty<string>(ref _textBox1Text, value);
			}
		}

		public string textBox2Text
		{
			get { return _textBox2Text; }
			set
			{
				SetProperty<string>(ref _textBox2Text, value);
			}
		}

		public string labelResultText
		{
			get { return _labelResultText; }
			set
			{
				SetProperty<string>(ref _labelResultText, value);
			}
		}

		public void CalculationAction()
		{
			int a = int.Parse(textBox1Text);
			int b = int.Parse(textBox2Text);
			int dbValue = _db.GetDBValue();

			labelResultText = (Calculation.Sum(a, b) + dbValue).ToString();
		}
	}
}
