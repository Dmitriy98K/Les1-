//Что нового
//Случайности
//new Random().Next(min, max)
//даст случайное целое число от min до max-1
//[min, max-1] или [min, max)
int numberA = new Random().Next(1,10);//1,,,9
int numberB = new Random().Next(1,10);
int result =numberA+numberB ;
Console.WriteLine(result);