/* 
Напишите программу для вычисления площади круга, прямоугольника и треугольника.  
Ввод данных осуществляется в диалоговом режиме. На первом шаге у пользователя запрашивается фигура, 
 площадь которой нужно вычислить.  
На втором шаге пользователь вводит параметры, необходимые для рассчета. Затем, выводится результат. 
*/ 
 
 
Console.WriteLine("Enter radius circle "); 
int Radius = int.Parse(Console.ReadLine()); 
 
Console.WriteLine("S circle = " + Math.Round(3.14*Radius*Radius)); 
double PloshchCircle(int r) 
{ 
    double ploshchCr = Math.Sqrt(3.14*r*r); 
    return ploshchCr; 
} 
 
Console.WriteLine("Enter sides triangle "); 
int firstSideTriangle = int.Parse(Console.ReadLine()); 
int secondSideTriangle = int.Parse(Console.ReadLine()); 
 
Console.WriteLine("S triangle = " + Math.Round(0.5*firstSideTriangle*secondSideTriangle)); 
double PloshchTriangle(int fst, int sst) 
{ 
    double ploshchTri = Math.Sqrt(0.5*fst*sst); 
    return ploshchTri; 
} 
 
Console.WriteLine("Enter sides rectangle "); 
int firstSideRectangle = int.Parse(Console.ReadLine()); 
int secondSideRectangle = int.Parse(Console.ReadLine()); 
 
Console.WriteLine("S rectangle = " + Math.Abs(firstSideRectangle*secondSideRectangle)); 
double PloshchRectangle(int fsr, int ssr) 
{ 
    double ploshchRect = Math.Sqrt(fsr*ssr); 
    return ploshchRect; 
}
