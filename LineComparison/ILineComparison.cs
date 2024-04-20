using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal interface ILineComparison
    {
        void Compare(double line1, double line2);
        void CheckEquality(double line1, double line2);
        double LengthOfLine();

    }
}
