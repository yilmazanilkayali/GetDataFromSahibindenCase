
using GetDataFromSahibinden.com;
using HtmlAgilityPack;
using System.Net;






foreach (var title in titles)
{
    string link = title.Attributes["title"].Value;
    Console.WriteLine(link);
}



















































//Uri url = new Uri("https://www.trendyol.com/erkek-spor-ayakkabi-x-g2-c109");

//WebClient webClient = new WebClient();

//string html = webClient.DownloadString(url);
////Console.WriteLine(html);
//HtmlDocument htmlDocument = new HtmlDocument();
//htmlDocument.LoadHtml(html);
                                                                        
//HtmlNodeCollection titles = htmlDocument.DocumentNode.SelectNodes("//*[@id='search-app']/div/div[1]/div/div/div/div/div/a");
////*[@id="container"]/div[3]/div/div[3]/div[3]/ul/li[1]/a
////*[@id='__layout']/div/div/div[1]/div[2]/div[2]/div[4]/div[1]/div[1]/div/article/div/header/h3/a  onedio
//Console.WriteLine(titles.Count);
////Console.WriteLine(titles[0].Attributes["href"].Value);
////*[@id='container']/div[3]/div/div[3]/div[3]/ul/li/a sahibnden başlık
//List<string> hrefList = new List<string>();
//foreach (var title in titles)
//{
//    string link = title.Attributes["href"].Value;
//    hrefList.Add("https://www.trendyol.com"+link);
//    Console.WriteLine(link);
//}//*[@id="__layout"]/div/div/div[1]/div[1]/div/header/div[1]/div/a
//foreach (string item in hrefList)
//{
//    Console.WriteLine(item+" hreflist");
//    Uri hrefUrl = new Uri(item);
//    WebClient detailclient = new WebClient();
//    string detailhtml = detailclient.DownloadString(hrefUrl);
//    HtmlDocument detailhtmlDocument = new HtmlDocument();
//    detailhtmlDocument.LoadHtml(detailhtml);
//    HtmlNodeCollection prices = detailhtmlDocument.DocumentNode.SelectNodes("//*[@id='product-detail-app']/div/div[2]/div[1]/div[2]/div[2]/div/div/div/div/div/span");                                                            
//    // Console.WriteLine(price);
//    foreach (var price in prices)
//    {
//        var prc = price.InnerHtml;
//        Console.WriteLine(prc);
//    }
//}







//string adres = "https://www.sahibinden.com/";
//WebRequest istek = HttpWebRequest.Create(adres);
//WebResponse cevap;
//cevap = istek.GetResponse();
//StreamReader donenbilgiler = new StreamReader(cevap.GetResponseStream());
//string gelen=donenbilgiler.ReadToEnd();
//int baslikbaslangic = gelen.IndexOf("<title>") + 7;
//int baslikbitis = gelen.Substring(baslikbaslangic).IndexOf("<title>");
//string baslik = gelen.Substring(baslikbaslangic, baslikbitis);
//Console.WriteLine(baslik);






