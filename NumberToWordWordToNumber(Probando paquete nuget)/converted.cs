using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using NumberToWordWordToNumber_Probando_paquete_nuget_;
using NumberToWors_WordToNumber;

namespace NumberToWordWordToNumber
{
    public class converted
    {

        static public void Main(string[] args)
        {

            Console.WriteLine("Select");
            Console.WriteLine("1. Number To Word");
            Console.WriteLine("2. Word To Number");

            int aux;
            if (!int.TryParse(Console.ReadLine(), out aux) || aux < 1 || aux > 2)
            {
                Console.WriteLine("Number invalid");
            }

            if (aux == 1)
            {
                Console.WriteLine("Write the number (1-999999999): ");
                if (!int.TryParse(Console.ReadLine(), out aux) || aux < 1 || aux > 999999999)
                {
                    Console.WriteLine("Number invalid");
                }

                converted converted = new converted();

                INPUT NEW = new INPUT(aux);

                OUTPUT exit = new OUTPUT(converted.convertn(NEW));

                string result = exit.GetResult();


                Console.WriteLine(result);

            }
            else if (aux == 2)
            {
                converted converted = new converted();
                Console.WriteLine("Write the word: ");
                string? aux1 = Console.ReadLine();

                INPUT NEW = new INPUT(aux1);

                OUTPUT exit = new OUTPUT(converted.convertw(NEW));

                dynamic result = exit.GetResult();


                Console.WriteLine(result);

            }

        }

        public string convertn(INPUT n)
        {
            converter converter = new converter();
            Input input = new Input(n.value);
            Output output = converter.Result(input);

            string result = output.GetResult();
            return result;
        }

        public dynamic convertw(INPUT n)
        {
            converter converter = new converter();
            InputWN inputwn = new InputWN(n.value);
            Output outputwn = converter.ResultWN(inputwn);


            dynamic result = outputwn.GetResult();
            return result;
        }



    }
}