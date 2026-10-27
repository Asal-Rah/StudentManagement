using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DataLayer
{
    public class Professor : User

    {
        public Dictionary<string, string> Banks = new()
            {
                { "2071", "Tosee Saderat" },
                { "5022", "Pasargad" },
                { "5028", "Shahr" },
                { "5029", "Tosee Taavon / Karafarin / Dey" },
                { "5041", "Resalat" },
                { "5047", "Shahr" },
                { "5054", "Gardeshgari" },
                { "5057", "Iran Zamin" },
                { "5058", "Khavarmianeh / Kosar" },
                { "5076", "Noor" },
                { "5818", "Iran Venezuela" },
                { "5859", "Tejarat / Khavarmianeh" },
                { "5892", "Sepah" },
                { "5894", "Refah" },
                { "6037", "Melli / Saderat / Keshavarzi" },
                { "6049", "Sepah" },
                { "6062", "Melal" },
                { "6063", "Mehr Iran" },
                { "6067", "Mehr Eghtesad" },
                { "6104", "Mellat" },
                { "6219", "Saman" },
                { "6221", "Parsian" },
                { "6273", "Tejarat / Ansar" },
                { "6274", "Eghtesad Novin / Karafarin" },
                { "6276", "Tosee Saderat" },
                { "6277", "Post Bank" },
                { "6278", "Parsian" },
                { "6279", "Sanat va Madan" },
                { "6280", "Maskan" },
                { "6281", "Tosee Credit Institution" },
                { "6362", "Ayandeh (Melli)" },
                { "6367", "Central Bank" },
                { "6369", "Hekmat Iranian" },
                { "6391", "Parsian" },
                { "6392", "Keshavarzi" },
                { "6393", "Sina / Pasargad / Mehr Eghtesad" },
                { "6395", "Ghavamin" },
                { "6396", "Sarmayeh" },
                { "9919", "Mellat" }
            };
        public String card { get; set; }
        public Professor(string firstName, string lastName, int age, string phoneNumber, string nationalCode, string card) : base(firstName, lastName, age, phoneNumber, nationalCode)
        {
            if(card.Length < 16)
            {
                throw new Exception("No card number can be less than 16 numbers. Please enter a valid card");
            }
            if (!Banks.TryGetValue(card[0..4], out string? Name))
            {
                throw new Exception("The card you have entered doesn't belong to any bank!!Please enter a valid card");
               
            }
            
            this.card = card;

        }
    }
}
