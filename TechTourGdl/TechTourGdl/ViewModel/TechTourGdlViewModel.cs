using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TechTourGdl.Model;
using TechTourGdl.Pages;
using Xamarin.Forms;

namespace TechTourGdl.ViewModel
{
	public class TechTourGdlViewModel : BaseViewModel
	{
		public TechTourGdlViewModel()
		{
			Title = "Tech Tour GDL";
			Developers = new ObservableCollection<Developer>();
			RemoveDeveloperCommand = new Command<Developer>(RemoveDeveloperAction);
			GoToAddNewDeveloperCommand = new Command(GoToAddNewDeveloperAction);
			ShowDeveloperDetailsCommand = new Command<Developer>(ShowDeveloperDetailsAction); 
		}

		public ObservableCollection<Developer> Developers { get; }

		public Command<Developer> ShowDeveloperDetailsCommand { get; }

		public Command GoToAddNewDeveloperCommand { get; }

		public Command<Developer> RemoveDeveloperCommand { get; }

		public async void AddDeveloper(Developer dev)
		{
			await Application.Current.MainPage.Navigation.PopAsync();
			Developers.Add(dev);
		}

		public void RemoveDeveloperAction(Developer dev)
		{
			Developers.Remove(dev);
		}

		public void GoToAddNewDeveloperAction()
		{
			var page = new AddNewDeveloperPage();
			page.BindingContext = new AddNewDeveloperViewModel(this);
			Application.Current.MainPage.Navigation.PushAsync(page);
		}

		public void ShowDeveloperDetailsAction(Developer dev)
		{
			Application.Current.MainPage.DisplayAlert("Developer Data", $"{dev.Name} {dev.LastName}", "Close");
		}
	}
}
