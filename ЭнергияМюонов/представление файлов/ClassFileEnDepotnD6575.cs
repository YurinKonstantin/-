using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ЭнергияМюонов.представление_файлов.stringFile;

namespace ЭнергияМюонов.представление_файлов
{
   public class ClassFileEnDepotnD6575 : ClassFile
    {
        public List<ClassstringDepotn5565> classstringDepotn5565s = new List<ClassstringDepotn5565>();
        public async void openFile()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                char[] chars = { '\n' };
                string s = await sr.ReadToEndAsync();
                string[] ss = s.Split(chars);

                for (int i = 1; i < ss.Length; i++)
                {
                    try
                    {


                        char[] chars1 = { '\t' };
                        string[] evented = ss[i].Split(chars1);

                        ClassstringDepotn5565 _stroka = new ClassstringDepotn5565()
                        {
                            lgD = Convert.ToDouble(evented[0], System.Globalization.CultureInfo.InvariantCulture),
                            exp = Convert.ToDouble(evented[1], System.Globalization.CultureInfo.InvariantCulture),
                            errorexp = Convert.ToDouble(evented[2], System.Globalization.CultureInfo.InvariantCulture),
                            sim = Convert.ToDouble(evented[3], System.Globalization.CultureInfo.InvariantCulture),
                            errorsim = Convert.ToDouble(evented[4], System.Globalization.CultureInfo.InvariantCulture),
                            otn = Convert.ToDouble(evented[5], System.Globalization.CultureInfo.InvariantCulture),
                            otnerror = Convert.ToDouble(evented[6], System.Globalization.CultureInfo.InvariantCulture)

                        };
                        classstringDepotn5565s.Add(_stroka);
                    }
                    catch(Exception ex)
                    {

                    }

                }

            }
        }
    }
}
