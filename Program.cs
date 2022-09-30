void Zadacha25()
{ 
    int N,a;
    Console.WriteLine("Задача №25 ");  	
    Console.WriteLine("Введите число ");
    a = Convert.ToInt32(Console.ReadLine()); 	
    Console.WriteLine("Введите степень числа ");
    N = Convert.ToInt32(Console.ReadLine());
    int b=1;
       for(int i=1;i<=N;i++)
    {
         b=b*a;    
    }
        Console.WriteLine(b);
	}	
    


void Zadacha27()
{
Console.WriteLine("Задача № 27 ");
Console.WriteLine ("Ввведите число ");
int x=Convert.ToInt32(Console.ReadLine());
int sum=0;
while (x>0)
 {
    sum=sum+x%10;
    x=x/10;  
 }
Console.WriteLine ("Сумма чисел "+sum);
}
    

void Zadacha29()
{
Console.WriteLine("Задача № 29 ");
int size=8;
Random ran=new Random();
int []num=new int [size];
int i;
for ( i=0; i<size; i++)
   {
    num[i]=ran.Next(-20,20);
    Console.Write(num[i]+"\t");
   }
   Console.WriteLine();

 for (i = 0; i < size; i++)
		for (int j = 0; j < size - 1; j++)
			if (Math.Abs((num[j])) >Math.Abs((num[j + 1])))
				{
                    int m = num[j + 1];
					num[j + 1] = num[j];
					num[j] = m;
				}
      Console.WriteLine("Отсортированный массив ");
for ( i = 0; i < size; i++)
            {
                Console.Write(num[i]+"\t");
            }
       Console.WriteLine();
}






Zadacha25();
Zadacha27();
Zadacha29();

