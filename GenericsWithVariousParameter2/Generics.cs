using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsWithVariousParameter2
{
    public  class Generics
    {
        public void Show<T1,T2>(T1 first ,T2 second)
        {
            Console.WriteLine("First variable value :{0}\nsecong variable value: {1}\n", first, second);
        }
    }
}
