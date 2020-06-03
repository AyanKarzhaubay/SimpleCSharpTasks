/*
using System;
public static class Program
{
    public static void Main()
    {
        int i, j, n, m;
        Console.Write("Jol sani n = ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Bagan sani m = ");
        m = int.Parse(Console.ReadLine());
        int[,] a = new int[n, m];
        int[] g = new int[n];
        Random r = new Random();
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < m; j++)
            {
                a[i, j] = r.Next(-50, 51);
                Console.Write(a[i, j] + "\t");
            }
            g[i] = 0;
            Console.WriteLine();
        }
        Console.WriteLine("\nSipattamalardin bastapki turi:");
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < m; j++)
            {
                if (a[i, j] < 0 && a[i, j] % 2 == 0)
                {
                    g[i] += a[i, j];
                }
            }
            Console.WriteLine("g[" + i + "]" + g[i]);
        }
        int s;
        //kopirshikter adisimen sorttau
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n - 1; j++)
            {
                if (g[j] > g[j + 1])
                {
                    s = g[j];
                    g[j] = g[j + 1];
                    g[j + 1] = s;
                }
            }
        }
        int t;
        //massivti keri ainaldiru
        for (i = 0, j = n - 1; i < j; i++, j--)
        {
            t = g[i];
            g[i] = g[j];
            g[j] = t;
        }
        Console.WriteLine("\nSipattamalardin kemu retimen rettelgen turi:");
        for (i = 0; i < n; i++)
        {
            Console.WriteLine("g[" + i + "]=" + g[i]);
        }
    }
}
*/

/*
using System;
public static class Program
{
    public static void Main()
    {
        //Бүтін санды B[0..5, 0..5] жиымы берілген. Жиымның бас диагоналынан төмен орналасқан 
        //теріс таңбалы элементтерінің элементтерінің санын табыңыздар.
        int i, j;
        int[,] B = new int[6, 6];
        Random r = new Random();

        for (i = 0; i < 6; i++)
        {
            for (j = 0; j < 6; j++)
            {
                B[i, j] = r.Next(-50, 51);
                Console.Write(B[i, j] + "\t");
            }
            Console.WriteLine();
        }
        double n = 0;
        for (i = 0; i < 6; i++)
        {
            for (j = 0; j < 6; j++)
            {
                if (i > j)
                {
                    if (B[i, j] < 0) { n++; }
                }
            }
        }
        Console.WriteLine("Bas diagonaldan tomen ornalaskan teris elementter sani:" + n);
        Console.ReadLine();
    }
}
*/
/*
using System;
public static class Program
{
    public static void Main()
    {
        //Бүтін сандардың 6x5 екіөлшемді жиымы бар. Элементтерінің арифметикалық орта мәні
        //максимал болатын жолдың нөмірін табыңыздар.
        int i, j;
        int[,] a = new int[6, 5];
        Random r = new Random();

        for (i = 0; i < 6; i++)
        {
            for (j = 0; j < 5; j++)
            {
                a[i, j] = r.Next(-50, 51);
                Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine();
        }
        double[] avg = new double[6];
        for (i = 0; i < 6; i++)
        {
            for (j = 0; j < 5; j++)
            {
                avg[i] += a[i, j];
            }
        }
        Console.WriteLine();

        for (i = 0; i < 6; i++)
        {
            avg[i] /= 5;
            Console.WriteLine("avg[" + i + "]=" + avg[i]);
        }

        int max = 0;
        for (i = 0; i < 6; i++)
        {
            if (avg[i] > avg[max]) { max = i; }
        }
        Console.WriteLine("Arifmetikalik ortasi maximal bolatin jol nomeri:" + max);
        Console.ReadLine();
    }
}
*/
/*
using System;
public class Program
{
    public static void Main()
    {
        double x, y, z, t;
        Console.Write("x = ");
        x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        y = double.Parse(Console.ReadLine());
        Console.Write("z = ");
        z = double.Parse(Console.ReadLine());
        t = Math.Max(x * x + y * y, y * y + z * z);
        Console.WriteLine("t = " + t);
        Console.ReadKey();
    }
}
*/
/*
using System;
public class Program
{
    public static void Main()
    {
        int n;
        double a, t = 1, y = 0;
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        Console.Write("a = ");
        a = int.Parse(Console.ReadLine());
        for (int i = 0; i <= n; i++)
        {
            t *= (a + i);
            y += 1 / t;
        }
        Console.WriteLine("y = " + y);
        Console.ReadKey();
    }
}
*/
/*
using System;
public static class Program
{
    public static void Main()
    {

        string str;
        char[] c = { '.', '!', '?' };
        Console.WriteLine("Kez kelgen eki soilem engiziniz:");
        string text = Console.ReadLine();
        string[] sentences = text.Split(c);
        str = sentences[0];
        sentences[0] = sentences[1];
        sentences[1] = str;
        Console.WriteLine("\nEki soilemnin orin auiskandagi kuii:");
        for (int i = 0; i < sentences.Length; i++)
        {
            sentences[i] = String.Concat(sentences[i], ".");
        } 
        text = String.Concat(sentences);
        Console.WriteLine(text);
        Console.ReadLine();
    }
}
*/
/*
using System;
public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Kez kelgen tirkes engiziniz:");
        string text = Console.ReadLine();
        string[] words = text.Split(' ');
        Console.WriteLine("Berilgen soz tirkestin uzindigi: " + text.Length);
        if (text.Length % 3 == 0)
        {
            words[1] = "";
        }
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = String.Concat(words[i], " ");
        }
        text = String.Concat(words);
        Console.WriteLine(text);
        Console.ReadLine();
    }
}
*/

/*
using System;
public static class Program
{
    public static void Main()
    {
        int i, j;
        int[,] x = new int[6, 5];
        Random r = new Random();

        Console.WriteLine("Bastapki matrica:");
        for (i = 0; i < 6; i++)
        {
            for (j = 0; j < 5; j++)
            {
                x[i, j] = r.Next(-20, 21);
                Console.Write(x[i, j] + "\t");
            }
            Console.WriteLine();
        }

        for (i = 0; i < 6; i++)
        {
            for (j = 0; j < 5; j++)
            {
                if (x[i, j] < 5) { x[i, j] = 111; }
            }
        }
        Console.WriteLine("\n5-ten kishi elementterdi 111-ge auistirgandagi matrica:");

        for (i = 0; i < 6; i++)
        {
            for (j = 0; j < 5; j++)
            {
                Console.Write(x[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
*/
/*
using System;
public static class Program
{
    public static void Main()
    {
        int i, j;
        int[,] c = new int[5, 4];
        Random r = new Random();

        Console.WriteLine("Tsehterdin(i) ar bolimshesindegi(j) shikizat sandar kestesi:");
        for (i = 0; i < 5; i++)
        {
            for (j = 0; j < 4; j++)
            {
                c[i, j] = r.Next(20, 80);
                Console.Write(c[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int[] sumc = new int[5];
        for (i = 0; i < 5; i++)
        {
            for (j = 0; j < 4; j++)
            {
                sumc[i] += c[i, j];
            }
            Console.WriteLine(i + "-tsehtin jalpi shikizat sani:" + sumc[i]);
        }

        int minI = 0;
        for (i = 0; i < 5; i++)
        {
            if (sumc[i] < sumc[minI]) { minI = i; }
        }
        Console.WriteLine("Shikizati en az tseh nomeri:" + minI);
        Console.ReadLine();
    }
}
*/
/*
using System;
public static class Program
{
    public static void Main()
    {
        int i, j;
        int[,] c = new int[5, 4];
        Random r = new Random();

        Console.WriteLine("Tsehterdin(i) ar bolimshesindegi(j) shikizat sandar kestesi:");
        for (i = 0; i < 5; i++)
        {
            for (j = 0; j < 4; j++)
            {
                c[i, j] = r.Next(20, 80);
                Console.Write("c[" + i + "," + j + "]=" + c[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int minI = 0, minJ = 0;
        for (i = 0; i < 5; i++)
        {
            for (j = 0; j < 4; j++)
            {
                if (c[i, j] < c[minI, minJ]) { minI = i; minJ = j; }
            }
        }
        Console.WriteLine("Shikizati en tomen tseh nomeri(i):" + minI + ", bolimshe nomeri(j): " + minJ);
        Console.ReadLine();
    }
}
*/
/*
using System;
public class Program
{
    public static void Main()
    {
        int i;
        double[] a = new double[10];
        for (i = 0; i < 10; i++)
        {
            Console.Write(i + 1 + "-san=");
            a[i] = double.Parse(Console.ReadLine());
        }
        for (i = 0; i < 10; i++)
        {
            if (a[i] > 15) { a[i] = 15; }
        }
        Console.WriteLine();
        for (i = 0; i < 10; i++)
        {
            Console.WriteLine(i + 1 + "-san=" + a[i]);
        }
        Console.ReadKey();
    }
}
*/
/*
using System;
public class Program
{
    public static void Main()
    {
        double x, y, z;
        Console.Write("x = ");
        x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        y = double.Parse(Console.ReadLine());
        Console.Write("z = ");
        z = double.Parse(Console.ReadLine());
        if (x > y && x > z) { Console.WriteLine("Ulken san:" + x); }
        else if (y > x && y > z) { Console.WriteLine("Ulken san:" + y); }
        else { Console.WriteLine("Ulken san:" + z); }
        Console.ReadKey();
    }
}
*/
/*
using System;
public class Program
{
    public static void Main()
    {
        int n;
        double y = 0;
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        for (double k = 1; k <= n; k++)
        {
            y += 1 / (k * k * k * k * k);
        }
        Console.WriteLine("y = " + y);
        Console.ReadKey();
    }
}
*/
/*
using System;
public static class Program
{
    public static int Reverse(int n)
    {
        int r = 0;
        while (n > 0)
        {
            r *= 10;
            r += n % 10;
            n /= 10;
        }
        return r;
    }
    public static void Main()
    {
        int n;
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Berilgen sannin cifrlarinin keri bagittasi:" + Reverse(n));
        Console.ReadLine();
    }
}
*/
/*
using System;

public static class Program
{
    public static double Volume(double R, double H)
    {
        return Math.PI * R * R * H;
    }
    public static void Main()
    {
        double R, H;
        Console.Write("R = ");
        R = double.Parse(Console.ReadLine());
        Console.Write("H = ");
        H = double.Parse(Console.ReadLine());
        Console.WriteLine("V = pi*R^2*H = " + Volume(R, H));
        Console.ReadLine();
    }
}
*/
/*
using System;
public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Tolik ati-joninizdi engiziniz(familia, ati, akesinin ati):");
        string text = Console.ReadLine();
        string[] words = text.Split(' ');
        Console.WriteLine("\nSizdin teginiz jane kalgan inicialdariniz:");
        Console.WriteLine(words[0] + " " + words[1].Substring(0, 1) + ". " + words[2].Substring(0, 1) + ".");
        Console.ReadLine();
    }
}
*/
/*
using System;
public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Text engiz:");
        string text = Console.ReadLine();
        string[] words = text.Split(' ');
        char[] letters = words[(words.Length - 1) / 2].ToCharArray();
        Console.WriteLine("\nBerilgen soz tirkestin ortasindagi sozdin kerisinshe zhazilui:");
        for (int i = letters.Length - 1; i >= 0; i--)
        {
            Console.Write(letters[i]);
        }
        Console.ReadLine();
    }
}
*/
/*
using System;
public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Text engiz:");
        string text = Console.ReadLine();
        string[] words = text.Split(' ');
        char[] letters1W = words[0].ToCharArray();
        char[] letters2W = words[1].ToCharArray();
        Console.WriteLine("\n1,2-sozderdin keri retpen zhazilui:");
        for (int i = letters1W.Length - 1; i >= 0; i--)
        {
            Console.Write(letters1W[i]);
        }
        Console.WriteLine();
        for (int i = letters2W.Length - 1; i >= 0; i--)
        {
            Console.Write(letters2W[i]);
        }
        Console.ReadLine();
    }
}
*/
/*
using System;
public static class Program
{
    public static void Main()
    {
        char[] c = { '.', '!', '?' };
        Console.WriteLine("Text engiz:");
        string text = Console.ReadLine();
        string[] sentences = text.Split(c);
        char[] letters2S = sentences[1].ToCharArray();
        int k = 0;
        for (int i = 0; i < letters2S.Length; i++)
        {
            if (letters2S[i] == 'E' || letters2S[i] == 'e') { k++; }
        }
        Console.WriteLine("\nE arpinin sani 2-soilemde: " + k);
        Console.ReadLine();
    }
}
*/

