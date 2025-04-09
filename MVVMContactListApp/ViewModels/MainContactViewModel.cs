using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVMContactListApp.Models;
using MVVMContactListApp.Views;
using System.Collections.ObjectModel;

using ContactModel = MVVMContactListApp.Models.Contact;


namespace MVVMContactListApp.ViewModels
{
    public partial class MainContactViewModel : ObservableObject
    {
        public static ObservableCollection<ContactModel> Contacts { get; set; } = new();

        [ObservableProperty]
        private string name;

        [ObservableProperty]
        private string email;

        [ObservableProperty]
        private string phoneNumber;

        [ObservableProperty]
        private string description;

        [RelayCommand]
        async Task Save()
        {
            var contact = new ContactModel
            {
                Name = Name,
                Email = Email,
                PhoneNumber = PhoneNumber,
                Description = Description
            };

            Contacts.Add(contact);

            await Application.Current.MainPage.Navigation.PushAsync(new ContactsPage());
        }
    }
}