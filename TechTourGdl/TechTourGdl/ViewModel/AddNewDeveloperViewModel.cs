using System;
using System.Collections.Generic;
using System.Windows.Input;
//using Plugin.Media;
//using Plugin.Media.Abstractions;
using TechTourGdl.Model;
using Xamarin.Forms;

namespace TechTourGdl.ViewModel
{
	public class AddNewDeveloperViewModel : BaseViewModel
	{
		object _techTourVM;

		public AddNewDeveloperViewModel(object techTourVM)
		{
			Title = "Add New Developer";
			_techTourVM = techTourVM;
			SaveDeveloperCommand = new Command(SaveDeveloperAction, CanSaveDeveloper);
			SelectPhotoForDeveloperCommand = new Command(SelectPhotoForDeveloperAction);
		}

		public TechTourGdlViewModel TechTourGdlVM
		{
			get
			{
				return _techTourVM as TechTourGdlViewModel;
			}
		}

		public string Name
		{
			get
			{
				return Developer.Name;
			}
			set
			{
				if (Developer.Name == value)
					return;
				Developer.Name = value;
				NotifyPropertyChanged();
				SaveDeveloperCommand.ChangeCanExecute();
			}
		}

		public string LastName
		{
			get
			{
				return Developer.LastName;
			}
			set
			{
				if (Developer.LastName == value)
					return;
				Developer.LastName = value;
				NotifyPropertyChanged();
				SaveDeveloperCommand.ChangeCanExecute();
			}
		}

		public string PhotoUrl
		{
			get
			{
				return Developer.PhotoUrl;
			}
			set
			{
				if (Developer.PhotoUrl == value)
					return;
				Developer.PhotoUrl = value;
				NotifyPropertyChanged();
				SaveDeveloperCommand.ChangeCanExecute();
			}
		}

		public Developer Developer { get; } = new Developer();

		public Command SaveDeveloperCommand { get; }

		public Command SelectPhotoForDeveloperCommand { get; }

		public void SaveDeveloperAction()
		{
			TechTourGdlVM.AddDeveloper(Developer);
		}

		public bool CanSaveDeveloper()
		{
			return !string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(LastName);
			//return !string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(LastName) && !string.IsNullOrWhiteSpace(PhotoUrl);
		}

		public async void SelectPhotoForDeveloperAction()
		{
			//var options = new List<string>();
			//if (CrossMedia.Current.IsCameraAvailable && CrossMedia.Current.IsTakePhotoSupported)
			//{
			//	options.Add("Take Photo");
			//}
			//if (CrossMedia.Current.IsPickPhotoSupported)
			//{
			//	options.Add("Pick Photo");
			//}
			//var result = await Application.Current.MainPage.DisplayActionSheet("Select Option", "Cancel", null, options.ToArray());
			//if (result == "Take Photo")
			//{

			//	var cameraoptions = new StoreCameraMediaOptions();
			//	cameraoptions.PhotoSize = PhotoSize.Medium;
			//	var photo = await CrossMedia.Current.TakePhotoAsync(cameraoptions);
			//	if (photo == null)
			//		return;
			//	PhotoUrl = photo.Path;
			//}
			//else if (result == "Pick Photo")
			//{
			//	var photo = await CrossMedia.Current.PickPhotoAsync();
			//	if (photo == null)
			//		return;
			//	PhotoUrl = photo.Path;
			//}
		}
		
	}
}
