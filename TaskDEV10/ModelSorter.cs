using System.Collections.Generic;
using System.Linq;
namespace TaskDEV10
{
    /// <summary>
    /// Create sorter for list of models
    /// </summary>
    class ModelSorter
    {
        /// <summary>
        /// Sort by descending list of models
        /// </summary>
        /// <param name="modelList">Unsorted list of models</param>
        /// <returns>Sorted list of models</returns>
        public List<Car> SortByDescendingModels(List<Car> modelList)
        {
            var sortedModelList = modelList.OrderByDescending(model => model.ModelNumber);
            return sortedModelList.ToList();
        }
    }
}