/*
using System;
public class Program
{
    public static void Main(string[] args)
    {
        //12
        int l = 90;
        int n1, n2;

        Console.Write("Komanda beriniz(1, 2, 3):\nn = ");
        n1 = int.Parse(Console.ReadLine());
        if (n1 == 1) { l += 90; }
        else if (n1 == 2) { l -= 90; }
        else if (n1 == 3) { l += 180; }

        Console.Write("Komanda beriniz(1, 2, 3):\nn = ");
        n2 = int.Parse(Console.ReadLine());
        if (n2 == 1) { l += 90; }
        else if (n2 == 2) { l -= 90; }
        else if (n2 == 3) { l += 180; }

        if (l == 90 || l == 450) { Console.WriteLine("Soltustik"); }
        else if (l == 180) { Console.WriteLine("Ontustik"); }
        else if (l == 270 || l == -90) { Console.WriteLine("Batis"); }
        else if (l == 360 || l == 0) { Console.WriteLine("Shigis"); }

        Console.ReadKey();
    }
}
*/
/*
using System;
public class Program
{
    public static void Main(string[] args)
    {
        //1
        double x, y, z, a, b;
        Console.Write("x = ");
        x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        y = double.Parse(Console.ReadLine());
        Console.Write("z = ");
        z = double.Parse(Console.ReadLine());

        a = (Math.Sqrt(Math.Abs(4 * x - 2)) - Math.Sqrt(Math.Abs(6 * y))) / (1 + (x * x / 2) + (y * y / 2));
        b = x * (Math.Asin(z) + Math.Exp(-x - 2));

        Console.WriteLine($"a={a}, b={b}");

        Console.ReadKey();
    }
}
*/
/*
using System;
public class Program
{
    public static void Main(string[] args)
    {
        //2

        double x, y;
        Console.Write("x = ");
        x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        y = double.Parse(Console.ReadLine());
        double t;

        if (x < y) { t = x; x = (x + y) / 2; y = 2 * t * y; }
        else if (x > y) { t = y; y = (x + y) / 2; x = 2 * x * t; }
        Console.WriteLine($"x = {x}, y = {y}");
        Console.ReadKey();
    }
}
*/
/*
using System;
public class Program
{
    public static void Main(string[] args)
    {
        //3
        int n = 0;
        for (int i = 1; i <= 200; i++)
        {
            if (i % 20 == 0) { n++; }
        }
        Console.WriteLine("n = " + n);

        Console.ReadKey();
    }
}
*/
/*
using System;
public class Program
{
    public static int Factorial(int n)
    {
        int f = 2;
        for (int i = 3; i <= n; i++)
        {
            f *= i;
        }
        return f;
    }
    public static void Main(string[] args)
    {
        //4

        int n;
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        double s = 0;
        for (int i = 1; i <= n; i++)
        {
            s += Math.Log10(Factorial(i)) * Math.Exp(-i * Math.Sqrt(i));
        }
        Console.WriteLine("s = " + Math.Round(s, 4));

        Console.ReadKey();
    }
}
*/
/*
using System;
public class Program
{
    public static void Main(string[] args)
    {
        //2
        double a, f;
        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());

        if (a < 0) { f = 1 / a + Math.Log(Math.Abs(a)); }
        else if (a >= 0 && a <= 10) { f = Math.Exp(-a) + Math.Sqrt(a); }
        else { f = a; }
        Console.WriteLine($"f({a})={f}");
        Console.ReadKey();
    }
}
*/
/*
using System;
public class Program
{
    public static void Main(string[] args)
    {
        //2
        double a, f;
        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());

        if (a < 2 && a >= -2) { f = a * a + 4 * a + 5; }
        else if (a < -2) { f = 0; }
        else { f = 1 / (a * a + 4 * a + 5); }
        Console.WriteLine($"f({a})={f}");
        Console.ReadKey();
    }
}
*/
/*
using System;
public class Program
{
    public static void Main(string[] args)
    {
        //2
        double a, f;
        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());

        if (a <= 0) { f = 0; }
        else if (a > 0 && a <= 1) { f = a * a - a; }
        else { f = a * a - Math.Sin(a * a); }
        Console.WriteLine($"f({a})={f}");
        Console.ReadKey();
    }
}
*/
/*
using System;
public class Program
{
    public static void Main(string[] args)
    {
        //3
        int n, y = 2;
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        for (int i = 2; i <= n; i++)
        {
            y = 2 * y;
        }
        Console.WriteLine($"2^{n}={y}");
        Console.ReadKey();
    }
}
*/
/*
using System;
public class Program
{
    public static void Main(string[] args)
    {
        //3
        int n;
        double s = 0;
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        for (int k = 1; k <= n; k++)
        {
            s += 1 / Math.Pow(k, 5);
        }
        Console.WriteLine($"s={s}");
        Console.ReadKey();
    }
}
*/
/*
using System;
public class Program
{
    public static void Main(string[] args)
    {
        //3
        double s = 0;
        for (int i = 1; i <= 50; i++)
        {
            s += 1 / Math.Pow(i, 3);
        }
        Console.WriteLine($"s={s}");
        Console.ReadKey();
    }
}
*/
/*
using System;
public static class Program
{
    public static void Main()
    {
        int n, i;
        Console.Write("n=");
        n = int.Parse(Console.ReadLine());
        double[] a = new double[n];
        Random r = new Random();
        for (i = 0; i < n; i++)
        {
            a[i] = r.Next(-50, 50) + r.NextDouble();
            Console.WriteLine($"a[{i}]={a[i]}");
        }
        Console.WriteLine();

        int maxAbsI = 0;
        for (i = 0; i < n; i++)
        {
            if (Math.Abs(a[i]) > Math.Abs(a[maxAbsI])) { maxAbsI = i; }
        }
        Console.WriteLine("Moduli boinsha en ulken element nomeri:" + maxAbsI);

        int p = 0;
        for (i = 0; i < n; i++)
        {
            if (a[i] > 0) { p = i; break; }
        }
        double s = 0;
        for (i = p + 1; i < n; i++)
        {
            s += a[i];
        }
        Console.WriteLine("Algashki on(+) elementinen kein ornalaskan elementter kosindisi:" + s);

        int lastMinI = n - 1;
        for (i = n - 1; i >= 0; i--)
        {
            if (a[i] < a[lastMinI]) { lastMinI = i; }
        }
        Console.WriteLine("Songi en kishi element orni:" + lastMinI);
    }
}
*/
/*
using System;
public static class Program
{
    public static void Main()
    {
        int i, j;
        int[] a = new int[10];
        Random r = new Random();
        Console.WriteLine("Massivtin bastapki kuyi:");
        for (i = 0; i < 10; i++)
        {
            a[i] = r.Next(-50, 51);
            Console.WriteLine("a[" + i + "]=" + a[i]);
        }
        Console.WriteLine("\nMassivtin kemu retimen rettelgen turi:");
        int s;
        //kopirshikter adisimen sorttau
        for (i = 0; i < 10; i++)
        {
            for (j = 0; j < 10 - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    s = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = s;
                }
            }
        }
        int t;
        //massivti keri ainaldiru
        for (i = 0, j = 10 - 1; i < j; i++, j--)
        {
            t = a[i];
            a[i] = a[j];
            a[j] = t;
        }
        for (i = 0; i < 10; i++)
        {
            Console.WriteLine("a[" + i + "]=" + a[i]);
        }
    }
}
*/
/*
using System;
public static class Program
{
    public static void Main()
    {
        int i, j;
        int[,] a = new int[10, 10];
        Random r = new Random();

        for (i = 0; i < 10; i++)
        {
            for (j = 0; j < 10; j++)
            {
                a[i, j] = r.Next(-50, 51);
                Console.Write($"a[{i},{j}]={a[i, j]} \t");
            }
            Console.WriteLine();
        }
        int[] auxDiag = new int[10];
        for (i = 0; i < 10; i++)
        {
            for (j = 0; j < 10; j++)
            {
                if (i + j == 10 - 1)
                {
                    auxDiag[i] = a[i, j];
                }
            }
        }
        int min = 0;
        for (i = 0; i < 10; i++)
        {
            if (auxDiag[i] < auxDiag[min])
            {
                min = i;
            }
        }
        Console.WriteLine("Kosalki diagonaldin min elementi:" + auxDiag[min]);
        Console.ReadLine();
    }
}
*/
/*
using System;
public static class Program
{
    public static void Main()
    {
        int i, j;
        int[,] a = new int[6, 6];
        Random r = new Random();

        for (i = 0; i < 6; i++)
        {
            for (j = 0; j < 6; j++)
            {
                a[i, j] = r.Next(-50, 51);
                Console.Write($"a[{i},{j}]={a[i, j]} \t");
            }
            Console.WriteLine();
        }
        int n1, n2;
        Console.WriteLine("Kai joldardi auistiru kerek:");
        Console.Write("n1 = ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("n2 = ");
        n2 = int.Parse(Console.ReadLine());
        int[] t = new int[6];
        for (j = 0; j < 6; j++)
        {
            t[j] = a[n1, j];

            a[n2, j] = a[n1, j];

            a[n1, j] = t[j];
        }
        for (i = 0; i < 6; i++)
        {
            for (j = 0; j < 6; j++)
            {
                Console.Write($"a[{i},{j}]={a[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
*/
/*
using System;
public static class Program
{
    public static void Main()
    {
        int i, j;
        int[,] a = new int[5, 5];
        Random r = new Random();

        for (i = 0; i < 5; i++)
        {
            for (j = 0; j < 5; j++)
            {
                a[i, j] = r.Next(-50, 51);
                Console.Write($"a[{i},{j}]={a[i, j]} \t");
            }
            Console.WriteLine();
        }
        int p = 1;
        for (i = 0; i < 5; i++)
        {
            for (j = 0; j < 5; j++)
            {
                if (i > j) { p *= a[i, j]; }
            }
        }
        Console.WriteLine("Bas diagonaldan tomen elementter kobeitindisi:" + p);
        Console.ReadLine();
    }
}
*/
/*
using System;
public static class Program
{
    public static void Main()
    {
        int i, j;
        int[,] B = new int[6, 6];
        Random r = new Random();

        for (i = 0; i < 6; i++)
        {
            for (j = 0; j < 6; j++)
            {
                B[i, j] = r.Next(-50, 51);
                Console.Write(B[i, j] + "\t");
            }
            Console.WriteLine();
        }
        double p = 1;
        for (i = 0; i < 6; i++)
        {
            for (j = 0; j < 6; j++)
            {
                if (i > j) { p *= B[i, j]; }
            }
        }
        Console.WriteLine("Bas diagonaldan tomen elementter kobeitindisi:" + p);
        Console.ReadLine();
    }
}
*/
/*
using System;
public static class Program
{
    public static void Main()
    {
        int i, j;
        int[,] a = new int[7, 4];
        Random r = new Random();

        for (i = 0; i < 7; i++)
        {
            for (j = 0; j < 4; j++)
            {
                a[i, j] = r.Next(-20, 21);
                Console.Write("a[" + i + "," + j + "]=" + a[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int maxI = 0, maxJ = 0;
        for (i = 0; i < 7; i++)
        {
            for (j = 0; j < 4; j++)
            {
                if (a[i, j] > a[maxI, maxJ]) { maxI = i; maxJ = j; }
            }
        }
        Console.WriteLine("Maximal element jol nomeri:" + maxI + ", bagan nomeri:" + maxJ);
        Console.ReadLine();
    }
}
*/
/*
using System;
public class Program
{
    public static void Main()
    {
        int s = 0;
        for (int i = 20; i <= 100; i++)
        {
            if (i % 7 == 0) { s += i; }
        }
        Console.WriteLine(" 20-dan 100-ge deingi 7-ge kaldiksiz bolinetin sandardin kosindisi: " + s);
        Console.ReadKey();
    }
}
*/
/*
using System;
public class Program
{
    public static void Main()
    {
        int p = 1;
        for (int i = 1; i < 100; i += 2)
        {
            if (i % 13 == 0) { p *= i; }
        }
        Console.WriteLine("13-ke kaldiksiz bolinetin eki orindi tak sandardin kobeitindisi: " + p);
        Console.ReadKey();
    }
}
*/
/*
using System;
public class Program
{
    public static void Main()
    {
        double x, y;
        Console.Write("x = ");
        x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        y = double.Parse(Console.ReadLine());
        if (x > y) { Console.WriteLine("Ulken san:" + x); }
        else if (y > x) { Console.WriteLine("Ulken san:" + y); }
        else { Console.WriteLine("Ekeui ten"); }
        Console.ReadKey();
    }
}
*/
/*
using System;
public static class Program
{
    public static void Main()
    {
        int i, j;
        int[,] a = new int[5, 10];
        Random r = new Random();

        for (i = 0; i < 5; i++)
        {
            for (j = 0; j < 10; j++)
            {
                a[i, j] = r.Next(-20, 21);
                Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine();
        }
        int[] k = new int[10];
        for (i = 0; i < 5; i++)
        {
            for (j = 0; j < 10; j++)
            {
                if (a[i, j] > 0) { k[i]++; }
            }
        }
        for (i = 0; i < 5; i++)
        {
            if (k[i] == 10) { Console.WriteLine(i + "-jol tugel on sandardan turadi"); }
            else { Console.WriteLine(0); }
        }
        Console.ReadLine();
    }
}
*/
/*
using System;
public static class Program
{
    public static void Main()
    {
        int i, j;
        int[,] a = new int[6, 6];
        Random r = new Random();

        for (i = 0; i < 6; i++)
        {
            for (j = 0; j < 6; j++)
            {
                a[i, j] = r.Next(-20, 21);
                Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine();
        }
        int max = a[0, 1];

        for (i = 0; i < 6; i++)
        {
            for (j = 0; j < 6; j++)
            {
                if (i < j)
                {
                    if (a[i, j] > max) { max = a[i, j]; }
                }
            }
        }
        Console.WriteLine("Kosimsha diagonaldin ustingedi en ulken element:" + max);
        Console.ReadLine();
    }
}
*/
/*
using System;
public static class Program
{
    public static void KishiRazriadtarKosindisi(int n, int m)
    {
        n = n % 10;
        m = m % 10;

        Console.WriteLine("Berilgen eki sannin kishi razriadtarinin kosindisi:\n" + n + "+" + m + "=" + (n + m));
    }
    public static void Main()
    {
        int n, m;
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        Console.Write("m = ");
        m = int.Parse(Console.ReadLine());
        KishiRazriadtarKosindisi(n, m);
        Console.ReadLine();
    }
}
*/
/*
using System;
public static class Program
{
    public static int Dauis(char c)
    {
        string dauisti = "AEIOUYaeiouy";

        if (dauisti.IndexOf(c) != -1)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    public static void Main()
    {
        char c;
        Console.Write("Kez kelgen agilshin simvolin engiziniz: ");
        c = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("\n" + Dauis(c));
        Console.ReadLine();
    }
}
*/
/*
using System;
public static class Program
{
    public static void Main()
    {
        int i, n = 0;
        Console.WriteLine("Kez kelgen matin engiziniz:");
        string text = Console.ReadLine();
        char[] lettersC = text.ToCharArray();
        string[] lettersS = new string[lettersC.Length];
        for (i = 0; i < lettersC.Length; i++)
        {
            if (lettersC[i] == '.') { n++; }
            lettersS[i] = Convert.ToString(lettersC[i]);
        }
        Console.WriteLine("\nBerilgen soilemdegi nukteler sani: " + n);
        for (i = 0; i < lettersS.Length; i++)
        {
            if (lettersS[i] == ".") { lettersS[i] = "..."; }
        }
        text = String.Concat(lettersS);
        Console.WriteLine("\nBerilgen soilemdegi nuktelerdi ush nuktemen almastirgandagi turi: ");
        Console.WriteLine(text);
        Console.ReadLine();
    }
}
*/
/*
using System;
public static class Program
{
    public static void Main()
    {
        char[] c = { '.', '!', '?' };
        Console.WriteLine("Kez kelgen matin engiziniz:");
        string text = Console.ReadLine();
        int l = text.Length;
        Console.WriteLine("\nBerilgen tirkestin uzindigi:" + l);
        if (l % 2 == 1)
        {
            string[] sentences = text.Split(c);
            Console.WriteLine("\nTirkestegi songi soilem:" +
                "\n" + sentences[l - 1]);
        }
        else
        {
            char[] letters = text.ToCharArray();
            Console.WriteLine("\nTirkestin ortasindagi simvol:" +
                "\n" + letters[(l - 1) / 2]);
        }

        Console.ReadLine();
    }
}
*/
/*
using System;
public static class Program
{
    public static void Main()
    {
        char[] dauistiDibistar = { 'a', 'e', 'i', 'y', 'u', 'o', 'A', 'E', 'I', 'Y', 'U', 'O' };
        string text = "Kazakh National University";
        Console.WriteLine(text);
        string[] words = text.Split(' ');
        int[] n = new int[words.Length];
        for (int i = 0; i < words.Length; i++)
        {
            n[i] = 0;
            char[] letters = words[i].ToCharArray();
            for (int j = 0; j < letters.Length; j++)
            {
                for (int k = 0; k < dauistiDibistar.Length; k++)
                {
                    if (letters[j] == dauistiDibistar[k])
                    {
                        n[i]++;
                    }
                }
            }
        }
        int maxI = 0;
        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] > n[maxI])
            {
                maxI = i;
            }
        }
        Console.WriteLine("Dauisti dibisi en kop soz: " + words[maxI]);
        Console.ReadLine();
    }
}

*/

