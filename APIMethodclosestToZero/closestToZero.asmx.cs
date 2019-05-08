using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace APIMethodclosestToZero
{
    /// <summary>
    /// Summary description for closestToZero
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class closestToZero : System.Web.Services.WebService
    {

       

        [WebMethod]
        public System.Single closestToZeroMethod(List<int> numbers)
        {

          
            if (numbers.Count > 0)
            {
                int a = numbers[0];
                int b;

                for (int i = 0; i <= numbers.Count - 1; i++)
                {
                    if (Math.Abs(a) > Math.Abs(numbers[i]))
                    {
                        a = numbers[i];
                    }
                    else if (Math.Abs(a) == Math.Abs((numbers[i])))
                    {
                        a = a > (numbers[i]) ? a : (numbers[i]);
                    }
                }

                return Convert.ToSingle(a);


            }
            else
                return Convert.ToSingle(0);
        }
    }
}
