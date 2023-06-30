using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Bb
{


    /*
      using (var fs = new FileStream(
                HostingEnvironment.MapPath(string.Format("~/Downloads/{0}.pdf", pdfGuid)),
                FileMode.CreateNew))
            {
                await response.Content.CopyToAsync(fs);
            }


     */

    public static partial class ContentHelper
    {


        public static void Download(this Uri url, FileInfo fileOutput, Action<HttpClient> initializer)
        {

            HttpClient client = new HttpClient();

            fileOutput.Refresh();
            if (fileOutput.Exists)
                throw new FileLoadException("local file allready exists");

            if (initializer != null)
                initializer(client);

            HttpResponseMessage response = client.GetAsync(url).Result;
            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {

                HttpContent content = response.Content;

                using (var fs = new FileStream(fileOutput.FullName, FileMode.CreateNew))
                    content.CopyToAsync(fs);

            }
            else
                throw new FileNotFoundException();

        }


    }


}
