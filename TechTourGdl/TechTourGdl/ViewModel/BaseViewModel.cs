using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TechTourGdl.ViewModel
{
	public class BaseViewModel : INotifyPropertyChanged
	{
		string _title = string.Empty;

		public BaseViewModel()
		{
		}

		public string Title
		{
			get
			{
				return _title;
			}
			set
			{
				if (_title == value)
					return;
				_title = value;
				NotifyPropertyChanged();
			}
		}

		#region INotifyPropertyChanged

		public event PropertyChangedEventHandler PropertyChanged;

		public void NotifyPropertyChanged([CallerMemberName]string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion
	}
}
