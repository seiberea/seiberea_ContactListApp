using ContactModel = MVVMContactListApp.Models.Contact;
using MVVMContactListApp.ViewModels;

namespace MVVMContactListApp.Views;

public partial class ContactDetailsPage : ContentPage
{
    public ContactDetailsPage(ContactModel contact)
    {
        InitializeComponent();
        BindingContext = new ContactDetailsViewModel(contact);
    }
}