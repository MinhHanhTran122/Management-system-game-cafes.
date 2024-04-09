using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYQUANNET
{
    internal class MayTram
    {
        string id, name;
        int im_price;
        string pic;
        public MayTram(string i, string n, int p = 0, string pi = "")
        {
            Id = i;
            Name = n;
            im_price = p;
            pic = pi;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Im_price { get => im_price; set => im_price = value; }
        public string Pic { get => pic; set => pic = value; }

    }
}
