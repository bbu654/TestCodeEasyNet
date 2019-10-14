using System;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

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
        { StringBuilder sb = new StringBuilder("");
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

    //    Change public fields in the class User to properties with the same name and type. Leave getters and setters with default access modifiers. In the setter of the property Name, check whether the string is null or empty. If it is, do not assign that value. 
    //    Code!

    //    Change public fields in the class Shop and GeoLocation to properties with the same names and types. Leave getters with default access modifiers and change access for setters to private. Add constructors to Shop and GeoLocation that take values for every property as parameters and assigns them. 
    //    Code!

    //    Despite the fact that Wonderland has an idyllic name, crimes are still present here. We recently noticed that one particular coder is decreasing the value of every good they buy by 1 virus in order to save on every purchase.
    //    Change the class Good to use properties with public getters and setters. The current code should still work, but decreasing of the price should have no effect. To achieve this, change the code in the Price's setter. You are not allowed to change any code outside of the Good class. 
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
            List<string> scomp = new List<string>() { " is equal to ", " is less than ", " is greater than " };
            string[] sComp=  { " is equal to ", " is less than ", " is greater than " };
            Util util = new Util(ConsoleColor.Green, ConsoleColor.Black);
            util.PrintInColor($"box1(Length={Length}, Width={Width}, Height={Height})Area = {this.Area}");
            int iReturn;const string isgreater = " is equal to ",isless = " is less than ";
            if (this.Area == box2.Area)
            {
                util.PrintInColor(sComp[Convert.ToInt32(eComp.IsGreat)]);
                iReturn = 0;
            }
            else if (this.Area < box2.Area)
            {
                util.PrintInColor(isless);
                iReturn = -1;
            }
            else
            {
                util.PrintInColor(scomp[3]);
                iReturn = 1;
            }
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

        //  Create a class ChickenFarm with 4 public properties: 
        //  double Longitude, double Latitude, int Capacity, and string Identifier. 
        //  Make a setter for the Identifier - private. 
        //  Remove the setter for the Capacity. 
        //  Leave all other getters and setters as-is without any access modifiers. 
    class ChickenFarm
    {           /*  */
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
        {            Latitude = lat;            Longitude = llong;        }
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
            Console.WriteLine($"Student: Name={0}, Age={1}",name,(age > 0) ? age.ToString() : "0" );
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
        public static void RunNAT()
        {
            AdvancedDroid ad = new AdvancedDroid(0, 0); ad.MoveTo(2, 2);
            new Guess(6); 
            Box box1 = new Box(1, 2, 3);
            Box box2 = new Box(1, 2, 4);
            int cbox = box1.CompareTo(box2);string line = "fucking ugly bitch";
            NullTest nullTest = new NullTest(line);
            nullTest.TestNull(cbox.ToString());nullTest.PigLatin(line);
            string line2 = nullTest._newlyCreated;    nullTest.PrintPL(line, line2);
            nullTest.JobsIO(@"C:\Users\Brice16\Documents\Resumes\JobsOct19-252019.txt");
            new Flower("Rose", "Red", 10, false);
            new ChickenFarm(62.9856, 168.333365, 10, "Red Rooster");
            new ResistanceBase(62.9856, 168.333365, 21, "RedDroid");
        }
    }
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
            Movie bbm = JsonConvert.DeserializeObject<Movie>(badboy); util.PrintInColor($"bbm:{bbm.ToString()}.\n"); util.PrintInColor($"bbm.Genres[0]={bbm.Genres[0]}, bbm.Genres[1]={bbm.Genres[1]}.\n");
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
                        if (lopity[i].Equals('1') || lopity[i].Equals('2') ||
                            lopity[i].Equals('3') || lopity[i].Equals('4') ||
                            lopity[i].Equals('5') || lopity[i].Equals('6') ||
                            lopity[i].Equals('7') || lopity[i].Equals('8') ||
                            lopity[i].Equals('9')) { ++minusCount; }
                        else
                        { break; }
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
            get            {            return _name;            }
            set            {             _name = value;           }
        }
        public DateTime ReleaseDate
        {            get;            set;        }
        public string[] Genres
        {            get;            set;        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("");int ipop = 0;
            sb.Append($"Name={Name}, ReleaseDate={ReleaseDate.ToShortDateString()}, Genres=");
            foreach (string item in Genres)
            {
                if (ipop < Genres.Length - 1) {                   sb.Append(item + ", ");         }
                else                          {                   sb.Append(item);                }
                ++ipop;
            }
                return sb.ToString();
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
    static class TextFramePretifier
    {
        private static int _textsPretified;
        static TextFramePretifier() { _textsPretified = 0; }
        public static void Prettify(string text)
        {   int astlen = text.Length + 4;
            Util util = new Util(ConsoleColor.Red, ConsoleColor.White );
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
    static class WTextFramePretifier
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
                if ( sb.Length == 2 )
                {
                    sb.Append(item);
                }
                else
                {
                    if ((item.Length + sb.Length + 3 ) > (widthOfFrame - 4))
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
    //  Create a class that has one public static method, GetSumBetween, 
    //  that takes two integers, a and b, and returns as an integer the sum of all integers between a and b (including a and b). 
    //  In the Main method, read two integers from the console, 
    //  call GetSumBetween, and print the returned number to the console.
    //  For example(don't output the green text):
    //  >6
    //  >10
    //  40  // 6 + 7 + 8 + 9 + 10 = 40
    class SumBetween
    {
        public static int GetSumBetween(int a, int b)
        {
            ColorPrint colorPrint = new ColorPrint(); colorPrint.ForeGroundColor = ConsoleColor.Red; colorPrint.BackGroundColor = ConsoleColor.White;
            int c = 0;
            for (int i = a; i <= b; i++)
            {                c = c + i;            }
            colorPrint.ColoredPrint($"The numbers between {a} and {b} sum to {c}\n"); return c;
        }
    }
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
    static class DistanceMeasurer
    {
        public static double GetDistance(int x1, int y1, int x2, int y2)
        {
            double firstq = Math.Pow(x1 - x2, 2.0);      //  = (x1 - x2)2
            double second = Math.Pow(y1 - y2, 2.0);      //  = (y1 - y2)2
            double thirdq = Math.Sqrt(firstq + second);
            return thirdq;
        }
    }
    //  Create a class Car. Inside the class, 
    //  create a public static int field CarsCount 
    //  and increment it in the constructor.
    //  In the Main method, create 5 objects of the type Car.
    //  Then, output a string containing the number of cars created to the screen, 
    //  "Number of created cars is {CarsCount}", using the value of the static field for it.   //  Code!
    class Car
    {
        public static int CarsCount = 0;
        private string _model;
        private int _year;
        public Car(string model, int year)
        {
            _model = model;
            _year = year;
            CarsCount++;
        }
        static public void CarLogic()
        {
            Car corolla = new Car("Corolla", 2004); 
            Car buick = new Car("Buick", 1997);
            Car sienna = new Car("Sienna", 1999);
            Car car123 = new Car("Car4", 2014);
            Car prius = new Car("Prius", 2013);
            Util util = new Util(ConsoleColor.Red, ConsoleColor.Yellow);
            util.PrintInColor($"{corolla._model}, {buick._model}, {sienna._model}, {car123._model}, {prius._model}, so Car Count = {CarsCount}\n");
        }
    }
    class ClassObjectsAndAccessors
    {
        public static bool enterInput = false;
        public ClassObjectsAndAccessors(bool enterConsoleInput = false)
        {
            enterInput = enterConsoleInput;
        }
        static public void RunCOAA()
        {
            Console.WriteLine("Hello World! Droid Killers: 23, 669, 133");
            Box box = new Box(14554, 25794, 98758) { IsOpened = true };
            box.PrintBoxArea(box.Area); if (box.IsOpened) { box.CloseBox(); }
            else { box.OpenBox(); }

            User user = new User { Age = 21, Name = "Brice Ulwelling" }; user.PrintUser();

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
            Glass glass = new Glass() { LiquidLevel = 200 }; String line = "Drink 0";
            if (!enterInput)
            {
                glass.Drink(50); glass.PrintGlass(); glass.Drink(49); glass.PrintGlass(); glass.Drink(44); glass.PrintGlass();
            }
            else
            {
                while (line != "Stop")
                {
                    //  string pep = "0"; int millilitters = 0;
                    string[] pop = line.Split(' ');
                    if (pop.Length > 1) { glass.Drink(Convert.ToInt32(pop[1])); }
                    if (line == "Print") { glass.PrintGlass(); }
                    line = Console.ReadLine();
                }
            }
            Rectangle rec = new Rectangle() { ReservedArea = 12, Length = 20, Width = 10 };
            rec.PrintAreaResult(rec.GetArea());

            Shield shield = new Shield(); shield.PrintShield();
            ExtendedShield shield1 = new ExtendedShield("BriceStar", 15); shield1.PrintShield();

            LitArea litArea = new LitArea(1, 1, 5, 6); litArea.DrawRec(litArea.TL, litArea.BR);
            LitArea lit = new LitArea(0, 0, 2, 4); lit.DrawRec(lit.TL, lit.BR);

            Car.CarLogic();
            int x1 = 2, y1 = 1, x2 = 3, y2 = 4; Console.WriteLine(); ColorPrint colorPrint = new ColorPrint(); colorPrint.ForeGroundColor = ConsoleColor.Red; colorPrint.BackGroundColor = ConsoleColor.White;
            double distance = DistanceMeasurer.GetDistance(x1, y1, x2, y2); colorPrint.ColoredPrint($"x1 = {x1.ToString()}, y1 = {y1.ToString()}, x2 = {x2.ToString()}, y2={y2.ToString()} = {distance.ToString()}\n");

            int d = SumBetween.GetSumBetween(6, 10); int e = SumBetween.GetSumBetween(1, 5);

            TextFramePretifier.Prettify("Why frame is so important, sir1?");
            TextFramePretifier.Prettify("Why frame is so important, sir2?");
            TextFramePretifier.Prettify("You look great today, sir!");

            WTextFramePretifier.Prettify(14, "Why frame is so important, sir1?");
            WTextFramePretifier.Prettify(14, "You look great today, sir!");

        }   //  static public void RunCOAA()
    }       //  class ClassObjectsAndAccessors    
            
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
    class Point
    {
        public int X;
        public int Y;
        public Point(int XCoordinate, int YCoordinate)
        {
             X = XCoordinate;
             Y = YCoordinate;
        }
    }   // class Point
    class LitArea
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
            StartP = new Point ( 0, 0 );
            int codePart = 333, salary=1000; 
            TL = _topLeft; BR = _bottomRight;
            //Write a program that creates an int variable codePart with the value 333. Then create another 
            //  int variable with name code and assign a value that is twice the codePart variable value. 
            //  Your program should output: Self - destruction started. The code is 666
            //  Create 4 int variables with different names. Assign them these values: 1000, 2000, 3000, 10000. Using string interpolation, insert those int variables into the strings to get such output:
            //  In one year my salary is going to be 1000 USD, In two years my salary is going to be 2000 USD
            //  In three years my salary is going to be 3000 USD, In four years my salary is going to be 10000 USD

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

            colorPrint.ColoredPrint($"\nDistance=175+(75*3)={175 + (75 * 3)}.  Self - destruction started. The code is {codePart*2}.\n");
            colorPrint.ColoredPrint($"_topLeft = [{_topLeft.X}, {_topLeft.Y}] and ");
            colorPrint.ColoredPrint($"_bottomRight = [{_bottomRight.X}, {_bottomRight.Y}]\n");
            StringBuilder sb = new StringBuilder();
            int iX = TL.X; int iY = TL.Y;int oX = BR.X;int oY = BR.Y;char oLetter = '.';
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
                    if (x == oX )
                    {
                        colorPrint.ColoredPrint(sb.ToString() + "\n");
                        sb.Clear();
                    }
                }
            }
            colorPrint.ColoredPrint(sb.ToString());
        }
    }
    //  Create a class Shield with two private fields: string _identifier and int _power. 
    //  Add a parameterless public constructor to the class Shield 
    //  that assigns 10 to _power and "Default" to _identifier.     Code!
    class Shield
    {
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
    //  Take your class Shield from the previous task and rename it to ExtendedShield. 
    //  Add two parameters to the constructor: string identifier and int power.
    //  Inside the constructor, assign the value of these parameters to the private fields _identifier and _power. 
    class ExtendedShield
    {
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
    //  Private fields start with an underscore and continue with lower camel case: _privateFieldName
    //  Public fields are written in upper camel case (sometimes referred to as Pascal case): PublicFieldName
    //  Public and private methods are written in upper camel case: PublicOrPrivateMethodName()
    //  Classes and namespaces are written in upper camel case: ClassName NamespaceName 
    class Rectangle
    {
        public int ReservedArea;
        public int Length;
        public int Width;
        public int GetArea()
        {
            PrintReservedArea(); // Ok, can call private methods from within the class
            return (Length * Width) - ReservedArea;
        }
        //private 
        public void PrintReservedArea()
        {            // Ok, can use private fields from within the class
            Console.WriteLine($"      Secret Reserved Area is: {ReservedArea}");
        }
        public void PrintAreaResult(int Area)
        {     // Ok, can use private fields from within the class
            Console.WriteLine($"             Original Area (Length*Width) ({Length}*{Width})");
            Console.WriteLine($"minus Secret Reserved Area is: {Area}");
        }
    }
    //   We are prototyping a robot that refills glasses during dinner. 
    //   Every glass holds 200 milliliters.     
    //   During dinner, people either drink water or juice, 
    //   and as soon as there is less than 100 ml left in the glass, 
    //   the robot refills it back to 200 ml. 
    class Glass    //   Create a class Glass 
    {
        public int LiquidLevel;    //    with one public int field LiquidLevel 
        public void Drink(int milliliters)  //   and methods public Drink(int milliliters) 
        {    //   that takes the amount of liquid that a person drank 
            if ( milliliters > LiquidLevel || milliliters > 199 )
            { milliliters = LiquidLevel - 1; }
            LiquidLevel = LiquidLevel - milliliters;
            if (LiquidLevel < 100)              {                Refill();            }
        }
        public void Refill()    //   and public Refill() 
        { LiquidLevel = 200; }      //   that refills the glass to be 200 ml full.         }
        public void PrintGlass()  //   print - you need to output to the screen how much liquid is in the glass 
        {
            ColorPrint colorPrint = new ColorPrint();
            Console.WriteLine();            //  ConsoleColor origCs4grnd = Console.ForegroundColor;            //  ConsoleColor origCsbckgrnd = Console.BackgroundColor;
            colorPrint.ForeGroundColor = ConsoleColor.Red;  //  Console.ForegroundColor = ConsoleColor.Red;
            colorPrint.BackGroundColor = ConsoleColor.White;//  Console.BackgroundColor = ConsoleColor.White;
            colorPrint.ColoredPrint($"This glass contains {LiquidLevel.ToString()} ml of liquid..\n" );    //   in the format "This glass contains {0} ml of liquid..", 
            if (LiquidLevel == 200) { colorPrint.ColoredPrint("|##|\n"); colorPrint.ColoredPrint("|##|\n"); colorPrint.ColoredPrint("|##|\n"); colorPrint.ColoredPrint("|##|\n"); }
            else if (LiquidLevel > 149) { colorPrint.ColoredPrint("|  |\n"); colorPrint.ColoredPrint("|##|\n"); colorPrint.ColoredPrint("|##|\n"); colorPrint.ColoredPrint("|##|\n"); }
            else { colorPrint.ColoredPrint("|  |\n"); colorPrint.ColoredPrint("|  |\n"); colorPrint.ColoredPrint("|##|\n"); colorPrint.ColoredPrint("|##|\n"); }                         //Console.ForegroundColor = origCs4grnd;            //Console.BackgroundColor = origCsbckgrnd;
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
    class User    ///*Create a class User 
    {
        public int Age;    //with two public fields: int Age 
        public string Name; //and string Name. 
        public void PrintUser()  //             * Then, output to the screen: "My name is {Name} and I'm {Age} years old." 
        {                    
            Util util = new Util(ConsoleColor.Cyan, ConsoleColor.White);
            util.PrintInColor($"\nMy name is {Name}, and I'm {Age.ToString()} years old.\n");    //      }      * using object fields for Name and Age. 
        }
    }   //  class User      ///*Create a class User

    class Program1
    {
        static void Main(string[] args)
        {
            ClassObjectsAndAccessors.RunCOAA();
            NullAndThis.RunNAT();
            ConsoleReadLineA();

        }   //  Main

        private static void ConsoleReadLineA()
        {
            Console.WriteLine("Enter your namer ");
            if (Console.ReadLine() == "Ritchie")
                Console.WriteLine("Access granted");
            else
                Console.WriteLine("Security Alert! You are under arrest for treason...");
            Console.WriteLine("How are you?");
            if (Console.ReadLine() == "fine")
                Console.WriteLine("Life is great!");
            else
                Console.WriteLine("Everything's gonna be alright");
            Console.WriteLine("Input your name, please.");
            string name = Console.ReadLine();
            Console.WriteLine($"My greetings, {name}!");
            Console.WriteLine("The Max of 2: Num1 Hit Enter;"); 
            int aInt = int.Parse(Console.ReadLine());    // Read a line and convert it to int (short version)
            Console.WriteLine("              Num2 Hit Enter;");
            int bInt = int.Parse(Console.ReadLine());    // Read a line and convert it to int (short version)
            if (aInt > bInt)
                Console.WriteLine($"Max:a={aInt.ToString()}");
            else
                Console.WriteLine($"Max:b={bInt.ToString()}");
            if (aInt < bInt)
                Console.WriteLine($"Min:a={aInt.ToString()}");
            else
                Console.WriteLine($"Min:b={bInt.ToString()}");
            Console.WriteLine("What Temperature is it? (enter an integer of degrees Celcius");
            if (Convert.ToInt32(Console.ReadLine()) < 5)
                Console.WriteLine("Wear a coat");
            else
                Console.WriteLine("Wear a jacket");

            Console.WriteLine("Enter Your First Name:");
            string firstName = Console.ReadLine();  // Read a line from the screen
            Console.WriteLine("Enter Your Last Name:");
            string secondName = Console.ReadLine(); // Read a line from the screen
            Console.WriteLine($"Should I call you {firstName} or {secondName}?");
            string numberOfBoxesString = Console.ReadLine();    // Read a line from the console
            string weightString = Console.ReadLine();           // Read a line from the console

            Console.WriteLine("Enter Number of Boxes:");
            int numberOfBoxes = Convert.ToInt32(numberOfBoxesString);// Convert numberOfBoxesString to an integer
            Console.WriteLine("Enter Weight of Boxes:"); 
            int weight = Convert.ToInt32(weightString);  // to an integer
            if (numberOfBoxes * weight > 30)
                Console.WriteLine("No, Your boxes weigh too much");
            else
                Console.WriteLine("Yes, our droids can fly your boxes");

            Console.WriteLine("Zanabar Game: Input a number");
            string inputAsString = Console.ReadLine(); // Read a line from the screen
            int myNumber = Convert.ToInt32(inputAsString); // Convert inputAsString to int
            Console.WriteLine($"{++myNumber}, I won!");    // Do some magic with myNumber

            //  string aString = Console.ReadLine();  //  Read a line from the console
            //  string bString = Console.ReadLine();  //  Read a line from the console
            //  string cString = Console.ReadLine();  //  Read a line from the console
            Console.WriteLine("The Middle: Num1 Hit Enter;");
            int a = Convert.ToInt32(Console.ReadLine());      //  to an integer
            Console.WriteLine("    Num2 Hit Enter;");
            int b = Convert.ToInt32(Console.ReadLine());      //  to an integer
            Console.WriteLine("    Num3 Hit Enter;");
            int c = Convert.ToInt32(Console.ReadLine());      //  to an integer

            if (a > b)
            {
                if (b > c)
                    Console.WriteLine(b);
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
                    Console.WriteLine(c);
                else         // a>b<c a<c           // a=2;b=1;c=3
                    Console.WriteLine(a);
            }
            else
            {
                if (b > c)
                {
                    if (a > c)   // a<b>c a>c           // a=2;b=3;c=1 
                        Console.WriteLine(a);
                    else         // a<b>c a<c           // a=1;b=3;c=2
                        Console.WriteLine(c);
                }
                else             // a<b<c a>c           // a=1;b=2;c=3
                    Console.WriteLine(b);               // skip if (a > c) and  else
            }
        }
    }   //  Program
}
