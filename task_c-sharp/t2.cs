using static System.Console;

class linear_equation{
    Dictionary<string,double> coefficients= new Dictionary<string, double>();
    string[] _keys=new string[]{"k1","k2","m1","m2"};
    public static void todo()
    {
        WriteLine(@"Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y=k1*x+b1,y=k2*x+b2.  
*значения b1, k1, b2 и k2 задаются пользователем.");
    }

    public  linear_equation(double? k1_i=null,double? k2_i=null, double? m1_i=null, double? m2_i=null)
    {
        
        if (k1_i!=null)
        {
            coefficients.Add(_keys[0],k1_i.Value);
        }
        else
        {
            WriteLine("Для системы уравнений k1*x+m1=k2*x+m2:");
            coefficients.Add(_keys[0],gather_input(_keys[0]));
        }
        if (k2_i!=null)
        {
        coefficients.Add(_keys[1],k2_i.Value);
        }
        else
        {
            coefficients.Add(_keys[1],gather_input(_keys[1]));
        }
        if (m1_i!=null)
        {
            coefficients.Add(_keys[2],m1_i.Value);
        }
        else 
        {
            coefficients.Add(_keys[2],gather_input(_keys[2]));
        }
        if (m2_i!=null)
        {
            coefficients.Add(_keys[3],m2_i.Value);
        }
        else
        {
            coefficients.Add(_keys[3],gather_input(_keys[3]));
        }
    }
    double gather_input(string key_arg)//наследовать передумал, потому что класс из первого тз заточен на то чтобы принять условно любое количество чисел, а потом вообще ужал в одну функцию 
    {
    bool is_valid_input=false;
    double buffer_double=0;
    string buffer_str=string.Empty;
    while (is_valid_input==false)
    {
        WriteLine($"Пожалуйста введи {key_arg}");
        buffer_str=ReadLine()!;
        is_valid_input=double.TryParse(buffer_str,out buffer_double);
    }
    return buffer_double;
    }
    private dynamic solution(double k1_i, double k2_i,double m1_i, double m2_i)//читал что-то про чистые функции и читаемость кода. Может это и правильно, что
    //функция явно принимает то с чем будет работать.
    {
        double[]? output = new double[2];
        // decimal sup_val_x,sup_val_y;
    //         Предрасчётная часть:
    // k1==k2? > дальше не считаем ;
    if (k1_i==k2_i)
    {
        output= null;
        
        return output!;
    }
    // m1==m2? > даём просто ответ 0,m //ну потому что f1(x)=<k0*0>0+1 и f2(x)=<k1*0>+1 => x=0,y=1
    if (m1_i==m2_i)
    {
        output[0]=0;
        output[1]=m1_i;
        return output;
    }
    // Для других сценариев:
    output[0]=(-m1_i+m2_i)/(k1_i-k2_i);
    output[1]=k1_i*output[0]+m1_i;
    return output;
    // условно уравниваем обе функции
    // неизвестные переменные в одну сторону, значения в другую. знаки при переносе меняем полярно
    // дальше математика второй класс, даёт нам координату пересечения на ox
    // чтобы получить координату пересечения на oy решаем одно из уравнений с обнаруженным иксом
    // ураура
    }
    public dynamic report()
    {
        string description=($"Графики функций f(x1)={this.coefficients[_keys[0]]}x+{this.coefficients[_keys[2]]} и f(x2)={this.coefficients[_keys[1]]}x+{this.coefficients[_keys[3]]} ");
        double[] output_main=solution( k1_i:this.coefficients[_keys[0]],
                                    k2_i:this.coefficients[_keys[1]],
                                    m1_i:this.coefficients[_keys[2]],
                                    m2_i:this.coefficients[_keys[3]]    );
        if (output_main==null)
        {
            WriteLine(description +"параллельны.");
        }
        else
        {
        string answer_str=string.Join(", ",output_main);
        WriteLine(description+$"пересекаются в точке ({answer_str}).");
        
        }
        return null!;
    }
}
