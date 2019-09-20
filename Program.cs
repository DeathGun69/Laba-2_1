using System;
using System.IO;

namespace laba2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ADMIN\Documents\sergey\KPO\laba2_1\text.txt";
            string line;
            string[] words;

            if(File.Exists(path)){
                StreamReader stread = new StreamReader(path, System.Text.Encoding.Default);

                try {
                    Console.WriteLine();
                        Console.WriteLine("Файл {0} существует", Path.GetFileName(path));
                        Console.WriteLine();

                        using (stread){
                            while ((line = stread.ReadLine()) != null)
                            {
                                words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                int lengt = words.Length;
                                for (int i = 0; i<lengt-1; i++){
                                    string elem_left = words[i];
                                    string elem_right = words[i+1];
                                    if (elem_left[elem_left.Length-1] == elem_right[0] ){
                                        Console.WriteLine(elem_left + " " + elem_right);
                                    }
                                }
                            }
                        }
                    } catch (Exception e) {
                        Console.WriteLine(e.Message);
                    } finally {
                        try {
                            stread.Close();
                        } catch (Exception e) {
                            Console.WriteLine(e.Message);
                        }
                    }
            } else {
                Console.WriteLine("Файла {0} не существует.", Path.GetFileName(path));
            }
        }
    }
}
