using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test_Exam_Task_4.Models;
using Newtonsoft.Json;

namespace Test_Exam_Task_4.Controllers
{
    public class ValuesController : ApiController
    {
        public IHttpActionResult Get(string s = "")
        {
            Model data = new Model();
            data.method = "GET";
            data.s = s;

            return Json(data, new JsonSerializerSettings
            {
                DefaultValueHandling = DefaultValueHandling.Ignore
            });
        }

        public IHttpActionResult Post(int x, string s, DateTime d)
        {
            Model data = new Model();
            data.method = "POST";
            data.x = x;
            data.d = d;
            data.s = s;

            return Json(data, new JsonSerializerSettings
            {
                DefaultValueHandling = DefaultValueHandling.Ignore
            });
        }

        public IHttpActionResult Put(int x, string s, DateTime d)
        {
            Model data = new Model();
            data.method = "PUT";
            data.s = s;
            data.d = d;
            data.x = x;

            return Json(data, new JsonSerializerSettings
            {
                DefaultValueHandling = DefaultValueHandling.Ignore
            });

        }

        public IHttpActionResult Delete(int x)
        {
            Model data = new Model();
            data.method = "DELETE";
            data.x = x;

            return Json(data, new JsonSerializerSettings
            {
                DefaultValueHandling = DefaultValueHandling.Ignore
            });

        }
    }
}
