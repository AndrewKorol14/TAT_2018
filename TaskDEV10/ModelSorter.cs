using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDEV10
{
    class ModelSorter
    {
        public List<Car> SortModels(List<Car> modelList)
        {
            var sortedModelList = modelList.OrderByDescending(model => model.ModelNumber);
            return sortedModelList.ToList();
        }
    }
}