using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_Exam_Task_4.Models
{
    public class Model
    {
        [JsonProperty("method")]
        public string method { get; set; }

        [JsonProperty("s")]
        public string s { get; set; }

        [JsonProperty("x")]
        public int x { get; set; }

        [JsonProperty("d")]
        public DateTime d { get; set; }

    }


}