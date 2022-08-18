// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool palindrom(int number)
{
    string result = Convert.ToString(number);
    for (int i = 0, j = result.Length -1; i < j; i++, j--)
        if (result[i] != result[j])
        return false;
    return true;
}
Console.Write("Введите число: ");
int userNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(palindrom(userNum));