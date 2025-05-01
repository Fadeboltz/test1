/*using System;

namespace ConsoleAppEmployeeInformation
{
    class Employee
    {
        protected string id;
        protected string name;
        protected double salary;
        protected DateTime joinDate;

        public Employee(string id, string name, double salary, string joinDate)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.joinDate = DateTime.ParseExact(joinDate, "dd-MM-yyyy", null);
        }

        public virtual double GrossIncome()
        {
            return salary;
        }

        public override string ToString()
        {
            return "ID: " + id + ", Name: " + name + ", Salary: " + salary + ", Joining Date: " + joinDate.ToString("dd-MM-yyyy");
        }
    }

    class FullTime : Employee
    {
        private double bonus;

        public FullTime(string id, string name, double salary, string joinDate, double bonus)
            : base(id, name, salary, joinDate) 
        {
            this.bonus = bonus;
        }

        public override double GrossIncome()
        {
            double gross = (salary * 12) + (bonus * 2);
            Console.WriteLine("Gross Income of " + name + " (FullTime): " + gross);
            return gross;
        }

        public override string ToString()
        {
            return "ID: " + id + ", Name: " + name + ", Salary: " + salary + ", Joining Date: " + joinDate.ToString("dd-MM-yyyy") + ", Type: FullTime, Bonus: " + bonus;
        }
    }

    class PartTime : Employee
    {
        private double commission;

        public PartTime(string id, string name, double salary, string joinDate, double commission)
            : base(id, name, salary, joinDate) 
        {
            this.commission = commission;
        }

        public override double GrossIncome()
        {
            double gross = salary + commission;
            Console.WriteLine("Gross Income of " + name + " (PartTime): " + gross);
            return gross;
        }

        public override string ToString()
        {
            return "ID: " + id + ", Name: " + name + ", Salary: " + salary + ", Joining Date: " + joinDate.ToString("dd-MM-yyyy") + ", Type: PartTime, Commission: " + commission;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FullTime ft = new FullTime("123", "Elizabeth", 500000, "12-10-2099", 250000);
            PartTime pt = new PartTime("678", "Jinx", 120000, "23-08-2120", 35700);

            Console.WriteLine(ft);
            ft.GrossIncome();

            Console.WriteLine(pt);
            pt.GrossIncome();
        }
    }
}
*/

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{


    class Employee
    {

        protected string id;
        protected string name;
        protected double salary;
        protected DateTime joiningDate;

        public Employee(string id, string name, double salary, string joinDate)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            joiningDate = DateTime.ParseExact(joinDate, "dd-MM-yyyy", null);
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Joining Date: " + joiningDate);
        }

        public virtual void GrossIncome()
        {

        }
    }
    class FullTime : Employee
    {
        private double bonus;

        public FullTime(string id, string name, double salary, string joiningDate, double bonus)
            : base(id, name, salary, joiningDate)
        {
            this.bonus = bonus;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Bonus: " + bonus);
        }

        public override void GrossIncome()
        {
            double gross = (salary * 12) + (bonus * 2);
            Console.WriteLine("Gross Income (FullTime): " + gross);
        }
    }
    class PartTime : Employee
    {
        private double commission;

        public PartTime(string id, string name, double salary, string joiningDate, double commission)
            : base(id, name, salary, joiningDate)
        {
            this.commission = commission;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Commission: " + commission);
        }

        public override void GrossIncome()
        {
            double gross = salary + commission;
            Console.WriteLine("Gross Income (PartTime): " + gross);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FullTime ft = new FullTime("E-001", "Rahim", 30000, "12-10-2021", 15000);
            PartTime pt = new PartTime("E-002", "Karim", 12000, "23-08-2022", 1300);

            ft.ShowInfo();
            ft.GrossIncome();

            Console.WriteLine();

            pt.ShowInfo();
            pt.GrossIncome();
        }
    }

}
*//*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Vehicle
    {
        private string vehicleName;
        private string vehicleId;
        public static int vehicleCount = 0;

        public string VehicleName
        {
            get { return vehicleName; }
            set { vehicleName = value; }
        }

        public string VehicleId
        {
            get { return vehicleId; }
            set { vehicleId = value; }
        }

        public Vehicle()
        {
            vehicleCount++;
            Console.WriteLine("\nVehicle constructor is called .");

        }

        public virtual void Status()
        {
            Console.WriteLine("Vehicle is used for Transport .");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Vehicle Name: {vehicleName}, Vehicle ID: {vehicleId}");
        }
    }

    class Motorbike : Vehicle
    {
        public Motorbike()
        {
            VehicleName = "Motorbike";
            VehicleId = "XE991";
            Console.WriteLine("Bike Constructor is Called.");
        }

        public override void Status()
        {
            Console.WriteLine("Motorbike is a two wheel's Vehicle.");
            Console.WriteLine("Motorbike Name: " + VehicleName + " MotorBikeID: " + VehicleId);
        }
    }

    class Truck : Vehicle
    {
        public Truck()
        {
            VehicleName = "Truck";
            VehicleId = "TT4403";
            Console.WriteLine("Truck Constructor is Called.");
        }

        public override void Status()
        {
            Console.WriteLine("Truck is six wheel's Vehicle.");
            Console.WriteLine("Truck Name: " + VehicleName + " TruckID: " + VehicleId);
        }
    }

    class Car : Vehicle
    {
        public Car()
        {
            VehicleName = "Car";
            VehicleId = "PR0890";
            Console.WriteLine("Car Constructor is Called.");
        }

        public override void Status()
        {
            Console.WriteLine("Car is a four wheel's vehicle.");
            Console.WriteLine("Car Name: " + VehicleName + " CarID: " + VehicleId);
        }
    }

    class Saloon : Car
    {
        public Saloon()
        {
            VehicleName = "Saloon";
            VehicleId = "SS009";
        }

        public override void Status()
        {
            Console.WriteLine("Saloon is a beautiful car.");
            Console.WriteLine("Saloon Name: " + VehicleName + " SaloonID: " + VehicleId);
        }
    }

    class MPV : Car
    {
        public MPV()
        {
            VehicleName = "MPV";
            VehicleId = "MP99";

        }

        public override void Status()
        {
            Console.WriteLine("MPV is a type of Car.");
            Console.WriteLine("MPV Name: " + VehicleName + " MPVID: " + VehicleId);
        }
    }

    class Program
    {
        static void Main()
        {
            Vehicle moto = new Motorbike();
            moto.Status();
            Vehicle truck = new Truck();
            truck.Status();
            Vehicle car = new Car();
            car.Status();
            Vehicle saloon = new Saloon();
            saloon.Status();
            Vehicle mpv = new MPV();
            mpv.Status();

            Console.WriteLine("\nTotal Vehicles Created: " + Vehicle.vehicleCount);
        }
    }
}

