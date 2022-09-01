// данная программа принимает на вход число и выдаёт сумму цифр в числе, которые являются делителями этого числа. 
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int number_clone = number; // вводим новую пременную для запоминания первичного значения number
int sum = 0; // переменная для подсчета суммы цифр
while(number_clone > 0)
   {
      if((number_clone % 10) != 0 && number % (number_clone % 10) == 0) // проверяем является ли цифра делителем числа,исключаем деление на ноль
      {
         sum = sum + (number_clone % 10);
      }   
      number_clone = number_clone / 10;
   }
// выводим сумму цифр
Console.WriteLine("сумма цифр в числе: " + sum);