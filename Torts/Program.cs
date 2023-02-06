Main();
static void Main()
{
    Console.Clear();
    Console.SetCursorPosition(0, 0);
    Console.WriteLine("Хотите сделать заказ?");
    Class p5 = new Class();
    p5.strela = "->";
    int posit = 1;
    Console.SetCursorPosition(0, posit);
    Console.WriteLine(p5.strela);
    Console.SetCursorPosition(2, 1);
    Console.WriteLine("Да");
    Console.SetCursorPosition(2, 2);
    Console.WriteLine("Нет");
    do
    {
        ConsoleKeyInfo key5 = Console.ReadKey();
        if (key5.Key == ConsoleKey.UpArrow)
        {
            posit--;
        }
        if (key5.Key == ConsoleKey.DownArrow)
        {
            posit++;
        }
        if (posit == 1 && key5.Key == ConsoleKey.Enter)
        {
            File.AppendAllText("C:\\Users\\lexre\\Desktop\\Zakaz.txt.txt", "\nВаш заказ (Торт):");
            strela_Nachalo();
        }
        if (posit == 2 && key5.Key == ConsoleKey.Enter)
        {
            Environment.Exit(0);
        }
        else
            Console.Clear();
        Console.SetCursorPosition(0, 0);
        Console.WriteLine("Хотите сделать заказ?");
        Console.SetCursorPosition(0, posit);
        Console.WriteLine(p5.strela);
        Console.SetCursorPosition(2, 1);
        Console.WriteLine("Да");
        Console.SetCursorPosition(2, 2);
        Console.WriteLine("Нет");
    }
    while (true);
}
static void nachalo()
{
    Console.Clear();
    Class p = new Class();
    p.x = "Количество коржей ";
    p.y = "Начинка ";
    p.z = "Размер ";
    p.a = "Цвет ";
    p.b = "Крем ";
    p.c = "Декор ";
    Console.SetCursorPosition(2, 0);
    Console.WriteLine(p.x);
    Console.SetCursorPosition(2, 1);
    Console.WriteLine(p.y);
    Console.SetCursorPosition(2, 2);
    Console.WriteLine(p.z);
    Console.SetCursorPosition(2, 3);
    Console.WriteLine(p.a);
    Console.SetCursorPosition(2, 4);
    Console.WriteLine(p.b);
    Console.SetCursorPosition(2, 5);
    Console.WriteLine(p.c);
}
static void forma()
{
    Console.Clear();
    Class p2 = new Class();
    p2.x = "Квадрат-10$";
    p2.y = "Круг-20$";
    p2.z = "Треугольник-30$";
    Console.SetCursorPosition(2, 0);
    Console.WriteLine(p2.x);
    Console.SetCursorPosition(2, 1);
    Console.WriteLine(p2.y);
    Console.SetCursorPosition(2, 2);
    Console.WriteLine(p2.z);
}
static void vkus()
{
    Console.Clear();
    Class p3 = new Class();
    p3.x = "Клубничный-10$";
    p3.y = "Шоколадный-20$";
    p3.z = "Ванильный-30$";
    Console.SetCursorPosition(2, 0);
    Console.WriteLine(p3.x);
    Console.SetCursorPosition(2, 1);
    Console.WriteLine(p3.y);
    Console.SetCursorPosition(2, 2);
    Console.WriteLine(p3.z);
}
static void razmer()
{
    Console.Clear();
    Class p4 = new Class();
    p4.x = "Маленький-10$";
    p4.y = "Средний-20$";
    p4.z = "Большой-30$";
    Console.SetCursorPosition(2, 0);
    Console.WriteLine(p4.x);
    Console.SetCursorPosition(2, 1);
    Console.WriteLine(p4.y);
    Console.SetCursorPosition(2, 2);
    Console.WriteLine(p4.z);
}
static void kollichestvo()
{
    Console.Clear();
    Class p2 = new Class();
    p2.x = "Один-10$";
    p2.y = "Два-20$";
    p2.z = "Три-30$";
    Console.SetCursorPosition(2, 0);
    Console.WriteLine(p2.x);
    Console.SetCursorPosition(2, 1);
    Console.WriteLine(p2.y);
    Console.SetCursorPosition(2, 2);
    Console.WriteLine(p2.z);
}
static void glazury()
{
    Console.Clear();
    Class p2 = new Class();
    p2.x = "Сахарная-10$";
    p2.y = "Белковая-20$";
    p2.z = "Шоколадная-30$";
    Console.SetCursorPosition(2, 0);
    Console.WriteLine(p2.x);
    Console.SetCursorPosition(2, 1);
    Console.WriteLine(p2.y);
    Console.SetCursorPosition(2, 2);
    Console.WriteLine(p2.z);
}
static void Dekor()
{
    Console.Clear();
    Class p2 = new Class();
    p2.x = "Мастика-10$";
    p2.y = "Посыпка-20$";
    p2.z = "Крем-30$";
    Console.SetCursorPosition(2, 0);
    Console.WriteLine(p2.x);
    Console.SetCursorPosition(2, 1);
    Console.WriteLine(p2.y);
    Console.SetCursorPosition(2, 2);
    Console.WriteLine(p2.z);
}
static void strela_kollichestvo()
{
    Class p5 = new Class();
    p5.strela = "->";
    int posit = 0;
    Console.Clear();
    kollichestvo();
    Console.SetCursorPosition(0, posit);
    Console.WriteLine(p5.strela);
    do
    {
        ConsoleKeyInfo key1 = Console.ReadKey();
        if (key1.Key == ConsoleKey.UpArrow)
        {
            posit--;
        }
        else if (key1.Key == ConsoleKey.DownArrow)
        {
            posit++;
        }
        else if (key1.Key == ConsoleKey.Backspace)
        {
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", p5.add + p5.save);
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", ";");
            strela_Nachalo();
        }
        else if (posit == 0 && key1.Key == ConsoleKey.Enter)
        {
            p5.save = p5.save + p5.one_Chena;
            string a = "Один,";
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", a);
        }
        else if (posit == 1 && key1.Key == ConsoleKey.Enter)
        {
            p5.save = p5.save + p5.two_Chena;
            string a = "Два,";
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", a);
        }
        else if (posit == 2 && key1.Key == ConsoleKey.Enter)
        {
            p5.save = p5.save + p5.three_Chena;
            string a = "Три,";
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", a);
        }

        Console.Clear();
        kollichestvo();
        Console.SetCursorPosition(0, posit);
        Console.WriteLine(p5.strela);
    }
    while (true);
}
static void strela_glazury()
{
    Class p5 = new Class();
    p5.strela = "->";
    int posit = 0;
    Console.Clear();
    glazury();
    Console.SetCursorPosition(0, posit);
    Console.WriteLine(p5.strela);
    do
    {
        ConsoleKeyInfo key1 = Console.ReadKey();
        if (key1.Key == ConsoleKey.UpArrow)
        {
            posit--;
        }
        else if (key1.Key == ConsoleKey.DownArrow)
        {
            posit++;
        }
        else if (key1.Key == ConsoleKey.Backspace)
        {
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", p5.add + p5.save);
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", ";");
            strela_Nachalo();
        }
        else if (posit == 0 && key1.Key == ConsoleKey.Enter)
        {
            p5.save = p5.save + p5.one_Chena;
            string a = "Сахарная,";
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", a);
        }
        else if (posit == 1 && key1.Key == ConsoleKey.Enter)
        {
            p5.save = p5.save + p5.two_Chena;
            string a = "Белковая,";
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", a);
        }
        else if (posit == 2 && key1.Key == ConsoleKey.Enter)
        {
            p5.save = p5.save + p5.three_Chena;
            string a = "Шоколадная,";
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", a);
        }

        Console.Clear();
        glazury();
        Console.SetCursorPosition(0, posit);
        Console.WriteLine(p5.strela);
    }
    while (true);
}
static void strela_Dekor()
{
    Class p5 = new Class();
    p5.strela = "->";
    int posit = 0;
    Console.Clear();
    Dekor();
    Console.SetCursorPosition(0, posit);
    Console.WriteLine(p5.strela);
    do
    {
        ConsoleKeyInfo key1 = Console.ReadKey();
        if (key1.Key == ConsoleKey.UpArrow)
        {
            posit--;
        }
        else if (key1.Key == ConsoleKey.DownArrow)
        {
            posit++;
        }
        else if (key1.Key == ConsoleKey.Backspace)
        {
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", p5.add + p5.save);
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", ";");
            strela_Nachalo();
        }
        else if (posit == 0 && key1.Key == ConsoleKey.Enter)
        {
            p5.save = p5.save + p5.one_Chena;
            string a = "Мастика,";
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", a);
        }
        else if (posit == 1 && key1.Key == ConsoleKey.Enter)
        {
            p5.save = p5.save + p5.two_Chena;
            string a = "Посыпка,";
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", a);
        }
        else if (posit == 2 && key1.Key == ConsoleKey.Enter)
        {
            p5.save = p5.save + p5.three_Chena;
            string a = "Крем,";
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", a);
        }

        Console.Clear();
        Dekor();
        Console.SetCursorPosition(0, posit);
        Console.WriteLine(p5.strela);
    }
    while (true);
}
static void strela_vkus()
{
    Class p5 = new Class();
    p5.strela = "->";
    int posit = 0;
    Console.Clear();
    vkus();
    Console.SetCursorPosition(0, posit);
    Console.WriteLine(p5.strela);
    do
    {
        ConsoleKeyInfo key1 = Console.ReadKey();
        if (key1.Key == ConsoleKey.UpArrow)
        {
            posit--;
        }
        else if (key1.Key == ConsoleKey.DownArrow)
        {
            posit++;
        }
        else if (key1.Key == ConsoleKey.Backspace)
        {
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", p5.add + p5.save);
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", ";");
            strela_Nachalo();
        }
        else if (posit == 0 && key1.Key == ConsoleKey.Enter)
        {
            p5.save = p5.save + p5.one_Chena;
            string a = "Клубничный,";
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", a);
        }
        else if (posit == 1 && key1.Key == ConsoleKey.Enter)
        {
            p5.save = p5.save + p5.two_Chena;
            string a = "Шоколадный,";
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", a);
        }
        else if (posit == 2 && key1.Key == ConsoleKey.Enter)
        {
            p5.save = p5.save + p5.three_Chena;
            string a = "Ванильный,";
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", a);
        }

        Console.Clear();
        vkus();
        Console.SetCursorPosition(0, posit);
        Console.WriteLine(p5.strela);
    }
    while (true);
}
static void strela_forma()
{
    Class p5 = new Class();
    p5.strela = "->";
    int posit = 0;
    Console.Clear();
    forma();
    Console.SetCursorPosition(0, posit);
    Console.WriteLine(p5.strela);
    do
    {
        ConsoleKeyInfo key1 = Console.ReadKey();
        if (key1.Key == ConsoleKey.UpArrow)
        {
            posit--;
        }
        else if (key1.Key == ConsoleKey.DownArrow)
        {
            posit++;
        }
        else if (key1.Key == ConsoleKey.Backspace)
        {
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", p5.add + p5.save);
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", ";");
            strela_Nachalo();
        }
        else if (posit == 0 && key1.Key == ConsoleKey.Enter)
        {
            p5.save = p5.save + p5.one_Chena;
            string a = "Квадрат,";
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", a);
        }
        else if (posit == 1 && key1.Key == ConsoleKey.Enter)
        {
            p5.save = p5.save + p5.two_Chena;
            string a = "Круг,";
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", a);
        }
        else if (posit == 2 && key1.Key == ConsoleKey.Enter)
        {
            p5.save = p5.save + p5.three_Chena;
            string a = "Треугольник,";
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", a);
        }
        Console.Clear();
        forma();
        Console.SetCursorPosition(0, posit);
        Console.WriteLine(p5.strela);
    }
    while (true);
}
static void strela_razmer()
{
    Class p5 = new Class();
    p5.strela = "->";
    int posit = 0;
    Console.Clear();
    razmer();
    Console.SetCursorPosition(0, posit);
    Console.WriteLine(p5.strela);
    do
    {
        ConsoleKeyInfo key1 = Console.ReadKey();
        if (key1.Key == ConsoleKey.UpArrow)
        {
            posit--;
        }
        else if (key1.Key == ConsoleKey.DownArrow)
        {
            posit++;
        }
        else if (key1.Key == ConsoleKey.Backspace)
        {
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", p5.add + p5.save);
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", ";");
            strela_Nachalo();
        }
        else if (posit == 0 && key1.Key == ConsoleKey.Enter)
        {
            p5.save = p5.save + p5.one_Chena;
            string a = "Маленький,";
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", a);
        }
        else if (posit == 1 && key1.Key == ConsoleKey.Enter)
        {
            p5.save = p5.save + p5.two_Chena;
            string a = "Средний,";
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", a);
        }
        else if (posit == 2 && key1.Key == ConsoleKey.Enter)
        {
            p5.save = p5.save + p5.three_Chena;
            string a = "Большой,";
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", a);
        }
        Console.Clear();
        razmer();
        Console.SetCursorPosition(0, posit);
        Console.WriteLine(p5.strela);
    }
    while (true);
}
static void strela_Nachalo()
{
    Class p5 = new Class();
    p5.strela = "->";
    int posit = 0;
    Console.Clear();
    nachalo();
    Console.SetCursorPosition(0, posit);
    Console.WriteLine(p5.strela);
    do
    {
        ConsoleKeyInfo key = Console.ReadKey();
        if (key.Key == ConsoleKey.UpArrow)
        {
            posit--;
        }
        if (key.Key == ConsoleKey.DownArrow)
        {
            posit++;
        }
        if (posit == 0 && key.Key == ConsoleKey.Enter)
        {
            strela_forma();
        }
        if (posit == 1 && key.Key == ConsoleKey.Enter)
        {
            strela_vkus();
        }
        if (posit == 2 && key.Key == ConsoleKey.Enter)
        {
            strela_razmer();
        }
        if (posit == 3 && key.Key == ConsoleKey.Enter)
        {
            strela_kollichestvo();
        }
        if (posit == 4 && key.Key == ConsoleKey.Enter)
        {
            strela_glazury();
        }
        if (posit == 5 && key.Key == ConsoleKey.Enter)
        {
            strela_Dekor();
        }
        if (key.Key == ConsoleKey.Escape)
        {
            File.AppendAllText("C:\\Users\\nikol\\Desktop\\myfile.txt", "(Конец заказа)");
            break;
        }
        else
        {
            Console.Clear();
            nachalo();
            Console.SetCursorPosition(0, posit);
            Console.WriteLine(p5.strela);
        }
    }
    while (true);
    Main();
}
