using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JqWidgetsDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var request = WebRequest.Create("http://localhost:52949//V1/Exceptions.json/ExceptionType");

            request.Headers.Add("postman-token", "a1aaf269-4c8a-0c84-1587-81a12243f216");
            request.Headers.Add("cache-control", "no-cache");
            request.Headers.Add("emstoken", "Un5uRmMx/ktYs9zNa/tcmNK498ZN2sh0B7FvTMO2AVYbRMnpJ3AhblB/VsTaeMj2Ck9VnEmOQu6NXt+vpfLlXg==");
            request.Headers.Add("content-type", "application/json");
            WebResponse response = request.GetResponse();
        }
    }
}