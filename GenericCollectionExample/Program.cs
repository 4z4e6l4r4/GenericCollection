using System.Collections;
using System.Linq;

namespace GenericCollectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    string[] isimler = new string[9];
            //    isimler[0] = "Dilara";
            //    isimler[1] = "Merve";
            //    isimler[2] = "Alparslan";
            //    //...
            //    isimler[8] = "Erhan";

            //    List<string> list = new List<string>();
            //    list.Add("Dilara");
            //    list.Add("Merve");
            //    list.Add("");
            //    list.Add("Erhan");
            //    list.Add("Yasir");
            //    list.Add("Ayşe");
            //    //....
            //    //16
            //    list.Add("Ahmet");//32


            //    foreach (string item in isimler)
            //    {
            //        if (!String.IsNullOrEmpty(item))
            //        {
            //            Console.WriteLine(item);
            //        }

            //    }
            //    Console.WriteLine("---------------");
            //    foreach (var item in list)
            //    {
            //        Console.WriteLine(item);
            //    }


            //    List<string[]> kisiler= new List<string[]>();
            //    string[] newinformatin1 = { "Erhan", "Kaya", "33", "Erkek" };
            //    kisiler.Add(newinformatin1);

            //    string[] newinformatin2 = { "Ayşe", "Kulin", "55", "Kadın","Yazar" };
            //    kisiler.Add(newinformatin2);

            //    kisiler.Add(new string[] { "Yasin", "22" });

            //    List<string[]> kisiler2= new List<string[]>//initialized - Liste oluşurken default veri oluşturma
            //    {
            //        new string[] {"Erhan","Kaya","33","Erkek"},
            //        new string[] {"Ahmet","Yalçın"},
            //        new string[] {"Ayşe","Kulin","22","yazar"}
            //    };
            //    int countArrayItems = 0;
            //    foreach (string[] item in kisiler2)
            //    {
            //       countArrayItems+=item.Length;
            //        int sayi = item.Length; int subindex = 0;
            //        foreach(string item2 in item)
            //        { 
            //            subindex++;
            //            Console.Write(item2);
            //            if (sayi == subindex) continue;

            //            Console.Write(" - ");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine(kisiler2.Count);
            //    Console.WriteLine(countArrayItems);


            //    Dictionary<int,string> keyValuePairs = new Dictionary<int,string>();

            //    keyValuePairs.Add(1, "Erhan");
            //    keyValuePairs.Add(2, "Yasin");

            //    Dictionary<int, string> keyValuePairs1 = new Dictionary<int, string>()
            //    {
            //        {2,"Yasin"},
            //        {3,"Ayşe"}
            //    };

            //    if (keyValuePairs1.ContainsKey(1))
            //    {
            //        Console.WriteLine(keyValuePairs1[1]);
            //    }
            //    Console.WriteLine();


            //    Dictionary<string,string> Users= new Dictionary<string, string>()
            //    {
            //        {"erhan@kaya.com","123123" },
            //        {"ismal@gulec.com","123" },
            //        {"merve@kavlak.com","kavlak123" },
            //        {"adem@karagulle.com","123" }
            //    };

            //    Console.Write("Enter Password: ");
            //    string password=Console.ReadLine();

            //    Console.Write("Enter Email: ");
            //    string email=Console.ReadLine();

            //    if (Users.ContainsKey(email)) {
            //        if(Users[email] == password){
            //            Console.WriteLine("Giriş Başarılı");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Şifreyi mi unutun? "+email+ " adresine sıfırlama kodu gönderebilirsin");
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı Bilgi Girişi");
            //    }


            //Dictionary<string, string[]> UserList = new Dictionary<string, string[]>()
            //{
            //    {"erhan@kaya.com",new string[] {"123","Erhan","Kaya"} },
            //    {"azra@yuksel.com",new string[] {"456","Azra","Yüksel"} }
            //};

            //string getEmail = "azra@yuksel.com";
            //string getPassword = "456";

            //if (UserList.ContainsKey(getEmail))
            //{
            //    if (UserList[getEmail][0] == getPassword)
            //    {
            //        Console.WriteLine($"Hoşgeldin {UserList[getEmail][1]} {UserList[getEmail][2]}.");
            //    }
            //}


            //List<User> users = new List<User>()
            //{
            //    new User { Id = 4,Name="Yasin",Surname="Solmaz",Email="yasin@solmaz.com",Password="123"},
            //    new User { Id = 5,Name="İrem",Surname="Gündoğdu",Email="irem@gun.com",Password="123"},
            //    new User { Id = 6,Name="Merve",Surname="Kavlak",Email="merve@kavlak.com",Password="123"},
            //};
            //users.Add(new User() { Id=1,Name="Erhan",Surname="Kaya",Email="erhan@kaya.com",Password="123"});

            //User user = new User();
            //user.Id = 2;
            //user.Name = "Fatih";
            //user.Surname = "Sezer";
            //user.Email = "fatih@sezer.com";
            //user.Password = "123";
            //users.Add(user);

            //User user1 = new User()
            //{
            //    Id = 3,
            //    Name="İsmail",
            //    Surname="Güleç",
            //    Email="ismail@gulec.com",
            //    Password="123"
            //};

            //users.Add(user1);



            //foreach (User item in users)
            //{
            //    Console.WriteLine($"{item.Id}.\t {item.Name}\t {item.Surname}");
            //}

            ////var findUser1 = users.FirstOrDefault(x=>x.Id==1);//tekil nesne çekme
            //// Console.WriteLine($"{findUser1.Name} {findUser1.Surname}");

            ////var findUser2 = users.Where(x => x.Id == 1).FirstOrDefault();//tekil nesne çekme
            //// Console.WriteLine($"{findUser2.Name} {findUser2.Surname}");

            //var findUsers = users.Where(x => x.Id == 1).ToList();//liste nesnesi çekme

            //foreach (var item in findUsers)
            //{
            //    Console.WriteLine($"{item.Name} {item.Surname}");

            //}
            //Console.WriteLine("--------------------");
            //var deleteUser=users.FirstOrDefault(x => x.Id == 4);//Kişiyi Bulma

            //if (deleteUser != null)//Bulanan Kişi Var mı?
            //{
            //    users.Remove(deleteUser);//Varsa Kişiyi nesne olarak listeden çıkar
            //}

            //foreach (var item in users)//Kalan Kullanıcıları Listeleme
            //{
            //    Console.WriteLine($"{item.Name} {item.Surname}");
            //}


            //Stack<string> stack = new Stack<string>();//LIFO Last in First out
            //stack.Push("A");
            //stack.Push("B");
            //stack.Push("C");
            //stack.Push("D");
            //stack.Push("E");

            //var lastValue=stack.Peek();
            ////Console.WriteLine(lastValue);

            //object value;
            //value = stack.Pop();//E
            //value = stack.Pop();//D
            //value = stack.Pop();//C
            //value = stack.Pop();//B
            //value = stack.Pop();//A
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(value);


            //Queue<string> queue = new Queue<string>();//FIFO First in Fist out
            //queue.Enqueue("Erhan");
            //queue.Enqueue("Enes");
            //queue.Enqueue("Dilara");
            //queue.Enqueue("Betül");

            //foreach (var item in queue)
            //{ 
            //    Console.WriteLine(item); 
            //}
            //Console.WriteLine("-------------");
            //string deleteValue=queue.Dequeue();
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Deleted Value= "+deleteValue);


            //Queue values = new Queue();
            //values.Enqueue("A");
            //values.Enqueue(1);
            //values.Enqueue(new User() { Id=1,Name="Erhan",Surname="Kaya",Email="adsad@asdas.com",Password="123"});

            //object deleteQueue;
            //deleteQueue=values.Dequeue();
            //deleteQueue=values.Dequeue();
            //deleteQueue=values.Dequeue();

            //Console.WriteLine(deleteQueue);


            List<User> userList = new List<User>()
            {
                new User { Id = 1,Name="Erhan",Surname="Kaya",Email="erhan@kaya.com",Password="123",Age=33},
                new User { Id = 2,Name="Alparslan",Surname="Kobak",Email="alp@kobak.com",Password="123",Age=23},
                new User { Id = 3,Name="Enes",Surname="Damat",Email="enes@damat.com",Password="123",Age=25},
                new User { Id = 4,Name="Yasin",Surname="Solmaz",Email="yasin@solmaz.com",Password="123",Age=24},
                new User { Id = 5,Name="İrem",Surname="Gündoğdu",Email="irem@gun.com",Password="123",Age=26},
                new User { Id = 6,Name="Merve",Surname="Kavlak",Email="merve@kavlak.com",Password="123",Age=24},
            };

            //Linq sorgularına temel giriş

            //where select
            //select * from Users where Age<26

            var list = userList.Where(x=>x.Age<26).ToList();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");
            //select from

            var list2 = from user in userList select user.Name+" "+user.Surname;

            foreach ( var item in list2 ) 
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------");

            var newlist = userList.Select(x => x.Age<25?  x.Age+ 1:x.Age);
            foreach ( var item in newlist )
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------");
            var newList2 = userList.Where(x=>x.Age<26).Select(x => x.Name);
            foreach (var item in newList2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------");
            var newList3 = from value in userList
                           where value.Age < 30
                           select new
                           {
                               Name = value.Name,
                               Surname = value.Surname,
                               Age = 0
                           };

            foreach ( var item in newList3)
            {
                Console.WriteLine(item.Name+" "+item.Surname+" "+item.Age);
            }


            List<NewUser> users = new List<NewUser>();
            
            foreach ( var item in newList3)
            {
                //NewUser newUser = new NewUser()
                //{
                //    Name= item.Name,
                //    Surname= item.Surname,
                //    Age = item.Age
                //};
                //users.Add(newUser);
                
                users.Add(new NewUser() {   Name = item.Name, 
                                            Surname = item.Surname, 
                                            Age = item.Age });
            }


        }
    }
}