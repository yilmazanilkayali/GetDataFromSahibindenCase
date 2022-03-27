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
        private IWebConnector connector;
        private readonly string SAHIBINDEN_URL = "https://www.sahibinden.com/";
        private readonly string SHOWCASE_ITEMS_XPATH = "//*[@id='container']/div[3]/div/div[3]/div[3]/ul/li";
        private readonly string ITEM_PRICE_XPATH = "//*[@id='classifiedDetail']/div/div[2]/div[2]/h3";
        private readonly string ITEM_TITLE_XPATH = "//*[@id='classifiedDetail']/div/div[1]/h1";

        public SahibindenConnector()
        {
            connector = new PageConnector();
        }
        public SahibindenConnector(IWebConnector connector)
        {
            this.connector = connector;
        }
        public void PrintShowcaseItems()
        {
            List<string> itemUrls = GetShowCaseItemsUrls();
            foreach (var itemUrl in itemUrls)
            {
                HtmlDocument htmlDocument = connector.GetHtmlDocumentByUrl(itemUrl);
                HtmlNode htmlNodePrice = htmlDocument.DocumentNode.SelectSingleNode(ITEM_PRICE_XPATH);
                HtmlNode htmlNodeTitle = htmlDocument.DocumentNode.SelectSingleNode(ITEM_TITLE_XPATH);
                if (htmlNodePrice != null && htmlNodeTitle != null)
                {
                    string price = htmlNodePrice.GetDirectInnerText().Trim();
                    string title = htmlNodeTitle.GetDirectInnerText().Trim();
                    Console.WriteLine("İlan Başlığı: " + title + "| İlan Fiyati: " + price);
                }
                    Thread.Sleep(2000);
            }
        }
        public List<string> GetShowCaseItemsUrls()
        {
            List<string> itemUrls = new List<string>();
            string itemUrlXpath = SHOWCASE_ITEMS_XPATH + "/a";
            HtmlDocument htmlDocument = connector.GetHtmlDocumentByUrl(SAHIBINDEN_URL);
            HtmlNodeCollection showcaseNodes = htmlDocument.DocumentNode.SelectNodes(itemUrlXpath);
            foreach (var showcaseItem in showcaseNodes)
            {
                itemUrls.Add(SAHIBINDEN_URL+showcaseItem.Attributes["href"].Value);
            }
            return itemUrls;
        }

    }
}