/*
using System;
struct Aeroflot
{
    public string punktNaznach;
    public int N;
    public string tipSamoleta; 
    public void DisplayInfo()
    {
        Console.WriteLine($"Название пункта назначения рейса:{punktNaznach}; \nНомер рейса: {N}; \nТип самолета: {tipSamoleta}.\n");
    }
}
class Program
{
    static void Main()
    {
        int i;
        Aeroflot[] aeroflot = new Aeroflot[9];
        for (i = 0; i < 9; i++)
        {
            Console.Write("Название пункта назначения рейса: ");
            aeroflot[i].punktNaznach = Console.ReadLine();
            Console.Write("Номер рейса: ");
            aeroflot[i].N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Тип самолета: ");
            aeroflot[i].tipSamoleta = Console.ReadLine();
        }
        Console.Clear();
        for (i = 0; i < 9; i++)
        {
            aeroflot[i].DisplayInfo();
        }
        int nNuzhni;
        Console.WriteLine("Введите номер рейса, о котором хотите узнать: ");
        nNuzhni = Convert.ToInt32(Console.ReadLine());
        int k = 0;
        for (i = 0; i < 9; i++)
        {
            if (aeroflot[i].N == nNuzhni)
            {
                aeroflot[i].DisplayInfo();
            }
            else
            {
                k++;
            }
        }
        if (k == 9)
        {
            Console.WriteLine("Рейс с таким номером не обнаружен.");
        }
        Console.ReadLine();
    }
}
*/
/*
using System;
struct Train
{
    public string punktNaznach;
    public int N;
    public int[] t;   //t[0]-sagat, t[1]=minut
    public void DisplayInfo()
    {
        Console.WriteLine($"Punkt naznachenia: {punktNaznach}, nomer poezda: {N}, vremia otpravlenia: {t[0]}:{t[1]}");
    }
}
class Program
{
    static void Main()
    {
        int i;
        Train[] train = new Train[6];
        for (i = 0; i < 6; i++)
        {
            train[i].t = new int[2];
            Console.Write("Punkt naznachenia: ");
            train[i].punktNaznach = Console.ReadLine();
            Console.Write("Nomer poezda: ");
            train[i].N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vremia otpravlenia: ");
            Console.Write("Chas vremeni otpravlenia: ");
            train[i].t[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Minuti vremeni otpravlenia: ");
            train[i].t[1] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Clear();
        for (i = 0; i < 6; i++)
        {
            train[i].DisplayInfo();
        }
        Console.WriteLine();
        int[] tPosle = new int[2];
        int k = 0;
        Console.WriteLine("Vvedite vremia, chtobi uvidet poezda otpravliashihsia posle etogo vremeni: ");
        Console.Write("Chasi: ");
        tPosle[0] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Minuti: ");
        tPosle[1] = Convert.ToInt32(Console.ReadLine());
        for (i = 0; i < 6; i++)
        {
            if (train[i].t[0] > tPosle[0])
            { 
                train[i].DisplayInfo();
            }
            else if(train[i].t[0] < tPosle[0])
            {
                k++;
            }
            else
            {
                if (train[i].t[1] > tPosle[1])
                {
                    train[i].DisplayInfo();
                }
            }
        }
        if (k == 6)
        {
            Console.WriteLine("Takih poezdov net.");
        }
        Console.ReadLine();
    }
}
*/
/*
using System;
struct Note
{
    public string familiaImia;
    public string nomerTelefona;
    public int[] dataRojdenia;   //dataRojdenia[0]-den, dataRojdenia[1]=mesiac, dataRojdenia[2]-god
    public void DisplayInfo()
    {
        Console.WriteLine($"Фамилия и имя: {familiaImia}, " +
            $"\nНомер телефона: {nomerTelefona}, " +
            $"\nДата рождения: {dataRojdenia[0]}.{dataRojdenia[1]}.{dataRojdenia[2]}");
    }
}
class Program
{
    static void Main()
    {
        int i;
        Note[] note = new Note[9];
        for (i = 0; i < 9; i++)
        {
            note[i].dataRojdenia = new int[3];
            Console.Write("Фамилия и имя: ");
            note[i].familiaImia = Console.ReadLine();
            Console.Write("Номер телефона: ");
            note[i].nomerTelefona = Console.ReadLine();
            Console.WriteLine("Дата рождения: ");
            Console.Write("День рождения: ");
            note[i].dataRojdenia[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Месяц рождения: ");
            note[i].dataRojdenia[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Год рождения: ");
            note[i].dataRojdenia[2] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Clear();
        for (i = 0; i < 9; i++)
        {
            note[i].DisplayInfo();
        }
        Console.WriteLine();
        int godRojdenia;
        Console.WriteLine("Введите нужный вам год, чтобы увидеть людей, которые родились в этот год: ");
        godRojdenia = Convert.ToInt32(Console.ReadLine());
        int k = 0;
        for (i = 0; i < 9; i++)
        {
            if (note[i].dataRojdenia[2] == godRojdenia)
            {
                note[i].DisplayInfo();
            }
            else
            {
                k++;
            }
        }
        if (k == 9)
        {
            Console.WriteLine("Люди, которые родились в этот год, не обнаружены.");
        }
        Console.ReadLine();
    }
}
*/
/*
using System;
struct Student
{
    public string tegiInicialdari;
    public string topNomiri;
    public int[] ulgerimi;
    public void DisplayInfo()
    {
        Console.WriteLine($"Tegi jane inicialdari: {tegiInicialdari} " +
            $"\nTop nomiri: {topNomiri}");
    }
    public void DisplayUlgerimi()
    {
        Console.WriteLine($"Ulgerimi: {ulgerimi[0]}, {ulgerimi[1]}, {ulgerimi[2]}, {ulgerimi[3]}, {ulgerimi[4]}.");
    }
}
public class Program
{
    public static void Main()
    {
        int i, j;
        double[] avgUlgerim = new double[8];
        Student[] student = new Student[8];
        for (i = 0; i < 8; i++)
        {
            student[i].ulgerimi = new int[5];
            Console.Write("Tegi jane inicialdari: ");
            student[i].tegiInicialdari = Console.ReadLine();
            Console.Write("Top nomiri: ");
            student[i].topNomiri = Console.ReadLine();
            Console.WriteLine("Ulgerimi: ");
            for (j = 0; j < 5; j++)
            {
                Console.Write($"Ulgerim {j + 1}: ");
                student[i].ulgerimi[j] = Convert.ToInt32(Console.ReadLine());
                avgUlgerim[i] += student[i].ulgerimi[j];
            }
        }
        Console.Clear();
        for (i = 0; i < 8; i++)
        {
            student[i].DisplayInfo();
            student[i].DisplayUlgerimi();
            avgUlgerim[i] /= 5;
        }
        int k = 0;
        Console.WriteLine();
        Console.WriteLine("Ortasha bagalari 4.0-den artik studentter tizimi: ");
        for (i = 0; i < 8; i++)
        {
            if (avgUlgerim[i] > 4.0) 
            {
                student[i].DisplayInfo();
                k++;
            }
        }
        if (k == 0)
        {
            Console.WriteLine("Ortasha bagalari 4.0-den artik studennter jok.");
        }
        Console.ReadLine();
    }
}
*/
/*
using System;
struct Marsh
{
    public string nachalnyiPunkt;
    public string konechnyiPunkt;
    public int nomerMarshruta;
    public override string ToString()
    {
        return $"Номер маршрута: {nomerMarshruta}; \nНачальный пункт маршрута: {nachalnyiPunkt}; \nКонечный пункт маршрута: {konechnyiPunkt}.\n";
    }
}
class Program
{
    static void Main()
    {
        int i;
        Marsh[] marshes = new Marsh[7];

        for (i = 0; i < 7; i++)
        {
            Console.Write("Номер маршрута: ");
            marshes[i].nomerMarshruta = Convert.ToInt32(Console.ReadLine());
            Console.Write("Начальный пункт маршрута: ");
            marshes[i].nachalnyiPunkt = Console.ReadLine();
            Console.Write("Конечный пункт маршрута: ");
            marshes[i].konechnyiPunkt = Console.ReadLine();
        }
        Console.Clear();
        for (i = 0; i < 7; i++)
        {
            Console.WriteLine(marshes[i]);
        }
        Console.Write("Введите номер маршрута, о котором хотите узнать: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int k = 0;
        Console.WriteLine();
        for (i = 0; i < 7; i++)
        {
            if (marshes[i].nomerMarshruta == n)
            {
                Console.WriteLine(marshes[i]);
            }
            else
            {
                k++;
            }
        }
        if (k == 7)
        {
            Console.WriteLine("Маршрут с таким номером не обнаружен.");
        }
        Console.ReadLine();
    }
}
*/

