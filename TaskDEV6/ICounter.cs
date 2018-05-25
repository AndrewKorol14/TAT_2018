using System.Collections.Generic;

namespace TaskDEV6
{
    /// <summary>
    /// Determines the function of counting 
    /// </summary>
    public interface ICounter
    {
        double CountByCommand(List<ProductCreator> list);
    }
}