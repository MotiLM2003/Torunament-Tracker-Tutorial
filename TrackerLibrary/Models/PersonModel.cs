using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Model
{
    public class PersonModel
    {

        public int Id { set; get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string CellphoneNumber { set; get; }

        public string FullName
        {
            get
            {
                return $"{LastName} {FirstName}";
            }
        }
    }
}