/*
using System;
using System.IO;
class Program
{
    static void Main()
    {
        int i;
        string[] tanistar = { "Аскабылов Куаныш", "Сейфудин Амир", "Нурсейыт Бейбарыс", "Сабитов Семсер", "Аблаев Елжан" };
        string[] nomerler = { "87473153849", "87085659737", "87073585701", "87005101002", "87474399549" };
        try
        {
            using (StreamWriter sw = new StreamWriter(@"C:\tanistar.txt", false, System.Text.Encoding.Default))
            {
                for (i = 0; i < 5; i++)
                {
                    sw.WriteLine(tanistar[i]);
                }
            }
            using (StreamWriter sw = new StreamWriter(@"C:\nomerler.txt", false, System.Text.Encoding.Default))
            {
                for (i = 0; i < 5; i++)
                {
                    sw.WriteLine(nomerler[i]);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.Write("Tanisinizdin atin koru ushin onin telefon nomirin engiziniz: ");
        string n = Console.ReadLine();
        int k = 0;

        StreamReader sr1 = new StreamReader(@"C:\nomerler.txt", System.Text.Encoding.Default);
        string line;
        do
        {
            k++;
            line = sr1.ReadLine();
        } while (line != n);
        string t = "";
        StreamReader sr2 = new StreamReader(@"C:\tanistar.txt", System.Text.Encoding.Default);
        for (i = 0; i < k; i++)
        {
            t = sr2.ReadLine();
        }
        Console.WriteLine(t);
        System.Diagnostics.Process.Start(@"C:\tanistar.txt");
        System.Diagnostics.Process.Start(@"C:\nomerler.txt");
        Console.ReadLine();
    }
}
*/
/*
using System;
using System.IO;
class Program
{
    static void Main()
    {
        int i;
        Random r = new Random();
        double[] s = { 0.324, 0.524, 0.789, 0.556, 0.761, 0.248, 0.345, 0.911, 0.216 };
        try
        {
            using (StreamWriter sw = new StreamWriter(@"C:\list.txt", false, System.Text.Encoding.Default))
            {
                for (i = 0; i < s.Length; i++)
                {
                    sw.WriteLine(s[r.Next(0, s.Length)]);
                }
            }
            StreamReader sr = new StreamReader(@"C:\list.txt", System.Text.Encoding.Default);
            string line = "";
            Console.WriteLine("0.5-ten ulken komponentter: ");
            do
            {
                line = sr.ReadLine();
                if (Convert.ToDouble(line) > 0.5) 
                {
                    Console.WriteLine(line);
                }
            } while (line != null);
            System.Diagnostics.Process.Start(@"C:\list.txt");
            Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
 */

