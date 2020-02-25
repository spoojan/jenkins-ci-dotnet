using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWindowsService
{
    public class BugTest
    {
        public BugTest()
        {
            for (int i = 10; i < 10; i++) {
			//System.out.println("Loop not true even once");
		}
        }
        ~BugTest()
        {
            throw new NotImplementedException();
        }
    }
}
