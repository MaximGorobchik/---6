using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Book_Shop
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook (string name, string authorname, string authorsurname, double price) : base(name, authorname, authorsurname, price)
        {
        }
        public override double Price
        {
            get { return base.Price * 1.3; }
        }
    }
}