*/
/*using System;

class SuperheroCharacter
{
    private string characterId;
    private string characterName;
    private string comicSeries;

    public SuperheroCharacter(string id, string name, string series)
    {
        characterId = id;
        characterName = name;
        comicSeries = series;
    }

    // Making virtual so it can be overridden in derived classes
    public virtual void ShowCharacterInfo()
    {
        Console.WriteLine($"ID: {characterId}, Name: {characterName}, Series: {comicSeries}");
    }

    public virtual bool CheckLegendStatus()
    {
        return false;
    }

    // Protected getters for derived class use
    protected string GetCharacterId() => characterId;
    protected string GetCharacterName() => characterName;
    protected string GetComicSeries() => comicSeries;
}

// ------------------ Hero Class ------------------
class Hero : SuperheroCharacter
{
    private int heroRank;
    private bool isLeadHero;
    private int appearancesCount;

    public Hero(string id, string name, string series, int rank, bool isLead, int count)
        : base(id, name, series)
    {
        heroRank = rank;
        isLeadHero = isLead;
        appearancesCount = count;
    }

    public override bool CheckLegendStatus()
    {
        return (isLeadHero && heroRank > 85 && appearancesCount > 120)
            || (!isLeadHero && appearancesCount > 90);
    }

    public override void ShowCharacterInfo()
    {
        Console.WriteLine($"[HERO] ID: {GetCharacterId()}, Name: {GetCharacterName()}, Series: {GetComicSeries()}");
        Console.WriteLine($"Rank: {heroRank}, Lead: {isLeadHero}, Appearances: {appearancesCount}");
        Console.WriteLine($"Legendary: {CheckLegendStatus()}\n");
    }
}

// ------------------ VillainBoss Class ------------------
class VillainBoss : SuperheroCharacter
{
    private int fearFactor;
    private bool duelWin;

    public VillainBoss(string id, string name, string series, int fear, bool win)
        : base(id, name, series)
    {
        fearFactor = fear;
        duelWin = win;
    }

    public override bool CheckLegendStatus()
    {
        return fearFactor > 75 && duelWin;
    }

    public override void ShowCharacterInfo()
    {
        Console.WriteLine($"[VILLAIN] ID: {GetCharacterId()}, Name: {GetCharacterName()}, Series: {GetComicSeries()}");
        Console.WriteLine($"Fear Factor: {fearFactor}, Duel Win: {duelWin}");
        Console.WriteLine($"Legendary: {CheckLegendStatus()}\n");
    }
}

// ------------------ Main Program ------------------
class Program
{
    static void Main()
    {
        SuperheroCharacter[] characters = new SuperheroCharacter[3];

        characters[0] = new Hero("H-101", "Iron Titan", "Galactic Warriors", 90, true, 150);
        characters[1] = new Hero("H-102", "Shadow Phantom", "Dark Legends", 70, false, 95);
        characters[2] = new VillainBoss("V-201", "Doom Lord", "Galactic Warriors", 80, true);

        foreach (SuperheroCharacter character in characters)
        {
            character.ShowCharacterInfo();
        }
    }
}
*/
/*using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] jagged = new int[4][];

        jagged[0] = new int[] { 1, 5, 7, 9, 11, 13, 15 };
        jagged[1] = new int[3]; // needs to hold 3 values
        jagged[2] = new int[] { 2, 4, 6, 8, 10, 12, 14, 16 };
        jagged[3] = new int[4]; // needs to hold 4 values

        for (int row = 0; row < 4; row += 2)
        {
            for (int column = 0; column < jagged[row].Length; column += 3)
            {
                //Console.Write("[" + row + "," + column + "] = ");
                Console.Write(jagged[row][column]);
            }
            Console.WriteLine();
        }

        for (int index = 0; index < jagged[1].Length; index += 2)
        {
            jagged[1][index] = jagged[0][index + 2] - jagged[0][index];
        }

        for (int index = 0; index < jagged[3].Length; index++)
        {
            jagged[3][index] = jagged[2][index + 2] - jagged[2][index + 3];
        }

        for (int row = 1; row < 4; row += 2)
        {
            for (int column = 0; column < jagged[row].Length; column += 2)
            {
                Console.Write(jagged[row][column] + " ");
            }
        }

        Console.WriteLine();
    }
}*/
/*namespace BoxUnbox
{
    public class A
    {
        internal int i = 10;
    }

    public class B : A
    {
        protected internal int j = 20;
    }

    class PrintA
    {
        public PrintA(ref int r)
        {
            r = 60;
        }

        internal int printA;
    }

    class PrintB
    {
        public PrintB(out string o)
        {
            o = "Try harder!";
        }

        protected internal int printB = 5;
    }

    public class Alpha
    {
        protected static string s = "This is a string";

        protected Alpha()
        {
            s += " alpha";
        }
    }

    class SubAlpha : Alpha
    {
        public SubAlpha()
        {
            s += " sub";
        }
    }

    public class SubSubAlpha : Alpha
    {
        public SubSubAlpha()
        {
            s += " subsub";
        }

        public static void print1(A a1)
        {
            Console.WriteLine(a1.i);
        }

        public static void print2(B b1)
        {
            Console.WriteLine(b1.j);
        }

        public static void Main(String[] args)
        {
            A a = new A();
            B b1 = new B();
            B b2 = new B();

            print1(a);     // Output: a.i
            print2(b1);    // Output: b1.j
            print2(b2);    // Output: b2.j

            Console.WriteLine(s);              // Value of static string s
            Console.WriteLine("Find the output:");

            s = null;
            new SubSubAlpha();                 // modifies s
            Console.WriteLine(s);              // updated s

            PrintA pa = new PrintA(ref a.i);
            PrintB pb = new PrintB(out s);

            Console.WriteLine("Out output = " + s);
            Console.WriteLine("printA = " + pa.printA);
            Console.WriteLine("Ref output = " + a.i);
            Console.WriteLine("printB = " + pb.printB);
        }
    }
}
*/

