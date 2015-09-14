using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.WebAPIAndUnitTests
{
    public class UnitTestCheck
    {
        public string TestCaseChecker(IMockChecker mc)
        {
            return mc.GetAppendedText("1") + "3";
        }
    }
}
