// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Функция задания user-ом параметров прямой в формате: y= k * x + b
void LineSet(double[] lineIncome, string text)
{
    double[] line = new double[2];
    System.Console.Write(text + " Через пробел: первое число k- наклон, второе b- смещение: ");
    line = Array.ConvertAll(Console.ReadLine()!.Split(), double.Parse);
    System.Console.WriteLine("Задана прямая: y = " + line[0] + "*x + " + line[1]);
    lineIncome[0] = line[0];
    lineIncome[1] = line[1];
}

// Проверка линий заданных в формате [параметр k (наклон), параметр b (смещение)]
// false- нет пересечения, true- пересечение линий есть
bool LineCheck(double[] line1, double[] line2)
{
    if (line1[0] == line2[0])
    {
        if (line1[1] == line2[1])
        {
            System.Console.WriteLine("Линии полностью совпадают.");
            return false;
        }
        else
        {
            System.Console.WriteLine("Линии параллельны.");
            return false;
        }
    }
    return true;
}

// Функция нахождения и вывода (без сохранения найденных координат) точки пересечения двух линий
void FindCrossPoint(double[] ln1, double[] ln2)
{
    if (LineCheck(ln1, ln2))
    {
        double x = (ln1[1] - ln2[1]) / (ln2[0] - ln1[0]);
        double y = (ln1[0] * x + ln1[1]);
        System.Console.WriteLine($"Координаты точки пересечения: {x}, {y}");
        return;
    }
    else
    {
        return;
    }
}

double[] lineOne = new double[2];
double[] lineTwo = new double[2];
LineSet(lineOne, "Введите коэффициенты первой прямой");
LineSet(lineTwo, "Введите коэффициенты второй прямой");
FindCrossPoint(lineOne, lineTwo);