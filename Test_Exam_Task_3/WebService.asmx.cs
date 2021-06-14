using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Test_Exam_Task_3
{
    /// <summary>
    /// Сводное описание для WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        [WebMethod]
        public int sum(int x, int y)
        {
            return x + y;
        }

        [WebMethod]
        public int mul(int x, int y)
        {
            return x * y;
        }

        [WebMethod]
        public int sub(int x, int y)
        {
            return x - y;
        }
    }
}
