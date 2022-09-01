// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

bool t = true;
while(t == true)
{
   Console.Write("Вы хотите найти степень числа? Ответьте: 'да' или 'нет' ");
   string answer = Console.ReadLine();
   if (answer == "нет" || answer == "Нет")
   {
      Console.WriteLine("Завершение программы");
      t = false;
   }
   else
   {
      Console.Write("Введите основание степени - число А: ");
      int A = Convert.ToInt32(Console.ReadLine());
      Console.Write("Введите степень числа - число B: ");
      int B = Convert.ToInt32(Console.ReadLine());

      int A_to_the_B = A; // переменная для вычисления степени числа A 
      int degree = 1; // переменная для изменения степени числа
      while(degree < B)
         {
           A_to_the_B = A_to_the_B * A; 
           degree++;   
         }
      Console.WriteLine("Результат: " + A_to_the_B);   
   }
}