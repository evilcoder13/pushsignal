using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net;
using System.Text;


namespace CanhBaoPushSignal.Controllers
{
    [Route("[controller]")]
    public class SendAlarm:Controller
    {
        [HttpGet]
        public string Get(string msg) {
            var request = WebRequest.Create("https://onesignal.com/api/v1/notifications") as HttpWebRequest;

            request.KeepAlive = true;
            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";

            request.Headers.Add("authorization", "Basic YmVkNzIxMjMtNzJlZS00MDA4LWFiZmMtY2IyYmZkYjA4NWFl");

            byte[] byteArray = Encoding.UTF8.GetBytes("{"
                                                    + "\"app_id\": \"f6f8f007-7c11-4fe2-b3b7-e4c28332f793\","
                                                    + "\"contents\": {\"en\": \""+msg+"\"},"
                                                    + "\"included_segments\": [\"All\"]}");

            string responseContent = null;

            try {
                using (var writer = request.GetRequestStream()) {
                    writer.Write(byteArray, 0, byteArray.Length);
                }

                using (var response = request.GetResponse() as HttpWebResponse) {
                    using (var reader = new StreamReader(response.GetResponseStream())) {
                        responseContent = reader.ReadToEnd();
                    }
                }
            }
            catch (WebException ex) {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(new StreamReader(ex.Response.GetResponseStream()).ReadToEnd());
            }

            return responseContent;
        }
    }
}