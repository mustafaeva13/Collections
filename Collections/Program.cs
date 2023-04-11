using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Security.AccessControl;
using System.Threading.Channels;
#region Contact List
//namespace ContactList
//{
//    class Person
//    {
//        public string Firstname { get; set; }
//        public string Lastname { get; set; }
//        public string Phonenumber { get; set; }
//        public static List<Person> Contact = new List<Person>();
//        private static object firstname;

//        static void Main(string[] args)
//        {

//            Person person = new Person();
//            Console.WriteLine("Enter your  name: ");
//            person.Firstname = Console.ReadLine();


//            Console.WriteLine("Enter Last name:");
//            person.Lastname = Console.ReadLine();

//            Console.WriteLine("Enter Phone number: ");
//            person.Phonenumber = Console.ReadLine();


//            Contact.Add(person);

//            static void ListPerson()
//            {
//                if (Contact.Count == 0)
//                {
//                    Console.WriteLine("Daxil et: ");
//                    Console.ReadKey();
//                    return;

//                }
//                Console.WriteLine(" your contact list have current people:\n");
//                foreach (var person in Contact)
//                {
//                    PrintPerson(person);
//                }
//                Console.WriteLine("\n continue");
//                Console.ReadKey();
//            }

//            static void PrintPerson(Person person)
//            {
//                throw new NotImplementedException();
//            }

//            Console.WriteLine("enter the person you would remove:");
//            string firtname = Console.ReadLine();
//            Person name = Contact.FirstOrDefault(name => name.Firstname.ToLower() == firstname.ToString());

//            if (name == null)
//            {
//                Console.WriteLine("yoxdur");
//                Console.ReadKey();
//                return;
//            }


//            string command = "";
//            while (command != "exit")
//            {
//                Console.Clear();
//                Console.WriteLine("enter your a command:");
//                command = Console.ReadLine().ToLower();
//                switch (command)
//                {
//                    case "add":
//                        AddContact();
//                        break;
//                    case "remove ":
//                        AddRemove();
//                        break;

//                    case "list":
//                        ListContact();
//                        break;

//                }
//            }
//        }

//        private static void ListContact()
//        {
//            throw new NotImplementedException();
//        }

//        private static void AddRemove()
//        {
//            RemoveContact();
//        }

//        private static void RemoveContact()
//        {
//            throw new NotImplementedException();
//        }

//        private static void AddContact()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
//    private static void ListPerson()
//    {
//        if (Contact.Count == 0)
//        {
//            Console.WriteLine("Daxil et: ");
//            Console.ReadKey();
//            return;

//        }
//        Console.WriteLine(" your contact list have current people:\n");
//        foreach (var person in Contact)
//        {
//            PrintPerson(person);
//        }
//        Console.WriteLine("\n continue");
//        Console.ReadKey();
//    }

//    private static void PrintPerson(Person person)
//    {
//        throw new NotImplementedException();
//    }
//}
//}
#endregion


#region WordfrequencyCounter

//namespace WordFrequencyCounter
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            character("numbers");
//        }
//        public static void character(string word)
//        {
//            Dictionary<string, int> words = new Dictionary<string, int>();
//            foreach (var item in word)
//            {
//                if (words.ContainsKey(item.ToString()))
//                {
//                    words[item.ToString()] = words[item.ToString()] + 1;

//                }
//                else
//                {
//                    words.Add(item.ToString(), 1);
//                }
//            }
//            Console.WriteLine(words.Count);
//            foreach (var item in words)
//            {
//                Console.WriteLine(item.Key + ": " + item.Value);
//            }
//            Console.ReadKey();
//        }


//    }
//}

#endregion

#region Undo
//namespace CancelRevertStack
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//        }
//        public interface IAction
//        {
//            void Undo();
//        }
//        public class AddCustomerAction : IAction
//        {
//            public AddCustomerAction(int customerId)
//            {

//            }
//            public void Undo()
//            {

//            }


//        }
//        public class UpdateCustomerAction : IAction
//        {
//            public UpdateCustomerAction(int customerId, string actionPerformed)
//            {

//            }

//            public UpdateCustomerAction(object id)
//            {
//                this.id = id;
//            }

//            public void Undo()
//            {

//            }
//            Stack<IAction> stack = new Stack<IAction>();
//            private object undoStack;
//            private object customerId;
//            private object id;
//            private object undostack;

//            void AddCustomer()
//            {
//                undoStack.Add(new AddCustomerAction(customerId.Id));
//            }
//            void UpdateCustomerQuantity()
//            {
//                NewMethod();

//                void NewMethod()
//                {
//                    undoStack.Add(new UpdateCustomerAction(customerId.Id));
//                }
//            }

//            private object GetUndostack()
//            {
//                return undostack;
//            }

//            void OnUndo(object undostack)
//            {
//                if (undostack.Count == 0)
//                    return;

//                var action = underStack.Pop();
//                action.Undo();
//            }
//        }
//    }
//}
#endregion




//namespace Printer
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//        }
//        class Document
//        {

//        }

//    }
//}