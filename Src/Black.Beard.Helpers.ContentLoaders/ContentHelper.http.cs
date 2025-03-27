namespace Bb
{


    public static partial class ContentHelper
    {

        /// <summary>
        /// Downloads content from a URL and saves it to a local file.
        /// </summary>
        /// <param name="url">The URL to download content from. Must not be null.</param>
        /// <param name="fileOutput">The file to save the downloaded content to. Must not be null and must not already exist.</param>
        /// <param name="initializer">Optional action to configure the HTTP client before the request is made.</param>
        /// <remarks>
        /// This method downloads content from the specified URL using an HTTP GET request and saves it to the specified file.
        /// If the file already exists, a FileLoadException is thrown.
        /// The method will await the result of the HTTP request and ensure a successful status code.
        /// If the initializer is provided, it will be used to configure the HttpClient before making the request.
        /// </remarks>
        /// <exception cref="System.IO.FileLoadException">Thrown when the target file already exists.</exception>
        /// <exception cref="System.IO.FileNotFoundException">Thrown when the HTTP request fails.</exception>
        /// <exception cref="System.Net.Http.HttpRequestException">Thrown when the HTTP request fails or returns a non-success status code.</exception>
        /// <exception cref="System.ArgumentNullException">Thrown when url or fileOutput is null.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Basic download example
        /// Uri sourceUrl = new Uri("https://example.com/file.txt");
        /// FileInfo targetFile = new FileInfo("C:\\Downloads\\file.txt");
        /// sourceUrl.Download(targetFile);
        /// 
        /// // Download with HTTP client configuration
        /// Uri secureUrl = new Uri("https://api.example.com/secured/document.pdf");
        /// FileInfo pdfFile = new FileInfo("C:\\Downloads\\document.pdf");
        /// secureUrl.Download(pdfFile, client => {
        ///     client.DefaultRequestHeaders.Add("Authorization", "Bearer myToken123");
        ///     client.Timeout = TimeSpan.FromMinutes(5);
        /// });
        /// </code>
        /// </example>
        public static void Download(this Uri url, FileInfo fileOutput, Action<HttpClient>? initializer = null)
        {

            HttpClient client = new HttpClient();

            fileOutput.Refresh();
            if (fileOutput.Exists)
                throw new FileLoadException("local file already exists");

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
