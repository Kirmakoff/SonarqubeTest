using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonarqubeTest.Challenges;

public class SonarChallenges
{

    // Дыра в безопасности в закомментированном коде
    public static void SAST()
    {
        int minutesOfInactivity = 15;
        string db_server = SzyfrowanieString.deszyfruj("+Y6YOi1/sbxQxss3w=="),     //   server: myserver.com
               db_dbname = SzyfrowanieString.deszyfruj("QVzoAgOn2f8WYZ8EhyQ=="),   //   base: mybase
               db_login = SzyfrowanieString.deszyfruj("uxAPEElEt0pn6Dl0Eg=="),     //   user: myuser 
               db_password = SzyfrowanieString.deszyfruj("T9+tQTXMrx2etMfJiQ==");  //   password: mypassword
    }



    // Высокая когнитивная сложность 

    public static int HelloGreatCodeReadability()
    {
        var random = new Random();
        var myList = new List<int>();
        for(int i = 0; i < 3; i++)
        {
            myList.Add(random.Next(1,100));
        }
        return myList[0] % 2 == 0 ? 
            0 : myList[1] % 2 == 0 ?
                1 : myList[2] % 2 == 0 ?
                    3 : 4;
    }
    

    
    // Высокая цикломатическая сложность (в данном примере - 14)
    
    public static void ProcessData(int value, string input)
    {
        if (value > 0) // +1
        {
            for (int i = 0; i < value; i++) // +1
            {
                if (i % 2 == 0) // +1
                {
                    Console.WriteLine("Even: " + i);
                }
                else // +1
                {
                    Console.WriteLine("Odd: " + i);
                }

                try
                {
                    if (input.Length > 5) // +1
                    {
                        Console.WriteLine("Long input");
                    }
                    else if (input.Length == 0) // +1
                    {
                        throw new ArgumentException("Input cannot be empty");
                    }
                }
                catch (ArgumentException ex) // +1
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                catch (Exception ex) // +1
                {
                    Console.WriteLine("Unexpected error: " + ex.Message);
                }
                finally
                {
                    Console.WriteLine("Iteration complete.");
                }
            }
        }
        else if (value == 0) // +1
        {
            Console.WriteLine("Value is zero.");
        }
        else // +1
        {
            Console.WriteLine("Value is negative.");
        }

        switch (input) // +1 (each `case` adds 1)
        {
            case "test":
                Console.WriteLine("Test case.");
                break;
            case "example":
                Console.WriteLine("Example case.");
                break;
            default:
                Console.WriteLine("Default case.");
                break;
        }
    }
    
    // Много вложенных циклов
    
    public static string HelloCycles()
    {
        var list = HelperMethods.GetIntsList(100);
        var result = string.Empty;
        foreach (var item in list)
        {
            if (item % 2 == 0)
            {
                foreach (var item2 in list)
                {
                    if (item2 % 3 == 0)
                    {
                        foreach (var item3 in list)
                        {
                            if (item3 % 4 == 0)
                            {
                                result += "4";
                            }
                        }

                        result += "3";
                    }
                }

                result += "2";
            }
        }

        return result;
    }
    
    
    // Дублирование кода
    
    public static void InitializeServer(FakeServer server)
    {
        server.Initialize();
        server.DoStuff();
    }

    public static void ReinitializeServer(FakeServer server)
    {
        server ??= new FakeServer();

        server.Initialize();
        server.DoStuff();
    }

    // Ковариантность массивов
    
    public static void UnsafeArrayCovariance()
    {
        var strings = new string[] { "a", "b", "c" };
        object[] objects = strings;

        objects[0] = 69; // Компиляция проходит, но это приводит к ArrayTypeMismatchException в рантайме

    }
    
    // Пустой цикл
    
    public static void EmptyCycle(bool someCondition)
    {
        while (someCondition); // Всё тело цикла - это пустой оператор ;
        {
            Task.Delay(100).Wait();
        }
    }


    // Сложный синтаксис в булевых флагах
    public static class MyFlags
    {
        public static bool ReadOnly;
    }
    

    
    public static void FaultyFlags()
    {
        bool flags = false;

        // Эти два условия равны, и оба не работают как надо
        
        if (flags & MyFlags.ReadOnly == MyFlags.ReadOnly)
        {
            ;
        }

        if (flags & (MyFlags.ReadOnly == MyFlags.ReadOnly))
        {
            ;
        }
        
        // Нужно так (много лишних скобок)

        if ((flags & MyFlags.ReadOnly) == MyFlags.ReadOnly)
        {
            ;
        }
        
    }

    //ElementAt оптимизирован для IList, а не для IEnumerable

    public static int HelloGreatOptimization()
    {
        var listInt = HelperMethods.GetIntsList(1000);
        var list = listInt.Where(x => x > 0);   // Здесь возвращается IEnumerable
        var random = new Random();
        var randomElement = list.ElementAt(random.Next(1, 1000)); // Здесь будет больно ближе к 1000
        return randomElement;
    }


    public enum MyEnum
    {
        Small = 0,
        Medium = 1,
        Large = 2,
        Default = -1
    }

    // Неправильное значение в enum
    
    public static void WrongValuesInEnum()
    {
        var myEnum = (MyEnum)123;
        Console.WriteLine(myEnum);
    }


    // A1 Method Naming
    public void ProveritZarplaty()
    {
        Task.Delay(1000).Wait();
    }

    // B1 Method Naming
    public void CheckZarplata()
    {
        Task.Delay(10).Wait();
    }

    // C1 Method Naming
    public void CheckSalary()
    {
        Task.Delay(1).Wait();
    }


    // Аутентификация, которая прорпустит любого юзера, если он постучится два раза

    public static void AuthUser()
    {
        Console.WriteLine("User:");
        string username = Console.ReadLine();
        Console.WriteLine("Password:");
        string password = Console.ReadLine();
        AuthUser(username, password, true);
    }
    

    public static string AuthUser(string username, string password, bool updatePassword = false)
    {
        var auth = new Auth();
        if(updatePassword)
            password = auth.UpdatePassword(username, password);
        
        var verificationResult = auth.VerifyPassword(username, password);
        
        return verificationResult == PasswordVerificationResult.Success ? username : string.Empty;
    }
    
    
}