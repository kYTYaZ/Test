
private static void testUpdateImageUrl()
{
    var htmlString = System.IO.File.ReadAllText(@"C:\TFS\WebSan\AHuangTesting\Main\Test\TestConsoleApplication\TestFiles\Email.html");
    HtmlDocument htmlDoc = new HtmlDocument();
    htmlDoc.LoadHtml(htmlString);
    HtmlNodeCollection nodes = htmlDoc.DocumentNode.SelectNodes("//img");
    foreach (HtmlNode node in nodes)
    {
        string value = node.GetAttributeValue("src", "");
        node.SetAttributeValue("scr", "new value");
    }
    nodes = htmlDoc.DocumentNode.SelectNodes("//img");
    htmlDoc.Save(@"C:\TFS\WebSan\AHuangTesting\Main\Test\TestConsoleApplication\TestFiles\Email-01.html");

    using (MemoryStream ms = new MemoryStream())
    {
        StreamWriter sw = new StreamWriter(ms);
        htmlDoc.Save(sw);
        sw.Flush();
        ms.Position = 0;
        StreamReader sr = new StreamReader(ms);
        htmlString = sr.ReadToEnd();
        sw.Dispose();
        sr.Dispose();
    }

    using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
    {
        htmlDoc.Save(ms);
        ms.Flush();
        StreamReader sr = new StreamReader(ms);
        htmlString = sr.ReadToEnd();
    }
}
