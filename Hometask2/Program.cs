#region RomanToInteger


//Console.WriteLine("Enter your input:");
//string Roman = Console.ReadLine();
//int result = 0;
//int myNumber = 0;
//for (int i = Roman.Length - 1; i >= 0; i--)
//{
//    switch (Roman[i])
//    {
//        case 'I':
//            myNumber = 1;
//            break;
//        case 'V':
//            myNumber = 5;
//            break;
//        case 'X':
//            myNumber = 10;
//            break;
//        case 'L':
//            myNumber = 50;
//            break;
//        case 'C':
//            myNumber = 100;
//            break;
//        case 'D':
//            myNumber = 500;
//            break;
//        case 'M':
//            myNumber = 1000;
//            break;
//    }
//    if ( myNumber < result)
//    {
//        result -= myNumber;
//    }
//    else
//    {
//        result += myNumber;
//    }
//}
//Console.WriteLine("Your converted result: "+result);


#endregion

#region DivideTwoIntegers
//public class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter your dividend:");
//        int dividend=Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter your divisor:");
//        int divisor=Convert.ToInt32(Console.ReadLine());
//        DivideTwoInteger( dividend, divisor);
//    }
//    static void DivideTwoInteger(int dividend,int divisor)
//    {
//        if (divisor == 0) 
//        {
//            Console.WriteLine("This operation doesn't exist.");
//            return;
//        }
//        if (dividend == 0) {
//            Console.WriteLine("0");
//            return;
//        }
//        int quotient = 0;
//        while (dividend >= divisor)
//        {
//            dividend -= divisor;   //dividend = dividend-divisor;
//            quotient++;
//        }

//        if ((dividend < 0) != (divisor < 0))
//        {
//            Console.WriteLine(-quotient); 
//        }
//        else
//        {
//            Console.WriteLine("Your quotient in result: "+quotient); 
//        }


//    }
//}



#endregion