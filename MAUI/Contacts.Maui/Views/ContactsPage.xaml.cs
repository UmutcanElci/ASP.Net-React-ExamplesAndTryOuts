namespace Contacts.Maui.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();

		List<Contact> contacts = new List<Contact>()
		{
			new Contact { Name="John Doe", Email="JohnDoe@mail.com"},
            new Contact { Name="Jane Doe", Email="JaneDoe@mail.com"},
            new Contact { Name="Tom Hanks", Email="TomHanks@mail.com"},
            new Contact { Name="Frank Liu", Email="FrankLiu@mail.com"},
        };

		//List<string> contacts = new List<string>() {
		//	"John Doe",
		//	"Jane Doe",
		//	"Tom Hanks",
		//	"Frank Liu"
		//};

		listContacts.ItemsSource = contacts;
	}

	public class Contact
	{
        public string Name { get; set; }
        public string Email { get; set; }
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