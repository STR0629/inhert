using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text;
using System.Text.Json;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;


namespace inhert
{
    internal class Program
    {
        
        //delegate declaratiom
        public delegate int DelDoit(int no, int no1);
        static int Addnumbers(int no, int no1)
        {
            return no + no1;
        }
        static int Productnumbers(int no, int no1)
        {
            return no * no1;
        }
        static int Diffnumbers(int no, int no1)
        {
            return (no - no1);

        }
        static int Squarenum(int no)
        {
            return no * no;
        }
        static bool CheckforEven(int no)
        {
            bool bl = false;
            if (no % 2 == 0)
            { bl = true; }
            return bl;
        }
        static void Main(string[] args)
        {
            /*string fileName = "dataStuff.txt";

            IFormatter formatter = new BinaryFormatter();
            SerializeItem(fileName, formatter);
            deserializeItem(fileName, formatter);
            Console.WriteLine("done");*/
            //Generic();
            //Genericbook();
            //SingleInheritance();
            //MultilevelInheritance();
            // Customerobj();
            //Wholeseller();
            //hierarchialInheritance();
            //GenericlistCollection();
            //Collection();
            //Dictionarydemo();
            //Dictionary();
            //Stack();
            //Queue();
            // regex();
            //Exception();
            //Exception1();
            //CollectionInitializers();
            //sortingcollection();
            //Inumerableoncollection();
            // instantiate delegate and assign method name to it.
            //delegatenum();
            //FuncDelegate();
            //Predicate();
            //ActionDelegate();
            //streamwriterdemo();
            //streamwriter();
            //streamreader();
            //Directorymethod();
            //DirectoryInfo();
            //bwriter();
            //file_Binaryreader();
            //JSONSERIALIZATION();
            //JsonDeserializer();
            //serializeBinaryformatxml();
            //deserializablebinarydormatxml();
            //ISerializible();
            //empser();
            //epmpdesr();
            //scootjson();
            //REFLECTIOND();
            //ReflectionOnMemberInfo();
            //ReflectionDemo();
            // SampleAtribute.CallGetAtribute();
            bookdemopublisherAttribute();
        }

        private static void bookdemopublisherAttribute()
        {
            List<Bookdemo> book = new List<Bookdemo>();
            book.Add(new Bookdemo
            {

                Id = 1,
                Title = "aaaaa",
                Author = "AAAA",
                Price = 111,
                Publisher = new PublisherDemo { Id = 100, Name = "Aaaa", Address = "aAaAaA" }

            });
            book.Add(new Bookdemo
            {

                Id = 2,
                Title = "bbb",
                Author = "BBBB",
                Price = 111,
                Publisher = new PublisherDemo { Id = 200, Name = "Aaaa", Address = "aAaAaA" }

            });
            book.Add(new Bookdemo
            {

                Id = 3,
                Title = "cccc",
                Author = "CCC",
                Price = 111,
                Publisher = new PublisherDemo { Id = 300, Name = "Aaaa", Address = "aAaAaA" }

            });
            book.Add(new Bookdemo
            {

                Id = 4,
                Title = "ddd",
                Author = "DDDD",
                Price = 111,
                Publisher = new PublisherDemo { Id = 400, Name = "Aaaa", Address = "aAaAaA" }

            });
            book.Add(new Bookdemo
            {

                Id = 5,
                Title = "eee",
                Author = "EEEE",
                Price = 111,
                Publisher = new PublisherDemo { Id = 500, Name = "Aaaa", Address = "aAaAaA" }

            });
            book.Add(new Bookdemo
            {

                Id = 6,
                Title = "fff",
                Author = "FFF",
                Price = 111,
                Publisher = new PublisherDemo { Id = 601, Name = "Aaaa", Address = "aAaAaA" }

            });
            Console.WriteLine("book details");
            foreach (var bookd in book)
            {
                Console.WriteLine($"BOOKNAME:{bookd.Title}\npublisherid:{bookd.Publisher.Id}\nbooktiitle:{bookd.Publisher.Name}");
            }
        }

