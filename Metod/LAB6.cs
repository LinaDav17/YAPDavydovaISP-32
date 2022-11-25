using System;
using System.Collections.Generic;
using System.Linq;

public class MainClass
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        VasyaStyle(number);
    }
    public static void VasyaStyle(int number)
    {
        int multiplication;
        for (int i = 1, a = 0, b = 0, c = 0; i < number; i++){
            bool result = false;
            multiplication = i.ToString().Length;
            for (int j = 0; j < multiplication; j++){
                if (i.ToString()[j] == '2' || i.ToString()[j] == '3' || i.ToString()[j] == '7'){
                    result = true;
                    a = i;
                    continue;
                }
                else{
                    result = false;
                    break;
                }
            }
            if (result == true){
                multiplication = i.ToString().Length;
                for (int j = 0; j < multiplication; j++){
                    if (i.ToString()[j] == '2' || i.ToString()[j] == '3' || i.ToString()[j] == '7'){
                        result = true;
                        a = i;
                        continue;
                    }
                    else{
                        result = false;
                        break;
                    }
                }
                if (result == true){
                    for (int q = 1; q < number; q++)
                    {
                        multiplication = q.ToString().Length;
                        for (int j = 0; j < multiplication; j++){
                            if (q.ToString()[j] == '2' || q.ToString()[j] == '3' || q.ToString()[j] == '7'){
                                result = true;
                                b = q;
                                continue;
                            }
                            else{
                                result = false;
                                break;
                            }
                        }
                        c = number - a * b;
                        if (result == true){
                            multiplication = c.ToString().Length;
                            for (int j = 0; j < multiplication; j++){
                                if (c.ToString()[j] == '2' || c.ToString()[j] == '3' || c.ToString()[j] == '7'){
                                    result = true;
                                    continue;
                                }
                                else{
                                    result = false;
                                    break;
                                }
                            }
                            if (result == true && c > 0 && b > a)
                                Console.WriteLine(number + " = " + a + " * " + b + " + " + c);
                        }
                    }
                }
            }
        }
    }
}
