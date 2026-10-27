
namespace StudentManagement.DataLayer
{
    public class User
    {

        public string firstName { get; set; }

        public string lastName { get; set; }
        public int age { get; set; }
        public string phoneNumber { get; set; }

        public string nationalCode { get; set; }


        public User(string firstName, string lastName, int age, string phoneNumber, string nationalCode)
        {
            if(string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName)|| string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(nationalCode) || age == 0  )
            {
                throw new Exception("All the fields must be filled! Please fill all of the fields.");
            }
            this.phoneNumber = phoneNumber;
            this.lastName = lastName;
            this.firstName = firstName;
            this.nationalCode = nationalCode;
            this.age = age;
        }


    }
}