/*
 * using System;
public static class Program
{
   //1-тапсырма
   //33-есеп
   public static void Main()
   {
       Console.Write("Oz atinizdi engiziniz: ");
       string str = Console.ReadLine();
       Console.WriteLine("Sizdin atinizdin bagana turinde tik bagittagi turi:");
       foreach (char c in str)
       {
           Console.WriteLine(c);
       }
       Console.ReadLine();
   }
}
*/
/*
using System;
struct Student
{
   string atiJoni;
   string[] panAttari;
   int[] panBagalari;
   public Student(string atiJoni ,string[] panAttari, params int[] panBagalari)
   {
       this.atiJoni = atiJoni;
       this.panAttari = panAttari;
       this.panBagalari = panBagalari;
   }
   public void DisplayInfo()
   {
       Console.WriteLine($"Ati-joni: {atiJoni};");
       for (int i = 0; i < panAttari.Length; i++)
       {
           Console.WriteLine($"Pan ati jane odan algan bagasi: {panAttari[i]} - {panBagalari[i]}");
       }
       Console.WriteLine();
   }
   public void DisplayAtiJoni()
   {
       Console.WriteLine(atiJoni);
   }
   public static void BarlikPannenAttestaciaAlganStudennter(Student[] studentter)
   {
       int[] k = new int[studentter.Length];

       for (int i = 0; i < studentter.Length; i++)
       {
           for (int j = 0; j < studentter[i].panAttari.Length; j++)
           {
               if (studentter[i].panBagalari[j] > 2)
               {
                   k[i]++;
               }
           }
       }
       Console.WriteLine("Barlik pannen attestacia algan studennter tizimi: ");
       for (int i = 0; i < studentter.Length; i++)
       {
           if (k[i] == studentter[i].panAttari.Length) 
           {
               studentter[i].DisplayAtiJoni();
           }
       }
   }
}
public class Program
{
   public static void Main()
   {
       Student[] studentter = new Student[5];
       string[] panAttari = { "Programmalau", "ICT", "Tarih", "Fizika", "Agilshin tili" };
       studentter[0] = new Student("Zhumagul Aigerim", panAttari, 5, 5, 5, 5, 5);
       studentter[1] = new Student("Serikov Serik", panAttari, 4, 4, 4, 5, 4);
       studentter[2] = new Student("Berikov Berik", panAttari, 5, 4, 5, 4, 5);
       studentter[3] = new Student("Erlanov Erlan", panAttari, 4, 2, 4, 4, 5);
       studentter[4] = new Student("Askarov Askar", panAttari, 2, 3, 4, 3, 4);
       for (int i = 0; i < studentter.Length; i++)
       {
           studentter[i].DisplayInfo();
       }
       Console.WriteLine();
       Student.BarlikPannenAttestaciaAlganStudennter(studentter);
       Console.ReadLine();
   }
}
*/
/*
using System;
class Tiktortburish
{
    int a, b; //a-uzindigi, b-eni
    public Tiktortburish(int a, int b)
    {
        this.a = a; 
        this.b = b;
    }
    public double Perimetri()
    {
        return 2 * (a + b);
    }
    public double Audani()
    {
        return a * b;
    }
    public void Shygaru()
    {
        Console.WriteLine($"Uzindigi: {a};" +
            $"\nEni: {b};" +
            $"\nPerimetri: P = 2 * ({a} + {b}) = {Perimetri()};" +
            $"\nAudani: S = {a} * {b} = {Audani()}.");
    }
}
public class Program
{
    public static void Main()
    {
        int a, b;
        Console.Write("Tiktortburish uzindigi: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Eni: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Tiktortburish t = new Tiktortburish(a, b);
        t.Shygaru();
        Console.ReadLine();
    }
}

*/

