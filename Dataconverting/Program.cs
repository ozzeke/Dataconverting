using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataconverting
{
    class Program
    {
        static void Main(string[] args)
        {

            //Love u babes xx

            //het tonen van een .parse
            int number1, number2, sum;

            Console.WriteLine("Please insert first number: "); //de gegeven input (bv 3) wordt hier geparts van string --> int
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please insert second number: "); //de gegeven input (bv 3) wordt hier geparts van string --> int
            number2 = int.Parse(Console.ReadLine());

            //som van de 2 numbers

            sum = number1 + number2;
            Console.WriteLine($"The sum of number one and two is: {sum}"); //som wordt weergeven als int

            Console.ReadKey();

            //--------------------------------------------------------------

            //methodes Casten

            short number3 = 10; //2 datatypes van het type short.
            short number4 = 20;

            short sum2 = (short)(number3 + number4); //gebruik gemaakt van de pars methode, die gebeurde aan de (short)
                                                     // net voor (num3 + num4), als je dit niet doet loop je op een error
                                                     //want de uitkomst van de 2 getallen is een int, dus je toont aan
                                                     // dat je de int parst naar een byte

            Console.WriteLine($"sum2 equals: {sum2} ");

            Console.ReadKey();

            //----------------------------------------------------------------

            //ToString methode

            //als je van een bv: Int naar een strig wil gaan ga je alsvolgt tewerk

            int number5 = 12;

            number5.ToString(); //wat hier gebeurt is eigenlijk van formaat int --> string gaan, dus op shcerm komt nu een string

            Console.WriteLine($"Output directs: {number5} ");

            Console.ReadKey();


            //----------------------------------------------------------------

            //last but not least, de " .Convert.To "


            byte glenns;
            Console.WriteLine("please fill in glenns age: ");  //de input die de user gaat geven is dus eigenlijk een string
            glenns = Convert.ToByte(Console.ReadLine());       //want het wordt getypt, dus we "converten die TO" Byte, zodat
                                                               //we glenn zijn leeftijd als een byte kunne gebruiken

            Console.WriteLine(glenns + 10);                   //aantonen dat het dataype nu effectief een int is want de 
                                                              //output is dus nu (input + 10)


            //je kan ook een string gwn converten maar dat is eigelijk allen voor deze te koppelen een uw datatype als je   
            //met meerdere strings werkt


        }
    }
}
