using System.Linq;

namespace Anglo_API.Core
{
    public class EndpointUrl
    {
        private object[] UrlVariables;
        private readonly string FullUrlWithoutVariables;

        public string FullUrl => string.Format(FullUrlWithoutVariables, UrlVariables);

        public EndpointUrl(string apiRootUrl, string resourceName)
        {
            FullUrlWithoutVariables = UrlCombine(apiRootUrl, resourceName);
            UrlVariables = new object[] { };
        }

        /// <summary>
        /// If Endpoint URL contains {0}, {1}, etc., these variables will be used to replace them
        /// </summary>
        public void SetUrlVariables(params string[] variables) => 
            UrlVariables = variables.Cast<object>().ToArray();

        private static string UrlCombine(params string[] urls)
        {
            for (var i = 0; i < urls.Length; i++)
            {
                if (urls[i].EndsWith("/"))
                {
                    urls[i] = urls[i].Substring(0, urls[i].Length - 1);
                }

                if (urls[i].StartsWith("/"))
                {
                    urls[i] = urls[i].Substring(1, urls[i].Length - 1);
                }
            }

            return string.Join("/", urls.Where(url => !string.IsNullOrEmpty(url)).ToList());
        }
    }
}