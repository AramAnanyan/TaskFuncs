using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFuncs
{
    public class Funcs
    {
        public void func1()
        {
            for(int i=0; i < 100; i++)
            {
                Console.WriteLine("666666666666666");
            }
        }
        public void func2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("2222");
            }
        }
        public async Task task1()
        {
             await Task.Run(() =>
             {
                 for (int i = 0; i < 100; i++)
                 {
                     Task.Delay(100);
                     Console.WriteLine("11111111111111111111" + i);
                 }

                 
             });
        }
        public async Task task2()
        {
            await Task.Run(() => func2());
        }
    }
}
