// int dayNumber = 7;

// switch (dayNumber) {
//     case 5 or 7: Console.WriteLine("Выходной"); break;
//     default: Console.WriteLine("Будний"); break;
// }


// int score = 78;

// switch (score)
// {
//     case >= 0 and <= 40:
//         Console.WriteLine("Неудовлетворительно");
//         break;
//     case >= 40 and < 60:
//         Console.WriteLine("Удовлетворительно");
//         break;
//     case >= 60 and < 80:
//         Console.WriteLine("Хорошо");
//         break;
//     case >= 80 and <= 100:
//         Console.WriteLine("Отлично");
//         break;
//     default:
//         Console.WriteLine("Некорректный балл");
//         break;
// }

// int temperature = 27;

// string temp = temperature switch {
//     >= 35 => "Очень жарко",
//     >= 25 => "Жарко",
//     >= 15 => "Комфортно",
//     >= 0 => "Прохладно",
//     < 0 => "Мороз"
// };

// Console.WriteLine(temp);

// string role = "teacher";

// string result = role switch {
//     "admin" => "Полный доступ",
//     "teacher" => "Доступ преподавателя",
//     _ => "Ограниченный доступ"
// };

// Console.WriteLine(result);

// int age = 20;
// bool hasTicket = true;

// switch (age) {
//     case >= 18 when hasTicket:
//         Console.WriteLine("Вход разрешен");
//         break;
//     case >= 18:
//         Console.WriteLine("Нет билета");
//         break;
//     default:
//         Console.WriteLine("Возраст не подходит");
//         break;
// }

// int level = 2;

// switch (level)
// {
//     case 1:
//         Console.WriteLine("Начальный уровень");
//         break;
//     case 2:
//         Console.WriteLine("Средний уровень");
//         break;
//     case 3:
//         Console.WriteLine("Продвинутый уровень");
//         break;
// }

//Задача A:

// Console.Write("Введите номер месяца (1-12): ");
// int num = int.Parse(Console.ReadLine());
// string result = num switch {
//     12 or 1 or 2 => "Зима",
//     3 or 4 or 5 => "Весна",
//     6 or 7 or 8 => "Лето",
//     9 or 10 or 11 => "Осень",
//     _ => "Неверный месяц"
// };

// Console.WriteLine(result);

//задача В
// Console.Write("Введите номер дня недели (1-7): ");
// int number = int.Parse(Console.ReadLine());
// string result = number switch {
//     >= 1 and <= 5 => "Будний",
//     >= 6 and <= 7 => "Выходной",
//     _ => "Неверный день недели"
// };

// Console.WriteLine(result);

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

//№6
// Console.WriteLine("Введите роль пользователя (admin, teacher, user): ");
// string role = Console.ReadLine();
// bool isTeacher = false;
// string rolee = role switch {
//     "admin" => "Полный доступ",
//     "user" => "Ограниченный доступ",
//     "teacher" when !isTeacher => "Требуется подтвержение",
//     "teacher" => "Доступ преподавателя",
//     _ => "Доступ запрещен"
// };

// Console.WriteLine(rolee);


//№7
// int points = int.Parse(Console.ReadLine());
// string level = points switch
// {
//     < 0 => "Ошибка",
//     >= 0 and <= 999 => "Новичок",
//     >= 1000 and <= 4999 => "Опытный",
//     >= 5000 and <= 9999 => "Продвинутый",
//     >= 10000 => "Мастер"
// };
// Console.WriteLine(level);


int number = 42;
string result = number switch {
    < 0 => "Отрицательное",
    1 or 2 or 3 => "Маленькое число",
    >= 0 and <= 9 => "Однозначное",
    >= 10 and <= 99 => "Двузначное",
    >= 100 => "Трехзначное или больше"
};

Console.WriteLine(result);