        private static void ReflectionDemo()
        {
            Console.WriteLine("\nReflection.MemberInfo");
            // Gets the Type and MemberInfo.
            Type myType = Type.GetType("System.IO.File");
            MemberInfo[] myMemberInfoArray = myType.GetMembers();
            // Gets and displays the DeclaringType method.
            Console.WriteLine("\nThere are {0} members in {1}.",
                myMemberInfoArray.Length, myType.FullName);
            Console.WriteLine("{0}.", myType.FullName);
            if (myType.IsPublic)
            {
                Console.WriteLine("{0} is public.", myType.FullName);
            }
        }

        private static void ReflectionOnMemberInfo()
        {
            // This code displays information about the GetValue method of FieldInfo.
            Console.WriteLine("Reflection.MethodInfo");
            // Gets and displays the Type.
            Type myType = Type.GetType("System.Reflection.FieldInfo");
            // Specifies the member for which you want type information.
            MethodInfo myMethodInfo = myType.GetMethod("GetValue");
            Console.WriteLine(myType.FullName + "." + myMethodInfo.Name);
            // Gets and displays the MemberType property.
            MemberTypes myMemberTypes = myMethodInfo.MemberType;
            if (MemberTypes.Constructor == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type All");
            }
            else if (MemberTypes.Custom == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Custom");
            }
            else if (MemberTypes.Event == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Event");
            }
            else if (MemberTypes.Field == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Field");
            }
            else if (MemberTypes.Method == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Method");
            }
            else if (MemberTypes.Property == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Property");
            }
            else if (MemberTypes.TypeInfo == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type TypeInfo");
            }
            // return 0;
        }

        private static void REFLECTIOND()
        {
            int i = 42;
            double d = 890.78;
            string st = "hello";
            Type ts = st.GetType();
            Type type = i.GetType();
            Type t = d.GetType();
            Console.WriteLine(type);
            Console.WriteLine(t);
            Console.WriteLine(ts);
            Assembly info = typeof(int).Assembly;
            Console.WriteLine(info);
            Assembly asinf = typeof(string).Assembly;
            Console.WriteLine(asinf);
        }

        private static void scootjson()
        {
            Dictionary<int, Scooter> scooters = new Dictionary<int, Scooter>();

            scooters.Add(1, new Scooter { Regno = "12355B", Model = "pache", Type = "150cc", Price = 120000 });
            scooters.Add(2, new Scooter { Regno = "123wr5B", Model = "R15", Type = "150cc", Price = 160000 });
            scooters.Add(3, new Scooter { Regno = "1ewefB", Model = "pulsar", Type = "200cc", Price = 220000 });
            scooters.Add(4, new Scooter { Regno = "12fewB", Model = "Impulse", Type = "220cc", Price = 200000 });
            scooters.Add(5, new Scooter { Regno = "12wqrB", Model = "Duke", Type = "250cc", Price = 820000 });
            scooters.Add(6, new Scooter { Regno = "14rfB", Model = "Benneli", Type = "600cc", Price = 720000 });
            scooters.Add(7, new Scooter { Regno = "12ferB", Model = "Tigerstreet", Type = "1000cc", Price = 920000 });
            scooters.Add(8, new Scooter { Regno = "1277h", Model = "unicorn", Type = "160cc", Price = 100000 });
            scooters.Add(9, new Scooter { Regno = "14hgt55B", Model = "fatboy", Type = "1000cc", Price = 180000 });
            scooters.Add(10, new Scooter { Regno = "45ytg5B", Model = "ducatti", Type = "1500cc", Price = 160000 });
            scooters[2].Model = "royalenfield";
            foreach (var sct in scooters.Values)
            {
                Console.WriteLine("{0} {1} {2} {3}", sct.Regno, sct.Model, sct.Type, sct.Price);
            }
        }

