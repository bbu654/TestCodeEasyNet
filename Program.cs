using System;
using System.Text;
using System.Collections;
using System.Runtime.Serialization;
using System.Linq;

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
    }
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
        public int CompareTo(Box box2)
        {
            Util util = new Util(ConsoleColor.Green, ConsoleColor.Black);
            util.PrintInColor($"\nbox1(Length={Length}, Width={Width}, Height={Height})Area = {this.Area}");
            int iReturn;
            if (this.Area == box2.Area)
            {
                util.PrintInColor($" is equal to ");
                iReturn = 0;
            }
            else if (this.Area < box2.Area)
            {
                util.PrintInColor($" is less than ");
                iReturn = -1;
            }
            else
            {
                util.PrintInColor($" is greater than ");
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
            Guess guess = new Guess(6); bool control = false; int i = 1;
            while (!control)
            {
                i++; control = guess.YouGuessed(i);
            }
            Box box1 = new Box(1, 2, 3);
            Box box2 = new Box(1, 2, 4);
            int cbox = box1.CompareTo(box2);
            NullTest nullTest = new NullTest("son of a beache");
            nullTest.TestNull(cbox.ToString());
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
    //  You've met another droid that knows a secret integer between 1 and 8. 
    //  Add or remove this modifiers to enable a guessing game where the user should 
    //  guess that secret number. (In this case, it is 6) Code!
    class Guess
    {
        private int _secretNumberToGuess;
        public Guess(int secretNumberToGuess)
        {
            this._secretNumberToGuess = secretNumberToGuess;
            Util util = new Util(ConsoleColor.Green, ConsoleColor.Black);
            util.PrintInColor($"exiting Guess, (P)secretNumber={secretNumberToGuess}, _secretNumber={_secretNumberToGuess}, this._secretNumber={this._secretNumberToGuess}\n");
        }
        public bool YouGuessed(int yourGuess)
        {
            Util util = new Util(ConsoleColor.Green, ConsoleColor.Black);
            if (this._secretNumberToGuess == yourGuess)
            {
                util.PrintInColor($"Congratulations!: you guessed the secret Number: {yourGuess.ToString()}");
                return true;
            }
            util.PrintInColor($"Try again:  you did not guess the secret Number: {yourGuess.ToString()}\n");
            return false;
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
            string json = @"{ 'Name': 'Bad Boys', 'ReleaseDate': '1995-4-7T00:00:00'}";  //  , 'Genres': [ 'Action', 'Comedy' ] }";
            var dict = json.Split(',').Select(x => x.Split(':')).ToDictionary(x => x[0], x => x[1]);
            foreach (var item in dict)
            {
                util.PrintInColor(item.Key + "=" + item.Value + "\n");
            }
            string[] stringSeparators = new string[] { "\', \'", "{ \'" };
            string[] keypairs = json.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);int ctr = 0;
            foreach (string item in keypairs)
            {
                util.PrintInColor($"item{++ctr}={item}, ");
            }                            //  Movie m = JsonConvert.DeserializeObject<Movie>(json);
            util.PrintInColor("\n");
            //
                            //    string name = m.Name;     // Bad Boys
                            //    Product product = new Product();
                            //    product.Name = "Apple";
                            //    product.Expiry = new DateTime(2008, 12, 28);
                            //    product.Sizes = new string[] { "Small" };
                            //    string json = JsonConvert.SerializeObject(product);
                            //    {   "Name": "Apple", "Expiry": "2008-12-28T00:00:00", "Sizes": [ "Small" ]   } 
        }   //  public void TestNull()
    }       //  Class NullTest
    class Movie
    {
        private string _name;
        private DateTime _datetime;
        public Movie(string name, DateTime dateTime) 
        { }
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
            Console.WriteLine("Hello World!");
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
            Console.WriteLine();
            TL = _topLeft; BR = _bottomRight;
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

    class Program
    {
        static void Main(string[] args)
        {
            ClassObjectsAndAccessors.RunCOAA();
            NullAndThis.RunNAT();
        }   //  Main
    }   //  Program
}