// ЗАДАЧА №10

int randomNumber = new Random().Next(100,1000);

int secondDigit = (randomNumber / 10) % 10;

Console.Write("Трехзначное число: ");
Console.WriteLine(randomNumber);

Console.Write("Вторая цифра числа: ");
Console.WriteLine(secondDigit);


// ЗАДАЧА №13

Console.Write("Пожалуйста введите число: ");
int number = int.Parse(Console.ReadLine());

int thirdDigit = -1;

if (number >= 100)
{
  while (number > 999)
  {
    number = number / 10;
  }
  thirdDigit = number % 10;    
}

if (thirdDigit >= 0)
{
  Console.Write("Третья цифра числа: ");
  Console.WriteLine(thirdDigit);
}
else
{
   Console.WriteLine("В этом числе нет третьей цифры");
}


// ЗАДАЧА №15

Console.Write("Пожалуйста введите число соответствующее дню недели: ");
int dayWeek = int.Parse(Console.ReadLine());

if (dayWeek > 1 && dayWeek < 8)
   if (dayWeek > 5)
     {
       Console.WriteLine("Ура! Это выходной день.");
     }
    else
    {
       Console.WriteLine("Это рабочий день.");
    }
else
{
Console.WriteLine("В неделе нет дней с таким порядковым номером");
}