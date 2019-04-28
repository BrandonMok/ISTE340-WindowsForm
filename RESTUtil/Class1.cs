using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RESTUtil
{
    public class REST
    {
        // Base Uri
        private string baseUri;

        // Constructor
        public REST(string bUri)
        {
            this.baseUri = bUri;
        }


        #region getRestData

        public string getRESTDataJSON(string uri)
        {
            // connect to the api
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUri + uri);

            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException we)
            {
                WebResponse err = we.Response;
                using (Stream responseStream = err.GetResponseStream())
                {
                    StreamReader r = new StreamReader(responseStream, Encoding.UTF8);
                    return r.ReadToEnd();
                }
            }
        }
        #endregion


        //public string getRESTDataXML(string uri) { }
    }
}