//using System;
//class Person
//{
//    private string name;
//    private int age;
//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }

//    public int Age
//    {
//        get { return age; }
//        set { age = value >= 0 ? value : 0; }
//    }
//    public Person()
//    {
//        name = "no name";
//        age = 0;
//        Console.WriteLine("Person default constructor called.");
//    }
//    public Person(string name, int age)
//    {
//        this.name = name;
//        this.age = age;
//        Console.WriteLine("Person parameterized constructor called.");
//    }
//    public virtual void DisplayInfo()
//    {
//        Console.WriteLine($"Person: {name}, Age: {age}");
//    }
//}
//class Student : Person
//{
//    private string course;

//    public string Course
//    {
//        get { return course; }
//        set { course = value; }
//    }

//    public Student(string name, int age, string course) : base(name, age)
//    {
//        this.course = course;
//        Console.WriteLine("Student parameterized constructor called.");
//    }

//    public override void DisplayInfo()
//    {
//        Console.WriteLine($"Student: {Name}, Age: {Age}, Course: {course}");
//    }
//}
//class Teacher : Person
//{
//    private string subject;

//    public string Subject
//    {
//        get { return subject; }
//        set { subject = value; }
//    }

//    public Teacher(string name, int age, string subject) : base(name, age)
//    {
//        this.subject = subject;
//        Console.WriteLine("Teacher parameterized constructor called.");
//    }

