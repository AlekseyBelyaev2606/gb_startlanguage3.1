Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int input = int.Parse(Console.ReadLine());

if (input < 10000 && input > 100000){
    Console.WriteLine("Вы ввели неправильное число");
}
else{
    string value = Convert.ToString(input);
    if(value[0] == value[4] && value[1] == value[3]){
        Console.WriteLine("Данное число является палиндромом");
    }
    else{
        Console.WriteLine("Данное число не является палиндромом");
    }
}