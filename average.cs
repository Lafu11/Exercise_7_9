using System;
public class Average{
	public static void Main(){
		double n1 = 0, n2, count = 0, average;
		string CheckEnd;
		Console.Write("Insert a mark: ");
		CheckEnd = Console.ReadLine();	// we read the mark as string to check the word "end"	 
		while(CheckEnd != "end"){
			n2 = Convert.ToDouble(s);
			count++;
			n1 += n2;
			Console.Write("Insert a mark: ");
			CheckEnd = Console.ReadLine();
		}
		if(count != 0){
			average = n1 / count;
			Console.WriteLine("The average is {0}.", average);
		}
	}
}
