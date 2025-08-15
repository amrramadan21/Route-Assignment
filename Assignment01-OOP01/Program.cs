using System.Reflection;
using static Assignment01_OOP01.Program;

namespace Assignment01_OOP01
{
    #region Enum

    #region Q1

    enum WeekDays
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    #endregion

    #region Q2

    enum SeasOn
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    #endregion

    #region Q3

    [Flags]
    enum Permission : byte
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }

    #endregion

    #region Q4

    enum Colors
    {
        Red,
        Green,
        Blue
    }

    #endregion
    #endregion

    #region Struct

    #region Q1
    struct Person
    {
        private string? Name;
        private int Age;

        public Person(string? name, int Age)
        {
            this.Name = name;
            this.Age = Age;
        }

        public override string ToString()
        {
            return $"Name : {Name} \nAge : {Age}\n";
        }

    }
    #endregion

    #region Q2

    struct Point
    {
        private double x;
        private double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"({x},{y})";
        }

        #endregion

        #region Q3



        #endregion

        #endregion

        internal class Program
        {
            static void Main(string[] args)
            {
                #region Part01


                #region Enum
                #region Q1

                //Console.WriteLine("Days In The Week : ");

                //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
                //{
                //    Console.WriteLine(day);
                //}

                #endregion

                #region Q2


                //Console.WriteLine("Enter The Season Name : ");
                //string? Input = Console.ReadLine();

                //if (Enum.TryParse(Input, true, out SeasOn season))
                //{
                //    switch (season)
                //    {
                //        case SeasOn.Spring:
                //            Console.WriteLine("The Range Of This Season From March To May");
                //            break;
                //        case SeasOn.Summer:
                //            Console.WriteLine("The Range Of This Season From June To August");
                //            break;
                //        case SeasOn.Autumn:
                //            Console.WriteLine("The Range Of This Season From September To November");
                //            break;
                //        case SeasOn.Winter:
                //            Console.WriteLine("The Range Of This Season From December To February");
                //            break;
                //    }
                //}
                //else
                //    Console.WriteLine("Invalid Season Name Entered.");


                #endregion

                #region Q3

                //Permission userPermissions = Permission.Read | Permission.Write;
                //Console.WriteLine("Initial Permissions: " + userPermissions);

                //userPermissions |= Permission.Execute;  
                //Console.WriteLine("After Adding Execute: " + userPermissions);

                //userPermissions &= ~Permission.Write;   
                //Console.WriteLine("After Removing Write: " + userPermissions);

                //if (userPermissions.HasFlag(Permission.Read))
                //{
                //    Console.WriteLine("User has Read permission");
                //}
                //else
                //{
                //    Console.WriteLine("User does not have Read permission");
                //}

                //if (userPermissions.HasFlag(Permission.Write))
                //{
                //    Console.WriteLine("User has Write permission");
                //}
                //else
                //{
                //    Console.WriteLine("User does not have Write permission");
                //}

                #endregion

                #region Q4

                //Console.WriteLine("Enter The Color Name : ");
                //string? input = Console.ReadLine();

                //if (Enum.TryParse(input, true, out Colors color))
                //{
                //   if (color ==Colors.Red  || color == Colors.Blue  || color ==  Colors.Green)
                //        Console.WriteLine($"The Input Color {color} Is A Primary Color.");

                //   else
                //        Console.WriteLine($"The Input Color {color} Is Not A Primary Color.");
                //}
                //else
                //    Console.WriteLine("Invalid Color Name Entered.");


                #endregion
                #endregion

                #region Struct

                #region Q1


                //Person[] people = new Person[3];
                //people[0] = new Person("Amr" , 22);
                //people[1] = new Person("sief", 21);
                //people[2] = new Person("Ali" , 20);


                //Console.WriteLine("Person Details: ");

                //foreach (Person person in people)
                //{
                //    Console.WriteLine(person.ToString());
                //}



                #endregion

                #region Q2

                //Console.WriteLine("Enter The First Point : ");
                //double.TryParse(Console.ReadLine(), out double x);

                //Console.WriteLine("Enter The Second Point : ");
                //double.TryParse(Console.ReadLine(), out double y);

                //Point point = new Point(x, y);

                //double destance = Math.Sqrt(Math.Pow(point.x - point.y, 2));

                //Console.WriteLine($"The Destance Between The Two Points is :{destance} ");

                #endregion

                #region Q3

                //Person[] people = new Person[3];

                //for (int i = 0; i < people.Length; i++)
                //{
                //    Console.WriteLine("Enter The Name: ");
                //    string? name = Console.ReadLine();

                //    Console.WriteLine("Enter The Age: ");
                //    bool isBarsed = int.TryParse(Console.ReadLine(), out int age);

                //    if (!isBarsed)
                //    {
                //        Console.WriteLine("Invalid Age,Setting to 0.");
                //        age = 0;

                //    }

                //    people[i] = new Person(name, age);

                //}

                //Console.Clear();
                //Console.WriteLine("Person Details: ");

                //foreach (Person person in people)
                //{
                //    Console.WriteLine(person.ToString());
                //}



                #endregion

                #endregion

                #endregion

                #region Part02
                #region Encapsulation

                Employee[] EmpArr = new Employee[3];

                EmpArr[0] = new Employee(1, "Ali", 5000m, SecurityLevel.DBA, new HiringDate(15, 8, 2025), Gender.Male);
                EmpArr[1] = new Employee(2, "Mona", 3000m, SecurityLevel.Guest, new HiringDate(1, 1, 2024), Gender.Female);
                EmpArr[2] = new Employee(3, "Omar", 7000m, SecurityLevel.DBA, new HiringDate(20, 5, 2023), Gender.Male);

                foreach (Employee emp in EmpArr)
                {
                    Console.WriteLine(emp.ToString());
                }


                #endregion
                #endregion






            }
        }
    }

}
