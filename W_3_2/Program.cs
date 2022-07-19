/* 
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
 
A (3,6,8); B (2,1,-7), -> 15.84 
 
A (7,-5, 0); B (1,-1,9) -> 11.53 
*/ 
 
Console.WriteLine("Enter coordinatu - A(x) "); 
int Coor_Ax = int.Parse(Console.ReadLine()); 
Console.WriteLine("Enter coordinatu - A(y) "); 
int Coor_Ay = int.Parse(Console.ReadLine()); 
Console.WriteLine("Enter coordinatu - A(i) "); 
int Coor_Ai = int.Parse(Console.ReadLine()); 
 
Console.WriteLine("Enter coordinatu - B(x) "); 
int Coor_Bxx = int.Parse(Console.ReadLine()); 
Console.WriteLine("Enter coordinatu - B(y) "); 
int Coor_Byy = int.Parse(Console.ReadLine()); 
Console.WriteLine("Enter coordinatu - B(i) "); 
int Coor_Bii = int.Parse(Console.ReadLine()); 
 
 
Console.WriteLine("Lenght otrezka 3D = " + Math.Floor(getLenght(Coor_Ax,Coor_Ay,Coor_Ai,Coor_Bxx,Coor_Byy,Coor_Bii))); 
 
double getLenght(int x, int y, int i, int xx, int yy, int ii) 
{ 
    double distanceOtrezka = Math.Sqrt((xx-x)*(xx-x) + (yy-y)*(yy-y) + (ii-i)*(ii-i)); 
    return distanceOtrezka; 
}