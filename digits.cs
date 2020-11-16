using System;
// This programm calculates how many numbers of 1, 2, 3 or more digits are
// entered by the user until he/she types “end”.
class digits
{
    static void Main()
    {
        int OneDigit = 0, TwoDigits = 0, ThreeDigits = 0, MoreThanThree = 0;
        Console.Write("Insert a number: ");
        string CheckEnd = Console.ReadLine();
        while(CheckEnd != "end"){
            int input = Convert.ToInt32(end);
            if(input != 0){
                if(input / 10 == 0)
                OneDigit ++;
                else 
                if(input / 100 == 0)
                TwoDigits ++;
                else
                if (input / 1000 == 0)
                ThreeDigits ++;
                else
                MoreThanThree++;
            }
            CheckEnd = Console.ReadLine();
        }
        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", OneDigit, TwoDigits, ThreeDigits, MoreThanThree); 
    }
}

