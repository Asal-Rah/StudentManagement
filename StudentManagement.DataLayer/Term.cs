using StudentManagement.DataLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DataLayer
{
    public class Term
    {
        public int Id {  get; set; }
        public string code {  get; set; }

        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public TermSeason termSeason { get; set; }

        

        
        

    }
}
