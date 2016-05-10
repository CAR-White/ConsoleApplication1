using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.BackgroundColor = ConsoleColor.Red;

            // This comes for a seperate assembly in namespace "ClassLibrary1"
            Class1 newObjFromClass1 = new Class1();
            newObjFromClass1.Class1Method();


            // The following code illustrates using more than just simple setters and getters
            Car MyCar = new Car();
            MyCar.Make = "Ford";
            MyCar.Model = "Escort";
            // MyCar.CarType = "Sports";
            MyCar.CarType = "Neither";
            MyCar.PrintDetails();

            SomeThing MySomeThing = new SomeThing();

            MySomeThing.MyField = "MyField";

            Console.WriteLine("{0}     {1}", MySomeThing.MyField, MySomeThing.MyOtherField);




            Console.Read();


        }
    }

    public abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model
        {
            set;
            get;
        }

        //public void PrintDetails()
        //{
        //    Console.WriteLine("{0}-{1}", this.Make, this.Model);
        //}


    }

    public class Car : Vehicle
    {
        private string _carType;
        public string CarType
        {
            //set { _carType   = value; }
            get { return _carType; }
            // seter code
            set
            {
                _carType = value;
                if ((_carType.ToUpper() != "SALOON") && (_carType.ToUpper() != "COUPE"))
                {
                    Console.WriteLine("\"{0}\" is an invalid car type, setting to default \"Saloon\"", _carType);
                    _carType = "Saloon";
                    //_carType = null;
                }
            }
            // end seter code


            // get { return _carType ; }
                 
        }

        public void PrintDetails()
        {
            Console.WriteLine("{0}-{1}-{2}", this.Make, this.Model, this.CarType);
        }
    }

    public class SomeThing
    {
        // Private fields to hold the variable.
        private string _myField;
        private string _myOtherField = "foo";

        public string MyField
        {
            get
            {
                // Do some custom stuff here, if desired.
                // Note the "this" keyword is not actually required, just to emphersise a point
                if (this._myField == "NOT HELLO") this._myField = "HELLO AGAIN";
                return this._myField;
            }
            set
            {
                // Do some custom stuff here, if needed.
                this._myField = value;
                if (this._myField == "MyField") this._myField = "NOT HELLO";
            }
        }

        public string MyOtherField
        {
            // Only declare readonly property by omitting 'set'.
            get
            {
                return this._myOtherField;
            }
        }
    }
}
