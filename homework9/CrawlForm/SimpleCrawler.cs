﻿using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using static CrawlForm.Program;

namespace CrawlForm
{
    public class SimpleCrawler {

    private int count = 0;

    public void CrawlStart(string url) {
      SimpleCrawler myCrawler = new SimpleCrawler();
      string startUrl = url;
      urlsResult.Add(startUrl, false);//加入初始页面
      new Thread(myCrawler.Crawl).Start();
    }

    private void Crawl() {
      Console.WriteLine("开始爬行了.... ");
      while (true) {
        string current = null;
        foreach (string url in urlsResult.Keys) {
          if ((bool)urlsResult[url]) continue;
          current = url;
        }

        if (current == null || count > 10) break;
        Console.WriteLine("爬行" + current + "页面!");
        string html = DownLoad(current); // 下载
        urlsResult[current] = true;
        count++;
        Parse(html);//解析,并加入新的链接
        Console.WriteLine("爬行结束");
      }
    }

    public string DownLoad(string url) {
      try {
        WebClient webClient = new WebClient();
        webClient.Encoding = Encoding.UTF8;
        string html = webClient.DownloadString(url);
        string fileName = count.ToString();
        File.WriteAllText(fileName, html, Encoding.UTF8);
        return html;
      }
      catch (Exception ex) {
        Console.WriteLine(ex.Message);
        return "";
      }
    }

    private void Parse(string html) {
      string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+(html|jsp|aspx){1}[]*[""']";
      MatchCollection matches = new Regex(strRef).Matches(html);
      foreach (Match match in matches) {
        strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                  .Trim('"', '\"', '#', '>');
        if (strRef.Length == 0) continue;
        if (urlsResult[strRef] == null) urlsResult[strRef] = false;
      }
    }
  }
}