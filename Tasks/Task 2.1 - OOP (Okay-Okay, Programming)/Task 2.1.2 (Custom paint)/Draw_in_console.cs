using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2__Custom_paint_
{
    public class Draw_in_console
    {
        static string name = null;
        static bool flag = false;
        static Circle circle = new Circle();
        static Ring ring = new Ring();
        static Square square = new Square();
        static Rectangle rectangle = new Rectangle();
        static Triangle triangle = new Triangle();

        public static void Draw()
        {
            if (name == null)
            {
                Console.Write("Введите Ваше имя: ");
                name = Console.ReadLine();
            }
            Console.WriteLine($"{name}, выберите действие:");
            if (flag == !true)
            {
                Console.Write("\tДобавить фигуру - 1\n\tСменить пользователя - 4\n\tВыход - 5\nВаше число - ");
            }
            else
            {
                Console.Write("\tДобавить фигуру - 1\n\tВывести все добавленные фигуры - 2\n\tОчистить холст - 3" +
                    "\n\tСменить пользователя - 4\n\tВыход - 5\nВаше число - ");
            }
            var _first_input = Console.ReadLine();
            if (int.TryParse(_first_input, out var first_input) == !true)
            {
                Console.WriteLine($"{name}, вы ввели неверные данные!");
            }
            else
            {
                switch (first_input)
                {
                    case 1:
                        Console.WriteLine($"\n{name}, выберите тип фигуры:");
                        Console.Write("\tКруг - 1\n\tКольцо - 2\n\tКвадрат - 3\n\tПрямоугольник - 4\n\tТреугольник - 5\nВаше число - ");
                        var _second_input = Console.ReadLine();
                        if (int.TryParse(_second_input, out var second_input) == !true)
                        {
                            Console.WriteLine($"\n{name}, вы ввели неверные данные!");
                            break;
                        }
                        else
                        {
                            switch (second_input)
                            {
                                case 1:
                                    Console.WriteLine($"\n{name}, введите параметры фигуры круг:");
                                    Console.Write("\tКоордината центра по оси x = ");
                                    var _first_center_x = Console.ReadLine();
                                    Console.Write("\tКоордината центра по оси y = ");
                                    var _first_center_y = Console.ReadLine();
                                    if (int.TryParse(_first_center_x, out var first_center_x) == !true || int.TryParse(_first_center_y, out var first_center_y) == !true)
                                    {
                                        Console.WriteLine($"\n{name}, вы ввели неверные данные!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Write("\tРадиус круга = ");
                                        var _radius = Console.ReadLine();
                                        if (int.TryParse(_radius, out var radius) == !true || radius <= 0)
                                        {
                                            Console.WriteLine($"\n{name}, вы ввели неверные данные!");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nФигура круг создана! Вот её характеристики: ");
                                            circle = new Circle(first_center_x, first_center_y, radius);
                                            circle.GetInfo();
                                            flag = true;
                                            Draw();
                                            break;
                                        }
                                    }
                                case 2:
                                    Console.WriteLine($"\n{name}, введите параметры фигуры кольцо:");
                                    Console.Write("\tКоордината центра по оси x = ");
                                    var _second_center_x = Console.ReadLine();
                                    Console.Write("\tКоордината центра по оси y = ");
                                    var _second_center_y = Console.ReadLine();
                                    if (int.TryParse(_second_center_x, out var second_center_x) == !true || int.TryParse(_second_center_y, out var second_center_y) == !true)
                                    {
                                        Console.WriteLine($"\n{name}, вы ввели неверные данные!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Write("\tВнутренний радиус кольца = ");
                                        var _inner_radius = Console.ReadLine();
                                        Console.Write("\tВнешний радиус кольца = ");
                                        var _outer_radius = Console.ReadLine();
                                        if (int.TryParse(_inner_radius, out var inner_radius) == !true || int.TryParse(_outer_radius, out var outer_radius) == !true 
                                            || inner_radius < 0 || outer_radius < 0 || inner_radius >= outer_radius)
                                        {
                                            Console.WriteLine($"\n{name}, вы ввели неверные данные!");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nФигура кольцо создана! Вот её характеристики: ");
                                            ring = new Ring(second_center_x, second_center_y, inner_radius, outer_radius);
                                            ring.GetInfo();
                                            flag = true;
                                            Draw();
                                            break;
                                        }
                                    }
                                case 3:
                                    Console.WriteLine($"\n{name}, введите параметры фигуры квадрат:");
                                    Console.Write("\tВведите сторону = ");
                                    var _side = Console.ReadLine();
                                    if (int.TryParse(_side, out var side) == !true)
                                    {
                                        Console.WriteLine($"\n{name}, вы ввели неверные данные!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nФигура квадрат создана! Вот её характеристики: ");
                                        square = new Square(side);
                                        square.GetInfo();
                                        flag = true;
                                        Draw();
                                        break;
                                    }
                                case 4:
                                    Console.WriteLine($"\n{name}, введите параметры фигуры прямоугольник:");
                                    Console.Write("\tВведите первую сторону = ");
                                    var _first_side = Console.ReadLine();
                                    Console.Write("\tВведите вторую сторону = ");
                                    var _second_side = Console.ReadLine();
                                    if (int.TryParse(_first_side, out var first_side) == !true || int.TryParse(_second_side, out var second_side) == !true )
                                    {
                                        Console.WriteLine($"\n{name}, вы ввели неверные данные!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nФигура прямоугольник создана! Вот её характеристики: ");
                                        rectangle = new Rectangle(first_side, second_side);
                                        rectangle.GetInfo();
                                        flag = true;
                                        Draw();
                                        break;
                                    }
                                case 5:
                                    Console.WriteLine($"\n{name}, введите параметры фигуры треугольник:");
                                    Console.Write("\tВведите первую сторону = ");
                                    var _first_side_ = Console.ReadLine();
                                    Console.Write("\tВведите вторую сторону = ");
                                    var _second_side_ = Console.ReadLine();
                                    Console.Write("\tВведите третью сторону = ");
                                    var _third_side = Console.ReadLine();
                                    if (int.TryParse(_first_side_, out var first_side_) == !true || int.TryParse(_second_side_, out var second_side_) == !true
                                        || int.TryParse(_third_side, out var third_side) == !true)
                                    {
                                        Console.WriteLine($"\n{name}, вы ввели неверные данные!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nФигура треугольник создана! Вот её характеристики: ");
                                        triangle = new Triangle(first_side_, second_side_, third_side);
                                        triangle.GetInfo();
                                        flag = true;
                                        Draw();
                                        break;
                                    }
                                default:
                                    Console.WriteLine($"\n{name}, такое число отсутствует.");
                                    break;
                            }
                            break;
                        }
                    case 2:
                        if (flag == !true)
                        {
                            Console.WriteLine($"\n{name}, такое число отсутствует.");
                            break;
                        }
                        else
                        {
                            circle.GetInfo();
                            ring.GetInfo();
                            square.GetInfo();
                            rectangle.GetInfo();
                            triangle.GetInfo();
                            break;
                        }
                    case 3:
                        if (flag == !true)
                        {
                            Console.WriteLine($"\n{name}, такое число отсутствует.");
                            break;
                        }
                        else
                        {
                            flag = false;
                            Console.Clear();
                            Draw();
                            break;
                        }
                    case 4:
                        Console.Clear();
                        name = null;
                        flag = false;
                        Draw();
                        break;
                    case 5:
                        Console.WriteLine($"\n{name}, досвидания!");
                        break;
                    default:
                        Console.WriteLine($"\n{name}, такое число отсутствует.");
                        break;
                }
            }
        }
    }
}