/*
using System;
class Tauar
{
    string ati;
    int bagasi;
    int koimadagiSani;
    public string Ati
    {
        set
        {
            ati = value ?? "No name";
        }
        get { return ati; }
    }
    public int Bagasi
    {
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Tauardin bagasi 0-den tomen bola almaidi.");
            }
            else { bagasi = value; }
        }
        get { return bagasi; }
    }
    public void SetKoimadagiSani(int ks)
    {
        this.koimadagiSani = ks;
    }
    public int GetKoimadagiSani()
    {
        return koimadagiSani;
    }
    public int JalpiBaga()
    {
        return bagasi * koimadagiSani;
    }
    public static string JalpiBagalarinSalistiru(Tauar t1, Tauar t2)
    {
        if (t1.JalpiBaga() > t2.JalpiBaga()) { return t1.Ati + " tauarinin jalpi bagasi " + t2.Ati + " tauarinin jalpi bagsinan kobirek."; }
        else if (t1.JalpiBaga() < t2.JalpiBaga()) { return t2.Ati + " tauarinin jalpi bagasi " + t1.Ati + " tauarinin jalpi bagasinan kobirek."; }
        else { return t1.Ati + " jane " + t2.Ati + " tauarlarinin jalpi bagalari ozara ten."; }
    }
    public override string ToString()
    {
        return $"Tauar ati: {Ati};" +
        $"\nBagasi: {Bagasi};" +
        $"\nKoimadagi sani: {GetKoimadagiSani()};" +
        $"\nTauardin jalpi bagasi: {JalpiBaga()}.";
    }
}
public class Program
{
    public static void Main()
    {
        int i;
        Tauar[] tauarlar = new Tauar[3];
        for (i = 0; i < tauarlar.Length; i++)
        {
            tauarlar[i] = new Tauar();
            Console.Write("Tauardin ati: ");
            tauarlar[i].Ati = Console.ReadLine();
            Console.Write("Bagasi: ");
            tauarlar[i].Bagasi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Koimadagi sani: ");
            int ks = Convert.ToInt32(Console.ReadLine());
            tauarlar[i].SetKoimadagiSani(ks);
            Console.WriteLine();
        }
        Console.Clear();
        for (i = 0; i < tauarlar.Length; i++)
        {
            Console.WriteLine(tauarlar[i].ToString());
        }
        Console.WriteLine();
        Console.WriteLine(Tauar.JalpiBagalarinSalistiru(tauarlar[0], tauarlar[1]));
        Console.WriteLine(Tauar.JalpiBagalarinSalistiru(tauarlar[0], tauarlar[2]));
        Console.WriteLine(Tauar.JalpiBagalarinSalistiru(tauarlar[1], tauarlar[2]));
        Console.ReadLine();
    }
}

*/
/*
using System;
class Ushburish
{
    int a, b, c;
    public int A
    {
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Kabirga uzindigi 0-den tomen bola almaidi.");
            }
            else { a = value; }
        }
        get { return a; }
    }
    public int B
    {
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Kabirga uzindigi 0-den tomen bola almaidi.");
            }
            else { b = value; }
        }
        get { return b; }
    }
    public void SetC(int C)
    {
        if (C < 0)
        {
            Console.WriteLine("Kabirga uzindigi 0-den tomen bola almaidi.");
        }
        else { c = C; }
    }
    public int GetC()
    {
        return c;
    }
    public double Audani()
    {
        double p = (A + B + GetC()) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - GetC()));
    }
    public static double EkiUshburishAudanarininAirmasi(Ushburish u1, Ushburish u2)
    {
        return u1.Audani() - u2.Audani();
    }
    public override string ToString()
    {
        return $"Ushburish: " +
            $"a = {A}, " +
            $"b = {B}, " +
            $"c = {GetC()}, " +
            $"Audani: {Audani()}.";
    }
}
public class Program
{
    public static void Main()
    {
        int i;
        Ushburish[] ushburishtar = new Ushburish[3];
        for (i = 0; i < ushburishtar.Length; i++)
        {
            ushburishtar[i] = new Ushburish();
            Console.Write("A = ");
            ushburishtar[i].A = Convert.ToInt32(Console.ReadLine());
            Console.Write("B = ");
            ushburishtar[i].B = Convert.ToInt32(Console.ReadLine());
            Console.Write("C = ");
            int C = Convert.ToInt32(Console.ReadLine());
            ushburishtar[i].SetC(C);
            Console.WriteLine();
        }
        Console.Clear();
        for (i = 0; i < ushburishtar.Length; i++)
        {
            Console.WriteLine(ushburishtar[i].ToString());
        }
        Console.WriteLine();
        Console.WriteLine(ushburishtar[0] + " jane " + ushburishtar[1] + " ushburishtarinin airmasi: " + Ushburish.EkiUshburishAudanarininAirmasi(ushburishtar[0], ushburishtar[1]));
        Console.WriteLine(ushburishtar[0] + " jane " + ushburishtar[2] + " ushburishtarinin airmasi: " + Ushburish.EkiUshburishAudanarininAirmasi(ushburishtar[0], ushburishtar[2]));
        Console.WriteLine(ushburishtar[1] + " jane " + ushburishtar[2] + " ushburishtarinin airmasi: " + Ushburish.EkiUshburishAudanarininAirmasi(ushburishtar[1], ushburishtar[2]));
        Console.ReadLine();
    }
}

*/
/*
using System;
class BolshekSan
{
    int n, d; //n-alimi, d-bolimi
    public void SetN(int N) //setter
    {
        this.n = N;
    }
    public int GetN() //getter
    {
        return n;
    }
    public int D //kasiet
    {
        set
        {
            this.d = (value != 0) ? value : 1;
        }
        get { return d; }
    }
    public static BolshekSan EkiBolshekSandiKosu(BolshekSan b1, BolshekSan b2)
    {
        BolshekSan b = new BolshekSan();
        b.SetN(b2.D * b1.GetN() + b1.D * b2.GetN());
        b.D = b1.D * b2.D;
        return b;
    }
    public override string ToString()
    {
        return $"{n}/{d}";
    }
}
public class Program
{
    public static void Main()
    {
        int i;
        BolshekSan[] bolshekSandar = new BolshekSan[3];
        for (i = 0; i < bolshekSandar.Length; i++)
        {
            bolshekSandar[i] = new BolshekSan();
            Console.Write("Bolshek san alimi: ");
            int N = Convert.ToInt32(Console.ReadLine());
            bolshekSandar[i].SetN(N);
            Console.Write("Bolimi: ");
            bolshekSandar[i].D = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }
        Console.Clear();
        for (i = 0; i < bolshekSandar.Length; i++)
        {
            Console.WriteLine("Bolshek san: " + bolshekSandar[i].ToString());
        }
        Console.WriteLine();
        Console.WriteLine(bolshekSandar[0] + " jane " + bolshekSandar[1] + " bolshek sandarinin kosindisi: " + BolshekSan.EkiBolshekSandiKosu(bolshekSandar[0], bolshekSandar[1]));
        Console.WriteLine(bolshekSandar[0] + " jane " + bolshekSandar[2] + " bolshek sandarinin kosindisi: " + BolshekSan.EkiBolshekSandiKosu(bolshekSandar[0], bolshekSandar[2]));
        Console.WriteLine(bolshekSandar[1] + " jane " + bolshekSandar[2] + " bolshek sandarinin kosindisi: " + BolshekSan.EkiBolshekSandiKosu(bolshekSandar[1], bolshekSandar[2]));
        Console.ReadLine();
    }
}
*/
/*
using System;
class GeomProg
{
    double b1; //b1-алғашқы мүшесі, Q-еселігі
    public double Q { set; get; } //автоматты қасиет
    public void SetB1(double b1) //setter
    {
        this.b1 = b1;
    }
    public double GetB1() //getter
    {
        return b1;
    }
    public double bn(int n) //геометриялық прогрессияның n-ші мүшесі
    {
        return b1 * Math.Pow(Q, n - 1);
    }
    public static string SaikesMushelerinSalistiru(GeomProg g1, GeomProg g2, int n)
    {
        if (g1.bn(n) > g2.bn(n))
        {
            return $"{g1} geom. progressiasinin {n}-mushesi {g2} progressiasinin {n}-mushesinen kobirek.";
        }
        else if (g1.bn(n) < g2.bn(n)) 
        {
            return $"{g2} geom. progressiasinin {n}-mushesi {g1} progressiasinin {n}-mushesinen kobirek.";
        }
        else 
        {
            return $"{g1} geom. progressiasinin {n}-mushesi {g2} progressiasinin {n}-mushesine ten.";
        }
    }
    public override string ToString()
    {
        return $"b1 = {GetB1()}, q = {Q}";
    }
}
public class Program
{
    public static void Main()
    {
        int i;
        GeomProg[] geomProgs = new GeomProg[3];
        for (i = 0; i < geomProgs.Length; i++)
        {
            geomProgs[i] = new GeomProg();
            Console.Write("Algashki mushesi: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            geomProgs[i].SetB1(b1);
            Console.Write("Eseligi: ");
            geomProgs[i].Q = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
        }
        Console.Clear();
        for (i = 0; i < geomProgs.Length; i++)
        {
            Console.WriteLine("Geometrialik progressia: " + geomProgs[i].ToString());
        }
        Console.Write("\nGeometrialik progressialardin kai mushesin tapkiniz keledi: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (i = 0; i < geomProgs.Length; i++)
        {
            Console.WriteLine($"{geomProgs[i]} geom. progressiasinin {n}-mushesi: " + geomProgs[i].bn(n));
        }
        Console.WriteLine();
        Console.WriteLine(GeomProg.SaikesMushelerinSalistiru(geomProgs[0], geomProgs[1], n));
        Console.WriteLine(GeomProg.SaikesMushelerinSalistiru(geomProgs[0], geomProgs[2], n));
        Console.WriteLine(GeomProg.SaikesMushelerinSalistiru(geomProgs[1], geomProgs[2], n));
        Console.ReadLine();
    }
}
*/

/*
using System;
class BolshekSan
{
    int n, d; //n-alimi, d-bolimi
    public BolshekSan() //бос конструктор
    {
        n = 1; d = 2;
    }
    public BolshekSan(int n, int d) //параметрлі конструктор
    {
        this.n = n;
        if (d != 0) { this.d = d; }
        else { this.d = 1; }
    }
    public BolshekSan(BolshekSan b) //көшіру конструктор
    {
        n = b.n;
        if (b.d != 0) { this.d = b.d; }
        else { this.d = 1; }
    }
    public void ButinSangaKobeitu(int k)
    {
        this.n *= k;
    }
    public override string ToString()
    {
        return $"{n}/{d}";
    }
}
public class Program
{
    public static void Main()
    {
        BolshekSan b1 = new BolshekSan(); // Бос конструкторды қолдану
        BolshekSan b2 = new BolshekSan(17, 64); // Параметрлі конструкторды қолдану
        BolshekSan b3 = new BolshekSan(b2); // Көшіру конструкторын қолдану
        Console.WriteLine("Bolshek san: " + b1
            + "\nBolshek san: " + b2
            + "\nBolshek san: " + b3 + "\n");

        Console.Write(b2 + " bolshek sanin kandai butin sanga kobeitkiniz keledi: ");
        int k = Convert.ToInt32(Console.ReadLine());
        Console.Write($"{k} * {b2} = ");
        b2.ButinSangaKobeitu(k);
        Console.WriteLine(b2);
        Console.ReadLine();
    }
}

 */
/*
using System;
class Tauar
{
   string ati;
   int tauarBagasi;
   int koimadagiSani;
   public Tauar()
   {
       ati = "Нан";
       tauarBagasi = 80;
       koimadagiSani = 100;
   }
   public Tauar(string a, int t, int k)
   {
       ati = a;
       tauarBagasi = t;
       koimadagiSani = k;
   }
   public Tauar(Tauar t)
   {
       ati = t.ati;
       tauarBagasi = t.tauarBagasi;
       koimadagiSani = t.koimadagiSani;
   }
   public int JalpiBaga()
   {
       return tauarBagasi * koimadagiSani;
   }
   public override string ToString()
   {
       return $"Tauardin ati: {ati};" +
       $"\nBagasi: {tauarBagasi};" +
       $"\nKoimadagi sani: {koimadagiSani};" +
       $"\nTauardin jalpi bagasi: {tauarBagasi} * {koimadagiSani} = {JalpiBaga()}.";
   }
}
public class Program
{
   public static void Main()
   {
       Tauar t1 = new Tauar(); // Бос конструкторды қолдану
       Tauar t2 = new Tauar("Coca Cola", 300, 20); // Параметрлі конструкторды қолдану
       Tauar t3 = new Tauar(t2); // Көшіру конструкторын қолдану
       Console.WriteLine(t1 + "\n\n" + t2 + "\n\n" + t3);
       Console.ReadLine();
   }
}
*/

