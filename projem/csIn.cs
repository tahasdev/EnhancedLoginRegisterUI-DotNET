using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projem
{
    public class csIn
    {
        public static void Durum(BaglantiDurumu d)
        {
            connection.Instance?.BaglantiDurumunuIsle(d);
        }
    }
}


