using OOP_3_Interface.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3_Interface.Models
{
    public class OrderDetail : BaseEntity
    {
        public HamburgerMenu ChoosenMenu { get; set; }
        public HamburgerSize Size { get; set; }
        public List<Extra> Extras { get; set; }
        public int Count { get; set; }

        public OrderDetail(string name)
        {
            Extras = new List<Extra>();
            Name = name;
        }

        public override string ToString()
        {
            if(Extras.Count < 1)
            {
                return $"{Name} adlı kişisinden,{Size} Boy , {Count}x Adet {ChoosenMenu},";
            }

            string extraSources = null;
            foreach (Extra item in Extras)
            {
                extraSources += $"{item.Name},";
            }
            extraSources = extraSources.TrimEnd(',');

            return $"{Name} adlı kişisinden,{Size} Boy , {extraSources}, {Count}x Adet Seçilen Menu: {ChoosenMenu.Name}, Toplam Fiyat : {Price} TL";
        }

        public void CalculateTotalFee()
        {
            Price += ChoosenMenu.Price;

            switch (Size)
            {
                case HamburgerSize.Medium:
                    Price += 1;
                    break;
                case HamburgerSize.Big:
                    Price += 2;
                    break;
                default:
                    break;
            }


            foreach (Extra item in Extras)
            {
                Price += item.Price;
            }

            Price *= Count;

          
        }

    }
}