//    public override void DisplayInfo()
//    {
//        Console.WriteLine($"Teacher: {Name}, Age: {Age}, Subject: {subject}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Person p1 = new Student("Alice", 20, "Computer Science");
//        p1.DisplayInfo();
//        Person p2 = new Teacher("Mr. Smith", 40, "Mathematics");
//        p2.DisplayInfo();
//    }
//}

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Enter number of rows: ");
//        int rows = Convert.ToInt32(Console.ReadLine());
//        int[][] jaggedArray = new int[rows][];

//        for (int i = 0; i < rows; i++)
//        {
//            Console.Write($"Enter number of elements for row {i}: ");
//            int cols = Convert.ToInt32(Console.ReadLine());
//            jaggedArray[i] = new int[cols];

//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write($"Element [{i}][{j}]: ");
//                jaggedArray[i][j] = Convert.ToInt32(Console.ReadLine());
//            }
//        }

//        Console.WriteLine("\nJagged Array and Row Sums:");
//        for (int i = 0; i < jaggedArray.Length; i++)
//        {
//            Console.Write("Row " + i + ": ");
//            foreach (int val in jaggedArray[i])
//            {
//                Console.Write(val + " ");
//            }
//            Console.WriteLine(" | Sum = " + RowSum(jaggedArray[i]));
//        }
//    }

//    static int RowSum(int[] row)
//    {
//        int sum = 0;
//        foreach (int val in row)
//        {
//            sum += val;
//        }
//        return sum;
//    }
//}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp8
//{


//    class Employee
//    {

//        protected string id;
//        protected string name;
//        protected double salary;
//        protected DateTime joiningDate;

//        public Employee(string id, string name, double salary, string joinDate)
//        {
//            this.id = id;
//            this.name = name;
//            this.salary = salary;
//            joiningDate = DateTime.ParseExact(joinDate, "dd-MM-yyyy", null);
//        }

//        public virtual void ShowInfo()
//        {
//            Console.WriteLine("ID: " + id);
//            Console.WriteLine("Name: " + name);
//            Console.WriteLine("Salary: " + salary);
//            Console.WriteLine("Joining Date: " + joiningDate);
//        }

//        public virtual void GrossIncome()
//        {

//        }
//    }
//    class FullTime : Employee
//    {
//        private double bonus;

//        public double Bonus
//        {
//            get { return bonus; }
//            set { bonus = value; }
//        }

//        public FullTime(string id, string name, double salary, string joiningDate, double bonus)
//            : base(id, name, salary, joiningDate)
//        {
//            this.bonus = bonus;
//        }

//        public override void ShowInfo()
//        {
//            base.ShowInfo();
//            Console.WriteLine("Bonus: " + bonus);
//        }

