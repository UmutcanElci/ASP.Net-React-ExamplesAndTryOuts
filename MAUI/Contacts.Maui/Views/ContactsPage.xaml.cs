using Contacts.Maui.Models;
using Contact = Contacts.Maui.Models.Contact;
namespace Contacts.Maui.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();

		List<Contact> contacts = ContactRepository.GetContacts();

		//List<string> contacts = new List<string>() {
		//	"John Doe",
		//	"Jane Doe",
		//	"Tom Hanks",
		//	"Frank Liu"
		//};

		listContacts.ItemsSource = contacts;
	}

	

    private async void listContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
		if(listContacts.SelectedItem != null)
		{
			await Shell.Current.GoToAsync(nameof(EditContactPage));
		}
    }

    private void listContacts_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        listContacts.SelectedItem = null;
    }
}