using Contactos.Maui.Models;
using Contact = Contactos.Maui.Models.Contact;

namespace Contactos.Maui.Views;



public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();

        

        //List<string> contacts = new List<string>()
        //{
        //    "John Doe",
        //    "Jane Doe",
        //    "Tom Hanks",
        //    "Frnak Liu"

        //};

        List<Contact> contacts = ContactRepository.GetContacts();

        ListContacts.ItemsSource = contacts;
	}



   

    private async void ListContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (ListContacts.SelectedItem != null)
        {
            //DisplayAlert("test", "test", "OK");
            await Shell.Current.GoToAsync($"{nameof(EditContactPage)}?Id={((Contact)ListContacts.SelectedItem).ContactId}");
        }
        
    }

    private void ListContacts_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        ListContacts.SelectedItem = null;
    }

    //private void btnEditContact_Clicked(object sender, EventArgs e)
    //{
    //    Shell.Current.GoToAsync(nameof(EditContactPage));
    //}

    //private void btnAddContact_Clicked(object sender, EventArgs e)
    //{
    //    Shell.Current.GoToAsync(nameof(AddContactPage));
    //}
}