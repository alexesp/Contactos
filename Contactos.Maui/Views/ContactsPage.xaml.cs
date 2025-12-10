namespace Contactos.Maui.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();

        List<Contact> contacts = new List<Contact>()
        { new Contact{ Name = "John Doe", Email="johndoe@gmail.com"},
          new Contact{ Name = "Jane Doe", Email="janedoe@gmail.com"},
          new Contact{ Name = "Tom Hanks", Email="tomhanks@gmail.com" },
          new Contact{ Name = "Frank Liu", Email="frankliu@gmail.com"}
          };

        //List<string> contacts = new List<string>()
        //{
        //    "John Doe",
        //    "Jane Doe",
        //    "Tom Hanks",
        //    "Frnak Liu"

        //};

        ListContacts.ItemsSource = contacts;
	}



    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
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