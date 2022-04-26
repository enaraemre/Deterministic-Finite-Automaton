using System;
namespace DFA
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int at = line.IndexOf('@');
            bool stillcorrect = true;
            if (at == -1 && stillcorrect==true)
            {
                Console.WriteLine("There is no @ in the e-mail ");
                stillcorrect = false;

            }
            else if (at == 0 && stillcorrect == true)
            {
                Console.WriteLine("@ cannot be at the beginning");
                stillcorrect = false;
            }
            else
            {
                string line1 = line.Substring(0, at);
                string line2 = line.Substring(at + 1);
                char[] chars1 = line1.ToCharArray();
                int i = 0;
                foreach (char x in chars1)
                {   
                    if(i==0 && x>= 48 && x <= 57 && stillcorrect==true)
                    {
                        Console.WriteLine("e-mail cannot start with a number");
                        stillcorrect = false;
                        break;
                    }
                    
                    else if (x >= 48 && x <= 57 || x == 95 || x >= 97 && x <= 122 && stillcorrect == true)
                    {
                        continue;
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("can contain small letters (a-z), digits (0-9) and underscore (_); before @");
                        stillcorrect = false;
                        break;
                    }
                }
                int dot = line2.IndexOf('.');
                
                if (dot==-1 && stillcorrect == true)
                {
                    Console.WriteLine("there must be . in the e=mail");
                    stillcorrect = false;
                }
                else if (dot == 0 && stillcorrect == true)
                {
                    Console.WriteLine(". cannot be after @");
                    stillcorrect = false;
                }
                else
                {
                    string subs2 = line2.Substring(dot + 1);
                    string subs1 = line2.Substring(0, dot);
                    char[] chars2 = subs1.ToCharArray();
                    foreach (char x in chars2)
                    {
                        if (x == 95 || x >= 97 || x <= 122 || x >= 65 || x <= 90 && stillcorrect == true)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("can contain digits (0-9) and letters (a-z;A-Z) after @");
                            stillcorrect = false;
                            break;
                        }
                    }
                    if (subs2 == "eu" && stillcorrect == true)
                    {
                        Console.WriteLine("e-mail is correct");
                    }
                    else if (subs2 == "pl" && stillcorrect == true)
                    {
                        Console.WriteLine("e-mail is correct");
                    }
                    else if(stillcorrect==true)
                    {
                        Console.WriteLine("the end of the e-mail must be eu or pl");
                        stillcorrect = false;
                    }
                }
            }
        }
    }
}
