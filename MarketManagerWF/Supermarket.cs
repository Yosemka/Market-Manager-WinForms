using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.CompilerServices;

namespace MarketManagerWF
{
    [KnownType(typeof(SectionGoods))]
    [KnownType(typeof(Goods))]
    [DataContract]
    public class Supermarket
    {
        private string name;
        
        private int sectionAmount;
        
        //static private string defaultPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\xml\";

        private int size;
        
        private SectionGoods[] sectionsQueue;
                
        private int front = -1;
        private int rear = -1;

        private const int NAME_ERROR = -2;              //имя используется уже или такого нет в списке
        private const int QUEUE_FULL_EMPTY_ERROR = -1;

        public Supermarket()
        {
            name = "no name";
            sectionAmount = 0;
            if (size <= 0)
                size = 10;
            sectionsQueue = new SectionGoods[size];
        }

        public Supermarket(int sz)
        {
            name = "no name";
            sectionAmount = 0;
            if (sz > 0)
                size = sz;
            else
                size = 1;
            sectionsQueue = new SectionGoods[size];
        }
        
        [DataMember]
        public string Name { get { return name; } set { name = value; } }

        //Всего секций на данный момент
        [IgnoreDataMember]
        public int SectionAmount { get { return sectionAmount; } set { sectionAmount = value; } }

        //Максимальное количество секций
        [DataMember]
        public int QueueSize
        {
            get { return size; }
            set 
            {
                size = value;
                sectionsQueue = null;
                sectionsQueue = new SectionGoods[size];
            }
        }
        [DataMember(Order = 10)]
        public List<SectionGoods> AllExistSections
        {
            get
            {
                List<SectionGoods> sections = new List<SectionGoods>();
                if (!IsQueueEmpty())
                {
                    foreach (SectionGoods section in sectionsQueue)
                    {
                        if(section != null)
                            sections.Add(section);
                    }
                    return sections;
                }
                else return null;
            }
            set
            {
                sectionAmount = 0;
                if(value != null)
                    for (int i = 0; i < value.Count; i++)
                    {
                        AddNewSection(value[i]);
                    }
            }
        }
        
        public int AddNewSection(string sectionName)
        {
            if (GetSection(sectionName) != null)    //проверка на существование секции с именем sectionName
            {   //если данное название используется в другой секции, не добавлять новую секцию
                return NAME_ERROR;
            }
            else
            {
                if (IsQueueFull())
                {   //список заполнен
                    return QUEUE_FULL_EMPTY_ERROR;
                }
                else
                {
                    if (IsQueueEmpty())     //список пуст => создается первый элемент с указателями...
                        front = rear = 0;   //на первый и крайний элементы очереди равными 0
                    else
                    {   //если список не пуст, указатель на первый элемент очереди front не трогаем
                        if (rear == size - 1 && front != 0)
                            //если указатель на крайний элемент очереди указывает на последний элемент массива
                            //и указатель на первый элемент очереди не указывает на первый элемент массива
                            //то есть очередь не заполнена... повторная проверка
                            rear = 0;   //то установить указатель на крайний элемент очереди на первый элемент массива
                        else
                            rear++;     //ИНАЧЕ просто увеличиваем на один только указатель на крайний элемент очереди
                    }
                    //создание объекта SectionGoods с именем sectionName и занесение ее в массив с индексом rear
                    sectionsQueue[rear] = new SectionGoods(sectionName);
                    sectionAmount++;    //увеличение количества элементов в очереди
                    return rear;        //вернуть указатель на добавленный новый элемент
                }               
            }
        } 
        public int AddNewSection(SectionGoods section)
        {
            if (GetSection(section.Name) != null)    //проверка на существование секции с именем sectionName
            {   //если данное название используется в другой секции, не добавлять новую секцию
                return NAME_ERROR;
            }
            else
            {
                if (IsQueueFull())
                {   //список заполнен
                    return QUEUE_FULL_EMPTY_ERROR;
                }
                else
                {
                    if (IsQueueEmpty())     //список пуст => создается первый элемент с указателями...
                        front = rear = 0;   //на первый и крайний элементы очереди равными 0
                    else
                    {   //если список не пуст, указатель на первый элемент очереди front не трогаем
                        if (rear == size - 1 && front != 0)
                            //если указатель на крайний элемент очереди указывает на последний элемент массива
                            //и указатель на первый элемент очереди не указывает на первый элемент массива
                            //то есть очередь не заполнена... повторная проверка
                            rear = 0;   //то установить указатель на крайний элемент очереди на первый элемент массива
                        else
                            rear++;     //ИНАЧЕ просто увеличиваем на один только указатель на крайний элемент очереди
                    }
                    //занесение секции в массив с индексом rear
                    sectionsQueue[rear] = section;
                    sectionAmount++;    //увеличение количества элементов в очереди
                    return rear;        //вернуть указатель на добавленный новый элемент
                }               
            }
        }
        public string DeleteSectionAndGoods()
        {
            if (IsQueueEmpty())
            {   //если очередь пуста, вернуть null
                return null;
            }
            else
            {   //очередь не пуста
                //сохранить имя первого элемента, который будет удаляться
                string tmpSectionName = sectionsQueue[front].Name; 
                //обнулить элемент массива, где хранился указатель на удаляемый элемент очереди
                sectionsQueue[front] = null;
                //Приведение в порядок указателей на первый и крайний элементы очереди
                if (IsOneElementInQueue())
                {   //если в очереди всего один элемент, и он удаляется, 
                    front = -1;     //то проинициировать указатели, как при пустой очереди
                    rear = -1;
                }
                else if (IsFrontOnTheLastRignElement())
                {   //если указатель на первый элемент очереди указывает на крайний элемент массива
                    front = 0;  //то front будет указывать теперь на первый элемент массива
                }
                else
                {   //если front не указывает на крайний, и в очереди больше 1 элемента
                    front++;    //то просто увеличить front На 1
                }
                sectionAmount--;        //уменьшение количества элементов в очереди
                return tmpSectionName;  //вернуть имя удаленной секции
            }               
        }

