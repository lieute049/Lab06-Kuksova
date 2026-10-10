using System;

class program
{
    static void main()
    { 
        //1.1
        //for (int i= 10; i >= 1; i--)
        //{
        //    console.writeline(i);
        //}
        //1.2
        //for (int i= 2; i <= 50; i+=2)
        //{
        //    console.writeline(i);
        //}
        //
        // int sum3 = 0;
        // int count7 = 0;

        // for (int i= 1; i <= 100; i++)
        // {
        //     if (i % 3 == 0) sum3 += i;
        //     if (i % 7 == 0) count7++;
        // }
        // console.writeline($"сумма кратных 3: {sum3}");
        // console.writeline($"Колво кратных 7: {count7}")
        //3
    //     int p = 0;
    //     int n = 0;
    //     console.writeline("input number (0-stop):");
    //     int num = convert.toint32(console.readline());
    //     while (num != 0 ) p++;
    //     if (num > 0)
    // {
    //     p++;
    // }
    // else
    // {
    //     n++;
    // }
    //     num = convert.toint32(console. readline());
    //}
    // console.writeline($"положительные: {p}");
    // console.writeline($"отрицаьельные : {n}");
// //4
//         bool ok = false;
//         for (int i = 1; i <= 3; i++)
//         {
//             console.writeline("password: ");
//             if (console.readline() == "qwerty") {ok = true; break;}
//         }
//         if (ok) console.writeline("mojno");
//         else console.writeline("nelza");
//     }
// //5
// int n = convert.toint32(console.readline());
// for (int i = 1; i<= 10; i++)
//     console.writeline($"{n} x {i} = {n * i}")
//6
// for (int i = 1; i <= 30; i++)
// {
//     if (i % 3 ==0) contiune;
//     if (i % 10 == 0 && i > 20) break;
//     console.writeline(i);
// }
// guess number
// int s = 42, guess;
// bool win = false;
// for (int i = 1; i <= 5; i++)
// {
//     console.write($"popitka {i}:")
//     guess = convert.toint32(console.readline());
//     if (guess == s) {console.writeline($"win popitki {i}"}; win = true; break;}
//     console.writeline(guess < secret ? "bolshe" : "menshe");
// }
// if (!win) console.writeline($"u lose number is  {s}");

int n = convert.toint32(console.readline());
int s = 0, count = 0
while (n > 0)
{
    s += n % 10;
    n /= 10;
    count++;
}
console.writeline($"summa: {s}, number: {c}")''
}
