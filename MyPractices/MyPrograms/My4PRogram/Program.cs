
using System.Collections.Generic;

bool running = true;
int operationInput;
Console.WriteLine("Welcome to my Contacts Program!");

//List<string> names = new List<string>();
//List<string> lastNames = new List<string>();
//List<string> phoneNumbers = new List<string>();
//List<string> emails = new List<string>();
//List<string> addresses = new List<string>();
//List<string> sexs = new List<string>();
//List<int> ages = new List<int>();
//List<bool> isFavorites = new List<bool>();
Dictionary<int, string> names = new Dictionary<int, string>();
Dictionary<int, string> lastNames = new Dictionary<int, string>();
Dictionary<int, string> phoneNumbers = new Dictionary<int, string>();
Dictionary<int, string> emails = new Dictionary<int, string>();
Dictionary<int, string> addresses = new Dictionary<int, string>();
Dictionary<int, string> sexs = new Dictionary<int, string>();
Dictionary<int, int> ages = new Dictionary<int, int>();
Dictionary<int, bool> isFavorites = new Dictionary<int, bool>();

List<int> ids = new List<int>();

try
{
    while (running)
    {
        Console.WriteLine("Please enter the operation you want to perform:");
        Console.WriteLine("1. Add contact, 2. Show contacts, 3. Edit Contact, 4. Find Contact, 5. Delete Contact, 6. Exit");
        int.TryParse(Console.ReadLine(), out operationInput);
        //procedure/function
        switch (operationInput)
        {

            case 1:
                {
                    AddNewContact(names, lastNames, phoneNumbers, emails, addresses, sexs, ages, isFavorites, ids);

                    break;
                }
            case 2:
                {
                    Console.WriteLine("You chose to show contacts.");

                    Console.WriteLine("Here are your contacts:");
                    Console.WriteLine("ID\t\tName\t\tLast Name\t\tPhone Number\t\tEmail\t\tAddress\t\tSex\t\tAge\t\tFavorite");

                    //for (int i = 0; i < ids.Count; i++)
                    //{
                    //    var id = i + 1;
                    //    //Console.WriteLine($"{ids[i]}\t\t{names[i]}\t\t{lastNames[i]}\t\t{phoneNumbers[i]}\t\t{emails[i]}\t\t{addresses[i]}\t\t{sexs[i]}\t\t{ages[i]}\t\t{(isFavorites[i] ? "Yes" : "No")}");
                    //    Console.WriteLine($"{ids[id]}\t\t{names[id]}\t\t{lastNames[id]}\t\t{phoneNumbers[id]}\t\t{emails[id]}\t\t{addresses[id]}\t\t{sexs[id]}\t\t{ages[id]}\t\t{(isFavorites[id] ? "Yes" : "No")}");
                    //}

                    foreach (var id in ids)
                    {
                        Console.WriteLine($"{id}\t\t{names[id]}\t\t{lastNames[id]}\t\t{phoneNumbers[id]}\t\t{emails[id]}\t\t{addresses[id]}\t\t{sexs[id]}\t\t{ages[id]}\t\t{(isFavorites[id] ? "Yes" : "No")}");
                    }

                    break;
                }
            case 3:
                {
                    Console.WriteLine("You chose to edit a contact.");
                    Console.WriteLine("please enter the id of the contact you want to edit:");

                    var idInput = int.Parse(Console.ReadLine());

                    if (idInput < 1 || idInput > ids.Count)
                    {
                        Console.WriteLine("Invalid contact ID. Please try again.");
                        break;
                    }
                    //int findedindex2;
                    //foreach (var id in ids)
                    //{
                    //    if (id == idInput)
                    //    {
                    //        findedindex2 = ids.IndexOf(id);
                    //        findedindex2 = id - 1;
                    //    }
                    //}
                    //linq
                    var findIndex = ids.Where(p => p == idInput).FirstOrDefault();
                    if (findIndex == 0)
                    {
                        Console.WriteLine("Contact not found. Please try again.");
                        break;
                    }
                    //var name = names[idInput - 1];
                    //var lastName = lastNames[idInput - 1];
                    //var phoneNumber = phoneNumbers[idInput - 1];
                    //var email = emails[idInput - 1];
                    //var address = addresses[idInput - 1];
                    //var sex = sexs[idInput - 1];
                    //var age = ages[idInput - 1];
                    //var isFavorite = isFavorites[idInput - 1];
                    var name = names[idInput ];
                    var lastName = lastNames[idInput];
                    var phoneNumber = phoneNumbers[idInput];
                    var email = emails[idInput ];
                    var address = addresses[idInput];
                    var sex = sexs[idInput];
                    var age = ages[idInput ];
                    var isFavorite = isFavorites[idInput];

                    Console.WriteLine($"Current name: {name}. Please enter the new name (or press Enter to keep the current name):");
                    if (!string.IsNullOrEmpty(Console.ReadLine()))
                    {
                        //names[idInput - 1] = Console.ReadLine();
                        names[idInput] = Console.ReadLine();
                    }
                    //else
                    //{ 
                    //    names[idInput - 1] = name; 
                    //}
                    Console.WriteLine($"Current last name: {lastName}. Please enter the new last name (or press Enter to keep the current last name):");
                    if (!string.IsNullOrEmpty(Console.ReadLine()))
                    {
                        lastNames[idInput ] = Console.ReadLine();
                    }
                    Console.WriteLine($"Current phone number: {phoneNumber}. Please enter the new phone number (or press Enter to keep the current phone number):");
                    if (!string.IsNullOrEmpty(Console.ReadLine()))
                    {
                        phoneNumbers[idInput ] = Console.ReadLine();
                    }
                    Console.WriteLine($"Current email: {email}. Please enter the new email (or press Enter to keep the current email):");
                    if (!string.IsNullOrEmpty(Console.ReadLine()))
                    {
                        emails[idInput] = Console.ReadLine();
                    }
                    Console.WriteLine($"Current address: {address}. Please enter the new address (or press Enter to keep the current address):");
                    if (!string.IsNullOrEmpty(Console.ReadLine()))
                    {
                        addresses[idInput] = Console.ReadLine();
                    }
                    Console.WriteLine($"Current sex: {sex}. Please enter the new sex (or press Enter to keep the current sex   ");
                    if (!string.IsNullOrEmpty(Console.ReadLine()))
                    {
                        sexs[idInput ] = Console.ReadLine();
                    }
                    Console.WriteLine($"Current age: {age}. Please enter the new age (or press Enter to keep the current age):");
                    if (!string.IsNullOrEmpty(Console.ReadLine()))
                    {
                        ages[idInput ] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine($"Current favorite status: {(isFavorite ? "Yes" : "No")}. Please enter the new favorite status (1. yes 2. no, or press Enter to keep the current status):");
                    var isFavoriteInput = Console.ReadLine();
                    if (!string.IsNullOrEmpty(isFavoriteInput))
                    {
                        isFavorites[idInput ] = isFavoriteInput == "1";
                    }
                    break;
                }
            case 4:
                {
                    Console.WriteLine("You chose to find a contact.");
                    break;
                }
            case 5:
                {
                    Console.WriteLine("You chose to delete a contact.");
                    Console.WriteLine("Please enter the ID of the contact you want to delete:");
                    var idInput = int.Parse(Console.ReadLine());
                    if (idInput < 1 || idInput > ids.Count)
                    {
                        Console.WriteLine("Invalid contact ID. Please try again.");
                        break;
                    }
                    var indexToRemove = idInput - 1;

                    ids.RemoveAt(indexToRemove);
                    //names.RemoveAt(indexToRemove);
                    //lastNames.RemoveAt(indexToRemove);
                    //phoneNumbers.RemoveAt(indexToRemove);
                    //emails.RemoveAt(indexToRemove);
                    //addresses.RemoveAt(indexToRemove);
                    //sexs.RemoveAt(indexToRemove);
                    //ages.RemoveAt(indexToRemove);
                    //isFavorites.RemoveAt(indexToRemove);
                    names.Remove(idInput);
                    lastNames.Remove(idInput);
                    phoneNumbers.Remove(idInput);
                    emails.Remove(idInput);
                    addresses.Remove(idInput);
                    sexs.Remove(idInput);
                    ages.Remove(idInput);
                    isFavorites.Remove(idInput);



                    break;
                }
            case 6:
                {
                    Console.WriteLine("Exiting the program. Goodbye!");
                    running = false;
                    break;
                }
            default:
                {
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
                }
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}

static void AddNewContact(Dictionary<int, string> names, Dictionary<int, string> lastNames, Dictionary<int, string> phoneNumbers, Dictionary<int, string> emails, Dictionary<int, string> addresses, Dictionary<int, string> sexs, Dictionary<int, int> ages, Dictionary<int, bool> isFavorites, List<int> ids)
{
    Console.WriteLine("You chose to add a contact.");

    Console.WriteLine("Please enter the contact's name:");

    var name = Console.ReadLine();

    //if (name.Contains("@") || name.Contains("*"))
    //{
    //    Console.WriteLine("Invalid input for name. Name cannot contain '@'.");
    //    break;
    //}
    //if (name.Contains("*"))
    //{
    //    Console.WriteLine("Invalid input for name. Name cannot contain '@'.");
    //    break;
    //}

    Console.WriteLine("Please enter the contact's last name:");
    var lastName = Console.ReadLine();

    // lastNames.Add(Console.ReadLine());


    Console.WriteLine("Please enter the contact's phone number:");
    var phoneNumber = Console.ReadLine();

    Console.WriteLine("Please enter the contact's email:");
    var email = Console.ReadLine();
    //if (!email.Contains("@"))
    //{
    //    Console.WriteLine("Invalid input for email. Email must contain '@'.");
    //    break;
    //}

    Console.WriteLine("Please enter the contact's address:");
    var address = Console.ReadLine();
    Console.WriteLine("Please enter the contact sex:");
    var sexInput = Console.ReadLine();
    Console.WriteLine("Please enter the contact age:");
    int.TryParse(Console.ReadLine(), out int ageInput);

    Console.WriteLine("Is this contact a favorite? (1. yes 2. no):");
    //var isFavoriteInput = Console.ReadLine();
    bool isFavorite;

    //if (isFavoriteInput == "1")
    //{
    //    isFavorite = true;
    //}
    ////else if (isFavoriteInput == "2")
    ////{
    ////    isFavorite = false;
    ////}
    //else
    //{
    //    //Console.WriteLine("Invalid input for favorite status. Defaulting to 'no'.");
    //    isFavorite = false;
    //}

    //isFavorite = (isFavoriteInput == "1") ? true : false;
    //isFavorite = isFavoriteInput == "1";
    isFavorite = Console.ReadLine() == "1";

    var maxId = ids.Count > 0 ? ids.Max() : 0;
    var id = maxId + 1;
    AddingNewContactToDataStructure(names, lastNames, phoneNumbers, emails, addresses, sexs, ages, isFavorites, ids, name, lastName, phoneNumber, email, address, sexInput, ageInput, isFavorite, id);
}

static void AddingNewContactToDataStructure(Dictionary<int, string> names, Dictionary<int, string> lastNames, Dictionary<int, string> phoneNumbers, Dictionary<int, string> emails, Dictionary<int, string> addresses, Dictionary<int, string> sexs, Dictionary<int, int> ages, Dictionary<int, bool> isFavorites, List<int> ids, string? name, string? lastName, string? phoneNumber, string? email, string? address, string? sexInput, int ageInput, bool isFavorite, int id)
{
    ids.Add(id);

    names.Add(id, name);
    lastNames.Add(id, lastName);
    phoneNumbers.Add(id, phoneNumber);
    emails.Add(id, email);
    addresses.Add(id, address);
    sexs.Add(id, sexInput);
    ages.Add(id, ageInput);
    isFavorites.Add(id, isFavorite);
}