        public SectionGoods GetSection(string sectionName)
        {
            foreach(SectionGoods section in sectionsQueue)
            {
                if (section != null && section.Name == sectionName)
                    return section;
            }
            return null;
        }

        public void Clear()
        {            
            if(AllExistSections != null) AllExistSections.Clear();
            sectionsQueue = null;
            /*for(int i = 0; i < sectionsQueue.Length; i++)
            {
                sectionsQueue[i] = null;
            }*/
            front = rear = -1;
            SectionAmount = 0;
            QueueSize = 0;
            Name = " "; 
        }
        //Вспомогательные/проверочные функции
        private bool IsQueueEmpty()
        {
            if (front == -1 && rear == -1)
                return true;
            else
                return false;
        }
        public bool IsQueueFull()
        {
            if ((front == 0 && rear == size - 1) || rear == front - 1)
                return true;
            else
                return false;
        }
        private bool IsFrontOnTheLastRignElement()
        {
            if (front == size - 1)
                return true;
            else
                return false;
        }
        private bool IsOneElementInQueue()
        {
            if (front == rear)
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            string str = string.Empty;
            if (!IsQueueEmpty())
            {
                foreach (SectionGoods section in AllExistSections)
                    str += section.ToString();
            }
            else
                str += "Нет существующих секций.";
            return str;
        }
        public string Serialize(string path)
        {
            //string path = defaultPath + this.Name + ".xml";
            //XmlSerializer ser = new XmlSerializer(typeof(Supermarket));

            var dcss = new DataContractSerializerSettings { PreserveObjectReferences = true };
            var dcs = new DataContractSerializer(typeof(Supermarket), dcss);

            File.WriteAllText(path, string.Empty);

            using(FileStream st = new FileStream(path, FileMode.OpenOrCreate))
            {
                //ser.Serialize(st, this);
                dcs.WriteObject(st, this);
            }
            return path;
        }
        public bool Deserialize(string path)
        {
            /*if (path == "")
                path = defaultPath + "supermarket.xml";*/

            //XmlSerializer ser = new XmlSerializer(typeof(Supermarket));

            var dcss = new DataContractSerializerSettings { PreserveObjectReferences = true };
            var dcs = new DataContractSerializer(typeof(Supermarket), dcss);

            try
            {
                if(File.Exists(path))
                {
                    using (FileStream st = new FileStream(path, FileMode.OpenOrCreate))
                    {
                        //Supermarket sp = (Supermarket)ser.Deserialize(st);
                        Supermarket sp = new Supermarket();
                        sp = (Supermarket)dcs.ReadObject(st);

                        this.Clear();
                        
                        this.Name = sp.Name;
                        this.QueueSize = sp.QueueSize;
                        this.AllExistSections = sp.AllExistSections;      
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            
        }
    }
}

