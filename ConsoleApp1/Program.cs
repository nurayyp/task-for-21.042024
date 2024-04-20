//1
//int[] numbers = { 6, 8, 4, 3, 7 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

//2
//int[] numbers = { 2, 3, 4, 5, 6 };
//int sum = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    sum+= numbers[i];
//}
//Console.WriteLine(sum);

//3
//int[] numbers = { 2, 3, 4, 5, 6};
//for (int i =  numbers.Length; i > 0; i--)
//{
//    Console.WriteLine(numbers[i - 1]);
//}

//4
//int[] numbers = new int[5];
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine($"enter the number {i + 1}");
//    numbers[i] = int.Convert(Console.ReadLine());
//}
//for (int j = 0; j < numbers.Length / 2; j++)
//{
//    int temp = numbers[j];
//    numbers[j] = numbers[numbers.Length - 1 - j];
//    numbers[numbers.Length - 1 - j] = temp;
//}
//for (int k = 0; k < numbers.Length; k++)
//{
//    Console.WriteLine(numbers[k] + " ");
//}

//5
//int[] numbers = { 2, 5, 9, 34, 6, 7 };
//int max = numbers[0];
//for (int i = 1; i < numbers.Length; i++)
//{
//    if (numbers[i] > max)
//    {
//        max = numbers[i];
//    }
//}
//Console.WriteLine(max);

//6
//int[] numbers = { 3, 6, 5, 6, 1, 86,};
//int sum = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    sum += numbers[i];
//}
//Console.WriteLine(sum);

//7
//int[] numbers = { 34, 62, 87, 67, 98 };
//int temp;
//for (int i = 0; i< numbers.Length; i++)
//{
//    for (int j = i + 1; j < numbers.Length; j++)
//    {
//        if (numbers[i] < numbers[j])
//        {
//            temp = numbers[i];
//            numbers[i] = numbers[j];
//            numbers[j] = temp;
//        }
//    }
//}
//foreach (int value in numbers)
//{
//    Console.WriteLine(value + " ");
//}

//8
//int[] numbers = { 3, 5, 0, 3, 7, 0, 9, 3, 6 };
//Console.WriteLine("ededi daxil edin");
//int eded = Convert.ToInt32(Console.ReadLine());
//int say = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] == eded)
//    {
//        say++;
//    }
//}
//Console.WriteLine(say);

//9
//int[] numbers = { -4, 4, -6, 5, 2, -8, 7 };
//int say = 0;    
//for (int i = 0; i< numbers.Length; i++)
//{
//    if (numbers[i] < 0)
//    {
//        say++;
//    }
//}
//Console.WriteLine(say);

//10
//int[] numbers = { -4, 4, -6, 5, 2, -8, 7 };
//int sum = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] > 0)
//    {
//        sum+= numbers[i];
//    }
//}
//Console.WriteLine(sum);

//11
//int[] numbers = { 4, 5, 7, 2, 3 };
//for (int i = 0;i < numbers.Length;i++)
//{
//    numbers[i] = numbers[i] * numbers[i];
//}
//for (int k = 0; k < numbers.Length; k++)
//{
//    Console.WriteLine(numbers[k] + " ");
//}

//12
//int[] numbers = { 9, 6, 2, 8, 3, 5 };
//for (int i = 1; i < numbers.Length; i++)
//{
//    int key = numbers[i];
//    int flag = 0;
//    for (int j = i-1; j>= 0 && flag !=1;)
//    {
//        if (key >= numbers[j])
//        {
//            numbers[j + 1] = numbers[j];
//            j--;
//            numbers[j+1] = key;
//        }
//        else flag = 1;
//    }
//}
//for  (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}