        private static void epmpdesr()
        {
            string fileName = "Employeee.json";
            string jsonString = File.ReadAllText(fileName);
            List<Employeee> employee = new List<Employeee>
            {
                new Employeee{EmpId=1,Name="str",DateofJoin=15-08-2022,Department="Testing",Salary=30000},
                new Employeee{EmpId=2,Name="ntr",DateofJoin=23-08-2022,Department="Developer",Salary=450000},
                new Employeee{EmpId=3,Name="ktr",DateofJoin=23-07-2022,Department="Analyst",Salary=350000},
                new Employeee{EmpId=4,Name="mikey",DateofJoin=13-04-2022,Department="Graphics",Salary=550000},
                new Employeee{EmpId=5,Name="zenitsu",DateofJoin=8-08-2022,Department="Reasearch",Salary=650000},

            };
            employee = JsonSerializer.Deserialize<List<Employeee>>(jsonString);
            {
                foreach (Employeee emp in employee)
                {
                    Console.WriteLine("{0} \n{1} \n{2} \n{3} \n{4}", emp.EmpId, emp.Name, emp.DateofJoin, emp.Department, emp.Salary);

                }


            }
        }

        private static void empser()
        {
            List<Employeee> employee = new List<Employeee>
            {
                new Employeee{EmpId=1,Name="str",DateofJoin=15-08-2022,Department="Testing",Salary=30000},
                new Employeee{EmpId=2,Name="ntr",DateofJoin=23-08-2022,Department="Developer",Salary=450000},
                new Employeee{EmpId=3,Name="ktr",DateofJoin=23-07-2022,Department="Analyst",Salary=350000},
                new Employeee{EmpId=4,Name="mikey",DateofJoin=13-04-2022,Department="Graphics",Salary=550000},
                new Employeee{EmpId=5,Name="zenitsu",DateofJoin=8-08-2022,Department="Reasearch",Salary=650000},

            };
            string jsonString = JsonSerializer.Serialize(employee);
            string fileName = "Employeee.json";
            Console.WriteLine(jsonString);
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine(File.ReadAllText(fileName));
        }





        private static void ISerializible()
        {
            string fileName = "dataStuff.txt";

            IFormatter formatter = new BinaryFormatter();
            SerializeItem(fileName, formatter);



            deserializeItem(fileName, formatter);
            Console.WriteLine("done");
        }

        private static void deserializeItem(string fileName, IFormatter formatter)
        {
            SerializeItem(fileName, formatter);
            MyItemType t = new MyItemType();
            t.Myvalue = "Hello everyone";
            FileStream s = new FileStream(fileName, FileMode.Create);
            formatter.Serialize(s, t);
            s.Close();
        }

        private static void SerializeItem(string fileName, IFormatter formatter)
        {
            MyItemType t = new MyItemType();
            t.Myvalue = "Hello ! this is Serialization program";

            FileStream s = new FileStream(fileName, FileMode.Create);
            formatter.Serialize(s, t);
            s.Close();
        }
        /*private static void deserializeItem()
        {
            throw new NotImplementedException();
        }

        private static void deserializeItem(string fileName, IFormatter formatter)
        {
            MyItemType t = new MyItemType();
            t.Myvalue = "Hello ! this is Serialization program";

            FileStream s = new FileStream(fileName, FileMode.Create);
            formatter.Serialize(s, t);
            s.Close();
        }

        private static void SerializeItem()
        {
            throw new NotImplementedException();
        }

        private static void SerializeItem(string fileName, IFormatter formatter)
        {
            SerializeItem(fileName, formatter);
            MyItemType t = new MyItemType();
            t.Myvalue = "Hello everyone";
            FileStream s = new FileStream(fileName, FileMode.Create);
            formatter.Serialize(s, t);
            s.Close();
        }*/

