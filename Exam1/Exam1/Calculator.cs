using System.Timers;

namespace Exam1;

public class Calculator
{
    public readonly List<char> operators = [];
    public readonly List<double> values = [];

    private void EnterNumber(double num)
    {
        values.Add(num);
    }

    private void EnterOperator(char oper)
    {
        operators.Add(oper);
    }

    public void Process()
    {
        var exit = true;
        
        this.values.Add(Reader.ReadNumber());
        while (exit)
        {
            var oper = Reader.ReadOperator();
            if (oper == '0')
            {
                break;
            }
            else
            {
                this.EnterOperator(oper);
                this.EnterNumber(Reader.ReadNumber());
            }
        }
        this.ShowExpression();
        this.Evaluate();
    }

    private void ShowExpression()
    {
        string expression = "";
        for (var i = 0; i < operators.Count; i++)
        {
            expression += values[i].ToString();
            expression += operators[i].ToString();
        }
        expression += values[values.Count - 1].ToString();
        Console.WriteLine("Expresion: " + expression);
    }

    private void Evaluate()
    {
        var index = 0;
        while (index < operators.Count)
        {
            if (operators[index] == '/' || operators[index] == '*')
            {
                values[index] = Calculate(operators[index], values[index], values[index + 1]);
                values.RemoveAt(index + 1);
                operators.RemoveAt(index);
            }
            else
            {
                index++;
            }
        }

        while (operators.Count != 0)
        {
            values[0] = Calculate(operators[0], values[0], values[1]);
            values.RemoveAt(1);
            operators.RemoveAt(0);
        }

        Console.WriteLine("El resultado del calculo es: " + values[0]);
    }

    private static double Calculate(char oper, double a, double b) => oper switch
    {
        '+' => a + b,
        '-' => a - b,
        '*' => a * b,
        '/' => b != 0 ? a / b : throw new ArgumentException("Division entre cero"),
        _ => throw new ArgumentException("El operador utilizado no está permitido")
    };
}
public class Reader
{
    public static double ReadNumber()
    {
        Console.WriteLine("Ingrese un numero para agregar a la expresión");
        string input = Console.ReadLine()!;
        double number;
        while (!double.TryParse(input, out number))
        {
            Console.WriteLine("El valor no tiene el formato esperado, ingrese un número");
            input = Console.ReadLine()!;
        }
        return number;
    }

    public static char ReadOperator()
    {
        Console.WriteLine("Ingrese un nuevo operador o enter para comenzar a calcular");
        string input = Console.ReadLine()!;
        if (input == "")
        {
            return '0';
        }
        
        char oper;
        List<char> validOperators = [ '+', '-', '*', '/' ];
        while (!char.TryParse(input, out oper) || !validOperators.Contains(oper))
        {
            Console.WriteLine("El valor no tiene el formato esperado, ingrese una operación de las siguientes (+,-,*,/)");
            input = Console.ReadLine()!;
        }
        return oper;
    }
}