//        public override void GrossIncome()
//        {
//            double gross = (salary * 12) + (bonus * 2);
//            Console.WriteLine("Gross Income (FullTime): " + gross);
//        }
//    }
//    class PartTime : Employee
//    {
//        private double commission;

//        public PartTime(string id, string name, double salary, string joiningDate, double commission)
//            : base(id, name, salary, joiningDate)
//        {
//            this.commission = commission;
//        }

//        public override void ShowInfo()
//        {
//            base.ShowInfo();
//            Console.WriteLine("Commission: " + commission);
//        }

//        public override void GrossIncome()
//        {
//            double gross = salary + commission;
//            Console.WriteLine("Gross Income (PartTime): " + gross);
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            FullTime ft = new FullTime("E-001", "Rahim", 30000, "12-10-2021", 15000);
//            PartTime pt = new PartTime("E-002", "Karim", 12000, "23-08-2022", 1300);

//            ft.ShowInfo();
//            ft.GrossIncome();

//            Console.WriteLine();

//            pt.ShowInfo();
//            pt.GrossIncome();
//        }
//    }

//}

using System;

class player
{
    protected string playerid;
    protected string playername;
    protected string teamname;

    public player(string playerid, string playername, string teamname)

    { 
        this.playerid = playerid;
        this.playername = playername;
        this.teamname = teamname;
    }
    public virtual void showinfo()
    {
        Console.WriteLine("hello");
    }
    public virtual void playerperformance()
    {

    }
}
class batsman: player
{
    private int totalruns;
    private double battingaverage;
    private int highestscore;

    public batsman(string playerid, string playername, string teamname, int totalruns, double battingaverage, int highestscore): base (playerid, playername,teamname)
    {
        this.totalruns = totalruns;
        this.battingaverage = battingaverage;
        this.highestscore = highestscore;
    }

    public override void showinfo()
    {
        base.showinfo();
        Console.WriteLine("Total Runs: " + totalruns);
        Console.WriteLine("Batting Average: "+battingaverage);
        Console.WriteLine("highest Score: "+ highestscore);
        playerperformance();
    }

    public override void playerperformance()
    {
        if (battingaverage > 50)
        {
            Console.WriteLine("Eligible for award.");
        }
        else
        {
            Console.WriteLine(" not eligible for award");
        }
    }
}
class bowler : player
{
    private int totalwickets;
    private double bowlingaverage;

    public bowler (string playerid, string playername, string teamname, int totalwickets, double bowlingaverage)
        : base (playerid, playername, teamname)
    {
        this.totalwickets = totalwickets;
        this.bowlingaverage = bowlingaverage;
    }

    public override void showinfo()
    {
        base.showinfo();
        Console.WriteLine("Total Wickets: " + totalwickets);
        Console.WriteLine("Bowling Average: "+ bowlingaverage);
        playerperformance();
    }
    public override void playerperformance()
    {
        if (totalwickets > 50)
        {
            Console.WriteLine("Eligible for award.");
        }
        else
        {
            Console.WriteLine(" not eligible for award");
        }
    }
}
class allrounder : player
{
    private int totalwickets;
    private int totalruns;

    public allrounder(string playerid, string playername, string teamname, int totalwickets, int totalruns)
        : base(playerid, playername, teamname)

    {
        this.totalwickets=totalwickets;
        this.totalruns=totalruns;   
    }

    public override void showinfo()
    {
        base.showinfo();
        Console.WriteLine("Total Wickets: "+ totalwickets);
        Console.WriteLine("Total Runs: "+ totalruns);
        playerperformance();
    }
    public override void playerperformance()
    {
        if (totalruns > 1000 && totalwickets > 50)
        {
            Console.WriteLine("Eligible for award.");
        }
        else
        {
            Console.WriteLine(" not eligible for award");
        }
    }
}

class program
{
    static void Main(string[] args)
    {
        player[] players = new player[4];

        players[0] = new batsman("P-1", "Tom Latham", "NZ", 6789, 57.3, 183);
        players[1] = new bowler("P-2", "Taskin Ahmed", "BD", 104, 23.2);
        players[2] = new allrounder("P-3", "Glenn Maxwell", "AUS", 7580, 98);
        players[3] = new allrounder("P-4", "Sam Curran", "ENG", 781, 60);

        foreach (player player in players)
        {
            player.showinfo();
            Console.WriteLine();
        }
    }
}