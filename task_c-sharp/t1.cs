using static System.Console;
class input_flow
{
    List<decimal> answers= new List<decimal>();
    
    public static void todo()
    {
        WriteLine("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
    }
    protected dynamic  lock_input( List<decimal> _answers)
    {
        decimal[] output= new decimal[this.answers.Count];
        for (int walk = 0; walk < _answers.Count; walk++)
        {
            output[walk]=_answers[walk];
        }
        return output;
    }
bool stop_the_cycle(bool inc_spin)
{
    inc_spin=false;
    return inc_spin;
}
    void read_data_by_todo(decimal[] coll_i)
    {
        int vocal_expression=0;
        foreach (decimal walk in coll_i)
        {
            if (walk>0) vocal_expression++;
        }
        string tmp=string.Join(", ",coll_i);
        WriteLine($"На входе: [{tmp}].");
        WriteLine($"Положительных значений: {vocal_expression}");

    }
    protected dynamic routine()
    {
        bool spin_the_cycle=true;
        bool is_valid_input=false;
        decimal buffer_dcm=0;
        string buffer_str=string.Empty;
        Console.CancelKeyPress+=delegate
        {
            spin_the_cycle=stop_the_cycle(spin_the_cycle);
            decimal[] all_input_boxed=lock_input(_answers: this.answers);
            read_data_by_todo(all_input_boxed);
            
        };

        WriteLine("Пожалуйста вводи числа, ctrl+c для завершения");
        while (spin_the_cycle)
        {
            buffer_str=ReadLine();
            is_valid_input=decimal.TryParse(buffer_str,out buffer_dcm);
            if (is_valid_input)
            {
                this.answers.Add(buffer_dcm);
            }
        

        }
        return null; 
    }
    public input_flow()
    {
        this.routine();
    }
}
// While true  

// Принимаем данные  

// если численное  

// добавляем в СПисок  

// Если больше нуля накидываем на счетчик  

// Если kbinterrupt прекращаем принимать ввод и отдаем вывод  

// список отдаем, счетчик войдовый  

// https://stackoverflow.com/questions/177856/how-do-i-trap-ctrlc-sigint-in-a-c-sharp-console-app

// List<string> people = new List<string>();

// void Add(T item): добавление нового элемента в список