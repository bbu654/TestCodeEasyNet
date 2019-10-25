using System;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using TestCodeasyNet;    //using ClassObjectNAccessor;    //using RunProgram;
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
    }
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
    class Flower
    {
        //  Create a class Flower with 4 public properties: 
        //  string Name, string Color, int Age, and bool IsEndangered. 
        //  Do not add any access modifiers to getters or setters.    
        public string Name
        { set; get; }
        public string Color
        { set; get; }
        public int Age
        { set; get; }
        public bool IsEndangered
        { set; get; }
        public Flower(string name, string color, int age, bool isEndangered)
        {
            Name = name;
            Color = color;
            Age = age;
            IsEndangered = isEndangered;
            WriteFlower();
        }
        public void WriteFlower()
        {
            Util util = new Util(ConsoleColor.Red, ConsoleColor.Black);
            util.PrintInColor($"Flower: {Name}, {Color}, {Age.ToString()}, ");
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
            new Flower("Rose", "Red", 10, false);
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
            Util sutil = new Util(ConsoleColor.Yellow, ConsoleColor.Black);sutil.PrintInColor($"While Loops:\n");
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

            bool testit = true; int idx4 = 0; string answer = "more"; string[] sAnswer = {"Fuck ME!" };//string[] sAnswer = { "more", "More", "morE", "mOre", "moRe", "MORE", "MOre", "OK"};
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
            int idx1 = 0;sutil.PrintInColor($"We will see a Triangle of {counter} rows\n");
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
            while ( idx3++  < counter )    
                sutil.PrintInColor($"{idx3 % 10}{sb.Append("#").ToString()}\n");
            Console.WriteLine("01234567890123456");sb.Clear();
            for (int i = counter - 1; i >= 0; i--)
            {                sutil.PrintInColor($"{sb.Append("#").ToString()}\n");            }
            Console.WriteLine("01234567890123456"); sb.Clear();
        /*  for (int i = 1; i < counter + 1; i++)
            {                sutil.PrintInColor($"{i % 10}");
                for (int j = 0; j < i; j++)
                {                    sb.Append($" ");                }
                sb.Append("#");            }
            sutil.PrintInColor($"{sb.ToString()}\n"); sb.Clear(); */
            Util dutil = new Util(ConsoleColor.Green, ConsoleColor.Red);dutil.PrintInColor(" Christmas Tree \n");
            int j = 0;
            for (int i = counter ; i >= 0; i--)
            {           //bbu654                //for (int j = 2; j < (counter * 2) + 2; j += 2)                /*{ */                                        //sb.Append($"{(i % 10).ToString()}");
                    sb.Append(sutil.TextRepeater(" ", i));
                    sb.Append(sutil.TextRepeater("#", j += 2));
                    sb.Append(sutil.TextRepeater(" ", i));                    sb.Append("\n");                //}
            }
            dutil.PrintInColor($"{sb.ToString()}"); 
            dutil.PrintInColor(dutil.TextRepeater(" ", counter)+ "[]" + dutil.TextRepeater(" ", counter));
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
                {                  sInput = sRin[++testNum]; sutil.PrintInColor($"{sRin[testNum]}: ");    }
                foreach (string item in sIn)
                {                  if (sInput.ToLower() == item) { fucked = true; }                       }

                if (sInput.ToLower() == "hide") { visible = false; }
                if (sInput.ToLower() == "unhide") { visible = true; }
                if (sInput.ToLower() == "game over") { testit = false; }
                if (sInput.ToLower() == "scan" && visible) sutil.PrintInColor($"scanning file {++fileNum}\n");
                if (sInput.ToLower() == "scan" && !visible) sutil.PrintInColor($"can't scan files for viruses. ");
                if (!fucked) sutil.PrintInColor("Invalid Input Dufus! ");
            }   //  while 
            sutil.PrintInColor(" run.\n");            return fileNum;
        }   //Scanning


        public static void CSBeginChap1RunWhiles(Util sutil,bool isConsoleRead = false)
        {
            int fileNum = 0, pop = Scanning(sutil, Scanning(sutil, Scanning(sutil, Scanning(sutil, Scanning(sutil, Scanning(sutil, fileNum))))));
            PrintTriangle(sutil,7); AddToSalaryWhile(sutil);DivideBy2(sutil,4096);
        }
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
            util.PrintInColor($"bbm:{bbm.ToString()}.\n"); 
            util.PrintInColor($"bbm.Genres[0]={bbm.Genres[0]}, " + $"bbm.Genres[1]={bbm.Genres[1]}.\n");
            NullTest nullTest = new NullTest("I am awesome to the MAX");
            nullTest.JobsIO(@"C:\Users\Brice16\Documents\Resumes\JobsOct26-Nov012019.txt");

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
                {
                    sb.AppendLine(""); sb.Append($"{++jobNum}. ");
                }
                else
                {
                    sb.AppendLine(item);
                }
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
        public DateTime ReleaseDate
        { get; set; }
        public string[] Genres
        { get; set; }
        public override string ToString()
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
            Utl.PrintColoredA(ConsoleColor.Red, ConsoleColor.Yellow,"Hello World! Droid Killers: 23, 669, 133");
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
 

    //  Create 4 int variables with different names. Assign them these values: 1000, 2000, 3000, 10000. Using string interpolation, insert those int variables into the strings to get such output:
    //  In one year my salary is going to be 1000 USD, In two years my salary is going to be 2000 USD
    //  In three years my salary is going to be 3000 USD, In four years my salary is going to be 10000 USD
    //  int codePart = 333, salary = 1000;

    //  Now for a more practical application.The biggest machine known to us is a huge cube, measuring 
    //  317 meters in each direction, and it is called “Dominator.” To stop Dominator, we plan to paint 
    //  it with a machine - destroying paint. Write a program that calculates how much paint we will need 
    //  to totally paint all six sides of Dominator, if painting 1 square meter takes 20 grams of paint. 
    //  You have studied geometry, haven't you? 
    //  Output the result using string interpolation in the format: I need **grams of paint.

    //  Here is a final task that may come in handy.Some drones are not so easy to reprogram immediately, so they may continue sending reports to the drone base.To prevent this, you can substitute false reports.You have to output to the screen: "I can see ** people in this square" and then decrement the number by 1.You have to repeat this until the number of people is equal to 0.For example:
    //  I can see 2 people in this square
    //  I can see 1 people in this square
    //  I can see 0 people in this square
    //  Try it yourself, but starting with 5 people at the beginning. Use int variables and strings interpolation.
    class Program1
    {
        static void Main(string[] args)
        {
            new ConsoleReadLineA();    //  Elementary C# Chapter~4-6???
            new CSBeginChapter1WhileLoops();   //
            Chap1ClassObjCarUserGlass.RunNamespaceCSIChap1.RunCSIChap1();
            ClassObjectsAndAccessors.RunCOAA();        //  RunCSIChap2
            NullTest nullTest = new NullTest("I love my job");
            nullTest.TestNull("10");
            NullAndThis.RunNAT();
        }   //  Main
    } 
}