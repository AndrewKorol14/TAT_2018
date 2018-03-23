using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDEV6.Test
{
    class CounterAllTests
    {

        public void ChooseTypeOfProductTest_ChooseTheType_TempList(/*List<ProductCreator> list*/)
        {
            List<ProductCreator> list = new List<ProductCreator>();
            list.Add(new ProductCreator("toy", "Dog", "10", "15"));
            list.Add(new ProductCreator("pencil", "Red", "50", "5"));
            list.Add(new ProductCreator("toy", "Cat", "15", "17"));
            CommandMenuCreator menu = new CommandMenuCreator();

        }

    }
}
