using System.Reflection.Metadata.Ecma335;

namespace StudentManagement.BusinessLayer.Extensions
{
    public static class Extensions
    {
        public static string ToMoblieFormat(this string phoneNumber)
        {
            if(phoneNumber.StartsWith("+98"))
            {
                phoneNumber = phoneNumber.Replace("+98", "0");
            }
            if(phoneNumber.StartsWith("9") && phoneNumber.Length == 10)
            {
                phoneNumber = "0" + phoneNumber;
            }
            if(phoneNumber.StartsWith("0") && phoneNumber.Length == 11)
            {
                return phoneNumber;
            }
            else
            {
                throw new Exception("The format of the phone number you have entered is not correct!!");
                
            }

            return phoneNumber;

        }
    }
}
