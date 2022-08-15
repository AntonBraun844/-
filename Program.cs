int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}
 int numberWeek;
numberWeek = Prompt("Введите день недели в виде цифры: ");    
if (numberWeek<1 || numberWeek>7) {
 System.Console.WriteLine("вы ввели неверную цифру"); 
   }
if (numberWeek>5){
  System.Console.WriteLine("это выходной день");  
}
   else {
    System.Console.WriteLine("это будний день");
   }