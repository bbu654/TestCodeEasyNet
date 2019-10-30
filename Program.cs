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
            int fileNum = 0, pop = Scanning(sutil, Scanning(sutil, Scanning(sutil, Scanning(sutil, Scanning(sutil, Scanning(sutil, fileNum))))));
            PrintTriangle(sutil, 7); AddToSalaryWhile(sutil); DivideBy2(sutil, 4096);
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
            {
                if (iB == 0) sutil.PrintInColor($"Can't divide by zero!\n");
                else sutil.PrintInColor($"{iA.ToString()} / {iB.ToString()} = {Divide(sutil, iA, iB).ToString()}.        ");
            }
        }
        public static int Add     (Util sutil, int iA = 65, int iB = 10, bool isConsoleRead = false)
        { return iA + iB; }
        public static int Subtract(Util sutil, int iA = 65, int iB = 10, bool isConsoleRead = false)
        { return iA - iB; }
        public static int Multiply(Util sutil, int iA = 65, int iB = 10, bool isConsoleRead = false)
        { return iA * iB; }
        public static int Divide  (Util sutil, int iA = 65, int iB = 10, bool isConsoleRead = false)
        { return iA / iB; }
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
            MathOps(sutil, 75, 1, "l", isConsoleRead); Fibonacci(sutil); AtoZ(sutil, new string[] { "adld", "Zelda", "POP", "ilove", "9%^%@@","exit" });
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
            RunChap21Arrays(util);
        }
        public static void GetNumbersFromConsole(Util sutil )
        {
            //  Call a method GetNumbersFromConsole that reads a count value of int, and then reads count 
            //  values from the console into an int array.Calculate and print the sum of all elements of 
            //  this array in a format "Sum: {number}". For example:
            //  >3
            //  >1
            //  >3
            //  >2
            //  Sum: 6
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
        #region CSBeginChap5InfinityTypesCastOutRef
        /*    Infinity
        //  The day came when I met Infinity. She was from the central resistance base, called 
        //  'Wonderland'. Every month, Ritchie had been sending the 10 best programmers from 
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
        //  Read an integer number from the screen and store it in a short variable named count.Write a program that prints numbers from 1(including) to count(including), each on a new line.But for multiples of two, print 'Save' instead of the number, and for the multiples of three print 'Earth'. For numbers which are multiples of both two and three, print 'SaveEarth'.
Example:
>7
1
Save
Earth
Save
5
SaveEarth
7

C# transformation

Infinity continued, "As you know, in C# every variable has a type. It's impossible to change the type of a variable, but you can convert a value from one type to another and then store it into a new variable. There are two kinds of type conversion: implicit and explicit. Implicit conversions happen without us as programmers even noticing it! Here is an example of implicit type conversion":
short shortNumber = 23;

// Implicit conversions
int intNumber = shortNumber;
float someFloat = shortNumber;
double firstDouble = intNumber;
double secondDouble = shortNumber;


// Wrong, no implicit conversion
intNumber = firstDouble;
"As you'll see, I've created a short variable and assigned it to int, float and double. Everything is fine; implicit conversion happens, and you store the value from a variable of one type, into a variable of another one." Infinity explained.
"This is a bit confusing!" I exclaimed. "How would I know that implicit conversion between two types exists?"
"Good question Teo! There is a general rule: implicit conversion exists from 'small' types, to 'bigger' ones, counted by the amount of bytes the type takes. For example, there is an implicit conversion from byte to int, but not vice versa; from int to byte."
"It makes some sense now... So, if inside an int variable, I have a big number - let's say 1000, and I try to store it inside a byte variable, it won't fit into the range [0-255]?" I shared my thoughts.
"Yes, that's exactly the reason Teo. If I have an int that takes 4 bytes, it's impossible to fit it into a byte type that is only 1 byte big. Here is a complete C# Implicit Numeric Conversions Table, or you can just use a subset that I've picked for you":

From Type   To Types
byte
short, ushort, int, uint, long, ulong, float, double or decimal


int
long, float, double or decimal
char
ushort, int, uint, long, ulong, float, double or decimal
float
double
Convert the variable types to make the code compile, and output 10 to the screen.You should not change the variable names.

I started to like her.She was smart, wasn't aggressive and explained things really well. Perhaps I wouldn't be so disappointed about working with her if I had no backup plan (like returning home with Noname's help).
"Good job Teo! There is one more type conversion technique — the explicit conversion. It is also called a cast. A cast is a way of explicitly informing the compiler that you intend to make the type conversion, and that you are aware that data loss may occur. To perform a cast, specify the type that you are casting to in parentheses(), in front of the value or variable to be converted. Here is an example where we cast double to int":

double a = 123.95;
int b = (int)a; // Explicit cast

Console.WriteLine(b); // Outputs 123
"This looks powerful!" I proclaimed. "Could you please show me some more cast examples?"
"No problem, here you go! Oh, and don't forget about the exercise after below the example!":

double someDouble = 123.95;
float someFloat = (float)someDouble; // No data loss, someFloat == 123.95

double anotherDouble = 123.456789098765;
float anotherFloat = (float)anotherDouble; // Data loss, anotherFloat == 123.4568

long someLong = 123;
int someInt = (int)someLong; // No data loss, someInt == 123

long anotherLong = 112233445566;
int anotherInt = (int)anotherLong; // Data loss, anotherInt == 564295870

int yetAnotherInt = 123;
byte someByte = (byte)yetAnotherInt; // No data loss, someByte == 123

int intToConvert = 1234;
byte resultAsByte = (byte)intToConvert; // Data loss, intToConvert is too big to fit into byte

// Multiple conversions in expression are also fine
int intResult = (int)someLong + (int)anotherDouble; // Data Loss, intResult == 246
float floatResult = (float)anotherDouble + (float)someDouble; // Data loss, floatResult == 247.406784

// Conversion of the operation's result is fine as well
int anotherIntResult = (int)(someLong + anotherDouble); // Data Loss, anotherIntResult == 246
float floatResult2 = (float)(anotherDouble + someDouble); // Data loss, floatResult2 == 247.406784
Apply one explicit type conversion (cast) to make the code compile. Do not change any string constants or variable names.

Apply several explicit type conversions (casts) to make the code compile. Do not change any string constants or variable names.

"So, take this very simple task. You have some cupcakes and some people that all want one! You need to share among people fairly, so that everyone gets an equal amount of cupcakes. Your program should read an int (amount of cupcakes), and another int (amount of people). Then, it should output "Every person should get {amount}
cupcakes"
"This seems simple; you just need to divide 2 numbers... do you want me to write the code?" I asked.
"Go ahead!" she said, a little too positively.
It was clear that something wasn't quite right. She was smiling and staring straight at me.
"But... I'll write the code." I uneasily thought to myself.
int cupcakesCount = int.Parse(Console.ReadLine());
int peopleCount = int.Parse(Console.ReadLine());

double result = cupcakesCount / peopleCount;

Console.WriteLine($"Every person should get {result} cupcakes.");
"Okay, let's run this code with 3 people and 6 cupcakes" she said.
The code ran fine; the result was - "Every person should get 2 cupcakes"
She continued, "But, what if we have only 1 cupcake and 4 people?"
When we tried my code with these parameters, the output was - "Every person should get 0 cupcakes"
"Why is it 0? It should be a quarter (0.25) of a cupcake for everyone!" I firmly yelled, frustrated.
C# is sometimes complicated

"Well, it's because of the type conversion. When you perform an arithmetic operation with integers, you'll always get an integer as a result. This works for short, byte, float and all other primitive types that we've used.
"What does this mean Infinity?!" I asked.
"This means, that you should be careful when dividing int types. C# compiler isn't able to understand that you want a float or double as a result, unless you specifically tell it this. Otherwise, it will disregard the fractional part. Here, I've prepared some examples":
int a = 9;
int b = 4;

double firstAttempt = a / b;
double secondAttempt = (double)a / b;
double thirdAttempt = a / (double)b;
double nextAttempt = (double)a / (double)b;
double lastAttempt = (double)(a / b);

Console.WriteLine(firstAttempt);  // Outputs 2
Console.WriteLine(secondAttempt); // Outputs 2.25
Console.WriteLine(thirdAttempt);  // Outputs 2.25
Console.WriteLine(nextAttempt);   // Outputs 2.25
Console.WriteLine(lastAttempt);   // Outputs 2

Console.WriteLine((int)2.25 );            // Outputs 2
Console.WriteLine((int) secondAttempt );   // Outputs 2
"As you'll see Teo, there are a lot of ways to cast types. The main rule here is 'if there are several operands in the expression, then the type of the result is the largest of the operand types'. For example, if you divide int and double, the result is double. If you multiply byte and int, the result is int. In tasks that you are going to solve in the future, make sure you don't forget to cast to double or float during int division. If you forget, you'll lose the fractional part, just like in the cupcakes example!"

Write a program that reads from the console, a number of days in an int variable named numberOfDays and outputs the same number as years.The output should be a double type.For this task, we can assume that there are 365 days in a year.
Example:
>1022
2.8


Use a method named GetNumbersFromConsole which will read from the console a count of int values and return all those values in an int array. Then, output to the console, the average of the array values. (Average is a sum of all array elements divided by their length value).
Example:
>4
>1
>2
>3
>4
2.5

Great job!

C# Beginner>5 Infinity>Type conversion
0
CONTACT US
Email:info @codeasy.net

COMPANY INFO
FAQ
How To Use Codeasy
Partners
Privacy Policy
Prices
Have fun and learn programming with codeasy.net © 2019 */
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
            new MethodsBegin1_2(); new CSBeginChapter2Arrays(); new Chap41InputValid();
            Chap1ClassObjCarUserGlass.RunNamespaceCSIChap1.RunCSIChap1();
            ClassObjectsAndAccessors.RunCOAA();        //  RunCSIChap2
            NullTest nullTest = new NullTest("I love my job");
            nullTest.TestNull("10");
            NullAndThis.RunNAT();
        }   //  Main
    } 
}