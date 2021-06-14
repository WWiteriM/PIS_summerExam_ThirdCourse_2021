using System.Web;

namespace Test_Exam_Task_1
{
    public class Handler1 : IHttpHandler
    {
        public bool IsReusable => true;

        public void ProcessRequest(HttpContext content)
        {
            HttpResponse res = content.Response;
            string firstParm = content.Request.QueryString["first"];
            string secondParm = content.Request.QueryString["second"];
            res.ContentType = "application/json";
            res.Write($"Get Http handler is working. Query params is ${firstParm} and ${secondParm}");
        }
    }

    public class Handler2 : IHttpHandler
    {
        public bool IsReusable => true;

        public void ProcessRequest(HttpContext content)
        {
            HttpResponse res = content.Response;
            string firstParm = content.Request.Params["first"];
            string secondParm = content.Request.Params["second"];
            res.ContentType = "text/plain";
            res.Write($"POST Http handler is working. Params: first - ${firstParm}, second - ${secondParm}");
        }
    }

    public class Handler3 : IHttpHandler
    {
        public bool IsReusable => true;

        public void ProcessRequest(HttpContext content)
        {
            HttpResponse res = content.Response;
            
            if(content.Request.HttpMethod == "GET")
            {

                res.WriteFile("./Page.html");

            } else if(content.Request.HttpMethod == "POST") {

                string x = content.Request.Params["x"];
                string y = content.Request.Params["y"];
                int sum = int.Parse(x) + int.Parse(y);
                res.ContentType = "text/plain";
                res.Write($"{sum}");

            } else {

                res.StatusCode = 400;
                res.End();

            }
        }
    }
}