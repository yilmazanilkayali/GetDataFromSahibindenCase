using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GetDataFromSahibinden.com
{
    public class PageConnector
    {
        private WebClient client;
        public PageConnector()
        {
            client = new WebClient();
        }
        public string GetHtmlAsString(string pageUrl)
        {
            Uri url = new Uri("https://www.sahibin.com/erkek-spor-ayakkabi-x-g2-c109?pi=9");
            return client.DownloadString(url);
        }
        public HtmlDocument GetHtmlDocument(string html)
        {
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);
            return htmlDocument;
        }
        public HtmlDocument GetHtmlDocumentByUrl(string pageUrl)
        {
            return GetHtmlDocument(GetHtmlAsString(pageUrl));
        }
    }
}
