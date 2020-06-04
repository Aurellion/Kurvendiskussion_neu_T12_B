using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurvendiskussion_neu
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string nochmal = "n";
            do
            {
                int auswahl = 0;
                Console.WriteLine("Kurvendiskussion");

                Console.WriteLine("1: Lineare Funktion y=f(x)=mx+n");
                Console.WriteLine("2: Quadratische Funktion y=f(x)=ax^2+bx+c");
                auswahl = Convert.ToInt32(Console.ReadLine());
                switch (auswahl)
                {
                    case 1:
                        Console.WriteLine("Parameter eingeben:");
                        double m = 0, n = 0;

                        //m = Convert.ToDouble(Console.ReadLine());

                        //Eingabe

                        //Mit Fehlerabfrage:
                        bool ergebnis0 = false;
                        bool ergebnis1 = false;

                        while (ergebnis0 == false)
                        {
                            Console.WriteLine("m=");
                            ergebnis0 = double.TryParse(Console.ReadLine(), out m);
                            if (ergebnis0 == false)
                            {
                                Console.WriteLine("Bitte eine gültige Zahl eingeben!");
                            }
                        }

                        while (ergebnis1 == false)
                        {
                            Console.WriteLine("n=");
                            ergebnis1 = double.TryParse(Console.ReadLine(), out n);
                            if (ergebnis1 == false)
                            {
                                Console.WriteLine("Bitte eine gültige Zahl eingeben!");
                            }
                        }
                        Console.WriteLine("y=f(x)=" + m + "x+" + n);

                        //Verarbeitung

                        //Monotonie
                        string mononotonie_ergebnis;
                        if (m == 0)
                        {
                            mononotonie_ergebnis = "Die Funktion f(x) ist gleichbleibend (konstant).";
                        }
                        else if (m < 0)
                        {
                            mononotonie_ergebnis = "Die Funktion f(x) ist streng monoton fallend.";
                        }
                        else
                        {
                            mononotonie_ergebnis = "Die Funktion f(x) ist streng monoton steigend.";
                        }

                        //Nullstelle
                        double xn;
                        xn = 0;
                        string nullstelle_ergebnis;
                        if (m != 0)
                        {
                            xn = -n / m;
                            nullstelle_ergebnis = "Die Nullstelle befindet sich bei xn=" + xn + ".";
                        }
                        else
                        {
                            nullstelle_ergebnis = "Es gibt keine Nullstelle.";
                        }

                        //Schnittpunkte
                        string xSchnittpunkt_ergebnis, ySchnittpunkt_ergebnis;

                        if (m != 0)
                        {
                            xSchnittpunkt_ergebnis = "Der Schnittpunkt mit der x-Achse liegt bei S_x=(" + xn + ";0).";
                        }
                        else
                        {
                            xSchnittpunkt_ergebnis = "Es gibt keinen Schnittpunkt mit der x-Achse.";
                        }

                        ySchnittpunkt_ergebnis = "Der Schnittpunkt mit der y-Achse liegt bei S_y=(0;" + n + ").";

                        //Ausgabe

                        //Monotonie
                        Console.WriteLine(mononotonie_ergebnis);
                        //Nullstelle
                        Console.WriteLine(nullstelle_ergebnis);
                        //Schnittpunkte
                        //Schnittpunkt im Koordinatenursprung
                        if (n == 0)
                        {
                            Console.WriteLine("Schnittpunkt im Koordinatenursprung S=(0;0).");
                        }
                        else
                        {
                            //Schnittpunkt mit der x-Achse
                            Console.WriteLine(xSchnittpunkt_ergebnis);
                            //Schnittpunkt mit der y-Achse
                            Console.WriteLine(ySchnittpunkt_ergebnis);
                        }
                        break;

                    case 2:
                        //Nullstellen, Achsenschnittpunkte, (Monotonie)   

                        //---------Eingabe-------------

                        Console.WriteLine("Parameter eingeben:");
                        double a = 0, b = 0, c=0;
                        bool ergebnis=false;

                        while (ergebnis == false || a == 0)
                        {
                            Console.WriteLine("a=");
                            ergebnis = double.TryParse(Console.ReadLine(), out a);
                            if (ergebnis == false || a==0)
                            {
                                Console.WriteLine("Bitte eine gültige Zahl verschieden von Null eingeben!");
                                //ergebnis = false;
                            }
                        }
                        ergebnis = false;
                        while (ergebnis == false)
                        {
                            Console.WriteLine("b=");
                            ergebnis = double.TryParse(Console.ReadLine(), out b);
                            if (ergebnis == false)
                            {
                                Console.WriteLine("Bitte eine gültige Zahl eingeben!");
                            }
                        }
                        ergebnis = false;
                        while (ergebnis == false)
                        {
                            Console.WriteLine("c=");
                            ergebnis = double.TryParse(Console.ReadLine(), out c);
                            if (ergebnis == false)
                            {
                                Console.WriteLine("Bitte eine gültige Zahl eingeben!");
                            }
                        }

                        Console.WriteLine("y=f(x)="+a+"x^2+"+b+"x+"+c);

                        //---------Verarbeitung-------------


                        //Nullstellen 
                        //Achsenschnittpunkte
                        string Ergebnis_yAchsenschnittpunkt = "Der Schnittpunkt mit der y-Achse liegt bei Sy=(0; " + c + ").";
                        string Ergebnis_xAchsenschnittpunkt = "";
                        double D;
                        double x1, x2, x0;
                        string Ergebnis_Nullstellen;
                        D = Math.Pow(b, 2) - 4 * a * c;
                        if (D < 0)
                        {
                            Ergebnis_Nullstellen = "Die Funktion hat keine reellen Nullstellen.";
                            Ergebnis_xAchsenschnittpunkt = "Es gibt keinen Schnittpunkt mit der x-Achse.";
                        }
                        else if (D == 0)
                        {
                            x0=-b/(2*a);
                            Ergebnis_Nullstellen = "Die Funktion hat eine doppelte reelle Nullstelle bei x_N="+x0+".";
                            Ergebnis_xAchsenschnittpunkt = "Der Schnittpunkt mit der x-Achse liegt bei Sx=(" + x0 + "; 0).";
                        }
                        else
                        {
                            x1 = (-b + Math.Sqrt(D)) / (2 * a);
                            x2 = (-b - Math.Sqrt(D)) / (2 * a);
                            Ergebnis_Nullstellen = "Die Funktion hat zwei reelle Nullstellen bei x_N1="+x1+" und x_N2="+x2+".";
                            Ergebnis_xAchsenschnittpunkt = "Die Schnittpunkte mit der x-Achse sind Sx1=("+x1+"; 0) und Sx2=("+x2+"; 0).";
                        }

                        //Scheitelpunkt und Monotonie
                        double x_Scheitelpunkt, y_Scheitelpunkt;
                        x_Scheitelpunkt = -b / (2 * a);
                        y_Scheitelpunkt = c - b * b / (4 * a);
                        string Ergebnis_Scheitelpunkt = "Der Scheitelpunkt liegt bei S_SP=(" + x_Scheitelpunkt + "; " + y_Scheitelpunkt + ").";
                        string Ergebnis_Monotonie="";
                        //string infty = "∞";
                        if (a > 0)
                        {
                            Ergebnis_Monotonie = "Die Funktion ist streng monoton fallend im Intervall (-\u221E; "
                                                     + x_Scheitelpunkt + ") und monoton wachsend im Intervall " +
                                                     "[" + y_Scheitelpunkt + "; +\u221E)";
                        }
                        else
                        {
                            Ergebnis_Monotonie = "Die Funktion ist streng monoton wachsend im Intervall (-\u221E; "
                                                     + x_Scheitelpunkt + ") und monoton fallend im Intervall " +
                                                     "[" + y_Scheitelpunkt + "; +\u221E)";
                        }

                        //---------Ausgabe-------------
                        Console.WriteLine(Ergebnis_Nullstellen);
                        Console.WriteLine(Ergebnis_xAchsenschnittpunkt);
                        Console.WriteLine(Ergebnis_yAchsenschnittpunkt);
                        Console.WriteLine(Ergebnis_Scheitelpunkt);
                        Console.WriteLine(Ergebnis_Monotonie);

                        break;
                    default:
                        Console.WriteLine("Falsche Eingabe!");
                        break;
                }




                Console.WriteLine("Noch eine Funktion untersuchen? (j/n)");
                nochmal = Console.ReadLine();
            } while (nochmal == "j" || nochmal == "J");
        }
    }
}
