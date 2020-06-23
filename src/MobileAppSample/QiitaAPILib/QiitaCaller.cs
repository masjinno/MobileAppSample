using log4net;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QiitaAPILib
{
    public class QiitaCaller
    {
        private static ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<string> GetTitles()
        {
            try
            {
                string url = "https://qiita.com/api/v2/items/4298795029ba9f67b9d2";
                WebRequest request = WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "application/json";
                Stream responseStream = request.GetResponse().GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                string responseJson = reader.ReadToEnd();
                log.DebugFormat("reader.ReadToEnd()={0}", responseJson);
                JObject responseJsonObject = JObject.Parse(responseJson);

                log.DebugFormat("responseJson={0}", responseJson);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("Caught an exception: {0}, Message={1}", ex.GetType(), ex.Message);
                throw ex;
            }

            return null;
        }
    }
}
