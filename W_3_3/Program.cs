/* 
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
 
3 -> 1, 8, 27 
5 -> 1, 8, 27, 64, 125 
*/ 
 
Console.WriteLine("Enter Number(N) "); 
int RundomeNumber = int.Parse(Console.ReadLine()); 
 
int Rnum = RundomeNumber; 
    int digitR = 1; 
    while (Rnum >= digitR) 
    { 
        int result = digitR*digitR*digitR; 
        digitR++; 
 
 
        Console.WriteLine( "Tabl_cubov: " + result); 
    }