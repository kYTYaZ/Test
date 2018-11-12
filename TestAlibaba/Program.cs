using System;
using System.Web;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.ComponentModel;
using System.Data;

namespace TestAlibaba
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Start info
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            String str = new String('=', 5);
            Console.WriteLine($"{str}{DateTime.Now}{str}");
            #endregion

            //testJson();
            //testSupplier();
            testWebDriver();

            #region End Info
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine($"{str}{DateTime.Now}{str}");
            Console.WriteLine($"Elapsed: {ts:c}");
            Console.WriteLine("THE END");
            Console.ReadLine();
            #endregion
        }

        private static void testWebDriver()
        {
            DataTable dataTable = new DataTable("Supplier");
            dataTable.Columns.Add("Code");
            dataTable.Columns.Add("Url");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Sid");
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--log-level=3");
            //chromeOptions.AddArgument("--disable-extensions");
            //chromeOptions.AddArgument("test-type");
            chromeOptions.AddArgument("--headless");
            //chromeOptions.AddArgument("--disable-gpu");
            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.SuppressInitialDiagnosticInformation = true;
            chromeDriverService.HideCommandPromptWindow = false;

            ChromeDriver driver = new ChromeDriver(chromeDriverService, chromeOptions);
            String url = "https://www.alibaba.com/trade/search?spm=a2700.supplier-normal.16.3.6dfa307a5MjBUV&f1=y&viewType=L&keyword=hotel_linen&n=50&indexArea=company_en";
            driver.Navigate().GoToUrl(url);
            while (true)
            {
                Int32 page = getCurrentPage(driver);
                Console.WriteLine($"Page: {page}");
                IReadOnlyCollection<IWebElement> elements = driver.FindElementsByXPath("//h2[@class='title ellipsis']/a");
                foreach (IWebElement element in elements)
                {
                    SupplierInfo supplier = new SupplierInfo(element);
                    DataRow row = dataTable.NewRow();
                    row["Code"] = supplier.Code;
                    row["Id"] = supplier.Id;
                    row["Name"] = supplier.Name;
                    row["Sid"] = supplier.Sid;
                    row["Url"] = supplier.Url;
                    dataTable.Rows.Add(row);
                }
                IWebElement webElement = driver.FindElementByXPath("//a[@class='next']");
                if (webElement.Enabled)
                    webElement.Click();
                else
                    break;
            };
            driver.Quit();
            dataTable.AcceptChanges();
        }

        private static Int32 getCurrentPage(ChromeDriver driver)
        {
            Int32 page = 0;
            try
            {
                page = Convert.ToInt32(driver.GetValue("//span[@class='current']"));
            }
            catch (Exception ex)
            {

                throw;
            }
            return page;
        }

        private static void testJson()
        {
            String json = "{id:2638,sid:235086180}";
            Dictionary<string, string> dic = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }

        private static void testSupplier()
        {
            String fileName = @"C:\AndrewHuang\Development\Visual Studio 2017\Projects\Test\TestAlibaba\Resources\Hotel Linen Suppliers - Reliable Hotel Linen Suppliers and Manufacturers at Alibaba.com.html";
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.OptionFixNestedTags = true;

            // filePath is a path to a file containing the html
            htmlDoc.Load(fileName);
            HtmlNodeCollection nodeList = htmlDoc.DocumentNode.SelectNodes("//h2[@class='title ellipsis']/a");
            foreach (HtmlNode node in nodeList)
            {
                SupplierInfo supplier = new SupplierInfo(node);
            }
        }
    }
    public class SupplierInfo
    {
        private String _Url = String.Empty;
        private String _Codes = String.Empty;
        public String Code { get; set; }
        public String Name { get; set; }
        public String Url { get; set; }
        public String Id { get; set; }
        public String Sid { get; set; }
        public SupplierInfo() { }
        public SupplierInfo(IWebElement element) : this()
        {
            this.Name = getValue(parentElement: element);
            this._Url = getValue(parentElement: element, attributeName: "href");
            this._Codes = getValue(parentElement: element, attributeName: "data-domdot");
            setProperties();
        }
        private void setProperties()
        {
            this.Url = getBasedUrl(this._Url);
            this.Code = getCode(this._Url);
            Dictionary<String, String> dic = JsonConvert.DeserializeObject<Dictionary<String, String>>(String.Concat("{", this._Codes, "}"));
            this.Id = dic["id"];
            this.Sid = dic["sid"];

        }
        public SupplierInfo(HtmlNode node) : this()
        {
            this.Name = getValue(parentNode: node);
            String url = getValue(parentNode: node, attributeName: "href");
            this.Url = getBasedUrl(url);
            this.Code = getCode(url);
            String codes = getValue(parentNode: node, attributeName: "data-domdot");
            Dictionary<String, String> dic = JsonConvert.DeserializeObject<Dictionary<String, String>>(String.Concat("{", codes, "}"));
            this.Id = dic["id"];
            this.Sid = dic["sid"];
        }
        private String getCode(String url)
        {
            String value = String.Empty;
            try
            {
                Uri uri = new Uri(url);
                String[] values = uri.Host.Split('.');
                value = values[0];
            }
            catch (Exception ex)
            {
            }
            return value;
        }
        private String getBasedUrl(String url)
        {
            String value = String.Empty;
            try
            {
                Uri uri = new Uri(url);
                value = $"{uri.Scheme}://{uri.Host}";
            }
            catch (Exception ex)
            {
            }
            return value;
        }
        private String getValue(HtmlNode parentNode, String xPath = "", String attributeName = "")
        {
            String value = String.Empty;
            try
            {
                HtmlNode node = String.IsNullOrEmpty(xPath) ? parentNode : parentNode.SelectSingleNode(xPath);
                if (node != null)
                    if (String.IsNullOrEmpty(attributeName))
                    {
                        value = HttpUtility.HtmlDecode(node.InnerText);
                    }
                    else
                        value = node.GetAttributeValue(attributeName, "");
            }
            catch (Exception ex)
            {

                throw;
            }
            return value.Trim();
        }
        private String getValue(IWebElement parentElement, String xPath = "", String attributeName = "")
        {
            String value = String.Empty;
            try
            {
                IWebElement element = String.IsNullOrEmpty(xPath) ? parentElement : parentElement.FindElement(By.XPath(xPath));
                if (element != null)
                    if (String.IsNullOrEmpty(attributeName))
                        value = HttpUtility.HtmlDecode(element.Text);
                    else
                        value = element.GetAttribute(attributeName);
            }
            catch (Exception ex)
            {

                throw;
            }
            return value.Trim();
        }
    }
    public static class Utilities
    {
        public static String GetValue(this ChromeDriver driver, String xPath, String attributeName = "")
        {
            String value = String.Empty;
            try
            {
                IWebElement element = driver.FindElement(By.XPath(xPath));
                if (element != null)
                    if (String.IsNullOrEmpty(attributeName))
                        value = HttpUtility.HtmlDecode(element.Text);
                    else
                        value = element.GetAttribute(attributeName);
            }
            catch (Exception ex)
            {

                throw;
            }
            return value.Trim();
        }

    }
}
