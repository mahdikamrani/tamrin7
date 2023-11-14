

using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

List<student> students = new List<student>();

string path = @"C:\Users\owner\Desktop\studentname.txt";
using (StreamReader sr = File.OpenText(path))
{
    int i = 0;
    string s = "";
    while ((s = sr.ReadLine()) != null)
    {
        Console.WriteLine(s);
        student student = new student();
        student.FName = s.Split(',')[0];

        student.LName = s.Split(',')[1];

        student.advanced1 = Convert.ToDouble(s.Split(',')[2]);

        student.advanced2 = Convert.ToDouble(s.Split(',')[3]);

        student.sys = Convert.ToDouble(s.Split(',')[4]);

        student.algoritm = Convert.ToDouble(s.Split(',')[5]);

        student.sheygaraee = Convert.ToDouble(s.Split(',')[6]);

        student.english = Convert.ToDouble(s.Split(',')[7]);

        student.math = Convert.ToDouble(s.Split(',')[8]);

        student.tafsir = Convert.ToDouble(s.Split(',')[9]);

        student.varzesh = Convert.ToDouble(s.Split(',')[10]);

        student.kargah = Convert.ToDouble(s.Split(',')[11]);
        students.Add(student);

    }

}

do
{
    int x = Convert.ToInt32(Console.ReadLine());
    if (x == 1)
    {
        foreach (var student in students)
        {
            Console.WriteLine(
              student.FName + student.LName + ":" + student.totalaverage());

        }
    }
    if (x == 2)
    {
        foreach (var student in students)
        {
            Console.WriteLine(
                student.FName + student.LName + ":" + student.average1());
        }
    }
    if (x == 3)
    {
        foreach (var student in students)
        {
            Console.WriteLine(
                student.FName + student.LName + ":" + student.average2());
        }
    }

    if (x == 4)
    {
        foreach (var student in students)
        {
            Console.WriteLine(
                student.FName + student.LName + ":" + student.average3());
        }
    }
    if (x == 5)
    {
        foreach (var student in students)
        {
            Console.WriteLine(
               student.ShowAllPrime());


        }
    }
    if (x == 6)
    {
        foreach (var student in students)
        {
            Console.WriteLine(
               student.GetGrade());


        }
    }
    if (x == 7)
    {
        foreach (var student in students)
        {
            Console.WriteLine(
                student.FName + "" + student.LName + "  total average :" + student.totalaverage() + "  average1 :" + student.average1() + "  average2 :" + student.average2() + "  average3 :" + student.average3()
                );
        }
    }
    if (x == 8)
    {
        Console.WriteLine("---- Sorted by TotalAverage ---- ");
        List<student> sortedByTotalAverage = students.OrderByDescending(s => s.totalaverage()).ToList();
        foreach (var stu in sortedByTotalAverage)
        {
            Console.WriteLine(
            stu.FName + stu.LName + stu.totalaverage());
        }
        
        }
        if (x == 9)
        {
            Console.WriteLine("---- Sorted by TotalAverage ---- ");
            List<student> sortedByaverage1 = students.OrderByDescending(s => s.average1 ()).ToList();
            foreach (var stu in sortedByaverage1)
            {
                Console.WriteLine(
                stu.FName + stu.LName + stu.average1());

            }
            
            }
    if (x == 10)
    {
        Console.WriteLine("---- Sorted by TotalAverage ---- ");
        List<student> sortedByaverage2 = students.OrderByDescending(s => s.average2()).ToList();
        foreach (var stu in sortedByaverage2)
        {
            Console.WriteLine(
            stu.FName + stu.LName + stu.average2());

        }

        
        }
    if (x == 11)
    {
        Console.WriteLine("---- Sorted by TotalAverage ---- ");
        List<student> sortedByaverage3 = students.OrderByDescending(s => s.average3()).ToList();
        foreach (var stu in sortedByaverage3)
        {
            Console.WriteLine(
            stu.FName + stu.LName + stu.average3());

        }

           }

    } while (true) ;
    

   

class student
{
    public string FName { get; set; }
    public string LName { get; set; }
    public double math { get; set; }
    public double advanced1 { get; set; }
    public double advanced2 { get; set; }
    public double sys { get; set; }
    public double algoritm { get; set; }
    public double sheygaraee { get; set; }
    public double english { get; set; }
    public double tafsir { get; set; }
    public double varzesh { get; set; }
    public double kargah { get; set; }

    public double totalaverage()
    {
        return ((math * 2) + (english * 2) + (advanced1 * 3) + (advanced2 * 3) + (sys * 3) + (algoritm * 3) + (sheygaraee * 3) + (tafsir * 1) + (varzesh * 1) + (kargah * 1)) / 22;
    }


    public double average1()
    {
        return ((advanced1 * 3) + (advanced2 * 3) + (sys * 3) + (algoritm * 3) + (sheygaraee * 3)) / 15;

    }

    public double average2()
    {
        return ((english * 2) + (math * 2)) / 4;
    }

    public double average3()
    {
        return ((advanced1 * 3) + (advanced2 * 3) + (sys * 3) + (algoritm * 3) + (sheygaraee * 3) + (english * 2) + (math * 2)) / 19;
    }

    public bool isPrime(double number)
    {
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    public string ShowAllPrime()
    {
        string result = "";
        if (isPrime(math))
            result += "- math : " + math + " - ";

        if (isPrime(sys))
            result += "- sys : " + sys + " - ";

        if (isPrime(algoritm))
            result += "- algoritm : " + algoritm + " - ";

        if (isPrime(sheygaraee))
            result += "- sheygaraee : " + sheygaraee + " - ";

        if (isPrime(english))
            result += "- english : " + english + " - ";

        if (isPrime(tafsir))
            result += "- tafsir : " + tafsir + " - ";

        if (isPrime(varzesh))
            result += "- varzesh : " + varzesh + " - ";

        if (isPrime(kargah))
            result += "- kargah : " + kargah + " - ";

        if (isPrime(advanced1))
            result += "- advanced1 : " + advanced1 + " - ";

        if (isPrime(advanced2))
            result += "- advanced2 : " + advanced2 + " - ";

        if (string.IsNullOrEmpty(result))
            result = "Not Found Prime Score for " + FName + " " + LName;
        else
            result += " is Prime number for " + FName + " " + LName;

        return result;
    }

    public string GetGrade()
    {
        if (totalaverage() >= 17)
            return FName + " " + LName + " In Grade A";
        if (totalaverage() >= 15 && totalaverage() < 17)
            return FName + " " + LName + " In Grade B";
        if (totalaverage() >= 13 && totalaverage() < 15)
            return FName + " " + LName + " In Grade C";
        if (totalaverage() >= 10 && totalaverage() < 13)
            return FName + " " + LName + " In Grade D";
        if (totalaverage() >= 7 && totalaverage() < 10)
            return FName + " " + LName + " In Grade E";
        if (totalaverage() >= 3 && totalaverage() < 7)
            return FName + " " + LName + " In Grade F";
        if (totalaverage() >= 0 && totalaverage() < 3)
            return FName + " " + LName + " In Grade G";
        return FName + " " + LName + " in Grade H";
    }
   
}
//mahdi kamrani nezhad.tamrin7++
















