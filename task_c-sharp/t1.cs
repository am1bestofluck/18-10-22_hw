using static System.Console;
class input_flow
{
    List<int> answers;
    
    public static void todo()
    {
        WriteLine("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
    }
    protected dynamic  lock_input()
    {
        int[] output= new int[this.answers.Count];
        return output;
    }
    void read_data_by_todo(int[] coll_i)
    {
        int vocal_expression=0;
        foreach (int walk in coll_i)
        {
            bool  step=walk>0? vocal_expression++: vocal_expression=vocal_expression;
        }
        WriteLine($"На входе: [{string.Join("", "",coll_i)}].");
        WriteLine($"Положительных значений: {vocal_expression}");

    }
    protected dynamic routine()
    {
        Console.CancelKeyPress+=delegate
        {
            int[] all_input_boxed=lock_input(cycle_spin_i:cycle_spin);
            read_data_by_todo(all_input_boxed);
            
        };

        bool cycle_spin=true;
        bool is_valid_input=false;
        int buffer_int=0;
        string buffer_str=string.Empty;
        while (true)
        {
            WriteLine("Пожалуйста введи число, ctrl+c для завершения");
            buffer_str=ReadLine();
            is_valid_input=decimal.TryParse(buffer_str,out buffer_int);
            if (is_valid_input)
            {
                this.answers.Add(buffer_int);
            }
        

        } 
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