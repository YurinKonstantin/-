using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ЭнергияМюонов.представление_файлов.stringFile;

namespace ЭнергияМюонов.представление_файлов
{
   public class ClassFileGMSdEdX : ClassFile
    {
        public List<ClassstringGMSdEdX> classstringDepotn5565s = new List<ClassstringGMSdEdX>();
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

                        ClassstringGMSdEdX _stroka = new ClassstringGMSdEdX()
                        {
                            EGeV = Convert.ToDouble(evented[0], System.Globalization.CultureInfo.InvariantCulture),
                            RatTo100 = Convert.ToDouble(evented[1], System.Globalization.CultureInfo.InvariantCulture)
                            

                        };
                        classstringDepotn5565s.Add(_stroka);
                    }
                    catch (Exception ex)
                    {

                    }

                }

            }

        }
    }
}
