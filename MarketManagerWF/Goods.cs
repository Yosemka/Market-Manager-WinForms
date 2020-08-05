using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace MarketManagerWF
{
    public class Goods
    {
        //Информационные поля
        private string name;
        private double price;
        //указатели на следующий и предыдущий элементы
        public Goods Next { get; set; }
        public Goods Previous { get; set; }
        //[XmlIgnore]
        
        //private string defaultPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\xml\";
        //Конструкторы
        public Goods(string newName = "no name", double newPrice = 0)
        {
            name = newName;
            price = newPrice;
        }

        public Goods() { }

        //Методы доступа к информационным полям
        
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if(value < 0)
                {
                    //Console.WriteLine("Неверная цена товара. Текущая цена установлена как 0");
                    value = 0;
                }
                price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}\t {1}\n", name, price);
        }
        public string Serialize(string path)
        {
            //string path = defaultPath + this.Name + ".xml";

            var dcss = new DataContractSerializerSettings { PreserveObjectReferences = true };
            var dcs = new DataContractSerializer(typeof(Goods), dcss);
            
            /*using (Stream fStream = new FileStream("test.xml",
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                dcs.WriteObject(fStream, this);
            }*/
            /*XmlSerializer ser = new XmlSerializer(typeof(Goods), dcss);*/
                        
            //using (FileStream st = new FileStream(path, FileMode.OpenOrCreate))
            using (FileStream st = new FileStream(path, FileMode.OpenOrCreate))
            {
                //ser.Serialize(st, this);
                dcs.WriteObject(st, this);
            }
            return path;
        }

        public bool Deserialize(string path)
        {
            /*if (path == "")
                path = defaultPath + "good.xml";*/

            var dcss = new DataContractSerializerSettings { PreserveObjectReferences = true };
            var dcs = new DataContractSerializer(typeof(Goods), dcss);

            //XmlSerializer ser = new XmlSerializer(typeof(Goods));
            if (File.Exists(path))
            {
                using (FileStream st = new FileStream(path, FileMode.Open))
                {
                    try
                    {
                        //Goods des = (Goods)ser.Deserialize(st);
                        Goods des = (Goods)dcs.ReadObject(st);
                        this.Name = des.Name;
                        this.Price = des.Price;
                        this.Next = des.Next;
                        this.Previous = des.Previous;
                    }
                    catch
                    {
                        return false;
                    }                        
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
