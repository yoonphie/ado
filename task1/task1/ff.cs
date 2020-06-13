using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace task1 
{
    public class ff
    {
        public Triangle[] input(string path)
        {
            Triangle[] r = null;
            Triangle t = new Triangle();
            using (StreamReader fileIn = new StreamReader("C:/Users/Софья/source/repos/task1/input.txt"))
            {
                int n;
                if (int.TryParse(fileIn.ReadLine(), out n))
                {
                    r = new Triangle[n];

                    for (int i = 0; i < n; i++)
                    {
                        string[] text = fileIn.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        double x;
                        double y;
                        Points a = null;
                        Points b = null;
                        Points c = null;

                        if (double.TryParse(text[0], out x) && double.TryParse(text[1], out y))
                        {
                            a = new Points(x, y);
                        }
                        else
                        {
                            throw new ArgumentException("Parametr is not right");
                        }

                        if (double.TryParse(text[2], out x) && double.TryParse(text[3], out y))
                        {
                            b = new Points(x, y);
                        }
                        else
                        {
                            throw new ArgumentException("Parametr is not right");
                        }


                        if (double.TryParse(text[4], out x) && double.TryParse(text[5], out y))
                        {
                            c = new Points(x, y);
                        }
                        else
                        {
                            throw new ArgumentException("Parametr is not right");
                        }

                        if ((t.length(a, b) + t.length(b, c) > t.length(c, a))
                            && (t.length(a, b) + t.length(c, a) > t.length(b, c))
                            && (t.length(b, c) + t.length(c, a) > t.length(a, b)))

                        {
                            r[i] = new Triangle(a, b, c);
                        }

                        else
                        {
                            throw new ArgumentException("Triangle doesn't exist.");
                        }
                    }
                }
                return r;
            }
        }
        public void output(Triangle[] r)
        {
            using (StreamWriter fileOut = new StreamWriter("C:/Users/Софья/source/repos/task1/output.txt"))
            {
                foreach (Triangle item in r)
                {
                    fileOut.WriteLine("Coordinates a = ({0},{1})", item.a.x, item.a.y);
                    fileOut.WriteLine("Coordinatse b = ({0},{1})", item.b.x, item.b.y);
                    fileOut.WriteLine("Coordinates c = ({0},{1})", item.c.x, item.c.y);
                    fileOut.WriteLine("Perimetr = {0}", item.P);
                    fileOut.WriteLine("Square = {0}", item.S);
                    fileOut.WriteLine();
                }
            }
        }
    }
}