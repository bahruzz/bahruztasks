// See https://aka.ms/new-console-template for more information


//int[] arr = { 1, 2, 3, 6, 8, 9 };
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i]==3)
//    {
//        Console.WriteLine("found-" + arr[i]);
//        break;
//    }
//}


//int[]arr ={1,2,3,2,8,9};
//int count = 0;
//for (int i = 0; i < arr.Length; i++)

//{
//    if (arr[i]==2)
//    {
//        count++;
//        if (count==2)
//        {
//            Console.WriteLine("found min 2 time "+ arr[i]);
//            break;
//        }
//    }
//}

//int n = 11;
//int count = 0;
//if (n < 2)
//{
//    Console.WriteLine("ne sade ne murekkeb");
//}
//else
//{
//    for (int i = 1; i <= n; i++)

//        if (n % i == 0)
//        {
//            count++;
//            {
//                if (count==3)
//                {
//                    break;
//                }
//            }
//        }





//    if (count == 2)
//    {
//        Console.WriteLine("sade");
//    }
//    else
//    {
//        Console.WriteLine("murekkeb");
//    }
//}

//int a = 5;
//int b = a;
//b = 100;
//Console.WriteLine(a);
//Console.WriteLine(b);

//int[] arr1 = { 1, 2, 3, 4 };
//int[] arr2 = arr1;
//arr2[0] = 200;
//Console.WriteLine(arr1[0]);
//Console.WriteLine(arr2[0]);


//int[] arr1 = { 1, 2, 3, 4 };
//arr1[0] = 100;
//int[] arr2 = arr1;
//arr2[0] = arr1[0] + 5;
//arr2[0] = 200;
//Console.WriteLine(arr1[0]);
//Console.WriteLine(arr2[0]);



//int[] arr1 = { 1, 2, 3, 4 };
//arr1[0] = 100;
//int[] arr2 = arr1;
//arr2[0] = 200;
//arr2[0] = arr1[0] + arr2[0];
//Console.WriteLine(arr1[0]);
//Console.WriteLine(arr2[0]);


//string name1 = "test";
//string name2 = name1;
//name2 = "salam";
//Console.WriteLine(name1);
//Console.WriteLine(name2);

//int[] arr = { 1, 2, 3, 4, 5 };
//for (int i = 0; i < arr.Length; i++)

//{
//    if (arr[i] == 2)
//    {
//        continue;
//    }
//    Console.WriteLine(arr[i]);
//}
//int a = 6;
//a++;
//Console.WriteLine(a);

//int a = 6;
//Console.WriteLine(a++);

//int a = 6;
//Console.WriteLine(++a);

//int a = 6;
//int b = a++;
//Console.WriteLine(a);
//Console.WriteLine(b);



//int a = 6;
//int b = ++a;
//Console.WriteLine(a);
//Console.WriteLine(b);

//int a = 5;
//int b = a+10;
//Console.WriteLine(a);
//Console.WriteLine(b);

//int a = 15;
//int b = --a;
//int c = ++b;

//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);






//Tasks:

//1) n - ededinin faktorialini hesablayin.

//int n = 5;
//int result = 1;
//for (int i =n;i>0;i--)
//{
//    result *= i;

//}
//Console.WriteLine(result);






//2) Verilmis arrayin icerisinde cut ededlerin ceminin kvadratini hesablayin.

//int[] arr = { 4, 5, 8, 11, 24, 30 };
//int sum = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 0)
//    {
//        sum += arr[i];
//    }
//}
//Console.WriteLine(sum*sum);





//3) n ededi gelir.
//    n - ededinin 2-ni hansisa quvvete yukseltdikde alinan edede beraber olub-olmadigini tapin.
//    Meselen : n ededi 4,8,16 ve s. gelirse yazilsin ki, 2-nin quvettidir. Eks halda quvveti deil yazilsin.

//int n = 32;
//int count = 0;
//bool quvvetidir = true;

//if (n < 0)
//{
//    Console.WriteLine("musbet deyil");
//}
//else
//{
//    for (int i = n; i > 1; i /= 2)
//    {
//        if (i % 2 != 0)
//        {
//            Console.WriteLine("quvveti deyil");
//            quvvetidir = false;
//            break;
//        }
//        count++;
//    }
//}
//if (quvvetidir == true)
//{
//    Console.WriteLine(count);
//}