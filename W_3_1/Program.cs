/* 
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
 
14212 -> нет 
 
12821 -> да 
 
23432 -> да 
*/ 
 
Console.WriteLine("Enter number: "); 
int number = int.Parse(Console.ReadLine()); 
 
Palindrom(number); 
 
void Palindrom (int num) 
{ 
   int FormulaFirst = number % 10; 
   int FormulaSecond = number / 10000; 
    if (FormulaFirst == FormulaSecond) 
   { 
      FormulaFirst = (FormulaFirst * 10) / 100; 
      FormulaSecond = (FormulaSecond * 10) % 10; 
 
   } 
   if (FormulaFirst == FormulaSecond)  
      Console.WriteLine("Yes, polindrom " + num);  
 
      else 
      Console.WriteLine("No, polindrom " + num); 
}
