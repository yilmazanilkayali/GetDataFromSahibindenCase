using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDataFromSahibinden.com
{
    public class SahibindenConnector
    {
        private PageConnector connector;
        private readonly string SAHIBINDEN_URL = "www.sahibinden.com";
        private readonly string SHOWCASE_ITEMS_XPATH= "//*[@id='container']/div[3]/div/div[3]/div[3]/ul/li";
        public SahibindenConnector()
        {
            connector = new PageConnector();
        }
        public HtmlNodeCollection GetShowcaseItems()
        {
            
        }
        //HtmlNodeCollection titles = htmlDocument.DocumentNode.SelectNodes("//div[contains(@class,'p-card-wrppr')]");
        public List<string> GetShowCaseItemsUrls()
        {
            List<string> itemUrls = new List<string>();
            string itemUrlXpath = SHOWCASE_ITEMS_XPATH + "/a";
            HtmlDocument htmlDocument = connector.GetHtmlDocumentByUrl(SAHIBINDEN_URL);
            HtmlNodeCollection showcaseNodes = htmlDocument.DocumentNode.SelectNodes(itemUrlXpath);
            foreach (var showcaseItem in showcaseNodes)
            {
                itemUrls.Add(showcaseItem.Attributes["href"].Value);
            }
            return itemUrls;
        }

    }
}
