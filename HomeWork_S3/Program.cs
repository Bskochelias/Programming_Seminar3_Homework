/*
Найти кубы чисел от 1 до N
Найти сумму чисел от 1 до А
Возведите число А в натуральную степень B используя цикл
Подсчитать сумму цифр в числе
Написать программу вычисления произведения чисел от 1 до N
Показать кубы чисел, заканчивающихся на четную цифру
Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
Определить, присутствует ли в заданном массиве, некоторое число
Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Найти сумму чисел одномерного массива стоящих на нечетной позиции
Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
*/

int Proverca_chisla()
{ 
  int num;
  while (true)
    {var input = Console.ReadLine();

    if (int.TryParse(input, out num))
        break;                                                   // обработка при успехе и выход из цикла
    else                                                         // обработка при ошибке
    {
        Console.WriteLine("[ERROR]: Не коректные данные по пробуйте еще раз!");
        Console.Write("Введите число: ");
    }
    }
  return num;
}



int otvet = 1;
string? otvet2 = " ";
do
{
  do
  { 
    Console.Clear();

    Console.WriteLine(" ");
    Console.WriteLine("Добрый день прошу выбрать цифру из списка что Вы хотите сделать?");
    Console.WriteLine("__________");
    Console.WriteLine("1. Найти кубы чисел от 1 до N");
    Console.WriteLine("2. Найти сумму чисел от 1 до А");
    Console.WriteLine("3. Возведите число А в натуральную степень B используя цикл");
    Console.WriteLine("4. Подсчитать сумму цифр в числе");
    Console.WriteLine("5. Написать программу вычисления произведения чисел от 1 до N");
    Console.WriteLine("6. Показать кубы чисел, заканчивающихся на четную цифру");
    Console.WriteLine("7. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран");
    Console.WriteLine("8. Определить, присутствует ли в заданном массиве, некоторое число");
    Console.WriteLine("9. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетныхчетных чисел");
    Console.WriteLine("10. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]");
    Console.WriteLine("11. Найти сумму чисел одномерного массива стоящих на нечетной позиции");
    Console.WriteLine("12. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.");
    Console.WriteLine("13. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом");
    Console.WriteLine("__________");
    Console.WriteLine(" ");

    otvet = Proverca_chisla();

    if (otvet > 14 ^ otvet < 1)
    {
      Console.WriteLine("Такой задачи тут нету!");
      Console.Write("Нажмите <Enter> для повторго ввода... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}      
    }

  } while (otvet > 14 ^ otvet < 1);

  Console.Clear();

//Начало тела задач

  //1. Найти кубы чисел от 1 до N
  if (otvet == 1)
    {
      int n1, i1 = 1;
      Console.Write("Введите число до которого вычеслять кубы чисел: ");
      n1 = Proverca_chisla();

      while (i1 < n1)
      {
        Console.WriteLine($"Куб числа {i1} равен: {i1*i1*i1}");
        i1++;
      }           
    }

//2. Найти сумму чисел от 1 до А
  if (otvet == 2)
    {
      int n2, i2 = 1,sum = 0;
      Console.Write("Введите число до которого нужно вычеслять сумму чисел: ");
      n2 = Proverca_chisla();

      while (i2 <= n2)
      {
        sum = sum + i2;
        i2++;
      }      
      Console.WriteLine($"Сумма чисел от 1 до {n2} равна: {sum} ");
    }

//3. Возведите число А в натуральную степень B используя цикл
  if (otvet == 3)
    {
      int a3, b3, i3 = 0,step = 1;
      Console.Write("Введите число для возведения в натуральную степь: ");
      a3 = Proverca_chisla();

      Console.Write("Введите натуральную степь: ");
      b3 = Proverca_chisla();

      while (i3 < b3)
      {
        step = step * a3;
        i3++;
      }      
      Console.WriteLine($"Число {a3} в натуральную степень {b3} равна: {step} ");
    }   

//4. Подсчитать сумму цифр в числе
  if (otvet == 4)
    {
      int a4, i4 = 1,copy, delitel = 2147483646;
      string? chislo;

      Console.Write("Введите число, для определения длины: ");
      a4 = Proverca_chisla();

      if (a4 < 0) {a4 = a4*-1;} 
      chislo = Convert.ToString(a4);

      copy = a4;
      while (copy > 9)
      {
        copy=copy%delitel;
        delitel= delitel/10;
        if (copy != a4)
        i4++;
      }
      Console.WriteLine($"Длина числа через опредления строки равна: {chislo.Length}");
      Console.WriteLine($"Длина строки через остаток равна: {i4}");
    }

//5. Написать программу вычисления произведения чисел от 1 до N
  if (otvet == 5)
    {
      int n5, i5 = 1, proiz = 1;
      Console.Write("Введите число до которого нужно вычеслять произведения чисел: ");
      n5 = Proverca_chisla();

      while (i5 <= n5)
      {
        proiz = proiz * i5;
        i5++;
      }      
      Console.WriteLine($"Произведения чисел от 1 до {n5} равна: {proiz} ");
    }

//6. Показать кубы чисел, заканчивающихся на четную цифру
  if (otvet == 6)
    {
      int n6, i6 = 1,kub;
      Console.Write("Введите число до которого нужно вывести кубы чисел заканчивающихся на четную цифру: ");
      n6 = Proverca_chisla();

      while (i6 <= n6)
      {
        kub = i6 * i6 * i6;
        if (kub%2==0)
        Console.WriteLine($"Куб числа {i6} равна: {kub} ");
        i6++;
      }      
    }

//Конец тела задач    
  Console.Write("Нажмите <Enter> для продолжения... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}

  do
  {
    Console.Clear();
    Console.WriteLine("Вы хотите воспользоваться еще одним решением? Yes/No");
    Console.WriteLine(" ");
    otvet2 = Console.ReadLine();

    if (otvet2 != "No" && otvet2 != "no" && otvet2 != "NO" && otvet2 !="n" && otvet2 !="N" 
        && otvet2 != "Yes" && otvet2 != "yes" && otvet2 != "YES" && otvet2 !="y" && otvet2 !="Y")
    {
    Console.WriteLine("Некоректный ответ");
    Console.Write(" Нажмите <Enter> для повторго ввода... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}
    }
  }
  while (otvet2 != "No" && otvet2 != "no" & otvet2 != "NO" && otvet2 !="n" && otvet2 !="N" 
        && otvet2 != "Yes" && otvet2 != "yes" && otvet2 != "YES" && otvet2 !="y" && otvet2 !="Y");

}
while (otvet2 != "No" & otvet2 != "no" & otvet2 != "NO" & otvet2 !="n" & otvet2 !="N");

Console.Clear();

Console.WriteLine("Спасибо, что воспользовались программой. Досвидание!!!");
Console.Write("Нажмите <Enter> для выхода... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}

Console.Clear();