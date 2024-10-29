namespace OoopComposition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ContactInfo contactInfo1 = new ContactInfo();
            contactInfo1.Id = 1;
            contactInfo1.Mail = "mara@aspit.dk";

            ContactInfo contactInfo2 = new ContactInfo();
            contactInfo1.Id = 3;
            contactInfo1.Mail = "degr@aspin.dk";

            Person person1 = new Person();
            person1.Id = 1;
            person1.Name = "Mads";
            person1.ContactInfo = contactInfo1;

            Person person2 = new Person();
            person2.Id = 7;
            person2.Name = "Dea";
            person2.ContactInfo = contactInfo2;

            Address address = new Address();
            address.Id = 1;
            address.Persons.Add(person1);
            address.Persons.Add(person2);

            // Find alle mails på personer der bor på en bestemt adresse:
            List<string> mails = new();
            foreach(Person person in address.Persons)
            {
                string mailForThatPerson = person.ContactInfo.Mail;
                mails.Add(mailForThatPerson);
            }
        }
    }
}
