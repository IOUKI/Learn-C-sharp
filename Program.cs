﻿using System;
using System.IO;

class Person {
    public string name;
    private string Name // 屬性(取得和設定)
    {
        get { return name; }
        set { name = value; }
    }

    int age; // 預設情況下，類別的成員是私有的

    public Person(string initName, int initAge) {
        name = initName;
        age = initAge;
    }

    public void SayHi() {
        Console.WriteLine("Hi, my name is " + name + " and I am " + age + " years old.");
    }

    public void PrintName() {
        Console.WriteLine(Name);
    }
}

class Taiwanese : Person {
    public Taiwanese(string initName, int initAge) : base(initName, initAge) {
        name = initName;
        // age = initAge; // age is private
    }

    // 覆寫方法
    public new void SayHi() {
        Console.WriteLine("你好，我叫" + name);
    }

}

// 抽象類別
abstract class Animal {
    public abstract void animalSound();
    public void sleep() {
        Console.WriteLine("Zzz");
    }
}

// 繼承抽象類別
class Pig : Animal {
    // 實作抽象方法
    public override void animalSound() {
        Console.WriteLine("The pig says: wee wee");
    }
}

interface IAnimal {
    void animalSound(); // interface method (does not have a body)
}

class Dog : IAnimal {
    public void animalSound() {
        Console.WriteLine("The dog says: bow wow");
    }
}

interface IFirstInterface {
    void myMethod(); // interface method
}

interface ISecondInterface {
    void myOtherMethod(); // interface method
}

// 多種介面
class DemoClass : IFirstInterface, ISecondInterface {
    public void myMethod() {
        Console.WriteLine("Some text..");
    }
    public void myOtherMethod() {
        Console.WriteLine("Some other text...");
    }
}

enum Level {
    Low = 99,
    Medium,
    High
}

namespace HelloWorld {
    class Program {
        static bool MyMethod(string name = "harry", int age = 20) {
            Console.WriteLine("My name is " + name + ", My age is " + age);
            return true;
        }
        static int PlusMethod(int x, int y) {
            return x + y;
        }
        static double PlusMethod(double x , double y) {
            return x + y;
        }
        static void Main(string[] args) {
            // 註解
            // This is a comment
            /*
                多行
                註解
            */

            // 輸出
            Console.WriteLine("Hello World!");
            Console.WriteLine("Learning C#");
            Console.Write("3 + 3 = ");
            Console.WriteLine(3 + 3);

            // 變數
            // 語法: [type] [variableName] = [value];
            string name = "lan";
            Console.Write("My name is ");
            Console.WriteLine(name);
            int n1 = 15;
            Console.WriteLine(n1);

            int n2;
            n2 = 11;
            Console.WriteLine(n2);

            // 常數
            // 不可改變其中的數值
            const int constNum = 333;
            Console.WriteLine(constNum);

            // 顯示變數
            string firstName = "John ";
            string lastName = "Doe";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);
            Console.WriteLine(n1 + n2);

            // 多變數
            int x = 1, y = 2, z = 3;
            Console.WriteLine(x + y + z);
            // int x, y, z;
            x = y = z = 50;
            Console.WriteLine(x + y + z);


            // 資料型別
            /*
                int 	4 bytes	Stores whole numbers from -2,147,483,648 to 2,147,483,647
                long	8 bytes	Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
                float	4 bytes	Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
                double	8 bytes	Stores fractional numbers. Sufficient for storing 15 decimal digits
                bool	1 bit	Stores true or false values
                char	2 bytes	Stores a single character/letter, surrounded by single quotes
                string	2 bytes per character	Stores a sequence of characters, surrounded by double quotes
            */

            // 類型轉換
            int n3 = 9;
            double n4 = n3; // 隱式轉換
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            double n5 = 9.78;
            int n6 = (int) n5; // 明確轉換
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            bool bool1 = true;
            Console.WriteLine("bool1: " + bool1);
            Console.WriteLine("bool1: " + Convert.ToString(bool1));
            
