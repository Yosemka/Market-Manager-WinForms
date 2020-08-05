using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Xml.Serialization;
using System.Reflection.Emit;

namespace MarketManagerWF
{
    [KnownType(typeof(Goods))]
    public class SectionGoods
    {
        //Адрес первого элемента списка 
        private Goods head;

        //Информационные поля
        private string name;        //название секции          

        private int count = 0;      //кол-во товаров

        //private static string defaultPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\xml\";

        //Методы доступа к информационным полям
        [DataMember]
        public int Count { get { return count; } set { count = value; } }
        [DataMember]
        public string Name { get { return name; } set { name = value; } }
        [DataMember]
        public Goods Head { get { return head; } set { head = value; } }

        [IgnoreDataMember]
        public bool IsEmpty { get { return count == 0; } }

        //Конструкторы
        public SectionGoods(string newName = "no name")
        {
            name = newName;
        }
        public SectionGoods() { }

        public int AddGoodToList(string newName)
        {
            //Создание нового узла списка товаров 
            Goods node = new Goods(newName);

            if (head == null)
            {   //если заголовок списка товаров пуст, то есть сам список пуст
                head = node;            //задать данный товар, как загловок списка
                head.Next = node;       //тк список замкнут, следующий и предыдущий узлы...
                head.Previous = node;   //.. указывают сами на себя, те на заголовок списка
            }
            else
            {   //если список не пуст

                //указатель на след элемент нового узла указывает на заголовок списка
                node.Next = head;
                //указатель на предыдущий элемент нового узла указывает на предыдущий элемент заголовока
                node.Previous = head.Previous;
                //указатель на следующий элемент крайнего узла указывает на новый узел
                head.Previous.Next = node;
                //указатель на предыдущий элемент перед заголовком указывает теперь на новый узел
                head.Previous = node;
            }
            count++;   //увеличить счетчик узлов в списке, те счетчик товаров в отделе

            return count;   //возвращает количество элементов в списке
        }

        public string DeleteGoodFromList(string name)
        {
            //поиск удаляемого товара
            Goods removedItem = GetElementByName(name);

            if (removedItem == null)
            {   //если удаляемый товар не найден
                return null;    //вернуть нулевой указатель
            }
            else
            {   //если удаляемый элемент существует
                // если удаляется единственный элемент списка
                if (count == 1)
                    head = null;    //указатель на заголовок списка обнулить
                else
                {   //если элементов в списке больше 1                    
                    if (removedItem == head)
                    {   // если удаляется заголовок списка элемент
                        head = head.Next;
                        //указатель на заголовок списка будет указывать на следующий элемент после удаляемого заголовка
                    }
                    //в любом случае:
                    //указатель Next предыдущего элемента перед удаляемым будет указывать на Next удаляемого элемента
                    removedItem.Previous.Next = removedItem.Next;
                    //указатель Previous следующего элемента после удаляемого будет указывать на Previous удаляемого
                    removedItem.Next.Previous = removedItem.Previous;
                }
                count--;                    //уменьшить счетчик количества элементов в списке
                return removedItem.Name;    //вернуть название удаленного товара
            }
        }

        public double GetTotalSectionPrice()
        {
            Goods[] allGoods = GetAllElements();
            double totalPrice = 0;
            if (allGoods != null)
                foreach (Goods goods in allGoods)
                    totalPrice += goods.Price;

            return totalPrice;
        }

        public void Clear()
        {
            head = null;
            count = 0;
        }

        public Goods GetElementByName(string name)
        {
            Goods current = head;   //начало поиска будет с заголовка

            if (IsEmpty)
            {   //если список пуст, то вернуть null и ничего не искать
                return null;
            }
            else
            {   //если в списке есть элементы
                do
                {   //начать искать с заголовка
                    if (current.Name == name)
                        return current; //если имя текущего элемента совпало с искомым, вернуть этот элемент
                    //если не совпало имя, текущим элементом сделать следущий эл. за нынешним
                    current = current.Next;
                }   //пройтись по всему списку, пока текущий элемент не будет снова указывать на заголовок
                while (current != head);

                return null;    //если товар с искомым именем не найден
            }
        }

        public Goods[] GetAllElements()
        {
            Goods current = head;
            List<Goods> list = new List<Goods>();

            if (IsEmpty)
            {   //если список товаров пуст, вернуть пустой указатель
                //Console.WriteLine("Список товаров пуст.");
                return null;
            }
            else
            {   //если список товаров не пуст...
                do
                {
                    list.Add(current);  //...добавить последовательно все элементы списка в List
                    current = current.Next;
                }
                while (current != head);
                return list.ToArray();
            }
        }
        public override string ToString()
        {
            Goods[] allGoods = GetAllElements();
            string str = "Section: " + this.Name + "\n";
            if (allGoods != null)
                for (int i = 0; i < allGoods.Length; i++)
                    str += (i + 1).ToString() + ") " + allGoods[i].ToString();
            else
                str += "Список товаров пуст...";
            str += "\n";
            return str;
        }

        public string Serialize(string path)
        {
            //XmlSerializer ser = new XmlSerializer(typeof(SectionGoods));
            //XmlSerializer ser = new XmlSerializer(typeof(SectionGoods), new System.Type[] { typeof(SectionGoods) });
            /*string path = defaultPath + this.Name + ".xml";*/

            var dcss = new DataContractSerializerSettings { PreserveObjectReferences = true };
            var dcs = new DataContractSerializer(typeof(SectionGoods), dcss);

            File.WriteAllText(path, string.Empty);

            using (FileStream tw = new FileStream(path, FileMode.OpenOrCreate))
            {
                //ser.Serialize(tw, this);
                dcs.WriteObject(tw, this);
            }
            return path;
        }

        public bool Deserialize(string path)
        {
            /*if (path == "")
                path = defaultPath + "section.xml";*/

            //XmlSerializer ser = new XmlSerializer(typeof(SectionGoods));

            var dcss = new DataContractSerializerSettings { PreserveObjectReferences = true };
            var dcs = new DataContractSerializer(typeof(SectionGoods), dcss);
            try
            {
                if (File.Exists(path))
                {
                    using (FileStream st = new FileStream(path, FileMode.Open))
                    {
                        SectionGoods goods = new SectionGoods();
                        //goods = (SectionGoods)ser.Deserialize(st);
                        goods = (SectionGoods)dcs.ReadObject(st);

                        this.Clear();

                        this.Count = goods.Count;
                        this.Name = goods.Name;
                        this.head = goods.head;
                    }
                    return true;
                }
                else
                {
                    Console.WriteLine("Файла не существует.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
