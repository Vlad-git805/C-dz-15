using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;

            //XmlDocument xdoc = new XmlDocument();

            //xdoc.Load("https://api.privatbank.ua/p24api/pubinfo?exchange&coursid=11");


            //XmlNodeList xNodelst = xdoc.DocumentElement.SelectNodes("//exchangerates/row");

            //int a = 0;
            //foreach (XmlNode xNode in xNodelst)
            //{
            //    a++;
            //    Console.Write(a + " - ");
            //    Console.WriteLine($"{xNode.SelectSingleNode("exchangerate").SelectSingleNode("@ccy").Value}");
            //}
            //Console.WriteLine("Select your valute: ");
            //int select = int.Parse(Console.ReadLine());
            //Console.WriteLine("Select valute to convert: ");
            //int select2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter count of your valute:");
            //int count_your_valute = int.Parse(Console.ReadLine());

            //decimal price_your_valute = 0;
            //decimal price_convert_valute = 0;

            //int f = 0;
            //foreach (XmlNode xNode in xNodelst)
            //{

            //    f++;
            //    if (f == select)
            //    {
            //        string str = xNode.SelectSingleNode("exchangerate").SelectSingleNode("@buy").Value;
            //        price_your_valute = decimal.Parse(str, CultureInfo.InvariantCulture);
            //    }
            //    if (f == select2)
            //    {
            //        string str = xNode.SelectSingleNode("exchangerate").SelectSingleNode("@buy").Value;
            //        price_convert_valute = decimal.Parse(str, CultureInfo.InvariantCulture);
            //    }
            //}

            //decimal result = 0;
            //price_your_valute = price_your_valute * count_your_valute;
            //result = price_your_valute / price_convert_valute;
            //Console.WriteLine(result);


            Console.OutputEncoding = Encoding.UTF8;

            XmlDocument xdoc = new XmlDocument();

            List<int> maxTemp = new List<int>();

            int choise = -1;
            do
            {
                Console.WriteLine("1 - Алма-Ата");
                Console.WriteLine("2 - Астана");
                Console.WriteLine("3 - Ашхабад");
                Console.WriteLine("4 - Баку");
                Console.WriteLine("5 - Москва");
                Console.WriteLine("6 - Вильнюс");
                Console.WriteLine("7 - Душанбе");
                Console.WriteLine("8 - Ереван");
                Console.WriteLine("9 - Киев");
                Console.WriteLine("10 - Кишинев");
                Console.WriteLine("11 - Минск");
                Console.WriteLine("12 - Рига");
                Console.WriteLine("13 - Таллинн");
                Console.WriteLine("14 - Ташкент");
                Console.WriteLine("15 - Тбилиси");
                Console.WriteLine("16 - Сама тепла погода");
                Console.WriteLine("17 - добавити нове місто");
                Console.WriteLine("0 - exit");
                Console.WriteLine("Choose the city where you want to see the weather: ");
                choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        {
                            Console.WriteLine("Алма - Ата");
                            xdoc.Load("http://informer.gismeteo.by/rss/36870.xml");
                            XmlNodeList xNodelst = xdoc.DocumentElement.SelectNodes("//rss/channel/item");
                            int a = 0;
                            foreach (XmlNode xNode in xNodelst)
                            {
                                if (a == 3)
                                {
                                    Console.WriteLine($"{xNode.SelectSingleNode("description").InnerText}");
                                }
                                a++;
                            }
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Астана");
                            xdoc.Load("http://informer.gismeteo.by/rss/35188.xml");
                            XmlNodeList xNodelst = xdoc.DocumentElement.SelectNodes("//rss/channel/item");
                            int a = 0;
                            foreach (XmlNode xNode in xNodelst)
                            {
                                if (a == 3)
                                {
                                    Console.WriteLine($"{xNode.SelectSingleNode("description").InnerText}");
                                }
                                a++;
                            }
                            Console.ReadLine();
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Ашхабад");
                            xdoc.Load("http://informer.gismeteo.by/rss/38880.xml");
                            XmlNodeList xNodelst = xdoc.DocumentElement.SelectNodes("//rss/channel/item");
                            int a = 0;
                            foreach (XmlNode xNode in xNodelst)
                            {
                                if (a == 3)
                                {
                                    Console.WriteLine($"{xNode.SelectSingleNode("description").InnerText}");
                                }
                                a++;
                            }
                            Console.ReadLine();
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Баку");
                            xdoc.Load("http://informer.gismeteo.by/rss/37850.xml");
                            XmlNodeList xNodelst = xdoc.DocumentElement.SelectNodes("//rss/channel/item");
                            int a = 0;
                            foreach (XmlNode xNode in xNodelst)
                            {
                                if (a == 3)
                                {
                                    Console.WriteLine($"{xNode.SelectSingleNode("description").InnerText}");
                                }
                                a++;
                            }
                            Console.ReadLine();
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Москва");
                            xdoc.Load("http://informer.gismeteo.by/rss/27612.xml");
                            XmlNodeList xNodelst = xdoc.DocumentElement.SelectNodes("//rss/channel/item");
                            int a = 0;
                            foreach (XmlNode xNode in xNodelst)
                            {
                                if (a == 3)
                                {
                                    Console.WriteLine($"{xNode.SelectSingleNode("description").InnerText}");
                                }
                                a++;
                            }
                            Console.ReadLine();
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("Вильнюс");
                            xdoc.Load("http://informer.gismeteo.by/rss/26730.xml");
                            XmlNodeList xNodelst = xdoc.DocumentElement.SelectNodes("//rss/channel/item");
                            int a = 0;
                            foreach (XmlNode xNode in xNodelst)
                            {
                                if (a == 3)
                                {
                                    Console.WriteLine($"{xNode.SelectSingleNode("description").InnerText}");
                                }
                                a++;
                            }
                            Console.ReadLine();
                        }
                        break;
                    case 7:
                        {
                            Console.WriteLine("Душанбе");
                            xdoc.Load("http://informer.gismeteo.by/rss/38836.xml");
                            XmlNodeList xNodelst = xdoc.DocumentElement.SelectNodes("//rss/channel/item");
                            int a = 0;
                            foreach (XmlNode xNode in xNodelst)
                            {
                                if (a == 3)
                                {
                                    Console.WriteLine($"{xNode.SelectSingleNode("description").InnerText}");
                                }
                                a++;
                            }
                            Console.ReadLine();
                        }
                        break;
                    case 8:
                        {
                            Console.WriteLine("Ереван");
                            xdoc.Load("http://informer.gismeteo.by/rss/37789.xml");
                            XmlNodeList xNodelst = xdoc.DocumentElement.SelectNodes("//rss/channel/item");
                            int a = 0;
                            foreach (XmlNode xNode in xNodelst)
                            {
                                if (a == 3)
                                {
                                    Console.WriteLine($"{xNode.SelectSingleNode("description").InnerText}");
                                }
                                a++;
                            }
                            Console.ReadLine();
                        }
                        break;
                    case 9:
                        {
                            Console.WriteLine("Киев");
                            xdoc.Load("http://informer.gismeteo.by/rss/33345.xml");
                            XmlNodeList xNodelst = xdoc.DocumentElement.SelectNodes("//rss/channel/item");
                            int a = 0;
                            foreach (XmlNode xNode in xNodelst)
                            {
                                if (a == 3)
                                {
                                    Console.WriteLine($"{xNode.SelectSingleNode("description").InnerText}");
                                }
                                a++;
                            }
                            Console.ReadLine();
                        }
                        break;
                    case 10:
                        {
                            Console.WriteLine("Кишинев");
                            xdoc.Load("http://informer.gismeteo.by/rss/33815.xml");
                            XmlNodeList xNodelst = xdoc.DocumentElement.SelectNodes("//rss/channel/item");
                            int a = 0;
                            foreach (XmlNode xNode in xNodelst)
                            {
                                if (a == 3)
                                {
                                    Console.WriteLine($"{xNode.SelectSingleNode("description").InnerText}");
                                }
                                a++;
                            }
                            Console.ReadLine();
                        }
                        break;
                    case 11:
                        {
                            Console.WriteLine("Минск");
                            xdoc.Load("http://informer.gismeteo.by/rss/26850.xml");
                            XmlNodeList xNodelst = xdoc.DocumentElement.SelectNodes("//rss/channel/item");
                            int a = 0;
                            foreach (XmlNode xNode in xNodelst)
                            {
                                if (a == 3)
                                {
                                    Console.WriteLine($"{xNode.SelectSingleNode("description").InnerText}");
                                }
                                a++;
                            }
                            Console.ReadLine();
                        }
                        break;
                    case 12:
                        {
                            Console.WriteLine("Рига");
                            xdoc.Load("http://informer.gismeteo.by/rss/26422.xml");
                            XmlNodeList xNodelst = xdoc.DocumentElement.SelectNodes("//rss/channel/item");
                            int a = 0;
                            foreach (XmlNode xNode in xNodelst)
                            {
                                if (a == 3)
                                {
                                    Console.WriteLine($"{xNode.SelectSingleNode("description").InnerText}");
                                }
                                a++;
                            }
                            Console.ReadLine();
                        }
                        break;
                    case 13:
                        {
                            Console.WriteLine("Таллинн");
                            xdoc.Load("http://informer.gismeteo.by/rss/26038.xml");
                            XmlNodeList xNodelst = xdoc.DocumentElement.SelectNodes("//rss/channel/item");
                            int a = 0;
                            foreach (XmlNode xNode in xNodelst)
                            {
                                if (a == 3)
                                {
                                    Console.WriteLine($"{xNode.SelectSingleNode("description").InnerText}");
                                }
                                a++;
                            }
                            Console.ReadLine();
                        }
                        break;
                    case 14:
                        {
                            Console.WriteLine("Ташкент");
                            xdoc.Load("http://informer.gismeteo.by/rss/38457.xml");
                            XmlNodeList xNodelst = xdoc.DocumentElement.SelectNodes("//rss/channel/item");
                            int a = 0;
                            foreach (XmlNode xNode in xNodelst)
                            {
                                if (a == 3)
                                {
                                    Console.WriteLine($"{xNode.SelectSingleNode("description").InnerText}");
                                }
                                a++;
                            }
                            Console.ReadLine();
                        }
                        break;
                    case 15:
                        {
                            Console.WriteLine("Тбилиси");
                            xdoc.Load("http://informer.gismeteo.by/rss/37549.xml");
                            XmlNodeList xNodelst = xdoc.DocumentElement.SelectNodes("//rss/channel/item");
                            int a = 0;
                            foreach (XmlNode xNode in xNodelst)
                            {
                                if (a == 3)
                                {
                                    Console.WriteLine($"{xNode.SelectSingleNode("description").InnerText}");
                                }
                                a++;
                            }
                            Console.ReadLine();
                        }
                        break;
                    case 16:
                        {
                            int max = -100;
                            string max_countryName = null;
                            Console.WriteLine("Сама тепла погода:");
                            string writePath = @"D:\ШАГ\C#\dz\dz15\ConsoleApp1\ConsoleApp1\cod.txt";
                            int count = System.IO.File.ReadAllLines(@"D:\ШАГ\C#\dz\dz15\ConsoleApp1\ConsoleApp1\cod.txt").Length;
                            string st1 = null;
                            string st2 = null;
                            using (StreamReader st = new StreamReader(writePath))
                            {
                                for (int i = 0; i < count / 2; i++)
                                {
                                    st1 = st.ReadLine();
                                    st2 = st.ReadLine();

                                    string strLink = @"http://informer.gismeteo.by/rss/";
                                    xdoc.Load(strLink + st2 + ".xml");
                                    XmlNodeList xNodelst = xdoc.DocumentElement.SelectNodes("//rss/channel/item");
                                    int a = 0;
                                    foreach (XmlNode xNode in xNodelst)
                                    {
                                        string lol = null;
                                        if (a == 3)
                                        {
                                            lol = xNode.SelectSingleNode("description").InnerText;
                                            for (int j = 0; j < lol.Length; j++)
                                            {
                                                if (lol[j] == '.' && lol[j + 1] == '.' && lol[j + 2] >= 48 && lol[j + 2] <= 57 && lol[j + 3] == ' ')
                                                {
                                                    string ab = (lol[j + 2]).ToString();
                                                    int abc = int.Parse(ab);
                                                    if(i == 0)
                                                    {
                                                        max = abc;
                                                        max_countryName = st1;
                                                    }
                                                    else
                                                    {
                                                        if(abc > max)
                                                        {
                                                            max = abc;
                                                            max_countryName = st1;
                                                        }
                                                    }
                                                    maxTemp.Add(abc);
                                                    break;
                                                }
                                                else if (lol[j] == '.' && lol[j + 1] == '.' && lol[j + 2] >= 48 && lol[j + 2] <= 57 && lol[j + 3] >= 48 && lol[j + 3] <= 57 && lol[j + 4] == ' ')
                                                {
                                                    string ab = (lol[j + 2]).ToString();
                                                    ab += lol[j + 3];
                                                    int abc = int.Parse(ab);
                                                    if (i == 0)
                                                    {
                                                        max = abc;
                                                        max_countryName = st1;
                                                    }
                                                    else
                                                    {
                                                        if (abc > max)
                                                        {
                                                            max = abc;
                                                            max_countryName = st1;
                                                        }
                                                    }
                                                    maxTemp.Add(abc);
                                                    break;
                                                }
                                            }
                                        }
                                        a++;
                                    }
                                }
                            }

                            Console.WriteLine(max_countryName + " " + max);

                            
                        }
                        break;
                    case 17:
                        {
                            Console.WriteLine("Введіть насву міста");
                            string str = Console.ReadLine();
                            Console.WriteLine("Введіть код міста");
                            string str2 = Console.ReadLine();
                            string path = @"D:\ШАГ\C#\dz\dz15\ConsoleApp1\ConsoleApp1\cod.txt";
                            using (StreamWriter sw = new StreamWriter(path, true))
                            {
                                sw.WriteLine(str);
                                sw.WriteLine(str2);
                            }
                        }
                        break;
                    case 0:
                        {
                            choise = 0;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("error");
                        }
                        break;
                }
            } while (choise != 0);
        }
    }
}
