using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDataFromSahibinden.com
{
    public interface IWebConnector
    {
        public string GetHtmlAsString(string pageUrl);
        public HtmlDocument GetHtmlDocument(string html);
        public HtmlDocument GetHtmlDocumentByUrl(string pageUrl);
    }
}
