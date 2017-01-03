using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Models
{
    [Serializable()]
     public class GuestCategory
    {
        private int categoryID;//客户类型ID
        private string categoryName=string.Empty;
        public GuestCategory() { }
        public int CategoryID
        {
            get
            {
                return categoryID;
            }

            set
            {
                categoryID = value;
            }
        }

        public string CategoryName
        {
            get
            {
                return categoryName;
            }

            set
            {
                categoryName = value;
            }
        }
    }
}
