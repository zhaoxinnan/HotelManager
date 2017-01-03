using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Models
{
    [Serializable]
    public class Guest
    {
        private int guestId;//客户ID
        private string name;//客户姓名
        private int categoryId;//客户类别
        private string sex;//客户性别
        private string mobile;//电话
        private int roomId;//房间号
        private DateTime arriveTime;//入住时间
        private DateTime leaveTime;//离开时间

        public int GuestId
        {
            get
            {
                return guestId;
            }

            set
            {
                guestId = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int CategoryId
        {
            get
            {
                return categoryId;
            }

            set
            {
                categoryId = value;
            }
        }

        public string Sex
        {
            get
            {
                return sex;
            }

            set
            {
                sex = value;
            }
        }

        public string Mobile
        {
            get
            {
                return mobile;
            }

            set
            {
                mobile = value;
            }
        }

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

        public DateTime ArriveTime
        {
            get
            {
                return arriveTime;
            }

            set
            {
                arriveTime = value;
            }
        }

        public DateTime LeaveTime
        {
            get
            {
                return leaveTime;
            }

            set
            {
                leaveTime = value;
            }
        }
    }
}
