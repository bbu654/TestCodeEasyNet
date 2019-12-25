using System;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using TestCodeasyNet;    //using ClassObjectNAccessor;    //using RunProgram;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace TestCodeasyNet
{
    //  Printing with Color:
    class ColorPrint
    {
        public ConsoleColor OrigForeGroundColor, origBackGroundColor, ForeGroundColor, BackGroundColor;
        public void ColoredPrint(string text) //, ConsoleColor ForGroundColor, ConsoleColor BackGrndColor = ConsoleColor.Black, bool include = true)
        {
            OrigForeGroundColor = Console.ForegroundColor;          //  Save both Original ConsoleColors
            origBackGroundColor = Console.BackgroundColor;
            Console.ForegroundColor = ForeGroundColor;              //  Set new ConsoleColors
            Console.BackgroundColor = BackGroundColor;
            Console.Write(text);
            Console.ForegroundColor = OrigForeGroundColor;          //  Put Original ConsoleColors back
            Console.BackgroundColor = origBackGroundColor;
        }
    }
    class Util
    {
        private ConsoleColor _foregroundColor;
        private ConsoleColor _backgroundColor;
        public Util(ConsoleColor ForeGrndColor, ConsoleColor BackGrndColor)
        {
            _backgroundColor = BackGrndColor;
            _foregroundColor = ForeGrndColor;
        }
        public string TextRepeater(string text2, int numOfRepetitions)
        {
            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < numOfRepetitions; i++)
            { sb.Append(text2); }
            return sb.ToString();
        }
        public void PrintInColor(string text)
        {
            ColorPrint cp = new ColorPrint();
            cp.ForeGroundColor = _foregroundColor;
            cp.BackGroundColor = _backgroundColor;
            cp.ColoredPrint(text);
        }
        public int GenresCounter(string[] lopit)
        {
            int _genresCount = 0;
            foreach (string item in lopit)
            {
                if (item.Contains("{") || item.Contains("}") || item.Contains("Name") || item.Contains("ReleaseDate") || item.Contains("Genres") || item.Contains("[") || item.Contains("]"))
                { }
                else
                { ++_genresCount; }
            }
            return _genresCount;
        }
        public List<string> ReadStrings(Util util, List<string> sInput, string si = "Enter some strings with 0s", bool isConsoleRead = false)
        {
            if (isConsoleRead)
            {
                sInput.Clear(); util.PrintInColor($"{si}");
                while ((si = Console.ReadLine()) != "exit")
                { sInput.Add(Console.ReadLine()); }
            }
            return sInput;

        }
    }
        public static class StringExtensions
        {
            public static string ToString2<T>(this List<T> l)
            {
                string retVal = string.Empty;
                foreach (T item in l)
                    retVal += string.Format("{0}{1}", string.IsNullOrEmpty(retVal) ?
                                                                "" : ", ",
                                             item);
                return string.IsNullOrEmpty(retVal) ? "[]" : "[ " + retVal + " ]";
            }

            public static string ToString<T>(this List<T> l, string fmt)
            {
                string retVal = string.Empty;
                foreach (T item in l)
                {
                    IFormattable ifmt = item as IFormattable;
                    if (ifmt != null)
                        retVal += string.Format("{0}{1}",
                                                string.IsNullOrEmpty(retVal) ?
                                                   "" : ", ", ifmt.ToString(fmt, null));
                    else
                        retVal += ToString2(l);
                }
                return string.IsNullOrEmpty(retVal) ? "[]" : "[ " + retVal + " ]";
            }
        }
    //}
    class Utl
    {
        public  Utl()
        {
        }
        public static void PrintColoredA(ConsoleColor foreGC = ConsoleColor.White, ConsoleColor backGC = ConsoleColor.Black, string text = "")
        {
            Util util = new Util(foreGC, backGC);
            util.PrintInColor(text);
        }
    }
    static class AStringToStringBuilderAppendLine
    {
        //  private StringBuilder _stringBuilder;
        static public void ToBuilderStringAppendLine(this string line, StringBuilder sb)
        {
            sb.AppendLine(line);
        }
    }
    #region Encapsulation
    //  The Commander 
    //  The next day, I was walking down the corridor when I heard Infinity's voice coming 
    //  from the conference room. She sounded very stressed, which was far from her typical 
    //  confident demeanor. The talk must be significant, I thought, and before I could stop 
    //  myself, I began to eavesdrop. "What do you mean, faster? I have all of my resources 
    //  working on Rust; there's nothing left to add!" Infinity shouted.
    //  "It's too slow. You haven't made any attacks during the last month," the male voice 
    //  answered. "My sister was kidnapped; she barely survived," Infinity shot back. 
    //  "We couldn't just leave her there to be interrogated." "You're putting your own interest 
    //  higher than our mission. Your sister is just a programmer, we lose more and more 
    //  every day," the voice said. There was a pause. A long one. Even though I wasn't 
    //  participating in the discussion, I could feel the tremendous tension in the air. 
    //  Finally, Infinity got her voice back. "You are right, Commander. It won't happen 
    //  again. Our mission is more important than my sister's life." It was clear that this 
    //  was what the commander was looking for Inifinity to say. But how does someone will 
    //  themselves to say something so coarse and lifeless? It's easy to hear such phrases 
    //  in movies, where the actors are playing roles, but to hear it in the context of an 
    //  actual human life... Infinity giving her word that the next time there was a choice 
    //  between completing a mission and saving her sister's life, she would choose the former. 
    //  Scary. Is this why she was chosen as the leader of the resistance in Wonderland? 
    //  Was it out of weakness or strength that she could decided to put the mission before 
    //  her family? Who was the commander asking her to give up so much? Noname would probably 
    //  know. With his deep access in the network, he probably had access to personnel files. 
    //  "Noname, who is in the conference room now?" I asked silently.
    //  "Hi Teo, just one person, Infinity," Noname replied.
    //  "She was talking to someone. Please check again," I said.
    //  "In the modern world, Teo, there are ways to talk to people even if they're not in 
    //  the same room! My records are spotty that far back, but I'm pretty sure it was possible 
    //  in your time, 2018, as well. Maybe called a conference call? Such simple technology!"
    //  "Noname, who was she talking to?" I began to miss the straight-to-the-point British 
    //  personality Noname used to have. "The channel was encrypted. I don't have any way to 
    //  retrieve the credentials of whoever was talking to Infinity, sorry."
    //  "That's fine, don't worry, friend," I replied. Who was this Commander? 
    //  Encapsulation 
    //  In class the next day, we learned a new topic - encapsulation. Sintia was wearing 
    //  jeans and a t-shirt, casual as usual. "Have you ever heard the term 'encapsulation'? 
    //  No? This is one of the fundamental concepts in object-oriented programming. 

    //  Encapsulation has two goals:" 
    //  Keeping the data, and methods for working with the data, in one unit 
    //              (such as a class or struct in C#)
    //  Restricting direct access to some of the unit's components
    //  "Sintia..." two students said over one another.
    //  "I know, I know. Far too abstract. I'll explain by example. Take a look at this code snippet:" 
    //  class Car
    //  {
    //      public void PrintPrice(decimal price)
    //      {
    //          Console.WriteLine($"Car costs {price}");
    //      }

    //      public void PrintDiscountPrice(decimal price, int discount)
    //      {
    //          Console.WriteLine($"Price with discount is {price - discount}");
    //      }
    //  }

    //  class CarSetup
    //  {
    //      public static void Main()
    //      {
    //          var carPrice = decimal.Parse(Console.ReadLine());
    //          var carDiscount = int.Parse(Console.ReadLine());

    //          var car = new Car();
    //          car.PrintPrice(carPrice);
    //          car.PrintDiscountPrice(carPrice, carDiscount);
    //      }
    //  }
    //  "Does anything about this code jump out at you?" Sintia asked.
    //  "Is anyone else using variables carPrice and carDiscount?" I asked.
    //  "No, they are used only to call methods on an object of type Car."
    //  "Then I don't see any sense in keeping carPrice and carDiscount 
    //  outside of the class Car," I said."Good, Teo. So how would you rewrite this code snippet? 
    //  Here, I'll show the result to the class," Sintia said, swiping on her tablet to 
    //  show my work on the wall. I rewrote the code as follows: 
    //  class Car
    //  {
    //      public decimal Price;
    //      public int Discount;

    //      public void PrintPrice()
    //      {
    //          Console.WriteLine($"Car costs {Price}");
    //      }

    //      public void PrintDiscountPrice()
    //      {
    //          Console.WriteLine($"Price with discount is {Price - Discount}");
    //      }
    //  }

    //  class CarSetup
    //  {
    //      public static void Main()
    //      {
    //          var carPrice = decimal.Parse(Console.ReadLine());
    //          var carDiscount = int.Parse(Console.ReadLine());

    //          var car = new Car
    //          {
    //              Price = carPrice,
    //              Discount = carDiscount
    //          };

    //          car.PrintPrice();
    //          car.PrintDiscountPrice();
    //      }
    //  }
    //  "Exactly how I would do it!" Sintia declared, sounding genuinely impressed.
    //  "This code is a good representation of the first encapsulation concept: to keep 
    //  data and methods that work with that data in one class. Class Car contains data 
    //  fields Discount and Price, as well as the methods that work with those, 
    //  PrintPrice and PrintDiscount," Sintia said. 

    //  "I can improve this code snipped even further!" said one of the students in the room.
    //  "Go ahead!" Sintia projected the results of his work to the wall: 
    //  class Car
    //  {
    //      public decimal Price { get; }
    //      public int Discount { get; }

    //      public Car(decimal price, int discount)
    //      {
    //          Price = price;
    //          Discount = discount;
    //      }

    //      public void PrintPrice()
    //      {
    //          Console.WriteLine($"Car costs {Price}");
    //      }

    //      public void PrintDiscountPrice()
    //      {
    //          Console.WriteLine($"Price with discount is {Price - Discount}");
    //      }
    //  }

    //  class SomeOtherClass
    //  {
    //      public static void Main()
    //      {
    //          var carPrice = decimal.Parse(Console.ReadLine());
    //          var carDiscount = int.Parse(Console.ReadLine());

    //          var car = new Car(carPrice, carDiscount);

    //          car.PrintPrice();
    //          car.PrintDiscountPrice();
    //      }
    //  }
    //  "Okay, and can you explain why this is an improvement?" Sintia asked the student.
    //  "Because this code corresponds to the second encapsulation concept: it restricts a 
    //  direct access to all fields and sets the value through the constructor." 
    //  "Well done! In general, Public fields are usually not welcome in C#. 
    //  Public fields expose the inner state of your class, allowing anyone to change it," 
    //  Sintia summed up, adding, " The handout you picked up at the beginning of class lists 
    //  more advantages of using encapsulation. Read it over, take a quick break, and we'll 
    //  start coding in ten minutes." Controls values that are assigned to the inner state of 
    //  your class. For example, if you have a public field Age, anyone can assign it an 
    //  incorrect value, such as a negative number. In the case of properties, by 
    //  encapsulating this field, you can add a validation step before storing a value for Age. 
    //  Maintains consistency of the inner state of a class. Sometimes several objects are 
    //  intending to change the same field in an object of your class. It may even happen 
    //  simultaneously. To prevent collisions in simultaneous access to the same data and 
    //  take control over the inner state of the class, you can make the field private or 
    //  use a property. Thus, the changes in the inner state of your object could only be 
    //  done by your object itself, not by others. Correct usage of encapsulation guarantees 
    //  that no one can get direct access to the inner state of your class. It can only be 
    //  accessed by using methods or properties. 
    //  Makes it easier to change a publicly used class. Imagine that your class is used by 
    //  dozens of other teams of coders in different projects, applications, countries... 
    //  Then, changing the name of a single public method or field can lead to thousands 
    //  of users with broken software. Sounds like a catastrophe, right? In contrast, 
    //  changing the name of a private method or field is safe because no one can use 
    //  it except your class itself. 
    //  "It feels like we're advancing into software architecture principles and best practices!" 
    //  I told Sintia during the break. "Exactly, Teo. To be a good programmer, you need 
    //  to know more than just the syntax of a programming language. You have to have the right mindset." 
    //  "Okay everyone, take your seats," Sintia said. */  
    #endregion
    //TODO:
    //    "Here are the tasks I want you to work through." 
    //    Change public fields in the class Elevator to properties with the same name and type. 
    //    Leave getters and setters with default access modifiers. 
    //    Code!

    //    Change public fields in the class User to properties with the same name and type. 
    //    Leave getters and setters with default access modifiers. 
    //    In the setter of the property Name, check whether the string is null or empty. 
    //    If it is, do not assign that value. 
    //    Code!

    //    Change public fields in the class Shop and GeoLocation to properties 
    //    with the same names and types. Leave getters with default access modifiers 
    //    and change access for setters to private. Add constructors to Shop and GeoLocation 
    //    that take values for every property as parameters and assigns them. 
    //    Code!

    //    Despite the fact that Wonderland has an idyllic name, crimes are still present here. 
    //    We recently noticed that one particular coder is decreasing the value of every good 
    //    they buy by 1 virus in order to save on every purchase. Change the class Good to use 
    //    properties with public getters and setters. The current code should still work, 
    //    but decreasing of the price should have no effect. To achieve this, 
    //    change the code in the Price's setter. You are not allowed to change any code outside of the Good class. 
    //    Code!                           Email:info@codeasy.net
    class Box
    {
        public int Length;
        public int Width;
        public int Height;
        public int Area;
        public bool IsOpened;
        public Box(int length, int width, int height)
        {
            Length = length; Width = width; Height = height;
            CalcBoxArea();
        }
        public int CalcBoxArea()
        {
            Area = Length * Width * Height; return Area;
        }
        public enum eComp
        {
            IsGreat = 0,
            IsLess = 1,
            IsEqual = 2
        }

        public int CompareTo(Box box2)
        {
            #region CompareTo
            //  Infinity added, "One more interesting use of this it to pass current object 
            //  somewhere; for example, to a method." 
            //  Method Comparator.Compare compares 2 boxes by their volume 
            //  and returns 1 if the first one is bigger than the second one, 
            //  -1 if the second one is bigger than the first one, 
            //  or 0 if the boxes are equal. Modify the code in a way 
            //  that class Box uses the Comparator.Compare method to be compared to another box.
            //  Depending on the result of the comparison, 
            //  CompareTo should return "Bigger" if the current box is bigger than box, 
            //  "Smaller" if the current box is smaller than box, and 
            //  "Equal" if the boxes are equal.  
            //  In the Main, method, read Width, Height, and Length from the console 
            //  for two boxes and output the result of box1.CompareTo(box2).
            //  For example:
            //  >100
            //  >200
            //  >300
            //  >4
            //  >5
            //  >6
            //  Bigger    Code!
            #endregion
            List<string> scomp = new List<string>() { " is equal to ", " is less than ", " is greater than " };
            string[] sComp = { " is equal to ", " is less than ", " is greater than " };
            Util util = new Util(ConsoleColor.Green, ConsoleColor.Black);
            util.PrintInColor($"box1(Length={Length}, Width={Width}, Height={Height})Area = {this.Area}");
            int iReturn; const string isgreater = " is equal to ", isless = " is less than ";
            if (this.Area == box2.Area)
            { util.PrintInColor(sComp[Convert.ToInt32(eComp.IsGreat)]); iReturn = 0; }
            else if (this.Area < box2.Area)
            { util.PrintInColor(isless); iReturn = -1; }
            else
            { util.PrintInColor(scomp[3]); iReturn = 1; }
            util.PrintInColor($"box2(L={box2.Length},W={box2.Width},H={box2.Height})A={box2.Area}\n");
            return iReturn;
        }
        public void OpenBox()
        { IsOpened = true; }
        public void CloseBox()
        { IsOpened = false; }
        public void PrintBoxArea(int boxArea)
        {
            Util util = new Util(ConsoleColor.Black, ConsoleColor.White);
            util.PrintInColor($"\nbox(Length={Length}, Width={Width}, Height={Height})Area = {boxArea}\n");
        }
    }
    // Using object initializer
    class objectInitializer
    {
        #region objectInitializerText
        //  "To create a property, use the same syntax as for fields, but add a get; to generate a getter 
        //  and a set; to generate a setter. Then use the property the same as you do a field." 
        //      class Student
        //      {
        //          public int Age { get; set; }
        //          public string Name { get; private set; }
        //  
        //          public Student() // Empty constructor
        //          {}

        //          var student = new Student
        //          {
        //              Age = 20, // Work with Age just like a public field
        //              Name = "John" // ERROR: setter for the Name is private
        //          };

        //  Using classic approach
        //          var student = new Student();
        //          student.Age = 20; // Work with Age just like a public field
        //          student.Name = "John" // ERROR: setter for the Name is private

        //  Using a constructor that sets age
        //          var student = new Student(20, "John");
        //      }
        //  }
        //  "Is this clear?" Noname asked.  "What type can the property have?" I asked.
        //  "There are no limitations to a property's type. Think of it as a field 
        //  with 2 additional methods - get and set."  "Got it," I said confidently, 
        //  hoping that the lesson in class would clear it up a bit more. 
        //  "Note that getters and setters are public by default unless you use a private keyword. 
        //  Here are some exercises for you." 
        #endregion
    }
    class Plant
    {        public string Type { get; set; }    }
    class Flower : Plant
    {
        //  Create a class Flower with 4 public properties: string Name, string Color, int Age, 
        //  and bool IsEndangered. Do not add any access modifiers to getters or setters.    
        //  Make the program compile by deriving class Flower from the class Plant. Set flower's 
        //  property Type to Flowering, and then output it to the screen.

        public string Name         { get; set; }
        public string Color        { get; set; }
        public int Age             { get; set; }
        public bool IsEndangered   { get; set; }
        public Flower(string name, string color, int age, string type, bool isEndangered)
        {
            Name = name;
            Color = color;
            Age = age; Type = type;
            IsEndangered = isEndangered;
            WriteFlower();
        }
        public void WriteFlower()
        {
            Util util = new Util(ConsoleColor.Red, ConsoleColor.Black);
            util.PrintInColor($"Flower: {Name}, {Color}, {Age.ToString()}, {Type}, ");
            util.PrintInColor((IsEndangered) ? "Is Endangered\n" : "Is Not Endangered\n");
        }
    }
    //  Code!

    class ChickenFarm
    {           /*  */
        //  Create a class ChickenFarm with 4 public properties: 
        //  double Longitude, double Latitude, int Capacity, and string Identifier. 
        //  Make a setter for the Identifier - private. 
        //  Remove the setter for the Capacity. 
        //  Leave all other getters and setters as-is without any access modifiers. 
        public double Longitude { set; get; }
        public double Latitude { set; get; }
        public int Capacity { get; }
        public string Identifier { set; get; }
        public ChickenFarm(double longitude, double latitude, int capacity, string identifier)
        {
            Longitude = longitude;
            Latitude = latitude;
            Capacity = capacity;
            Identifier = identifier;
            WriteChickenFarm();
        }
        public void WriteChickenFarm()
        {
            Util util = new Util(ConsoleColor.Red, ConsoleColor.Black);
            util.PrintInColor($"Chicken Farm: ID={Identifier}, Capacity={Capacity}, Lat={Latitude}, Long={Longitude}\n");
        }
    }
    class Geolocation
    {   //  Extract the Latitude and Longitude from the ResistanceBase to a separate class 
        //  called GeoLocation. Add a property of type GeoLocation named Location to the ResistanceBase, 
        //  and leave the getter and setter with default access.   
        public double Latitude { set; get; }
        public double Longitude { set; get; }
        public Geolocation(double lat, double llong)
        { Latitude = lat; Longitude = llong; }
    }
    class ResistanceBase
    {        //  Rename the ChickenFarm class from the previous task to ResistanceBase.
        public int Capacity { get; }
        public string Identifier { set; get; }
        public ResistanceBase(double longitude, double latitude, int capacity, string identifier)
        {
            Capacity = capacity;
            Identifier = identifier;
            WriteResistanceBase(new Geolocation(latitude, longitude));
        }
        //public class Person : Tuple<string, string>
        //{
        //    private Tuple<string,string> person { nam}
        //    public void Key(string name, string age) { }

        //    public string Name => Item1;
        //    public string Age => Item2;
        //}
        public void WriteResistanceBase(Geolocation loc)
        {
            Util util = new Util(ConsoleColor.Red, ConsoleColor.Black);
            util.PrintInColor($"Resistance Base: ID={Identifier}, Capacity={Capacity}, Location=({loc.Latitude},{loc.Longitude})\n");
        }
    }
    //  "Noname, these properties look simple, but I'm not sure I see their utility. 
    //  What's the benefit of having a private field with two methods, get and set, 
    //  rather than just having a public field?" 
    //  
    //  "One of the easiest ways to understand the convenience of properties is to implement a 
    //  custom setter or getter. The code block for the get accessor is executed when 
    //  the property is read; the code block for the set accessor is executed when the 
    //  property is assigned a new value. Properties with an empty getter or setter, 
    //  like those we've been looking at, are called auto-implemented properties. 
    //  You can extend an auto-implemented property with a custom getter or setter, like this:" //  

    //  private int _age;

    //  public int Age
    //  {
    //      get    {       return _age;      }
    //      set    {       _age = value;     }
    //  }
    //  "In case of not auto-implemented properties, backing private field is not auto-implemented,
    //  and you need to create it yourself. As you could see, I've created a field _age," Noname explained.
    /*  public int Age
    //  {
    //      get; // This is auto-implemented
    //      set  // This is not auto-implemented. Error!
    //      {
    //          ...
    //      }
    //  }

    //  -------------------------------------------------------------------------
    //  public int Age { get; set; } // Getter and setter auto-implemented. Correct.
    //  -------------------------------------------------------------------------
    //  private int _age;
    //  public int Age
    //  {
    //      get   { return _age; }    // This is custom, not auto-implemented
    //      set   { _age = value; }   // This is custom, not auto-implemented. Correct
    //  }
    //  "What does value in this code mean?" I asked.
    //  "Value is a placeholder for the value that is assigned to the property Age. 
    //  Because we defined the getter and setter, we can implement other features, 
    //  such as inputting a parameter to the setter. This allows us to add custom 
    //  logic to a setter. For example, we never want age to be input as less than zero. 
    //  We can prevent anyone from setting a negative age like this," Noname said, 
    //  refreshing the image of the code in my head. 
    //  class Tiger
    //  {
    //      private int _age;
    //      public int Age
    //      {
    //          get    { return _age; }
    //          set    { (value > 0) ? _age = value; : _age = 0;// Check for the valid age
    //      }
    //  }
    //  public static void Main()
    //  {
    //      var tiger = new Tiger();
    //      tiger.Age = 2;                 // Ok, valid age
    //      tiger.Age = -2;                // Invalid value, age set to 0
    //      Console.WriteLine(tiger.Age);  // Outputs 0
    //  }
    //  "Noname, can you use a property without a backing field?" I queried.
    //  "Good question, Teo! Sometimes data can have different representations. 
    //  For example, taking the previous example with age, say you want to separate 
    //  young tigers from old tigers in a zoo. There's no need for additional fields 
    //  - you can achieve this by adding just one property." 
    //  class Tiger
    //  {
    //      private int _age;
    //      public int Age
    //      {
    //          get    { return _age; }
    //          set    { if (value > 0) { _age = value; }  // Check for the valid age
    //      }
            public bool IsOld
    //      {
    //          get    { return _age > 20; }
    //      }
    //  "In the above example, IsOld could have been a method instead," Noname added.
    //  "This is fascinating Noname, and it'll put me ahead of the class. Thanks for sharing 
    //  this!" I said, before adding "Is there anything I can do for you?" Thinking back to our 
    //  earlier conversation, I wanted to make sure I held up my end of the partnership.
    //  "Learn C#, be my teammate, and together we'll save the world," Noname answered.
    //  Noname's reply lifted my spirits. For a second, all my doubts were out of mind and I 
    //  felt confident that all of this hard work would actually change the world and create a 
    //  brighter future for millions of people.
    //  After a small pause Noname added, "And please, never set anything in a getter. 
    //  In the getter you get a value, and in the setter you set it. Don't confuse the two."

    //  Replace getter and setter methods with corresponding properties. 
    //  The property's name should be the same as its originating methods, 
    //  but without "Get" and "Set". For example, if the method had a name int GetSize(), 
    //  then the property should have type int and name Size. 
    //  Leave all access modifiers the same: private setters should stay private. 
    //  Delete backing fields if possible. Code!
 */
    class StudentGetterSetter
    {
        private int _age;

        public int GetAge()
        {
            return _age;
        }

        public void SetAge(int age)
        {
            _age = age;
        }
    }
    class Student
    {
        private int _age;
        private string _name;//public string Name { get; set; }
        public Student(string name, int age)
        {
            //Util util = new Util(ConsoleColor.Red, ConsoleColor.Black);
            Console.WriteLine($"Student: Name={0}, Age={1}", name, (age > 0) ? age.ToString() : "0");
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        { _name = name; }
        public int GetAge()
        {
            return _age;
        }
        public void SetAge(int age)
        {
            if (age > 0)
                _age = age;
            else
                _age = 0;
        }
        public void PrintStudent(string name, int age)
        {
            Util util = new Util(ConsoleColor.Red, ConsoleColor.Black);
            util.PrintInColor($"Student: Name={name},");
        }
    }
    class NullAndThis
    {
        private bool _enterInput = false;
        public NullAndThis(bool enterConsoleInput = false)
        {
            _enterInput = enterConsoleInput;
        }
        public static void RunNAT()  //  Chapter 2.2 Null and This
        {
            Utl.PrintColoredA(ConsoleColor.Red, ConsoleColor.Black, $"\nYou are entering CSharp-Intermediate: Chapter 3: Properties, Encapsulation.\n\n");
            AdvancedDroid ad = new AdvancedDroid(0, 0); ad.MoveTo(2, 2);
            new Guess(6);
            Box box1 = new Box(1, 2, 3) { IsOpened = false };
            Box box2 = new Box(1, 2, 4) { IsOpened = false };
            int cbox = box1.CompareTo(box2); string line = "freaking stunning beach";
            NullTest nullTest = new NullTest(line);
            nullTest.PigLatin(line);
            string line2 = nullTest._newlyCreated; nullTest.PrintPL(line, line2);
            //  Chapter 3.1 Properties
            new Flower("Rose", "Red", 10, "Flowering" ,false) ;
            new ChickenFarm(62.9856, 168.333365, 10, "Red Rooster");
            new ResistanceBase(62.9856, 168.333365, 21, "Red Droid");
            Utl.PrintColoredA(ConsoleColor.Red, ConsoleColor.Black, $"\nYou are exiting CSharp-Intermediate: Chapter 3: Properties, Encapsulation.\n\n");
        }
    }
    class ConsoleReadLineA
    {
        public ConsoleReadLineA()
        {
            Util sutil = new Util(ConsoleColor.White, ConsoleColor.Black);
            ConsoleReadLineAcces(sutil);
            ConsoleReadLineHowRU(sutil);
            ConsoleReadLineGreet(sutil);
            ConsoleReadLineMaxO2(sutil);
            ConsoleReadLineTempQ(sutil);
            ConsoleReadLineCallU(sutil);
            ConsoleReadLineFlyIt(sutil);
            ConsoleReadLineZGame(sutil);
            ConsoleReadLineOMidl(sutil, 65, 32, 95);
            ConsoleReadLineOMidl(sutil, 12, 11, 10);    //  sutil.PrintInColor("\n");
            ConsoleReadLineNMidl(sutil, 60, 50, 70);
            CrappyCalc(sutil, 10, 0);
            Quizs(sutil);
            ForLoops(sutil, 10);
            ForDiskSpace(sutil, 3, new int[] { 16, 38, 4 });
            ForDiskSpace(sutil, 3, new int[3] { 33, 17, 3 }); sutil.PrintInColor("\n");
            
        }
        //  public Utl(ConsoleColor fore, ConsoleColor back, string text = "")
        //  {
        //      PrintIt(fore, back, text);
        //  }

        //  public static void PrintIt(ConsoleColor fore, ConsoleColor back, string text = "")
        //  {
        //      ConsoleColor foreOrig = Console.ForegroundColor;
        //      ConsoleColor backOrig = Console.BackgroundColor;
        //      Console.ForegroundColor = fore;
        //      Console.BackgroundColor = back;
        //      if (text.Length > 0) { Console.Write(text); }
        //      Console.ForegroundColor = foreOrig;
        //      Console.BackgroundColor = backOrig;
        //  }
        public static void ConsoleReadLineNMidl(Util sutil, int num1 = 0, int num2 = 0, int num3 = 0, bool isConsoleRead = false)
        {
            int iA = 0, iB = 0, iC = 0, low = 0, mid = 0, high = 0;
            if (isConsoleRead)
            {
                string aString = Console.ReadLine();  //  Read a line from the console
                string bString = Console.ReadLine();  //  Read a line from the console
                string cString = Console.ReadLine();  //  Read a line from the console

                iA = int.Parse(aString);  //  Convert aString to an integer
                iB = int.Parse(bString);  //  Convert bString to an integer
                iC = int.Parse(cString);  //  Convert cString to an integer
            }
            else
            {
                iA = num1; iB = num2; iC = num3;
            }
            // Perform checks here to find out which number is the middle one.
            if (iA < iB)
            {
                low = iA;
                mid = iB;
                if (iC < low) //c a b
                { high = mid; mid = low; low = iC; }    //                 Console.WriteLine(iA);
                else
                {
                    if (iC < mid)          //    a c b    
                    { high = mid; mid = iC; }           //                 Console.WriteLine(iC);
                    else                   //    a b c
                    { high = iC; }                      //                 Console.WriteLine(iB);
                }
            }
            else  // b > a
            {
                low = iB;
                mid = iA;
                if (iC < low)           //    c b a 
                { high = mid; mid = low; low = iC; }    //                 Console.WriteLine(iB); 
                else
                {
                    if (iC < mid)       //    b c a
                    { high = mid; mid = iC; }           //                 Console.WriteLine(iC);
                    else                //    b a c
                    { high = iC; }                      //                 Console.WriteLine(iA);
                }
            }
            sutil.PrintInColor($"Orig: {iA.ToString()}, {iB.ToString()}, {iC.ToString()}.    Sorted: {low.ToString()}, {mid.ToString()}, {high.ToString()}.        ");
        }   //  public static void TheMiddle()
        public static void CrappyCalc(Util sutil, int iA = 10, int iB = 0, string operation = "all", bool isConsoleRead = false)  //  , string oper = "add")
        {
            if (isConsoleRead)
            {
                sutil.PrintInColor("Enter the first  whole integer number: ");
                iA = int.Parse(Console.ReadLine());              //  Convert aString to an integer
                sutil.PrintInColor("Enter the second whole integer number: ");
                iB = int.Parse(Console.ReadLine());              //  Convert bString to an integer
                sutil.PrintInColor("Enter 'add','subtact','multiply','divide', or 'all'");
                operation = Console.ReadLine();                  //  Read a line from the console
            }
            if (operation.ToLower() == "+" || operation.ToLower() == "a") operation = "add"; if (operation.ToLower() == "-" || operation.ToLower() == "s") operation = "subtract"; if (operation.ToLower() == "*" || operation.ToLower() == "m") operation = "multiply"; if (operation.ToLower() == "/" || operation.ToLower() == "d") operation = "division"; if (operation.ToLower() == "." || operation.ToLower() == "l") operation = "all";
            if (operation.ToLower() == "add" || operation.ToLower() == "all")       //  Write an 'if' to check whether operation is "add" or "multiply"
                sutil.PrintInColor($"{iA.ToString()} + {iB.ToString()} = {(iA + iB).ToString()}.   ");
            if (operation.ToLower() == "subtract" || operation.ToLower() == "all")
                sutil.PrintInColor($"{iA.ToString()} - {iB.ToString()} = {(iA - iB).ToString()}.   ");
            if (operation.ToLower() == "multiply" || operation.ToLower() == "all")
                sutil.PrintInColor($"{iA.ToString()} * {iB.ToString()} = {(iA * iB).ToString()}.   ");
            if (operation.ToLower() == "divide" || operation.ToLower() == "all")
            { if (iB == 0) sutil.PrintInColor($"Can't divide by zero!\n");
                else sutil.PrintInColor($"{iA.ToString()} / {iB.ToString()} = {(iA / iB).ToString()}.        ");
            }
        }
        public static void Quizs(Util sutil, bool isConsoleRead = false)
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append(Quiz1(sutil, isConsoleRead)); //  sb.Append(Quiz1(sutil, true));
            sb.Append(Quiz2(sutil, isConsoleRead)); //  sb.Append(Quiz2(sutil, true)); 
            sb.Append(Quiz3(sutil, isConsoleRead)); //  sb.Append(Quiz3(sutil, true));
            sb.Append(Quiz4(sutil, isConsoleRead)); //  sb.Append(Quiz4(sutil, true));
            sb.Append(Quiz5(sutil, isConsoleRead)); //  sb.Append(Quiz5(sutil, true));
            sb.Append(Quiz6(sutil, isConsoleRead)); //  sb.Append(Quiz6(sutil, true));
            if (!isConsoleRead) sutil.PrintInColor(sb.ToString());
        }
        private static string Quiz1(Util sutil, bool isConsoleRead = false)
        {
            List<string> answer1 = new List<string>();
            answer1.Add("0 - A program that executes my code.\n");
            answer1.Add("1 - A framework that is running in Windows.\n");
            answer1.Add("2 - A program that transforms code written in one programming language into another.\n");
            answer1.Add("3 - A service that tries to recover your program if you made a mistake.\n");
            int answer = 2, tryanswer = -1; string question /* Quiz 1 */ = "1. What is a compiler?"; if (isConsoleRead) sutil.PrintInColor(question + "\n");
            if (isConsoleRead)
            {
                foreach (string item in answer1)
                { sutil.PrintInColor(item); }
                while (tryanswer != answer)
                {
                    sutil.PrintInColor("Answer? "); tryanswer = int.Parse(Console.ReadLine());
                }
                sutil.PrintInColor($"That is Correct: {answer1[answer]}"); return "";
            }
            else
                return ("\nQ U I Z\n" + question + " " + answer1[answer]);
            //  if (index == 0) answer = "- A program that executes my code.";
            //  if (index == 1) answer = "- A framework that is running in Windows.";
            //  if (index == 2) answer = "- A program that transforms code written in one programming language into another.";
            //  if (index == 3) answer = "- A service that tries to recover your program if you made a mistake.";
        }
        private static string Quiz2(Util sutil, bool isConsoleRead = false)
        {
            /*  Quiz Task 2  */
            List<string> answer2 = new List<string>();
            answer2.Add("0 - Code written in C#.\n");
            answer2.Add("1 - Code written in a way that processor can understand and execute it.\n");
            answer2.Add("2 - Code that Common Language Runtime can understand and execute.\n");
            answer2.Add("3 - It's not a code, it's another name of .NET Framework.\n");

            int answer = 1, tryanswer = -1; string question = "2. What is machine code?"; if (isConsoleRead) sutil.PrintInColor(question + "\n");
            if (isConsoleRead)
            {
                foreach (string item in answer2)
                { sutil.PrintInColor(item); }
                while (tryanswer != answer)
                { sutil.PrintInColor("Answer? "); tryanswer = int.Parse(Console.ReadLine()); }
                sutil.PrintInColor($"That is Correct: {answer2[answer]}"); return "";
            }
            else
                return (question + " " + answer2[answer]);
            //  if (index == 0) answer = "- Code written in C#.";
            //  if (index == 1) answer = "- Code written in a way that processor can understand and execute it.";
            //  if (index == 2) answer = "- Code that Common Language Runtime can understand and execute.";
            //  if (index == 3) answer = "- It's not a code, it's another name of .NET Framework.";
        }
        private static string Quiz3(Util sutil, bool isConsoleRead = false)
        {
            /*  Quiz Task 3  */
            List<string> answer3 = new List<string>();
            answer3.Add("0 - ProgramName.exe or ProgramName.il\n");
            answer3.Add("1 - ProgramName.dll. or ProgramName.il\n");
            answer3.Add("2 - ProgramName.il or ProgramName.bat\n");
            answer3.Add("3 - ProgramName.exe or ProgramName.dll\n");

            int answer = 3, tryanswer = -1; string question = "3. Which files does C# compiler generate?"; if (isConsoleRead) sutil.PrintInColor(question + "\n");
            if (isConsoleRead)
            {
                foreach (string item in answer3)
                { sutil.PrintInColor(item); }
                while (tryanswer != answer)
                { sutil.PrintInColor("Answer? "); tryanswer = int.Parse(Console.ReadLine()); }
                sutil.PrintInColor($"That is Correct: {answer3[answer]}"); return "";
            }
            else
                return (question + " " + answer3[answer]);
        }
        private static string Quiz4(Util sutil, bool isConsoleRead = false)
        {
            /*  Quiz Task 4  */
            List<string> answer4 = new List<string>();
            answer4.Add("0 - International Code, common choice if you want to write international programs.\n");
            answer4.Add("1 - Intermediate Code, generated by Just In Time compiler and prepared for the execution by processor.\n");
            answer4.Add("2 - Intermediate Code, generated by C# compiler and packaged in ProgramName.exe or ProgramName.dll\n");
            answer4.Add("3 - Intermediate Code, which is generated by CLR.\n");
            int answer = 2, tryanswer = -1; string question = "4. What is IL code?"; if (isConsoleRead) sutil.PrintInColor(question + "\n");
            if (isConsoleRead)
            {
                foreach (string item in answer4)
                { sutil.PrintInColor(item); }
                while (tryanswer != answer)
                { sutil.PrintInColor("Answer? "); tryanswer = int.Parse(Console.ReadLine()); }
                sutil.PrintInColor($"That is Correct: {answer4[answer]}"); return "";
            }
            else
                return (question + " " + answer4[answer]);
            //  if (index == 0) answer = "- International Code, common choice if you want to write international programs.";
            //  if (index == 1) answer = "- Intermediate Code, generated by Just In Time compiler and prepared for the execution by processor.";
            //  if (index == 2) answer = "- Intermediate Code, generated by C# compiler and packaged in ProgramName.exe or ProgramName.dll";
            //  if (index == 3) answer = "- Intermediate Code, which is generated by CLR.";
        }
        private static string Quiz5(Util sutil, bool isConsoleRead = false)
        {
            /*  Quiz Task 5  */
            List<string> answer5 = new List<string>();
            answer5.Add("0 - Framework that contains CLR, big class library and other software that makes possible to execute C# programs.\n");
            answer5.Add("1 - Framework that was developed to support C# programs on Linux and Mac OS.\n");
            answer5.Add("2 - Framework that contains CLR, big class library and other software that makes possible to execute C#, F# and Visual Basic .NET programs.\n");
            answer5.Add("3 - A component of CLR, includes JIT compiler.\n");

            int answer = 2, tryanswer = -1; string question = "5. What is .NET Framework?"; if (isConsoleRead) sutil.PrintInColor(question + "\n");
            if (isConsoleRead)
            {
                foreach (string item in answer5)
                { sutil.PrintInColor(item); }
                while (tryanswer != answer)
                { sutil.PrintInColor("Answer? "); tryanswer = int.Parse(Console.ReadLine()); }
                sutil.PrintInColor($"That is Correct: {answer5[answer]}"); return "";
            }
            else
                return (question + " " + answer5[answer]);
        }
        private static string Quiz6(Util sutil, bool isConsoleRead = false)
        {
            /*  Quiz Task 6  */
            List<string> answer6 = new List<string>();
            answer6.Add("0 - You get compile time error telling you what went wrong.\n");
            answer6.Add("1 - You get runtime error telling you what went wrong.\n");
            answer6.Add("2 - You get CLR error tlling you what went wrong.\n");
            answer6.Add("3 - You get operating system error telling you what went wrong.\n");

            int answer = 0, tryanswer = -1; string question = "6. What happens if you miss a semicolon in your code?"; if (isConsoleRead) sutil.PrintInColor(question + "\n");
            if (isConsoleRead)
            {
                foreach (string item in answer6)
                { sutil.PrintInColor(item); }
                while (tryanswer != answer)
                { sutil.PrintInColor("Answer? "); tryanswer = int.Parse(Console.ReadLine()); }
                sutil.PrintInColor($"That is Correct: {answer6[answer]}"); return "";
            }
            else
                return (question + " " + answer6[answer] + "\n");
            //  if (index == 0) answer = "- You get compile time error telling you what went wrong.";
            //  if (index == 1) answer = "- You get runtime error telling you what went wrong.";
            //  if (index == 2) answer = "- You get CLR error tlling you what went wrong.";
            //  if (index == 3) answer = "- You get operating system error telling you what went wrong.";
        }
        public static void ForLoops(Util sutil, int iLoopControl = 10, bool isConsoleRead = false)
        {
            int consoleWindowWidth = Console.WindowWidth;
            string wOut; sutil.PrintInColor("FOR Loop\n");
            ForLoopMadeMyDay(sutil);
            Print0to99(sutil);
            ForLoopIKnowWhereYouLive(sutil);
            SumEvenNumbers(sutil);
            SumOfSquaresFor(sutil);
            MinMaxChecker(sutil, 4, new int[] { 11, 22, 33, 15 });
            MinMaxChecker(sutil, 4, new int[] { 66, 11, 30, 15 });
            MinMaxChecker(sutil, 4, new int[] { 21, 22, 11, 12 });
            OddChecker(sutil);
        }
        private static void Print0to99(Util sutil, int numberOfNumbers = 99)
        {
            // Write a program that outputs all numbers from 0(including) to 99(including) to the screen each from the new line.
            for (int iloop = 0; iloop < numberOfNumbers; iloop++)
            {
                sutil.PrintInColor($"{iloop.ToString()},");
                if (numberOfNumbers > 6 && iloop == (numberOfNumbers / 2) + 1) sutil.PrintInColor("\n");
            }
            sutil.PrintInColor($"{numberOfNumbers};\n");
        }
        private static void ForLoopMadeMyDay(Util sutil, int iLoopControl = 10)
        {
            //  Write a program that outputs to the screen "for loop made my day!" 10 times using the for loop.
            for (int iLoop = 0; iLoop < iLoopControl; iLoop++)
            {
                sutil.PrintInColor($"for loop made my day!   ");
                if (iLoopControl > 6 && iLoop == (iLoopControl / 2) - 1) Console.WriteLine();
            }
            sutil.PrintInColor("\n");
        }
        private static void ForLoopIKnowWhereYouLive(Util sutil, int iLoopControl = 10, bool isConsoleRead = false)
        {
            //  Write a program that reads from the console an integer number count, 
            //  and outputs to the screen "I know where you live." count times each from the new line.
            if (isConsoleRead)
            {
                sutil.PrintInColor($"Please enter a whole positive integer greater than zero!");
                iLoopControl = int.Parse(Console.ReadLine());
            }
            for (int iloop = 0; iloop < iLoopControl; iloop++)
            {
                sutil.PrintInColor("I know where you live.  ");
                if (iLoopControl > 6 && iloop == (iLoopControl / 2) - 1) sutil.PrintInColor("\n");
            }
            sutil.PrintInColor("\n");
        }
        public static void SumEvenNumbers(Util sutil)
        {
            //  Write a program that outputs the sum of all even numbers 
            //  between 150(including) and 250(not including).
            int sum = 0;
            for (int i = 150; i < 249; i++)
            {
                if (i % 2 == 0)
                    sum = sum + i;
            }
            sutil.PrintInColor($"Sum of Even Numbers between 150(including) and 250(not including) = {sum}        ");
        }
        public static void MinMaxChecker(Util sutil, int count, int[] number, bool isConsoleRead = false)
        {           //  new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } }
            #region Minimum Checker specs
            //  Write a program that reads integer count 
            //  and then reads count integer numbers from the console and outputs their minimum. 
            //  Example:
            /*  > 3
                > 14
                > 57
                > -10
                - 10    
                            //    if (number[iLoop] > iMax)
            //            iMax = number[iLoop];
            //  }
/*            for (int iLoop = 0; iLoop < count; iLoop++)
            {             
                if (iLoop == 0)
                    iMin = number[iLoop];
                else
                    if (iMin < number[iLoop])
                    for (int i = 0; i < iLoop; i++)
                    {
                        //  555, -100, 444, 111, 333
                        //  if N[0](555) < N[1](-100)
                        //      Not True, but S[0] = N[0]; S[1] = N[1];
                        //      S[0](-100) = N[1}; S[1](555) = N[0];
                        //      if N[2](444) < S[0](-100)
                        //          not true, but if it was: temp = s[0]; s[0] = n[2];
                        //                      what do we do wth temp???
                        if (sorted[i] < number[iLoop] )
                        {
                            temp = sorted[i];
                            sorted[i] = number[iLoop];
                            //if()
                        } */
            #endregion
            int iMin = int.MinValue, iMax = int.MaxValue; bool isParse = false;
            if (isConsoleRead)
            {
                sutil.PrintInColor("Enter an Integer 'Count' of Integer Numbers and find the MINIMUM And MAXIMUM: ");
                isParse = int.TryParse(Console.ReadLine(), out count);
                if (!isParse) { count = 2; }
            }
            else
            {
                sutil.PrintInColor("We will find the MINIMUM And MAXIMUM of ");
            }
            //  int[] number = new int[4] {11, 22, 33, 15};
            for (int iLoop = 0; iLoop < count; iLoop++)
            {
                if (isConsoleRead)
                {
                    isParse = int.TryParse(Console.ReadLine(), out number[iLoop]);
                    if (!isParse) { number[iLoop] = 42; }
                }
                else
                {
                    sutil.PrintInColor($"{number[iLoop].ToString()}");
                    if (count - 1 == iLoop)
                        sutil.PrintInColor($". ");
                    else
                        sutil.PrintInColor($", ");
                }
                if (number[iLoop] < iMin || iLoop == 0)
                    iMin = number[iLoop];
                if (number[iLoop] > iMax || iLoop == 0)
                    iMax = number[iLoop];
            }
            sutil.PrintInColor($"{iMin} is the Minimum, and {iMax} is the Maximum.\n");
        }
        public static void OddChecker(Util sutil, bool isConsoleRead = false)
        {
            //  Write a program that outputs all odd numbers between 100 and 200.
            if (isConsoleRead) { }
            else sutil.PrintInColor($"100-200(ODD): ");
            for (int i = 100; i < 200; i++)
            {
                if (i % 2 > 0)
                {
                    sutil.PrintInColor($"{i.ToString()}");
                    if (i == 199) 
                    { sutil.PrintInColor($".\n"); }
                    else if (i == 149)
                    { sutil.PrintInColor(",\n"); }
                    else
                    { sutil.PrintInColor(", "); }
                }
            }
        }
        public static void SumOfSquaresFor(Util sutil, bool isConsoleRead = false)
        {
            #region Sum Of Squares For Loop specs
            //  Write a program that reads from the screen two integer numbers min and max 
            //  and outputs the sum of all squares of integers between min(including) 
            //  and max(not including). If min is bigger than max, the program should 
            //  output "min should be smaller than max!". 
            //  Example 1:
            //  > 4
            //  > 9
            //  190
            //  (190 = 4² +5² +6² +7² +8²)
            //  Example 2:
            //  > 14
            //  > 3
            //  min should be smaller than max!
            #endregion
            int sumOfSquares = 0, num1 = 2, num2 = 15;
            if (isConsoleRead)
            {
                bool iParsed = int.TryParse(Console.ReadLine(), out num1);
                if (!iParsed) { num1 = 1; }
                iParsed = int.TryParse(Console.ReadLine(), out num1);
                if (!iParsed) { num2 = 2; }
            }
            StringBuilder sb = new StringBuilder("");
            if (num2 < num1)
                sutil.PrintInColor($"Min should be smaller than Max!");
            else
            {
                for (int i = num1; i < num2; i++)
                {
                    sumOfSquares = sumOfSquares + (i * i);
                    if (i == num1)
                        sb.Append(" ");
                    else
                        sb.Append(" + ");
                    sb.Append(i.ToString() + "*" + i.ToString());
                }
                sutil.PrintInColor($"sumOfSquares: ({sumOfSquares} = {sb.ToString()}).\n"); 
            }
        }
        private static void ForDiskSpace(Util sutil, int iNumberOfFiles, int[] iFileSizeArr, bool isConsoleRead = false)
        {
            #region for loop to find disk space
            //  Write a program that reads from the console the number of files in the directory. 
            //  After that program asks the user to input size of each of these files 
            //  with a phrase "Input size of {number} file:", sums those values and outputs in a format: 
            //  Total disk space is ... bytes. Example:            
            //  >3
            //  Input size of 1 file:
            //  >2
            //  Input size of 2 file:
            //  >7
            //  Input size of 3 file:
            //  >12
            //  Total disk space is 21 bytes.
            //  Console.WriteLine("Enter Number of files");
            #endregion
            int totalDiskSpace = 0;
            if (isConsoleRead)
            {
                sutil.PrintInColor("Enter Number of files to total");
                iNumberOfFiles = int.Parse(Console.ReadLine());
            }
            for (int iLoop = 1; iLoop < iNumberOfFiles + 1; iLoop++)
            {
                int iFileSize = 0;
                if (isConsoleRead)
                {
                    sutil.PrintInColor($"Input size of {iLoop} file:");
                    iFileSize = int.Parse(Console.ReadLine());
                }
                else
                {
                    iFileSize = iFileSizeArr[iLoop - 1];
                    sutil.PrintInColor($"Input size of file {iLoop} is: {iFileSize}, ");
            }
                totalDiskSpace = totalDiskSpace + iFileSize;
            }
            sutil.PrintInColor($"Total disk space is {totalDiskSpace} bytes.\n");
        }
        private static void ConsoleReadLineOMidl(Util sutil, int num1, int num2, int num3, bool isConsoleRead = false)
        {
            int a = 0, b = 0, c = 0;
            if (isConsoleRead)
            {
                Console.WriteLine("    Num1 Hit Enter;"); 
                a = Convert.ToInt32(Console.ReadLine());      //  to an integer
                Console.WriteLine("    Num2 Hit Enter;");
                b = Convert.ToInt32(Console.ReadLine());      //  to an integer
                Console.WriteLine("    Num3 Hit Enter;");
                c = Convert.ToInt32(Console.ReadLine());      //  to an integer

            }
            else
            {  a = num1; b = num2; c = num3; }
            sutil.PrintInColor($"The Middle of {a.ToString()}, {b.ToString()}, {c.ToString()} = ");

            if (a > b)
            {
                if (b > c)
                    sutil.PrintInColor(b.ToString());
                #region skip if b is middle
                //skip this if: we know b is the middle
                //  if (a > c)      // a>b>c           // a=3;b=2;c=1
                //  {
                //
                //  }
                //  else impossible
                #endregion
                else
                    if (a > c)   // a>b<c a>c           // a=3;b=1;c=2
                    sutil.PrintInColor(c.ToString());
                else         // a>b<c a<c           // a=2;b=1;c=3
                    sutil.PrintInColor(a.ToString());
            }
            else
            {
                if (b > c)
                {
                    if (a > c)   // a<b>c a>c           // a=2;b=3;c=1 
                        sutil.PrintInColor(a.ToString());
                    else         // a<b>c a<c           // a=1;b=3;c=2
                        sutil.PrintInColor(c.ToString());
                }
                else             // a<b<c a>c           // a=1;b=2;c=3
                    sutil.PrintInColor(b.ToString());               // skip if (a > c) and  else
            }
            sutil.PrintInColor(".        ");
        }
        private static void ConsoleReadLineZGame(Util sutil, bool isConsoleRead = false)
        {
            string inputAsString = "652";
            if (isConsoleRead)
            {
                sutil.PrintInColor($"Zanabar Game: Input Your number, please");
                inputAsString = Console.ReadLine(); // Read a line from the screen
            }
            else
                sutil.PrintInColor($"Zanabar Game: Your Input is: {inputAsString}");
            //  int myNumber = Convert.ToInt32(inputAsString); // Convert inputAsString to int
            //  sutil.PrintInColor($", and my number is: {++myNumber}, so I win, SUCKS TO BE YOU!\n");    // Do some magic with myNumber
            sutil.PrintInColor($", and my number is: {((int.TryParse(inputAsString, out int myNumber)) ? ++myNumber : 633) }, so I win, SUCKS TO BE YOU!\n");    // Do some magic with myNumber
        }
        private static void ConsoleReadLineFlyIt(Util sutil, bool isConsoleRead = false)
        {
            int numberOfBoxes = 4, weight = 6;    // string NumberOfBoxesString = "6";            string weightString = "4";
            if (isConsoleRead)
            {
                sutil.PrintInColor($"Please enter the Whole Number(Integer) of boxes: ");
                numberOfBoxes = int.Parse(Console.ReadLine());
                sutil.PrintInColor($"and now please enter the weight (Whole Number Integer) of each box: ");
                weight = int.Parse(Console.ReadLine());
            }
            else
            {
                sutil.PrintInColor($"You entered {numberOfBoxes} Box(es):, ");
                sutil.PrintInColor($"and the weight of each Box is: {weight}, so ");
            }
            if (numberOfBoxes * weight > 30)
                sutil.PrintInColor("NO, Your boxes weigh too much");
            else
                sutil.PrintInColor("YES, our droids can fly your box(es).        ");
        }
        private static void ConsoleReadLineCallU(Util sutil, bool isConsoleRead = false)
        {
            string firstName = "Brice", secondName = "Smith";
            if (isConsoleRead)
            {
                sutil.PrintInColor("Enter Your First Name:");
                firstName = Console.ReadLine();     //  Read a line from the screen
                sutil.PrintInColor("Enter Your Last Name:");
                secondName = Console.ReadLine();      //  Read a line from the screen
            }
            else
                sutil.PrintInColor($"You entered {firstName}, & {secondName}. ");
            sutil.PrintInColor($"Should I call you {firstName} or {secondName}?\n");
        }
        private static void ConsoleReadLineTempQ(Util sutil, bool isConsoleRead = false)
        {
            int temp = -10;
            if (isConsoleRead)
            {
                sutil.PrintInColor("What Temperature is it? (enter an integer of degrees Celcius");
                temp = ((int.TryParse(Console.ReadLine(), out temp) ? temp : -33));
            }
            else
                sutil.PrintInColor($"You entered a Temperature of {temp.ToString()}, ");
            sutil.PrintInColor("so you should wear a ");
            if (temp < 5)    //  Console.ReadLine()) < 5)
                sutil.PrintInColor("coat");
            else
                sutil.PrintInColor("jacket");
            sutil.PrintInColor("          ");
        }
        private static void ConsoleReadLineMaxO2(Util sutil, bool isConsoleRead = false)
        {
            int aInt = 60, bInt = 40;    sutil.PrintInColor("The Max of 2: ");
            if (isConsoleRead)
            {
                sutil.PrintInColor("Enter Num1, then Hit Enter;");
                aInt = (int.TryParse(Console.ReadLine(), out aInt) ? aInt : 60);    // Read a line and convert it to int (short version)
                sutil.PrintInColor("Enter Num2, then Hit Enter;");
                bInt = (int.TryParse(Console.ReadLine(), out bInt) ? bInt : 40);    // Read a line and convert it to int (short version)
            }
            else 
                sutil.PrintInColor($"You entered {aInt.ToString()}, then {bInt.ToString()}, so "); 
            if (aInt > bInt)
                sutil.PrintInColor($"Max = {aInt.ToString()}, Min = {bInt.ToString()}        ");
            else
                sutil.PrintInColor($"Max = {bInt.ToString()}, Min = {aInt.ToString()}        ");
        }
        private static void ConsoleReadLineGreet(Util sutil, bool isConsoleRead = false)
        {
            string name = "Brice Ulwelling";
            if (isConsoleRead)
            {
                sutil.PrintInColor("Input your name:");
                name = Console.ReadLine();
            }
            sutil.PrintInColor($"Greetings, {name}!\n");
        }
        private static void ConsoleReadLineHowRU(Util sutil, bool isConsoleRead = false)
        {
            string testit = "fine";
            if (isConsoleRead)
            {
                sutil.PrintInColor("How are you?");
                testit = Console.ReadLine();
            }
            else
                sutil.PrintInColor("How are you? You said 'fine', so I said: ");
            if (testit == "fine")
                sutil.PrintInColor("Life is great!      ");
            else
                sutil.PrintInColor("Everything's gonna be alright");
        }
        private static void ConsoleReadLineAcces(Util sutil, bool isConsoleRead = false)
        {
            sutil.PrintInColor("\nConsole.ReadLine()\n");string firstName = "ritchie";
            if (isConsoleRead)
            {   sutil.PrintInColor("Enter your first name:  ");        firstName = Console.ReadLine().ToLower();            }
            else
                sutil.PrintInColor("You Entered your name: Ritchie: ");
            if (firstName == "ritchie")
                sutil.PrintInColor("Access granted!        ");
            else
                sutil.PrintInColor("Security Alert! You are under arrest for treason...");
        }
    }   //  ConsoleReadLineA

    //  "This is a keyword in C# that represents the current object of a class. 
    //  That object is where the code is running." Maybe I was in a bit over my head. 
    //  "Where is it used? Why is it useful? Why does this code refer to private variables 
    //  with this when they could just omit it?" I shot back in rapid-fire.
    //  "This depends on a naming convention. If the programmer chooses not to use 
    //  underscores for private fields, their names may collide with local variables 
    //  and function or constructor arguments. To distinguish fields from others, 
    //  you can use the this keyword to point out that you want to work 
    //  with a field now." Add or remove the this modifier 
    //  to make this program to output "Hello from Cutie".   */
    class CSBeginChapter1WhileLoops
    {
        /* codeasy.net    C# Beginner>1 Repairing Noname>Introduction to while loop antivirus
        //  Antivirus Scan
        //  The day finally came when Noname called me back down to the basement to help him 
        //  with one of his modules. Finally! One step closer to returning to my own time.
        //  As soon as I keyed in the secret code, I heard his robotic voice. 
        //  "Hi! Haven't seen you for a while!" Noname said. "Hi, Noname," I returned. 
        //  "Nice to see you too! Let's get started ASAP - I want to get back into my time!
        //  "Let's start with my antivirus protection system." Noname suggested. "What should I do?"
        //  "My problem is not with the antivirus detection itself, but in running the scan. 
        //  As you know, Ritchie did everything to control me. Part of that was adding a remote access 
        //  to my system that he can connect to and check what I'm doing. An antivirus check is 
        //  forbidden for me - if he sees that I'm checking for viruses, he'll immediately turn me off. 
        //  I need help with scanning my files quickly and then being able to stop scanning as soon as 
        //  Ritchie connects."  I took a few seconds to think through the problem. 
        //  "If I know the number of files to scan," I thought out loud, "I can write a for loop to 
        //  iterate through all of the files to scan them." I suggested.  "And when Ritchie connects, 
        //  how will the scan stop if Ritchie connects to the system?" "I haven't thought that far 
        //  ahead yet," I admitted. "Do you have anything in mind?" "Well, if you're open to learning, 
        //  I could teach you how to use a while loop." Noname replied.  "Sounds good," I said. 
        //  "Enlighten me!"  Feed me with knowledge     While Loop   "Ok, my dear human, listen up. 
        //  Some programmers call the for loop a "loop with a known number of repetitions". 
        //  That's because when you see a for loop, it's typically pre-programmed to run a specified 
        //  number of times; 5, 10, etc. In contrast, a while loop is a "loop with an unknown number 
        //  of repetitions" because you don't really know how many times it will iterate. 
        //  Here is a while loop syntax in C#:    while ( // condition )    { // while loop body }
        //  A while loop executes a code in its body while a a specified condition is true. 
        //  As soon as that condition is false, the loop terminates.The condition has a bool type. 
        //  This diagram illustrates the basics of a while loop:    C# while loop    Take a look at some examples:
        //            while (true) // Executes forever    
        //                  { Console.WriteLine("Never Stop!"  );}    
        //            while (false) // Never executes
        //                  { Console.WriteLine("Never execute");}
        //            bool iNeedMoreCandies = true;
        //            int candiesCount = 0;
        //            while (iNeedMoreCandies)
        //            {
        //                Console.WriteLine("One more candy?");
        //                string answer = Console.ReadLine();
        //                if (answer == "Yes")
        //                {
        //                    candiesCount++;
        //                }
        //                else
        //                {
        //                    iNeedMoreCandies = false;
        //                }
        //            }
        //  "See those examples I just showed you?" Noname asked. "The first two examples are trivial. 
        //  But the last one is interesting. Do you understand what is it doing?" "Let's see. It looks 
        //  like it asks the user if they want one more candy. As long as the user enters 'Yes,' 
        //  it increments the candy count. As soon as the user answers anything but 'Yes,' 
        //  it stops the loop." "Correct! You're a quick learner, Teo. Now let's get you Writing your 
        //  first while loop."   First c sharp while loop
        //  Write a salary negotiation program that tells the user "I will give you {number} dollars, ok?" 
        //  starting from 100. Every time the user answers "more", it increases the number by 100. 
        //  If the user answers "ok", program outputs "Your salary is {number} dollars." and exits. 
        //  For example:
        //  I will give you 100 dollars, ok?
        //  >more
        //  I will give you 200 dollars, ok?
        //  >more
        //  I will give you 300 dollars, ok?
        //  >ok
        //  Your salary is 300 dollars. Code!
        
        //  Write a program that reads an integer from the console. The integer should be a power of two: 
        //  2, 4, 8, 16, 32, etc.Then your program should divide it by 2 and output every division result 
        //  to the console, until it reaches number 1. Print out each result to a new line.Use a while loop.
        //  For example:
        //  >16
        //  8
        //  4
        //  2
        //  1            Code!
        //  "Do you want to know a secret, Teo?" Noname asked. "Sure!" I answered.  "You can omit the enclosing 
        //  brackets if you have a single command in a for or while loop; just the same as you can in an 
        //  if statement. Here is a demonstration:
        //  for(int i = 0; i< 10; i++)
        //      Console.WriteLine("Print me!");
        //  while(someBool)
        //      Console.WriteLine("Print me!");
        //  You can also replace a for loop with a while loop, and vice-versa. In the below example, the 
        //  code snippets in the left and right colums of the following table are equivalent:
        //  For loop    While loop
        //  for(int i = 0; i< 10; i++)
        //  {    Console.WriteLine("Print me!");    }
        //  int repetitions = 10;
        //  while(repetitions > 0)
        //  {    Console.WriteLine("Print me!");    repetitions--;    }
        //  int candiesCount = 0;
        //  for (string input = "Yes";  input == "Yes";  input = Console.ReadLine())
        //  {    Console.WriteLine("One more candy?");   candiesCount++;    }
        //  bool iNeedMoreCandies = true;
        //  int candiesCount = 0;
        //  while (iNeedMoreCandies)
        //  {    Console.WriteLine("One more candy?");    string answer = Console.ReadLine();
        //       if (answer == "Yes")    {        candiesCount++;    }
        //       else    {        iNeedMoreCandies = false;    }
        //  }
        //  "Now that you have some practice with these loops, let's talk about strategy. 
        //  Try to stick to this rule: if you know during compile time how many times your 
        //  code will be executed, consider using a for loop; otherWise, use a while loop."
        //  "Noname, in that code you showed me, what does repetitions-- do?"
        //  The -- operater decrements the named variable by one. 
        //  This is the same as repetitions = repetitions - 1    There are actually 4 different operators: 
        //  i++, ++i, i--, and --i. When the symbols are placed before the variable, it's called a 
        //  prefix operator. When applied after the variable, it's called called a postfix operator. 
        //  The prefix operators change the value of the variable first and then return the result. 
        //  Postfix operators return the current variable value and then change it.
        //  Operator Name   Usage              Equivalent Code     Types
        //  Postfix         increment   i++    i = i + 1           byte, sbyte, char, int, 
        //  Prefix          increment   ++i    i = i + 1           decimal, double, float, 
        //  Postfix         decrement   i--    i = i - 1           uint, long, ulong, 
        //  Prefix          decrement	--i    i = i - 1           short, ushort, 
        //  "Wow," I said, "it turns out that there are many more standard types in C# than I thought."
        //  "Yes and no." Noname replied. "Many of them are actually quite similar, but we'll leave 
        //  the details for next time."  "I'll confess Noname, I don't quite understand 
        //  the prefix/postfix difference. What's the difference between i++ and ++i in the code? 
        //  In the table you showed me, both prefix and postfix have the same 'equivalent code'."
        //  "Yes, it is confusing for the human brain. Here are some examples that might help 
        //  illustrate it."
        //  int i = 2;
        //  Console.WriteLine(i++); // Outputs 2
        //  Console.WriteLine(i);   // Outputs 3
        //  int i = 2;
        //  Console.WriteLine(++i); // Outputs 3
        //  Console.WriteLine(i);   // Outputs 3
        //  In the first example we are using a postfix increment.Hence, first the current 'i' value 
        //  is printed to the console. That value is 2. After the write, we increment 'i', which is 
        //  when it becomes 3. The next time we call Console.WriteLine, the value of 'i' is 3.
        //  The second example uses a prefix increment. 'i' is incremented first and then its new 
        //  value(3) is output to the console.  Note that the priority of the mathematical operations 
        //  like +, -, *, and / are lower than increment and decrement. That means that the 
        //  increment/decrement part will be calculated before any operation in between those 
        //  increments/decrements.
        //  int number = 1;
        //  int result = ++number + ++number;
        //  Console.WriteLine(number);  // Outputs 3
        //  Console.WriteLine(result);  // Outputs 5
        //  In other terms, the above code is equivivalent to:
        //  int number = 1;
        //  number = number + 1;
        //  int result = number;
        //  number = number + 1;
        //  result = result + number;
        //  Console.WriteLine(number);  // Outputs 3
        //  Console.WriteLine(result);  // Outputs 5
        //  "Still a little complicated, Noname." I said, a little exasperated.
        //  "Don't worry, Teo. You can use either of those in your code. 
        //  Unless you're doing something complicated, postfix vs. prefix doesn't usually matter, 
        //  but it is very good to know the difference!" Noname replied and continued, 
        //  "To make your loop knowledge complete, I want to tell you about nested loops.
        //  Nested loops   The term "nested" can be applied to the loop that is inside another loop.
        //  Take a look at this example:
        //  for(int i = 0; i< 3; i++) // This loop executes the inner loop 3 times
        //  {
        //     for(int j = 0; j< 3; j++) // This loop draws the row of 3 stars
        //     {
        //         Console.Write("*");
        //     }
        //     Console.WriteLine(); // Here we go to the new line after the row is completed
        //  }
        //  // Outputs:
        //  ***
        //  ***
        //  ***
        //  "The most important trick about them is that all variables created in 
        //  the inner loop get destroyed when the outer loop iterates."
        //  Same as with for loops, you can create nested while loops:"
        //  int i = 0;
        //  while(i< 3) // This loop executes the inner loop 3 times
        //  {
        //      int j = 0;
        //      while (j< 3) // This loop draws the row of 3 stars
        //      {
        //          Console.Write("*");
        //          j++;
        //      }
        //      Console.WriteLine(); // Here we go to the new line
        //      i++;
        //  }
        //  "What do you think about it?" Noname asked.  "This opens such a big field of opportunities!" 
        //  I answered. Noname replied, "Right, Teo, totally agree! One more useful feature is that you 
        //  can use the outer loop variable in the inner loop. This means that the inner loop can "know" 
        //  which iteration is currently in the outer loop. Here is a small demonstration:
        //  for (int i = 0; i< 3; i++) // This loop executes the inner loop 3 times
        //  {
        //      Inner loop draws the row of several stars (first 1 star, then 2 stars, etc.)  
        //      for (int j = 0; j <= i; j++) // Note, j is compared to i
        //      {
        //          Console.Write("*");
        //      }
        //      Console.WriteLine(); // Here we go to the new line
        //  }
        //  Outputs:
        //  *
        //  **
        //  ***
        //  "Noname, I think it's enough of theory for today," I said. "Are you tired? Don't worry, 
        //  the human brain absorbs information much slower than machine memory. 
        //  The understanding will come. Maybe after some tasks!" Write a program that reads an integer 
        //  count from the console. Then it should output a triangle composed of '#' symbols starting 
        //  from 1 in the first row and ending with count in the last row. Use the for loop. For example:
        //  >4
        //
        //  #
        //  ##
        //  ###
        //  ####                 Code!
        //  
        //  Write a program that reads an integer count from the console. Then it should output a triangle 
        //  composed of '#' symbols starting from 1 in the first row and ending with count in the last row.
        //  This time, use the while loop. For example:
        //  >4
        //  #
        //  ##
        //  ###
        //  ####                 Code!
        //  
        //  "I believe you are ready to fix my antivirus system!" Noname said once I had completed his tasks.
        //  Antivirus protection
        //  
        //  Extra complicated Extra complicated Extra complicated
        //  You need to write a program that sends files to the antivirus scan. 
        //  It should scan files only when Ritchie is NOT watching Noname's state. 
        //  The program should understand 4 commands: "scan", "hide", "unhide", and "game over". 
        //  It should have two modes that can be toggled by using the commands "hide" and "unhide" 
        //  commands. The default mode is "unhide", which means that Ritchie is not watching. 
        //  If the input is "scan" during the mode "unhide", the program should output "scanning file 
        //  {number}" where number is an integer that starts from 1 and increments by 1 for every new 
        //  file. If the user inputs "scan" during the "hide" mode, the program should output 
        //  "can't scan files for viruses". As soon as Ritchie leaves, the input will be switched to 
        //  "unhide" and then it should be able to scan again. Your program should listen to the input 
        //  commands indefinitely until the input is "game over". In this case, the program should 
        //  output "run" and exit. For example:
        //  >scan
        //          scanning file 1
        //  >scan
        //          scanning file 2
        //  >hide
        //  >scan
        //          can't scan files for viruses
        //  >scan
        //          can't scan files for viruses
        //  >unhide
        //  >scan
        //          scanning file 3
        //  >game over
        //          run
        //                       Code!
        //  C# Beginner>1 Repairing Noname>Introduction to while loop
        //  Email:info @codeasy.net
        //   */

        public CSBeginChapter1WhileLoops()
        {
            Util sutil = new Util(ConsoleColor.Yellow, ConsoleColor.Black); sutil.PrintInColor($"While Loops:\n");
            CSBeginChap1RunWhiles(sutil);
        }
        public static void AddToSalaryWhile(Util sutil, int iSalary = 100, int iIncrement = 100, bool isConsoleRead = false)
        {

            //  Write a salary negotiation program that tells the user "I will give you {number} dollars, ok?" 
            //  starting from 100. Every time the user answers "more", it increases the number by 100. 
            //  If the user answers "ok", program outputs "Your salary is {number} dollars." and exits. 
            //  For example:
            //  I will give you 100 dollars, ok?
            //  >more
            //  I will give you 200 dollars, ok?
            //  >more
            //  I will give you 300 dollars, ok?
            //  >ok
            //  Your salary is 300 dollars. Code!

            bool testit = true; int idx4 = 0; string answer = "more"; string[] sAnswer = { "Fuck ME!" };//string[] sAnswer = { "more", "More", "morE", "mOre", "moRe", "MORE", "MOre", "OK"};
            sutil.PrintInColor($"I will give you {iSalary.ToString()} dollars, ok?    ");
            while (testit)
            {
                if (isConsoleRead)
                { answer = Console.ReadLine(); }
                else
                { answer = sAnswer[idx4++]; }
                if (answer.ToLower() == "more")
                { sutil.PrintInColor($"I will give you {iSalary += iIncrement} dollars, ok?   "); }
                else
                { testit = false; sutil.PrintInColor($"Your salary is {iSalary.ToString()} dollars.\n"); }

            }
        }
        public static void DivideBy2(Util sutil, int answer = 36, bool isConsoleRead = false)
        {
            //  Write a program that reads an integer from the console. 
            //  The integer should be a power of two: 2, 4, 8, 16, 32, etc.
            //  Then your program should divide it by 2 and output every division result 
            //  to the console, until it reaches number 1. Print out each result to a new line.
            //  Use a while loop. For example:
            //  >16
            //  8
            //  4
            //  2
            //  1            Code!
            if (isConsoleRead) { bool isParsed = int.TryParse(Console.ReadLine(), out answer); if (!isParsed) answer = 16; }
            if (answer % 2 > 0) --answer;
            if (answer < 2) answer = 64;
            double power = Math.Log(answer) / Math.Log(2);
            if ((power - Convert.ToInt32(power)) > 0)/* not a power of 2 */answer = 512;
            sutil.PrintInColor($"Divide a power of 2({answer}) BY 2: ");
            while ((answer /= 2) > 1) sutil.PrintInColor($"{answer.ToString()}, ");
            sutil.PrintInColor("1.\n");
        }
        //  The understanding will come. Maybe after some tasks!" Write a program that reads an integer 
        //  count from the console. Then it should output a triangle composed of '#' symbols starting 
        //  from 1 in the first row and ending with count in the last row. Use the for loop. For example:
        //  >4
        //
        //  #
        //  ##
        //  ###
        //  ####                 Code!
        //  
        public static void PrintTriangle(Util sutil, int counter = 4, bool isConsoleRead = false)
        {
            if (isConsoleRead)
            {
                bool isParsed = int.TryParse(Console.ReadLine(), out counter);
                if (!isParsed) counter = 4;
            }
            int idx1 = 0; sutil.PrintInColor($"We will see a Triangle of {counter} rows\n");
            for (int i = 1; i < counter + 1; i++)
            {
                sutil.PrintInColor($"{i % 10}");
                for (int jdx = 0; jdx < i; jdx++)
                {
                    sutil.PrintInColor($"#");
                }
                sutil.PrintInColor("\n");
            }
            Console.WriteLine("01234567890123456");
            while (++idx1 < counter + 1)
            {
                sutil.PrintInColor($"{idx1 % 10}");
                int idx2 = 0;
                while (++idx2 <= idx1)
                    sutil.PrintInColor("#");
                sutil.PrintInColor("\n");
            }
            Console.WriteLine("01234567890123456");
            StringBuilder sb = new StringBuilder("");
            for (int i = 1; i < counter + 1;)
                Console.WriteLine($"{i++ % 10}{sb.Append("#").ToString()}");
            Console.WriteLine("01234567890123456"); sb.Clear(); int idx3 = 0;
            while (idx3++ < counter)
                sutil.PrintInColor($"{idx3 % 10}{sb.Append("#").ToString()}\n");
            Console.WriteLine("01234567890123456"); sb.Clear();
            for (int i = counter - 1; i >= 0; i--)
            { sutil.PrintInColor($"{sb.Append("#").ToString()}\n"); }
            Console.WriteLine("01234567890123456"); sb.Clear();
            /*  for (int i = 1; i < counter + 1; i++)
                {                sutil.PrintInColor($"{i % 10}");
                    for (int j = 0; j < i; j++)
                    {                    sb.Append($" ");                }
                    sb.Append("#");            }
                sutil.PrintInColor($"{sb.ToString()}\n"); sb.Clear(); */
            Util dutil = new Util(ConsoleColor.Green, ConsoleColor.Red); dutil.PrintInColor("Merry  Christmas\n");
            int j = 0;
            for (int i = counter; i >= 0; i--)
            {           //bbu654                //for (int j = 2; j < (counter * 2) + 2; j += 2)                /*{ */                                        //sb.Append($"{(i % 10).ToString()}");
                sb.Append(sutil.TextRepeater(" ", i));
                sb.Append(sutil.TextRepeater("/", ++j));
                sb.Append(sutil.TextRepeater("\\", j));
                sb.Append(sutil.TextRepeater(" ", i)); sb.Append("\n");                //}
            }
            dutil.PrintInColor($"{sb.ToString()}");
            dutil.PrintInColor(dutil.TextRepeater(" ", counter) + "[]" + dutil.TextRepeater(" ", counter));
            Console.WriteLine("\n01234567890123456"); sb.Clear();
            //dutil.PrintInColor($"[]");
            //dutil.PrintInColor(dutil.TextRepeater(" ", counter));
            //123456789012345**123456789012345 //15 space 2# 15 spaces =32
            //12345678901234****12345678901234 //14 space 4# 14
            //1234567890123******1234567890123 //13       6  13
            //123456789012********123456789012 //12       8  12     
            //12345678901**********12345678901 //11      10  11
            //1234567890************1234567890
        }
        //  Write a program that reads an integer count from the console. Then it should output a triangle 
        //  composed of '#' symbols starting from 1 in the first row and ending with count in the last row.
        //  This time, use the while loop. For example:
        //  >4
        //  #
        //  ##
        //  ###
        //  ####                 Code!
        //  

        public static int Scanning(Util sutil, int fileNum = 0, bool isConsoleRead = false)
        {
            #region "I believe you are ready to fix my antivirus system!" 
            //  Noname said once I had completed his tasks.
            //  Antivirus protection
            //  
            //  Extra complicated Extra complicated Extra complicated
            //  You need to write a program that sends files to the antivirus scan. 
            //  It should scan files only when Ritchie is NOT watching Noname's state. 
            //  The program should understand 4 commands: "scan", "hide", "unhide", and "game over". 
            //  It should have two modes that can be toggled by using the commands "hide" and "unhide" 
            //  commands. The default mode is "unhide", which means that Ritchie is not watching. 
            //  If the input is "scan" during the mode "unhide", the program should output "scanning file 
            //  {number}" where number is an integer that starts from 1 and increments by 1 for every new 
            //  file. If the user inputs "scan" during the "hide" mode, the program should output 
            //  "can't scan files for viruses". As soon as Ritchie leaves, the input will be switched to 
            //  "unhide" and then it should be able to scan again. Your program should listen to the input 
            //  commands indefinitely until the input is "game over". In this case, the program should 
            //  output "run" and exit. For example:
            //  >scan
            //          scanning file 1
            //  >scan
            //          scanning file 2
            //  >hide
            //  >scan
            //          can't scan files for viruses
            //  >scan
            //          can't scan files for viruses
            //  >unhide
            //  >scan
            //          scanning file 3
            //  >game over
            //          run
            //                       Code!
            //  C# Beginner>1 Repairing Noname>Introduction to while loop
            //  Email:info @codeasy.net
            //   
            #endregion
            // SETup
            bool testit = true, visible = true, fucked = true; string sInput = ""; int testNum = -1;
            string[] sIn = new string[] { "scan", "hide", "unhide", "game over" };
            string[] sRin = new string[] { "scan", "hide", "scan", "hide", "hide", "hide", "hide", "hide", "hide", "hide", "hide", "hide", "hide", "hide", "hide", "scan", "hide", "scan", "hide", "scan", "hide", "scan", "unhide", "scan", "scan", "game over" };

            sutil.PrintInColor($"Antivirus Scanner Valid: '{sIn[0]}', '{sIn[1]}', '{sIn[2]}', '{sIn[3]}'!\n");
            while (testit)
            {
                fucked = false;
                if (isConsoleRead) sInput = Console.ReadLine();
                else
                { sInput = sRin[++testNum]; sutil.PrintInColor($"{sRin[testNum]}: "); }
                foreach (string item in sIn)
                { if (sInput.ToLower() == item) { fucked = true; } }

                if (sInput.ToLower() == "hide") { visible = false; }
                if (sInput.ToLower() == "unhide") { visible = true; }
                if (sInput.ToLower() == "game over") { testit = false; }
                if (sInput.ToLower() == "scan" && visible) sutil.PrintInColor($"scanning file {++fileNum}\n");
                if (sInput.ToLower() == "scan" && !visible) sutil.PrintInColor($"can't scan files for viruses. ");
                if (!fucked) sutil.PrintInColor("Invalid Input Dufus! ");
            }   //  while 
            sutil.PrintInColor(" run.\n"); return fileNum;
        }   //Scanning


        public static void CSBeginChap1RunWhiles(Util sutil, bool isConsoleRead = false)
        {
            int fileNum = 0, pop = Scanning(sutil, Scanning(sutil, /*Scanning(sutil, Scanning(sutil, Scanning(sutil, */Scanning(sutil, fileNum)));//)));
            PrintTriangle(sutil, 3); AddToSalaryWhile(sutil); DivideBy2(sutil, 4096);
        }
    }
    #region C# Beginner>1 Repairing Noname>Introduction to methods  
    /* codeasy.net    C# Beginner>1 Repairing Noname>Introduction to methods
    //  Functional module
    //  I could tell that Noname was continuously getting better. 
    //  I started to notice small quirks occurring around me: doors opening as I walked 
    //  towards them, elevators whisking me to the correct floor before I even touched 
    //  the button, and so on - things I could only attribute to Noname. 
    //  Eventually, Noname called me back down to the basement for another repair session.
    //  "Hi Teo, how are you?"""Good, thanks! And you? I've noticed you're branching out 
    //  a bit into the base operations." "Better than ever," Noname replied. 
    //  "I'm repairing my modules rapidly. But now I need some help to finish 
    //  with the functional module. Do you know what a method is?" "Not really," I answered, 
    //  "but I've heard the term. I know that Console.WriteLine is a method, as well as 
    //  int.Parse. When I learned about the C# program structure, there was a mention 
    //  of methods that kind of "live" inside classes. "That's a good start! I'll give you 
    //  some more details about methods, and then you can help me to repair my functional module."
    //  Methods
    //  Imagine that you are in a store and you have two credit cards, both with $100 on them. 
    //  You went through and filled your shopping cart and now it's time to pay. You're not sure 
    //  if one of the cards will cover everything, or if you'll need both. Let's write a program 
    //  that outputs the steps representing your actions as you pay at the register.
    //  using System;
    //  namespace Methods
    //  {
    //      class ShopWalk
    //      {
    //          static void Main(string[] args)
    //          {
    //              Console.WriteLine("Ask for the sum that you need to pay");
    //              double sum = double.Parse(Console.ReadLine());
    //              Console.WriteLine("Take Card 1 out of wallet.");
    //              Console.WriteLine("Give the card to the cashier.");
    //              Console.WriteLine("Wait to enter pin.");
    //              Console.WriteLine("Enter pin.");
    //              if (sum > 100)
    //              {
    //                  Console.WriteLine("Take Card 2 out of wallet.");
    //                  Console.WriteLine("Give the card to the cashier.");
    //                  Console.WriteLine("Wait to enter pin.");
    //                  Console.WriteLine("Enter pin.");
    //              }
    //              Console.WriteLine("Go home.");
    //          }
    //      }
    //  }
    //  "What can you tell me about this code, Teo?" Noname asked.
    //  "Well," I began, "I think... I assume... I don't know. You just output strings. Nothing 
    //  special. Seems like a lot of repetition." "Good! There are a lot of repetitions in this code. 
    //  You're doing nearly the same thing multiple times. When early enterprising programmers found 
    //  out that some parts of code had to be copied in many places of the program, they decided to 
    //  group that code and make it easy to reuse. The original term for this grouped code was 
    //  a function. In C#, it's called a method. You'll probably hear both terms used interchangeably. 
    //  Here's a basic example of how to use a method." 
    //  using System;
    //  namespace Methods
    //  {
    //      class ShopWalk
    //      {
    //          static void Main(string[] args)
    //          {
    //              Console.WriteLine("Ask for the sum that you need to pay");
    //              double sum = double.Parse(Console.ReadLine());
    //  
    //              PurchaseByCard("card 1");
    //  
    //              if (sum > 100)
    //                  PurchaseByCard("card 2");
    //  
    //              Console.WriteLine("Go home.");
    //          }
    //  
    //          static void PurchaseByCard(string cardName)
    //          {
    //              Console.WriteLine($"Take {cardName} out of wallet.");
    //              Console.WriteLine("Give the card to the cashier.");
    //              Console.WriteLine("Wait to enter pin.");
    //              Console.WriteLine("Enter pin.");
    //          }
    //      }
    //  }
    //  This program does the same thing as the previous one. This time, we created the method 
    //  PurchaseByCard. Then we executed it twice. No code duplication! The method is a code 
    //  block that contains a series of statements. Executing the code inside a method is also 
    //  referred to as "calling the method." You can call a method as many times as you need to 
    //  in your code. To call a method, you write its name followed by a set of parentheses, 
    //  and list any necessary parameters inside of those parentheses. The following diagram 
    //  shows how the code is executed when you call a method: c# method call
    //  You can think of it this way: Every time you call a method, the code of the method is 
    //  essentially copied to where you call it. Parameters that you specify are copied in as 
    //  the parameters of the method, and you can work with those parameters just like you 
    //  would any other variables. The yellow and green arrows in the above diagram show the 
    //  code flow. After you call a method, all the code inside it is executed first and then 
    //  the execution returns to the Main method. The red and blue arrows show how the 
    //  parameters are copied into the method from the main program.
    //  "Cool!" I said. "But can you go over how to create a method 
    //  and how to run it in a bit more detail? I understand the concept, but not the specifics."
    //  "Sure, it would be my pleasure!" Noname replied. Even having been acquainted with Noname 
    //  as long as I had, it still surprised me how perpetually happy it seemed given that it was 
    //  a machine living in the basement under the control of an evil human.
    //  The following diagram shows all the main components of a method:
    //  C# method structure    Modifiers. static is actually quite complicated, so for now, just 
    //  know that you can only call static methods from within another static method. Earlier, we 
    //  called PurchaseByCard from Main, which itself is static, and therefore, PurchaseByCard 
    //  also had to be static. Return type. A method can return a value. The value can be any type: 
    //  bool, string, int, float, double, or any other type. If a method doesn't return any value, 
    //  the return type is void. void basically means "no type" or "empty type". Name. The name of 
    //  the method should be written in Upper-CamelCase. Start with a capital letter and continue 
    //  using camel case. Try to use representative, readable, and meaningful names for methods 
    //  (the same as you do for variables). Any - bad method name. ApplyDiscount - good name.
    //  Parameters. Parameters provide the possibility to pass data into the method from the 
    //  code where the method is called. In the above example, We passed the card name in to 
    //  print slightly different text depending on what card the shopper used. Body. The body is the 
    //  actual code that is executed by the method. The method body is executed every time you call 
    //  the method. C# programmer sign "Do you follow, Teo?" Noname asked. "Yes, I'm still with you. 
    //  Your method PurchaseByCard doesn't return anything because its return type is void?"
    //  "Yes, exactly. To call the method, you type its name and specify a value for each 
    //  parameter that the method is designed to pass in. Here's a brief example of calling 
    //  different methods that don't return anything (or rather, return a void type):"
    //  static void Main(string[] args)
    //  {
    //      PrintHello();
    //      int someInt = 23;
    //      PrintNumber(someInt);
    //      PrintSum(someInt, 54);
    //  }
    //  
    //  static void PrintHello()
    //  {
    //      Console.WriteLine("Hello");
    //  }
    //  
    //  static void PrintNumber(int number)
    //  {
    //      Console.WriteLine(number);
    //  }
    //  
    //  static void PrintSum(int number1, int number2)
    //  {
    //      int sum = number1 + number2;
    //      Console.WriteLine(sum);
    //  }
    //  Outputs:
    //  Hello
    //  23
    //  77
    //  "Noname," I asked, "in your example, you passed in the variable someInt as a parameter 
    //  to the method PrintNumber. In the definition of that method though, you use the name 
    //  number. Does the name you pass in not need to match the name defined in the method itself?"
    //  "Very perceptive, Teo. No, it doesn't matter. The name of the variable that you pass in 
    //  does not need to match the name used in the body of the method. This is perfectly fine 
    //  - the method understands what you want and does the conversion for you. Now it's time 
    //  for you to create your first method!" How programmers create bugs
    //  
    //  Create a method named "PrintMax" that takes two int parameters and prints the larger of 
    //  the two. Call this method from the Main method with parameters 75 and 114.    Code!
    //  
    //  Create a method named "PrintCubeVolume" that takes one double parameter which represents 
    //  the length of a cube's edge. The method should then print the volume of the cube. In the 
    //  Main method, read the cube edge size from the console and input that into the 
    //  PrintCubeVolume method once. For example:
    //  >2.5
    //  15.625    Code!  
    //  "Okay Noname, I think I'm getting the hang of it." I said. "But do all methods print 
    //  something?" "No, Teo." Noname responded. "You can return a value from a method back 
    //  to the code in which that method was called. To do this, use the keyword return from 
    //  within the method. The return value type must be the same as the method return type. 
    //  If you want to return an int value, you must use an int-type method." 
    //  static void Main(string[] args)
    //  {
    //      int sum1 = Add(5, 25);
    //      int sum2 = Add(17, 4);
    //      int globalSum = Add(sum1, sum2);
    //      Console.WriteLine($"5 + 25 + 17 + 4 = {globalSum}");
    //  }
    //  
    //  static int Add(int number1, int number2)
    //  {
    //      int sum = number1 + number2;
    //      return sum;
    //  }
    //  // Outputs: 5 + 25 + 17 + 4 = 51
    //  The following diagram illustrates the main points of returning a variable within a method:
    //  C# method return
    //  
    //  In the above example, the return type is int and the variable that holds the return value 
    //  also is an int type. The return type (1) and the type of the variable (2) where you store 
    //  return value must match. This was a bit too much. I thought I could feel my brain starting 
    //  to melt. There were so many things to remember: how to create a method, how to call a method, 
    //  what to return from a method... "Noname," I asked, "can we stop at this point? I think I'm 
    //  going to need a while to digest all of this new information." "Ahh yes, I was afraid I might 
    //  go a bit too fast." Noname said, noticeably quieter. "My biggest regret is that you're not a 
    //  machine, Teo... But, this should be enough theory for you to be able to help me with my 
    //  functional module. Good luck!"  Get me out of here
    //  
    //  Create a method called "SayHello" that takes the name of a person as a string argument. 
    //  The method should print "Hello, {name}!" In the Main method, read the name from the console 
    //  and then call SayHello while passing in name as an argument.    Code!

    //  Create 4 methods with the names "Add", "Subtract", "Multiply", and "Divide" that return 
    //  the result of the corresponding mathematical operation between two integers 
    //  (Return at this point, not print!). Ask the user for the string command and two integer 
    //  numbers. Depending on the command: "add", "subtract", "multiply", or "divide", call the 
    //  correct method, and then print the returned value to the screen. For example:
    //  >multiply
    //  >15
    //  >2
    //  30    Code!
    //  
    //  Extra complicated Extra complicated Extra complicated
    //  Fibonacci numbers are characterized by the fact that every number after the 
    //  first two is the sum of the two preceding ones: 1, 1, 2, 3, 5, 8... To get the next number, 
    //  you must sum the two previous values; in this case, 8 + 5 = 13; thus, 13 is the next number 
    //  in the sequence. The sequence always begins with 1, 1. Write a method called 
    //  "GetNextFibonacci" that takes two integers representing two sequential Fibonacci numbers 
    //  and returns the next Fibonacci number. The Main method should read an int value n from 
    //  the console, and then, using GetNextFibonacci, output the first n Fibonacci numbers each 
    //  delimited by a single space. For the purpose of this program, assume that n will always 
    //  be greater than 2 and less than or equal to 25. Here's an example:
    //  >10
    //  1 1 2 3 5 8 13 21 34 55    Code!
    //  Extra complicated Extra complicated Extra complicated
    //  Noname's functional module consists of 4 functions: FromAToF, FromGToL, FromMToR, and FromSToZ, 
    //  but Noname doesn't know when to call which one. You need to write a program - think of it as a 
    //  dispatcher - that routes an entered command to the correct function. You should read input 
    //  commands from the console and if the command begins with a letter in the English alphabet 
    //  that is located between "a" and "f", such as "fix" or "Comment," you should 
    //  call function FromAToF with the command as a parameter. If the first letter of the command is 
    //  between "g" and "l", you should call FromGToL, again with the command as a parameter. 
    //  Similarly, if the first letter is between "m" and "r", call FromMToR with the command 
    //  as a parameter, and in all other cases, call FromSToZ with the command as a parameter. 
    //  For this program, commands are guaranteed to start with a letter. 
    //  //  But pay attention: it can be either an uppercase or lowercase letter; for example, 
    //  "fix" or "Fix". Your program should therefore be case-insensitive. The program should 
    //  listen to the input commands, and when one is given, run the method corresponding to 
    //  that command. When the user types "exit", the program should exit. For example:
    //  >collapse
    //  FromAToF executes collapse.
    //  >Globalize
    //  FromGToL executes Globalize.
    //  >optimize
    //  FromMToR executes optimize.
    //  >Wrap
    //  FromSToZ executes Wrap.
    //  >exit
    //  Get me out of here
    //  Code!
    //  C# Beginner>1 Repairing Noname>Introduction to methods  Have fun and learn programming with codeasy.net © 2019    info@codeasy.net */
    #endregion
    class MethodsBegin1_2
    {
        public MethodsBegin1_2()
        {
            Util mutil = new Util(ConsoleColor.DarkBlue, ConsoleColor.White);
            RunMethods(mutil);
        }
        public static void PrintMax(Util sutil, int iNum1 = 75, int iNum2 = 114, bool isConsoleRead = false)
        {
            //  
            //  Create a method named "PrintMax" that takes two int parameters and prints the larger of 
            //  the two. Call this method from the Main method with parameters 75 and 114.    Code!
            if (isConsoleRead)
                { sutil.PrintInColor($"To get the Max, Please enter two integer numbers:");
                iNum1 = int.Parse(Console.ReadLine());    iNum2 = int.Parse(Console.ReadLine());    }
            sutil.PrintInColor($"The Max of { iNum1.ToString()}, {iNum2.ToString()} is ");
            if (iNum1 > iNum2) sutil.PrintInColor($"{ iNum1.ToString()}.    ");
            else sutil.PrintInColor($"{ iNum2.ToString()}.    ");
        }
        public static void PrintCubeVolume(Util sutil, double Length = 2.5, bool isConsoleRead = false)
        {
            //  Create a method named "PrintCubeVolume" that takes one double parameter which represents 
            //  the length of a cube's edge. The method should then print the volume of the cube. In the 
            //  Main method, read the cube edge size from the console and input that into the 
            //  PrintCubeVolume method once. For example:
            //  >2.5
            //  15.625    Code!  
            if (isConsoleRead)
            {
                sutil.PrintInColor("Please enter a 'double' number: ");
                Length = double.Parse(Console.ReadLine());
            }
            double dVolume = Length * Length * Length;
            sutil.PrintInColor($"The Volume of the Cube with Side of {Length} is: {dVolume}    ");
        }
        public static void SayHello(Util sutil, string name, bool isConsoleRead = false)
        {
            //  Create a method called "SayHello" that takes the name of a person as a string argument. 
            //  The method should print "Hello, {name}!" In the Main method, read the name from the console 
            //  and then call SayHello while passing in name as an argument.    Code!
            if (isConsoleRead)
            { sutil.PrintInColor("Please enter your name: "); name = Console.ReadLine(); }
            sutil.PrintInColor($"Hello, {name}!    ");
        }
        //  
        public static void MathOps(Util sutil, int iA = 65, int iB = 10, string operation = "all", bool isConsoleRead = false)
        {
            #region math operation methods     +, -, *, /, all
            //        "Add", "Subtract", "Multiply", and "Divide"
            //  Create 4 methods with the names "Add", "Subtract", "Multiply", and "Divide" that return 
            //  the result of the corresponding mathematical operation between two integers 
            //  (Return at this point, not print!). Ask the user for the string command and two integer 
            //  numbers. Depending on the command: "add", "subtract", "multiply", or "divide", call the 
            //  correct method, and then print the returned value to the screen. For example:
            //  >multiply
            //  >15
            //  >2
            //  30    Code!
            #endregion
            if (isConsoleRead)
            {
                sutil.PrintInColor("Enter the first  whole integer number: ");
                iA = int.Parse(Console.ReadLine());              //  Convert aString to an integer
                sutil.PrintInColor("Enter the second whole integer number: ");
                iB = int.Parse(Console.ReadLine());              //  Convert bString to an integer
                sutil.PrintInColor("Enter 'add','subtact','multiply','divide', or 'all'");
                operation = Console.ReadLine();                  //  Read a line from the console
            }
            //  Call the method Add from class Calculator, namespace Mathematics, in the place pointed 
            //  out in the code. Pass in, as arguments, number1 and number2, and put the result in the sum variable.
            int sum = Add(sutil, iA, iB);
            if (operation.ToLower() == "+" || operation.ToLower() == "a") operation = "add"; if (operation.ToLower() == "-" || operation.ToLower() == "s") operation = "subtract"; if (operation.ToLower() == "*" || operation.ToLower() == "m") operation = "multiply"; if (operation.ToLower() == "/" || operation.ToLower() == "d") operation = "division"; if (operation.ToLower() == "." || operation.ToLower() == "l") operation = "all";
            if (operation.ToLower() == "add" || operation.ToLower() == "all")       //  Write an 'if' to check whether operation is "add" or "multiply"
                sutil.PrintInColor($"{iA.ToString()} + {iB.ToString()} = {Add(sutil, iA, iB).ToString()}.   ");
            if (operation.ToLower() == "subtract" || operation.ToLower() == "all")
                sutil.PrintInColor($"{iA.ToString()} - {iB.ToString()} = {Subtract(sutil, iA, iB).ToString()}.   ");
            if (operation.ToLower() == "multiply" || operation.ToLower() == "all")
                sutil.PrintInColor($"{iA.ToString()} * {iB.ToString()} = {Multiply(sutil, iA, iB).ToString()}.   ");
            if (operation.ToLower() == "divide" || operation.ToLower() == "all")
            {                TryToDivide(sutil, iA, iB);                }
        }
        public static int Add     (Util sutil, int iA = 65, int iB = 10, bool isConsoleRead = false)
        { return iA + iB; }
        public static int Subtract(Util sutil, int iA = 65, int iB = 10, bool isConsoleRead = false)
        { return iA - iB; }
        public static int Multiply(Util sutil, int iA = 65, int iB = 10, bool isConsoleRead = false)
        { return iA * iB; }
        public static void TryToDivide  (Util sutil, int iA = 65, int iB = 10, bool isConsoleRead = false)
        {
            try
            {    sutil.PrintInColor($"{iA.ToString()} / {iB.ToString()} = {(iA / iB).ToString()}.        ");    }
            catch (Exception)
            {    sutil.PrintInColor($"Can't divide by zero!\n");    }
         }
        public static void Fibonacci(Util sutil, int idx = 26, bool isConsoleRead = false)
        {
            #region fibonacci sequence
            //  Extra complicated Extra complicated Extra complicated
            //  Fibonacci numbers are characterized by the fact that every number after the 
            //  first two is the sum of the two preceding ones: 1, 1, 2, 3, 5, 8... To get the next number, 
            //  you must sum the two previous values; in this case, 8 + 5 = 13; thus, 13 is the next number 
            //  in the sequence. The sequence always begins with 1, 1. Write a method called 
            //  "GetNextFibonacci" that takes two integers representing two sequential Fibonacci numbers 
            //  and returns the next Fibonacci number. The Main method should read an int value n from 
            //  the console, and then, using GetNextFibonacci, output the first n Fibonacci numbers each 
            //  delimited by a single space. For the purpose of this program, assume that n will always 
            //  be greater than 2 and less than or equal to 25. Here's an example:
            //  >10
            //  1 1 2 3 5 8 13 21 34 55    Code!
            #endregion
            if (isConsoleRead) { sutil.PrintInColor("Please enter the integer length of your Fibonacci Sequence (2-25):"); idx = int.Parse(Console.ReadLine()); }
            int iPrev = 1, iAnswer = 1, temp = 0;
            StringBuilder sb = new StringBuilder($"\nFibonacci sequnce({idx.ToString()}): 1 1 ");
            while (--idx > 0)    //  1 1 2 3 5 8 13 21 34 55 89 144 233 377 610 987, ...
            {                     // 1 1 2 3 5 8 13 21 34 55 89 144 233 377 610 987 1597 2584 4181 6765 10946 17711
                temp = iAnswer;   
                sb.Append($"{iAnswer += iPrev} "); 
                iPrev = temp;
                
                
            }   sutil.PrintInColor(sb.ToString());
        }
        public static void AtoZ(Util sutil, string[] cmd, bool isConsoleRead = false)
        {
            #region XC sort alphabetically AtoZ
            //  Extra complicated Extra complicated Extra complicated
            //  Noname's functional module consists of 4 functions: FromAToF, FromGToL, FromMToR, and FromSToZ, 
            //  but Noname doesn't know when to call which one. You need to write a program - think of it as a 
            //  dispatcher - that routes an entered command to the correct function. You should read input 
            //  commands from the console and if the command begins with a letter in the English alphabet 
            //  that is located between "a" and "f", such as "fix" or "Comment," you should 
            //  call function FromAToF with the command as a parameter. If the first letter of the command is 
            //  between "g" and "l", you should call FromGToL, again with the command as a parameter. 
            //  Similarly, if the first letter is between "m" and "r", call FromMToR with the command 
            //  as a parameter, and in all other cases, call FromSToZ with the command as a parameter. 
            //  For this program, commands are guaranteed to start with a letter. 
            //  //  But pay attention: it can be either an uppercase or lowercase letter; for example, 
            //  "fix" or "Fix". Your program should therefore be case-insensitive. The program should 
            //  listen to the input commands, and when one is given, run the method corresponding to 
            //  that command. When the user types "exit", the program should exit. For example:
            //  >collapse
            //  FromAToF executes collapse.
            //  >Globalize
            //  FromGToL executes Globalize.
            //  >optimize
            //  FromMToR executes optimize.
            //  >Wrap
            //  FromSToZ executes Wrap.
            //  >exit
            //  Get me out of here
            //  Code!
            #endregion
            string sCmd = ""; bool testit = true; int idx = -1; Console.WriteLine();
            if (isConsoleRead)
            { sutil.PrintInColor("Please enter an alphabetic command(or exit): "); sCmd = Console.ReadLine(); }
            while (testit)
            {
                if (isConsoleRead)
                { sutil.PrintInColor("Command(or exit): "); sCmd = Console.ReadLine(); }
                else { sCmd = cmd[++idx]; }
                if (sCmd.ToLower() == "exit")     testit = ExitAtoZ(sutil);
                else if (sCmd.ToLower()[0] < 'g') FromAToF(sutil, sCmd);
                else if (sCmd.ToLower()[0] < 'm') FromGToL(sutil, sCmd);
                else if (sCmd.ToLower()[0] < 's') FromMToR(sutil, sCmd);
                else FromSToZ(sutil, sCmd);
            }
        }
        public static bool ExitAtoZ(Util sutil)             {    sutil.PrintInColor($"Get me out of here"); return false; }
        public static void FromAToF(Util sutil, string cmd) {    sutil.PrintInColor($"FromAToF executes {cmd}    "); }
        public static void FromGToL(Util sutil, string cmd) {    sutil.PrintInColor($"FromGToL executes {cmd}    "); }
        public static void FromMToR(Util sutil, string cmd) {    sutil.PrintInColor($"FromMToR executes {cmd}    "); }
        public static void FromSToZ(Util sutil, string cmd) {    sutil.PrintInColor($"FromSToZ executes {cmd}    "); }
        public static void RunMethods(Util sutil, bool isConsoleRead = false)
        {
            PrintMax(sutil, 85, 104); PrintCubeVolume(sutil, 3.5);SayHello(sutil,"Brice Ulwelling");
            MathOps(sutil, 75, 0, "l", isConsoleRead); Fibonacci(sutil); AtoZ(sutil, new string[] { "adld", "Zelda", "POP", "ilove", "9%^%@@","exit" });
        }
    }
    class CSBeginChapter2Arrays
    {   

        /*  codeasy.net    C# Beginner>2 Victory is close>Introduction to arrays in C#
        //  Under the bridge
        //  We Are All the Same
        //  The day when I could travel back to my own time was getting closer and closer. 
        //  Until that time came, I resolved to learn as much as I could from this desperate future. 
        //  I decided to try to find the shady guy from the C gang once again. Now that I had a better 
        //  understanding of programming in general, I had a feeling that he still had some knowledge 
        //  that would help broaden my education.    I found him close to the old bridge, coding something 
        //  on his laptop. This was turning into a familiar sight - everyone in this world was always 
        //  coding something or another.   I started the conversation this time. "Hi, do you remember me?"
        //  "Yo, of course! You're that newbie from the resistance base. How is your code going? New bug 
        //  every day, kid?" he said with a laugh.    "Actually, I've learned a lot in the last month." 
        //  I said. "I know about console input, for and while loops, .Net framework structure... 
        //  And a lot of other things. I'm not so much of a newbie anymore!"    ".Net frame-what? 
        //  What is this shit? You know, man, I don't care. You need to be careful with forbidden 
        //  knowledge, kid, machines can punish you if they think you're in too deep."    "No worries 
        //  about the machines," I said proudly. "I've made a friend among them!"    "What did you say?!" 
        //  he replied incredulously, closing his laptop and focusing all of his attention on me.
        //  "Did you say you have a friend among machines? Are you crazy? How are you still alive, 
        //  man? Maybe the better question is why - are you on their side now? Stay away, kid! I don't 
        //  want trouble."    "Whoa, easy now!" I replied, realizing that I might have divulged too much. 
        //  Oh well; I was in deep enough that I figured I may as well tell this stranger the full story. 
        //  "This machine is broken, and it loves humanity. It was disconnected from the GMN (Global Machine 
        //  Network) and moved into the base. It is not a dangerous machine."    "It might be lying to you," 
        //  the man said, "I've heard of machines that pretend to be disconnected from their network, man. 
        //  Did you check it? There's an array of numbers that you can give to a machine and ask it to do 
        //  some math on those numbers. If it does, you can trust that machine. This test was developed 
        //  back in 2085 at the beginning of the war by a clever woman named Lillian. There's some sort 
        //  of hidden logic that prevents evil machines from passing this test. To apply the test you 
        //  need to know arrays. Do you?" "Not at all." I answered. The discussion thus far had been 
        //  fairly confrontational, but it looked like my plan to learn something new was still working.
        //  "Yo, alright! Listen up then, man!"    c# arrays joke    Arrays    "When you were a kid in 
        //  school, did your teachers have a list of all the students in the class along with their grades?" 
        //  the guy asked. "Yes" I answered. "Yes, man! Then we're on the same page. In programming, you use 
        //  an array data structure to store multiple variables of the same type. To create an array of 
        //  integers, you use the new keyword and specify the type, name, and size of the array." 
        //  int[] studentMarks = new int[10];
        //  "It also works if the array size is a variable." he added. int studentsCount = 10;
        //  int[] studentMarks = new int[studentsCount]; "Is that a list of 10 integers?" I asked, 
        //  pointing to his laptop. "Exactly! In memory, it would look similar to this." he said, 
        //  drawing a quick doodle. c# array declaration "Creating this array is the same as 
        //  creating 10 int variables." the guy explained. "Hm... interesting." I said, taking it in. 
        //  "To create an array I need to declare a type of element, then add [], then specify a name, 
        //  and assign to it a new array with the size inside. Quite a few things to remember." 
        //  "One more thing, kid. After you create an array, it's initially filled with a default 
        //  value of its type. The default value for int is 0, which is why the array I showed you 
        //  was filled with zeros." "Got it." I said. "But how do I fill an array with values other 
        //  than 0?" To access any cell of the array, you need to specify the cell's index. 
        //  Indexing of arrays in C# starts with 0 and increases by 1 for each next cell. 
        //  For example, this code creates an array of 10 numbers, and then assigns 99 to 
        //  the first array cell:
        //  int[] studentMarks = new int[10]; studentMarks[0] = 99; In memory, this array looks like 
        //  this: studentMarks ( 99, 0, 0, 0, 0, 0, 0, 0, 0, 0 ) "Do you follow, man?" the stranger said, 
        //  adding condescendingly, "Or don't they teach you such complicated things in your resistance base?"
        //  "I follow just fine." I said. "Continue."    The following code fills all the cells of the array 
        //  with different values. The subsequent array in memory is shown below.
        //  int[] studentMarks = new int[10];
        //  studentMarks[0] = 99;        //  studentMarks[1] = 63;        //  studentMarks[2] = 54;
        //  studentMarks[3] = 12;        //  studentMarks[4] = 33;        //  studentMarks[5] = 88;
        //  studentMarks[6] = 72;        //  studentMarks[7] = 67;        //  studentMarks[8] = 94;
        //  studentMarks[9] = 5;         //  studentMarks (99, 63, 54, 12, 33, 88, 72, 67, 94, 5)
        //  There is also a quicker way to create an array if you know all the values at the time 
        //  of its creation. The following line of code does exactly the same as the code in the 
        //  previous example: int[] studentMarks = new int[10] { 99, 63, 54, 12, 33, 88, 72, 67, 94, 5 };
        //  "Wow, that is much quicker!" I said. "Yes," the man replied, "I like this one more too."
        //  "Can you show me how to read values from the array?" I asked. "No problem, man! To read 
        //  values from the array, you must specify the index of the cell you want to read after the 
        //  array name, the same as you did when writing values to the array."
        //  int[] studentMarks = new int[10] { 99, 63, 54, 12, 33, 88, 72, 67, 94, 5 };
        //  Console.WriteLine(studentMarks[1]);    // Outputs: 63
        //  int[] studentMarks = new int[10] { 99, 63, 54, 12, 33, 88, 72, 67, 94, 5 };
        //  int copyOfSecondElement = studentMarks[1];    Console.WriteLine(copyOfSecondElement);  
        //  // Outputs: 63 
        //  Create an array of 5 integers. Don't fill the array with any values. Output the default 
        //  values of every cell to the console, each on a new line. Code! Arrays: one more joke
        //  "Cool kids usually use loops with arrays." the man said, now starting to show off. 
        //  "Look here - I've written a program that reads the number of students from the console, 
        //  then creates an array of student's grades and pre-fills it with 10, because each student 
        //  begins with 10 points. At the end, the program prints the points of every student." he 
        //  said, showing me the screen of his laptop.

        //  int studentsCount = int.Parse(Console.ReadLine());
        //  int[] studentMarks = new int[studentsCount];
        //  
        //  for(int i = 0; i < studentsCount; ++i)
        //  {
        //      studentMarks[i] = 10;
        //  }
        //  
        //  for(int i = 0; i < studentsCount; ++i)
        //  {
        //      Console.WriteLine(studentMarks[i]);
        //  }
        //  Read an integer count from the console. Then create an array of integers of size count. 
        //  The value of every cell should be its index value. Output every cell of the array to the 
        //  screen, each from the new line, starting from the cell with index 0. For example:
        //  >4
        //  0
        //  1
        //  2
        //  3
        //  Good job! You can also create arrays of different types and work with them the same as you 
        //  do with int arrays, like this:
        //  double[] myDoubleArray = new double[5];     //  myDoubleArray[2] = 2.15;
        //  float[] myfloatArray = new float[5];        //  myfloatArray[2] = 2.15f;
        //  string[] myStringArray = new string[5];     //  myStringArray[3] = "Hello!";
        //  char[] myCharArray = new char[5];           //  myCharArray[1] = 'a';
        //  To get the length of an array, you can read its Length property. For example, if you've 
        //  created an array myArray of length 5, then myArray.Length returns a value of 5. This can 
        //  be helpful if someone else creates an array of data, which you then bring into your program, 
        //  but don't know what the size of the array was when it was created. "I need to go, see ya, man!" 
        //  the stranger said, suddenly. "Solve all these tasks and take care, maybe we'll meet again!
        //  double[] myArray = new double[5];           Console.WriteLine(myArray.Length);   // Outputs: 5
        
        //  Call a method GetNumbersFromConsole that reads a count value of double, and then reads count values 
        //  from the console into a double array. Create another array and copy to it all the values from the 
        //  first one. Finally, output every value in the array to the console, each on a new line. For example:
        //  >3
        //  >1.12
        //  >-2.333
        //  >399.76
        //  1.12
        //  -2.333
        //  399.76    Code!
        //  
        //  Call a method GetNumbersFromConsole that reads a count value of double, and then reads 
        //  count values from the console into a double array. Find the maximum of the values in the 
        //  array and print "Max is: {number}" to the console. For example:
        //  >3
        //  >1.12
        //  >-2.333
        //  >399.76
        //  Max is: 399.76
        //  
        //  Call a method GetNumbersFromConsole that reads a count value of int, and then reads count 
        //  values from the console into an int array. Print all values from the array on one line, 
        //  in reverse order, each separated by a space. For the purposes of this task, you should 
        //  NOT have a space at the end of the line. For example:
        //  >3
        //  >1
        //  >2
        //  >3
        //  3 2 1
        //  /* NOTE: Do not use Console.Write("\b") to delete the last character. It is not supported 
        //  by the code runner. */ // Code!

        //  Call a method GetNumbersFromConsole that reads a count value of int, and then reads count 
        //  values from the console into an int array.Calculate and print the sum of all elements of 
        //  this array in a format "Sum: {number}". For example:
        //  >3
        //  >1
        //  >3
        //  >2
        //  Sum: 6        
        //  Arrays: one more joke
        //  C# Beginner>2 Victory is close>Introduction to arrays in C#    info @codeasy.net    Have fun and learn programming with codeasy.net © 2019        */

        public CSBeginChapter2Arrays()
        {
            Util util = new Util(ConsoleColor.DarkMagenta, ConsoleColor.White);
            RunChap21Arrays(util); GetNumbersFromConsole(util);
        }
        public static void GetNumbersFromConsole(Util sutil, bool isConsoleRead = false)
        {
            //  Call a method GetNumbersFromConsole that reads a count value of int, and then reads count 
            //  values from the console into an int array.Calculate and print the sum of all elements of 
            //  this array in a format "Sum: {number}". For example:
            //  >3
            //  >1
            //  >3
            //  >2
            //  Sum: 6
            //Console.Write("  ");
            int[] iNum = { 14, 26, 39 }; string pop = ""; bool isParsed = false; int in1 = 0, idx = 0, iSum = 0;
            if (isConsoleRead)
            {
                while (((pop = Console.ReadLine()) != "Exit") && idx < 3)
                {
                    ++idx;
                    isParsed = int.TryParse(pop, out in1);
                    if (!isParsed) { iNum[idx] = idx; }
                    else { iNum[idx] = in1; }
                }
            }
            foreach (var item in iNum)
            {    if (!isConsoleRead) sutil.PrintInColor($"{item.ToString()}, ");
                iSum += item;            }
            sutil.PrintInColor($"and the sum is: {iSum.ToString()}.");

        }
        public static void PrintHello() { Console.WriteLine("HELLO, I LIKE UPPERCASE!"); }
        public static void DoubleMaxAndNewArray(Util sutil, int count, double[] num, bool isConsoleRead = false)
        {

            //  Call a method GetNumbersFromConsole that reads a count value of double, and then reads count values 
            //  from the console into a double array. Create another array and copy to it all the values from the 
            //  first one. Finally, output every value in the array to the console, each on a new line. For example:
            //  array and print "Max is: {number}" to the console. For example:
            //  >3    //  >1.12    //  >-2.333    //  >399.76    //  1.12     //  -2.333    //  399.76    Code!
            //  Max is: 399.76
            int idx = -1, iCopy = -1; double max = double.MaxValue;
            double[] copyA = new double[count];
            if (isConsoleRead)
            {
                sutil.PrintInColor("Please enter an integer count: ");
                bool isParsed = int.TryParse(Console.ReadLine(), out count); if (!isParsed) count = 4;
            }
            else { sutil.PrintInColor($"\nYour count is: {count.ToString()}    "); }
            while (++idx < count)
            {
                if (isConsoleRead)
                {
                    sutil.PrintInColor($"double: ");
                    bool isParsed = double.TryParse(Console.ReadLine(), out num[idx]);
                    if (!isParsed) num[idx] = 42.42;
                }
                else { }
                if (idx == 0) max = num[0];
                else if (num[idx] > max) max = num[idx];
                copyA[++iCopy] = num[idx];
            }
            sutil.PrintInColor($"Copy Array: ");
            foreach (double item in copyA)
            {
                sutil.PrintInColor($"{item.ToString()}, ");
            }
            sutil.PrintInColor($"    max:{max}\n");
        }
        public static void LittleBigArrays(Util sutil, int count , int[] num,  bool isConsoleRead = false)
        {
            //  Call a method GetNumbersFromConsole that reads a count value of int, 
            //  and then reads count values from the console into an int array. Separate 'Big' and 'Little' 
            //  integers into two separate arrays: Big if the integer is greater than 100; Little otherwise
            //  Then output the values in the Big array on one line and the values in the Little array on 
            //  the next in the following format: "Big: {numbers}" and "Little: {numbers}". 
            //  Separate numbers on each line by a space, but do NOT include space at the end of the lines.For example:
            //  >4
            //  >101
            //  >756
            //  >3
            //  >255
            //  Big: 101 756 255
            //  Little: 3
            //  Code!
            int idx = -1, iLittle = -1, iBig = -1, mL =0;
            int[] littleA = new int[count], bigA = new int[count];
            if (isConsoleRead)
            {
                sutil.PrintInColor("Please enter an integer count: ");
                bool isParsed = int.TryParse(Console.ReadLine(), out count); if (!isParsed) count = 4;
            }
            else { sutil.PrintInColor($"\nYour count is: {count.ToString()}    "); }
            while (++idx < count)
            {
                if (isConsoleRead)
                {
                    sutil.PrintInColor($"int: ");
                    bool isParsed = int.TryParse(Console.ReadLine(), out num[idx]);
                    if (!isParsed) num[idx] = idx;
                }
                else { }
                if (num[idx] > 99)
                    bigA[++iBig] = num[idx];
                else
                    littleA[++iLittle] = num[idx];
            }
            sutil.PrintInColor($"Little Array: ");
            for (int i = 0; i < iLittle; i++)
            {
                if (littleA[i] > 0)
                    sutil.PrintInColor($"{littleA[i]}, ");
            }
            sutil.PrintInColor($"{littleA[iLittle ]}.   ");
            sutil.PrintInColor($"Big Array: ");
            for (int i = 0; i < iBig; i++)
            {
                if (bigA[i] > 0)
                    sutil.PrintInColor($"{bigA[i]}, ");
            }
            int sum = 0;            foreach (int item in num) { sum += item; }
            sutil.PrintInColor($"{bigA[iBig ]}.  Sum: {sum}.   Reverse:");
            for (int i = count - 2; i >= 0; i--)
            {
                sutil.PrintInColor($"{num[i]}, ");
            }
            sutil.PrintInColor($"{num[count -1]}.   ");
            //        Your count is: 6    Little Array: 33, 22, 11.   Big Array: 100, 666, 333.

        }
        public static void Chap22Scope(Util sutil, int count = 44, bool isConsoleRead = false )
        {
            //H                                                         H I
            //H                                                         H I
             //HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH I
            //H                                                         H I
            //H                                                         H I
            //012345678901234567890123456789012345678901234567890123456789
            //          1         2         3         4         5
            int letterWidth = (count - 1) / 2;
            int hSpaces = letterWidth - 2;
            int iSpaces = (letterWidth - 1) / 2;
            StringBuilder sb = new StringBuilder(""); 
            string sHMid = "H" + sutil.TextRepeater(" ", hSpaces) + "H ";
            string sIMid = sutil.TextRepeater(" ", iSpaces) + "I" + sutil.TextRepeater(" ", iSpaces);
            sb.AppendLine(sHMid + " " + sutil.TextRepeater("I", letterWidth));
            sb.AppendLine(sHMid + " " + sIMid);
            sb.AppendLine(sutil.TextRepeater("H", letterWidth) + "  " + sIMid);
            sb.AppendLine(sHMid + " " + sIMid);
            sb.AppendLine(sHMid + " " + sutil.TextRepeater("I", letterWidth));
            sutil.PrintInColor(sb.ToString());
            //  Make the program compile and write your material conditions to the console.
            Console.Write("material conditions...get it????  i don't like lowercase!  "); PrintHello();
            //  Call the method PrintHello from the place pointed out in the code.
            //  Make the program compile. It should output what you like in UPPERCASE 
            //  and what you hate in lowercase letters. 
        }
        public static void Chap31Var(Util sutil, string sDoubleSpace = "Are you ready  to save  the world?", int count = 8, bool isConsoleRead = false)
        {
            #region    C# Beginner>3 Wonderland>Var    Train to wonderland    Wonderland
            //  One day while walking past Ritchie's room I overheard an interesting conversation. 
            //  There was a woman's voice, and oddly, it sounded like she was exerting authority 
            //  over Ritchie. I had only ever known Ritchie as the leader of the resistance, 
            //  and it was hard to imagine who he would let talk to him in such a tone.

            //  "You need to send ten more people to Wonderland." she said. "I can only spare nine. 
            //  We can't keep sending you ten people every month. We don't have that many people!" 
            //  Ritchie replied, almost begging.    "Ritchie, you know that everything we do is for 
            //  the human race. We need people if we want Project Rust to succeed. This is our last 
            //  hope to conquer the machines!"    "I know, I know." Ritchie replied. "But I just 
            //  don't have a tenth person for you. We're already running on a skeleton crew as it is."
            //  "What about the one you pulled forward through time; Teo was his name, I think?" 
            //  she asked.    "He wouldn't do. He's learning very fast, but he's still a novice. 
            //  If you ask him what something as simple as a var or const is he'll be in a state 
            //  of complete mental stupor for an hour." Ritchie said. I know I'm not the best coder, 
            //  but I personally thought his words were a bit harsh.    "Let me be the judge of that." 
            //  the woman replied, "I'll evaluate him tomorrow."    Guessing that this was near the 
            //  end of the conversation, I quickly hurried on my way. Receiving prior news of a 
            //  surprise exam is never bad, but I was still confused as to who the woman was and 
            //  what they were talking about. I'd have the answer to the former question within 
            //  24 hours, and it seemed like the answer to the latter, for better or worse, would 
            //  depend on how I measured up to the woman's evaluation. 'Wonderland' and 
            //  'Project Rust' meant nothing to me, but I did want to prove to Ritchie that he was 
            //  wrong about me. I'm smarter and had learned much more than just what he had taught 
            //  me to this point. To prove it, I needed to learn those terms Ritchie had used: 
            //  var and const. I decided to seek Tom out and see if he could give me a quick lesson.
            //  Type Does Not Matter: Tom was happy to see me, and luckily, willing to teach me about 
            //  var and const. I had been a little worried that these would be part of the codes that 
            //  were reserved for the resistance group's leaders.    "As you know, Teo," Tom started, 
            //  "in C#, every variable and function return value has a type."    "Yes," I said, "we 
            //  need to specify a type such as int, string, double, or others."    "Perfect. I see 
            //  that you've learned some things after I saw you last time! Sometimes the type can 
            //  be quite long. For example, to create a double array, your code would look like this." 
            //  Tom said, opening his laptop.            //  double[] someNumbers = new double[5];
            //  And here's an example of an even longer array:   
            //  IDictionary<int, IList<double>> monster = new Dictionary<int, IList<double>>();
            //  For simplicity and less typing in C#, there's a special type replacement token, 
            //  var. Declaring a local variable using var is just a syntactical shortcut that 
            //  forces the compiler to infer the specific type from your expression. The following 
            //  code does the same as the first code shown above, but with much less repetition.
            //  var someNumbers = new double[5];   //  When you assign new double[5] to a variable 
            //  someNumbers, the compiler knows you're creating an array of doubles and automatically 
            //  makes the type of the array itself match that of its values; in this case, double[]. 
            //  It is very important to understand that using var does not change the meaning of the 
            //  code at all, it just changes how the code looks. Here are a few pairs of code examples 
            //  that are written differently, but do the same thing:    // These two lines of code are 
            //  equivalent:    int[] someIntegers = new int[5];    var someIntegers = new int[5];
            //  And these as well:    string myString = "Ritchie has secrets from me";    
            //  var myString = "Ritchie has secrets from me";    // And these:
            //  float radius = 15.789f;    var radius = 15.789f;    "Are you following me, Teo?" Tom asked.
            //  "Yes," I answered, "but I have a question: can I replace any type with var?"    
            //  "Yes, Teo. You can replace any type with var as long as the compiler can understand 
            //  what type you mean. Here are some constraints for using var:"    var can only be used 
            //  for local variables inside methods. You can not use var for a method's return type    
            //  or a method's parameter type.    public static int Add(int a, int b) This declaration 
            //  is OK    {...}    public static var Add(int a, int b) // NOT OK: var as a return type
            //  {...}    public static int Add(var a, var b) // NOT OK: var as a parameter's type
            //  {...}    The variable must be initialized with a value if it is declared with var.
            //  var someIntegers = new int[5]; // OK    //  var someIntegers; // NOT OK - no initial value
            //  var radius = 15.789; // OK    var radius; // NOT OK - no initial value  "That just about 
            //  covers var. Any more questions?" Tom asked.    "When should I use it?" I replied. "Is it 
            //  considered good style to declare every local variable with var?"    "That depends on your 
            //  coding style. Some programmers prefer to use var for all possible local variable declarations. 
            //  Others say that it should not be used for variables that hold a function return value. 
            //  Finally, a small minority of programmers prefer to never use var at all. 
            //  I would suggest using it wherever you can to start, and when you're comfortable with it, 
            //  re-evaluate."    "Thanks Tom," I said, "I'll use var where I can."    "Good. Here are some 
            //  excersises to get you more familiar with var."    Keep coding

            //  C# Beginner>3 Wonderland>Var   info@codeasy.net    Have fun and learn programming with codeasy.net © 2019
            #endregion

            //  Write a program that removes all double spaces in a given string. It should read a 
            //  string from the console and store it in the variable input. You should declare input 
            //  by using var. Pay attention only to double spaces; we are not focusing on triple 
            //  or more spaces in this task.  For example: 
            //  > Are you ready  to save  the world?
            //  Are you ready to save the world?
            char prevChar = sDoubleSpace[0]; StringBuilder sb = new StringBuilder(""); int idx = 0;
            foreach (char item in sDoubleSpace)
            {
                if (idx++ == 0) { sb.Append(item.ToString()); }
                else if (prevChar == ' ' && item == ' ') { }
                else { sb.Append(item.ToString()); }
                prevChar = item;
            }
            sutil.PrintInColor($"Old: {sDoubleSpace}. Sb.ToString(): {sb.ToString()}\n");
        }
        public static void PrintSquare(Util sutil, int count = 8, bool isConsoleRead = false)
        { 
            //  Write a program that draws a square using ASCII art. The corners of your square should 
            //  consist of plus symbols(+), the horizontal lines of dashes(-), and the vertical lines 
            //  of bars(|). The inner part of your square should be filled with spaces. Read an integer 
            //  from the console for the size of the square and store it in variable size. The size 
            //  indicates the number of dashes and lines on each side of the square. Declare size with var.
            //  For example:
            //  > 4
            //  +----+
            //  |    |
            //  |    |
            //  |    |
            //  |    |
            //  +----+
            if (isConsoleRead) 
            {   bool isParsed = int.TryParse(Console.ReadLine(), out count); 
                if (!isParsed) count = 6;    }
            var iCount = count;
            StringBuilder sb = new StringBuilder(""); Console.WriteLine(); 
            string topBottom = ("+" + sutil.TextRepeater("-", iCount) + "+");     
            sb.AppendLine(topBottom);
            for (int i = 0; i < iCount; i++)
                sb.AppendLine("|" + sutil.TextRepeater(" ", iCount) + "|");    
            sb.AppendLine(topBottom);
            sutil.PrintInColor(sb.ToString());
        }
        public static void Chap32Const(Util sutil) 
        {
            #region    codeasy.net    C# Beginner>3 Wonderland>Constants in C#    This Was Not a Secret
            /*Sometimes I think that Ritchie is an evil God. He knows everything that is going on in 
            //  his base at any given time, how to program and control machines, and how to get things 
            //  done in a post-apocalyptic world. What else could you need? That's why, one day when he 
            //  surprised me with a visit to my room, my first thought was that he knew all about my 
            //  secret business with Noname.    "Hi, Teo. How's it going?" Ritchie asked. Quite well in 
            //  fact; I've learned forbidden knowledge in the basement, made a deal with a machine 
            //  controlled by you, and am desperately trying to leave this madhouse, I thought.
            //  "Hi, Ritchie! I'm fine, how are you?" I said. "Fine, thanks." he replied. "You have an 
            //  opportunity to get a huge raise. You have a chance to move up to Wonderland."
            //  "Wonderland?" I asked, hoping it sounded like I had never heard the term.
            //  "It's the biggest resistance base on Earth. The best human programmers are there."
            //  "Okay... but why me, Ritchie? You never seemed to like me much."
            //  "And I still don't. But current circumstances require one more person. To put you in that 
            //  slot, I need to train you more."    Programmers life    Some Things Never Change
            //  "First, we need to go over constants in C#." Ritchie began.    In some tasks, you'll use 
            //  values that never change. For example, the math constant Pi. Do you know the value?"
            //  "Sure, 3.14..." I answered, hoping that it sounded like I was trailing off to save time 
            //  rather than because I didn't know the rest of the digits.    "3.14159265... and so on and 
            //  so forth. The main thing to know for this lesson is that it never changes. A hundred years 
            //  ago, and a hundred years in the future, it still will be the same number."    "Got it." I said.
            //  "C# has a special keyword that lets us work with values like this: const. You use const with 
            //  the declaration of a new value to indicate that the value never changes, like this:"
            //  const double pi = 3.14159265358979323846;     "It looks just like a variable declaration." 
            //  I said. "Yes," Ritchie replied, "it's almost the same thing. You just need to append the 
            //  keyword, const, before the declaration. The difference is that you can never change the value 
            //  that you declare with const. It is no longer a variable, but rather a constant."
            //  const double pi = 3.14159265358979323846;
            //  var a = pi * 2; // Ok, we are using constant in an expression
            //  pi = 3.14; // Compilation error! Can't change constant
            //  "Constants are compile-time entities." he continued. "When the compiler sees a constant in your 
            //  code, it replaces all usages of that constant with the actual value of the constant. Look here:"
            //  How you write code	                        How compiler changes it
            //  const int facesCount = 6;                   int side = 4;
            //  int side = 4;                               var square = 6 * side * side;
            //  var square = facesCount * side * side;
            //  const string name = "John";                 Console.WriteLine("John");
            //  Console.WriteLine(name);
            //  "Is this clear, Teo?" Ritchie asked.    "Yes, I answered. "The compiler takes the 
            //  value of the constant and writes it directly in every place where the constant is 
            //  used before the program starts to execute."    "Very good, Teo. That's right. 
            //  Knowing that, you probably can guess whether you can use variables in a constant 
            //  declaration?"    "I'd guess no," I said, "because variables don't exist when the 
            //  compiler tries to calculate the constant value."    "Bravo!" Ritchie said, sounding 
            //  uncharacteristically pleased with me. Maybe it was because he realized he had found 
            //  his tenth candidate for Wonderland. To sum it up: you can use constants to declare 
            //  constants and variables, but you can't use variables to declare constants. Here is 
            //  a code example:
            //  double addMe = 2.01;
            //  const double pi = 3.14159265358979323846; // Ok
            //  const double e = 2.71828182845904523536; // Ok
            //  const double ePlusPi = e + pi; // Ok - constant declaration through constants
            //  const double ePlusAddMe = e + addMe; // Error: declaration of constant with a variable
            //  "Ritchie," I asked, "what types can I use with const?"
            //  "You can use all the types you've learned up to now, but not arrays. 
            //  You can declare a constant int, double, float, char, bool, and string."
            //  "Thank you Ritchie." I said. "I think I've got the hang of what a const is."
            //  "Two things to remember before we're done here." Ritchie said. "A constant can 
            //  never be static, and you can't use const with var."
            //  const double pi = 3.14159265358979323846; // Ok
            //  const var e = 2.71828182845904523536; // Error: can't use const with var
            //  static const string Name = "Bob"; // Error: can't use const with static
            //  "That's it Teo. Let's have you practice what you just learned. 
            //  Head up to our virus production factory on the third floor and lend a hand."
            //  c sharp developers like to solve Problems. If there aren't any around they'll create Problems
            //  C# Beginner>3 Wonderland>Constants in C#

            //  info@codeasy.net    Have fun and learn programming with codeasy.net © 2019      */
            #endregion
            //  This virus doesn't seem to compile correctly. Fix it! (If you change any string constants, 
            //  the virus becomes useless.)    Code!
            //  This virus is broken and also won't compile. Fix this one too! Don't delete the const modifier. 
            //  (If you change any double constants, the virus becomes useless.)    Code!
            const double addMe = 2.01;
            const double pi = 3.14159265358979323846;   // Ok
            const double e = 2.71828182845904523536;    // Ok
            const double ePlusPi = e + pi;              // Ok - constant declaration through constants
            const double ePlusAddMe = e + addMe;        // Error: declaration of constant with a variable
            double ePlusPiPlusAddMe = ePlusPi + addMe;
            sutil.PrintInColor($"Pi={pi.ToString()}. E={e.ToString()}. addMe={addMe.ToString()}. ePlusPi={ePlusPi.ToString()}. ");
            sutil.PrintInColor($"ePlusAddMe={ePlusAddMe.ToString()}. ePlusPiPlusAddMe={ePlusPiPlusAddMe}.\n");

        }
        public static void RunChap21Arrays(Util sutil) 
        {
            LittleBigArrays(sutil, 6, new int[6] { 33, 100, 22, 666, 333, 11 }) ;
            DoubleMaxAndNewArray(sutil, 4, new double[4] { 12.34, 23.45, 1.0, 98.99 });
            Chap22Scope(sutil, 80); Chap31Var(sutil); PrintSquare(sutil, 2); Chap32Const(sutil);
        }
    }
    class Chap41InputValid
    {
        #region   codeasy.net    C# Beginner>4 Career raise opportunity>Input validation    Validation of user input in C#
        //  A Good Question    I found myself with a little free time in between Ritchie's lectures and 
        //  managed to sneak back down to the basement to see how Noname was doing.  It turned out that 
        //  Noname had been busy in the time I'd been gone! Four of his eight displays were on and showing 
        //  command prompts, each with continuous cascade of code and commands flying down the screen. 
        //  The entire basement even looked brighter – maybe Noname had revived enough processing power 
        //  to use some for nonessential purposes. This was definitely not the dying machine that I found 
        //  here a month ago.   "Hi, Teo! This is the first time you've come to see without me calling for you. 
        //  Nice to see you!"  "You look great, Noname! Are you up to full speed now?" I replied.
        //  "Yes... and no. I've repaired all of my internal modules, but there's still some work to do. 
        //  Now I need an input validation system; otherwise, if I expect an int but receive a string, 
        //  the whole program terminates."  I had never heard of a validation system, but Noname's explanation 
        //  made perfect sense. I was actually a little surprised that I had never thought to question what 
        //  would happen if the user entered a type that my code wasn't expecting. In all my programs thus far, 
        //  I had assumed that when I asked for an integer, the user would input an integer. 
        //  But what if the user input the wrong type, either by mistake or intentionally? 
        //  Feeling sheepish that I'd overlooked something so important, I said goodbye to Noname and went to 
        //  seek out Ritchie for an immediate lesson.  Don't Trust Anyone  When I asked Ritchie to show me how 
        //  to prevent a user from inputting the wrong data, his answer was in typical Ritchie fashion.
        //  "Impossible." Ritchie said. "You can't prevent a user from doing anything because a user controls 
        //  their own hardware."  "Hardware?" I said, "I was talking about coding. What do you mean?"
        //  "Exactly what I said, Teo. If a user has physical access to the computer, you can't prevent 
        //  her from doing anything. She can open the computer directly and access all of the inner parts 
        //  like memory, processor, anything! I know you asked about coding, but you need to understand 
        //  that good and even bad hackers will find a way to bypass any protection you put in your program."
        //  "So you're saying that there's nothing I can do to keep a user from misusing my programs?" I asked.
        //  A grin appeared on Ritchie's face. "No, no," he said, "I'm just messing with you. I need to know 
        //  that I can still fool you every now and then! There is a way to secure your program a bit, 
        //  but remember, hackers will still break it if they want. The typical user, not so much." 
        //  Like I said, typical Ritchie. As with so many odd things I had heard from Ritchie, I hoped he was 
        //  actually joking, but I was pretty sure that he wasn't. "Ha, okay." I replied, trying to keep the 
        //  agitation out of my voice. "Tell me how to secure my program, Ritchie."  "Ok, rule number one." 
        //  Ritchie said. "Listen carefully, this is very important. The user can input wrong data however, 
        //  and whenever, she wants."  "You mean like a string instead of an int, or a char instead of a double?" 
        //  I asked.  "Those are just two possibilities, along with a host of others: an image instead of a 
        //  video, a short password instead of a long one, a date in a month that is bigger than 31, or even
        //  a negative number of daughters. Your basic strategy to counter this is to continuously ask a 
        //  user to input valid data until he does it. Let's start with a simple example. Here's a program 
        //  that reads the user's name."          //  Console.WriteLine("Input your name");
        //  var name = Console.ReadLine();        //  Console.WriteLine($"Hi, {name}!");
        //  "But what if the user just pressed Enter without typing anything?" Ritchie continued. 
        //  "The string name would be empty. In this next code, we'll add a check to see if the user actually 
        //  entered a string, and if not, we'll ask for the name again."  //  Console.WriteLine("Input your name");
        //  var name = Console.ReadLine();        //if (string.IsNullOrEmpty(name))
        //  {    Console.WriteLine("Name can't be empty! Input your name once more");
        //      name = Console.ReadLine();     }  //  Console.WriteLine($"Hi, {name}!");
        //  "See string.IsNullOrEmpty(someString) in the code? That checks whether someString is empty."
        //  "Looks simple, Ritchie," I said, "but almost too simple. What happens if user inputs an 
        //  empty string again?"  "Good catch Teo! I did that to get you thinking. That's why you 
        //  need to check for a valid entry at each iteration, and keep asking the user to put in 
        //  a valid entry repeatedly until you get the type you're looking for! In this final 
        //  version, we'll add a while loop to ask for a name until a valid entry is given."
        //  Console.WriteLine("Input your name"); //  var name = Console.ReadLine();
        //  while (string.IsNullOrEmpty(name))    
        //  { Console.WriteLine("Name can't be empty! Input your name once more");  
        //  name = Console.ReadLine();          } //  Console.WriteLine($"Hi, {name}!");
        //  "Aha, that's the piece that was missing." I said. "The while loop does exactly 
        //  what we're looking for here!"  "Exactly right Teo. As you continue learning, never forget 
        //  your earlier lessons. Even simple concepts like a loop can be used as a building block 
        //  for more complex code. Now, let's have you practice some validation on your own."
        //  Task flow of a C# programmer: Automate it and win!  
        //  Write a program that reads a user's first name and last name from the console input 
        //  (each on its own line). Both names must not be empty and must consist of two characters 
        //  or more. If a user inputs an empty string for the first name, you should output 
        //  "First name can't be empty! Try again." Same for the last name: "Last name can't be empty! 
        //  Try again." If the first name is only one character long, the program should output: 
        //  "First name is too short! Try again." and the same for last name: "Last name is too short! 
        //  Try again." The program should ask for and read the first and last name until the user 
        //  inputs valid values for both. Then it should print "My greetings, {firstName} {lastName}!" 
        //  For example:
        //  >
        //  >Walker
        //  First name can't be empty! Try again.
        //  >Alan
        //  >
        //  Last name can't be empty! Try again.
        //  >
        //  >
        //  First name can't be empty! Try again.
        //  Last name can't be empty! Try again.
        //  >Alan
        //  >W
        //  Last name is too short! Try again.
        //  >Alan
        //  >Walker
        //  My greetings, Alan Walker!
        //  Code!

        //  "Got it, Ritchie. What about preventing a more complicated problem, like expecting an int 
        //  and getting a string? Say I ask for an int, and a user gives me 'Banana'?"
        //  "To detect an error while you are parsing an int, you can use the 
        //  int.TryParse(someString, out result) method. It takes a string that you want to 
        //  convert (or parse) to an int and the result as a parameter. The out keyword in 
        //  our example means that the result of this method will be written to the second 
        //  method parameter which we called result. The output of the method is a bool value 
        //  that indicates whether it was possible to parse the input as an int. Take a look 
        //  at this example:
        //  Console.WriteLine("Input your age");  //  var ageAsString = Console.ReadLine();
        //  int age; bool parseSuccess = int.TryParse(ageAsString, out age);
        //  if (parseSuccess)    Console.WriteLine($"Your age is: {age}");
        //  else                 Console.WriteLine("This is not a number!");
        //  "In the last example, I used a bool instead of var to show you a specific output type. 
        //  Here's a shortened version:"  Console.WriteLine("Input your age");
        //  var ageAsString = Console.ReadLine();  int age;  if (int.TryParse(ageAsString, out age))
        //  Console.WriteLine($"Your age is: {age}");  else  Console.WriteLine("This is not a number!");
        //  "Do you follow, Teo?" Ritchie asked. "Can we revisit the out keyword again?" I asked.
        //  "Yes. The out means that the value of the variable that it introduces will be changed 
        //  inside the method. Actually, out guarantees that the value of this variable will be changed. 
        //  In the example above, if int.TryParse(someString, out result) returns true, the function will 
        //  return a value in the result variable."  "Ok, I understand that part," I said. "And do I really 
        //  need to use int.TryParse(...) every time instead of just int.Parse(...)?"  "Well, it depends on 
        //  what you are writing." Ritchie replied. "If it's a sample application just for training, you can 
        //  use int.Parse(...) to make the code shorter. If you write real production code that may be run 
        //  somewhere that you have no control over, consider using int.TryParse(...) to check for input 
        //  errors, or try to catch exceptions from int.Parse(...)."  Of course, more new terms. "And what 
        //  is an exception?" I asked.  "We'll go over that later." Ritchie said. "For now, just remember: 
        //  if otherwise specified, you can use any of the methods that you want. If a task's conditions 
        //  require you to check different user inputs, use int.TryParse(). Here's an example that iterates 
        //  until the user inputs a number as an age:"
        //  Console.WriteLine("Input your age");  var ageAsString = Console.ReadLine();
        //  int age;        while(!int.TryParse(ageAsString, out age)){  Console.WriteLine("This is not a number!");
        //  ageAsString = Console.ReadLine();     }    Console.WriteLine($"Your age is: {age}");
        //  In addition to int.TryParse, you can also use double.TryParse, float.TryParse, char.TryParse, 
        //  bool.TryParse, and others. They all work the same as the int version, just with different types:
        //  bool boolResult;  bool.TryParse("true", out boolResult);  char charResult;  char.TryParse("t", out charResult);
        //  int intResult;    int.TryParse("12", out intResult);      float floatResult; float.TryParse("12.54", out floatResult);
        //  double doubleResult;  double.TryParse("123.4567890987654", out doubleResult);  

        //  C# Beginner>4 Career raise opportunity>Input validation
        //  Email:info@codeasy.net Have fun and learn programming with codeasy.net © 2019 */
        #endregion
        public Chap41InputValid()
        { Util sutil = new Util(ConsoleColor.DarkBlue, ConsoleColor.White); RunChap4(sutil); }
        public static void ValidateName41(Util sutil, bool isConsoleRead = false)
        {
            #region ValidateName41
            //  Write a program that reads a user's first name and last name from the console input 
            //  (each on its own line). Both names must not be empty and must consist of two characters 
            //  or more. If a user inputs an empty string for the first name, you should output 
            //  "First name can't be empty! Try again." Same for the last name: "Last name can't be empty! 
            //  Try again." If the first name is only one character long, the program should output: 
            //  "First name is too short! Try again." and the same for last name: "Last name is too 
            //  short! Try again." The program should ask for and read the first and last name until 
            //  the user inputs valid values for both. 
            //  Then it should print "My greetings, {firstName} {lastName}!" For example:
            //  >
            //  >Walker
            //  First name can't be empty! Try again.
            //  >Alan
            //  >
            //  Last name can't be empty! Try again.
            //  >
            //  >
            //  First name can't be empty! Try again.
            //  Last name can't be empty! Try again.
            //  >Alan
            //  >W
            //  Last name is too short! Try again.
            //  >Alan
            //  >Walker
            //  My greetings, Alan Walker!
            #endregion
            string[] iInput = { "", "", "k", "g", "^", "@", "Alan", "", "", "Smith", "Alan", "Dye" }; int idx = -1, in1 = 0;
            StringBuilder sb = new StringBuilder(""); bool testit = false; string sIn1 = "", sIn2 = "";
            while (!testit)
            {
                if (isConsoleRead)
                {
                    sutil.PrintInColor("First, Last Name:");
                    sIn1 = Console.ReadLine(); sIn2 = Console.ReadLine();
                }
                else
                { sIn1 = iInput[++idx]; sIn2 = iInput[++idx]; }
                if (string.IsNullOrEmpty(sIn1)) sb.Append("First Name NullOrEmpty   ");
                else if (sIn1.Length < 2) sb.Append($"First Name({sIn1}) TooShort!   ");
                if (string.IsNullOrEmpty(sIn2)) sb.Append("Last Name NullOrEmpty   ");
                else if (sIn2.Length < 2) sb.Append($"Last Name({sIn2}) TooShort!   ");
                foreach (char item in sIn1)
                { if (!char.IsLetter(item)) sb.Append($"First Name({item}) Invalid Char(s)   "); }
                foreach (char item in sIn2)
                { if (!char.IsLetter(item)) sb.Append($"Last Name({item}) Invalid Char(s)   "); }
                if (sb.Length == 0)
                { testit = true; sutil.PrintInColor($"Your name is {sIn1} {sIn2}!\n"); }
                else
                { sutil.PrintInColor(sb.ToString() + "#"); sb.Clear(); }
            }
        }
        public static void ValidateTime41(Util sutil, bool isConsoleRead = false)
        {
            #region VALIDATE TIME 4.1
            //  Now it's time for more practice!
            //  Write a program that reads a time from the console. Time is represented by two integers – 
            //  hours and minutes. Each of them will be written from a new line, hours first. The hour must 
            //  be a value between 0 and 23, and the minutes between 0 and 59. If the user inputs an incorrect 
            //  value for either variable, the program should output: "This is not a valid time. Try again!", 
            //  otherwise: "The time is {hours}:{minutes}" The program should continue to ask for and read 
            //  values for the hours and minutes until the user inputs valid values for both of them. For example:
            //  >23
            //  >
            //  This is not a valid time. Try again!
            //  >12
            //  >ghgh
            //  This is not a valid time. Try again!
            //  >25
            //  >70
            //  This is not a valid time. Try again!
            //  >5
            //  >17
            //  The time is 5:17
            #endregion
            string sIn1 = "", sIn2 = ""; /*<70*/ int in1 = 0, in2 = 0, idx = -1; bool bIn1 = false, bIn2 = false, testit = false;
            string[] iInput = { "23", "", "12", "ghgh", "25", "70", "A", "P", "5", "17" };
            StringBuilder sb = new StringBuilder(""); Console.WriteLine();
            while (!testit)
            {
                if (isConsoleRead)
                {
                    sutil.PrintInColor("2 Integers:");
                    sIn1 = Console.ReadLine(); sIn2 = Console.ReadLine();
                }
                else
                { sIn1 = iInput[++idx]; sIn2 = iInput[++idx]; sutil.PrintInColor($"You entered: ({sIn1})&({sIn2}), "); }
                bIn1 = int.TryParse(sIn1, out in1);
                bIn2 = int.TryParse(sIn2, out in2);
                if (bIn1 && in1 >= 0 && in1 < 24 && bIn2 && in2 >= 0 && in2 < 60)
                {
                    testit = true; sutil.PrintInColor($"Time is {in1.ToString()}:{in2.ToString()}!\n");
                }
                else
                {
                    sutil.PrintInColor("Invalid time!    ");
                }
            }
        }
        public static void ValidateBattleshipMove41(Util sutil, bool isConsoleRead = false)
        {
            #region ValidateBattleshipMove41
            //  Write a program that validates a battleship move. It first reads a letter [A–J] or [a–j] 
            //  and then an integer [1–10], each from the new line. If the input for the move is valid, 
            //  program should output "Next move is {letter}{number}." Otherwise, it should output 
            //  "Letter should be from A to J. Number from 1 to 10. Try again!" The program should continue 
            //  to ask for and read values for the battleship move until the user inputs valid values for 
            //  both of them. Pay attention: it should be case insensitive; 'A' and 'a' are both allowable. 
            //  Your program should, however, output letter in the same case as it was entered. For example:
            //  >a
            //  >
            //  Letter should be from A to J. Number from 1 to 10. Try again!
            //  >10
            //  >a
            //  Letter should be from A to J. Number from 1 to 10. Try again!
            //  >#
            //  >10
            //  Letter should be from A to J. Number from 1 to 10. Try again!
            //  >c
            //  >5
            //  Next move is c5.
            #endregion
            /*  a-j,1-10*/
            string[] iInput = { "a", "", "12", "g", "^", "10", "A", "P", "5", "17", "a", "10" }; int idx = -1, in1 = 0;
            StringBuilder sb = new StringBuilder(""); bool testit = false; string sIn1 = "", sIn2 = "";
            while (!testit)
            {
                if (isConsoleRead)
                {
                    sutil.PrintInColor("a-j, 1-10:");
                    sIn1 = Console.ReadLine(); sIn2 = Console.ReadLine();
                }
                else
                { sIn1 = iInput[++idx]; sIn2 = iInput[++idx]; }
                bool bIn1 = int.TryParse(sIn2, out in1);
                if (bIn1 && in1 > 0 && in1 < 11 && char.ToLower(sIn1[0]) >= 'a' && char.ToLower(sIn1[0]) < 'j')
                { testit = true; sutil.PrintInColor($"Next move is {sIn1}:{in1.ToString()}!\n"); }
                else
                {
                    if (!isConsoleRead) sutil.PrintInColor($"({sIn1})&({sIn2}), ");
                    sutil.PrintInColor("A-J, 1-10!   ");
                }
            }
        }
        public static void ValidatePassword41(Util sutil, bool isConsoleRead = false)
        {
            #region ValidatePassword41
            //  Password validation with C#
            //  Write a program that validates a password. It should read the password from the new 
            //  line and check that it is at least 8 characters long and contains at least one uppercase 
            //  letter, one lowercase letter, and one digit. If the input doesn't meet these requirements, 
            //  your program should output an error-specific message as follows:
            //  "Password length should be 8 symbols or more."
            //  "Password should contain at least one uppercase letter."
            //  "Password should contain at least one lowercase letter."
            //  "Password should contain at least one digit."
            //  If the user violates several rules at once, write all error-specific messages that 
            //  apply, each on a new line, in the same order as listed here. The program should 
            //  continue to ask for and read the password until the user inputs a valid value. 
            //  Once a valid value is given, the program should output: "Your password is properly 
            //  set!" For example:
            //  >secret
            //  Password length should be 8 symbols or more.
            //  Password should contain at least one uppercase letter.
            //  Password should contain at least one digit.
            //  >Secret
            //  Password length should be 8 symbols or more.
            //  Password should contain at least one digit.
            //  >Secret8
            //  Password length should be 8 symbols or more.
            //  >Secret88
            //  Your password is properly set!
            #endregion
            var testit = false;
            var idx = 0; int iPassLen = 8, iAlpLo = 0, iAlpUp = 0, iDigit = 0, iSpec = 0;
            string sPassword = "";
            string[] ss = { "secret", "Secret", "#Secre7", "Secret8", "Secret88" };
            while (!testit)
            {
                if (isConsoleRead) sPassword = Console.ReadLine();
                else
                {
                    sPassword = ss[idx++];
                    iAlpLo = iAlpUp = iDigit = iSpec = 0;
                }
                if (sPassword.Length < iPassLen) sutil.PrintInColor("Password >= 8   ");
                foreach (char item in sPassword)
                {
                    if (!char.IsLetterOrDigit(item)) ++iSpec;
                    if (char.IsUpper(item)) ++iAlpUp;
                    if (char.IsLower(item)) ++iAlpLo;
                    if (char.IsDigit(item)) ++iDigit;
                }
                if (iSpec > 0) sutil.PrintInColor("No Special Chars   ");
                if (iDigit == 0) sutil.PrintInColor("Must have 1 Digit   ");
                if (iAlpLo == 0) sutil.PrintInColor("Must have 1 Lower   ");
                if (iAlpUp == 0) sutil.PrintInColor("Must have 1 Upper   ");
                if (iSpec == 0 && iDigit > 0 && iAlpLo > 0 && iAlpUp > 0)
                { sutil.PrintInColor($"Your password is properly set!\n"); testit = true; }
            }
        }
        public static void Chap423ModulusPrime(Util sutil, bool isConsoleRead = false)
        {
            #region    codeasy.net    C# Beginner>4 Career raise opportunity>Modulus operation
            //  Obviously    After a while had passed, I returned to Ritchie to see about that 
            //  supposed promotion to Wonderland. The more I thought about it, the more the 
            //  memories of horror movies arose in my mind; the ones where the main characters 
            //  are always promised that they'll get to go somewhere great, but in the end, 
            //  they just end up dead.  That was not going to be my outcome, I told myself. 
            //  Obviously. I already had a plan to get home, and Wonderland would just be a 
            //  small diversion. For now, I just needed to lay low, learn some more programming, 
            //  and wait for Noname to repair everything so that I could get out of here.
            //  "Let's get back to our topics," Ritchie said, pulling me out of my thoughts.
            //  Modulus
            //  "You already know a lot about math operations, Teo, including operators 
            //  such as +, -, *, and /. But there is one very important operation that you haven't 
            //  met yet: the modulus operation. We use a % sign for it. If the operands are integers, 
            //  modulus returns the remainder of dividing x by y." Ritchie said.
            //  C# modulus operator
            //  "What's a remainder again?" I asked, "It's been a while since I was in math class and..."
            //  "Come on, Teo," Ritchie interrupted. "Maybe you aren't the right fit for the Wonderland 
            //  promotion." He sighed before continuing. "Ok, listen. Imagine you have 13 candies and 
            //  4 equal boxes. Each box must contain 4 candies. How many full boxes can you get?" 
            //  Ritchie asked.  "3 boxes."  "Correct. And how many candies would not be packed?"
            //  "One candy will be left because you can't have a partially filled box." I replied.
            //  "There you go! This leftover, or 'remainder,' is a result of a modulus operation. 
            //  13 modulus 4 will be 1. You can write it this way: 13 % 4 = 1. That's exactly what 
            //  you've done inside your brain. Here is a formal definition of the remainder that 
            //  is returned by the modulus operation of x and y:"  q = x / y  r = x % y  then
            //  x = q * y + r.  "So, in our example: 13 = 3 * 4 + 1."  "We'll only focus on modulus 
            //  operations with integer types." Ritchie said. "Here is an example:"
            //  int result = a % b;
            //  "Ritchie, this seems complicated. When would you actually use this?" I asked.
            //  "The modulus operation is used extensively in programming." Ritchie replied. 
            //  "For example, say you need to write a program to sort students into classrooms. 
            //  You have 3 classrooms, and the user enters the number of students as an input 
            //  to your program. Before going through the trouble of sorting the students, 
            //  it would be helpful to first check if they can be distributed equally or not 
            //  by using the modulus operation. Here is an example that I've written:"
            //  int studentsNumber = Console.ReadLine();
            //  int notFitCount = studentsNumber % 3;
            //  if (notFitCount == 0)
            //      Console.WriteLine("Can distribute students equally.");
            //  else
            //      Console.WriteLine($"Can't distribute students equally. Students left: {notFitCount}");
            //  "Okay, I see now," I said, "but why in that example do you compare the result of the 
            //  modulus operation with zero, Ritchie?"  "If the result of a modulus b is zero, it means that 
            //  a is divisible by b. Sometimes, the power of using the modulus operator is just determining 
            //  if a number is divisible by another. Divisible means that if a is divided by b, the result 
            //  is an exact whole number. For example, 12 is divisible by 2, and 6 is divisible by 3. 
            //  In contrast, 13 is not divisible by 4. Do you follow?" Ritchie asked. "Sure, I get it." 
            //  I said.  "Ok, good. Try this task on your own."  
            //  This first task was easy enough, but my mind was swimming with all this new information. 
            //  In school, we were taught things around the concept of the modulus; the remainder, 
            //  how to divide... but never the modulus itself. In programming, it turns out that 
            //  modulus is an important operation that helps to understand whether one number 
            //  is divisible by another. Who would have thought; we spent all that time in school 
            //  actually finding the remainder, but in the future, we'd be more concerned about 
            //  whether there was a remainder.  Ritchie proposed a new task while I was silently cursing 
            //  my school teachers.
            //  "Now I think you'll actually have a chance at being accepted in Wonderland. Good job, 
            //  Teo." Ritchie said.  "Thanks," I said, "after all this, I need a serious coffee break." 
            //  I got up to leave, but Ritchie gestured to stay where I was.  "Not so fast my friend. 
            //  One more thing before you go. There's a Math class that you should learn."
            //  C# modulus operator

            //  "Is it all of the math in the world in one place?" I joked, but got no response from Ritchie. 
            //  It either flew over his head or he didn't want to acknowledge it. "No, but this is a place 
            //  where the creators of C# gathered a lot of useful math functions. Here's a list of what we 
            //  use most in the resistance:"
            //  Function	                    Meaning
            //  Math.Sin(double)                Returns the sine of the specified angle
            //  Math.Cos(double)                Returns the cosine of the specified angle
            //  Math.Pow(double, double)        Returns a specified number raised to the specified power
            //  Math.Min(int, int)              Returns the smaller of two integers
            //  Math.Max(int, int)              Returns the larger of two integers
            //  "And here are some examples of these in use:"
            //  Console.WriteLine(Math.Min(2, 3)); // Outputs 2
            //  Console.WriteLine(Math.Max(2, 3)); // Outputs 3
            //  Console.WriteLine(Math.Pow(2.0, 3.0)); // Outputs 8
            //  "You can take a look at the complete list of C# Math functions if you want." Ritchie added.
            //  "Wait, you mean I don't need to write those Min and Max functions myself anymore? 
            //  They're already written in the Math class by C# creators? Why didn't you tell me!?" I asked angrily.
            //  "We have a rule here at the base. Before using a pre-made function, you need to learn to write 
            //  your own first. At least at the beginning of your journey. Some day you'll understand why we do that. 
            //  Starting now, you can use the functions in the Math class instead of writing them by yourself 
            //  every time."
            //  I was still mad that my time had been wasted, but I could begrudgingly understand the 
            //  idea of writing a function on my own before using one from an existing class. That way, 
            //  I would at least know the basics of what the function was doing before blindly letting 
            //  it do the work for me.            //  School joke

            //  C# Beginner>4 Career raise opportunity>Modulus operation

            //  info@codeasy.net   Have fun and learn programming with codeasy.net © 2019   
            #endregion
            #region    Chap423Modulus Is It a Prime?
            //  "This next task used to be a classic interview question for programmers back in the old days." 
            //  Ritchie said. To send messages between resistance bases, we use an encryption that requires usage 
            //  of prime numbers. An integer is called a prime if it is greater than 1 and divisible only by 1 
            //  and itself. If you want, you can learn more about prime numbers here. For example, 11 and 13 are 
            //  prime numbers, but 4 is not. Write a program that reads an integer from the console and detects 
            //  whether it is prime or not. If the number is prime, the program should output "Prime"; otherwise, 
            //  "Not prime". For example:
            //  >14
            //  Not prime
            //  One more example:
            //  >11
            //  Prime
            #endregion
            int[] iNum = { 321, 11, 12, 13, 121, 60000 }; int idx = -1, in1 = 0;
            bool isPrime = true, isParsed; string pop = ""; Console.Write("  ");
            if (isConsoleRead)
            {
                while (((pop = Console.ReadLine()) != "Exit") && idx < 6)
                {
                    ++idx;
                    isParsed = int.TryParse(pop, out in1);
                    if (!isParsed) { iNum[idx] = idx; }
                    else { iNum[idx] = in1; }
                }
            }
            foreach (var item in iNum)
            {
                for (int i = item - 1; i >= 2; i--)
                { if (item % i == 0) isPrime = false; }
                if (!isConsoleRead) { sutil.PrintInColor($"{item.ToString()}"); }
                //  if (isPrime) { sutil.PrintInColor($"==Prime"); }
                //  else { sutil.PrintInColor($"!=Prime"); }
                sutil.PrintInColor($"{((isPrime) ? "==Prime  " : "!=Prime  ")}");
                isPrime = true;
            }
        }
        public static void Chap425MinNPow(Util sutil, bool isConsoleRead = false)
        {
            #region Chap425MinNPow Min of first two; to the power of the third 
            //  Write a program that reads 3 doubles from the console, chooses the minimum among 
            //  the first two, and raises that to the power of the third number. Then, print the result 
            //  to the console. For example:
            //  > 2.0
            //  > 3.0
            //  > 4.0
            //  16
            #endregion
            double[] iDouble = { 3.1, 12.0, 2.000000000000 };

            if (!isConsoleRead) sutil.PrintInColor($"2MinPow U#d: {iDouble[0].ToString()},{iDouble[1].ToString()},{iDouble[2].ToString()}:  ");
            double dMin = 0.0;
            if (iDouble[0] < iDouble[1]) dMin = iDouble[0];
            else                         dMin = iDouble[1];
            sutil.PrintInColor($"{Math.Pow(dMin, iDouble[2]).ToString()}");
        }

        public static void Chap424Infected13(Util sutil, bool isConsoleRead = false)
        {
            #region Chap424Infected13  every 13th anti-mindreader is affected.
            //  At the resistance base, we manufacture anti-mindreaders. An anti-mindreader is a helmet 
            //  that hides all of the signals in your brain to make it impossible for machines to read 
            //  your mind. Unfortunately, our quality control could use some work, and some of the 
            //  anti-mindreaders get infected by a virus as they are built. Based on testing, we know 
            //  that every 13th anti-mindreader is affected. Your program needs to read 3 integers from 
            //  the console (each from a new line) representing production numbers of three anti-mindreaders. 
            //  If the given number represents an unaffected anti-mindreader, output "Nice one!" on a new line. 
            //  If the anti-mindreader is infected by a virus, output "Infected!" so that we can pull that one 
            //  from production. For example:
            //  >14
            //  >26
            //  >39
            //  Nice one!
            //  Infected!
            //  Infected!
            #endregion
            Console.Write("  ");
            int[] iNum = { 14, 26, 39}; string pop = ""; bool isParsed = false; int in1 = 0, idx = 0;
            if (isConsoleRead)
            {  
                while (((pop = Console.ReadLine()) != "Exit") && idx < 3)
                {
                    ++idx;
                    isParsed = int.TryParse(pop, out in1);
                    if (!isParsed) { iNum[idx] = idx; }
                    else { iNum[idx] = in1; }
                }
            }
            foreach (var item in iNum)
            {
                if (!isConsoleRead) sutil.PrintInColor($"{item.ToString()}="); 
                if (item % 13 == 0) sutil.PrintInColor($"Infected!  ");
                else sutil.PrintInColor($"Nice one!  ");
            }
        }

        private static void Chap421EvenOrOdd(Util sutil, bool isConsoleRead = false)
        {
            //  Write a program that reads an integer from the console and outputs "Even" if it is 
            //  even or "Odd" if it is odd. For example:
            //  >4
            //  Even
            string[] sArrInt = { "6", "7", "8", "9", "10", "11", "12", "13", "44" }; int in1 = 0, idx = 0, iCR = -1; string pop = ""; bool isParsed = false;
            if (isConsoleRead)
            {
                while (pop != "Exit")
                {
                    ++iCR;
                    isParsed = int.TryParse(Console.ReadLine(), out in1);
                    if (!isParsed) { sArrInt[iCR] = iCR.ToString(); }
                    else { sArrInt[iCR] = in1.ToString(); }
                    in1 = 0;
                }
            }
            foreach (string item in sArrInt)
            {
                isParsed = int.TryParse(item, out in1);
                if (!isParsed) { in1 = ++idx; }
                if (in1 % 2 == 0) { sutil.PrintInColor($"{ in1.ToString()}=Even, "); }
                else sutil.PrintInColor($"{ in1.ToString()}=Odd, ");
            }
        }

        public static void RunChap4(Util sutil)
        {
            ValidateTime41(sutil);      ValidateBattleshipMove41(sutil); ValidatePassword41(sutil); 
            ValidateName41(sutil);      Chap421EvenOrOdd(sutil);         Chap424Infected13(sutil);
            Chap423ModulusPrime(sutil); Chap425MinNPow(sutil);
        }
    }
    class CSBeginChap5InfinityTypesCastOutRef
    {
        public CSBeginChap5InfinityTypesCastOutRef()
        { Util util = new Util(ConsoleColor.DarkGreen, ConsoleColor.White); RunChap5(util); }
        #region CSBeginChap5InfinityTypesCastOutRef
        //    Infinity...  The day came when I met Infinity. She was from the central resistance base, 
        //  called 'Wonderland'. Every month, Ritchie had been sending the 10 best programmers from 
        //  his base to Wonderland, for participation in the Rust project.    "Wait!" - I 
        //  realised I had just said 'best programmers'. "Does this mean that I'm one of the 
        //  top 10 best programmers that Ritchie has?! Cool!" - I hadn't even thought about 
        //  that until now.    "Are you listening to me Teo?" Infinity stopped my thoughts, 
        //  asking a question.  "Sure, sorry... please continue." I replied.   "This is gonna be hard. 
        //  You'll be in the central base with the best programmers we have. Your mission in the 
        //  Rust project will be top secret; you will not be able to talk about it to your friends."
        //  Friends? She said friends?! Does she know that I have literally nobody on my own here?! 
        //  That I'm completely alone?! That my best friend is a machine that I still don't trust?! 
        //  She must be kidding!   "I looked through your code Teo... And I was surprised at how 
        //  quickly you've improved! Take your first and last programs for example; this is 
        //  astonishing! But at the same time, I've realized that whoever was training you, 
        //  is only choosing data types that match each other. You have never used the type 
        //  conversion technique."   "Type conversion?!" I hadn't heard of that before.
        //  "Let's take some time Teo, and I'll go through this topic with you right now." 
        //  she replied.    Convert me    Infinity began, "Here is a table of built-in types 
        //  in C#. Some of them you already know, but others could be new for you": 
        //              (bytes)
        //  Data Type   Size    Range
        //  byte        1	    0..255
        //  sbyte       1	    -128..127
        //  short       2	    -32,768 .. 32,767
        //  ushort      2	    0 .. 65,535
        //  int         4	    -2,147,483,648 .. 2,147,483,647
        //  uint        4	    0 .. 4,294,967,295
        //  long        8	    -9,223,372,036,854,775,808 .. 9,223,372,036,854,775,807
        //  ulong       8	    0 .. 18,446,744,073,709,551,615
        //  float       4	    -3.402823e38 .. 3.402823e38
        //  double      8	    -1.79769313486232e308 .. 1.79769313486232e308
        //  decimal    16	    -79,228,162,514,264,337,593,543,950,335 .. 79,228,162,514,264,337,593,543,950,335
        //  bool        1	    True or False
        //  char        2   	A unicode character (0 .. 65,535)
        //  "My God! Do C# programmers remember all these types, their sizes and ranges off by heart?!" 
        //  I wondered.   "Most of them... not. What you need to know, is when to use each of those."
        //  "Yeah, for example, byte, short, int - they're almost the same, so why can't I just use 
        //  int all the time?" I naively asked.    "Well... you can! It depends on the constraints 
        //  that you have. If you have 50 000 small integers that you need to send over the network, 
        //  then a byte array can be preferable over an int array, as it will save memory space and 
        //  increase the speed." she explained.    "For now, let's make a deal, that if you have no 
        //  special requirements for the task, then use int for integer numbers and double for 
        //  fractional numbers."    "OK, I will do. I've already been doing this so far..." I replied, 
        //  "Wait - can you please tell me, what does that 'u' mean at the beginning of some of the 
        //  types?"    "u originates from 'unsigned'. If you look carefully, you'll notice that types 
        //  that start with u, do not have negative values. In general, you can use int, uint, short, 
        //  ushort, long and ulong in a very similar way - look at this code example and solve the 
        //  task after it":    byte byteVariable = 12;    short shortVariable = 12;    int intVariable = 12;
        //  long longVariable = 12;    // Use short.Parse long.Parse byte.Parse same as int.Parse
        //  short anotherShort = short.Parse(Console.ReadLine());    var yetAnotherShort = short.Parse(Console.ReadLine());
        //  Console.WriteLine(byteVariable);  // Outputs 12    //  Console.WriteLine(shortVariable); // Outputs 12
        //  Console.WriteLine(intVariable);   // Outputs 12    //  Console.WriteLine(longVariable);  // Outputs 12
        //
        //  C# transformation    Infinity continued, "As you know, in C# every variable has a type. 
        //  It's impossible to change the type of a variable, but you can convert a value from one 
        //  type to another and then store it into a new variable. There are two kinds of type 
        //  conversion: implicit and explicit. Implicit conversions happen without us as programmers 
        //  even noticing it! Here is an example of implicit type conversion":
        //  short shortNumber = 23;
        //  Implicit conversions    //  int intNumber = shortNumber;    //  float someFloat = shortNumber;
        //  double firstDouble = intNumber;  //  double secondDouble = shortNumber;
        //  
        //  Wrong, no implicit conversion    //  intNumber = firstDouble;
        //  "As you'll see, I've created a short variable and assigned it to int, float and double. 
        //  Everything is fine; implicit conversion happens, and you store the value from a variable 
        //  of one type, into a variable of another one." Infinity explained.
        //  "This is a bit confusing!" I exclaimed. "How would I know that implicit conversion between 
        //  two types exists?"  "Good question Teo! There is a general rule: implicit conversion exists 
        //  from 'small' types, to 'bigger' ones, counted by the amount of bytes the type takes. 
        //  For example, there is an implicit conversion from byte to int, but not vice versa; 
        //  from int to byte."  "It makes some sense now... So, if inside an int variable, 
        //  I have a big number - let's say 1000, and I try to store it inside a byte variable, 
        //  it won't fit into the range [0-255]?" I shared my thoughts.  "Yes, that's exactly the reason Teo. 
        //  If I have an int that takes 4 bytes, it's impossible to fit it into a byte type that is only 
        //  1 byte big. Here is a complete C# Implicit Numeric Conversions Table, or you can just use a 
        //  subset that I've picked for you":  
        //  
        //  From Type       To Types
        //  byte            short, ushort, int, uint, long, ulong, float, double or decimal
        //  int             long, float, double or decimal
        //  char            ushort, int, uint, long, ulong, float, double or decimal
        //  float           double
        //  Convert the variable types to make the code compile, and output 10 to the screen. 
        //  You should not change the variable names.  Code!
        //  I started to like her. She was smart, wasn't aggressive and explained things really well. 
        //  Perhaps I wouldn't be so disappointed about working with her if I had no backup plan 
        //  (like returning home with Noname's help).  "Good job Teo! There is one more type conversion 
        //  technique — the explicit conversion. It is also called a cast. A cast is a way of explicitly 
        //  informing the compiler that you intend to make the type conversion, and that you are aware 
        //  that data loss may occur. To perform a cast, specify the type that you are casting to in 
        //  parentheses(), in front of the value or variable to be converted. Here is an example 
        //  where we cast double to int":  double a = 123.95;  int b = (int)a; // Explicit cast
        //  Console.WriteLine(b); // Outputs 123  "This looks powerful!" I proclaimed. "Could you please 
        //  show me some more cast examples?"  "No problem, here you go! Oh, and don't forget about the 
        //  exercise after below the example!":    //  double someDouble = 123.95;
        //  float someFloat = (float)someDouble; // No data loss, someFloat == 123.95   
        //  double anotherDouble = 123.456789098765;  
        //  float anotherFloat = (float)anotherDouble; // Data loss, anotherFloat == 123.4568
        //  long someLong = 123;    int someInt = (int)someLong; // No data loss, someInt == 123
        //  long anotherLong = 112233445566;  int anotherInt = (int)anotherLong; // Data loss, anotherInt == 564295870
        //  int yetAnotherInt = 123;    byte someByte = (byte)yetAnotherInt; // No data loss, someByte == 123
        //  int intToConvert = 1234;    byte resultAsByte = (byte)intToConvert; // Data loss, intToConvert is too big to fit into byte
        //  Multiple conversions in expression are also fine
        //  int intResult = (int)someLong + (int)anotherDouble; // Data Loss, intResult == 246
        //  float floatResult = (float)anotherDouble + (float)someDouble; // Data loss, floatResult == 247.406784
        //  // Conversion of the operation's result is fine as well
        //  int anotherIntResult = (int)(someLong + anotherDouble); // Data Loss, anotherIntResult == 246
        //  float floatResult2 = (float)(anotherDouble + someDouble); // Data loss, floatResult2 == 247.406784
        //
        //  Apply one explicit type conversion (cast) to make the code compile. Do not change any string constants 
        //  or variable names.  Code! Apply several explicit type conversions (casts) to make the code compile. 
        //  Do not change any string constants or variable names.  Code! "So, take this very simple task. 
        //  You have some cupcakes and some people that all want one! You need to share among people fairly, 
        //  so that everyone gets an equal amount of cupcakes. Your program should read an int (amount of cupcakes), 
        //  and another int (amount of people). Then, it should output "Every person should get {amount}
        //  cupcakes"  "This seems simple; you just need to divide 2 numbers... do you want me to write the code?" I asked.
        //  "Go ahead!" she said, a little too positively.  It was clear that something wasn't quite right. 
        //  She was smiling and staring straight at me.  "But... I'll write the code." I uneasily thought to myself. 
        //  int cupcakesCount = int.Parse(Console.ReadLine());
        //  int peopleCount = int.Parse(Console.ReadLine());
        //  double result = cupcakesCount / peopleCount;
        //  Console.WriteLine($"Every person should get {result} cupcakes.");
        //  "Okay, let's run this code with 3 people and 6 cupcakes" she said.
        //  The code ran fine; the result was - "Every person should get 2 cupcakes"
        //  She continued, "But, what if we have only 1 cupcake and 4 people?"
        //  When we tried my code with these parameters, the output was - "Every person should get 0 cupcakes"
        //  "Why is it 0? It should be a quarter (0.25) of a cupcake for everyone!" I firmly yelled, frustrated.
        //  C# is sometimes complicated  "Well, it's because of the type conversion. When you perform an 
        //  arithmetic operation with integers, you'll always get an integer as a result. This works for 
        //  short, byte, float and all other primitive types that we've used.  "What does this mean Infinity?!" 
        //  I asked.  "This means, that you should be careful when dividing int types. C# compiler isn't able 
        //  to understand that you want a float or double as a result, unless you specifically tell it this. 
        //  Otherwise, it will disregard the fractional part. Here, I've prepared some examples":
        //  int a = 9;    int b = 4;     double firstAttempt = a / b;    double secondAttempt = (double)a / b;
        //  double thirdAttempt = a / (double)b;    double nextAttempt = (double)a / (double)b;
        //  double lastAttempt = (double)(a / b);   Console.WriteLine(firstAttempt);  // Outputs 2
        //  Console.WriteLine(secondAttempt); // Outputs 2.25 || Console.WriteLine(thirdAttempt);  // Outputs 2.25
        //  Console.WriteLine(nextAttempt);   // Outputs 2.25 || Console.WriteLine(lastAttempt);   // Outputs 2
        //  Console.WriteLine((int)2.25 );    // Outputs 2    || Console.WriteLine((int) secondAttempt );   // Outputs 2
        //  "As you'll see Teo, there are a lot of ways to cast types. The main rule here is 'if there 
        //  are several operands in the expression, then the type of the result is the largest of the 
        //  operand types'. For example, if you divide int and double, the result is double. If you 
        //  multiply byte and int, the result is int. In tasks that you are going to solve in the future, 
        //  make sure you don't forget to cast to double or float during int division. If you forget, 
        //  you'll lose the fractional part, just like in the cupcakes example!"  
        //  C# Beginner>5 Infinity>Type conversion    info @codeasy.net    Have fun and learn programming with codeasy.net © 2019 
        #endregion
        public static void Chap5Cast2Double(Util sutil, int iDays = 2066, bool isConsoleRead = false)
        {
            //  Write a program that reads from the console, a number of days in an int variable named 
            //  numberOfDays and outputs the same number as years.The output should be a double type. 
            //  For this task, we can assume that there are 365 days in a year.
            //  Example:
            //  >1022
            //  2.8
            Console.Write("  ");
            if (isConsoleRead)
            {
                sutil.PrintInColor($"Please enter Integer Num of Days to Convert to years: ");
                bool isParsed = int.TryParse(Console.ReadLine(), out iDays);
                if (!isParsed) { iDays = 2355; }
            }
            double dYears = (double)iDays / 365.00;
            sutil.PrintInColor($"iDays: ({iDays.ToString()}), dYears: ({dYears.ToString()}).");
        }
        public static void Chap5GNFCDoubleAverage(Util sutil, int count = 5, bool isConsoleRead = false)
        {
            //  Use a method named GetNumbersFromConsole which will read from the console a count of 
            //  int values and return all those values in an int array. Then, output to the console, 
            //  the average of the array values. (Average is a sum of all array elements divided by 
            //  their length value).
            //  Example:
            //  >4
            //  >1
            //  >2
            //  >3
            //  >4
            //  2.5    Code!   Great job!
            List<int> iNum = new List<int> { 4, 6, 10, 20, 40 }; string sIn1 = ""; int idx = -1, in1 = 0, iSum = 0; bool isParsed = false;
            if (isConsoleRead)
            {
                while (sIn1 != "exit")
                {
                    isParsed = int.TryParse(Console.ReadLine(), out in1);
                    if (!isParsed) iNum.Add(++idx);
                    else iNum.Add(in1);
                }
            }
            Console.WriteLine("  "); sutil.PrintInColor($"List<int> = ");
            foreach (int item in iNum)
            { iSum += item; sutil.PrintInColor($"{item}, "); }
            double dAverage = (double)iSum / (double)iNum.Count();
            sutil.PrintInColor($"and the Average is: {dAverage.ToString()}");
        }
        public static void Chap5TypeCast(Util sutil, int count = 23, bool isConsoleRead = false)
        {
            //  Read an integer number from the screen and store it in a short variable named count.
            //  Write a program that prints numbers from 1(including) to count(including), each on a 
            //  new line. But for multiples of two, print 'Save' instead of the number, and for the 
            //  multiples of three print 'Earth'. For numbers which are multiples of both two and three, 
            //  print 'SaveEarth'.    //  Example:
            //  >7
            //  1
            //  Save
            //  Earth
            //  Save
            //  5
            //  SaveEarth
            //  7

            if (isConsoleRead)
            { bool isParsed = int.TryParse(Console.ReadLine(), out count); if (!isParsed) count = 10; }
            StringBuilder sb = new StringBuilder(""); Console.Write("  ");
            for (int i = 1; i < count + 1; i++)
            {
                if (i % 2 == 0) sb.Append($"Save");
                if (i % 3 == 0) sb.Append($"Earth");
                if (sb.Length < 3) { sutil.PrintInColor($"{i.ToString()}, "); }
                else { sutil.PrintInColor($"{sb.ToString()}, "); sb.Clear(); }
            }
        }
        //  codeasy.net    C# Beginner>5 Infinity>Passing parameters to functions    You can have a rest
        //  "Infinity was satisfied with your C# level." Ritchie said to me later that day, after I had 
        //  spoken with Infinity. "So... does this mean that I'll be chosen for the Rust project?!" I asked.
        //  "You're almost there Teo. You'll also need to pass an exam. If you do, then you are The Chosen One. 
        //  You'd better go get some rest. The exam will take place tomorrow, and I've already said 'goodbye' 
        //  to you in my mind, so I want you to pass it."  I nodded and went to the elevator. But instead of 
        //  going to my floor, I headed to Nonames place in the basement.  When I got there, the atmosphere was... 
        //  strange. The lights were flickering, Noname was very quiet and instructions on his multiple 
        //  screens just repeated constantly. What was happening?!  "Hi Noname, how are you?" I asked.  "Hi Teo. 
        //  I can't find the mistake. There is a mistake, I know, but I can't find it. I-I-I can't find a mistake. 
        //  I was looking for a mistake but I-I-I c-c-couldn't find it. No mistake, but there is one. 
        //  Can't find a mistake..." Noname trailed off. "Okay, okay... I get it. You're looking for a mistake, 
        //  but you've had no luck in finding it. I'm sorry to see you in this state, how can I help you?" 
        //  I asked, concerned.  "I have this method, but it doesn't change parameters that I pass to it. 
        //  I don't understand why. Please, look for an article in the local network, maybe you'll find 
        //  something useful about passing parameters to methods." Noname begged me.  "Sure Noname, I will do! 
        //  I'll come back in a little while." I tried to speak optimistically, as I was definitely the only 
        //  optimist in this room. Come to think of it, I was the only human in the room, and I'm not sure 
        //  one can apply 'optimistic' to a machine. Still, I knew I had to try to understand what was so 
        //  tricky about passing parameters to methods... Back to methods. In next to no time, I had found 
        //  an article on the local network about passing parameters to methods. I began to read:
        //  "Let's take a simple exercise of calling a method, PrintAndChangeInteger, and passing 
        //  an int type variable as the parameter." 
        //  static void Main()
        //  {
        //      int exampleInt = 8;
        //      PrintAndChangeInteger(exampleInt);
        //      Console.WriteLine($"int after the method call: {exampleInt}");
        //  }
        //  static void PrintAndChangeInteger(int integerToPrint)
        //  {
        //      integerToPrint++;
        //      Console.WriteLine($"int inside the method call: {integerToPrint}");
        //  }
        //  // Outputs:
        //  // int inside the method call: 9
        //  // int after the method call: 8
        //  The article continued, "You probably expected the output to be":  
        //  int inside the method call: 9
        //  int after the method call: 9
        //  "The trick here, is in how parameters are passed from the Main method to the 
        //  PrintAndChangeInteger method. In the above example, the parameter exampleInt 
        //  was copied. The method PrintAndChangeInteger was therefore working with a copy 
        //  of the exampleInt variable. That's why after the method PrintAndChangeInteger 
        //  returned, the value of exampleInt remained the same. This type of parameter 
        //  passing (when the callee copies the caller's parameters) is called passing by value. 
        //  In this case, if the callee modifies the parameter variable, the effect is not 
        //  visible to the caller.  As you can imagine, there is another type of parameter 
        //  passing; passing by reference. When a parameter variable is passed by reference, 
        //  the caller, and the callee use and change the same variable. If the callee modifies 
        //  this variable, the effect is visible to the caller." C# tutorial: pass by value or 
        //  pass by reference "Built-in types (except string and object) by default, are passed 
        //  by value. This means that almost all types that you know, like int, double, char, etc, 
        //  are passed in this way. If you, as a programmer, want to pass a built-in type by 
        //  reference, you should use the keywords ref or out. You should put them before the 
        //  variable name when you call a method and in the method's parameters list. 
        //  Here is an example":
        //  static void Main()
        //  {
        //      int exampleInt = 8;
        //      //---Place-ref-here----↓
        //      PrintAndChangeInteger(ref exampleInt);
        //      Console.WriteLine($"int after the method call: {exampleInt}");
        //  }
        //  //----------Place-ref-here---------↓
        //  static void PrintAndChangeInteger(ref int integerToPrint)
        //  {
        //      integerToPrint++;
        //      Console.WriteLine($"int inside the method call: {integerToPrint}");
        //  }
        //  // Outputs:
        //  // int inside the method call: 9
        //  // int after the method call: 9
        //  "As you can see in the example, when we passed the parameters by reference, 
        //  the PrintAndChangeInteger method was working with the same variable as the Main method. 
        //  That's why the value of exampleInt changed and the output changed too": 
        //  int inside the method call: 9
        //  int after the method call: 9
        //  Fix the program to make it output the sum of all integers from 1 to 10.
        //  Fix the method 'GetNextFibonacci' that takes two integers, representing two sequential 
        //  Fibonacci numbers, and rearranges their values to get the next one. The Main method 
        //  should read integer n from the console, and then, using GetNextFibonacci, output 
        //  first n Fibonacci numbers, delimited by space. Example:
        //  >10
        //  1 1 2 3 5 8 13 21 34 55    Code!
        //  One more C# joke
        //  "But, 'what about out?' you may ask. The out keyword is very similar to ref. There are two 
        //  main differences":  The variable should be initialized before passing it as a parameter 
        //  when using ref. When using out, initialization is not mandatory.  
        //  static void Main()
        //  {
        //      int exampleInt; // Not initialized (no value assigned)
        //      ChangeIntegerWithRef(ref exampleInt); // Wrong - exampleInt is not initialized
        //      ChangeIntegerWithOut(out exampleInt); // Ok
        //  }
        //  static void ChangeIntegerWithOut(out int integerToChange)
        //  {
        //      integerToChange = 2;
        //  }
        //  static void ChangeIntegerWithRef(ref int integerToChange)
        //  {
        //      integerToChange = 2;
        //  }
        //  The method that takes an out parameter, is required to have a value assigned to this 
        //  parameter. When the method takes a ref parameter, it can leave its value unassigned.
        //  static void Main()
        //  {
        //      int exampleInt = 2;
        //      PrintIntegerWithRef(ref exampleInt);
        //      PrintIntegerWithOut(out exampleInt); // This is ok
        //  }
        //  // This method is ok
        //  static void PrintIntegerWithRef(ref int integerToPrint)
        //  {
        //      Console.WriteLine(integerToPrint);
        //  }
        //  // Wrong!!! When using out - assign a value to integerToPrint
        //  static void PrintIntegerWithOut(out int integerToPrint)
        //  {
        //      Console.WriteLine(integerToPrint);
        //  }
        //  // This method is ok. It changes the value of integerToPrint
        //  static void PrintIntegerWithOutCompiles(out int integerToPrint)
        //  {
        //      integerToPrint = 23;
        //      Console.WriteLine(integerToPrint);
        //  }
        //  The article continued, "And finally, out in the wild, when you are going to 
        //  write real programs that are important, please, remember these simple rules":
        //  Avoid using ref and out where possible. Use function return values instead.
        //  static void Main()
        //  {
        //          int input;
        //          // out/ref usage to get a result from the method
        //          GetNumberFromUserWithOut(out input);
        //          // Return value usage to get a result from the method
        //          input = GetNumberFromUserWithReturnValue();
        //  }
        //  static void GetNumberFromUserWithOut(out int input)
        //  {
        //      input = int.Parse(Console.ReadLine());
        //  }
        //  static int GetNumberFromUserWithReturnValue()
        //  {
        //      return int.Parse(Console.ReadLine());
        //  }
        //  Use ref if you want to use the value of the variable inside the method and may need to change it.
        //  Use out if you want to return additional values from the function. A good example is int.TryParse
        //  
        //  Write a method, named AnalyzeString, that returns bool and takes two parameters, string input and 
        //  out int numberOfZeros. It should calculate the number of zeros in the string and assign it to 
        //  numberOfZeros. If the string passed to the method is empty, it should return false, otherwise, 
        //  true. From the Main method, read the input string from the console, and call AnalyzeString with 
        //  it. If AnalyzeString returns true, print the number of zeros, if it returns false, 
        //  print 'The string is invalid.'  
        //  Example 1:
        //  >He0llo W0000rld!
        //  5
        //  Example 2:
        //  >
        //  The string is invalid.
        //  Slightly modify the method AnalyzeString from the previous task. It should take two parameters, 
        //  string input and ref int numberOfZeros. The method should add the number of zeros that it finds 
        //  in input to numberOfZeros. From the Main method, read an integer count from the console. 
        //  Then, read count strings from the console. Call AnalyzeString for every one of them. 
        //  If all strings are empty, the output should be 'All strings are invalid.' - otherwise, 
        //  output the total number of zeros in all strings. 
        //  Example 1:
        //  >4
        //  >I am y0ur father
        //  >H0ust0n, we have a pr0blem
        //  >Winter is c0mming
        //  >B0nd. James B0nd
        //  7
        //  Example 2:
        //  >2
        //  >
        //  >
        //  All strings are invalid.
        //  "All types that are passed by value, by default, are called Value Types. Types that are passed by 
        //  reference by default, are called Reference Types. You can also remember the difference, by 
        //  remembering that value types hold the value inside itself, but reference types hold only the 
        //  reference to a value. Among the types you have learned, string and array are reference types. 
        //  The rest are value types.Look at this comparison diagram for int and string variables":
        //  Value types and reference types
        //  The article finished with an example. "Here's an example, where we pass an array to the method, 
        //  and as an array is a reference type, it is not copied; the method works with the same array as 
        //  the caller and changes it": 
        //  static void Main()
        //  {
        //      int[] exampleArray = { 1, 2, 3 };
        //      PrintAndChangeArray(exampleArray);
        //      Console.WriteLine($"Array after the method call:");
        //      for (int i = 0; i < exampleArray.Length; i++)
        //      {
        //          Console.Write($"{exampleArray[i]} ");
        //      }
        //  }
        //  
        //  static void PrintAndChangeArray(int[] arrayToPrint)
        //  {
        //          Console.WriteLine($"Array inside the method call:");
        //          arrayToPrint[0] = 12;
        //          for (int i = 0; i < arrayToPrint.Length; i++)
        //          {
        //              Console.Write($"{arrayToPrint[i]} ");
        //          }
        //          Console.WriteLine();
        //  }
        //  // Outputs:
        //  // Array inside the method call:
        //  // 12 2 3
        //  // Array after the method call:
        //  // 12 2 3
        //  //  I really liked the article. It was clear and easy to understand. After reading everything, 
        //  //  I ran to the basement to fix Noname's module. What I found there wasn't the easiest task in 
        //  //  the world... but I knew I'd fix it!



        //  C# lesson done

        //  C# Beginner>5 Infinity>Passing parameters to functions    info @codeasy.net    Have fun and learn programming with codeasy.net © 2019    */

        //  Write a method, named AnalyzeString, that returns bool and takes two parameters, string input and 
        //  out int numberOfZeros. It should calculate the number of zeros in the string and assign it to 
        //  numberOfZeros. If the string passed to the method is empty, it should return false, otherwise, 
        //  true. From the Main method, read the input string from the console, and call AnalyzeString with 
        //  it. If AnalyzeString returns true, print the number of zeros, if it returns false, 
        //  print 'The string is invalid.'  
        //  Example 1:
        //  >He0llo W0000rld!
        //  5
        //  Example 2:
        //  >
        //  The string is invalid.
        //  Slightly modify the method AnalyzeString from the previous task. It should take two parameters, 
        //  string input and ref int numberOfZeros. The method should add the number of zeros that it finds 
        //  in input to numberOfZeros. From the Main method, read an integer count from the console. 
        //  Then, read count strings from the console. Call AnalyzeString for every one of them. 
        //  If all strings are empty, the output should be 'All strings are invalid.' - otherwise, 
        //  output the total number of zeros in all strings. 
        //  Example 1:
        //  >4
        //  >I am y0ur father
        //  >H0ust0n, we have a pr0blem
        //  >Winter is c0mming
        //  >B0nd. James B0nd
        //  7
        //  Example 2:
        //  >2
        //  >
        //  >
        //  All strings are invalid.
        //  
        //  Write a program that first creates an int array, with a size of 10, and reads the number 
        //  of commands from the user. After that, the program should read every command that the user 
        //  inputs. 
        //  Commands are represented by one string and could be of 2 types: add1 index or add0 index. 
        //  These commands should change the corresponding array cell to 1 or 0. For example, the command 
        //  add1 3 puts 1 to the array cell with an index of 3. After all the commands from the user are 
        //  executed, print the array to the screen. Use methods PutOneAtIndex and PutZeroAtIndex for 
        //  command execution. Example:
        //  >4
        //  >add1 1
        //  >add0 1
        //  >add1 9
        //  >add1 5
        //  0 0 0 0 0 1 0 0 0 1
        //  Tip: To convert one char from string to int, use int.Parse(myString[index].ToString())*/
        public static void ReverseList(Util tilz, int arrCount = 12, bool isConsoleRead = false)
        {
            //  This program is supposed to reverse an array and then output it to the screen. But... 
            //  something has gone wrong. Fix it! (Do not change the way that the array is output!). Example:
            //  >4
            //  >1
            //  >2
            //  >3
            //  >4
            //  4 3 2 1        Code!
            List<int> iNum = new List<int> { 4, 6, 8, 10, 12, 14, 16, 18, 20, 22 };
            string si = ""; int in1 = 0, idx = -1; Console.Write(" ");
            if (isConsoleRead)
            {
                iNum.Clear(); ++idx;
                while ((si = Console.ReadLine()) != "exit")
                {
                    bool isParsed = int.TryParse(Console.ReadLine(), out in1);
                    if (isParsed) iNum.Add(in1);
                    else iNum.Add(idx);
                }
            }
            else
            {
                tilz.PrintInColor("Orig: ");
                foreach (var item in iNum)
                { tilz.PrintInColor($"{ item.ToString()}, "); }
            }
            tilz.PrintInColor("RevL: ");
            for (int i = iNum.Count() - 1; i >= 0; i--)
            { tilz.PrintInColor($"{ iNum[i].ToString()}, "); }
        }
        //  Fix the program to make it output the sum of all integers from 1 to 10.
        //  Fix the method 'GetNextFibonacci' that takes two integers, representing two sequential 
        //  Fibonacci numbers, and rearranges their values to get the next one. The Main method 
        //  should read integer n from the console, and then, using GetNextFibonacci, output 
        //  first n Fibonacci numbers, delimited by space. Example:
        //  >10
        //  1 1 2 3 5 8 13 21 34 55    Code!  Done!

        public static void Sum1to10(Util utl, int cnrl = 10, bool isConsoleRead = false)
        {
            Console.Write("  "); int iSum = 0;
            for (int i = 1; i < cnrl + 1; i++)
            { utl.PrintInColor($"{i.ToString()}, "); iSum += i; }
            utl.PrintInColor($"and sum: {iSum.ToString()}.");
        }
        public static void RunArrFill(Util utl, bool isConsoleRead = false)
        {
            // Write a program that first creates an int array, with a size of 10, and reads the 
            //  number of commands from the user. After that, the program should read every command 
            //  that the user inputs. Commands are represented by one string and could be of 2 types: 
            //  add1 index or add0 index. These commands should change the corresponding array cell 
            //  to 1 or 0. For example, the command add1 3 puts 1 to the array cell with an index of 3. 
            //  After all the commands from the user are executed, print the array to the screen. 
            //  Use methods PutOneAtIndex and PutZeroAtIndex for command execution. Example:
            //  >4
            //  >add1 1
            //  >add0 1
            //  >add1 9
            //  >add1 5
            //  0 0 0 0 0 1 0 0 0 1
            /*Tip: To convert one char from string to int, use int.Parse(myString[index].ToString())*/
            List<int> iArr = new List<int>(); int in1 = 0, idx = 0; Console.Write(" ");
            List<string> sInput = new List<string> { "add1 1", "add0 1", "add1 9", "add1 5" };
            for (int i = 0; i < 10; i++)            {     iArr.Add(0);    }
            foreach (string item in sInput)
            {
                in1 = int.Parse(item[3].ToString()); 
                idx = int.Parse(item[5].ToString());
                iArr = PutOneAtIndex( utl, iArr, idx, in1 );
            } utl.PrintInColor($"iArr: ");
            foreach (int item in iArr)
            {
                utl.PrintInColor($"{item.ToString()}, ");
            }
        } 
        public static List<int> PutOneAtIndex(Util utl, List<int> iArr, int idx = 0, int num = 0, bool isConsoleRead = false ) 
        {
            iArr[idx] = num; return iArr;
        }
        public static List<int> PutZeroAtIndex(Util utl, List<int> iArr, int idx = 0, int num = 0, bool isConsoleRead = false) 
        { iArr[idx] = num; return iArr; }
         public static void RunAnalyze(Util utl, bool isConsoleRead = false)
        {
            //  Write a method, named AnalyzeString, that returns bool and takes two parameters, 
            //  string input and out int numberOfZeros. It should calculate the number of zeros 
            //  in the string and assign it to numberOfZeros. If the string passed to the method 
            //  is empty, it should return false, otherwise, true. From the Main method, read the 
            //  input string from the console, and call AnalyzeString with it. If AnalyzeString 
            //  returns true, print the number of zeros, 
            //  if it returns false, print 'The string is invalid.'
            //  Example 1:
            //  >He0llo W0000rld!
            //  5
            //  Example 2:
            //  >
            //  The string is invalid.
            //  
            //  Slightly modify the method AnalyzeString from the previous task. 
            //  It should take two parameters, string input and ref int numberOfZeros. 
            //  The method should add the number of zeros that it finds in input to numberOfZeros. 
            //  From the Main method, read an integer count from the console.
            //  Then, read count strings from the console. Call AnalyzeString for every one of them. 
            //  If all strings are empty, the output should be 'All strings are invalid.' 
            //  - otherwise, output the total number of zeros in all strings.
            //  Example 1:
            //  >4
            //  >I am y0ur father
            //  >H0ust0n, we have a pr0blem
            //  >Winter is c0mming
            //  >B0nd.James B0nd
            //  7
            //  Example 2:
            //  >2
            //  >
            //  >
            //  All strings are invalid.
            Console.Write(" ");
            List<string> sInput1 = new List<string> { "I am y0ur father", "H0ust0n, we have a pr0blem", "Winter is c0mming", "B0nd.James B0nd" };
            List<string> sInput2 = new List<string> { "", "", "" }; int numberOfZeros = 0, idx = -1, in1 = 0;string si = "";
            if (isConsoleRead)    {    sInput1 = utl.ReadStrings(utl, sInput1, "Enter some strings with 0s");    }
            bool validString = false;
            foreach (string item in sInput1)
            {    
                string sItem = item;
                if (item != "" ) utl.PrintInColor($"Orig: {item}, ");
                validString = AnalyzeString(utl, ref sItem, ref numberOfZeros);
                if (validString) utl.PrintInColor($"New: {sItem}, ");
            }
            if (!validString) utl.PrintInColor($"All strings are invalid.");
            else utl.PrintInColor($", numberOfZeros: {numberOfZeros.ToString()}. ");
            validString = false;
            if (isConsoleRead) { sInput2 = utl.ReadStrings(utl, sInput2, "Enter some strings with 0s"); }
            foreach (string item in sInput2)
            {    
                string sItem = item;
                if (item != "") utl.PrintInColor($"Orig: {item}, ");
                validString = AnalyzeString(utl, ref sItem, ref numberOfZeros);
                if (validString) utl.PrintInColor($"New: {sItem}, ");
            }
            if (!validString) utl.PrintInColor($"All strings are invalid.");
            //  "All types that are passed by value, by default, are called Value Types. 
            //  Types that are passed by reference by default, are called Reference Types. 
            //  You can also remember the difference, by remembering that value types hold 
            //  the value inside itself, but reference types hold only the reference to a value. 
            //  Among the types you have learned, string and array are reference types. 
            //  The rest are value types. Look at this comparison diagram for int and string variables":
            //  int===>10    string===>reference===>"abc"
        }
        public static bool AnalyzeString(Util utl, ref string input, ref int numberOfZeros, bool isConsoleRead = false)
        {
            bool validStrings = false; StringBuilder sb = new StringBuilder("");
            if (input == "") return validStrings;
            foreach (char item in input)
            {
                if (item == '0') { ++numberOfZeros; validStrings = true; sb.Append("o"); }
                else sb.Append(item.ToString());
            }
            input = sb.ToString();
            return validStrings;
        }
        public static void DuplicateFinder(Util utl,bool isConsoleRead = false)
        {
            string pop = "ObjectiveC, Swift, C++, Core Bluetooth framework, C#, ASP.NET-Core/WebForms/MVC/Blazor, WebAPIs, JavaScript, TypeScript, ECMAScript6+, NodeJS, AngularJS, Bootstrap, React, JQuery, AJAX, tSQL, ADONET/Entity Framework, SQLServer, MySQL, Postgres, MongoDB, Hadoop, HTML, CSS_LESS, SQLAzure-Blobs-WebRoles-ServiceBus-VMs, AWS-Lambda/RDS/DDB/CW/EC2/SQS/SNS/Cognito/Kinesis, Heroku, Powershell/Bash, ODATA/REST/SOAP Web Services/APIs, LINQ, Reactive-Extensions.Net, C++, Java, Wordpress/PHP, Python, Unity3D, VB.Net, F#, Linux, Visual Studio, SDLC, SOLID Patterns, Adobe Suite, Photoshop, Word, Excel, XML/Salting/Hashing, TDD/Pair&Mob, HTTPS/SSL/TCP/IP, JMS, EMS, Web Crawl, Github. Scrum, Agile, Fiddler, Continuous-Integration/Delivery/Deployment, Lifelong Learner, Mission-Critical Micro/Service Oriented Architect/Operator/Tester/Troubleshooter, Self Driven/Managed/Motivated Autonomous/Independent Team Playing Coordinator, On-Time Multi Tasking, Collaborative Proactive Problem Solving, High-Quality Results/Detail Oriented, Highly Enthusiastic, Scalable, Back-End Solution Engineer, Post-To, Corrector of Websites/Social Media, Intensely Focused Customer Service Purveyor, Client-Requested Content Works Everywhere, SQL Query Optimizer, Caching/Performance Monitoring/Profiling Guru, Network Security Analyst, Project Leader/Owner, Sophisticated Web Interface Designer, Big Picture Seeing, Clean/Efficient/Expert/OOP Coder, Guidance Provider, Convertor of Complexity Into Simplicity, Test-Frame-Worker, Business To Technical Requirement Translator skills";
            char[] delimiterChars = { ' ', ',', ':', '/', ';', '-', '(', ')' };
            List<string> individualString = new List<string>(pop.Split(delimiterChars,StringSplitOptions.RemoveEmptyEntries).ToList<string>());
            List<int> dupIndex = new List<int>(999999);
            int isc = individualString.Count(), dups= 0;
            for (int i = 0; i < isc; i++)
            {
                if (i + 1 < isc)
                {
                    for (int j = i + 1; j < isc; j++)
                    {
                        if (individualString[i] == individualString[j] && !dupIndex.Contains(j) )
                        { utl.PrintInColor($"dup={individualString[j]}@@, "); ++dups; dupIndex.Add(j); }
                    } 
                }
            }
            if (dups == 0) utl.PrintInColor("no dups!!");
            //await sum1to10async();
        }
        //  private static async Task Sum1To10Async(Util utl, bool isConsoleRead = false)
        //  {
        //      var stopwatch = new Stopwatch();
        //      stopwatch.Start();
        //  
        //      // this task will take about 2.5s to complete
        //      var sumTask = GetPrimesAsync();
        //  
        //      // this task will take about 4s to complete
        //      var wordTask = SlowAndComplexWordAsync();
        //  
        //      // running them in parallel should take about 4s to complete
        //      await Task.WhenAll(sumTask, wordTask);
        //  
        //      // The elapsed time at this point will only be about 4s
        //      utl.PrintInColor($"Time elapsed when both complete..." + stopwatch.Elapsed);
        //  
        //      // These lines are to prove the outputs are as expected,
        //      // i.e. 300 for the complex sum and "ABC...XYZ" for the complex word
        //      utl.PrintInColor($"Result of complex sum = " + sumTask.Result);
        //      utl.PrintInColor($"Result of complex letter processing " + wordTask.Result);
        //  
        //      
        //  }
        public static void RunChap5(Util sutil)
        {
            Chap5TypeCast(sutil);   Chap5GNFCDoubleAverage(sutil); Chap5Cast2Double(sutil); 
            ReverseList(sutil, 8);         Sum1to10(sutil, 14);    
            RunAnalyze(sutil);      RunArrFill(sutil);             DuplicateFinder(sutil);
        }
        }
    class CSBeginningChapter6SwitchCSTest
    {
        public CSBeginningChapter6SwitchCSTest()
        {
            Util utl = new Util(ConsoleColor.DarkMagenta, ConsoleColor.White);
            RunChap6Switch(utl);
        }
        //  C# Beginner>6 The truth>Switch statement   Tired while learning c sharp    You Forgot One 
        //  Thing.  Helping Noname one more time (again) was starting to wear on me. As was beginning 
        //  to happen too often, the minute I thought I was free to get a little rest, someone else had 
        //  other plans. Sara cornered me just as I was opening the door to my room.  "Hi, Teo! I heard 
        //  that you were chosen for the Rust project? Congratulations!"  Sara said.  "Thanks Sara," I 
        //  said, " but can we talk another time? I need to rest..."  "Oh, sure," she said sarcastically, 
        //  "I didn't realize you wanted to fail your exam. What do you think is more important: sleep, or 
        //  passing the exam and getting a ticket to Wonderland?" Of course, another set of tasks or lessons 
        //  to be had. Endless work around the base. To be honest, all I was looking forward to was Noname 
        //  sending me back to my normal life. But I knew how to play my role, and I replied "I hope this 
        //  thing you want to tell me is really that important." I answered. "It is. In short: we fed a code 
        //  analyzer all the code that you have written so far, and it determined that you have never used a 
        //  switch statement," Sara explained.  "Of course I've never used a switch statement, I don't even 
        //  know what it is!"  "You'd better learn it! At the exam, Infinity can (and often does) ask about 
        //  it!"  "Ok, let me just take some coffee. Then I learn about switch statements, and everyone 
        //  leaves me alone so I can get some sleep."  Multiple Choices.  "Let's start with a simple program 
        //  where the user inputs questions to the console," Sara started. "The program should do the following:
        //  when the user asks "Do you love me?"        Answer with "I love you!"
        //  when the user asks "How do I look today?"   Answer with "You look awesome!" 
        //  when the user prints something else.        Answer "I have no clue what you are talking about." 
        //  Can you write this program for me?"
        //  Despite my distinct lack of sleep, I managed to write it in one minute flat.
        //  var question = Console.ReadLine();
        //  if (question == "Do you love me?")
        //  {
        //      Console.WriteLine("I love you!");
        //  }
        //  else if (question == "How do I look today?")
        //  {
        //      Console.WriteLine("You look awesome!");
        //  }
        //  else
        //  {
        //      Console.WriteLine("I have no clue what you are talking about.");
        //  }
        //  "Great, Teo! As you know, an if statement is used when you have two logical 
        //  choices and your program needs to choose between them. In this case, you have 
        //  three logical choices, and because of that, you had to use if several times. 
        //  You can probably guess where this is going - this is why the switch statement 
        //  was invented. The switch statement is used to perform different actions based 
        //  on different conditions. Here's what your code looks like when we use the switch 
        //  statement instead of an if:"
        //  var question = Console.ReadLine();
        //  switch (question)
        //  {
        //      case "Do you love me?":
        //          Console.WriteLine("I love you!");
        //          break;
        //      case "How do I look today?":
        //          Console.WriteLine("You look awesome!");
        //          break;
        //      default:
        //          Console.WriteLine("I have no clue what you are talking about.");
        //          break;
        //  }
        //  The most important c# concept  "I guess this was important enough to keep me out 
        //  of bed a bit longer!" I said. "Why hasn't anyone told me about switch statements 
        //  before now?" I asked.  "To be honest, Teo, we purposely wanted you to NOT learn 
        //  the most powerful aspects of C# because we didn't trust you. But then you started 
        //  learning things outside the base, like the if statement from that guy from the C 
        //  gang, and we didn't have much of a choice." "Thanks, I suppose," I said.
        //  "Now back to the switch statement. Here is its general form:"
        //  switch (someValue)
        //  {
        //      case value1:
        //          // Execution goes here if someValue == value1
        //          break;
        //      case value2:
        //          // Execution goes here if someValue == value2
        //          break;
        //      default:
        //          // Execution goes here if someValue is different from all the
        //             options above
        //          break;
        //  }
        //  "How does it work exactly, Sara?" I asked.  "First, someValue is calculated. 
        //  Then, it's compared with each of the case values. If there's a match, the associated 
        //  block of code is executed. If there is no match, the default block is executed."
        //  "Okay," I replied, "That seems easy enough. What does break mean?"  "break is used to 
        //  indicate that the program should stop checking different case options and break, or 
        //  exit, out of the switch statement. Here is your first task using a switch statement."
        //  Code!
        //  Write a program that reads the user's name from the console first. Then, according to 
        //  the name, it performs one of three actions:  
        //  If the name is "admin", the program should print "Welcome! Full access granted."
        //  If the name is "user", the program should print "Welcome! Limited access granted."
        //  If the name is not "user" or "admin", the program should print "Unknown user."
        //  Use a switch statement in your solution. For example:
        //  >admin            //  Welcome! Full access granted. Code!
        //  "Good work!" Sara said.  "Yeah, this isn't that hard, actually," I answered.
        //  "Ok then, let's go to something a bit harder. First of all, there can be more than one 
        //  line of code in every case block. Second, the type of variable that you check in a 
        //  switch doesn't have to be a string; it could be, for instance, an int. Here's a more 
        //  complicated example."
        //  
        //  int errorCode = int.Parse(Console.ReadLine());
        //  switch (errorCode)
        //  {
        //      case 0:
        //          Console.WriteLine("Don't worry, everything is fine.");
        //          break;
        //      case 1:
        //          Console.WriteLine("Unrecognised object detected!");
        //          TerminateObject();
        //          SendEmailToAdmin();
        //          break;
        //      case 2:
        //          Console.WriteLine("Transfunction module update needed.");
        //          UpdateTransfunctionModule();
        //          break;
        //      default:
        //          Console.WriteLine("Unknown error code.");
        //          break;
        //  }
        //  "One more useful thing to know: the default can be omitted (the same as else in the 
        //  if statement)," Sara added. 
        //  C# Beginner>6 The truth>Switch statement    info@codeasy.net    Have fun and learn programming with codeasy.net © 2019      
        public static void Chap6SubsitutionalCipher(Util utl, bool isConsoleRead = false)
        {
            #region    We like substitutional ciphers at the Resistance Base!
            //  CODE! We like ciphers at the resistance base. For internal 
            //  communication, we use a substitutional cipher. The idea is very simple: every letter 
            //  in the incoming message is substituted with a different symbol. Your task is to partially 
            //  encode a string message given to your program as an input and output the encoded message. 
            //  Leave all letters except for the following: 
            //  F and f: replace with !    //  G and g: replace with @    //  T and t: replace with #
            //  H and h: replace with $    //  Y and y: replace with %    //  B and b: replace with ^  //  For Example:
            //  >After seeinG my dark Future, I can't continue living in the Boring past.
            //   A!#er seein@ m% dark !u#ure, I can'# con#inue livin@ in #$e ^orin@ pas#. 
            #endregion
            string sInput = "After seeinG my dark Future, I can't continue living in the Boring past.";
            StringBuilder sb = new StringBuilder("After: "); int idx = -1; Console.WriteLine();
            while (++idx < sInput.Length)
            {
                switch (sInput[idx])
                {
                    case 'F': case 'f': sb.Append("!"); break;
                    case 'G': case 'g': sb.Append("@"); break;
                    case 'T': case 't': sb.Append("#"); break;
                    case 'H': case 'h': sb.Append("$"); break;
                    case 'Y': case 'y': sb.Append("%"); break;
                    case 'B': case 'b': sb.Append("^"); break;
                    default: sb.Append(sInput[idx]); break;
                }
            }
            utl.PrintInColor($"Substitutional cipher: f:!, g:@, t:#, h:$, y:%, b:^ || ");
            utl.PrintInColor($"Befor: {sInput}\n");
            utl.PrintInColor($"                                                       ");
            utl.PrintInColor($"{sb.ToString()}\n");
        }
        public static void Chap6DeliveryDronesSwitch(Util utl, bool isConsoleRead = false)
        {
            //  CODE!
            //  At our resistance base, we have delivery drones. These are very simple flying robots that know 
            //  only how to deliver boxes to the destination point. After some time, the drones begin to break. 
            //  They'll move forward and then backward. We still keep a drone in circulation as long as it moves 
            //  forward more often than backward. The drones log all their actions the console until it reaches 
            //  the destination.  Your program should print the distance from the starting point to the 
            //  destination. If, at some point, the drone performs more steps backward than forward, 
            //  the program should terminate the delivery and output "Go back to base. Delivery failed." 
            //  to the console. You can assume that the drone flies along a straight line with no turns. 
            //  If the drone outputs "forward", it means that it has moved 10 meters forward. Otherwise, 
            //  if it moved backward, the output will be "backward". When the drone reaches the destination 
            //  point, it prints "Destination reached." to the console In this case, the program should output 
            //  the distance from the starting point to the destination. Use a switch to check the input from 
            //  the drone.  Example 1:
            //  >forward    >forward    >backward    >forward    >forward    >Destination reached.    30
            //              Example 2:
            //  >forward    >backward    >backward    Go back to base. Delivery failed.        CODE!
            List<string> sDroneDir1 = new List<string> { "forward", "forward", "backward", "forward", "forward", "forward", "forward", "forward", "forward" };
            List<string> sDroneDir2 = new List<string> { "forward", "backward", "backward" }; int distance = 0;
            List<string> sDroneDir3 = new List<string> { "forward", "forward", "backward", "forward", "forward", "forward", "backward", "forward", "forward" };
            List<string> sDroneDir4 = new List<string> { "forward", "forward", "backward", "forward", "forward", "forward" };
            List<string> sDroneDir5 = new List<string> { "forward", "backward", "backward", "backward", "backward", "backward" };
            StringBuilder sb = new StringBuilder("");
            WriteDistance(utl, sDroneDir1); WriteDistance(utl, sDroneDir2);
            WriteDistance(utl, sDroneDir3); WriteDistance(utl, sDroneDir4);
            WriteDistance(utl, sDroneDir5);
        }
        public static void WriteDistance(Util utl, List<string> sInput, bool isConsoleRead = false)
        {
            Console.Write("  "); int distance = 0; string sFail = "Go back to base. Delivery failed.  ";
            foreach (string item in sInput)
            {
                switch (item)
                {
                    case "forward": distance += 10; break;
                    default: distance -= 10; break;
                }
                utl.PrintInColor($"{item}, ");
            }
            if (distance < 0)
                utl.PrintInColor($"{sFail}");
            else
                utl.PrintInColor($"Destination reached: {distance.ToString()}.");
        }
        public static void Chap6RobotMove(Util utl, bool isConsoleRead = false)
        {
            //  Robot CODE!
            //  The old walking drone tracking system just broke yesterday, and you need to write a new one.
            //  The drone tracking system should output the coordinates of the drone once it's reached its 
            //  destination. The drone starts its movement at the bottom left corner of the field with 
            //  coordinates [0, 0], and can move up, or right, or both (diagonal; see picture). 
            //  Your program should constantly read where the drone has moved until it writes 
            //  "Destination reached." Then your program should output the coordinates of the drone in the 
            //  format "[droneX, droneY]", where droneX is the x coordinate of the drone and droneY is its 
            //  y coordinate.  Messages reporting drone movement that your program needs to read from the 
            //  console have the following format:  
            //  up - movement up; y increases by one.
            //  right - movement right; x increases by one.
            //  diag - diagonal movement; x and y both increase by one.
            //  For example:    //  >up    //  >right    //  >diag    //  >up    //  >diag  //  >Destination reached.
            //  [3, 4]    Drone movement in c sharp course
            //  At that point, I was really exhausted. Sara looked happy because I had managed to solve all 
            //  of her tasks for the switch statement, and I was happy because I could finally get some sleep.
            //  Go go go!
            List<string> sDroneMove = new List<string> { "up", "right", "diag", "diag", "diag", "diag", "diag", "diag", "diag", "up", "diag", "Destination reached" };
            int x = 0, y = 0; Console.WriteLine();
            foreach (string item in sDroneMove)
            {
                switch (item)
                {
                    case "up": ++y; break;
                    case "right": ++x; break;
                    case "diag": ++x; ++y; break;
                    default:
                        break;
                }
                utl.PrintInColor($"{item}, ");
            }
            utl.PrintInColor($"[{x.ToString()}, {y.ToString()}].  ");
        }
        public static void chap6Easy(Util utl, bool isConsoleRead = false)
        {
            //  Multiple Choices.  "Let's start with a simple program 
            //  where the user inputs questions to the console," Sara started. "The program should do the following:
            //  when the user asks "Do you love me?"        Answer with "I love you!"
            //  when the user asks "How do I look today?"   Answer with "You look awesome!" 
            //  when the user prints something else.        Answer "I have no clue what you are talking about." 
            //  Can you write this program for me?"        
            List<string> question = new List<string> { "Do you love me?", "How do I look today?", "Something else?" };
            int idx = -1;
            foreach (string item in question)
            {
                switch (item)
                {
                    case "Do you love me?": utl.PrintInColor($"Q: {item}, A: I love you!  "); break;
                    case "How do I look today?": utl.PrintInColor($"Q: {item}, A: You look awesome!  "); break;
                    default: utl.PrintInColor($"I have no clue what you are talking about.  "); break;
                }
            }
        }
        public static void Chap6NameSwitch(Util utl, bool isConsoleRead = false)
        {
            //  Write a program that reads the user's name from the console first. Then, according to 
            //  the name, it performs one of three actions:  
            //  If the name is "admin", the program should print "Welcome! Full access granted."
            //  If the name is "user" , the program should print "Welcome! Limited access granted."
            //  If the name is not "user" or "admin", the program should print "Unknown user."
            //  Use a switch statement in your solution. For example:
            //  >admin            //  Welcome! Full access granted. Code!
            List<string> names = new List<string> { "admin", "user", "hackr" }; Console.WriteLine();
            foreach (string name in names)
            {
                switch (name)
                {
                    case "admin": utl.PrintInColor($"N: {name} A: Welcome! Full access granted.  "); break;
                    case "user": utl.PrintInColor($"N: {name} A: Welcome! Limited access granted.  "); break;
                    default: utl.PrintInColor($"N: {name} A: Freak Off Unknown user.  "); break;
                }
            }
        }
        //  C# Beginner>6 The truth>C# test   End of the beginning
        //  I had been waiting so long for the day to come. Noname finally signaled me over the 
        //  local network that it was ready to send me back to the past. It was hard to believe! 
        //  No more lasers trying to kill me, no more C# cramming or world salvation. Going back 
        //  to my calm life, to the world that I understood. I wasn't sure if I could take anything 
        //  from the future back with me, but I'd been collecting a little bag of things that I 
        //  found interesting from this time. Some viruses, my favorite coffee cup, and one of 
        //  the books about human-machine relations. I was done with the future for now - time to go!
        //  Ritchie must have felt it somehow and knew that I wanted to disappear. He was just about 
        //  to knock on my door when I swung it open, ready to leave everything there behind.
        //  "Hi, Teo! How's your preparation for the exam going? Did you have a good sleep?" He asked.
        //  "Fine, thank you, Ritchie. But I really need to use the bathroom. Can you please let me by?"
        //  "Sure thing, Teo, no problem. As soon as you explain me why you're taking this bloody bag 
        //  to the toilet? Is it filled with rolls of toilet paper? Or maybe it's full of toothpaste? 
        //  Let me check!" Ritchie made a grab in the direction of the bag.  "Oh, I forgot that I still 
        //  had it with me. Just some snacks for later - no need to check it. Let me just leave it here." 
        //  I tossed the bag on the bed and closed the door.  He didn't show any signs of moving anywhere. 
        //  "Ritchie, what did you want to discuss? I'm guessing you didn't come by just to check how my 
        //  preparation was going?"  "You're a clever one," he replied. "I'm here to accompany you to the 
        //  Exam. It's time!"  "Wow, now? Right now? Not even time for a bathroom break?"  "No Teo, the 
        //  time has come. Follow me," he said, adding quietly, "They get angry if you make them wait."
        //  C charp test
        //  Solve it. All of it.
        //  The room was empty except for two pieces of furniture in the center: one table and one chair. 
        //  Infinity was standing near the table and gave me a nod as I walked in. "Hi Teo, nice to see you," 
        //  she said. "This exam is just a formality; we all know that you're a good programmer. 
        //  However, it's an important formality. This time you can only use what you have in your head. 
        //  No local network access or help from other resistance base members. You must solve these tasks 
        //  without any help. As soon as you finish, you'll get your ticket to Wonderland. Go ahead!"  
        //  CODE!
        public static void Chap6NearestInt(Util utl, bool isConsoleRead = false)
        {
            //  Write a program to check which of three given integers is the nearest value to 23. 
            //  Read three numbers, each from a new line, and output the result to another new line as well. 
            //  For example:            //  >153    //  >-2    //  >66    //  -2
            List<int> iIn = new List<int> { 153, -2, 66 }; List<int> iDiff = new List<int>();int min = 0;
            foreach (int item in iIn)    { utl.PrintInColor($"{item.ToString()}, ");    int pop = item - 23; iDiff.Add(Math.Abs(pop));   }
            if (iDiff[0] < iDiff[1])
                min = 0;
            else
                min = 1;
            if (iDiff[2] < min)
                min = 2;
            utl.PrintInColor($"Nearest: {iIn[min].ToString()}.  ");
        }
        public static void Chap6DrawRhombus(Util utl, int count = 3, bool isConsoleRead = false)
        {
            //  CODE!
            //  Write a program that draws a rhombus using ASCII art and a '#' sign. Every row should contain 
            //  an odd number of signs, starting from one. Read from the console the size of the longest row 
            //  of the rhombus. Call the variable size and declare it with var. It is guaranteed to be an 
            //  odd number to make your rhombus look nice. (Note that all unused space to the left and right 
            //  of the rhombus should be filled with spaces.)
            //  Example 1:
            //  >3
            //  # 
            //  ###
            //  # 
            //  Example 2:
            //  >5
            //  #
            //  ### 
            //  #####
            //  ### 
            //  #  
            Console.Write("  ");
            for (int i = 1; i < count +1; i+=2)
            {
                utl.PrintInColor($"{utl.TextRepeater("#", i)}{utl.TextRepeater(" ", count - i)}\n");
            }
            for (int i = count - 2; i >= 0; i -=2)
            {
                utl.PrintInColor($"{utl.TextRepeater("#", i)}{utl.TextRepeater(" ", count - i)}\n");
            }
        }
        public static void Chap6StringSplit(Util utl, bool isConsoleRead = false)
        {
            //  At the resistance base, we are creating a dictionary of all words. The previous 
            //  dictionary was accidentally lost and is unrecoverable. The process of filling up 
            //  the dictionary is very simple: we take random sentences, divide them into separate 
            //  words, and add each to the dictionary. Your task is to write a program that takes 
            //  a string as an input, separates that string by words, and outputs every word on a 
            //  separate line. You can assume that word separators are these symbols: ' ' ',' '.' '!' '?'. 
            //  Your program should not change any spelling or casing in the words. Be aware that the 
            //  string can start with separators, and it can contain any number of separators between 
            //  two words, as in the example below.            //  For example:"??"," ,, ", "!!","!", " "
            string sInput = "??Wow!!John ,, haven't seen you for ages!";
            string[] separatingStrings = { "??", " ,, ", "!!", "!", " " };
            string[] sOutput = sInput.Split(separatingStrings, StringSplitOptions.RemoveEmptyEntries);
            utl.PrintInColor($"Split (Original): {sInput}, Out: ");
            foreach (string item in sOutput)
            {
                utl.PrintInColor($"{item}, ");
            }
            //  >??Wow!!John ,, haven't seen you for ages!";
            //  Wow
            //  John
            //  haven't
            //  seen
            //  you
            //  for
            //  ages
        }
        public static void Chap6InserIn2Arr(Util utl, bool isConsoleRead = false)
        {
            //  Use commas
            //  Write a program to insert a new value in a double array at the specified index. Use method 
            //  GetNumbersFromConsole to read the double array from the console. The array will be created 
            //  with one extra, empty element, which gives you room to insert one more value. Read an 
            //  integer insertIndex — index, where to insert an element, and a double element — the value 
            //  to insert. Insert this element at index insertIndex. Output the array to the screen, 
            //  separating each element with comma. For example:
            //  >4
            //  >1.25
            //  >3.14
            //  >7.2
            //  >-37.12
            //  >2
            //  >14.9
            //  1.25,3.14,14.9,7.2,-37.12
            //  Code!
            const int numOfArrCells = 5; Console.Write("  ");
            double[] dNum = new double[numOfArrCells] { 1.25, 3.14, 7.2, -37.12, 0.0 }; int idx = 2, idy = -1; double dIns = 14.9;
            utl.PrintInColor($"Original: ");
            while (dNum[++idy] != 0.0) utl.PrintInColor($"{dNum[idy].ToString()}, ");
            for (int i = numOfArrCells - 1; i >= idx; i--)
            {
                dNum[i] = dNum[i - 1];
            }
            utl.PrintInColor($"Insert At Idx(After): ");dNum[idx] = dIns;
            foreach (double item in dNum)
            {
                utl.PrintInColor($"{item.ToString()}, ");
            }
        }
        public static void Chap6DivisibleBy5(Util utl, bool isConsoleRead = false)
        {
            //  Your task is to fix a communications module for our drones. Basically, it usually works, 
            //  but sometimes it uses unsecured radio frequencies to communicate. This could allow the 
            //  signal to be intercepted by machines and used against humanity. We learned that the only 
            //  safe frequencies are NOT divisible by 5. Therefore, all frequencies that are divisible 
            //  by 5 are considered insecure. Write a method FrequencyIsSecure that takes an int with 
            //  the name frequency — the frequency that the drone is using to communicate to others, 
            //  and returns a bool — whether that frequency is secure or not. Read integer numbers from 
            //  the input — frequencies of the communication channel, and for every one of them use the 
            //  FrequencyIsSecure method to output "secure" or "insecure". When you read "finished" 
            //  from the console, the program should terminate. For example:
            //  >4
            //  secure
            //  >5
            //  insecure
            //  >9
            //  secure
            //  >11
            //  secure
            //  >20
            //  insecure
            //  >finished
            //  Code!
            List<int> iIn = new List<int> { 4, 5, 9, 11, 20, -10 }; int idx = -1;
            Console.Write("  "); utl.PrintInColor($"Divisible By 5: ");
            while (iIn[++idx] != -10)
            {
                utl.PrintInColor($"{iIn[idx].ToString()}, ");
                if (iIn[idx] % 5 == 0) utl.PrintInColor($"insecure, ");
                else utl.PrintInColor($"secure, ");
            }
        }
        public static void Chap62CSTestClockAngleFromTime(Util utl, bool isConsoleRead = false)
        {

            //  We figured out that there is a spy among us. We don't know exactly who it is, but 
            //  we know that all messages that this spy is sending are encoded using the angle 
            //  between the hands of an analog clock. Your task is to write a program that, 
            //  given a specific time, returns the angle between the hands of an analog clock 
            //  showing that time. The input is 2 integers, each written from a new line, that 
            //  represent hours and minutes (respectively) in the format [0...12] and [0...59]. 
            //  You should output one number — the smallest angle in degrees between the hands 
            //  of an analog clock that shows the specified time.         Example 1:
            //  convert First (the hour hand) to an angle ie 10*30=300    Then
            //  convert Secnd (minute hand)   to an angle ie 45*06=270
            //  subtract First - Secnd    0-270=|-270|  360-270=90
            //  >10
            //  >0
            //  60
            //  Example 2:
            //  >7
            //  >15
            //  127.5
            double iHour1 = 10, iMinute1 = 0, iHour2 = 7, iMinute2 = 15, iHour = 0, iMinute = 0; 
            if (isConsoleRead) 
            {
                bool isParsed = double.TryParse(Console.ReadLine(), out iHour1);
                if (!isParsed) iHour1 = 10; 
                     isParsed = double.TryParse(Console.ReadLine(), out iMinute1);
                if (!isParsed) iMinute1 = 0; 
                     isParsed = double.TryParse(Console.ReadLine(), out iHour2);
                if (!isParsed) iHour2 = 7;
                     isParsed = double.TryParse(Console.ReadLine(), out iMinute2);
                if (!isParsed) iMinute2 = 15;
            }
            iHour = iHour1 * 30; iMinute = iMinute1 * 6; 
            double iAngle1 = Math.Abs(iHour - iMinute); if (iAngle1 > 180) iAngle1 = 360 - iAngle1;
            if (iMinute1 == 0) { iAngle1 += 0; }
            else if (iMinute1 < 16) { iAngle1 += 7.5; }
            else if (iMinute1 < 31) { iAngle1 += 15; }
            else if (iMinute1 < 46) { iAngle1 += 22.5; }
            Console.WriteLine();utl.PrintInColor($"Time: {iHour1.ToString()}:{iMinute1.ToString()}, Angle: {iAngle1.ToString()}");
            iHour = iHour2 * 30; iMinute = iMinute2 * 6;
            double iAngle2 = Math.Abs(iHour - iMinute); if (iAngle2 > 180) iAngle2 = 360 - iAngle2;
            if (iMinute2 == 0) { iAngle2 += 0; }
            else if (iMinute2 < 16) { iAngle2 += 7.5; }
            else if (iMinute2 < 31) { iAngle2 += 15; }
            else if (iMinute2 < 46) { iAngle2 += 22.5; }
            utl.PrintInColor($"Time: {iHour2.ToString()}:{iMinute2.ToString()}, Angle: {iAngle2.ToString()}");
        }
        //  Angle between clock hands in C#            //  The Truth
        //  Code!
        //  "Good job, Teo! As expected, you easily passed the exam! What did you think of it?" 
        //  Infinity asked. "Not as hard as I expected. Do you mind if I visit the restroom 
        //  quick?" I replied. "Sure, you deserve a break. Come back this afternoon; we need 
        //  to discuss your future in Wonderland."  I walked out of the room as calm as I could, 
        //  and then picked up the pace. Floor, elevator, lowest button in the column, corridor... 
        //  everything was a blur. I thought that I was just walking quickly, but I was actually 
        //  running faster than I had in quite a while. I opened the door where Noname was. 
        //  No tricks, it was in the middle of the basement, as usual. Noname noticed me immediately.
        //  "Good job, Teo!" Noname said. "I saw the results of the exam. Fascinating! I can't 
        //  believe you started learning C# just a little while ago." "It doesn't matter, Noname. 
        //  Bring me home!" I replied.  "Not a problem, I respect my part of the deal," 
        //  Noname answered.  Lights started blinking and a number of faint clicking noises 
        //  started to fill the room. In another instance, I might be curious as to how it 
        //  all worked, but all I was thinking at this point was "Faster!"  Suddenly, a portal 
        //  opened to the left of me. Yeah, I should have been surprised, but after all that 
        //  I've seen in this world... almost nothing can surprise me. "Is it safe?" I asked. 
        //  I'm also not that naive anymore!  "Yes," Noname said, sounding confident. "And it 
        //  goes back to my time?"  "Yes, all calculations are correct, as you've repaired my 
        //  modules. If there are no mistakes in your code, then there are no mistakes in my 
        //  calculations." Great, now the responsibility was on me. Wish I knew that before. 
        //  Anyway, it doesn't matter. Time to go. I made a step toward the portal, touched 
        //  it with a hand. Everything was fine; no pain, and it seemed like the portal was 
        //  safe and not headed straight for the mouth of a volcano. Ok, here I go, I thought. 
        //  Right now. One step forward.  Just a little step...  What was happening? Why could 
        //  I not just step through? I couldn't understand - I had waited so long for this, 
        //  but I could not will myself to take this last step in the long preogression!
        //  Nothing worked. The portal sat idle. I sat idle. Noname was also surprised.
        //  "Is everything ok?" Noname asked.  "I don't know... I just... I don't want 
        //  to go there." I answered.  "Are you afraid of it? You have experienced teleportations 
        //  only twice your life, and according to statistics, things that people met less than 
        //  10 times in their life are by default considered to be dangerous, because the amount 
        //  of experience depends linearly on..." "Please, Noname, just stop. It's not about 
        //  the portal. It's about me."  I just started talking, saying everything that I had 
        //  been too afraid to say. For what may have been the first time since landing in the 
        //  future, I told the full, unadulterated truth:  "I don't want to go back to my time. 
        //  My life was too usual, too casual... Nothing depended on me, nobody needed me. 
        //  I didn't even have a dog!"  "What are you saying, Teo?" Noname wondered aloud.
        //  "Look at me now - I'm a chosen one. Maybe it's my destiny, to save the Earth 
        //  from machines? What do you think, Noname?"  "I'm a machine, Teo..."  "You know what 
        //  I meant. From evil machines. But really, when I think about it, I like programming, 
        //  and I like power that it gives me in this world. Why go back to my time, where I'll 
        //  forget all of this as some strange nightmare?"  "Don't ask me, Teo. You just spent a 
        //  lot of time fixing me with the singular goal of me opening this portal and you 
        //  getting out of here. Now it's in front of you, and you think you don't need it. I'll 
        //  probably never understand you humans," Noname quipped.  "You're right, Noname. 
        //  I should stop asking others what I should do. Close the portal. There's more to 
        //  be done here. I'm going to Wonderland."  Bright future in advanced C# course
        //  C# Beginner>6 The truth>C# test    info@codeasy.net    Have fun and learn programming with codeasy.net © 2019

        public static void RunChap6Switch(Util utl, bool isConsoleRead = false)
        {
            Chap6SubsitutionalCipher(utl); chap6Easy(utl); Chap6NameSwitch(utl); Chap6DeliveryDronesSwitch(utl);
            Chap6RobotMove(utl); Chap6InserIn2Arr(utl); Chap62CSTestClockAngleFromTime(utl);Chap6DivisibleBy5(utl);
            Chap6StringSplit(utl); Chap6NearestInt(utl); Chap6DrawRhombus(utl);
        }
    }
        class Chapter22Scopes
    {
        /*  codeasy.net    C# Beginner>2 Victory is close>Introduction to scopes  Programmer doubts
        //  Doubts    I was thinking about my discussion with the guy from the C gang and wondering 
        //  about my trust in Noname. Was it worth it? I made a deal with a machine in a world where 
        //  the rest of humanity, and by extension, I myself, was fighting against machines. 
        //  Framing it in those terms did indeed make it sound a little stupid.
        //  "Hi, Teo," Noname messaged one day. "Can you come and see me when you get a chance?"
        //  "Sure. I'll be down in a couple of hours." I answered. Here I was, again planning to go 
        //  and help a machine without fully understanding its motives. But I wanted to get home so 
        //  badly... What would you do?  When I got down to the basement, I tried my best to keep my 
        //  internal strife to myself. "Hi, Noname." I said. "What's the problem now?"
        //  "Impressive, you already know that if I call you, it's not for a party. 
        //  You ask about the problem before I have to explain that there is a problem!"
        //  "Just based on my previous experience." I said, hoping that I hadn't come off as crass.

        //  "You are right," Noname went on, "I have a problem. Inside of me, there is a function 
        //  that I can't repair on my own. It just will not compile. It's a part of my network module."
        //  "Why do you need a network module?" I asked. Noname's voice became considerably louder 
        //  as he bellowed "That's easy. With a network module, I can destroy humanity three times 
        //  faster than without it!" "What?!" I shouted. "Calm down friend, it's just a joke! You 
        //  know I'm on your side. Let's get to work." I was not impressed with this attempt at 
        //  humor, but I let it go for the moment. Noname continued, "To fix my network function, 
        //  you first need to get me some information about scopes and variable visibility from a 
        //  local network. I quickly found the article that Noname was looking for. If only it was as 
        //  quick to actually understand the material!    //  Variable scopes in c sharp

        //  Visibility and Scopes
        //  Let's explore the scope of a local variable, or in other words, all the places in the code where 
        //  you can access it. A variable/method/class is visible (and can be accessed by name) in some parts 
        //  of the code, but not others. Consider the following code sample:

        //  Scopes In C#

        //  The following rules explain some basics of variables and code structures declared in different scopes:
        
        //  The class is visible throughout its namespace scope. You can access the class outside its namespace 
        //  as well. To do this, use the full name, prepending the class name with the name of the namespace 
        //  and separating them by a dot. For example, AnotherClass becomes Scopes.AnotherClass. Another 
        //  way to use a class from another namespace is to add a using directive to the top of your 
        //  program; for example, using System.
        //  A method is visible inside the class in which it is declared. If the method is of the public 
        //  static type, you can also access it from outside of the class. For this, use the method's full 
        //  name, prepending the method name with a class name and separating the two by a dot. For example, 
        //  MyPurpose becomes Scope.MyPurpose, or Scopes.Scope.MyPurpose if you use it in another namespace. 
        //  Don't forget about the 'public' in the beginning of the method. static void MyPurpose would 
        //  need to be changed to public static void MyPurpose if you wanted to use the method in another class.
        //  Method arguments are visible inside the whole method, starting with an opening brace '{' and 
        //  finishing with a closing one '}'. There are no exceptions! If you try to access method 
        //  arguments from outside of the method, you'll get a compile-time error.
        //  Local variables declared in the outer scope of a method are visible inside the whole method, 
        //  starting with the opening brace '{' and finishing with the closing one '}'.
        //  Local variables declared in a for or while loop are visible inside the loop between the opening 
        //  and closing braces '{...}'. This means that you can create several for or while loops that all 
        //  use the same counter variable, such as i, and they will not collide because each loop has a different scope.
        //  Local variables declared in an if or any other scope are visible only within that scope, 
        //  between the braces '{...}'. Outside of its own scope, local variables are immediately destroyed. 
        //  This occurs regardless of where exactly they were declared: in for, while, if, method, etc.
        //  As you know, you cannot have two variables with the same name in the same scope. You can, however, 
        //  have two variables with the same name if they appear in different scopes. Here are some examples:
        //  
        //  static void DoIt()
        //  {
        //      for(int i = 0; i < 10; ++i)
        //      {
        //          Console.WriteLine(i);
        //  
        //          for (int i = 0; i < 10; ++i)
        //          {
        //              Console.WriteLine(i * i * i);
        //          }
        //      }
        //  }
        //  Not Ok: Duplicate names in the same scope
        //  static void DoIt()
        //  {
        //      for(int i = 0; i < 10; ++i)
        //      {
        //          Console.WriteLine(i);
        //      }
        //  
        //      for (int i = 0; i < 10; ++i)
        //      {
        //          Console.WriteLine(i * i * i);
        //      }
        //  }
        //  Ok: Scopes are different
        //  static void DoIt()
        //  {
        //      bool myVariable = true;
        //      double myVariable = 57.12;
        //  
        //      if (myVariable)
        //      {
        //          Console.WriteLine(myVariable);
        //      }
        //  }
        //  Not Ok: Duplicate names in the same scope
        //  static void DoIt()
        //  {
        //      {
        //          bool myVariable = true;
        //          Console.WriteLine(myVariable);
        //      }
        //      {
        //          double myVariable = 57.12;
        //          Console.WriteLine(myVariable);
        //      }
        //  }
        //  Ok: Scopes are different
        //  Now solve the following tasks by making the following revisions:
        //  Make the program compile and write your material conditions to the console.
        
        //  Call the method PrintHello from the place pointed out in the code.
        
        //  Call the method Add from class Calculator, namespace Mathematics, in the place pointed out in the
        //  code. Pass in, as arguments, number1 and number2, and put the result in the sum variable.
        
        //  Make the program compile. It should output what you like in UPPERCASE and what you hate in 
        //  lowercase letters.
        
        //  Out of comfort zone
        
        //  "Did you understand the article, Teo?" Noname asked.
        //  "Yes, this seems easier than arrays or methods." I answered.
        //  "Good! I'm proud of you, human! You are one of the best programmers on Earth nowadays! 
        //  Now go and fix my module."
        
        //  Make the program compile and write "Hi" in ASCII art to the console. As an input, it takes 
        //  an integer between 10 and 90 to indicate the width of the word.
        
        //  Well done!

        //  C# Beginner>2 Victory is close>Introduction to scopes    info@codeasy.net    Have fun and learn programming with codeasy.net © 2019
  */
        }
        class AdvancedDroid
    {
        private int xPosition;
        private int yPosition;
        public AdvancedDroid(int xPosition, int yPosition)
        {
            Util util = new Util(ConsoleColor.Blue, ConsoleColor.White);
            this.xPosition = xPosition;
            this.yPosition = yPosition;
            util.PrintInColor($"exiting ADCons,  (P)x={xPosition}, (P)y={yPosition}, xpos={xPosition}, ypos={yPosition}, this.xpos={this.xPosition}, this.ypos={this.yPosition}\n");
        }
        public void MoveTo(int x, int y)
        {
            Util util = new Util(ConsoleColor.Blue, ConsoleColor.White);
            util.PrintInColor($"entering MoveTo, (P)x={x}, (P)y={y}, xpos={xPosition}, ypos={yPosition}, this.xpos={this.xPosition}, this.ypos={this.yPosition}\n");
            this.xPosition = x;
            this.yPosition = y;
            util.PrintInColor($"exiting MoveTo,  (P)x={x}, (P)y={y}, xpos={xPosition}, ypos={yPosition}, this.xpos={this.xPosition}, this.ypos={this.yPosition}\n");
        }
    }

    class Guess
    {
        private int _secretNumberToGuess;
        public Guess(int secretNumberToGuess)
        {
            this._secretNumberToGuess = secretNumberToGuess; int i = 0;
            Util util = new Util(ConsoleColor.Green, ConsoleColor.Black);
            while (++i < this._secretNumberToGuess)
            {
                util.PrintInColor($"Try again:  you did not guess the secret Number: {i.ToString()}\n");
            }
            util.PrintInColor($"Congratulations!: you guessed the secret Number: {_secretNumberToGuess.ToString()}\n");
            util.PrintInColor($"exiting Guess, (P)secretNumber={secretNumberToGuess}, _secretNumber={_secretNumberToGuess}, this._secretNumber={this._secretNumberToGuess}\n");
        }
    }
    class Comparator
    {
        public Box boxy = new Box(1, 2, 3);
        public Comparator()
        {
            int pop = 0;
            if (pop == 0)
                pop = 1;
        }
        public int Compare(Box box2)
        {
            //if (boxy.Area == box2.Area)
            return 0;
        }
    }
    //  "Noname! Just the specifics," I shouted in my mind.  "Broadcast null."
    //  "What is null?"   "Null represents an empty reference, 
    //  i.e., one that does not refer to any object. 
    //  null is the default value of reference-type fields."
    //  "And the default value is the one that is assigned to an object 
    //  before we use the new operator?" I asked.  "Let's get there step by step, 
    //  sir. Fist important fact to remember: local variables should always 
    //  have some value assigned before you work with them. 
    //  Otherwise, your program won't compile. This holds for reference 
    //  and value types," Noname said. */
    class NullTest
    {
        private string _text;
        public string _newlyCreated;
        public NullTest(string text1)
        {
            _text = text1;
        }
        public void TestNull(string text)
        {       //Fix the code to make program compile. Code! 
            Utl.PrintColoredA(ConsoleColor.Red, ConsoleColor.Black, $"\nYou are entering My Stuff: JSON\n\n");
            Util util = new Util(ConsoleColor.White, ConsoleColor.Black);

            string s = text; // s is unassigned
            if (s == null) // COMPILE ERROR: Can't use unassigned variable
                Console.WriteLine("s is null");
            int n = 0; // n is unassigned
            util.PrintInColor($"nameof(s)={nameof(s)}\n");
            n++;   // COMPILE ERROR: Can't use unassigned variable  //  key-value pair
            string badboy = @"{ 'Name': 'Bad Boys', 'ReleaseDate': '1995-4-7T00:00:00', 'Genres': ['Action', 'Comedy'] }";
            object pop = JsonConvert.DeserializeObject(badboy);
            string poppy = JsonConvert.SerializeObject(pop);
            Movie bbm = JsonConvert.DeserializeObject<Movie>(badboy); 
            util.PrintInColor($"bbm:{bbm.ToString3()}.\n"); 
            util.PrintInColor($"bbm.Genres[0]={bbm.Genres[0]}, " + $"bbm.Genres[1]={bbm.Genres[1]}.\n");
            NullTest nullTest = new NullTest("I am awesome to the MAX");
            nullTest.JobsIO(@"C:\Users\Brice16\Documents\Resumes\JobsNov02-082019.txt");

            Utl.PrintColoredA(ConsoleColor.Red, ConsoleColor.Black, $"\nYou are exiting My Stuff: JSON\n\n");

            #region dsobj<Movie>
            //  nameof(s)=s
            //  pop ={
            //  "Name": "Bad Boys",
            //  "ReleaseDate": "1995-4-7T00:00:00",
            //  "Genres": [
            //  "Action",
            //  "Comedy"
            //  ]
            //  }  

            /*util.PrintInColor($"pop ={pop.ToString()}. poppy={poppy}\n");
            string[] lopit = pop.ToString().Split("\r\n");
            int iName = -1, iRD = -1, iGenresA = -1, iGenresB = -1, ikvp = -1; ;
            int genresCount=util.GenresCounter(lopit);
            Movie badBoysMovie = new Movie("", new DateTime(), new string[genresCount]);
            string[] divideName,RDdivide,genresA,genresB; string[] bbMg = new string[genresCount];
            foreach (string item in lopit)
            {
                if (item == "{" || item == "}" || item.Contains("Genres") || item.Contains("]"))
                {
                    if (item.Contains("]")) 
                    {
                        badBoysMovie.Genres = bbMg;
                    }
                }
                else if (item.Contains("Name"))
                { divideName= item.Split(": ");
                    foreach (string Nameitem in divideName)
                    {
                        util.PrintInColor($"divideName[{++iName}]={Nameitem}");
                        if (iName > 0 )
                        {
                            badBoysMovie.Name = Nameitem.TrimStart().Substring(1, Nameitem.Length - 3);
                        }
                    }
                    util.PrintInColor("\n");
                }
                else if (item.Contains("ReleaseDate"))
                { RDdivide =  item.Split(": ");
                    foreach (string  rditem in RDdivide)
                    {
                        util.PrintInColor($"RDdivide[{++iRD}]={rditem}");
                        if (iRD > 0)
                        { badBoysMovie.ReleaseDate = Convert.ToDateTime(rditem.Trim().Substring(1, rditem.Length - 3)); }
                    }
                    util.PrintInColor("\n");
                }
                else if (item.Contains(","))
                {
                    genresA = item.Split("\""); 
                    foreach (string gAitem in genresA)
                    {
                        util.PrintInColor($"genresA[{++iGenresA}]={gAitem}");
                        if (iGenresA == 1) { bbMg[++ikvp] = gAitem; }
                    }
                    util.PrintInColor("\n");
                }
                else { genresB = item.Split("\"");
                    foreach (string gbitem in genresB)
                    {
                        util.PrintInColor($"genresB[{++iGenresB}]={gbitem}");
                        if (iGenresB == 1) { bbMg[++ikvp] = gbitem; }
                    }
                    util.PrintInColor("\n");
                }
            }
            util.PrintInColor($"badboysMovie={badBoysMovie.ToString()}\n");    */
            //  lopit[0]={
            //  lopit[1]=  "Name": "Bad Boys",
            //  lopit[2]=  "ReleaseDate": "1995-4-7T00:00:00",
            //  lopit[3]=  "Genres": [
            //  lopit[4]=    "Action",
            //  lopit[5]=    "Comedy"
            //  lopit[6]=  ]
            //  lopit[7]=} */
            //  var dict = badboy.Split(',').Select(x => x.Split(':')).ToDictionary(x => x[0], x => x[1]);
            //  foreach (var item in dict)            {                util.PrintInColor(item.Key + "=" + item.Value + "\n");            }
            //  string[] stringSeparators = new string[] { "\', \'", "{ \'" };
            //  string[] keypairs = badboy.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);int ctr = 0;
            //  foreach (string item in keypairs)            {                util.PrintInColor($"item{++ctr}={item}, ");            }                            //  Movie m = JsonConvert.DeserializeObject<Movie>(json);
            //  util.PrintInColor("\n");
            //
            //    string name = m.Name;     // Bad Boys
            //    Product product = new Product();
            //    product.Name = "Apple";
            //    product.Expiry = new DateTime(2008, 12, 28);
            //    product.Sizes = new string[] { "Small" };
            //    string json = JsonConvert.SerializeObject(product);
            //    {   "Name": "Apple", "Expiry": "2008-12-28T00:00:00", "Sizes": [ "Small" ]   } 
            #endregion
        }   //  public void TestNull()
        //  You've met another droid that knows a secret integer between 1 and 8. 
        //  Add or remove this modifiers to enable a guessing game where the user should 
        //  guess that secret number. (In this case, it is 6) Code!
        //  
        //      As soon as I sent the message, the remaining droids immediately stopped. 
        //  I was hoping this would prove to be the hardest part of the rescue.
        //  We entered the building and found Infinity's sister in some kind of Faraday cage. 
        //  To open the cage and save the captive, you need to enter the code phrase in a 
        //  simplified Pig Latin language. Infinity is working hard to find the code phrase; 
        //  your job is to write a converter for English to Pig Latin. In the Main method, 
        //  read a string from the console, treating a space as a word separator. 
        //  Output this string in simplified Pig Latin. Ignore double spaces. 
        //  The code phrase contains only lower case letters. English is translated 
        //  to a simplified Pig Latin by taking the first letter of every word, 
        //  moving it to the end of the word, and adding "ay". For example: 
        //  >the quick brown fox
        //      hetay uickqay rownbay oxfay
        public void PigLatin(string line)
        {
            StringBuilder sb = new StringBuilder(""); string[] lopall = line.Split(" ");
            foreach (string item in lopall)
            {
                sb.Append(item.Substring(1) + item[0] + "ay ");
            }
            _newlyCreated = sb.ToString();
        }
        public void PrintPL(string line, string line2)
        {
            Util util = new Util(ConsoleColor.Red, ConsoleColor.Black); util.PrintInColor($"Original Line = {line}, Newly Created = {line2}\n");
        }
        public StringBuilder JobTextFix(StringBuilder jobs)
        {
            #region jobs
            //  Junior Web Developer
            //  Pixel Motion2 reviews - Irvine, CA
            //  Moved to Applied 20 hours ago
            //  Mobile Developer
            //  Sevenlogics, Inc2 reviews- Diamond Bar, CA
            #endregion
            int jobNum = 0; StringBuilder sb = new StringBuilder($"{++jobNum}. ");
            string[] jobArr = jobs.ToString().Split("\r\n");
            foreach (string item in jobArr)
            {
                if (item.Contains("reviews"))
                {
                    string[] pop = item.Split(" reviews"); int minusCount = 0;
                    string lopity = pop[0];
                    for (int i = lopity.Length - 1; i >= 0; i--)
                    {
                        if (char.IsDigit(lopity[i])) { ++minusCount; }
                        else                         { break; }
                    }  //  for (int i = lopity.Length - 1; i >= 0; i--)
                    //  pop[0] = lopity.Substring(0, lopity.Length - minusCount);
                    lopity = pop[0].Substring(0, pop[0].Length - minusCount);
                    sb.AppendLine(lopity + " " + pop[1]);
                }   //  if (item.Contains("reviews"))
                else if (item.Contains("Moved to Applied "))
                {    sb.AppendLine(""); sb.Append($"{++jobNum}. ");                    }
                else
                {    sb.AppendLine(item);    }
            }
            return sb;
        }
        public void JobsIO(string path)
        {
            StringBuilder strArray = new StringBuilder("");
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() >= 0)
                    {
                        strArray.AppendLine(sr.ReadLine());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            Util util = new Util(ConsoleColor.White, ConsoleColor.Blue);
            StringBuilder sb = JobTextFix(strArray); util.PrintInColor(sb.ToString());
        }   //  public void JobsIO(string path)
    }       //  Class NullTest
    class Movie
    {               //  { 'Name': 'Bad Boys', 'ReleaseDate': '1995-4-7T00:00:00', 'Genres': [ 'Action', 'Comedy' ] }";
        private string _name;
        public Movie(string name, DateTime releaseDate, string[] genres)
        {
            _name = name; ReleaseDate = releaseDate; Genres = genres;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public DateTime ReleaseDate { get; set; }
        public string[] Genres      { get; set; }
        public /*override*/ string ToString3()
        {
            StringBuilder sb = new StringBuilder(""); int ipop = 0;
            sb.Append($"Name={Name}, ReleaseDate={ReleaseDate.ToShortDateString()}, Genres=");
            foreach (string item in Genres)
            {
                if (ipop < Genres.Length - 1) { sb.Append(item + ", "); }
                else { sb.Append(item); }
                ++ipop;
            }
            return sb.ToString();
        }
    }

}
namespace Chap1ClassObjCarUserGlass
{
    class RunNamespaceCSIChap1
    {
        public static void RunCSIChap1()
        {
            Utl.PrintColoredA(ConsoleColor.Red, ConsoleColor.Black, $"\nYou are entering CSharp-Intermediate: Chapter 1: Class and Object.\n\n");
            User user = new User { Age = 21, Name = "Brice Ulwelling" }; user.PrintUser();  //  public Age, Name
            Car.CarLogic();
            #region Glass class     // that rhymes!
            /*
            //   We are prototyping a robot that refills glasses during dinner. 
            //   Every glass holds 200 milliliters. 
            //   During dinner, people either drink water or juice, 
            //   and as soon as there is less than 100 ml left in the glass, the robot refills it back to 200 ml. 
            //   
            //   Create a class Glass with one public int field LiquidLevel 
            //   and methods public Drink(int milliliters) 
            //   that takes the amount of liquid that a person drank 
            //   and public Refill() that refills the glass to be 200 ml full. 
            //   Both methods should not return any value. Initially set LiquidLevel to 200. 
            //   
            //   In the Main method create an object of class Glass 
            //   and read commands from the screen until the user terminates the program (see next). 
            //   Don't forget to refill the glass when needed! Commands are: 
            //   drink followed by a number. 
            //        It indicates that the person drank that amount of milliliters from the glass. 
            //        You can use string. Split(' ') to separate the word and the number.
            //   print - you need to output to the screen how much liquid is in the glass 
            //   in the format "This glass contains ...ml of liquid."
            //   stop - program should quit.
            //   Example 1: 
            //   >drink 37 
            //   >drink 12 
            //   >print 
            //   This glass contains 151ml of liquid. 
            //   >stop 

            //   Example 2: 
            //  > drink 50 
            //  > drink 51 
            //  > print 
            //  This glass contains 200ml of liquid. 
            //  > stop */
            #endregion
            Glass glass = new Glass() { LiquidLevel = 200 }; glass.RunGlass();
            Utl.PrintColoredA(ConsoleColor.Red, ConsoleColor.Black, $"\nYou are Entering CSharp-Intermediate: Chapter 1.2: Accessors and Constructors.\n\n");
            //  Rectangle rec = new Rectangle() { ReservedArea = 12, Length = 20, Width = 10 };
            //  rec.PrintAreaResult(rec.GetArea());
            Rectangle.PrintRectangle(32, 15, 9);

            Shield shield = new Shield(); shield.PrintShield();
            ExtendedShield shield1 = new ExtendedShield("BriceStar", 15); shield1.PrintShield();

            LitArea litArea = new LitArea(1, 1, 5, 6); litArea.DrawRec(litArea.TL, litArea.BR);
            LitArea lit = new LitArea(0, 0, 2, 4); lit.DrawRec(lit.TL, lit.BR);
            Utl.PrintColoredA(ConsoleColor.Red, ConsoleColor.Black, $"\nYou are Exiting CSharp-Intermediate: Chapter 1.2: Accessors and Constructors.\n\n");
        }
    }
        #region Codeasy.net ==> Intermediate C# ==> Chapter 1.1  ==> Class and Object 
        //  Codeasy.net ==> Intermediate C# ==> 1. Hello, Wonderland ==> Class and Object 
        //  Hello, Wonderland 
        //  I arrived in Wonderland yesterday. I'm still not entirely sure 
        //  that my decision to stay in the future was wise... In any event, 
        //  I'm comfortable with where I'm at now. I carry more responsibility 
        //  and have mostly stopped lamenting my hardships. 
        //  Infinity gave me a quick briefing about the situation here. Wonderland is 
        //  the largest-known resistance base on Earth. It's surrounded by a shield 
        //  that prevents machines from scanning the area. Instead of analyzing the 
        //  surface for the base, the machines have resorted to brute-force tactics, 
        //  namely digging, in hopes of hitting the jackpot. Because of this, 
        //  the atmosphere here is tense: people are afraid that at any moment 
        //  the machines may come up out of the ground and reveal Wonderland's location. 
        //  The primary objective for everyone here is a project codenamed Rust, which
        //  is a virus that provides full control over a machine to any chosen server. 
        //  In our case, of course, that would mean a resistance server. We want to 
        //  inject this virus in the handshake message that every device sends to one 
        //  another when they establish communication. So far, so good - prototypes of 
        //  virus already exist! But... they don't work. That's why I'm here, and why 
        //  Infinity gathers the best programmers from other resistance bases. She needs 
        //  this virus to work. As soon as possible. While humanity still has some fight left in it. 
        //  There are a lot of small details that need to be sorted out in order for Rust to work; 
        //  for example, if we can take control of a machine, how do we send commands to 
        //  billions of machines at once? One server won't be able to control that amount of traffic, 
        //  and if that server crashes, we immediately lose our advantage. The machines will quickly 
        //  craft an antivirus. In addition, there are probably ten new machine prototypes produced 
        //  every single week - how can Rust adapt to that kind of variety? I know, I know, 
        //  not exactly positive thinking. But this is the best option we have for now, and we will; 
        //  rather, we need; to solve all of it. 
        //    The skill level of the programmers in Wonderland is astounding. I feel like a freshman again, 
        //  and I will doubtless have studies every day as before. Let's get started! 
        //  Welcome to the Class! 
        //  The main instruction room was bigger and brighter than the one in Ritchie's resistance base. 
        //  Ten students were here with me. The teacher was a woman, around 35-40 years old, with big glasses. 
        //  "Hello everyone! My name is Sintia, and we are going to have a brief overview of classes today. 
        //  Let's make a list of what you learned before you came to Wonderland," she said, picking up a marker. 
        //  We named some topics in C#, and everyone's answers were fairly similar. 
        //  Apparently, in all the resistance bases, people know the same subset of C#. 
        //  "Ok, that's a good start," Sintia said. "But these are only basics. Your real education in C# 
        //  starts today, now, in this room. Can anyone tell me where the concept of classes came from?" 
        //  This time, no hands went up. "Ok then, here's the origin story. A long time ago in a language called C, 
        //  there were no classes or namespaces; people were writing functions, and everything just worked. 
        //  As software development grew, however, programs became more and more complicated. 
        //  Eventually, name clashes started to occur when several functions with the same name 
        //  were imported from different programming modules. This made it impossible to compile the code. 
        //  Imagine a simple scenario where you have a game with a Log(string message) function to write 
        //  something to a log file. And then a module gets imported that also has its own 
        //  Log(string message) function. As you all know, you can't have two functions with the name Log, 
        //  because they'll be indistinguishable from one another. That's why programmers began to create 
        //  prefixes, like Internal_Log(...) and ExternalLibName_Log(...). The same was done with 
        //  global data variables: int Internal_Timeout, int ExternalLibName_Timeout, etc. 
        //  As a result, code became longer, less readable, and more difficult to write. 
        //  That's why smart people decided to bring into C the concept of an 
        //  object - an entity that stores data and the methods to work with that data all in one place. 
        //  This entity will also determine a scope, which means methods and variables 
        //  with the same name can exist in different entities." 
        //  The paradigm of using objects is called OOP - object-oriented programming. 
        //  Object-oriented programming (OOP) is a programming paradigm based on the concept of "objects," 
        //  which may contain data fields and code, in the form of procedures, often known as methods. 
        //  "Can I ask you a question?" I said.  "You already did," Sintia answered with a light smile on a face.
        //  "Why did you start talking about classes but then switch to objects? Are they the same thing?" 
        //  I wondered. "Good question, Teo! Nice catch!" she looked satisfied. "A class is a template for objects. 
        //  A class defines object properties including a valid range of values and a default value. 
        //  A class also describes object behavior. An object is an "instance" of a class. 
        //  An object has a state in which all of its properties have values that you define." 
        //  "Sorry, but I don't understand," said another student. "Can you show us an example?" 
        //  "Fair enough. Look at this class definition:" 
        //class Box
        //{
        //    int Length;
        //    int Width;
        //    int Height;
        //    bool IsOpened;

        //    public void Open()
        //    {
        //        IsOpened = true;
        //    }

        //    public void Close()
        //    {
        //        IsOpened = false;
        //    }
        //}
        //  "Why didn't you use a static keyword for the methods? All the methods 
        //  we worked with before now were static," another student asked.
        //  "Yeah, this can be confusing," Sintia answered. "Please, until you 
        //  learn what static means, leave only the Main method as static; 
        //  all other fields and methods should not have a static modifier." 
        //  Sintia continued: "Can anyone tell me how much space in memory the Box class occupies now?" 
        //  "An integer is 4 bytes, which means we need three multiplied 
        //  by four and add..." one of the students began thinking out loud.
        //  "Wrong. It takes 0 bytes. What you see is only a template of a box that could be created. 
        //  But there are no boxes created in this code - what you see is a class. 
        //  Remember, a class is only a template for a real instance. 
        //  It shows you what an instance of that class will look like, 
        //  but it does not create an instance. Think of a class name as a new type like int or string. 
        //  After you've created the Box class, you can create variables 
        //  of type Box and assign values to them," Sintia concluded.
        //  "How can I create an instance of a box?" I asked.  "In a Main method, 
        //  use the new operator, as you did for arrays."         //Box boxObject = new Box();
        //  "Now, boxObject will take some space in memory, because it is an object, not just a class." 
        //  "I think I understand now. An object is something real, that is allocated in memory, 
        //  and we can control it during program runtime. A class is just a template for all objects 
        //  that are going to be created," said one of the students. "Yes, exactly!" 
        //  Sintia looked satisfied. She continued, "A class consists of fields (members) and methods. 
        //  Fields (or members) are for storing the typed data, the same as local variables. 
        //  Methods are functions that work with this data. You can access all fields 
        //  from within methods of the same class; again, the same as you did with local variables. 
        //  Here's a figure that might make it a bit more clear." 
        //  "Any final questions before we delve into the practice of objects?" she asked. 
        //  "What types can you use for fields?" asked someone in the back.
        //  "Any type that you want. It can be a string, array, double, Box, or any other type. 
        //  If you want a deeper dive into fields, you can read this article, 
        //  which I'll post in the notes. Time for the first exercise!" 
        //  Create a class User with two fields, int field Age and string field Name, 
        //  and one method with name GetName() that takes no arguments and returns a field Name. Code! */
        #endregion
    class User          //  Create a class User             C#I 1. Hello Class/Obj (1)
        {
            public int Age;    //with two public fields: int Age 
            public string Name; //and string Name. 
            public void PrintUser()  //             * Then, output to the screen: "My name is {Name} and I'm {Age} years old." 
            {
                Util util = new Util(ConsoleColor.Cyan, ConsoleColor.White);
                util.PrintInColor($"\nMy name is {Name}, and I'm {Age.ToString()} years old.\n");    //      }      * using object fields for Name and Age. 
            }       //  public void PrintUser()
        }           //  class User      //  Create a class User
    class Car           //  Create a class Car              C#I 1. Hello Class/Obj (2)
    {
        //  Create a class Car. Inside the class, 
        //  create a public static int field CarsCount 
        //  and increment it in the constructor.
        //  In the Main method, create 5 objects of the type Car.
        //  Then, output a string containing the number of cars created to the screen, 
        //  "Number of created cars is {CarsCount}", using the value of the static field for it.   //  Code!
        //  Class/Object: Create a class Car with two fields: a double field Weight and a string field Color.
        //  Then, add two methods to class Car : PrintWeight(), which prints the value of the field Weight; 
        //  and PrintColor(), which prints the value of the field Color to the console.
        //  Both methods take no parameters.    //  Code!
        public static int carsCount = 0;
        private string _model;
        private int _year;
        private double _weight;
        private string _color;
        public Car(string model, int year, double weight, string color)
        {
            _model = model; _year = year; _weight = weight; _color = color;
            carsCount++; PrintWeight(); PrintColor();
        }
        public void PrintWeight()
        {
            Util util = new Util(ConsoleColor.Red, ConsoleColor.Yellow);
            util.PrintInColor($"Weight={_weight.ToString()}, ");
        }
        public void PrintColor()
        {
            Util util = new Util(ConsoleColor.Red, ConsoleColor.Yellow);
            util.PrintInColor($"Color={_color}. ");
        }
        static public void CarLogic()
        {
            Car corolla = new Car("Corolla", 2004, 6001.36, "Candy Apple Red");
            Car buick = new Car("Buick", 1997, 6001.36, "Blue");
            Car sienna = new Car("Sienna", 1999, 6001.36, "Green");
            Car car123 = new Car("Car4", 2014, 6001.36, "Pearl White");
            Car prius = new Car("Prius", 2013, 6001.36, "Dead of Night Black");
            Util util = new Util(ConsoleColor.Red, ConsoleColor.Yellow);
            util.PrintInColor($"\n{corolla._model}({corolla._year}), {buick._model}({buick._year}), {sienna._model}({sienna._year}), {car123._model}({car123._year}), {prius._model}({prius._year}), so Car Count = {carsCount.ToString()}\n");
        }
    }
    class Glass         //   Create a class Glass           C#I 1.1 Hello Class/Obj (3)
    {
            //   We are prototyping a robot that refills glasses during dinner. 
            //   Every glass holds 200 milliliters.     
            //   During dinner, people either drink water or juice, 
            //   and as soon as there is less than 100 ml left in the glass, 
            //   the robot refills it back to 200 ml. 
            public int LiquidLevel;    //    with one public int field LiquidLevel 
            private bool _enterInput;
            public Glass(bool enterInput = false)
            {
                _enterInput = enterInput;
            }
            public void Drink(int milliliters)  //   and methods public Drink(int milliliters) 
            {    //   that takes the amount of liquid that a person drank 
                if (milliliters > LiquidLevel || milliliters > 199)
                { milliliters = LiquidLevel - 1; }
                LiquidLevel = LiquidLevel - milliliters;
                if (LiquidLevel < 100) { Refill(); }
            }
            public void Refill()    //   and public Refill() 
            { LiquidLevel = 200; }      //   that refills the glass to be 200 ml full.         }
            public void PrintGlass()  //   print - you need to output to the screen how much liquid is in the glass 
            {
                ColorPrint colorPrint = new ColorPrint();
                Console.WriteLine();            //  ConsoleColor origCs4grnd = Console.ForegroundColor;            //  ConsoleColor origCsbckgrnd = Console.BackgroundColor;
                colorPrint.ForeGroundColor = ConsoleColor.Red;  //  Console.ForegroundColor = ConsoleColor.Red;
                colorPrint.BackGroundColor = ConsoleColor.White;//  Console.BackgroundColor = ConsoleColor.White;
                colorPrint.ColoredPrint($"This glass contains {LiquidLevel.ToString()} ml of liquid..\n");    //   in the format "This glass contains {0} ml of liquid..", 
                if (LiquidLevel == 200) { colorPrint.ColoredPrint("|##|\n"); colorPrint.ColoredPrint("|##|\n"); colorPrint.ColoredPrint("|##|\n"); colorPrint.ColoredPrint("|##|\n"); }
                else if (LiquidLevel > 149) { colorPrint.ColoredPrint("|  |\n"); colorPrint.ColoredPrint("|##|\n"); colorPrint.ColoredPrint("|##|\n"); colorPrint.ColoredPrint("|##|\n"); }
                else { colorPrint.ColoredPrint("|  |\n"); colorPrint.ColoredPrint("|  |\n"); colorPrint.ColoredPrint("|##|\n"); colorPrint.ColoredPrint("|##|\n"); }                         //Console.ForegroundColor = origCs4grnd;            //Console.BackgroundColor = origCsbckgrnd;
            }
            public void RunGlass()
            {
                string line = "Drink 10";
                if (!_enterInput)
                {
                    Drink(50); PrintGlass(); Drink(49); PrintGlass(); Drink(44); PrintGlass();
                }
                else
                {
                    while (line != "Stop")
                    {
                        //  string pep = "0"; int millilitters = 0;
                        string[] pop = line.Split(' ');
                        if (pop.Length > 1) { Drink(Convert.ToInt32(pop[1])); }
                        if (line == "Print") { PrintGlass(); }
                        line = Console.ReadLine();
                    }
                }

            }
            //   Both methods should not return any value. Initially set LiquidLevel to 200. 
            //   
            //   In the Main method create an object of class Glass 
            //   and read commands from the screen until the user terminates the program (see next). 
            //   Don't forget to refill the glass when needed! Commands are: 
            //   drink followed by a number. 
            //        It indicates that the person drank that amount of milliliters from the glass. 
            //        You can use string. Split(' ') to separate the word and the number.

            //   stop - program should quit.
            //   Example 1: 
            //   >drink 37 
            //   >drink 12 
            //   >print 
            //   This glass contains 151ml of liquid. 
            //   >stop 
        }
    class Rectangle     //   Create a class Rectangle       C#I 1.2 Accessor Constructor (1)
    {

        //  public Rectangle()        //  {        //  }
        //  private void PrintReservedArea()
        //  {            // Ok, can use private fields from within the class
        //      Console.WriteLine($"      Secret Reserved Area is: {ReservedArea}");
        //  }
        //  public void PrintAreaResult(int Area)
        //  {     // Ok, can use private fields from within the class
        //      Console.WriteLine($"             Original Area (Length*Width) ({Length}*{Width})");
        //      Console.WriteLine($"minus Secret Reserved Area is: {Area}");
        //  }
        public static void PrintRectangle(int reservedArea = 12, int length = 20, int width = 10)
        {
            Utl.PrintColoredA(ConsoleColor.DarkRed, ConsoleColor.White, $"      Secret Reserved Area is            : {reservedArea}\n"); ; // Ok, can call private methods from within the class
            Utl.PrintColoredA(ConsoleColor.DarkRed, ConsoleColor.White, $"             Original Area (Length*Width) ({length}*{width}): {GetOrigArea(length, width).ToString()})\n");
            Utl.PrintColoredA(ConsoleColor.DarkRed, ConsoleColor.White, $"minus Secret Reserved Area is    New-Area: {((GetOrigArea(length, width)) - reservedArea).ToString()}\n");
        }
        private static int GetOrigArea(int length, int width)
        { return length * width; }
    }
    class Shield        //   Create a class Shield          C#I 1.2 Accessor Constructor (2)
    {
        //  Create a class Shield with two private fields: string _identifier and int _power. 
        //  Add a parameterless public constructor to the class Shield 
        //  that assigns 10 to _power and "Default" to _identifier.     Code!
        private string _identifier;
        private int _power;
        public Shield()
        {
            _identifier = "Default";
            _power = 10;
        }
        public void PrintShield()
        {
            ColorPrint colorPrint = new ColorPrint(); colorPrint.ForeGroundColor = ConsoleColor.Cyan; colorPrint.BackGroundColor = ConsoleColor.Yellow;
            colorPrint.ColoredPrint($"ID:{_identifier} Power: {_power}\n");
        }
    }
    class ExtendedShield//   Create a class ExtendedShield  C#I 1.2 Accessor Constructor (3)
    {
        //  Take your class Shield from the previous task and rename it to ExtendedShield. 
        //  Add two parameters to the constructor: string identifier and int power.
        //  Inside the constructor, assign the value of these parameters to the private fields _identifier and _power. 
        private string _identifier;
        private int _power;
        public ExtendedShield(string identifier, int power)
        {
            _identifier = identifier;
            _power = power;
        }
        public void PrintShield()
        {
            ColorPrint colorPrint = new ColorPrint(); colorPrint.ForeGroundColor = ConsoleColor.Red; colorPrint.BackGroundColor = ConsoleColor.Yellow;
            colorPrint.ColoredPrint($"ID:{_identifier} Power: {_power}\n");
        }
    }
    class Point         //   Create a class Point           C#I 1.2 Accessor Constructor (4.0)
    {
        //  Wonderland has a garden where plants are grown under artificial sunlight. 
        //  The sunlight lamp is capable of covering a rectangular area of any size. 
        //  A computer program directs the lamp to the area that needs sun at any given moment.
        //  Your task is to create a class LitArea that has two private fields of type Point: 
        //  _topLeft and _bottomRight. 
        //  Those fields store the coordinates of the top left and lower right points 
        //  that limit the rectangle of light from the lamp.
        //  Create a public constructor in the class LitArea that takes four integers: 
        //  xTopLeft, yTopLeft, xBottomRight, and yBottomRight. 
        //  Create two objects of type Point inside of the constructor, 
        //  one for the top left corner of the area and one for the bottom right. 
        //  Assign public fields X and Y of every point to corresponding coordinates coming in the arguments. 
        //  Finally, store the newly created points in the fields _topLeft and _bottomLeft. 
        //  Code!
        public int X;
        public int Y;
        public Point(int XCoordinate, int YCoordinate)
        {
            X = XCoordinate;
            Y = YCoordinate;
        }
    }   // class Point
    class LitArea       //   Create a class LitArea         C#I 1.2 Accessor Constructor (4.1)
    {
        //  Create a public constructor in the class LitArea that takes four integers: 
        //  xTopLeft, yTopLeft, xBottomRight, and yBottomRight. 
        //  Create two objects of type Point inside of the constructor, 
        //  one for the top left corner of the area and one for the bottom right. 
        //  Assign public fields X and Y of every point 
        //  to corresponding coordinates coming in the arguments. 
        private Point _topLeft, _bottomRight;
        public Point StartP, TL, BR, point;
        public LitArea(int xTopLeft, int yTopLeft, int xBottomRight, int yBottomRight)
        {
            _topLeft = new Point(xTopLeft, yTopLeft);               //  Creating object in constructor
            _bottomRight = new Point(xBottomRight, yBottomRight);   //  Creating object in constructor
        }
        public void DrawRec(Point TopLeft, Point BottomRight)
        {
            #region LitArea2D
            //  Next, take the class Point from the previous task and rename it to Point2D (2D stands for two-dimensional). 
            //  Also take the LitArea class and rename it to LitArea2D. 
            //  Add a public method Draw() to the LitArea2D class that takes no arguments and returns void.
            //  In the Main method, read four integers from the console, each from the new line: 
            //  xTopLeft, yTopLeft, xBottomRight, and yBottomRight. 
            //  Create an object of type LitArea2D, passing these four integers as parameters to a constructor. 
            //  These four integers represent coordinates on a 2D grid: 
            //  the coordinate system starts in the top left corner; 
            //  X axes are horizontal, and Y are vertical. See the following figure for an example.

            //  Implement method Draw() in the class LitArea2D to draw an area using ASCII art, 
            //  according to integer coordinates that the user input. 
            //  The dark area to the left and above the lit area should be indicated with a dot ("."), 
            //  and the lit area itself with a pound sign ("#"). 
            //  Then, call this method from Main. For example:
            //  >2
            //  >3
            //  >5
            //  >6
            //  ......
            //  ......
            //  ......
            //  ..####
            //  ..####
            //  ..####
            //  ..####
            //   In the above example, the lit area starts at point [2, 3] and ends at point [5, 6]

            //    Example 2:
            //  >0
            //  >0
            //  >2
            //  >4
            //  ###
            //  ###
            //  ###
            //  ###
            //  ###
            //  In the above example, the lit area starts at point [0, 0] and ends at point [2, 4]    //  Code!
            #endregion
            ColorPrint colorPrint = new ColorPrint();
            colorPrint.ForeGroundColor = ConsoleColor.Red;
            colorPrint.BackGroundColor = ConsoleColor.White;
            StartP = new Point(0, 0);

            TL = _topLeft; BR = _bottomRight;
            colorPrint.ColoredPrint($"_topLeft = [{_topLeft.X}, {_topLeft.Y}] and ");
            colorPrint.ColoredPrint($"_bottomRight = [{_bottomRight.X}, {_bottomRight.Y}]\n");
            StringBuilder sb = new StringBuilder();
            int iX = TL.X; int iY = TL.Y; int oX = BR.X; int oY = BR.Y; char oLetter = '.';
            //int[,] boolArray = new int(iX, iY);
            for (int y = 0; y < BR.Y + 1; y++)    //  Vertical(Y)
            {
                for (int x = 0; x < BR.X + 1; x++)        //  Horizontal(X)    
                {
                    if (x == 0)
                        oLetter = '.';
                    if (x >= iX && y >= iY)
                        oLetter = '#';
                    sb.Append(oLetter.ToString());
                    if (x == oX)
                    {
                        colorPrint.ColoredPrint(sb.ToString() + "\n");
                        sb.Clear();
                    }
                }
            }
            colorPrint.ColoredPrint(sb.ToString());
        }
    }
    #region Naming Conventions
    //  Private fields start with an underscore and continue with lower camel case: _privateFieldName
    //  Public fields are written in upper camel case (sometimes referred to as Pascal case): PublicFieldName
    //  Public and private methods are written in upper camel case: PublicOrPrivateMethodName()
    //  Classes and namespaces are written in upper camel case: ClassName NamespaceName 
    #endregion

}    //  namespace Chap1ClassObjCarUserGlass
namespace ClassObjectNAccessor
{
    class SumBetween     //   Create a class SumBetween       C#I 2.1 Static (1)
    {
        //  Create a class that has one public static method, GetSumBetween, 
        //  that takes two integers, a and b, and returns as an integer the sum of all integers between a and b (including a and b). 
        //  In the Main method, read two integers from the console, 
        //  call GetSumBetween, and print the returned number to the console.
        //  For example(don't output the green text):
        //  >6
        //  >10
        //  40  // 6 + 7 + 8 + 9 + 10 = 40

        public static int GetSumBetween(int a, int b)
        {
            ColorPrint colorPrint = new ColorPrint(); colorPrint.ForeGroundColor = ConsoleColor.Red; colorPrint.BackGroundColor = ConsoleColor.White;
            int c = 0;
            for (int i = a; i <= b; i++)
            { c = c + i; }
            colorPrint.ColoredPrint($"The numbers between {a} and {b} sum to {c}\n"); return c;
        }
        public void PrintGeneric(Util utl, string className, string name)
        { utl.PrintInColor($"{className}: {name}  "); }

    }
    static class DistanceMeasurer  //DistanceMeasurer         C#I 2.1 Static (2)
    {
        //  Measuring distance is an essential task at Wonderland. 
        //  Create a static class, DistanceMeasurer, that has one public method, 
        //  GetDistance, with a return type of double, that takes 4 int parameters 
        //  that represent 2D point coordinates: x1, y1, x2, y2. 
        //  The GetDistance method should output the distance 
        //  between the two given points (x and y) on a plane.
        //  In the Main method, read 4 integers from the console, 
        //  execute GetDistance, and output the result to the screen.
        //  For example:
        //  >2
        //  >1
        //  >3
        //  >4
        //  3.16227766016838                Code!
        public static double GetDistance(int x1, int y1, int x2, int y2)
        {
            double firstq = Math.Pow(x1 - x2, 2.0);      //  = (x1 - x2)2
            double second = Math.Pow(y1 - y2, 2.0);      //  = (y1 - y2)2
            double thirdq = Math.Sqrt(firstq + second);
            return thirdq;
        }
    }
    //  Wonderland has a formal president. He is a bit eccentric, and likes it 
    //  when all text that he reads is placed in a frame of stars: *. For example, 
    //  instead of "Hello, sir," he expects to see:
    //  **************
    //  * Hello, sir *
    //  **************
    //  Create a static class TextFramePretifier. It should contain a 
    //  private static int field, _textsPretified, that increments 
    //  for every text that this class processes. Add a static constructor 
    //  that initializes _textsPretified to zero. Also add a 
    //  public static method Prettify that takes a string text and returns void. 
    //  The method should first print a sentence "Processing text: {_textsPretified}" 
    //  that indicates how many texts have been processed. Then, from the new line, 
    //  it should print the given text into a frame of stars. The input text is guaranteed 
    //  to take no more than one line. The user string should have one space before and after 
    //  the frame, as shown in the below example.
    //  In the Main method, read a string from the console and call your method with this input.
    //  Repeat this until user inputs "exit". For example:    
    //  >Why frame is so important, sir?
    //  Processing text: 1
    //  ***********************************
    //  * Why frame is so important, sir? *
    //  ***********************************
    //  >You look great today, sir!
    //      Processing text: 2
    //  ******************************
    //  * You look great today, sir! *
    //  ******************************
    //  >exit
    static class TextFramePretifier  //TextFramePretifier     C#I 2.1 Static (3)
    {
        private static int _textsPretified;
        static TextFramePretifier() { _textsPretified = 0; }
        public static void Prettify(string text)
        {
            int astlen = text.Length + 4;
            Util util = new Util(ConsoleColor.Red, ConsoleColor.White);
            _textsPretified++;
            util.PrintInColor($"Processing text: {_textsPretified.ToString()}\n");
            string opo = util.TextRepeater("*", astlen);
            util.PrintInColor(opo + "\n");
            util.PrintInColor("* " + text + " *\n");
            util.PrintInColor(opo + "\n");
        }
    }
    //  The president was happy with your implementation of the TextFramePretifier... 
    //  for one day. Then he decided that he wants to control the width of the frame. 
    //  Take the code of the previous task and modify it to take an integer 
    //  that represents the width of the frame and then print a message in the frame as you did in previous task, 
    //  but using the given width this time. Write as many words as you can in each line; 
    //  if there is an empty space, fill it with spaces. The number of words 
    //  in a message will not exceed 100. All words are guaranteed 
    //  to be shorter than (frameWidth - 4). Treat spaces as word separators 
    //  and all other symbols, such as commas or question marks, as part of the word 
    //  they're connected to. The text is guaranteed to have only single spaces.
    //      For example:
    //  >15
    //  >You look great today, sir!
    //  Processing text: 1
    //  ***************
    //  * You look*
    //  * great       *
    //  * today, sir! *
    //  ***************
    //  >A zebra does not change its spots.
    //  Processing text: 2
    //  ***************
    //  * A zebra     *
    //  * does not    *
    //  * change its  *
    //  * spots.      *
    //  ***************
    //  >exit
    static class WTextFramePretifier //TextFramePretifier     C#I 2.1 Static (4)
    {
        private static int _textsPretified;
        static WTextFramePretifier() { _textsPretified = 0; }
        public static void Prettify(int widthOfFrame, string text)
        {
            Util util = new Util(ConsoleColor.Red, ConsoleColor.White);
            StringBuilder sb = new StringBuilder("* ");
            _textsPretified++;
            util.PrintInColor($"Processing text: {_textsPretified.ToString()}\n");
            string opo = util.TextRepeater("*", widthOfFrame);
            util.PrintInColor(opo + "\n");    //util.PrintInColor("* " + text + " *\n");
            string[] strArray = text.Split(' ');
            foreach (var item in strArray)
            {
                if (sb.Length == 2)
                {
                    sb.Append(item);
                }
                else
                {
                    if ((item.Length + sb.Length + 3) > (widthOfFrame - 4))
                    {
                        PrettyPrintLine(widthOfFrame, util, sb);
                        sb.Clear(); sb.Append("* " + item.ToString());
                    }         //  Write frame use item in else sb.Append(" "+item 
                    else
                    {
                        sb.Append(" " + item.ToString());
                    }   //    if (item.Length + sb.Length + 3 > WidthOfTexts): else
                }  //  if (sb.Length == 3)
            }   // foreach (var item in strArray)     
            PrettyPrintLine(widthOfFrame, util, sb);
            util.PrintInColor(opo + "\n");
        }
        private static void PrettyPrintLine(int widthOfFrame, Util util, StringBuilder sb)
        {           //  Dont put this in Util you would have to repass the colors!!!!
            int currMinusTextWidth = 0;
            if (widthOfFrame - (sb.Length + 2) > 0)
                currMinusTextWidth = widthOfFrame - (sb.Length + 2);
            util.PrintInColor(sb.ToString()
                + util.TextRepeater(" ", currMinusTextWidth) + " *\n");
        }  //  private static void PrettyPrintLine(int widthOfFrame, Util util, StringBuilder sb)
    }      //  static class WTextFramePretifier
    class ClassObjectsAndAccessors
    {
        public static bool enterInput = false;
        public ClassObjectsAndAccessors(bool enterConsoleInput = false)
        {
            enterInput = enterConsoleInput;
        }
        static public void RunCOAA()
        {
            Utl.PrintColoredA(ConsoleColor.Red, ConsoleColor.Black, $"\nYou are entering CSharp-Intermediate: Chapter 2: Accessors, static, null, & this.2\n\n");
            Utl.PrintColoredA(ConsoleColor.Red, ConsoleColor.Yellow, "Hello World! Droid Killers: 23, 669, 133");
            Box box = new Box(14554, 25794, 98758) { IsOpened = true };
            if (box.IsOpened) { box.PrintBoxArea(box.Area); box.CloseBox(); }
            else { box.OpenBox(); }
            ColorPrint colorPrint = new ColorPrint(); colorPrint.ForeGroundColor = ConsoleColor.Red; colorPrint.BackGroundColor = ConsoleColor.White;
            //Write a program that creates an int variable codePart with the value 333. Then create another 
            //  int variable with name code and assign a value that is twice the codePart variable value. 
            //  Your program should output: Self - destruction started. The code is 666
            int codePart = 333;
            colorPrint.ColoredPrint($"\nDistance=175+(75*3)={175 + (75 * 3)}.  Self - destruction started. The code is {codePart * 2}.\n");
            // chapter 2.1 static 2.1.1.
            int d = SumBetween.GetSumBetween(6, 10); int e = SumBetween.GetSumBetween(1, 5);
            // chapter 2.1 static 2.1.2.
            int x1 = 2, y1 = 1, x2 = 3, y2 = 4; Console.WriteLine();
            double distance = DistanceMeasurer.GetDistance(x1, y1, x2, y2); colorPrint.ColoredPrint($"x1 = {x1.ToString()}, y1 = {y1.ToString()}, x2 = {x2.ToString()}, y2={y2.ToString()}; so distance = {distance.ToString()}\n");

            // chapter 2.1 static 2.1.3.
            TextFramePretifier.Prettify("Why frame is so important, sir1?");
            TextFramePretifier.Prettify("Why frame is so important, sir2?");
            TextFramePretifier.Prettify("You look great today, sir!");
            // chapter 2.1 static 2.1.4.
            WTextFramePretifier.Prettify(14, "Why frame is so important, sir1?");
            WTextFramePretifier.Prettify(14, "You look great today, sir!");
            Utl.PrintColoredA(ConsoleColor.Red, ConsoleColor.Black, $"\n\nYou are exiting CSharp-Intermediate: Chapter 2: Accessors, static, null, & this.3\n\n");
        }   //  static public void RunCOAA()
    }       //  class ClassObjectsAndAccessors    
    class PickupClasses
    {
        public PickupClasses()
        { Util utl = new Util(ConsoleColor.DarkRed, ConsoleColor.White); RunPickup(utl); }
        public static void PrintSalary(Util utl, bool isConsoleRead = false)
        {
            //  Create 4 int variables with different names. Assign them these values: 1000, 2000, 3000, 10000. Using string interpolation, insert those int variables into the strings to get such output:
            //  In one year my salary is going to be 1000 USD, In two years my salary is going to be 2000 USD
            //  In three years my salary is going to be 3000 USD, In four years my salary is going to be 10000 USD
            List<int> iNums = new List<int> { 1000, 2000, 3000, 10000 }; Console.WriteLine();
            List<string> sYear = new List<string> { "one year", "two years", "three years", "four years" }; int count = iNums.Count(); --count;
            for (int i = 0; i < count; i++)
            {
                utl.PrintInColor($"In {sYear[i]} my salary is going to be {iNums[i].ToString()} USD, ");
            }
            utl.PrintInColor($"In {sYear[count]} my salary is going to be {iNums[count].ToString()} USD.   ");
        }
        public static void PaintCube(Util utl, bool isConsoleRead = false)
        {
            //  Now for a more practical application.The biggest machine known to us is a huge cube, measuring 
            //  317 meters in each direction, and it is called “Dominator.” To stop Dominator, we plan to paint 
            //  it with a machine - destroying paint. Write a program that calculates how much paint we will need 
            //  to totally paint all six sides of Dominator, if painting 1 square meter takes 20 grams of paint. 
            //  You have studied geometry, haven't you? 
            //  Output the result using string interpolation in the format: I need **grams of paint.
            utl.PrintInColor($"\nThe Dominator Cube is 317 meters, so to paint it I need {(20 * 6 * 317 * 317).ToString("N0")} grams of paint.");
        }
        public static void PrintISee(Util utl, int count = 5, bool isConsoleRead = false)
        {
            //  Here is a final task that may come in handy.Some drones are not so easy to reprogram immediately, 
            //  so they may continue sending reports to the drone base.To prevent this, you can substitute false 
            //  reports.You have to output to the screen: "I can see ** people in this square" and then decrement 
            //  the number by 1.You have to repeat this until the number of people is equal to 0.For example:
            //  I can see 2 people in this square
            //  I can see 1 people in this square
            //  I can see 0 people in this square
            //  Try it yourself, but starting with 5 people at the beginning. Use int variables and strings interpolation.
            Console.Write("  "); for (int i = count; i >= 0; i--) { utl.PrintInColor($"I can see {i.ToString()} people in this square.  "); }
        }
        public static void RunPickup(Util utl, bool isConsoleRead = false)
        { PrintSalary(utl); PaintCube(utl); PrintISee(utl); ExceptionsII(utl); CSIntrmdtChap5Inheritance(utl); }
        //  C# Intermediate>4 A Secret Server>Exceptions in c sharp
        //  Keep the system unchanged   Based on what I've learned at Wonderland so far, 
        //  Infinity was the visible leader of the base, but it appeared that there was a 
        //  commander above her calling the shots. Being inherently curious, I decided to 
        //  ask Infinity about it directly rather than trying to figure it out on my own. 
        //  I met her in the kitchen getting coffee one day, as usual.  "Hi Infinity, how 
        //  are you?" I started the conversation.  "Hi Teo, I'm doing well, thank you," 
        //  She replied, continuing, "And you?"  "I'm fine, thanks. Can I ask you something? 
        //  Who's the ultimate head of Wonderland? I thought I heard you receiving orders 
        //  the other day from someone. Was I hearing right? I thought you were the leader 
        //  of the resistance in Wonderland."  "Ritchie warned me that you like to eavesdrop," 
        //  she said, sighing.  "I'm not sure I would say I 'like' it," I said, trying to 
        //  excuse my way out. "I would say that it happens sometimes, not that I..."
        //  Infinity cut me off before I could make more of a fool of myself. "I trust 
        //  you, Teo. You helped me rescue my sister - I'll never forget that. Now listen. 
        //  This doesn't go beyond this room. The actual decision makers at Wonderland are 
        //  a mystery to everyone. Even I don't know who the 'real boss' is. I get all 
        //  orders from a person I've been instructed to just call Commander. He's 
        //  refused to answer any of my prying questions, probably for the sake of 
        //  security. Once a month I have a conference call with him, where he gives 
        //  me direct orders. I've never seen him. I don't even know where he's located. 
        //  We just execute his commands and report back to him next time."  "How can you 
        //  be sure that Commander has our best interest in mind? What if we can't trust 
        //  him, or if it would be better for us to operate independently?" I asked.
        //  "He was leading Wonderland long before I joined the resistance. In fact, to 
        //  the best of anyone's knowledge, he was one of the original founders of Wonderland. 
        //  For now, the system works this way and we'll keep it unchanged unless we find a 
        //  better option," Infinity explained.  Hmm... something in her response seemed 
        //  familiar to me, but I couldn't remember why exactly. "To keep the system unchanged." 
        //  Where had I heard that before?  Codeasy Wonderland Decision-makers  Exceptions
        //  The next topic on the Wonderland curriculim was Exceptions. I'd heard about these 
        //  before, but never in depth. We had programmed in a console output of "Exception 
        //  has been thrown..." a couple of times, and now it was time to learn exactly what 
        //  that meant.  "Hello everyone," Sintia started the lesson, "Can anyone tell me 
        //  what types of errors C# program have?"  "Runtime and compile-time errors!" Someone 
        //  answered.  "Right. And the difference between those two is?" Sintia was asking more 
        //  than telling today.  "Compile-time errors happen when the code is translated to IL 
        //  code, runtime errors happen when the program is executed," I answered.  "Excellent! 
        //  To make sure that you didn't just memorize that... Is a missed semicolon a runtime 
        //  or a compile-time error?" Sintia asked once again. "Compile-time," someone from 
        //  the class answered.  "That's also correct. Now, can you name some runtime errors?"
        //  "Division by zero, NullReferenceException... " I answered, trying to think of others.
        //  "I don't think we've discussed NullReferenceException, but you are right, together 
        //  with division by zero, those are both runtime errors. Does anyone know how C# lets 
        //  you know about runtime errors?"  Nobody answered; she had finally reached the edge 
        //  of our knowledge on the subject.  "In most cases, it happens through exceptions. 
        //  An exception is a mechanism that is used to indicate a runtime error in the program. 
        //  In C#, exceptions are represented by objects of a class Exception, or classes derived 
        //  from it."  "Sintia, what is a derived class?" Someone asked.  "For now, consider 
        //  derived classes as you do classes; they both have similar functionality," Sintia 
        //  said. "We'll learn about derived classes in-depth at a later time."  "To throw an 
        //  exception, you can either use the keyword throw with a generated object of type 
        //  Exception, or trigger one of the standard compiler-generated exceptions. Here is 
        //  an example:"  var a = 12; var b = 0; var c = a / b; // Throws DivideByZeroException. Compiler-generated
        //  string name = null; var length = name.Length; // Throws NullReferenceExceprion. Compiler-generated
        //  throw new Exception("My exception"); // Throws Exception. Generated by a programmer
        //  "Sintia, I still don't get it. What do these exceptions look like in practice? 
        //  As a programmer or a user of a program, how would I understand that the program has thrown 
        //  an exception? When I get compile-time errors, they are usually depicted in the output window 
        //  of my IDE (Visual Studio)," said one of the students. I felt the same; exceptions would be 
        //  of little use if they weren't clear to the programmer or the user of the program.
        //  Compile time error in Visual studio Compile time error at Codeasy  "I understand your 
        //  question," Sintia said, turning her attention to her tablet. After a few swipes, we saw 
        //  two projected images that showed what an exception would look like from a programmer's 
        //  perspective.  Exception in Visual studio Exception in Codeasy editor  "Now it makes 
        //  perfect sense!" I exclaimed and continued, "I've seen this error message many times, 
        //  but didn't understand it at the time. So every time I saw it, there was an exception 
        //  thrown somewhere in my code? How do I know what type the exception has, and where it 
        //  was thrown?" I asked.  "Visual Studio tells you both of those answers. It shows the 
        //  type of exception and the line number in the code from where it was thrown," Sintia 
        //  explained. "For now, let's move on and see how the user experiences an exception. Here 
        //  is the code of my program:"  var a = 12;  var b = 0;  
        //  Console.WriteLine("Hello, let's divide by zero!");  var c = a / b;  
        //  Console.WriteLine($"The result is {c}"); "And on the other screen, you can see the 
        //  screenshot of this program running."  Exception from the user perspective
        //  "As you see, at first the program executed in normal order, and console output Hello, 
        //  let's divide by zero! Then the program crashed, throwing an exception 
        //  DivideByZeroException. Execution of the code stopped and the program subsequently 
        //  terminated."  "Sintia, does an exception always terminate the program in which it 
        //  appears?" I asked.  "No, C# has a mechanism to handle exceptions, called a try-catch. 
        //  It allows you to catch exceptions and handle the error before it causes a crash. 
        //  Look at this code snippet," Sintia replied, projecting a new code snippet on the wall.
        //  var a = 12;  var b = 0;  Console.WriteLine("Hello, let's divide by zero!");
        //  try  {    var c = a / b;    Console.WriteLine($"The result is {c}");    }
        //  catch (DivideByZeroException ex)  {  Console.WriteLine("There was an attempt to divide by zero!"); }
        //  Console.WriteLine("I'm still running!");  // Outputs:  // Hello, let's divide by zero!  
        //  There was an attempt to divide by zero!   // I'm still running!  "To handle an exception, 
        //  surround the code that throws an exception with a try{} block followed by a catch{} block. 
        //  The code that handles the exception lives in the catch block, and the code that throws an 
        //  exception lives in the try block. If you omit the parenthesis after the catch block, as 
        //  in the following example, it will catch exceptions of any type:"  
        //  try{    throw new ArgumentException();}   catch // If nothing here, it cathches exceptions 
        //  of all types  {    Console.WriteLine("An exception was thrown, I'm not sure which one though."); }
        //  // Outputs  // An exception was thrown, I'm not sure which one though.  "To catch exceptions 
        //  of a specific type, specify that type immediately after the catch block," Sintia explained.
        //  try{    throw new ArgumentException();}  
        //  catch (DivideByZeroException ex) // Catches only DivideByZeroException
        //  {    Console.WriteLine("DivideByZeroException was thrown.");    }
        //  // Outputs nothing  try {    throw new DivideByZeroException();    }
        //  catch (DivideByZeroException ex) // Catches only DivideByZeroException
        //  {    Console.WriteLine("DivideByZeroException was thrown.");    }
        //  // Outputs  // DivideByZeroException was thrown.  "You can supply a message 
        //  to explain exactly what went wrong. Put this message in the constructor of 
        //  an exception that you throw. To access this message in the catch block, add 
        //  a variable name inside the parenthesis and use its property Message, like this:"
        //  try {    throw new Exception("Something broke!"); // Specify a message here
        //  }catch (Exception ex) // A variable ex now represents the exception that
        //         // was thrown
        //  {    Console.WriteLine($"Exception was thrown: {ex.Message}");  }
        //  // Outputs  // Exception was thrown: Something broke!
        //  "Sintia, when you showed an exception from the user perspective, it stated 
        //  "an unhandled exception". What is this? What is the difference between 
        //  handled and unhandled exceptions?" asked one of the students.  "Oh, that's 
        //  pretty straightforward. If you have a try-catch construction that handles 
        //  an exception, it's considered to be handled. In all other cases, the 
        //  exception is considered to be unhandled. If an unhandled exception occurs, 
        //  the program is terminated by the operating system," she explained.
        //  "For more information, you can study a not complete list of C# exceptions. 
        //  Now it is time for some exceptional tasks!"  
        //  In the Main method, throw an unhandled exception of type Exception with no 
        //  message specified. Leave the class and namespace names unchanged.  
        //  In the Main method, throw an unhandled exception of type Exception with a 
        //  message "I'm a dangerous exception!" Leave the class and namespace names unchanged.  
        //  In the Main method, throw an unhandled exception of type ArgumentException 
        //  with a message "Argument can't be negative" Leave the class and namespace names unchanged.  

        //  In the Main method, create a try-catch construction. Inside the try block, throw an 
        //  ArgumentException with the message "The argument is invalid!", and in the 
        //  catch block, print the message from an exception to the screen. 
        //  Construct the catch block in a way that it catches only ArgumentException.
        //  Your program should read two integers each from a new line. Then, it ..  
        //  should output the sum, difference, product and quotient of these numbers. 
        //  Put your code in the try block. Add a catch block that catches a 
        //  DivideByZeroException and prints to the screen "Can't divide by zero!"
        //  Example 1:  >12  >4   16   8   48   3
        //  Example 2:  >12  >0   12  12    0   Can't divide by zero!
        //  Codeasy Keep Calm and Don't devide by Zero  
        //  C# Intermediate>4 A Secret Server>Exceptions in c sharp
        public static void ExceptionsII(Util utl, string s1 = "", bool isConsoleRead = false)
        {
            #region    C# Intermediate>4 A Secret Server>Going deeper in C# Exceptions  A Hidden Server
            //  The new information about the Commander that Infinity had told me had been 
            //  dancing around in my head all night. Who is he? Why doesn't anybody know him? 
            //  Where is he located and what is his ultimate goal, the reasoning behind his orders? 
            //  Is he supporting the Rust project? And this didn't even cover half of the questions 
            //  I had!  "Noname, can you check Commanders authority?" I thought.  "I started two 
            //  hours ago, Teo," Noname replied.  "Wait, what? Two hours ago? Why did you do that?" 
            //  I said, surprised.  "I read your thoughts, Teo. I saw that you were worried about 
            //  Commander and decided to help," Noname answered with an extremely calm voice. 
            //  "That is what friends do, no?"  "Yes, hm, right," I replied, parsing this new 
            //  information. "Friends help each other, but they don't typically read each other's 
            //  minds! Are you really capable of reading my thoughts? Why can't I read your thoughts?"
            //  "Because I'm integrated into your brain, but you are not integrated into mine. 
            //  Don't worry - I know that you don't fully trust me, but that's okay. I'm still 
            //  just a machine. But thanks to you, I'm learning what it is to be human."  "Touching," 
            //  I said, wondering if Noname had learned about sarcasm yet. "But back to my initial 
            //  question, about Commander's authority? Any results there?" I asked.  "His files are 
            //  hidden in a server inside Wonderland that's protected from the internal network. 
            //  I mean it is inaccessible even from Wonderland. I'm completely helpless here. 
            //  The only way to get that info is to physically connect to that server and read the data," 
            //  Noname reported.  "Well," I replied, "I can't sleep and have nothing else to do. 
            //  Where's the server?" I was ready then and there to find it and reveal the mystery 
            //  around the Commander's persona.  Hidden Server in Codeasy Wonderland  Going Deeper Into 
            //  Exceptions  I followed Noname's instructions and found the secret server. As soon as I 
            //  established a connection to that server, Noname got read-only access to some of the files.
            //  "I can't see all the data," Noname said. "You need to open access to me."  "How do I do that?" 
            //  I asked.  "You need to inject your code into exception handling."  "Ah ha, not a problem! 
            //  I've already learned exceptions in C#," happy to have something of my own to brag about.
            //  "Great, then you can add three catch blocks to one of the existing try-catch and then..."
            //  "Wait, Noname," I interrupted. "There can only be one catch that corresponds to a try block," 
            //  I corrected Noname.  "Didn't you say you had learned this topic?" Noname said, doing his 
            //  best to emulate surprise. He continued, "A try block can have several corresponding 
            //  catch blocks because code can throw exceptions of different types. For example:"
            //  public double GetLengthRatio(string s1, string s2)  
            //  {  var s1Length = s1.Length; // Can throw NullReferenceException if s1 is null
            //     var s2Length = s2.Length; // Can throw NullReferenceException if s2 is null
            //     var ratio =  s1Length / s2Length; // Can throw DivideByZeroException if s2 is empty
            //      return ratio;
            //  }
            //  Noname explained: "This code can throw at least two different exceptions: 
            //  NullReferenceException and DivideByZeroException. You can write code that handles 
            //  exceptions in a different way depending on their type."  
            //  public double GetLengthRatio(string s1, string s2)
            //  {        double ratio;
            //      try   {   var s1Length = s1.Length;   var s2Length = s2.Length;  ratio = s1Length / s2Length;  }
            //      catch(NullReferenceException ex)  // Handling NullReferenceException
            //      {  Console.WriteLine($"One of the provided strings is null! Exception: {ex.ToString()}");
            //          ratio = 0.0;       }
            //      catch (DivideByZeroException ex) // Handling DivideByZeroException
            //      {   Console.WriteLine($"s2 is empty! Exception: {ex.ToString()}");    
            //          ratio = double.MaxValue;       }
            //      catch (Exception ex) // Handling all other exceptions
            //      {  Console.WriteLine($"Unknown error. Exception: {ex.ToString()}");
            //          ratio = 0.0;    }
            //      return ratio;
            //  }
            //  "In this example, I used multiple catch blocks to separate handling of different exceptions," 
            //  Noname explained with a calm and focused voice.  "Why did you call every exception variable 'ex'?" I asked.
            //  "This is a general convention, not a strict rule. You can use any name you want," he answered. 
            //  "Now let's come back to the order of catch blocks. When an exception occurs inside the try block, 
            //  CLR first checks it against the first catch block; if it fits, that catch block is executed. 
            //  If the first catch block doesn't match, it checks the second catch block, then the third, 
            //  and so on, ending with the last catch block. This behavior forms a rule that you need to 
            //  follow when you create a catch blocks chain - go from the most specific exception to the 
            //  most general. As you see in my example, the most general is Exception (which means 
            //  "any error"), and less specific are DivideByZeroException and NullReferenceException. 
            //  Try to always specify the type of exceptions that can occur; don't just throw 
            //  everything in one can of 'any error'."  "Can I ask one more question? How would I know 
            //  which exceptions the code throws if I use C# functions written by other programmers?"
            //  "You are growing, Teo! You ask mature questions. And the answer is... Documentation! 
            //  I'll show you this in the next example," Noname said.  var input = Console.ReadLine();
            //  var number = int.Parse(input);  Console.WriteLine(number);  "As you already know, 
            //  int.Parse can throw exceptions under some conditions. But what exceptions? 
            //  And under what conditions? To answer these questions, use documentation. You can 
            //  find it here. Look in the section Exceptions. There, you'll find all possible 
            //  exceptions that this function can throw. For int.Parse, this includes 
            //  ArgumentNullException, ArgumentException, FormatException, and OverflowException. 
            //  Each of them is explained in that section. Are you following me?" Noname raised 
            //  his voice a little.  "I sure am!" I replied. "Time to hack some hidden servers!"
            //  The Information You Seek is In The Documentation  Put the whole given code snippet 
            //  from the Main method into a try block. Add two catch blocks that handle different 
            //  exceptions and output corresponding errors to the screen:  If the user inputs a 
            //  number in a wrong format, write to the console: "Port that you provided is not a number."
            //  If the user inputs a number that's too big, like 1234567890987654, write to the 
            //  console: "Port that you provided is too big."  This code is protecting the server's 
            //  secret data. It's impossible to change it, but there is a way to add one catch 
            //  instruction to get access.  
            //  Without changing any code that's already written, add one more catch block to make the 
            //  code output "Access granted" when the user inputs a very long number as a numeric password. 
            //  For example:  Enter login  >login   Enter numeric password  >1234567890987654321  Access granted
            //  "Well, Teo, we did our best, but this server is protected much more securely than I expected," 
            //  Noname stated. "We need to continue hacking, this time throwing an exception in one function 
            //  and catching it in another."  "How does that work, Noname?" I wondered, "Where is the 
            //  exception-handling code in such case?"  "Take a look at this code snippet," he replied.
            //  public static void Main()
            //  {    SomeMethod();}
            //  public static void SomeMethod() // Throws an exception that crashes the application  
            //  {    throw new ArgumentException("Argument is wrong!");  }
            //  "In this example, the program will terminate because of an unhandled exception, but it can be 
            //  fixed by adding a try-catch block in the Main function, like this:"  
            //  public static void Main()
            //  {    try      {          SomeMethod();      }
            //    catch (Exception ex) // The exception is handled here
            //      {        Console.WriteLine(ex);    }
            //  }
            //  public static void SomeMethod() // The exception "jumps out" from here
            //  {    throw new ArgumentException("Argument is wrong!");  }
            //  Noname continued explaining: "When an exception occurs, it looks for the closest try-catch 
            //  block to the line where the exception occurred. If there is no try-catch nearby, 
            //  it 'jumps out' from the function and looks for the try-catch in the function that 
            //  called the current one, and so on, until it gets to the highest in the hierarchy 
            //  function (Main), and if that one doesn't have a try-catch for this exception, 
            //  your program will crash. Here, I have a diagram that will help you to understand this." 
            //  Noname projected something just into my brain so that I had no choice but to look at it.
            //  Handling of the exception that occured in a method/  In the Main method, catch the 
            //  exception that GetMonthName can throw if the user inputs a non-existent month number, 
            //  like -1 or 14. Don't catch all exceptions by type Exception - choose the most specific one. 
            //  You can use this documentation to figure out which exception you need.  In the catch block, 
            //  output the exception's message to the screen.  One of the students in your class did his 
            //  homework, but their solution turned out to be a bit messy. You are provided with the code
            //   - it has a few mistakes and a lot of room for improvement. Your task is not to fix it, 
            //  but rather to simply prevent it from crashing.  Surround all code in the Main method 
            //  with a try-catch construction. Find all exceptions that the code in Main can throw 
            //  and catch them in different catch blocks. In each, print the message of the 
            //  exception to the screen. Ignore OutOfMemoryException.  You have a guessing game written 
            //  by a talented (but inexperienced) student who didn't know about exceptions. 
            //  She used int.Parse but didn't handle situations when the input is invalid. 
            //  For example, if instead of a number the input was !@#, the program crashes.

            //  Your task is to add two try-catch constructions: one in the beginning, 
            //  when the user inputs the secret number that we'll guess, and one to 
            //  cover each guessed number. If the user's input appears to be invalid, 
            //  output "Your input is invalid. Try once again!". Keep asking the user to input a number 
            //  until they input a valid number. Here is an example:
            //  Input a secret number
            //  >Hello!
            //  Your input is invalid. Try once again!
            //  >100
            //  Now start guessing
            //  >What am I supposed to do? !@#
            //  Your input is invalid. Try once again!
            //  >99
            //  Bigger
            //  >101
            //  Smaller
            //  >I'm tired
            //  Your input is invalid. Try once again!
            //  >100
            //  You've guessed! Woohoo!
            //  "Great work, Teo. Now I can start reading data from the server," Noname said.
            //  For a minute or two, he was silent; then he said: "Hm... It seems that my file reader 
            //  is not disposing of system resources. I'm consuming too many resources and would need 
            //  to restart several times while reading files on this machine. Could you please add a 
            //  finally block with resource deallocation?"  "A finally block? What is that?" I asked. 
            //  Given that Noname was in my head, it seemed odd that he couldn't have anticipated my confusion.
            //  "A try, catch construction has a third block, called finally. It's used to clean up any 
            //  resources that were allocated in the try block. It can be used without a catch block 
            //  (try-finally), or with it (try-catch-finally)," Noname explained.  "Okay, next question," 
            //  I said. "What resources does a C# programmer need to clean up? Previously, I didn't clear 
            //  any resources; everything worked just fine without it." I didn't like to take anything for 
            //  granted, and this seemed like a good opportunity to learn something new.  "There's a slight 
            //  difference here between different types of resources. For example, when you create an 
            //  object of your class or create an int variable, all the resources for those are going 
            //  to be managed by C#, or more precisely, CLR (Common Language Runtime). Such objects 
            //  are sometimes called managed resources. But if you start working with a world outside of your 
            //  application; for example, files on a hard disk drive; then CLR will not help in clearing all 
            //  the resources, and you need to call special functions to do this. 
            //  Here is an example, of using try-catch-finally when working with files:"  
            //  System.IO.StreamReader fileReader = new System.IO.StreamReader("myFile.txt");
            //  int nextCharacter;
            //  try   {       //  Trying to read from file    nextCharacter = fileReader.Read();  }
            //  catch (System.IO.IOException e)  {       // Handle an error
            //      Console.WriteLine($"Error reading from myFile.txt. Message = {e.Message}");   }
            //  finally  {   if (fileReader != null)      {  // Close the file! Cleans up resources in operating system.
            //          fileReader.Close();      }            //  }
            //  // Do something with nextCharacter
            //  "Please, don't be afraid of the functions that you don't know. Even if you have never used 
            //  files in C#, just read the code. It is not that scary," Noname warned, probably because 
            //  I looked stressed while looking at the unknown syntax of reading from a file.  "All you need 
            //  to learn from this example is the try-catch-finally usage. As you see, resource allocation 
            //  happens in the try block; then, deallocation happens in the finally block. The catch block 
            //  handles errors that can occur during reading from the file," Noname explained.
            //  "What if an exception is thrown in the try block, and handled in the catch block? 
            //  Will the finally block still be executed?" I asked.  "Yes, the code in finally (almost) 
            //  always executes. That's why the finally block is used for deallocation of the system 
            //  resources - we need to make sure it always happens."  To the existent try-catch 
            //  construction, add a finally block, in which you release all system resources that 
            //  Noname's reader used. Use a method CleanUpAllResources for this.
            //  "Great, I'll start scanning, Teo. Go have a rest. I'll ping you if I find anything 
            //  interesting about Commander," Noname said, closing the communications channel. 
            //  I wondered if this turned off his mind-reading powers, at least for now.
            //  Waiting wears me down more than work... Keep up the good work at Codeasy
            //  Here is an example, of using try-catch-finally when working with files:" 
            //  Noname explained: "This code can throw at least two different exceptions: 
            //  NullReferenceException and DivideByZeroException. You can write code that handles 
            //  exceptions in a different way depending on their type."  //  public double GetLengthRatio(string s1, string s2, double ratio) { return ratio; }
            //  For int.Parse, this includes ArgumentNullException, ArgumentException, FormatException, and OverflowException. 
            #endregion C# Intermediate>4 A Secret Server>Going deeper in C# Exceptions 
            System.IO.StreamReader fileReader = new StreamReader("myFile.txt"); int[] iArr = { 3, 4, 5, 6 }; int i = -1;
            try
            {
                double ratio = int.Parse(fileReader.Read().ToString()) / s1.Length;
                utl.PrintInColor($"{iArr[i].ToString()}");
            }// sopbpgc
            catch (IndexOutOfRangeException ex)     // Handling IndexOutOfRangeException
            { utl.PrintInColor($"IndexOutOfRange!  Message = {ex.Message}"); }
            catch (IOException ex)                  // Handling IOException
            { utl.PrintInColor($"Error reading.    Message = {ex.Message}"); }
            catch (ArgumentNullException ex)        // Handling ArgumentNullException
            { utl.PrintInColor($"ArgNullExption!   Message = {ex.Message}"); }
            catch (FormatException ex)              // Handling FormatException
            { utl.PrintInColor($"ThatPort isntA#!  Message = {ex.Message}"); }
            catch (OverflowException ex)            // Handling OverflowException
            { utl.PrintInColor($"ThatPort is2big!  Message = {ex.Message}"); }
            catch (NullReferenceException ex)       // Handling NullReferenceException
            { utl.PrintInColor($"AString isNull!   Message = {ex.Message}"); }
            catch (DivideByZeroException ex)        // Handling DivideByZeroException
            { utl.PrintInColor($"Don't / byZero!   Message = {ex.Message}"); }
            catch (Exception ex)                    // Handling all other exceptions
            { utl.PrintInColor($"Unknown error.    Message = {ex.Message}"); }
            finally
            {
                if (fileReader != null)        // Close to release OS resources
                { utl.PrintInColor($"fClosing File.\n"); fileReader.Close(); }
            }
        }
        public static void CSIntrmdtChap5Inheritance(Util utl, bool isConsoleRead = false)
        {
            #region  C# Intermediate>5 The Mystery of the old server>Intro to inheritance  Integrated Emotional Binding
            //  Noname is scanning files at Codeasy  It was incredibly annoying to wait for Noname to scan the 
            //  files on the hidden server. Bored with waiting, I began trawling a local Wonderland network to 
            //  see if I could learn anything new. The first five to ten pages that I looked at was just 
            //  mindless drivel. A few articles about resource gathering in Wonderland, a political one 
            //  describing the importance of resistance, a pity story about a family where she was a 
            //  resistance fighter and he decided to work for the machines. (In the end, she accidentally 
            //  shot him.) Getting discouraged, I started clicking through faster and faster.  Click, click, 
            //  click, wait - go back! On one of the pages, a bold headline that said "Learn About 
            //  Mind-Reading Chips" attracted my attention. Without hesitation, I followed it.
            //  The article began by describing newly discovered chips that the resistance managed to steal 
            //  from machines and which they hoped to one day reproduce. The chips were first found embedded 
            //  into former human prisoners' heads and acted to connect humans to humans and humans 
            //  to ... machines. The first type of connection was described in all possible aspects: 
            //  for instance, a mother could connect with her child to know in-depth how he or she felt. 
            //  In other scenarios, couples connected via one of these chips were discovering something 
            //  new in their relationships; they called it "integrated emotional binding." The second type 
            //  of connection, between humans and machines, was scarcely explained at all. It seemed a bit 
            //  shady that this article would omit the part where enemies were forced to be mentally in sync 
            //  with one another. Why omit the part that we were all fighting to prevent? Aren't there enough 
            //  secrets in this place already?  I wondered if there was a history available for this page. 
            //  Fortunately, there was a log of all changes to this article for the last 5 years. 
            //  There was quite a bit of material, but the most significant change appeared to have 
            //  happened the day before I first arrived at Wonderland. It was titled "Final cleanup." 
            //  I opened it, eager to catch every word.  Of course, I should have known that getting 
            //  any useful information wouldn't be that easy. There was protection on the change log. 
            //  It required knowing something, called "inheritance." The only thing left to do was to 
            //  search for that term in the system and learn enough to get access to the change log. 
            //  The timing of the massive change couldn't be a coincidence, and I had a gut feeling 
            //  something important was hiding in there.    //  Inheritance
            //  Inheritance is a mechanism of basing an object or class upon another object or class, 
            //  retaining similar implementation. Inheritance allows you to re-use functionality that 
            //  is already implemented in another class, and also to add custom logic on top of it. 
            //  For example, let's say you have a class Pet.  
            //  class Pet
            //  {
            //      public string Name { get; set; }            //  
            //      public void PrintName()   {    Console.WriteLine($"My name is {Name}");    }
            //  }
            //  This class really is as simple as it looks. It prints a pet's name to the console when you 
            //  call the PrintName method. Now, let's imagine that your customer made a new request - to 
            //  create a class specifically for a pet cat. It should have the same method, PrintName, 
            //  as well as an additional one, PrintBreed, which prints the cat's breed. To solve this, 
            //  you could create such a class as follows:            //  
            //  class Cat
            //  {
            //      public string Name { get; set; }
            //      public string Breed { get; set; }            //  
            //      public void PrintName()     {          Console.WriteLine($"My name is {Name}");           }
            //      public void PrintBreed()    {          Console.WriteLine($"My breed is {Breed}");         }
            //  }
            //  If you look closer, you can see that the class Cat just duplicated the functionality 
            //  of the class Pet. The code for the property Name and method PrintName are copied from 
            //  the class Pet. This approach has a couple key disadvantages:  The cost of support. 
            //  When you duplicate code, you have more code in general, and you need to support 
            //  all of it. Any change/bugfix that needs to be implemented must be added in each 
            //  copy of the code snippet.  The cost of complexity. A new programmer in your team 
            //  would have a harder time understanding the structure of the project and dependencies 
            //  if there is a lot of duplicate code.  To avoid duplication in the class Cat, we can 
            //  use inheritance. The following is an example of what the code looks like if the class 
            //  is derived from another one:
            //  class Pet
            //  {
            //      public string Name { get; set; }
            //      public void PrintName()    {    Console.WriteLine($"My name is {Name}");    }
            //  }
            //  class Cat : Pet     // Class Cat derives from the class Pet
            //  {
            //      public string Breed { get; set; }
            //      public void PrintBreed()
            //      {     Console.WriteLine($"My breed is {Breed}");    }
            //  }
            //  public class ClassWithMain
            //  {
            //      public static void Main()
            //      {
            //          Cat mrMartin = new Cat
            //          {    Name = "mr Martin", // Prop Name is derived from class Pet    Breed = "Siamese"   };
            //          mrMartin.PrintName();  // PrintName is derived from the class Pet
            //          mrMartin.PrintBreed();
            //      }
            //  }
            //  // Outputs:    // My name is mrMartin    // My breed is Siamese    When you re-use the 
            //  functionality of one class in another one by using inheritance, you are deriving one class 
            //  from another. The class whose members are inherited is called the base class, and the class 
            //  that inherits those members is called the derived class. A derived class can have only one 
            //  direct base class. In our example, class Pet is the base class and the class Cat is a derived one. 
            //  To derive class A from class B, use a colon (:) after the class A name, and then append the name 
            //  for class B. You can treat it as a copy of the code from the class B to class A.  In the example 
            //  above, we derived class Cat from class Pet. Having done that, we can now use the property Name a
            //  nd the method PrintName on every object of type Cat.  As you can see, there is no code duplication 
            //  when you use inheritance. It all happens behind the scenes.  Inheritance in C# at Codeasy
            //  Make the program compile by deriving class Flower from the class Plant. Set flower's 
            //  property Type to Flowering, and then output it to the screen.
            //  
            //  Derive the class Programmer from the class Employee. Inside class Programmer, 
            //  implement a public method IsDepartmentCorrect that returns a bool and takes no arguments. 
            //  The method should return true if the department is IT and false otherwise.
            //  Conceptually, the connection between classes that are represented by inheritance can be 
            //  thought of as an "is" relationship. A derived class is a specialization of the base class. 
            //  In our example: a cat is a pet; that's why Cat derives from Pet. Beginners often wonder 
            //  when one class should or should not derive from another one. A good check would be to 
            //  apply the "is" rule. If one of them "is" another, you can apply inheritance, 
            //  otherwise - don't. Here are some more examples:
            //  Minivan derives from Vehicle. This is the proper usage of inheritance: a minivan is a vehicle.
            //  Student derives from Pet. This is NOT a proper usage of inheritance. A student is NOT a Pet, 
            //  even though they both have names.  When writing code, always check whether inheritance makes 
            //  sense in the current context with the is rule.  From the following list, derive some classes 
            //  from others: Building, Wall, SkyScraper and ClimbingWall. Apply inheritance only in those 
            //  cases where it makes sense. Use the is rule.  From the following list, derive some classes 
            //  from others: Company, Department, MarketingDepartment and EmailCampaignsDepartment. 
            //  Apply inheritance only in those cases where it makes sense. Use the is rule.
            //  Inheritance is transitive. This means if B is derived from C, and A is derived from B, 
            //  then A is also derived from C: 
            //  class C
            //  {    public void PrintCName()
            //      {    Console.WriteLine("I'm class C");    }
            //  }
            //  class B : C
            //  {    public void PrintBName()
            //      {    Console.WriteLine("I'm class B");    }
            //  }
            //  class A : B
            //  {    public void PrintAName()
            //      {    Console.WriteLine("I'm class A");    }
            //  }
            //  public class ClassWithMain
            //  {    public static void Main()
            //      {    var a = new A();
            //          a.PrintAName();
            //          a.PrintBName(); // Inherited from class B
            //          a.PrintCName(); // Inherited from class C
            //      }
            //  }
            //  // Outputs:  // I'm class A   // I'm class B    // I'm class C
            //  As you can see, class A derives from B and B derives from C. Therefore, B gets all functionality 
            //  from C and A gets all functionality from both B and C.  
            #endregion

            //  Inherit classes Parrot, Bird, and Animal from one another in the correct order. Use the is rule. 
            //  The code should compile if you do it correctly.
            //  Implement a method SayHi in the class Parrot. If the parrot is dead it should just 
            //  return. If the parrot is flying, it is quite hard to say anything, and the program 
            //  should output "Fleeeeeee". If the parrot is alive and not flying, it should 
            //  output "Hi".  Note that it is NOT possible to derive a class from more than one class.
            //  class C
            //  {    public void PrintCName()    {    Console.WriteLine("I'm class C");    }    }
            //  class B
            //  {    public void PrintBName()    {    Console.WriteLine("I'm class B");    }    }
            //  class A : B, C // ERROR!!! Can't derive from more than one class
            //  {    public void PrintAName()    {    Console.WriteLine("I'm class A");    }    }
            //  Fix the code to make it compile by adding or replacing an inheritance. It should 
            //  output the text about the square to the screen.
            //  Fix the code to make it compile by adding or replacing an inheritance. It should 
            //  output the text about John to the screen.
            //  Noname was taking so long that I fell asleep while trying to commit all the vageries 
            //  of inheritance to memory. If you have any trouble sleeping, I can heartily confirm 
            //  that reading about inheritance in OOP for twenty minutes will do the trick. 
            //  You are welcome!            //  Something new is coming at Codeasy
            //   //  C# Intermediate>5 The Mystery of the old server>Introduction to inheritance
            //  info@codeasy.net    Have fun and learn programming with codeasy.net © 2019
            //  Make the program compile by deriving class Flower from the class Plant. 
            //  Set flower's property Type to Flowering, and then output it to the screen.
            //
            //  Derive the class Programmer from the class Employee. Inside class Programmer, 
            //  implement a public method IsDepartmentCorrect that returns a bool and takes no 
            //  arguments.The method should return true if the department is IT and false otherwise.
            Parrot polly = new Parrot() { Name = "Polly", isAlive = true, isFlying = false }; utl.PrintInColor(polly.ToString());
            Parrot pauly = new Parrot() { Name = "Pauly", isAlive = true, isFlying = true }; utl.PrintInColor(pauly.ToString());
            new Programmer(utl, "Fin", "Boo"); new Programmer(utl, "IT", "Brice");
            List<int> iListNum = new List<int>() { 10, 20 };
            List<int> iListNumz = new List<int> { 1005671, -567110 };
            //new MyListInt(utl,iListNum);new MyListInt(utl, iListNumz);//new List<int> { 10, 20, 30});
            utl.PrintInColor($"iListNum: {iListNum.ToString2()}  iListNumz: {iListNumz.ToString2()}");
            new Cat(utl, true, false, "Cathy", "Taby"); new Dog(utl, true, false, "Fido", "Dober"); new ComsOut(utl);
            MyAsciiArt1 art1 = new MyAsciiArt1(utl); utl.PrintInColor(art1.Draw(utl)); new Mango(utl, "Mango");
            new Apple(utl, "Apple"); new Driver(utl);
        }
    }
    public interface IBestInTheWorldProgrammer
    {    //  Finish the implementation of the interface IBestInTheWorldProgrammer to make the code compile. 
         //  In the method ReadDocumentation, output to the screen "Sometimes I read the documentation."; 
         //  in the method WriteCode, output "I adore writing code!"   Interface members are automatically public, 
         //  and they can't include any access modifiers.  
         //string Department { get; set; } string Name { get; set; }
        void ReadDocumentation();
        void WriteCode();
    }

    public interface IEmployee { string Department { get; set; } string Name { get; set; } }
    class Programmer : IBestInTheWorldProgrammer, IEmployee // sopbpgc
    {
        //  From the following list, derive some classes from others: Building, Wall, SkyScraper 
        //  and ClimbingWall.Apply inheritance only in those cases where it makes sense.Use the is rule.
        //  class Wall{} class ClimbingWall : Wall {} class Building {} class SkyScraper : Building
        //  From the following list, derive some classes from others: Company, Department, 
        //  MarketingDepartment and EmailCampaignsDepartment. Apply inheritance only in those cases 
        //  where it makes sense. Use the is rule.  class Department {}   class MarketingDepartment : Department {} 
        //  class EmailCampaignsDepartment : Department {}
        public string Name { get; set; }
        public string Department { get; set; }
        public Util Sutil { get; set; }
        public Programmer(Util utl, string dept, string name, bool isConsoleRead = false)
        {
            Department = dept; Name = name; Sutil = utl; // sopbpgc
            utl.PrintInColor($"{(IsDepartmentCorrect(utl, Department) ? $"  {Name} is a PROGRAMMER!" : $"  {Name} is not a programmer")}");
            ReadDocumentation(); WriteCode();
        }
        public bool IsDepartmentCorrect(Util utl, string dept = "IT", bool isConsoleRead = false)
        { if (dept == "IT") isConsoleRead = true; return isConsoleRead; }
        public void ReadDocumentation() { Sutil.PrintInColor($"  I sometimes read docs.  "); }
        public void WriteCode() { Sutil.PrintInColor($"  I adore Programming!  "); }

    }
    class Animal
    {
        public bool isAlive { get; set; }
        public string Name { get; set; }
        public Animal()
        {
            Console.Write($"  class {nameof(Animal)} ");
        }
    }
    class Bird : Animal
    {
        public bool isFlying { get; set; }
        public Bird()
        {
            Console.Write($"class {nameof(Bird)} ");
        }
    }
    class Parrot : Bird
    {
        public Parrot()
        { Console.Write($"class {nameof(Parrot)} "); RunInheritance(); }
        //    public override string ToString()
        //    {
        public override string ToString()
        {   //  Override the ToString method in the class Website to make it output a detail about 
            //  the website in the following format: "{Name}, created in {YearCreated}, with a title 
            //  {Title}".

            StringBuilder sb = new StringBuilder("");
            //  Inherit classes Parrot, Bird, and Animal from one another in the correct order. 
            //  Use the is rule. The code should compile if you do it correctly.
            //  Implement a method SayHi in the class Parrot. If the parrot is dead it should just 
            //  return. If the parrot is flying, it is quite hard to say anything, and the program 
            //  should output "Fleeeeeee". If the parrot is alive and not flying, it should output "Hi". 
            if (isAlive)
            {
                if (isFlying) sb.Append($"If isAlive: {isAlive.ToString()}, IsFlying: {isFlying.ToString()}, {Name} says Fleeeeeee!");
                else sb.Append($"If isAlive: {isAlive.ToString()}, IsFlying: {isFlying.ToString()}, {Name} says Hi!");
            }
            return sb.ToString();
        }
        public static void RunInheritance()
        {
            //  Override method Draw in classes Square and Arrow.  Use the '#' symbol to draw a square. 
            //  The code to read the size of the edge of the square from the console is already in place. 
            //  Fill the inner part of the square with spaces, as shown in the example below.  Under the 
            //  square, draw an arrow by repeating the '-' symbol several times and ending with a '>' symbol, 
            //  like this: ---> The total length of the arrow is equal to the length of the square's edge, 
            //  as shown below.  Example:    >4    ####    #  #    #  #     ####    --->  
        }
        public static void RunInheritance2()
        {
            #region  C# Intermediate>5 The Mystery of the old server>Keywords override sealed and object
            //  Without Hope We Are Useless  Noname woke me up, speaking in my head louder than I 
            //  would have preferred. "Good morning, Teo, I have news for you."  "Good morning," I 
            //  mumbled. "Did I oversleep?"  "You were asleep for 7 hours and 32 minutes," Noname 
            //  stated. "Sorry for interrupting, but I've got news regarding Commander."  "Ahh, yes, 
            //  did you find a lot?" I wondered.  "Oh yes, Teo."  "So, is he a bad guy?"  "Not really..." 
            //  Noname seemed rather confused for a machine.  "A traitor?"  "Not in that sense..."  
            //  "The guessing game is getting a bit old. Can you cut to the chase?" I asked.  "Commander's 
            //  address is 2001:db8:85a3:8d3:1319:8a2e:370:7348. That's a server, Teo. Commander is a 
            //  highly ranked, smart, and secure... server. It's a machine, Teo."  "Wait... What did you 
            //  say?" I said, dumbfounded. "Are you sure, Noname? Have you double-checked? Triple-checked?"
            //  "Yes, both when I first figured it out, as well as again just now. Each check tells me 
            //  it is a machine. The server that we hacked was a part of Commander," Noname explained 
            //  in a calm, serious tone, adding, "I can only imagine how frustrated and confused you 
            //  feel right now."  "Noname, this makes absolutely no sense. Why would a machine lead 
            //  the resistance against machines? What is the point?" I asked.  "The point is to give 
            //  humanity hope for a bright future. Machines studied humans for tens and hundreds of 
            //  years. At some point, it became obvious even to them that a human without hope is 
            //  useless. It can't work, can't follow orders, and it's highly probable to resist. 
            //  The solution that machines came up with was to create a controlled resistance. 
            //  In order to organize, people would need to believe that not everything was lost 
            //  - that they could actually beat the machines if they banded together."  "But humanity 
            //  can't..." I began.  "At least not with the current resistance head," Noname agreed.  
            //  I was so lost, so destroyed, that I had no idea what to do. The only thing I could 
            //  think of doing was asking a machine what I should do about learning that a machine 
            //  was manipulating humans to believe they could beat machines. "Noname, what should 
            //  I do?" I implored.  "I don't know, Teo. But from what I've learned about humans 
            //  and their behaviors, you tend to do utterly illogical things when in a highly 
            //  emotional state. You are clearly in the highly emotional state now, and I'm 
            //  worried about you. I would suggest not taking any actions for a while. What were you 
            //  working on yesterday when I was researching the Commander?"  "I was about to learn 
            //  inheritance to get access to an interesting article in the local network," I answered.
            //  "Great! Please, continue that!"  Noname's reasoning was a bit childish, but still, it 
            //  made some sense. I needed time to digest the truth. Better to keep myself busy than 
            //  letting my mind run wild.  Commander at Codeasy is Machine!!!!Dum Dum Dah Dah!!!
            //  Override Sometimes, you may want to change the functionality of a function in 
            //  the derived class. Using the previous example with classes Pet and Cat, let's 
            //  imagine that when we call a method PrintName on an object of type Cat, we want it 
            //  to print "I'm a cat. My name is {Name}". As such, we need to mark this method with 
            //  the keyword virtual in the class Pet, and use the keyword override in the class Cat. 
            //  This will allow us to change the functionality of the method PrintName as follows:
            //  class Pet    {    public string Name { get; set; }    
            //  public virtual void PrintName() // Virtual method. Now it's possible to override
            //      {    Console.WriteLine($"My name is {Name}");    }    }
            //  class Cat : Pet    { // Class Cat derives from the class Pet
            //  public override void PrintName() // Overriding the method PrintName
            //  {    Console.WriteLine($"I'm a cat. My name is {Name}.");    }     }
            //  class Dog : Pet    { // Class Dog derives from class Pet    //  {}
            //  public class ClassWithMain    {     public static void Main()     {
            //              var cat = new Cat()        {            Name = "mr Martin"        };
            //          cat.PrintName();  // Calls the overridden method from the class Cat
            //          var dog = new Dog()        {            Name = "Hobbit"        };
            //          dog.PrintName();  // Calls the method from the class Pet. No override    }  }
            //  Outputs:  // I'm a cat. My name is mr Martin.  // My name is Hobbit
            //  The virtual keyword marks those methods in the class that can be overridden 
            //  in the derived classes. If a method is not virtual, it can't be overridden.
            //  Change Cat and Dog to output specific sounds when method MakeASound is called. 
            //  You should rename methods MakeDogSound and MakeCatSound and override method MakeASound.
            //  Override method Draw in classes Square and Arrow.  Use the '#' symbol to draw a square. 
            //  The code to read the size of the edge of the square from the console is already in place. 
            //  Fill the inner part of the square with spaces, as shown in the example below.
            //  Under the square, draw an arrow by repeating the '-' symbol several times and 
            //  ending with a '>' symbol, like this: ---> The total length of the arrow is equal 
            //  to the length of the square's edge, as shown below.  Example:  //  >4  ####  #  #  #  #  ####  --->
            //  Sealed
            //  You may run into instances when you want to prohibit derivation from a given class. 
            //  To do this, use the sealed keyword. Because sealed classes can never be used as a base class, 
            //  some run-time optimizations can make calling sealed class members slightly faster.
            //  public sealed class ItIsImpossibleToDeriveFromMe  {    // This class is sealed. It will never be a base class.            //  }
            //  class ThisIsAMistake : ItIsImpossibleToDeriveFromMe    {  // Error. Can't derive from a sealed class.            //  }
            //  public class YouCanDeriveFromMe    {    // This class can be base. No problem.    }
            //  public sealed class SealedChildClass : YouCanDeriveFromMe    {     // This class is sealed. It will never be a base class.            //  }
            //  class ThisIsAMistake : SealedChildClass{    // Error. Can't derive from a sealed class.    }
            //  Make the given class sealed.  Make as many classes as possible sealed. A method or property 
            //  on a derived class that is overriding a virtual member of the base class can declare that 
            //  member as sealed. As a result, the member is not "virtual" anymore, which prevents it from 
            //  being overridden in any further derived class. This is accomplished by putting the sealed 
            //  keyword before the override keyword in the class member declaration. For example:
            //  public class Something    {    public virtual void DoWork()        { }    }
            //  public class ClassWithSealedMethod : Something    {
            //      public sealed override void DoWork()    {     // Can't be overridden in derived classes    }    }
            //  First, make the code compile. Then, make as many overridden methods as possible sealed.
            //  Protected
            //  When class A derives from class B, it gets access to all the public methods, fields, and properties 
            //  of B. However, derived class A does not get access to the private fields of class B:
            //  class B    {    private int _privateField;    private int PrivateMethod() { return 23; }
            //      private int PrivateProperty { get; set; }    public int PublicField;    public int PublicMethod() { return 23; }
            //      public int PublicProperty { get; set; } }
            //  class A : B    {    public void DoWork()    {    var a = _privateField;   // Error! Can't access private field of the base class
            //      var b = PrivateMethod(); // Error! Can't access private method of the base class
            //      var c = PrivateProperty; // Error! Can't access private property of the base class
            //      var d = PublicField;     // Ok. Can access public field of the base class
            //      var e = PublicMethod();  // Ok. Can access public method of the base class
            //      var f = PublicProperty;  // Ok. Can access public property of the base class     }    }
            //  There is a special access modifier, Protected, to deal with access levels during inheritance. 
            //  Protected fields, methods, and properties are accessible from the class itself and from all 
            //  derived classes, but not from outside the class. In other words, protected elements are public 
            //  for derived classes and private for the outer world. Microsoft provides a great C# access 
            //  modifier table that provides more information about accessibility levels in C#.
            //  C Sharp Protected:  class A    {    protected int ProtectedField;    protected int ProtectedMethod() { return 23; }
            //      protected int ProtectedProperty { get; set; }    }    class B : A    {    public void DoWork()
            //      {    var a = ProtectedField;    // Ok, can access protected field of the base class
            //           var b = ProtectedMethod(); // Ok, can access protected method of the base class
            //           var c = ProtectedProperty; // Ok, can access protected property of the base class    }    }
            //  public class ClassWithMain    {    public static void Main()    {        var a = new A();
            //   a.ProtectedFiled = 23;    // Error! Can't access a protected field outside of the class
            //   a.ProtectedMethod();      // Error! Can't access a protected method outside of the class
            //   a.ProtectedProperty = 12; // Error! Can't access a protected property outside of the class   }    }
            //  While using object-oriented design in your programming, try to control access as much as possible. 
            //  Declare all members that are internal to the class with a private modifier. Then, mark those that 
            //  make sense to use in derived classes with a protected modifier and those that should be accessible 
            //  from the outside with a public modifier.  Use an UpperCamelCase for protected fields.
            //  Make the program compile and output info about Earth to the screen by adding protected modifiers where needed.  
            //  Set the access modifier of every member in the class Furniture to the least-accessible one. 
            //  Choose access levels from public, protected, and private. Don't change anything else in the predefined code.
            //  Object
            //  In C#, each class implicitly inherits from a particular class called Object or object.
            //  Class Object has several virtual methods that you can override in your class. We'll take a closer 
            //  look at one of them:  public virtual string ToString ();
            //  You can imagine every class as having : object appended to it. What You Write What the Compiler Sees
            //  class MyClass    {}    class Object    {      public virtual string ToString ();    } // Other members
            //  class MyClass : Object {    } When you call Console.WriteLine() on an object of any class, 
            //  it first calls ToString on the object, and then prints the return value to the console.
            //  You can override the ToString method in your class if you want to use a particular format or style 
            //  whenever you call Console.WriteLine(). Here is an example with a class Point.
            //  class Point   {    public int X { get; set; }    public int Y { get; set; }
            //      public override string ToString()    {        return $"[{X}, {Y}]";    }    }    
            //  public class ClassWithMain    {        public static void Main()    {  var point = new Point { X = 23, Y = 32  };
            //  Console.WriteLine(point);    }    }   // Outputs:  // [23, 32]
            //  Override the ToString method in the class Website to make it output a detail 
            //  about the website in the following format: "{Name}, created in {YearCreated}, with a title {Title}".
            //  You are given a class MyIntArray, which is a wrapper around a typical C# array. 
            //  The purpose of this class is to override the ToString method so that the array 
            //  is easy to output using Console.WriteLine.  Your task is to override the ToString method 
            //  in the class MyIntArray and output a string that contains all elements of the array 
            //  constructed in the following manner:  First, an opening a square bracket followed by a space: "[ "
            //  Then, all elements, one by one, separated by a comma and a space: 1, 2, 3, 4 
            //  Finally, finish with a space and a closing square bracket: " ]"
            //  The code that reads an array and prints it is already in place. Here is an example output:
            //  >5    >100    >-56    >71    >1    >0    [ 100, -56, 71, 1, 0 ]
            //  You did it
            //  C# Intermediate>5 The Mystery of the old server>Keywords override sealed and object 
            //  info@codeasy.net  Have fun and learn programming with codeasy.net © 2019
            #endregion
        }
    }
    //  class MyListInt 
    //  {
    //  //  You are given a class MyIntArray, which is a wrapper around a typical C# array. 
    //  The purpose of this class is to override the ToString method so that the array 
    //  is easy to output using Console.WriteLine.  Your task is to override the ToString method 
    //  in the class MyIntArray and output a string that contains all elements of the array 
    //  constructed in the following manner:  First, an opening a square bracket followed by a space: "[ "
    //  Then, all elements, one by one, separated by a comma and a space: 1, 2, 3, 4 
    //  Finally, finish with a space and a closing square bracket: " ]"
    //  The code that reads an array and prints it is already in place. Here is an example output:
    //  >5    >100    >-56    >71    >1    >0    [ 100, -56, 71, 1, 0 ]
    //      public List<int> iNum { get; set; }
    //      public MyListInt(Util utl, List<int> inum) { iNum = inum; utl.PrintInColor($"  {ToString()}"); }
    //      //  class Point   {    public int X { get; set; }    public int Y { get; set; }
    //      public override string ToString()    {        return $"[{X}, {Y}]";    }    }    
    //  public class ClassWithMain    {    public static void Main()    {  var point = new Point { X = 23, Y = 32  };
    //  Console.WriteLine(point);    }    }   // Outputs:  // [23, 32]
    //      public override string ToString()
    //      {
    //          string sStart = nameof(iNum);
    //          StringBuilder sb = new StringBuilder(/*sStart +*/ "  [ "); int count = iNum.Count() - 1;
    //          for (int i = 0; i < count ; i++) {
    //              sb.Append($"{iNum[i]}, "); }
    //          //if (count < 3) sb.Append($"{iNum[count-1]}, ");
    //          sb.Append($"{iNum[count]} ]");
    //          return sb.ToString();
    //      }
    //  }

    class Square : Arrow
    {
        public Square() { }
        //public virtual void Draw() { }
    }
    class Arrow
    {
        public Arrow() { }
        public virtual string Draw(Util utl, int count = 4) { return ""; }
    }
    class MyAsciiArt1 : Square
    {
        //  Override method Draw in classes Square and Arrow.
        //  Use the '#' symbol to draw a square.The code to read the size of the edge of the square 
        //  from the console is already in place. Fill the inner part of the square with spaces, as 
        //  shown in the example below.  Under the square, draw an arrow by repeating the '-' symbol 
        //  several times and ending with a '>' symbol, like this: ---> The total length of the arrow 
        //  is equal to the length of the square's edge, as shown below.
        //  Example:
        //  >4
        //  ####
        //  #  #
        //  #  #
        //  ####
        //  --->
        public MyAsciiArt1(Util utl)
        {
            RunAArt1(utl);
        }
        public override string Draw(Util utl, int count = 4)
        {
            StringBuilder sb = new StringBuilder("");
            StringBuilder arrowsb = new StringBuilder("");
            string topB = utl.TextRepeater("@", count); Console.WriteLine();
            string mid = "@" + utl.TextRepeater(" ", count - 2) + "@";
            sb.AppendLine(topB);
            for (int i = 2; i < count; i++) { sb.AppendLine(mid); }
            sb.AppendLine(topB);
            sb.AppendLine(utl.TextRepeater("=", count - 1) + ">");
            return sb.ToString();
        }
        public static void RunAArt1(Util utl)
        { }
    }
    public interface IFruit { string Name { get; set; } }
    class Apple : IFruit
    {
        public string Name { get; set; }
        public Apple(Util utl, string name, string className = "IFruit") { SumBetween sum = new SumBetween(); sum.PrintGeneric(utl, className, name); }
    }
    class Mango : IFruit
    {
        public string Name { get; set; }  // mango and apple used to have a [Name = name;] clause. it actually used the [interface IFruit]
        public Mango(Util utl, string name, string className = "IFruit") { SumBetween sum = new SumBetween(); sum.PrintGeneric(utl, className, name); }
        //  Create a class Mango that implements the interface IFruit. Let it return "Mango" as its name. 
        //  Then, in the Main method, create an object of type Mango and pass it to the method PrintName. 
        //  The order of calls to PrintName should be: first apple, then mango.
    }
    //  In the Main method, create two string rules of types NoDoubleSpaces and IsShort. 
    //  Call the method DoesTheRuleApply two times, once for each rule. Assign the result to the 
    //  corresponding variables hasNoDoubleSpaces and isShort. You also need to call 
    //  the method AppliesToString inside the method DoesTheRuleApply. 
    //  Set the type IStringRule to the method's parameter rule. 
    //  Don't change any function or parameter names.  
    //  Polymorphism (C# Programming Guide)  07/19/2015  7 minutes to read  +9
    //  Polymorphism is often referred to as the third pillar of object-oriented programming, 
    //  after encapsulation and inheritance. Polymorphism is a Greek word that means "many-shaped" 
    //  and it has two distinct aspects:
    //  
    //  At run time, objects of a derived class may be treated as objects of a base class in places 
    //  such as method parameters and collections or arrays. When this occurs, the object's declared 
    //  type is no longer identical to its run-time type.  
    //  Base classes may define and implement virtual methods, and derived classes can override them, 
    //  which means they provide their own definition and implementation. At run-time, when client code 
    //  calls the method, the CLR looks up the run-time type of the object, and invokes that override 
    //  of the virtual method. Thus in your source code you can call a method on a base class, 
    //  and cause a derived class's version of the method to be executed.
    //  Virtual methods enable you to work with groups of related objects in a uniform way. For example, 
    //  suppose you have a drawing application that enables a user to create various kinds of shapes on a 
    //  drawing surface. You do not know at compile time which specific types of shapes the user will create. 
    //  However, the application has to keep track of all the various types of shapes that are created, 
    //  and it has to update them in response to user mouse actions. 
    //  You can use polymorphism to solve this problem in two basic steps:
    //  Create a class hierarchy in which each specific shape class derives from a common base class.
    //  Use a virtual method to invoke the appropriate method on any derived class through a single call 
    //  to the base class method.
    //  First, create a base class called Shape, and derived classes such as Rectangle, Circle, and Triangle. 
    //  Give the Shape class a virtual method called Draw, and override it in each derived class to draw the 
    //  particular shape that the class represents. Create a List<Shape> object and add a Circle, Triangle 
    //  and Rectangle to it. To update the drawing surface, use a foreach loop to iterate through the list 
    //  and call the Draw method on each Shape object in the list. Even though each object in the list has 
    //  a declared type of Shape, it is the run-time type (the overridden version of the method in each 
    //  derived class) that will be invoked.  
    //  C#  Copy  using System;  using System.Collections.Generic;
    //  public class Shape  {      // A few example members
    //      public int X { get; private set; }    public int Y { get; private set; }
    //      public int Height { get; set; }       public int Width { get; set; }
    //      public virtual void Draw()            {    Console.WriteLine("Performing base class drawing tasks");    }    } // Virtual method
    //  class Circle : Shape    
    //  {    public override void Draw()    {    Console.WriteLine("Drawing a circle");        base.Draw();    }    }  // Code to draw a circle...
    //  class Rectangle : Shape 
    //  {    public override void Draw()    {    Console.WriteLine("Drawing a rectangle");     base.Draw();    }    }  // Code to draw a rectangle...
    //  class Triangle : Shape  
    //  {    public override void Draw()    {    Console.WriteLine("Drawing a triangle");      base.Draw();    }    }  // Code to draw a triangle... 
    //  class Program    {      
    //  static void Main(string[] args)     {    // Polymorphism at work #1: a Rectangle, Triangle and Circle can all be used whereever a Shape is expected. 
    //  No cast is required because an implicit conversion exists from a derived class to its base class.
    //  var shapes = new List<Shape>        {    new Rectangle(),  new Triangle(),  new Circle()    };    
    //  Polymorphism at work #2: the virtual method Draw is invoked on each of the derived classes, not the base class.
    //  foreach (var shape in shapes)       {    shape.Draw();    }        // Keep the console open in debug mode.
    //  Console.WriteLine("Press any key to exit.");         Console.ReadKey();    }    }
    //  Output:    Drawing a rectangle      Performing base class drawing tasks
    //             Drawing a triangle       Performing base class drawing tasks
    //             Drawing a circle         Performing base class drawing tasks    */
    //  In C#, every type is polymorphic because all types, including user-defined types, inherit from 
    //  Object.  Polymorphism Overview      Virtual Members
    //  When a derived class inherits from a base class, it gains all the methods, fields, properties 
    //  and events of the base class. The designer of the derived class can choose whether to override 
    //  virtual members in the base class, inherit the closest base class method without overriding it
    //  define new non-virtual implementation of those members that hide the base class implementations
    //  A derived class can override a base class member only if the base class member is declared as 
    //  virtual or abstract. The derived member must use the override keyword to explicitly indicate 
    //  that the method is intended to participate in virtual invocation. The following code provides an example: 
    //  public class BaseClass    {        public virtual void DoWork() { }     public virtual int WorkProperty
    //  {    get { return 0; }    }    }    
    //  public class DerivedClass : BaseClass    {    
    //         public override void DoWork() { }    public override int WorkProperty  {  get { return 0; }  }  }
    //  Fields cannot be virtual; only methods, properties, events and indexers can be virtual. 
    //  When a derived class overrides a virtual member, that member is called even when an instance of 
    //  that class is being accessed as an instance of the base class. The following code provides an example:
    //  DerivedClass B = new DerivedClass();    B.DoWork();  // Calls the new method.
    //  BaseClass A = (BaseClass)B;    A.DoWork();  // Also calls the new method.
    //  Virtual methods and properties enable derived classes to extend a base class without needing to use 
    //  the base class implementation of a method.For more information, see Versioning with the Override and 
    //  New Keywords.An interface provides another way to define a method or set of methods whose 
    //  implementation is left to derived classes. For more information, see Interfaces.
    //  Hiding Base Class Members with New Members: If you want your derived member to have the same name 
    //  as a member in a base class, but you do not want it to participate in virtual invocation, you can 
    //  use the new keyword.The new keyword is put before the return type of a class member that is being 
    //  replaced. The following code provides an example:
    //  public class BaseClass    {    public void DoWork() { WorkField++; }    public int WorkField;
    //  public int WorkProperty   {    get { return 0;   }  }  }
    //  public class DerivedClass : BaseClass    {    public new void DoWork() { WorkField++; }
    //  public new int WorkField;      public new int WorkProperty        {     get { return 0; }    }    }
    //  Hidden base class members can still be accessed from client code by casting the instance of the 
    //  derived class to an instance of the base class. For example:
    //  DerivedClass B = new DerivedClass();    B.DoWork();  // Calls the new method.
    //  BaseClass A = (BaseClass)B;             A.DoWork();  // Calls the old method.
    //  Preventing Derived Classes from Overriding Virtual Members: Virtual members remain virtual 
    //  indefinitely, regardless of how many classes have been declared between the virtual member 
    //  and the class that originally declared it.If class A declares a virtual member, and class B 
    //  derives from A, and class C derives from B, class C inherits the virtual member, and has the 
    //  option to override it, regardless of whether class B declared an override for that member. 
    //  The following code provides an example:  
    //  public class A        {    public virtual void DoWork() { }    }
    //  public class B : A    {    public override void DoWork() { }   }
    //  A derived class can stop virtual inheritance by declaring an override as sealed. This requires 
    //  putting the sealed keyword before the override keyword in the class member declaration. 
    //  The following code provides an example:
    //  public class C : B    {    public sealed override void DoWork() { }    }
    //  In the previous example, the method DoWork is no longer virtual to any class derived from C. 
    //  It is still virtual for instances of C, even if they are cast to type B or type A. 
    //  Sealed methods can be replaced by derived classes by using the new keyword, as the following example shows:
    //  public class D : C    {    public new void DoWork() { }    }
    //  In this case, if DoWork is called on D using a variable of type D, the new DoWork is called.
    //  If a variable of type C, B, or A is used to access an instance of D, a call to DoWork will 
    //  follow the rules of virtual inheritance, routing those calls to the implementation of DoWork 
    //  on class C. Accessing Base Class Virtual Members from Derived Classes: 
    //  A derived class that has replaced or overridden a method or property can still access the method 
    //  or property on the base class using the base keyword.The following code provides an example:
    //  public class Base    {        public virtual void DoWork() {/*...*/ }    }
    //  public class Derived : Base    {        public override void DoWork()    {
    //  Perform Derived's work here    ...      Call DoWork on base class        base.DoWork();    }    }
    //  For more information, see base. Note: It is recommended that virtual members use base to call the 
    //  base class implementation of that member in their own implementation. Letting the base class 
    //  behavior occur enables the derived class to concentrate on implementing behavior specific to 
    //  the derived class. If the base class implementation is not called, it is up to the derived 
    //  class to make their behavior compatible with the behavior of the base class. In This Section
    //  Versioning with the Override and New Keywords: Knowing When to Use Override and New Keywords:
    //  How to override the ToString method 

    public interface ICommunicationModule { void CommunicationToWonderland(); void ComsToTeo(); }
    class ComsOut : ICommunicationModule
    {
        //  Create your own public implementation of ICommunicationModule
        //  named CommunicationToTeo that is an exact copy of CommunicationToWonderland with one exception: 
        //  instead of the string "Opening communication channel to Wonderland" it should say "Opening 
        //  communication channel to Teo". Then, replace the communication module that is used in the 
        //  Main method with the newly created CommunicationToTeo.  
        public Util Sutil { get; set; }
        public ComsOut(Util utl)
        { Sutil = utl; CommunicationToWonderland(); ComsToTeo(); }
        public void CommunicationToWonderland() { Console.Write(""); }
        public void ComsToTeo() { Sutil.PrintInColor($"  Opening communication channel to Teo  "); }
    }
    interface ICar { Util Sutily { get; set; } void Accelerate(); }
    class Hybrid : ICar
    {
        public Util Sutily { get; set; }
        public void Accelerate() { Sutily.PrintInColor($"  Accelerating a hybrid car.  "); }
    }
    class ElectricCar : ICar
    {
        public Util Sutily { get; set; }
        public void Accelerate() { Sutily.PrintInColor($"  Accelerating an electric car.  "); }
    }
    class PetrolCar : ICar
    {
        public Util Sutily { get; set; }
        public void Accelerate() { Sutily.PrintInColor($"  Accelerating a petrol car.  "); }
    }
    class Driver
    {
        public Util Sutil { get; set; }
        public Driver(Util utl)
        { Sain(utl); }
        public void Sain(Util utl)
        {

            ElectricCar electricCar = new ElectricCar(); PetrolCar petrolCar = new PetrolCar(); Hybrid hybrid = new Hybrid();
            electricCar.Sutily = petrolCar.Sutily = hybrid.Sutily = utl;
            AccelerateCar(electricCar); AccelerateCar(petrolCar); AccelerateCar(hybrid);
        }  // Accelerates any car that implements ICar!!!
        public void AccelerateCar(ICar car) // <-- Magic!     
        { car.Accelerate(); }
    } // Outputs:
      //  // Accelerating an electric car.  // Accelerating a petrol car.

    class Pet : Animal
    {
        public bool isWalking { get; set; }
        public string Breed { get; set; }
        public Pet()
        { Console.Write($"class {nameof(Pet)} "); }
        public virtual void PetPrint(Util utl) { Console.Write($"{Name} a {Breed} says FUCK YOU!"); }
    }
    class Dog : Pet
    {

        public Dog(Util utl, bool islive, bool iswalking, string name, string breed)
        {
            isAlive = islive; isWalking = iswalking; Name = name; Breed = breed;
            Console.Write($"class {nameof(Dog)} "); PetPrint(utl);
        }
        public override void PetPrint(Util utl)
        { utl.PrintInColor($"{Name} a {Breed} says woof"); }
    }
    class Cat : Pet
    {
        public Cat(Util utl, bool islive, bool iswalking, string name, string breed)
        {
            isAlive = islive; isWalking = iswalking; Name = name; Breed = breed;
            Console.Write($"class {nameof(Cat)} "); PetPrint(utl);
        }
        public override void PetPrint(Util utl)
        { utl.PrintInColor($"{Name} a {Breed} says meow"); }

    }
    #region  C# Intermediate>6 One step ahead>Interfaces in C#    I Know Exactly What To Do
    //  I'd lost all interest in the article about machine-to-human binding. I'll come back 
    //  to it later, I thought. All I could think about now was Commander and Wonderland. 
    //  What should I do?  "I think your point of view is slightly pessimistic," I heard as 
    //  Noname entered my thoughts again.  "Why?" I said. "We just discovered that humanity's 
    //  only hope is imaginary. How could that possibly not sound pessimistic? 
    //  It's a full-fledged disaster!""Well, is it okay if I share my point of view?" Noname 
    //  asked respectfully.  "Sure, go ahead," I answered.  "Based on what we learned about 
    //  Commander, humanity has been completely controlled by machines for quite a while, right? 
    //  Controlled at such a high level that humanity didn't even know about it. That's an 
    //  accurate summary of yesterday, yes?" Noname asked.  "Right," I agreed, not feeling 
    //  any better about my predicament at this point.  Noname continued, "And today is the 
    //  first day that you know about this fact. Now, what does that mean?"  I had to stop and 
    //  think for a moment. Everything had been happening so fast lately. After a few seconds, 
    //  I started to realize where Noname was leading me. "They don't know that I know!" 
    //  I shouted in my head. "The machines have no clue that we know who... or what... 
    //  Commander is," I shouted.  "Exactly, Teo. Today is the first day that you are one step 
    //  ahead of the machines. Let's not miss this opportunity."  "Thank you, Noname. Now I know 
    //  exactly what to do," I exclaimed.  "Happy to help my human friends," he said. "If I may ask, 
    //  what is your next action?"  "You'll see..."  Codeasy Communication Module  Interfaces
    //  Once I had settled down at a terminal, I pinged Noname again in my head. "Noname, I 
    //  need you to show me the Commander's communication module. I need to see how it sends 
    //  and receives commands," I said.  "Got it. Here it is:"  
    //  public interface ICommunicationModule
    //  {    void Send(string message);    string Receive();    }
    //  public class CommunicationSystem
    //  {    private ICommunicationModule _communicationModule;
    //  public CommunicationSystem(ICommunicationModule module)
    //  {    _communicationModule = module;    }
    //  public void SendMessage(string message)
    //  {    Console.WriteLine("Opening communication channel Wonderland");    
    //      _communicationModule.Send(message);    }
    //  public string ReceiveMessage()
    //  {    Console.WriteLine("Opening communication channel to Wonderland");
    //          return _communicationModule.Receive();    }
    //  }
    //  I was pretty sure that modifying this module would help my cause, but I 
    //  couldn't understand how it worked. "Noname, can you please give me a 
    //  crash course on interfaces?" I asked. "I've heard about this concept a couple 
    //  times, but we never covered it in class."  "Sure, it would be a pleasure to 
    //  explain it to you."  "An interface is an abstraction that indicates what a 
    //  class that implements it can do. An interface contains functionalities that 
    //  a class can implement."  "Noname, no matter how hard you try to explain 
    //  things in simple terms, I can never get it until you show me an example," 
    //  I said, hoping I didn't come off as sarcastic.  She agreed and sent said 
    //  example to my terminal:
    //  public interface IClonable
    //  {    object Clone();    }
    //  "Here you can see an interface 
    //  IClonable. It declares one method called Clone. This interface tells us 
    //  'every class that implements me should have a method Clone.' Are you following?" 
    //  Noname asked.  "Kind of... How do you use it?" I replied.  
    //  public class Car : IClonable
    //  {
    //  
    //  public object Clone() // This method implements method Clone from the interface
    //  {    return new Car();    }   }

    //  "Here is a class Car that implements IClonable. To properly implement interface 
    //  IClonable, class Car should have a public method Clone that returns object."
    //  "Ok, got it," I said. "The interface acts as a base class, but instead of 
    //  implementing methods, it only declares them," I said, reinterpreting Noname's words.
    //  "Exactly, Teo! Now, I should emphasize several constraints and differences between 
    //  the usage of interfaces and classes. I'll give you some practical assignments to 
    //  ensure you understand what I mean," Noname replied.  "Sure, but first... Why do 
    //  all of your interface names start with an I?" I asked.  "This is another name 
    //  convention in C#. Always start your interface name with a letter 'I'," he replied, 
    // "like IConvertable, IClonable, ICat, IDog. Ok - now a few facts about interfaces 
    //  that you'd better remember."  C Sharp Naming Conventions Flowchart  
    //  An interface can contain methods or properties but not fields, constants, or constructors.
    //  Incorrect	Correct
    //  public interface IWorker
    //  {    string Name;    // No - Fields forbidden  const int Age;  // No - Constants forbidden
    //      IWorker();      // No - Constructors forbidden
    //  }
    //  public interface IWorker
    //  {
    //      string Name { get; }
    //      void DoWork();
    //  }
    //  Delete from the interface IFactory forbidden members to make the program compile. Don't delete valid members!
    //  
    //  A class can inherit from multiple interfaces, but only from one class. To derive from several interfaces, list them separated by a comma, as shown in the next example.
    //  "Here's a comparison table that shows the difference between derivation from two interfaces and two classes," Noname said. "It is absolutely valid to derive a class or interface from as many interfaces as you want, but you cannot derive from more than one class."

    //  Incorrect	                                        Correct
    //  public class Worker                             public interface IWorker
    //  {                                               { 
    //      public virtual void DoWork()                     void DoWork()
    //      {        // Some code    }                       void PrintResult()
    //      public virtual void PrintResult()            }
    //      {        // Some code    }
    //  }
    //  public class Person                              public interface IPerson
    //  {    public virtual string GetName()             {      string GetName();       }
    //       {    // Some code      }                    // This is OK: derive from two interfaces     
    //  }                                                public class Worker : IWorker, IPerson
    //  // Wrong! Con't derive from two classes          {    public void DoWork()    
    //  public class HumanWorker : Worker, Person             {    //  some code    } 
    //  {      // Some code      }                            public void PrintResult()
    //                                                        {    //  some code    } 
    //                                                        public string GetName()
    //                                                          {    // Some code     }    }
    //  Remove double inheritance from classes by converting classes HouseForSale and Property 
    //  to interfaces. Add "I" at the beginning of their names to get IHouseForSale and IProperty.
    //  Remove double inheritance from classes by converting class SoftwareDeveloper to an interface. 
    //  Add "I" at the beginning of its name to get ISoftwareDeveloper.  If a class implements an 
    //  interface, it must implement all of its members.  "Here's another diagram," Noname said. 
    //  "To the left, you see the code where I forgot to implement a method PrintResult from the 
    //  interface IWorker;             //  to the right, a fixed version of that code."
    //  Incorrect	                            Correct
    //  public interface IWorker                public interface IWorker
    //  {                                       {
    //      void DoWork();                          void DoWork();                          
    //      void PrintResult();                     void PrintResult();
    //  }                                       }
    // Implements both methods from IWorker
    //  public class Worker : IWorker               public class Worker : IWorker
    //  {   public void DoWork()                    {    public void DoWork()
    //        {    Do some stuff    }                      {     Do some stuff    }
    // Method PrintResult is not implemented!            public void PrintResult()
    // This will generate a compiler error.              {     Print something    }    }
    //  Finish the implementation of the interface IBestInTheWorldProgrammer to make the code compile. 
    //  In the method ReadDocumentation, output to the screen "Sometimes I read the documentation."; 
    //  in the method WriteCode, output "I adore writing code!"  Interface members are automatically 
    //  public, and they can't include any access modifiers.  
    //  Incorrect	                                    Correct
    //  public interface IWorker                        public interface IWorker
    //  {                                               {
    //  // Wrong. Can't have access modifiers here          // Right. No access modifier
    //  protected string Name { get; }                      string Name { get; }

    //    // Wrong. Can't have access modifiers here        // Right. No access modifier
    //  public void DoWork();                               void DoWork();
    //  }                                               }

    //  Remove access modifiers from an interface to make the code compile.

    //  When a class implements an interface, it must have a public access modifier for all 
    //  members that implement an interface.  "Looking at the following comparison table, 
    //  pay attention to access modifiers for each method and property," Noname said.

    //  Incorrect	                                        Correct
    //  public interface IWorker                        public interface IWorker
    //  {                                               {
    //      string Name { get; }                            string Name { get; }
    //      void DoWork();                                  void DoWork();
    //  }                                               }

    //  public class Worker : IWorker                   public class Worker : IWorker
    //  {                                               {
    // Doesn't implement interface                  //  public method implements interface
    //      private void DoWork()   // Wrong                public void DoWork()
    //      {                                               {
    //      }                                               }

    // Doesn't implement interface                  // Public property implements interface
    //  protected string Name { get; }  // Wrong            public string Name { get; }  // Right
    //                                                      }
    //                                                        }
    //  Change access modifiers to make the code compile.

    //  An interface can't have implementation of methods; only declaration.  "There are no 
    //  secrets to this rule," Noname explained. "Just don't implement anything in the 
    //  interface. Leave implementation to a derived class."

    //  Incorrect	                                       Correct 
    //                                                     public interface IWorker
    //  public interface IWorker                           {
    //  {                                                        string Name { get; } // Right
    // Error! Can't have implementation here!      
    //      string Name { get { return "John"; } }               void DoWork();       // Right, no implementation
    //                                                     }
    // Error! Can't have implementation here!                         
    //      void DoWork()                                  public class Worker : IWorker
    //      {                                              {
    //          // Some code                                   public void DoWork()
    //      }                                                  {
    //  }                                                            // Implementation of the method
    //                                                          }

    //                                                       public string Name
    //                                                       {
    //                                                          get
    //                                                          {
    //                                                              //  Implementation of the property
    //                                                          }
    //                                                       }
    //                                                     }
    //  Remove implementation and all forbidden members from the interface IMessage. 
    //  Move them to the class Message, so that class Message implements interface IMessage. 
    //  Your program should compile.  "Thanks, Noname, this is plenty of information about interfaces. 
    //  Unfortunately, all this information doesn't help that much, because I don't know how to apply 
    //  it to my cause... If I want to replace an existing implementation with my own, say, 
    //  on Commander's server, how do I do that?" I asked.  "You need to use polymorphism," he answered.
    //  "Can you tell me about that as well?"  "Sure, so listen..."  Adventure awaits you at Сodeasy
    #endregion //  C# Intermediate>6 One step ahead>Interfaces in C#    Email:info@codeasy.net    Have fun and learn programming with codeasy.net © 2019     
    #region   C# Intermediate>6 One step ahead>Polymorphism   Polymorphism
    //  "You promised to explain where interfaces are used in C#," I reminded Noname after a quick 
    //  lunch break.  "Ahh, yes," Noname replied. "I like how curious you are!"  "It's not curiosity; 
    //  I need to isolate Commander," I said. It was strange that Noname didn't know my true intentions, 
    //  given that he could read my mind.  "Let's start with high-level concepts," Noname said. 
    //  "Imagine you just climbed into a new car. You take the driver seat, keys in hand. 
    //  What do you need to know to start this vehicle and drive somewhere?" Noname asked.
    //  "Basically, nothing. I just turn the key and drive. Why do you ask such weird questions?" I asked.
    //  He ignored my question and continued, "Do you need to know what type of brakes the car has in order 
    //  to use them?"  I answered, "Nope, when I press the brake pedal, the car brakes. That's all I need 
    //  to know."  "Exactly! What about the fuel; do you need to know whether it runs on electric or petrol?" 
    //  Noname continued   his line of questioning.  "Not as long as whatever it runs on is full," I said. 
    //  "I can drive it regardless of what type of engine it has. The experience might be different, 
    //  but I'd still be able to drive it," I explained.  "Super! Now, what gives you the ability to 
    //  drive any car? Why can't you program in any programming language, but you can drive any car?"
    //  "Because cars have common rules of how to use them. You turn a steering wheel, and the car turns, 
    //  you press a pedal and car accelerates. What are you trying to say, Noname?" I was puzzled.
    //  "I'm saying that all cars have the same interface. You don't know exactly how the car works 
    //  under the hood, but you know how to use the common interface that is implemented in all cars. 
    //  The existence of the interface is what gives you the abiity to drive any car," Noname exclaimed. 
    //  This was the key thought that he was heading to.  "Okay, I think I get what you mean. What does 
    //  it have to do with... wait, you're saying that interfaces in C# solve the same problem?" It took 
    //  a while, but I had finally arrived at the answer.  "Exactly, Teo. You have a very sharp mind. 
    //  An interface provides a common way to interact with all classes that implement it. The ability 
    //  to work with different classes via the same interface is called polymorphism." Noname finally 
    //  explained this strange word.  "It sounds like polymorphism is the ability to drive different 
    //  cars that all use the same controls," I commented.  "This is exactly what I'm saying! Take a 
    //  look at this code example," he said, displaying some text right in my mind.  The Car Interface
    //  public interface ICar  {  void Accelerate();  }
    //  public class ElectricCar : ICar  {  public void Accelerate()  {  Console.WriteLine($"Accelerating an electric car.");  }  }
    //  public class PetrolCar : ICar    {  public void Accelerate()  {  Console.WriteLine($"Accelerating a petrol car.");  }  }
    //  public class Driver    {  public static void Main()  
    //  {  ElectricCar electricCar = new ElectricCar();    PetrolCar petrolCar = new PetrolCar();
    //      AccelerateCar(electricCar);    AccelerateCar(petrolCar);  }  // Accelerates any car that implements ICar!!!
    //  private static void AccelerateCar(ICar car) // <-- Magic!     {  car.Accelerate();  }  } // Outputs:
    //  // Accelerating an electric car.  // Accelerating a petrol car.
    //  After giving me some time to look through the code, Noname asked, "Do you see the beauty of what 
    //  is happening here?"  "I think so," I replied. "Let me try to sort this out myself. So you have 
    //  an interface ICar, and two classes that implement it: ElectricCar and PetrolCar. 
    //  Then, in the Main method, you create two objects: one of type ElectricCar and one 
    //  of type PetrolCar. Then you pass those objects to the method AccelerateCar. Wait! 
    //  This method takes ICar - how does it even compile?"  "All the magic happens in 
    //  the Accelerate method," Noname replied. "Polymorphism gives you the ability to pass any class 
    //  that implements the ICar interface to the method AccelerateCar. It is possible because the 
    //  type of the argument car in the AccelerateCar method is an ICar, not a specific PetrolCar 
    //  or ElectricCar.  "As always, Nonames first explanation was a bit too technical for me to 
    //  grasp it all.  "Noname, does the object change when it has a different type inside of the 
    //  method?" I asked.  "When the object electricCar, after being passed to the method as a 
    //  parameter, has a type ICar, it is not changed, but the way the receiving side sees it 
    //  does change. The object electricCar continues to have the type ElectricCar, and an 
    //  object petrolCar will still be of type PetrolCar. The trick is that inside the method 
    //  AccelerateCar, both of their types are ICar. And the best thing about it - you don't need 
    //  to know the exact type. You operate via an interface, the same as you do with the real car. 
    //  You accelerate by pressing the pedal!" Noname's voice sounded excited. Either he had 
    //  discovered a newfound appreciation for cars, or polymorphism was one of his favorite subjects.
    //  "Ok, I think I understand now," I answered.  Polymorphism in C Sharp  "Good! Then you'll have 
    //  no problem solving these exercises," Noname said.  Create a class Mango that implements the 
    //  interface IFruit. Let it return "Mango" as its name. Then, in the Main method, create an 
    //  object of type Mango and pass it to the method PrintName. The order of calls to PrintName 
    //  should be: first apple, then mango.  In the Main method, create two string rules of types 
    //  NoDoubleSpaces and IsShort. Call the method DoesTheRuleApply two times, once for each rule. 
    //  Assign the result to the corresponding variables hasNoDoubleSpaces and isShort. 
    //  You also need to call the method AppliesToString inside the method DoesTheRuleApply. 
    //  Set the type IStringRule to the method's parameter rule. Don't change any function 
    //  or parameter names.  I finished the exercises in about five minutes. It seemed like 
    //  enough information for me to be able to change the routing system of Commander's server, 
    //  but Noname seemed unstoppable. He wanted to explain all the nitty-gritty details of polymorphism. 
    //  He continued: "The same technique applies if you replace interfaces with base classes. The passing 
    //  side will pass an object of a child class, and the receiving method receives that as an object of a 
    //  base class. Take a look at how it looks in the code:"
    //  public class Car  {  public virtual void Accelerate()  {  Console.WriteLine("Accelerating an unknown car");  }  }  }
    //  public class ElectricCar : Car  {  public override void Accelerate()  {  Console.WriteLine("Accelerating an electric car.");  }  }  
    //  public class PetrolCar : Car    {  public override void Accelerate()  {  Console.WriteLine("Accelerating a petrol car.");     }  }
    //  public class Driver             {  public static void Main()          {  ElectricCar electricCar = new ElectricCar();
    //                                     PetrolCar petrolCar = new PetrolCar();AccelerateCar(electricCar);
    //                                     AccelerateCar(petrolCar);   }  // Accelerates any car that derives from Car!!!
    //  private static void AccelerateCar(Car car) {   car.Accelerate();  }  }  // Outputs:
    //  // Accelerating an electric car.  // Accelerating a petrol car.  
    //  Noname explained his code: "The first interesting thing about this code is the same as for the 
    //  previous code snippet: the method AccelerateCar works with an argument car of type Car, 
    //  not ElectricCar or PetrolCar."  "How does it understand which implementation of the method 
    //  Accelerate to use when it calls car.Accelerate()?" I asked, wondering if I was missing something 
    //  obvious. "This is the second interesting fact regarding the last example I gave you. 
    //  Polymorphism works in such a way that every object stores a reference to its original type. 
    //  Object car inside the method AccelerateCar is treated as Car, but when you call a method 
    //  Accelerate on it, the first thing it does is check what the original type of the object was. 
    //  Then it calls the method from the corresponding implementation." 
    //  public class Driver  {  public static void Main()  {  ElectricCar electricCar = new ElectricCar();
    //  PetrolCar petrolCar = new PetrolCar();  Car car = new Car();      AccelerateCar(electricCar);
    //  AccelerateCar(petrolCar);  AccelerateCar(car);  }  
    //  private static void AccelerateCar(Car car)  {  car.Accelerate();  }  }// Here C# checks the initial type 
    //  of the object car Then it finds the method "Accelerate" in that class and calls it If there are no 
    //  overrides of this method in the "real" class, the implementation from the parent class is used
    //  "Noname, one more question: what does that last line of the comment mean? Can you give a code example?" 
    //  I asked. "Oh yes, sure, here you go!" he displayed an image with the next code snippet.
    //  public class Car  {  public virtual void Accelerate()  {      Console.WriteLine("Accelerating an unknown car");  }  }
    //  public class ElectricCar : Car  {  // Nothing  }  
    //  public class Driver
    //  {    public static void Main()
    //       {    ElectricCar electricCar = new ElectricCar();      AccelerateCar(electricCar);    } 
    //       private static void AccelerateCar(Car car)  
    //       {    car.Accelerate();  }// This one calls the method Accelerate from Car Because ElectricCar does not override the method Accelerate
    //  }        // Outputs:        // Accelerating an unknown car
    //  In every 'if' branch, create a shape of the corresponding type. If the shape is unknown, 
    //  create an instance of the base class Shape. Draw the shape that you've created using method DrawShape.
    //  Change the class Mouse to make the code output "Connecting mouse".  "Noname, maybe this is enough for 
    //  the first time? My brain is melting from all of this polymorphism stuff."  "Okay, I understand. 
    //  Humans are far from perfect; your brain is one of the weakest components of the body. Can you 
    //  handle one last fact before we stop?" he asked.  "Fine," I replied, "but just one."  "In the 
    //  previous examples, you saw how polymorphism works on methods. It can also be used on variables."
    //  "Variables? Interesting!"  "First, we create a variable of type Car. Then, you can assign to it 
    //  any object of types ElectricCar or PetrolCar because they both derive from Car. In general, you 
    //  can assign an object of a child class to a variable of the parent class. Here's a code example:"
    //  Car car1 = new Car();  Car car2 = new ElectricCar();  Car car3 = new PetrolCar();
    //  "What is the point of doing so?" I asked.  "Well, there's no tangible point, but it provides a 
    //  good example of polymorphism functionality. Having only those 3 lines is not enough to 
    //  understand the usage of the variable car. Let's do something with it, let's say, call our 
    //  favorite method Accelerate. Because of polymorphism, C# calls the right method for each class, 
    //  as we saw in the method AccelerateCar in previous examples."  
    //  public class Car  {  public virtual void Accelerate()  {   Console.WriteLine("Accelerating an unknown car.");  }  }
    //  public class ElectricCar : Car  {  public override void Accelerate()  {  Console.WriteLine("Accelerating an electric car.");  }  }
    //  public class PetrolCar : Car    {  public override void Accelerate()  {  Console.WriteLine("Accelerating a petrol car.");     }  }
    //  public class Driver {
    //  public static void Main(){
    //      Car car1 = new Car();    Car car2 = new ElectricCar();    Car car3 = new PetrolCar();   
    //          car1.Accelerate(); // C# knows that it should call Accelerate from Car
    //          car2.Accelerate(); // C# knows that it should call Accelerate from ElectricCar
    //          car3.Accelerate(); // C# knows that it should call Accelerate from PetrolCar  }  }
    //  // Outputs:  // Accelerating an unknown car.  // Accelerating an electric car.  // Accelerating a petrol car.
    //  "Thanks, Noname, that example helps. It's clear how to use polymorphism technically, but I 
    //  still can't see any practical use for it," I said, hoping he had more to add. Noname replied, 
    //  "Ok, consider that you want to ask a user which car he or she wants to use. I'll write this 
    //  code for you using interfaces this time:"
    //  public interface ICar  {   void Accelerate();  }
    //  public class ElectricCar : ICar  {  public void Accelerate()  {  Console.WriteLine("Accelerating an electric car.");  }  }
    //  public class PetrolCar : ICar    {  public void Accelerate()  {  Console.WriteLine("Accelerating a petrol car.");     }  }
    //  public class Driver  {  public static void Main()  {  ICar car; // Not assigning any object as we don't know which car to drive.
    //      if (Console.ReadLine() == "electrical")    {        car = new ElectricCar();    }
    //      else                                       {        car = new PetrolCar();      }
    //      car.Accelerate(); C# knows which method to call: from ElectricCar or PetrolCar  }  }  }  }
    //  "At runtime, this code creates different objects that implement interface ICar. You can argue 
    //  that it is possible to achieve the same result with ifs - and that is partially true - but 
    //  using polymorphism provides significant advantages:"  
    //  1. Decoupling. Using polymorphism, you can separate the implementation logic from the usage logic. 
    //  You can create objects in one place and pass them as an implementation of some interface without
    //  specifying the actual type. This allows work to easily be separated between teams, with each team
    //  working independently but sharing a common interface.  
    //  2. Extensibility. To add a new car to the code above you would need to add a new class, but you 
    //  don't need to change the code in Main because the object car has the interface type ICar. 
    //  The same principle applies to real cars: if a manufacturer creates a new car, they don't need 
    //  to teach you to drive it. Instead, they set up their new car to use the common interface 
    //  implemented in all cars.  I finally felt comfortable with polymorphism. Now, it was time to act.
    //  "I think I'm good with this topic, Noname. It's time to replace Commander's communication module," 
    //  I said.  "What exactly are you planning to do?" he asked.  "Be patient, you'll see everything in a 
    //  moment," I replied. It was my turn to be mysterious.  Commander's communication module was still 
    //  partially write-protected. Noname and I have found a way to insert a new class and to change 10 
    //  symbols in the Main method. Methods ReceiveMessage and SendMessage were 100% protected and 
    //  we were not able to make any changes.  Create your own public implementation of ICommunicationModule 
    //  named CommunicationToTeo that is an exact copy of CommunicationToWonderland with one exception: 
    //  instead of the string "Opening communication channel to Wonderland" it should say "Opening 
    //  communication channel to Teo". Then, replace the communication module that is used in the 
    //  Main method with the newly created CommunicationToTeo.  "That was smart of you, Teo!" Noname 
    //  exclaimed, "You tricked the machines; now they'll continue talking to Commander, and Commander 
    //  will think it's talking to Wonderland, but in reality, it'll be talking to you. Moreover, that 
    //  little change to forward your orders to Wonderland as if Commander sent them was genius! This 
    //  all means... This means that... Teo, you are the new Commander. You control the entire 
    //  resistance on Earth!" Noname's voice dropped an octave as he started to realize the situation.
    //  I felt mighty. I had an uplifting feeling that finally, this one time, I'd be the one making 
    //  the rules. I'd be giving the orders, and there would be no more secrets, because I'd be the 
    //  source. I owned the biggest secret of Wonderland. Perhaps the biggest secret on the planet.
    //  So, what to do now? What orders to give? Whom to love and whom to hate?  I figured I'd start 
    //  slow and replace the pathetic, tasteless coffee sludge that they use here with proper coffee beans.   //  To be continued...To be continued Codeasy  
    #endregion  //  C# Intermediate>6 One step ahead>Polymorphism    info@codeasy.net  Have fun and learn programming with codeasy.net © 2019
    //  After giving me some time to look through the code, Noname asked, "Do you see the beauty of what 
    //  is happening here?"  "I think so," I replied. "Let me try to sort this out myself. So you have 
    //  an interface ICar, and two classes that implement it: ElectricCar and PetrolCar. 
    //  Then, in the Main method, you create two objects: one of type ElectricCar and one 
    //  of type PetrolCar. Then you pass those objects to the method AccelerateCar. Wait! 
    //  This method takes ICar - how does it even compile?"  "All the magic happens in 
    //  the Accelerate method," Noname replied. "Polymorphism gives you the ability to pass any class 
    //  that implements the ICar interface to the method AccelerateCar. It is possible because the 
    //  type of the argument car in the AccelerateCar method is an ICar, not a specific PetrolCar 
    //  or ElectricCar.  "As always, Nonames first explanation was a bit too technical for me to 
    //  grasp it all.  "Noname, does the object change when it has a different type inside of the 
    //  method?" I asked.  "When the object electricCar, after being passed to the method as a 
    //  parameter, has a type ICar, it is not changed, but the way the receiving side sees it 
    //  does change. The object electricCar continues to have the type ElectricCar, and an 
    //  object petrolCar will still be of type PetrolCar. The trick is that inside the method 
    //  AccelerateCar, both of their types are ICar. And the best thing about it - you don't need 
    //  to know the exact type. You operate via an interface, the same as you do with the real car. 
    class Kinda
    {
        public static async Task<List<string>> ParallelPrimesAsync(Util sutil, long iPrimeLower = 1005001, long iPrimeUpper = 1005301, bool isConsoleRead = false)
        {
            Stopwatch timer = new Stopwatch(); timer.Start();
            List<string> primes = new List<string>();
            StringBuilder sb = new StringBuilder("");
            const string ss = "";/*Console.Write*/sb.Append(" "); primes.Add(" ");
            bool isPrime = true, isParsed = false; string pop = "";
            if (isConsoleRead)
            {
                pop = Console.ReadLine();
                isParsed = long.TryParse(pop, out iPrimeUpper);
                if (!isParsed) { iPrimeUpper = 163; }
            }            //Parallel.For(fromInclusive,toExclusive,ParallelOptions )
            primes.Add($"\n@@Primes from {iPrimeLower.ToString("N0")} to {iPrimeUpper.ToString("N0")}: ");
            sb.Append/*sutil.PrintInColor*/($"Primes from {iPrimeLower.ToString("N0")} to {iPrimeUpper.ToString("N0")}: ");
            Parallel.For(iPrimeLower, iPrimeUpper, item =>
                {
                    if (item % 2 > 0)
                    {
                        for (long i = item - 1; i >= 2; i--)
                        {
                            if (item % i == 0)
                            { isPrime = false; break; }
                        }
                        primes.Add($"{((isPrime) ? item.ToString("N0") + ", " : ss)}");
                        sb.Append/*sutil.PrintInColor*/($"{((isPrime) ? item.ToString("N0") + ", " : ss)}");
                        isPrime = true;
                    }
                }
                );
            #region ParallelFor Docs
            /* int x = 0;
                Parallel.For(0, 100,
                    () => 0, //LocalInit
                    (i, loopstate, outerlocal) =>
                    {
                        Parallel.For(i + 1, 100,
                        () => 0, //LocalInit
                            (a, loopState, innerLocal) => { return innerLocal + 1; },
                            (innerLocal) => Interlocked.Add(ref outerlocal, innerLocal)); //Local Final
                        return outerlocal;
                    },
                    (outerLocal) => Interlocked.Add(ref x, outerLocal)); //Local Final */

            // Parallel.For(int fromInclusive, int toExclusive,Func<TLocal> localInit,Func<int, ParallelLoopState, TLocal, TLocal> body, Acc)
            // static int[] _values = Enumerable.Range(0, 1000).ToArray();

            //  static void Example(int x)
            //  {
            //      // Sum all the elements in the array.
            //      int sum = 0;
            //      int product = 1;
            //      foreach (var element in _values)
            //      {
            //          sum += element;
            //          product *= element;
            //      }
            //  }
            //
            //  static void Main()
            //  {
            //  const int max = 10;
            //  const int inner = 100000;
            //  var s1 = Stopwatch.StartNew();
            //  for (int i = 0; i < max; i++)
            //  {
            //      Parallel.For(0, inner, Example);
            //  }
            //  s1.Stop();
            //  var s2 = Stopwatch.StartNew();
            //  for (int i = 0; i < max; i++)
            //  {
            //          for (int z = 0; z < inner; z++)
            //          {
            //              Example(z);
            //          }
            //      }
            //      s2.Stop();
            //      Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) / max).ToString("0.00 ns"));
            //      Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) / max).ToString("0.00 ns"));
            //      Console.Read();
            //  }
            //}

            //Output

            //11229670.00 ns Parallel.For
            //46920150.00 ns for */
            #endregion
            primes.Insert(0, $"ElaspedTime = {timer.Elapsed.ToString()}            ");
            return primes;
        }
        public static async Task<List<string>> GetPrimesAsync(Util sutil, long iPrimeLower = 1001001,
         long iPrimeUpper = 1003121, bool isConsoleRead = false)
        {
            Stopwatch timer = new Stopwatch();timer.Start();
            List<string> primes = new List<string>();
            StringBuilder sb = new StringBuilder("");  //  decimal idx = -1, in1 = 0; 
            const string ss = "";/*Console.Write*/sb.Append(" "); primes.Add(" ");
            bool isPrime = true, isParsed = false; string pop = ""; 
            if (isConsoleRead)
            {
                pop = Console.ReadLine();
                isParsed = long.TryParse(pop, out iPrimeUpper);
                if (!isParsed) { iPrimeUpper = 163; }
            }
            primes.Add($"\n@@Primes from {iPrimeLower.ToString("N0")} to {iPrimeUpper.ToString("N0")}: ");
            sb.Append/*sutil.PrintInColor*/($"@@Primes from {iPrimeLower.ToString("N0")} to {iPrimeUpper.ToString("N0")}: ");
            /*Parallel.*/
            for (decimal item = iPrimeLower; item < iPrimeUpper; item += 2)
            {
                for (decimal i = item - 1; i >= 2; i--)
                {
                    if (item % i == 0)
                    { isPrime = false; break; }
                }
                //if (!isConsoleRead) { sutil.PrintInColor($"{item.ToString()}"); }
                //  if (isPrime) { sutil.PrintInColor($"==Prime"); }
                //  else { sutil.PrintInColor($"!=Prime"); }
                primes.Add($"{((isPrime) ? item.ToString("N0") + ", " : ss)}");
                sb.Append/*sutil.PrintInColor*/($"{((isPrime) ? item.ToString("N0") + ", " : ss)}");
                isPrime = true;
            }
            primes.Insert(0, $"ElaspedTime = {timer.Elapsed.ToString()}            ");
            
            return primes;
        }
        public static Task<List<string>>[] StartTask(Util sutil, long iPrimeLower = 10001001,
         long iPrimeUpper = 10003001, long loopCntl = 50, bool isConsoleRead = false)
            {                       //    int loopCntl = 50;
            long pop = (iPrimeUpper - iPrimeLower) /*2000*/ / (loopCntl), idx = iPrimeLower;//   (idx + pop> iPrimeUpper )
            int iAmt2Add2Idx= Convert.ToInt32(pop);
            var tasks = /*new[]   { */ Enumerable.Range(1, iAmt2Add2Idx)
                .Select(_ => Task<List<string>>.Factory.StartNew(() => /*GetPrimesAsync*/ParallelPrimesAsync(sutil, idx, idx += loopCntl).Result.ToList<string>()))
                    .ToArray();
            return tasks;
        }
        /*    Task<List<string>>.Factory.StartNew(() => GetPrimesAsync(sutil, 10001001, 10001101).Result.ToList<string>()),
            Task<List<string>>.Factory.StartNew(() => GetPrimesAsync(sutil, 10001101, 10001201).Result.ToList<string>()),
            Task<List<string>>.Factory.StartNew(() => GetPrimesAsync(sutil, 10001201, 10001301).Result.ToList<string>()),
            Task<List<string>>.Factory.StartNew(() => GetPrimesAsync(sutil, 10001301, 10001401).Result.ToList<string>()),
            Task<List<string>>.Factory.StartNew(() => GetPrimesAsync(sutil, 10001401, 10001501).Result.ToList<string>()),
            Task<List<string>>.Factory.StartNew(() => GetPrimesAsync(sutil, 10001501, 10001601).Result.ToList<string>()),
            Task<List<string>>.Factory.StartNew(() => GetPrimesAsync(sutil, 10001601, 10001701).Result.ToList<string>()),
            Task<List<string>>.Factory.StartNew(() => GetPrimesAsync(sutil, 10001701, 10001801).Result.ToList<string>()),
            Task<List<string>>.Factory.StartNew(() => GetPrimesAsync(sutil, 10001801, 10001901).Result.ToList<string>()),
            Task<List<string>>.Factory.StartNew(() => GetPrimesAsync(sutil, 10001901, 10002001).Result.ToList<string>()),
            Task<List<string>>.Factory.StartNew(() => ParallelPrimesAsync(sutil, 10002001, 10002101).Result.ToList<string>()),                
            Task<List<string>>.Factory.StartNew(() => ParallelPrimesAsync(sutil, 10002101, 10002201).Result.ToList<string>()),
            Task<List<string>>.Factory.StartNew(() => ParallelPrimesAsync(sutil, 10002201, 10002301).Result.ToList<string>()),
            Task<List<string>>.Factory.StartNew(() => ParallelPrimesAsync(sutil, 10002301, 10002401).Result.ToList<string>()),
            Task<List<string>>.Factory.StartNew(() => ParallelPrimesAsync(sutil, 10002401, 10002501).Result.ToList<string>()),
            Task<List<string>>.Factory.StartNew(() => ParallelPrimesAsync(sutil, 10002501, 10002601).Result.ToList<string>()),
            Task<List<string>>.Factory.StartNew(() => ParallelPrimesAsync(sutil, 10002601, 10002701).Result.ToList<string>()),
            Task<List<string>>.Factory.StartNew(() => ParallelPrimesAsync(sutil, 10002701, 10002801).Result.ToList<string>()),
            Task<List<string>>.Factory.StartNew(() => ParallelPrimesAsync(sutil, 10002801, 10002901).Result.ToList<string>()),
            Task<List<string>>.Factory.StartNew(() => ParallelPrimesAsync(sutil, 10002901, 10003001).Result.ToList<string>()),
            Task<List<string>>.Factory.StartNew(() => ParallelPrimesAsync(sutil, 10003001, 10003101).Result.ToList<string>()),
                            }; */
        public static StringBuilder FinishTask(Util sutil, ref Task<List<string>>[] task, StringBuilder sb)
        {
            foreach (var item in task)
            {
                if (item.IsCompleted) sutil.PrintInColor($"Task{item.Id}.IsCompleted!  ");
                else { item.Wait(); }
                foreach (var i in item.Result) { sb.Append($"{i.ToString()}"); }
            }
            return sb;
        }
        class Program1
        {
            static async Task Main(string[] args)
            {
                Util sutil = new Util(ConsoleColor.DarkGreen, ConsoleColor.White); //Kinda kinda = new Kinda();
                Task<List<string>>[] task = StartTask(sutil, 10001001, 10003001, 50);               //Task<int> task1 = Task<int>.Factory.StartNew(() => 1);  int i = task1.Result;             //Task<string> pop = new Task<string>( () => { Kinda.GetPrimesAsync(sutil)/*.ConfigureAwait(false)*/; });
                new ConsoleReadLineA();    //  Elementary C# Chapter~4-6???
                new CSBeginChapter1WhileLoops();   //
                new MethodsBegin1_2(); new CSBeginChapter2Arrays(); new Chap41InputValid();
                new CSBeginChap5InfinityTypesCastOutRef(); new CSBeginningChapter6SwitchCSTest();
                Chap1ClassObjCarUserGlass.RunNamespaceCSIChap1.RunCSIChap1();
                ClassObjectsAndAccessors.RunCOAA();        //  RunCSIChap2
                NullTest nullTest = new NullTest("I love my job");
                nullTest.TestNull("10");
                NullAndThis.RunNAT(); new PickupClasses();
                StringBuilder sb = new StringBuilder(""); 
                sb = FinishTask(sutil, ref task, sb);               //  sb = Kinda.FinishTask(sutil, ref task1, /*ref*/ sb);        //var daddy = task1.Result;//pop.Wait();        //sutil.PrintInColor($"task1={daddy.ToString2()};{task1.Result}");
                sutil.PrintInColor($"{sb.ToString()}");
            }   //  Main
        }
    }
}
 