        private static void NewMethod(out MyItemType t, out FileStream s, string fileName, IFormatter formatter)
        {
            t = new MyItemType();
            t.Myvalue = "Hello ! this is Serialization program";

            s = new FileStream(fileName, FileMode.Create);
            formatter.Serialize(s, t);
            s.Close();
        }

        private static void deserializablebinarydormatxml()
        {
            Cat mycat;
            Stream strm;
            BinaryFormatter bfrm;
            //open the file and deserialize it.
            strm = File.Open("data.xml", FileMode.Open);
            bfrm = new BinaryFormatter();
            // typecasting to cat from object type
            mycat = (Cat)bfrm.Deserialize(strm);
            strm.Close();
            Console.WriteLine("After Deserialization");
            mycat.Showcat();
        }

        private static void serializeBinaryformatxml()
        {
            Cat mycat;
            Stream strm;
            BinaryFormatter bfrm;
            mycat = new Cat();
            mycat.Name = "mikkey";
            mycat.Description = "Italian";
            mycat.Age = 3;
            // before serialization
            mycat.Showcat();
            strm = File.Open("data.xml", FileMode.Create);
            bfrm = new BinaryFormatter();
            bfrm.Serialize(strm, mycat);
            strm.Close();
            //empty the mycat object
            mycat = null;
        }

        private static void JsonDeserializer()
        {
            string fileName = "Weatherforecast.json";
            string jsonString = File.ReadAllText(fileName);
            Weatherforecast weatherforecast = new Weatherforecast();
            weatherforecast = JsonSerializer.Deserialize<Weatherforecast>(jsonString);
            Console.WriteLine($"Date:{weatherforecast.Date}");
            Console.WriteLine($"TemperatureCelsius: {weatherforecast.TemperatureCelcius}");
            Console.WriteLine($"Summary:{weatherforecast.Summary}");
        }

        private static void JSONSERIALIZATION()
        {
            var Weatherforecast = new Weatherforecast
            {
                Date = DateTime.Parse("2022-02-24"),
                TemperatureCelcius = 31,
                Summary = "Hot"
            };
            string jsonString = JsonSerializer.Serialize(Weatherforecast);
            string fileName = "WeatherForecast.json";
            Console.WriteLine(jsonString);
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine(File.ReadAllText(fileName));
        }

        private static void bwriter()
        {
            String filename = "hello2.txt";
            using (var stream = File.Open(filename, FileMode.Create))
            {
                using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                {
                    writer.Write(1.250F);
                    writer.Write(@"C:\\Temp is ");
                    writer.Write(10);
                    writer.Write(true);
                }
            }
        }