            /*
                運算符:
                +	Addition	    Adds together two values	            x + y	
                -	Subtraction	    Subtracts one value from another	    x - y	
                *	Multiplication	Multiplies two values	                x * y	
                /	Division	    Divides one value by another	        x / y	
                %	Modulus	        Returns the division remainder	        x % y	
                ++	Increment	    Increases the value of a variable by 1  x++	
                --	Decrement	    Decreases the value of a variable by 1	x--
            */

            // 數學
            Console.WriteLine(Math.Min(5, 10));
            Console.WriteLine(Math.Sqrt(64));

            // 字串
            string txt = "abcd";
            Console.WriteLine("the length of the txt string is: " + txt.Length);
            string helloWorldTxt = "Hello, World!";
            Console.WriteLine(helloWorldTxt.ToUpper());
            Console.WriteLine(helloWorldTxt.ToLower());
            Console.WriteLine(string.Concat(txt, helloWorldTxt));
            Console.WriteLine($"txt: {txt}");
            Console.WriteLine($"txt[0]: {txt[0]}");
            Console.WriteLine($"txt a index: {txt.IndexOf('a')}");
            Console.WriteLine($"txt a substring: {txt.Substring(1)}");

            // if else
            if (n1 > n2) {
                Console.WriteLine("n1 > n2");
            } else if (n1 < n2) {
                Console.WriteLine("n1 < n2");
            } else {
                Console.WriteLine("n1 == n2");
            }
            bool bool2 = n1 > n2 ? true : false; // 三元運算符

            // switch
            switch(bool2) {
                case true:
                    Console.WriteLine("n1 > n2");
                    break;
                default:
                    Console.WriteLine("n1 <= n2");
                    break;
            }

            // while loop
            int j = 0;
            while (j < 5) {
                Console.WriteLine(j);
                j++;
            }

            // for loop
            for (int i = 0; i < 5; i++) {
                Console.WriteLine(i);
            }

            // foreach
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            foreach (string i in cars) {
                Console.WriteLine(i);
            }

            // Arrays
            Array.Sort(cars); // 依照文字長度由小排到大
            foreach (string i in cars) {
                Console.WriteLine(i);
            }

            // 多維陣列
            int[,] myNumbers = {{1, 2, 3, 4}, {5, 6, 7, 8}};
            int x1 = myNumbers[1, 2];
            Console.WriteLine("x1: " + x1);

            // 方法
            MyMethod(name, n1); // 傳遞參數
            MyMethod(); // 預設參數
            MyMethod(name: "alex", age: 36); // 關鍵字參數
            bool resultBoolean = MyMethod(); // 回傳值
            Console.WriteLine(resultBoolean);

            // 方法多載
            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("int: " + myNum1);
            Console.WriteLine("double: " + myNum2);

            // 類別
            Car myCar = new Car();
            myCar.fullThrottle();

            Person p1 = new Person(initName: "John", initAge: 25);  // 呼叫建構子
            p1.SayHi();
            Console.WriteLine(p1.name);
            p1.name = "Alex";
            Console.WriteLine(p1.name);
            p1.PrintName();

            Taiwanese t1 = new Taiwanese(initName: "豪豪", initAge: 25);
            t1.SayHi();

            // 抽象類別
            Pig myPig = new Pig();
            myPig.animalSound();
            myPig.sleep();

            // 介面
            Dog myDog = new Dog();
            myDog.animalSound();

            // 多種介面
            DemoClass myObj = new DemoClass();
            myObj.myMethod();
            myObj.myOtherMethod();

            // 列舉
            Level myVar = Level.Medium;
            Console.WriteLine(myVar);
            Console.WriteLine((int) Level.Low);
            Console.WriteLine((int) Level.Medium);

            // 檔案
            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

            string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
            Console.WriteLine(readText);  // Output the content

            // 例外處理
            try {
                int[] myNumbers2 = {1, 2, 3};
                Console.WriteLine(myNumbers2[10]);
            } catch (Exception e) {
                Console.WriteLine("Error: " + e.Message);
            } finally {
                Console.WriteLine("The 'try catch' is finished.");
            }
        }
    }
}