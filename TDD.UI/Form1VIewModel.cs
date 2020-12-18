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
		//private System.Windows.Forms.Button button1;

		private string _textBox1Text = string.Empty;
		private string _textBox2Text = string.Empty;
		private string _labelResultText = string.Empty;


		public string textBox1Text
		{
			get { return _textBox1Text; }
			set
			{
				SetProperty<string>(ref _textBox1Text, value);
				//if (_textBox1Text == value)
				//{
				//	return;
				//}
				
				//_textBox1Text = value;
				//OnPropertyChanged("textBox1Text");
			}
		}

		public string textBox2Text
		{
			get { return _textBox2Text; }
			set
			{
				SetProperty<string>(ref _textBox2Text, value);
				//if (_textBox2Text == value)
				//{
				//	return;
				//}

				//_textBox2Text = value;
				//OnPropertyChanged("textBox2Text");
			}
		}

		public string labelResultText
		{
			get { return _labelResultText; }
			set
			{
				SetProperty<string>(ref _labelResultText, value);
				//if (_labelResultText == value)
				//{
				//	return;
				//}

				//_labelResultText = value;
				//OnPropertyChanged("labelResultText");
			}
		}

		//public event PropertyChangedEventHandler PropertyChanged;

		//public void OnPropertyChanged(string propertyName)
		//{
		//	if (PropertyChanged != null)
		//	{
		//		PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		//	}
		//}

		public void CalculationAction()
		{
			int a = int.Parse(textBox1Text);
			int b = int.Parse(textBox2Text);

			labelResultText = Calculation.Sum(a, b).ToString();
		}
	}
}
