using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Models
{
    [Serializable]
    public class RoomType
    {
        protected int typeId;//房间类型ID
        protected string typeName = String.Empty;//房间名称
        protected decimal typePrice;//房间价格
        protected string addBedPrice;//添加床位的价格
        protected string isAddBed;//是否添加床位
        protected string remark;//备注
        public RoomType() { }
        public int TypeId
        {
            get
            {
                return typeId;
            }

            set
            {
                typeId = value;
            }
        }

        public string TypeName
        {
            get
            {
                return typeName;
            }

            set
            {
                typeName = value;
            }
        }

        public decimal TypePrice
        {
            get
            {
                return typePrice;
            }

            set
            {
                typePrice = value;
            }
        }

        public string AddBedPrice
        {
            get
            {
                return addBedPrice;
            }

            set
            {
                addBedPrice = value;
            }
        }

        public string IsAddBed
        {
            get
            {
                return isAddBed;
            }

            set
            {
                isAddBed = value;
            }
        }

        public string Remark
        {
            get
            {
                return remark;
            }

            set
            {
                remark = value;
            }
        }
    }
}
