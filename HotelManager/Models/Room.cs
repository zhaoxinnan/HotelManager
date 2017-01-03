using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Models
{
    [Serializable]
    public class Room
    {
        #region Protected Members
        protected int roomId;//房间号ID
        protected string number = String.Empty;//房间号
        protected int typeID;//房间类型ID
        protected int bedNumber;//床位数
        protected string description = String.Empty;//房间描述
        protected string state = String.Empty;//房间状态
        protected int guestNumber;//入住客人数

       
        #endregion
        #region Public Methods
        public Room() { }
        #endregion
        #region
        public int RoomId
        {
            get
            {
                return roomId;
            }

            set
            {
                roomId = value;
            }
        }

        public string Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public int TypeID
        {
            get
            {
                return typeID;
            }

            set
            {
                typeID = value;
            }
        }

        public int BedNumber
        {
            get
            {
                return bedNumber;
            }

            set
            {
                bedNumber = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }
        public int GuestNumber
        {
            get
            {
                return guestNumber;
            }

            set
            {
                guestNumber = value;
            }
        }

        
        #endregion
    }
}
