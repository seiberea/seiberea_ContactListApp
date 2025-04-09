using CommunityToolkit.Mvvm.ComponentModel;
using MVVMContactListApp.Models;

namespace MVVMContactListApp.ViewModels
{
    public partial class ContactDetailsViewModel : ObservableObject
    {
        [ObservableProperty] private string name;
        [ObservableProperty] private string email;
        [ObservableProperty] private string phoneNumber;
        [ObservableProperty] private string description;

        public ContactDetailsViewModel(MVVMContactListApp.Models.Contact contact)
        {
            Name = contact.Name;
            Email = contact.Email;
            PhoneNumber = contact.PhoneNumber;
            Description = contact.Description;
        }
    }
}