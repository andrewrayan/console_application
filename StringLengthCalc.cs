using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleappliation
{
    class StringLengthCalc
    {
        public void Calculate(string value)
        {
            if (value.Length == 0)
            {
                Console.WriteLine("Empty string.");
            }
            else
            {
                ArrayList arrayList = new ArrayList();
                for(int i = 0; i< value.Length; i++)
                {
                    char _char = value[i];
                    if (arrayList.Contains(_char))
                    {
                        continue;
                    }
                    for(int j = i + 1; j < value.Length; j++)
                    {
                        if(value[i]== value[j])
                        {
                            arrayList.Add(value[i]);
                        }
                    }
                }
                Console.WriteLine("Repeated Charaters are");
                foreach(var i in arrayList)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
