using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnluCo.Bitirme.DataAcces.Dtoes
{
    public class OfferwithProductDto:ProductsbycategoryDto
    {
        public int OfferUserID { get; set; }


        public int OfferPrice { get; set; }
    }
}
