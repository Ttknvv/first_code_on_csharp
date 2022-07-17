Console.WriteLine("Введите день недели ");
int Num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if(Num<6) {Console.WriteLine("Рабочий день");}
else if(Num<8) {Console.WriteLine("Выходной");}
else {Console.WriteLine("Не в промежутке");}