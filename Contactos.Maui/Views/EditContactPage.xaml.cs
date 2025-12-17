using Contactos.Maui.Models;
using Contact = Contactos.Maui.Models.Contact;
namespace Contactos.Maui.Views;

[QueryProperty(nameof(ContactId),"Id")]
public partial class EditContactPage : ContentPage
{
	private Contact contact;
	public EditContactPage()
	{
		InitializeComponent();
	}

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
		//Shell.Current.GoToAsync("..");
		Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    }

	public string ContactId
	{
		set
		{
			contact = ContactRepository.GetContactById(int.Parse(value));
			//lblName.Text = contact.Name;

			if(contact != null)
			{
				enryName.Text = contact.Name;
				entryEmail.Text = contact.Email;
				entryPhone.Text = contact.Phone;
				//entryAddress.Text = contact.Address;
			}
		}
	}

    private void btnUpdate_Clicked(object sender, EventArgs e)
    {
		contact.Name = enryName.Text;
		contact.Address = entryAddress.Text;
		contact.Email = entryEmail.Text;
		contact.Phone = entryPhone.Text;
		ContactRepository.UpdateContact(contact.ContactId, contact);
        Shell.Current.GoToAsync("..");
    }
}