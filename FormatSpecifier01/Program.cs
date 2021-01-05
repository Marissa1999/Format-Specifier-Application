using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatSpecifier01
{
    class Program
    {
        static void Main(string[] args)
        {
            string myFName = "Fred";
            string myLName = "Andrews";
            int myInt = 100;
            string FormatFName = String.Format("| First Name:  |{0,20}|", myFName);
            string FormatLName = String.Format("| Last Name:   |{0,20}|", myLName);
            string FormatPrice = String.Format("| Price:       |{0,20:C}|", myInt);
            Console.WriteLine(FormatFName);
            Console.WriteLine(FormatLName);
            Console.WriteLine(FormatPrice);
            Console.WriteLine();

            FormatFName = String.Format("| First Name:  |{0,-20}|", myFName);
            FormatLName = String.Format("| Last Name:   |{0,-20}|", myLName);
            FormatPrice = String.Format("| Price:       |{0,-20:C}|", myInt);
            Console.WriteLine(FormatFName);
            Console.WriteLine(FormatLName);
            Console.WriteLine(FormatPrice);
            // The example displays the following output on a system whose current
            // culture is en-US:
            //         | First Name:  |                Fred|
            //         | Last Name:   |             Andrews|
            //         | Price:       |             $100.00|
            //
            //         | First Name:  |Fred                |
            //         | Last Name:   |Andrews             |
            //         | Price:       |$100.00             |


            //Using Standard Numeric Format Strings
            // https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings

            //The Currency("C") Format Specifier
            decimal value1 = 123.456m;
            Console.WriteLine("\n\nThe Currency(\"C\") Format Specifier");
            Console.WriteLine(value1.ToString("C2"));
            // Displays $123.46

            decimal value2 = 123.456m;
            Console.WriteLine("Your account balance is {0:C2}.", value2);
            // Displays "Your account balance is $123.46."

            decimal[] amounts = { 16305.32m, 18794.16m };
            Console.WriteLine("   Beginning Balance           Ending Balance");
            Console.WriteLine("   {0,-28:C2}{1,14:C2}", amounts[0], amounts[1]);
            // Displays:
            //        Beginning Balance           Ending Balance
            //        $16,305.32                      $18,794.16 


            Console.WriteLine("\n\nThe Currency(\"C\") Format Specifier");
            double value3 = 12345.6789;
            Console.WriteLine(value3.ToString("C", CultureInfo.CurrentCulture));

            Console.WriteLine(value3.ToString("C3", CultureInfo.CurrentCulture));

            Console.WriteLine(value3.ToString("C3",
                              CultureInfo.CreateSpecificCulture("da-DK")));
            // The example displays the following output on a system whose
            // current culture is English (United States):
            //       $12,345.68
            //       $12,345.679
            //       12.345,679 kr



            // The Decimal ("D") Format Specifier
            int value4, value5;

            Console.WriteLine("\n\nThe Decimal (\"D\") Format Specifier");
            value4 = 12345;
            Console.WriteLine(value4.ToString("D"));
            // Displays 12345
            Console.WriteLine(value4.ToString("D8"));
            // Displays 00012345

            value5 = -12345;
            Console.WriteLine(value5.ToString("D"));
            // Displays -12345
            Console.WriteLine(value5.ToString("D8"));
            // Displays -00012345



            //The Exponential("E") Format Specifier

            double value6 = 12345.6789;
            Console.WriteLine("\n\nThe Exponential(\"E\") Format Specifier");
            Console.WriteLine(value6.ToString("E", CultureInfo.InvariantCulture));
            // Displays 1.234568E+004

            Console.WriteLine(value6.ToString("E10", CultureInfo.InvariantCulture));
            // Displays 1.2345678900E+004

            Console.WriteLine(value6.ToString("e4", CultureInfo.InvariantCulture));
            // Displays 1.2346e+004

            Console.WriteLine(value6.ToString("E",
                              CultureInfo.CreateSpecificCulture("fr-FR")));
            // Displays 1,234568E+004



            //The Fixed-Point("F") Format Specifier
            int integerNumber1;
            integerNumber1 = 17843;
            Console.WriteLine("\n\nThe Fixed-Point(\"F\") Format Specifier");
            Console.WriteLine(integerNumber1.ToString("F",
                              CultureInfo.InvariantCulture));
            // Displays 17843.00

            int integerNumber2;
            integerNumber2 = -29541;
            Console.WriteLine(integerNumber2.ToString("F3",
                              CultureInfo.InvariantCulture));
            // Displays -29541.000

            double doubleNumber1;
            doubleNumber1 = 18934.1879;
            Console.WriteLine(doubleNumber1.ToString("F", CultureInfo.InvariantCulture));
            // Displays 18934.19

            Console.WriteLine(doubleNumber1.ToString("F0", CultureInfo.InvariantCulture));
            // Displays 18934

            double doubleNumber2;
            doubleNumber2 = -1898300.1987;
            Console.WriteLine(doubleNumber2.ToString("F1", CultureInfo.InvariantCulture));
            // Displays -1898300.2

            Console.WriteLine(doubleNumber2.ToString("F3",
                              CultureInfo.CreateSpecificCulture("es-ES")));
            // Displays -1898300,199    



            //The General("G") Format Specifier
        }
    }
}
