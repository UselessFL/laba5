namespace calculator{
    internal class Programm {
        static void Main(string[] args){
            Console.Writeline(a);
            double a = double.Parse(Console.Readline());
            Console.Writeline(b);
            double b = double.Parse(Console.Readline());
            Console.Writeline(znak?);
            string c = Console.Readline();
            c = Char.Parse(c);
            if ( c== '+'){
                Console.Writeline(a+b);
            }
            else if(c == '-'){
                Console.Writeline(a-b);
            }
           else if(c == '*'){
                Console.Writeline(a*b);
            }
            else if(c == '/'){
                Console.Writeline(a/b);
            }
            else if(c == '%'){
                Console.Writeline(a%b);
            }
            else{
                Console.Writeline('ERROR');
            }
        }
    }
        
}
    