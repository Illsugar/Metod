using System;

class Program
{
    static void Main(string[] args)
    {
        Complex complex1;
        complex1.re = 1;
        complex1.im = 1;

        Complex complex2;
        complex2.re = 2;
        complex2.im = 2;

        Console.WriteLine("Выбор операции: \n1 - сложение \n2 - умножение \n3 - вычистание\n");
        int operation = int.Parse(Console.ReadLine());

        switch (operation)
        {
            case 1:
                Complex result = complex1.Plus(complex2); //вызов метода сложения 
                Console.WriteLine(result.ToString()); // вывод сложения
                break;
            case 2:
                result = complex1.Multi(complex2);  //вызов метода умножения
                Console.WriteLine(result.ToString()); //вывод умножения
                break;
            case 3:
                result = complex1.Minus(complex2); //вызов метода вычитания
                Console.WriteLine(result.ToString()); //вывод вычитания
                break;

        }
        /*Complex result = complex1.Plus(complex2); 
        Console.WriteLine(result.ToString()); // вывод сложения
        result = complex1.Multi(complex2);
        Console.WriteLine(result.ToString()); //вывод умножения
        result = complex1.Minus(complex2);
        Console.WriteLine(result.ToString()); //вывод вычитания*/
    }
}

struct Complex
{
    public double im;
    public double re;
    
    //Сложение комплексных чисел
    public Complex Plus(Complex x) 
    {
        Complex y;
        y.im = im + x.im;
        y.re = re + x.re;
        return y;
    }

    //Перемножение комплексных чисел
    public Complex Multi(Complex x)
    {
        Complex y;
        y.im = re * x.im + im * x.re;
        y.re = re * x.re - im * x.im;
        return y;
    }

    //Вычистание комплексных чисел
    public Complex Minus(Complex x)
    {
        Complex y;
        y.im = im - x.im;
        y.re = re - x.re;
        return y;
    }

    public string ToString()
    {
        return re + "+" + im + "i";
    }
}