using System.Runtime.InteropServices;

Console.Write("Enter one of them : C | T | R");

char input =Convert.ToChar( Console.ReadLine());

switch(input)
{
    case 'C':
    Circle(5);
    break;

    case 'T':
        Triangle(5);
    break;

    case 'R':
        Rectangle(5,8);
    break;
}
 
void Circle(int radius)
 {
    for (int y = 0; y <= 2 * radius; y++) 
    {
          for (int x = 0; x <= 2 * radius; x++) 
            {
               int distance = (int)Math.Sqrt(Math.Pow(x - radius, 2) + Math.Pow(y - radius, 2));
                 if (distance > radius - 0.5 && distance < radius + 0.5) 
                {
                   Console.Write("* ");  
                }  else 
                {
                 Console.Write("  ");  
                }
            }
               Console.WriteLine();  
   } 
 }

 void Triangle(int height)
 {
    for (int i = 1; i <= height; i++) 
    {
     for (int j = 1; j <= i; j++) 
     {
        Console.Write("* ");  
     }
      Console.WriteLine();  
    }
 }

 void Rectangle(int height,int width)
 
    
 
 {
     for (int i = 0; i < height; i++) 
     {
        for (int j = 0; j < width; j++)
         {
            Console.Write("* ");  
         }
        Console.WriteLine();  
     }
 }