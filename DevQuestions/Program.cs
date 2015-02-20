using System;

namespace DevQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            InheritingClass1 ic1 = new InheritingClass1();
            InheritingClass2 ic2 = new InheritingClass2();


            Console.WriteLine(bc.GetString());
            Console.WriteLine(ic1.GetString());
            Console.WriteLine(ic2.GetString());


            Console.ReadLine();
        }
    }
}

public class BaseClass
{
    public virtual string GetString()
    {
        return "Value from base class";
    }
}

public class InheritingClass1 : BaseClass
{
    public override string GetString()
    {
        return "Value from inheriting class";
    }
}

public class InheritingClass2 : BaseClass
{
}