/*
using System;
using System.IO;
public class Program
{
    static int BinarySearch(int[] array, int searchedValue, int left, int right)
    {
        while (left <= right)
        {
            var middle = (left + right) / 2;

            if (searchedValue == array[middle])
            {
                return middle;
            }
            else if (searchedValue < array[middle])
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }
        return -1;
    }
    public static void Main()
    {
        int i;
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        try
        {
            int n = 0;
            using (StreamWriter sw = new StreamWriter(@"C:\list.txt", false, System.Text.Encoding.Default))
            {
                for (i = 0; i < numbers.Length; i++)
                {
                    n++;
                    sw.WriteLine(numbers[i]);
                }
            }
            int[] numbersInFile = new int[n];
            StreamReader sr = new StreamReader(@"C:\list.txt", System.Text.Encoding.Default);
            string line = "";
            for (i = 0; i < numbersInFile.Length; i++)
            {
                if (line == null) { break; }
                line = sr.ReadLine();
                numbersInFile[i] = Convert.ToInt32(line);
            }
            Console.Write("Tizimnen kandai sandi joiginiz keledi: ");
            int k = Convert.ToInt32(Console.ReadLine());
            int right = numbersInFile[numbersInFile.Length - 1];
            int left = numbersInFile[0];
            int BinarySearchResult = BinarySearch(numbersInFile, k, left, right);
            string[] fileLines = File.ReadAllLines(@"C:\list.txt");
            fileLines[BinarySearchResult] = String.Empty; // deleting
            File.WriteAllLines(@"C:\ChangedList.txt", fileLines);
            System.Diagnostics.Process.Start(@"C:\list.txt");
            System.Diagnostics.Process.Start(@"C:\ChangedList.txt");
            Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
*/
/*
using System;
using System.Linq;

public static class Program
{
    public static void Main()
    {
        int i;
        string[] tizim = { "Ibragim Dias", "Askarov Askar", "Berikov Berik", "Serikov Serik", "Zhumagul Aigul", "Zhumagul Erlan", "Toktarov Toktar", "Erkhanov Erkhan" };
        string[] familialar = new string[tizim.Length];
        Console.WriteLine("Top tizimi: ");
        for (i = 0; i < tizim.Length; i++)
        {
            Console.WriteLine(tizim[i]);
            string[] FI = tizim[i].Split(' ');
            familialar[i] = FI[0];
        }
        for (i = 0; i < tizim.Length; i++)
        {
            string[] FI = tizim[i].Split(' ');
            familialar[i] = FI[0];
        }
        var result = familialar
             .Select(str => new { Name = str, Count = familialar.Count(s => s == str) })
             .Where(obj => obj.Count > 1)
             .Distinct()
             .ToDictionary(obj => obj.Name, obj => obj.Count);
        int n = 0;
        foreach (var r in result)
        {
            n++;
        }
        string[] kaitalanatinF = new string[n];
        i = 0;
        foreach (var r in result)
        {
            kaitalanatinF[i] = r.Key;
            i++;
        }
        Console.WriteLine("\nFamilialari birdei studentter: ");
        for (i = 0; i < tizim.Length; i++)
        {
            for (int j = 0; j < kaitalanatinF.Length; j++)
            {
                if (tizim[i].Contains(kaitalanatinF[j]))
                {
                    Console.WriteLine(tizim[i]);
                }
            }
        }
        Console.ReadLine();
    }
}
*/

/*
using System;
class Ushburish
{
    double a, b, c;
    public Ushburish(double a, double b, double c) //параметрлі конструкторы
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public Ushburish(Ushburish u) //көшіру конструкторы
    {
        a = u.a;
        b = u.b;
        c = u.c;
    }
    public void Eseleu(int k) //барлық өрістерді бүтін санға еселеу
    {
        a *= k;
        b *= k;
        c *= k;
    }
    public void Eseleu(int k1, int k2, int k3) //әр өрісті әр түрлі бүтін сандарға еселеу
    {
        a *= k1;
        b *= k2;
        c *= k3;
    }
    public void Eseleu(double k) //барлық өрістерді нақты санға еселеу
    {
        a *= k;
        b *= k;
        c *= k;
    }
    public void Eseleu(double k1, double k2, double k3) //әр өрісті әр түрлі нақты сандарға еселеу
    {
        a *= k1;
        b *= k2;
        c *= k3;
    }
    public override string ToString()
    {
        return $"Ushburish: " +
            $"a = {a}, " +
            $"b = {b}, " +
            $"c = {c}.";
    }
}
public class Program
{
    public static void Main()
    {
        Ushburish u1 = new Ushburish(3, 4, 5);
        Ushburish u2 = new Ushburish(u1);
        Console.WriteLine(u2);
        Console.Write("\nBerilgen ushburishti kandai butin sanga eseleu kerek: ");
        int k = Convert.ToInt32(Console.ReadLine());
        u2.Eseleu(k);
        Console.WriteLine(u2);


        u2 = new Ushburish(u1);
        Console.WriteLine("\nBerilgen ushburishti kandai butin sandarga eseleu kerek: ");
        int k1, k2, k3;
        Console.Write("k1 = ");
        k1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("k2 = ");
        k2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("k3 = ");
        k3 = Convert.ToInt32(Console.ReadLine());
        u2.Eseleu(k1, k2, k3);
        Console.WriteLine(u2);


        u2 = new Ushburish(u1);
        Console.Write("\nBerilgen ushburishti kandai nakti sanga eseleu kerek: ");
        double dk = Convert.ToDouble(Console.ReadLine());
        u2.Eseleu(dk);
        Console.WriteLine(u2);


        u2 = new Ushburish(u1);
        Console.WriteLine("\nBerilgen ushburishti kandai nakti sandarga eseleu kerek: ");
        double dk1, dk2, dk3;
        Console.Write("k1 = ");
        dk1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("k2 = ");
        dk2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("k3 = ");
        dk3 = Convert.ToDouble(Console.ReadLine());
        u2.Eseleu(dk1, dk2, dk3);
        Console.WriteLine(u2);


        Console.ReadLine();
    }
}
*/
/*

using System;
class BolshekSan
{
    int n, d; //n-alimi, d-bolimi
    public BolshekSan(int n, int d) //parametrli 
    {
        this.n = n;
        this.d = d;
    }
    public BolshekSan(BolshekSan b) //koshiru
    {
        this.n = b.n;
        this.d = b.d;
    }
    public void Kosu(int k) //bolshek sandi butin sanga kosu
    {
        Console.WriteLine($"{n}/{d} + {k} = ");
        this.n += this.d * k;
    }
    public void Kosu(BolshekSan b) //bolshek sandi bolshek sanga kosu
    {
        Console.WriteLine($"{n}/{d} + {b.n}/{b.d} = ");
        this.n = this.n * b.d + this.d * b.n;
        this.d *= b.d;
    }
    public override string ToString()
    {
        return $"{n}/{d}";
    }
}
public class Program
{
    public static void Main()
    {
        BolshekSan b1 = new BolshekSan(13, 64);
        BolshekSan b2 = new BolshekSan(b1);
        Console.WriteLine(b2);
        Console.Write("\nBerilgen bolshek sandi kandai butin sanga kosu kerek: ");
        int k = Convert.ToInt32(Console.ReadLine());
        b2.Kosu(k);
        Console.WriteLine(b2);


        b2 = new BolshekSan(b1);
        Console.WriteLine("\nBerilgen bolshek sandi kandai bolshek sanga kosu kerek: ");
        int n, d;
        Console.Write("Alimi: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Bolimi = ");
        d = Convert.ToInt32(Console.ReadLine());
        BolshekSan b = new BolshekSan(n, d);
        b2.Kosu(b);
        Console.WriteLine(b2);

        Console.ReadLine();
    }
}
 */
/*
using System;
class Uakit
{
    int sag, min, sec;
    public Uakit(int sag, int min, int sec) //parametrli 
    {
        Sag = sag;
        Min = min;
        Sec = sec;
    }
    public Uakit(Uakit u) //koshiru
    {
        Sag = u.sag;
        Min = u.min;
        Sec = u.sec;
    }
    public int Sag
    {
        get { return sag; }
        set { sag = (value >= 0 && value <= 23) ? value : 0; }
    }
    public int Min
    {
        get { return min; }
        set { min = (value >= 0 && value <= 59) ? value : 0; }
    }
    public int Sec
    {
        get { return sec; }
        set { sec = (value >= 0 && value <= 59) ? value : 0; }
    }
    public static Uakit EkiUakitMerzimininAirmasi(Uakit u1, Uakit u2) //берілген екі уақыт мерзімінің айырмасын табу
    {
        int sag, min, sec;
        sag = u1.Sag - u2.Sag;
        min = u1.Min - u2.Min;
        sec = u1.Sec - u2.Sec;
        return new Uakit(sag, min, sec);
    }
    public static Uakit EkiUakitMerzimininAirmasi(Uakit u) //берілген уақыт мерзімінің ағымдағы уақыттан айырмасын анықтау
    {
        int sag, min, sec;
        sag = DateTime.Now.Hour - u.Sag;
        min = DateTime.Now.Minute - u.Min;
        sec = DateTime.Now.Second - u.Sec;
        return new Uakit(sag, min, sec);
    }
    public override string ToString()
    {
        return $"Uakit:{Sag}:{Min}:{Sec}";
    }
}
public class Program
{
    public static void Main()
    {
        Uakit u1 = new Uakit(22, 51, 59);
        Uakit u2 = new Uakit(12, 36, 12);
        Uakit u3 = new Uakit(u1);
        Console.WriteLine($"{u3} uakitinin {u2} uakitinan airmasi: ");
        Console.WriteLine(Uakit.EkiUakitMerzimininAirmasi(u3, u2));
        Console.WriteLine($"{u2} uakitinin kazirgi uakittan airmasi: ");
        Console.WriteLine(Uakit.EkiUakitMerzimininAirmasi(u2));
        Console.ReadKey();
    }
}
*/
/*
using System;
class Tauar
{
    string ati;
    int bagasi;
    int koimadagiSani;
    public Tauar(string ati, int bagasi, int koimadagiSani) //параметрлі конструктор
    {
        this.ati = ati;
        this.bagasi = bagasi;
        this.koimadagiSani = koimadagiSani;
    }
    public Tauar(Tauar t) //көшіру конструкторы
    {
        ati = t.ati;
        bagasi = t.bagasi;
        koimadagiSani = t.koimadagiSani;
    }
    public int JalpiBaga(int n) //параметрлі әдіс берілген тауардың жалпы бағасын есептейді
    {
        return bagasi * n;
    }
    public int JalpiBaga() //параметрсіз әдіс қоймадағы бар тауарлардың жалпы бағасын есептейді
    {
        return bagasi * koimadagiSani;
    }
    public override string ToString()
    {
        return $"Tauar ati: {ati};" +
        $"\nBagasi: {bagasi};" +
        $"\nKoimadagi sani: {koimadagiSani}.";
    }
}
public class Program
{
    public static void Main()
    {
        Tauar t = new Tauar("Пломбир", 200, 50);
        Console.WriteLine(t);
        Console.WriteLine($"\nBerilgen tauardin koimadagi barliginin jalpi bagasi: {t.JalpiBaga()}");
        Console.Write($"\nBerikgen tauardin kansha danasinin jalpi bagasin bilginiz keledi: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Berilgen tauardin {n} danasinin jalpi bagasi: {t.JalpiBaga(n)}");
        Console.ReadLine();
    }
}
 */
