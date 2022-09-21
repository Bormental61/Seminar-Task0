/* Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

int getRandomThreeDigitNumber(int minBorder, int maxBorder)
{
    int result = new Random().Next(minBorder, maxBorder);
    return result;
}
int deleteSecondDigit(int number)
{
    int firstDigit = new int();
    int thirdDigit = new int();
    firstDigit = number / 100;
    thirdDigit = number % 10;
    int firstThirdDigitNumber = firstDigit*10 + thirdDigit;
    return firstThirdDigitNumber;
}
int randomNumber = getRandomThreeDigitNumber(100, 1000);
Console.WriteLine($"Случайное трехзначное число {randomNumber}");
int secondDigitDeletedNumber = deleteSecondDigit(randomNumber);
Console.WriteLine($"Число без второй цифры {secondDigitDeletedNumber}");

