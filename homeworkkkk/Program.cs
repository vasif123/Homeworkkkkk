using System;

namespace homeworkkkk
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 1-1
            //Gonderilmis 3 ededin en boyuyunu tapib qaytaran metod
            // -3 integer parametr qebul edir ve iclerinde en boyuk hansidirsa onu tapib return edir
            // Eyni sekilde verilmis 4 ve 5 ededin en boyuyunu tapan metodlar da yazin


            //Console.WriteLine("Birinci Deyeri Daxil Et:");
            //string num1Str = Console.ReadLine();
            //Console.WriteLine("Ikinci Deyeri Daxil Et:");
            //string num2Str = Console.ReadLine();
            //Console.WriteLine("Ucuncu Deyeri daxil Et");
            //string num3str = Console.ReadLine();
            //Console.WriteLine("Dorduncu deyeri daxil et");
            //string num4str = Console.ReadLine();
            //Console.WriteLine("Besinci deyeri daxil et");
            //string num5str = Console.ReadLine();
            //try
            //{
            //    int a = int.Parse(num1Str);
            //    int b = int.Parse(num2Str);
            //    int c = int.Parse(num3str);
            //    int d = int.Parse(num4str);
            //    int e = int.Parse(num5str);

            //    Sumbig3(a, b, c);
            //    Sumbig4(a,b,c,d);
            //    Sumbig5(a, b, c, d, e);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Yalniz Reqem Daxil Edile Biler");
            //}

            #endregion
            #region task 2-1
            //Gonderilmis ededin reqemlerinin cemini qaytaran metod 
            // -misalcun bu metodu call ederken arqument olaraq 451 gondersek 
            // metoddan geriye 10 qayitmalidir


            //Console.WriteLine("Eded daxil et");
            //string num = Console.ReadLine();
            //try
            //{
            //    int a = int.Parse(num);
            //    Sum(a);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Yalniz Reqem Daxil Edile Biler");
            //}
            #endregion
            #region task 3-1
            //Supermarketdə belə bir aksiya keçirilir:
            //“İstənilən iki mal alana üçüncüsü pulsuz verilir,
            //ancaq seçilmiş 3 maldan iki ən bahalısının qiyməti ödənilir”.
            //Alınacaq 3 məhsulun qiyməti verilmişdirsə ödəniləcək məbləği hesbalayan metod yazin 
            //-yəni metodunuz 3 doubel parameter qebul edib en boyuk ikisinin cemini hesablayib qaytarmalidir


            //Console.WriteLine("Birincinin qiymeti");
            //string value1 = Console.ReadLine();
            //Console.WriteLine("Ikincinin qiymeti");
            //string value2 = Console.ReadLine();
            //Console.WriteLine("Ucuncunun qiymeti");
            //string value3 = Console.ReadLine();
            //try
            //{
            //    double a = double.Parse(value1);
            //    double b = double.Parse(value2);
            //    double c = double.Parse(value3);

            //    Sum(a, b, c);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Eded daxil edin");
            //}
            #endregion
          
        }
        #region task 1-2
        //static void Sumbig3(int a, int b, int c)
        //{


        //    if (a > b && a > c)
        //    {
        //        Console.WriteLine($"3 reqem arasinda en boyuk {a} dir");
        //    }
        //    else if (b > c && b > a)
        //    {
        //        Console.WriteLine($"3 reqem arasinda enboyuk {b} dir");
        //    }
        //    else if (c > b && c > a)
        //    {
        //        Console.WriteLine($"3 reqem arasinda en boyuk {c} dir");
        //    }
        //    else
        //    {
        //        Console.WriteLine("ededler bir birine beraberdi");
        //    }
        //    return;
        //}
        //static void Sumbig4(int a,int b,int c ,int d)
        //{
        //    if (a > b && a > c && a>d)
        //    {
        //        Console.WriteLine($"4 reqem arasinda en boyuk {a} dir");
        //    }
        //    else if (b > c && b > a && b>d)
        //    {
        //        Console.WriteLine($"4 reqem arasinda enboyuk {b} dir");
        //    }
        //    else if (c > b && c > a && c>d)
        //    {
        //        Console.WriteLine($"4 reqem arasinda en boyuk {c} dir");
        //    }
        //    else if(d>a && d>b && d > c)
        //    {
        //        Console.WriteLine($"4 reqem arasinda en boyuk {d} dir");
        //    }
        //    else
        //    {
        //        Console.WriteLine("ededler bir birine beraberdi");
        //    }
        //    return;
        //}
        //static void Sumbig5(int a, int b, int c, int d,int e)
        //{
        //    if (a > b && a > c && a > d && a>e)
        //    {
        //        Console.WriteLine($"5 reqem arasinda en boyuk {a} dir");
        //    }
        //    else if (b > c && b > a && b > d && b>e)
        //    {
        //        Console.WriteLine($"5 reqem arasinda enboyuk {b} dir");
        //    }
        //    else if (c > b && c > a && c > d &&c>e)
        //    {
        //        Console.WriteLine($"5 reqem arasinda en boyuk {c} dir");
        //    }
        //    else if (d > a && d > b && d > c && d>e )
        //    {
        //        Console.WriteLine($"5 reqem arasinda en boyuk {d} dir");
        //    }
        //    else if (e > a && e > b && e > c && e > d)
        //    {
        //        Console.WriteLine($"5 reqem arasinda en boyuk {e} dir");
        //    }
        //    else
        //    {
        //        Console.WriteLine("ededler bir birine beraberdi");
        //    }
        //    return ;
        //}
        #endregion
        #region task 2-2
        //static void Sum(int a)
        //{
        //    int sum = 0;
        //    int mod;
        //    do
        //    {
        //        mod = a % 10;
        //        sum += mod;
        //        a = (a - mod) / 10;

        //    } while (a > 0);
        //    Console.WriteLine(sum);
        //}
        #endregion
        #region task 3-2
        //static void Sum(double a, double b, double c)
        //{
        //    double result = 0;
        //    if(a<b && a < c)
        //    {
        //        result = b + c;
        //        Console.WriteLine(result);
        //    }
        //    else if(b<a && b< c)
        //    {
        //        result = a + c;
        //        Console.WriteLine(result);
        //    }
        //    else
        //    {
        //        result = a + b;
        //        Console.WriteLine(result);
        //    }
        //}
        #endregion
    }


}