/*
using System;
class Trapecia
{
    double a, b, c, d; //a, b - tabandari, c, d - shetki kabirgalari
    public Trapecia(Trapecia t) //көшіру конструкторы
    {
        a = t.a;
        b = t.b;
        c = t.c;
        d = t.d;
    }
    public Trapecia(double a, double b, double c, double d) //параметрлі конструкторы
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
    }
    public void Masshtabtau(int ik) //барлық өрістерді бүтін санға еселеу
    {
        a *= ik;
        b *= ik;
        c *= ik;
        d *= ik;
    }
    public void Masshtabtau(double dk) //барлық өрістерді нақты санға еселеу
    {
        a *= dk;
        b *= dk;
        c *= dk;
        d *= dk;
    }
    public override string ToString()
    {
        return $"Trapecia: " +
            $"a = {a}, " +
            $"b = {b}, " +
            $"c = {c}, " +
            $"d = {d}.";
    }
}
public class Program
{
    public static void Main()
    {
        Trapecia t1 = new Trapecia(4, 8, 5, 5);
        Trapecia t2 = new Trapecia(t1);
        Console.WriteLine(t2);
        Console.WriteLine("\nBerilgen trapecianin kabirgalarin kandai butin sanga kobeitip masshtabtau kerek:");
        int ik = Convert.ToInt32(Console.ReadLine());
        t2.Masshtabtau(ik);
        Console.WriteLine(t2);

        t2 = new Trapecia(t1);
        Console.WriteLine("\nBerilgen trapecianin kabirgalarin kandai nakti sanga kobeitip masshtabtau kerek:");
        double dk = Convert.ToDouble(Console.ReadLine());
        t2.Masshtabtau(dk);
        Console.WriteLine(t2);


        Console.ReadLine();
    }
}
*/
/*
using System;
class Tiktortburish
{
    double a, b; //a-uzindigi, b-eni
    public Tiktortburish(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public Tiktortburish(Tiktortburish t)
    {
        this.a = t.a;
        this.b = t.b;
    }
    public void Eseleu(int k) //бүтін санға еселеу
    {
        a *= k;
        b *= k;
    }
    public void Eseleu(int k1, int k2) //бүтін сандарға еселеу
    {
        a *= k1;
        b *= k2;
    }
    public void Eseleu(double k) //нақты санға еселеу
    {
        a *= k;
        b *= k;
    }
    public void Eseleu(double d1, double d2) //нақты сандарға еселеу
    {
        a *= d1;
        b *= d2;
    }

    public override string ToString()
    {
        return $"Uzindigi: {a};" +
            $"\nEni: {b}.";
    }
}
public class Program
{
    public static void Main()
    {
        int a, b;
        Console.Write("Tiktortburish uzindigi: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Eni: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Tiktortburish t = new Tiktortburish(a, b);

        Tiktortburish kt = new Tiktortburish(t);
        Console.WriteLine(kt);
        Console.Write("\nTiktortburishtin oristerin kandai butin sanga eseleu kerek: ");
        int k = Convert.ToInt32(Console.ReadLine());
        kt.Eseleu(k);
        Console.WriteLine(kt);


        kt = new Tiktortburish(t);
        Console.WriteLine("\nTiktortburishtin oristerin kandai butin sandarga eseleu kerek: ");
        int k1, k2;
        Console.Write("k1 = ");
        k1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("k2 = ");
        k2 = Convert.ToInt32(Console.ReadLine());
        kt.Eseleu(k1, k2);
        Console.WriteLine(kt);


        kt = new Tiktortburish(t);
        Console.Write("\nTiktortburishtin oristerin kandai nakti sanga eseleu kerek: ");
        double dk = Convert.ToDouble(Console.ReadLine());
        kt.Eseleu(dk);
        Console.WriteLine(kt);


        kt = new Tiktortburish(t);
        Console.WriteLine("\nTiktortburishtin oristerin kandai nakti sandarga eseleu kerek: ");
        double d1, d2;
        Console.Write("d1 = ");
        d1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("d2 = ");
        d2 = Convert.ToDouble(Console.ReadLine());
        kt.Eseleu(d1, d2);
        Console.WriteLine(kt);


        Console.ReadLine();
    }
}
*/
/*
using System;
class BolshekSan
{
    int n, d; //n-alimi, d-bolimi
    public BolshekSan(int n, int d) //parametrli 
    {
        this.n = n;
        this.d = d;
    }
    public BolshekSan(BolshekSan b) //koshiru
    {
        this.n = b.n;
        this.d = b.d;
    }
    public int EUOB() //En ulken ortak bolgish
    {
        int a = n, b = d;
        while (b != 0)
        {
            int t = b;
            b = a % b;
            a = t;
        }
        return a;
    }
    public void Kiskartu() //Bolshekti kiskartu
    {
        int t = EUOB();
        n /= t;
        d /= t;
    }
    public void Kosu(int k) //bolshek sandi butin sanga kosu
    {
        this.n += this.d * k;
        Kiskartu();
    }
    public void Kosu(BolshekSan b) //bolshek sandi bolshek sanga kosu
    {
        this.n = this.n * b.d + this.d * b.n;
        this.d *= b.d;
        Kiskartu();
    }
    public override string ToString()
    {
        if (n == d)
        {
            return "1";
        }
        else if (n < d)
        {
            return $"{n}/{d}";
        }
        else
        {
            int k = n % d;
            int t = (n - k) / d;
            return $"{n}/{d} = {t} butin {k}/{d}";
        }
    }
}
public class Program
{
    public static void Main()
    {
        BolshekSan b1 = new BolshekSan(13, 64);
        BolshekSan b2 = new BolshekSan(b1);
        Console.WriteLine(b2);

        Console.Write("\nBerilgen bolshek sandi kandai butin sanga kosu kerek: ");
        int k = Convert.ToInt32(Console.ReadLine());

        Console.Write($"\n{b2} + {k} = ");
        b2.Kosu(k);
        Console.WriteLine(b2);


        b2 = new BolshekSan(b1);
        Console.WriteLine("\nBerilgen bolshek sandi kandai bolshek sanga kosu kerek: ");
        int n, d;
        Console.Write("Alimi: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Bolimi = ");
        d = Convert.ToInt32(Console.ReadLine());
        BolshekSan b = new BolshekSan(n, d);

        Console.Write($"\n{b2} + {b} = ");
        b2.Kosu(b);
        Console.WriteLine(b2);

        Console.ReadLine();
    }
}
 */

/*
 * using System;
public class Program
{ 
   public static void Main()
   {
       int x, y;
       Console.Write("x osinin uzindigi: ");
       x = Convert.ToInt32(Console.ReadLine());

       Console.Write("y osinin uzindigi: ");
       y = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine();
       Console.WriteLine("^ y");
       for (int i = y; i > 0; i--)
       {
           Console.WriteLine("|");
       }
       Console.Write(" ");
       for (int i = x; i > 0; i--)
       {
           Console.Write("-");
       }
       Console.WriteLine("> x");
       Console.ReadLine();
   }
}*/
/*
using System;
public static class Program
{
    public static void Main()
    {
        string text = "Kazakhstan, officially the Republic of Kazakhstan, is a transcontinental country largely located in Central Asia with the most western parts of it being located in Eastern Europe." +
            "It is the world's largest landlocked country, and the ninth-largest country in the world, with an area of 2,724,900 square kilometres." +
            "Kazakhstan is the most dominant nation of Central Asia economically, generating 60% of the region's GDP, primarily through its oil and gas industry." +
            "It also has vast mineral resources.";
        Console.WriteLine(text);

        string[] sentences = text.Split('.');
        char[] lettersOfLastSentence = sentences[sentences.Length - 2].ToCharArray();

        int n = 0;
        for (int i = 0; i < lettersOfLastSentence.Length; i++)
        {
            if (lettersOfLastSentence[i] == 'A' || lettersOfLastSentence[i] == 'a')
            {
                n++;
            }
        }
        Console.WriteLine("\nBerilgen matindegi songi soilemde A arpinin sani: " + n);
        Console.ReadLine();
    }
}
*/