using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static CrawlForm.Program;

namespace CrawlForm
{
    public class SimpleCrawler
    {

        private int count = 0;

        public void CrawlStart(string url)
        {
            SimpleCrawler myCrawler = new SimpleCrawler();
            try
            {
                new Uri(url);
            }
            catch (System.UriFormatException)
            {
                return;
            }
            string startUrl = url;
            urlsResult.Add(startUrl, false);//加入初始页面
            new Thread(myCrawler.Crawl).Start();
        }

        private void Crawl()
        {


            while (true)
            {
                string current = null;
                foreach (string url in urlsResult.Keys)
                {
                    if ((bool)urlsResult[url]) continue;
                    current = url;
                }


                if (current == null || count > 10) break;
                Console.WriteLine("爬行" + current + "页面!");
                string html = DownLoad(current); // 下载
                urlsResult[current] = true;
                count++;

                List<string> urlList = new List<string>();
                foreach (DictionaryEntry i in urlsResult)
                {
                    if((bool)i.Value==true)
                        urlList.Add(i.Key.ToString());
                }
                Parallel.ForEach(urlList, item => Parse(item)) ;
                Console.WriteLine("爬行结束");
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                if (urlsResult[strRef] == null) urlsResult[strRef] = false;
            }
        }


      private void Parse1(string html, string current)
        {
            string strRef = @"[/test]\d*[/page]\d*[.html]";
            MatchCollection matches = new Regex(strRef).Matches(html);

            foreach (Match match in matches)
            {
                strRef = current + match.Value;
                if (strRef.Length == 0) continue;
                if (urlsResult[strRef] == null) urlsResult[strRef] = false;
            }
        }

    }
}
