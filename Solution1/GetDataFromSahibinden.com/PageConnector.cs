using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GetDataFromSahibinden.com
{
    public class PageConnector : IWebConnector
    {
        
        private WebClient client;
        public PageConnector()
        {
            client = new WebClient();
        }
        //url üzerindeki html dosyası string olarak alınır.
        public string GetHtmlAsString(string pageUrl)
        {
            Uri url = new Uri(pageUrl);           
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            client.Headers.Add("sec-ch-ua-platform", "Windows");
            client.Headers.Add("referer", "https://www.sahibinden.com/");
            client.Headers.Add("upgrade-insecure-requests", "1");
            return client.DownloadString(url);
            
        }
        public HtmlDocument GetHtmlDocument(string html)
        {
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);
            return htmlDocument;
        }
        //detay sayfaları için HtmlDocument url'lerini alir.
        public HtmlDocument GetHtmlDocumentByUrl(string pageUrl)
        {
            return GetHtmlDocument(GetHtmlAsString(pageUrl));
        }
    }
}
