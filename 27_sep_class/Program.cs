using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_sep_class
{
    internal class Program
    {
        public class Test<T>
        {
            private T data;

            public void Accept(T data)
            {
                this.data = data;
            }

            public T Print()
            {
                return data;
            }

        }


        public class Product
        {
            public int Id { get; set; }

            public string Name { get; set; }


            public int Price { get; set; }

            public override string ToString()
            {
                return $"{Id} {Name}  {Price}";
            }
        }

        static void Main(string[] args)
        {
            List<string> list1 = new List<string>();
            list1.Add("Abhay");
            list1.Add("Akarsh");
            list1.Remove("Akarsh");
            foreach (var l in list1)
            {
                Console.WriteLine(l);
            }


            string[] names = new string[2];
            list1.Insert(1, "Anshul");
            list1.CopyTo( names);

            foreach (var l in list1)
            {
                Console.WriteLine(l);
            }

            list1.Reverse();
            list1.Add("Saransh");

            list1.RemoveAt(2);

            list1.IndexOf("Saransh");

           // Console.WriteLine(list1.Capacity);



            // SortedList
            SortedList<int, string> number_names = new SortedList<int, string>();
            number_names.Add(11, "Abhay");
            number_names.Add(12, "Abhishek");
            number_names.Add(13, "Akarsh");
            number_names.Add(15, "Aniket");
            number_names.Add(14, null);


            foreach (KeyValuePair<int, string> item in number_names)
            {
                Console.WriteLine(" Key " + item.Key + " Value: " + item.Value);

            }




            // Stack

            Stack<string> numbers = new Stack<string>();
            numbers.Push("one");
            numbers.Push("two");
            numbers.Push("three");
            numbers.Push("four");

            foreach(var i in numbers)
            {
                Console.WriteLine(i);
            }   

            numbers.Pop();
            Console.WriteLine("peek at next item to destack " + numbers.Peek());

            numbers.Pop();



            Console.WriteLine("The array now is --");
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }

            Stack<string> numbers_first_copy = new Stack<string>(numbers);






            // Queue
            Queue<string> numbers_ = new Queue<string>();
            numbers_.Enqueue("Abhay");
            numbers_.Enqueue("Akarsh");
            numbers_.Enqueue("Rahul");
            numbers_.Enqueue("Rajesh");

            // create an array twice the size of queue and copy the elemnst starting from middle.
            string[] arr = new string[numbers_.Count * 2];
            numbers_.CopyTo(arr, numbers_.Count);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }




            // Dicitonary
            //Dictionary<int, string> dictionary = new Dictionary<int, string>();
            //dictionary.Add(1, "Test1");
            //dictionary.Add(2, "Test2");

            //foreach (KeyValuePair<int, string> item in dictionary)
            //{
            //    Console.WriteLine(item.Key + "  " + item.Value);
            //}


            //
            //List<Employee> emp1 = new List<Employee>();
            //emp1.Add(new Employee { Empid = 20, Empname = "Rajesh" });
            //emp1.Add(new Employee { Empid = 21, Empname = "Ramesh" });

            //List<Employee> emp2 = new List<Employee>();
            //emp2.Add(new Employee { Empid = 22, Empname = "Rahul" });
            //emp2.Add(new Employee { Empid = 23, Empname = "Ram" });

            //List<Employee> emp3 = new List<Employee>();
            //emp3.Add(new Employee { Empid = 24, Empname = "Rajsee" });
            //emp3.Add(new Employee { Empid = 25, Empname = "Roshan" });


            //List<Department> department = new List<Department>();
            //department.Add(new Department { Deptcode = 01, Deptname = "Marketing", emps = emp1 });
            //department.Add(new Department { Deptcode = 02, Deptname = "Advertsing", emps = emp2 });
            //department.Add(new Department { Deptcode = 01, Deptname = "Development", emps = emp3 });






            //foreach (Department d in department)
            //{
            //    Console.WriteLine($"{d.Deptcode}  {d.Deptname}");
            //        foreach (Employee e in d.emps)
            //    {
            //        Console.WriteLine($"{e.Empid}  {e.Empname}");
            //    }
                

            //}


            //Console.WriteLine(emp1.Empid);


            List<Department> departmentlist = new List<Department>()
            {
                new Department
                {
                    Deptcode = 01, Deptname = "marketing",
                    emps ={ new Employee{Empid=3,Empname="User3"},
                        new Employee{Empid=4,Empname="User4"},
                        new Employee{Empid=5,Empname="User5"}, }

                },

                new Department
                {
                    Deptcode = 02, Deptname = "hr",
                    emps ={ new Employee{Empid=4,Empname="User6"},
                        new Employee{Empid=5,Empname="User7"},
                        new Employee{Empid=7,Empname="User8"}, }
                }
            };

            foreach (Department d in departmentlist)
            {
                Console.WriteLine(d.Deptname);
                foreach (Employee e in d.emps)
                {
                    Console.WriteLine("\t" + e.Empname);
                }
            }





















        }
    }
}
