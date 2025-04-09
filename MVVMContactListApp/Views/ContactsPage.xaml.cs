using MVVMContactListApp.Models;
using MVVMContactListApp.ViewModels;


namespace MVVMContactListApp.Views
{

    public partial class ContactsPage : ContentPage
    {
        public ContactsPage()
        {
            InitializeComponent();
        }
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var contact = e.CurrentSelection.FirstOrDefault() as MVVMContactListApp.Models.Contact;
            if (BindingContext is ContactsViewModel vm && contact != null)
            {
                vm.ContactSelectedCommand.Execute(contact);
                ((CollectionView)sender).SelectedItem = null;
            }
        }
    }
}