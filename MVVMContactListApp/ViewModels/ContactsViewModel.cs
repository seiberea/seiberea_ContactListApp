using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVMContactListApp.Models;
using MVVMContactListApp.Views;
using System.Collections.ObjectModel;

using ContactModel = MVVMContactListApp.Models.Contact;


namespace MVVMContactListApp.ViewModels
{
    public partial class ContactsViewModel : ObservableObject
    {
        public ObservableCollection<ContactModel> ContactList => MainContactViewModel.Contacts;

        [RelayCommand]
        async Task GoToAddContact()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new MainContactPage());
        }

        [RelayCommand]
        async Task ContactSelected(ContactModel contact)
        {
            if (contact != null)
            {
                await Application.Current.MainPage.Navigation.PushAsync(new ContactDetailsPage(contact));
            }
        }
    }
}