using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceDEV11
{
    /// <summary>
    /// Create web service for getting day quantity
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class GetterDaysService : System.Web.Services.WebService
    {
        /// <summary>
        /// Gets quantity of days from the beginning of our era to inputted date
        /// </summary>
        /// <param name="date">Inputted date</param>
        /// <returns>Day quantity</returns>
        [WebMethod]
        public uint GetDayQuantity(DateTime date)
        {
            DateTime christmasDate = DateTime.MinValue;
            uint dayQuantity = (uint)(date - christmasDate).TotalDays;
            return dayQuantity;
        }
    }
}