        private static void DirectoryInfo()
        {
            //file create
            DirectoryInfo d = new DirectoryInfo(@"C:\\hello1");
            try
            {
                if (d.Exists)
                {
                    Console.WriteLine("path exists");

                }
                d.Create();
                Console.WriteLine("directory created");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private static void Directorymethod()
        { 
            //file move
            string sourcedirctory = @"C:\\Current";
            string destdirctory = @"C:\\Archive";
            try
            {
                var txtFiles = Directory.EnumerateFiles(sourcedirctory, "*.txt");
                foreach (string currentFile in txtFiles)
                {
                    string fileName = currentFile.Substring(sourcedirctory.Length + 1);
                    Directory.Move(currentFile, Path.Combine(destdirctory, fileName));
                    Console.WriteLine("file moved");
                }
                Console.WriteLine("file moved");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void file_Binaryreader()
        {
            float Ratio;
            string Tempdirectory;
            int time;
            bool statusbar;
           String filename = "hello2.txt";
            if (File.Exists(filename))
            {
                using (var stream = File.Open(filename, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        Ratio=reader.ReadSingle();
                        Tempdirectory=reader.ReadString();
                        time=reader.ReadInt32();
                        statusbar=reader.ReadBoolean();
                    }
                }
                Console.WriteLine("ratio set to: "+Ratio);
                Console.WriteLine("tempdirectory:" + Tempdirectory);
                Console.WriteLine("time is: " + time);
                Console.WriteLine("statusbar" + statusbar);
            }

        }

        private static void streamreader()
        {
            string path = @"example1.txt";
            string line;
            StreamReader sr = new StreamReader(path);
            try
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                sr.Close();
                sr.Dispose();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void streamwriterdemo()
        {
            try
            {
                using (StreamWriter swr = new StreamWriter("hello.txt"))
                {
                    Console.WriteLine("enter any long string");
                    string data = Console.ReadLine();
                    swr.WriteLine(data);
                }
                Console.WriteLine("data saved");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private static void streamwriter()
        {
            DirectoryInfo[] dirinfo = new DirectoryInfo(@"C:\").GetDirectories();
            using (StreamWriter sw = new StreamWriter("CDriveDirs.txt"))
            {
                foreach (DirectoryInfo dir in dirinfo)
                {
                    sw.WriteLine(dir.Name);
                }
            }
            Console.WriteLine(" file saved");
        }

        private static void ActionDelegate()
        {
            Action<string> action = (string msg) => Console.WriteLine("This is Action Delegate  " + msg);
            action("Great!");
            Action<int, int> divide = (int no, int no1) => Console.WriteLine("Division : {0} ", no / no1);
            divide(250, 50);
        }

        private static void Predicate()
        {
            Predicate<int> evencheck = CheckforEven;
            bool res = CheckforEven (12);
            if (res)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }

        private static void FuncDelegate()
        {
            Func<int, int, int> product = (no, no1) => no * no1;
            Func<int, int, int> diff = (no, no1) => no * no1;
            Func<int, int> Squarenum = (no) => no * no;
            Console.WriteLine(product(21, 10));
        }

        private static void delegatenum()
        {
            DelDoit ddoit = Addnumbers;

            int res = ddoit(485, 855);
            Console.WriteLine(res);
            //delegate multicasting.
            ddoit += Productnumbers;
            int pro = ddoit(10, 25);
            Console.WriteLine(pro);
            ddoit += Diffnumbers;
            int diff = ddoit(100, 25);
            Console.WriteLine(diff);

            ddoit -= Diffnumbers;
            Console.WriteLine(ddoit(35, 15));
        }

        private static void Inumerableoncollection()
        {
            FormattedAddress address = new FormattedAddress()
            {
               {"john","doe","123 street","topeko","KS","0000" },
                {
               "jane","smith","456 street","topeko","KS","0000"}
            };




            Console.WriteLine("Address Entries:");
            foreach (string addressEntry in address)
            {
                Console.WriteLine("\r\n" + addressEntry);
            }
        }

        private static void sortingcollection()
        {
            var cars = new List<Car>
    {

        { new Car() {Name="kia",Color="blue",Speed = 30}},
        { new Car() {Name="hyundai",Color="green",Speed = 80}},
        { new Car() {Name="maruti",Color="blue",Speed = 70}},
        { new Car() {Name="skoda",Color="green",Speed = 50}},
        { new Car() {Name="volkswagon",Color="red",Speed = 20}},
        { new Car() {Name="renault",Color="red",Speed = 80}},
        { new Car() {Name="mahindra",Color="green",Speed = 40}}

    };




            cars.Sort();
            foreach (Car thisCar in cars)
            {
                Console.Write(thisCar.Color.PadRight(5) + " ");
                Console.Write(thisCar.Speed.ToString() + " ");
                Console.Write(thisCar.Name);
                Console.WriteLine();



            }
        }

        private static void CollectionInitializers()
        {
            List<Customer> cstm = new List<Customer>
            {
                new Customer { Customerid = 1, Name = "str", Email = "str@gmail.com", Phone = 1112223334 },
                new Customer { Customerid = 2, Name = "tanjiro", Email = "thunderclap@gmail.com", Phone = 12334444 },
                new Customer { Customerid = 3, Name ="mikey",Email ="tokyorev@gnail.com",Phone=1234321}
            };
            foreach (Customer c in cstm)
            {
                Console.WriteLine("{0} {1} {2} ", c.Customerid, c.Name, c.Email, c.Phone);
            }
        }

        private static void Exception1()
        {
            try
            {
                Console.WriteLine("enter a number");
                var num = int.Parse(Console.ReadLine());
                Console.WriteLine(num);
            }
            catch (Exception)
            {
                Console.WriteLine("error occured");
            }
            finally
            {
                Console.WriteLine("enter valid input");
            }
        }

        private static void Exception()
        {
            int x = 0;
            try
            {
                int y = 100 / x;
                Console.WriteLine(y);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine(x);
            }
        }

        private static void regex()
        {
            string pattern = "(Mr\\.? |Mrs\\.? |Miss |Ms\\.? )";
            string[] names = { "Mr. Warner", "Ms. Samuels",
                         "chahal", "Ms. Morris" };
            foreach (string name in names)
                Console.WriteLine(Regex.Replace(name, pattern, String.Empty));
            string[] str = { "parth@gmail.com", "parthmaniyargmail.com", "@gmail.com" };

            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} a valid E-mail address.", s,
                                    IsValidEmail(s) ? "is" : "is not");
            }
        }

        public static bool IsValidEmail(string inputEmail)
        {
            string strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            Regex re = new Regex(strRegex, RegexOptions.IgnoreCase);

            if (re.IsMatch(inputEmail))
                return (true);
            else
                return false;
                
        }

        private static void Queue()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("GST");
            queue.Enqueue("CGST");
            queue.Enqueue("SGST");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            queue.Dequeue();
            Console.WriteLine("FIRST IN FIRST OUT");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }

        private static void Stack()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("biryani");
            stack.Push("chilly chicken");
            stack.Push("soft drink");
            stack.Push("ice creame");
            foreach (var it in stack)
            {
                Console.WriteLine(it);
            }
            stack.Pop();
            foreach (var it in stack)
            {
                Console.WriteLine(it);
            }
        }

        private static void Dictionary()
        {
            Dictionary<int, Customer> customerdictionary = new Dictionary<int, Customer>();
            customerdictionary.Add(1, new Customer
            {
                Name = "str",
                customersid = 1234,
                Email = "gojusatoro@gmail.com",
                Phone = 222333445
            });
            customerdictionary.Add(2, new Customer
            {
                Name = "str2",
                customersid = 123334,
                Email = "sssas@gmail.com",
                Phone = 1112223333
            });
            customerdictionary[2].Name = "www";
            foreach (var cst in customerdictionary.Values)
            {

                Console.WriteLine("{0} {1} {2} {3}", cst.Customerid, cst.Name, cst.Email, cst.Phone);
            }
        }

        private static void Dictionarydemo()
        {
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1, "srh");
            keyValuePairs.Add(2, "kkr");
            keyValuePairs.Add(3, "csk");
            keyValuePairs.Add(4, "dc");
            foreach (var city in keyValuePairs)
            {
                Console.WriteLine("{0} {1}", city.Key, city.Value);
            }
            keyValuePairs.Add(5, "hhh");
            Console.WriteLine("eliminated");
            foreach (var city in keyValuePairs)
            {
                Console.WriteLine("{0} {1}", city.Key, city.Value);
            }
        }

        private static void Collection()
        {
            var customers = new List<Customer>();
            customers.Add(new Customer { Customerid = 1111, Name = "Hashira", Email = "strength@gmail.com", Phone = 22233344 });
            customers.Add(new Customer { Customerid = 2222, Name = "zenitsu", Email = "thunderclap@gmail.com", Phone = 666667788 });
            customers.Add(new Customer { Customerid = 3333, Name = "Tanjiro", Email = "waterform@gmail.com", Phone = 565654443 });
            //customers[0].Customerid = 4444;
            //customers[0].Name = "SLIME";
            foreach (var cstomer in customers)
            {
                Console.WriteLine($"{cstomer.Customerid} {cstomer.Name} {cstomer.Email} {cstomer.Phone}");
            }
        }

        private static void GenericlistCollection()
        {
            var bikes = new List<string>();
            bikes.Add("Royal Enfield");
            bikes.Add("PULSAR");
            bikes.Add("rx 100");
            bikes.Add("yezdi");
            bikes.Add("Java");
            foreach (var bike in bikes)
            {
                Console.WriteLine(bike);

            }
            bikes.Remove("Java");
            Console.WriteLine(bikes.Count);
            foreach (var bike in bikes)
            {
                Console.WriteLine(bike);
            }
            bikes.RemoveAt(bikes.Count - 2);
            foreach (var bike in bikes)
            {
                Console.WriteLine(bike);
            }
        }

        private static void hierarchialInheritance()
        {
            Distributers distributers = new Distributers();
            distributers.Customerid = 1234;
            distributers.Name = "str";
            distributers.Email = "str@gmail.com";
            distributers.Phone = 222333444;
            distributers.Area = "malkajgiri";
            Console.WriteLine("{0} {1} {2} {3} {4}", distributers.Customerid, distributers.Name, distributers.Email, distributers.Phone, distributers.Area);
            Wholeseller();
        }

        private static void Wholeseller()
        {
            Wholesellercs wholesellercs = new Wholesellercs();
            wholesellercs.Customerid = 22;
            wholesellercs.Name = "str";
            wholesellercs.Phone = 222333444;
            wholesellercs.Email = "srr@gmail.com";
            wholesellercs.Nichebuissness = "mmcd";
            Console.WriteLine("{0} {1} {2} {3} {4}", wholesellercs.Customerid, wholesellercs.Name, wholesellercs.Phone, wholesellercs.Email, wholesellercs.Nichebuissness);
        }

        private static void Customerobj()
        {
            Customer customer = new Customer();
            customer.Customerid = 1234;
            customer.Name = "stre";
            customer.Email = "str@gmail.com";
            customer.Phone = 123434343;
            Console.WriteLine("{0} {1} {2} {3}", customer.Customerid, customer.Name, customer.Email, customer.Phone);
        }

        private static void MultilevelInheritance()
        {
            Novel novel = new Novel();
            novel.Title = "infinite";
            novel.Bookcode = 1234;
            novel.Author = "Nene";
            novel.Price = 6666;
            Console.WriteLine("{0} {1} {2} {3}", novel.Title, novel.Bookcode, novel.Author, novel.Price);
        }

        private static void SingleInheritance()
        {
            Shortstorybook shortstorybook = new Shortstorybook();
            shortstorybook.Author = "myself";
            shortstorybook.Title = "lost anger";
            shortstorybook.Bookcode = 123;
            shortstorybook.Price = 300;
            shortstorybook.Noofstories = 1;
            Console.WriteLine("title:{0}\tbookcode:{1}\tauthor:{2}\tprice:{3}\tno_of_stories:{4}", shortstorybook.Title, shortstorybook.Bookcode, shortstorybook.Author, shortstorybook.Price, shortstorybook.Noofstories);
        }

        private static void Genericbook()
        {
            Generic<Book> book = new Generic<Book>();
            book.field = new Book();
            book.field.Bookcode = 6966;
            book.field.Title = "lone ranger";
            book.field.Author = " str";
            book.field.Price = 666;
            Console.WriteLine("b{0}\t{1}\t{2}\t{3}", book.field.Bookcode, book.field.Title, book.field.Author, book.field.Price);
        }

        private static void Generic()
        {
            Generic<string> gstring = new Generic<string>();
            gstring.field = "str";
            Console.WriteLine("{0}", gstring.field);
            Generic<int> gint = new Generic<int>();
            gint.field = 0629;
            Console.WriteLine("{0}", gint.field);
        }
    }
}
