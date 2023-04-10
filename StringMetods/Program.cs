namespace StringMetods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = string.Empty;       //bosluq qoymaq isteyirsizse bu methoddan istifade olunur; Ramda yer tutmur 

            string Comment = "Hello     World      Salam         Dunya   ";
            Console.WriteLine( Comment.StartsWith("Hello"));                                                      //Startwith  >> sozun evvelinde bu soz varmi;
            Console.WriteLine(Comment.EndsWith("A"));                                                            //Startwith  >> sozun sonunda  bu soz varmi;
            Console.WriteLine(Comment.Contains("alam"));                                                        //Startwith  >> sozun ICINDE  bu soz varmi;
            Console.WriteLine(Comment.Length);                                                                 //Startwith  >> string arrayinin uzunlugunu gosterir;
            Console.WriteLine(Comment.EndsWith("A"));                                                         //Startwith  >> sozun sonunda  bu soz varmi;
            Console.WriteLine(Comment.IndexOf("o",Comment.IndexOf("o")+1));                                  //Startwith  >> yazdigimiz herf hansi indexsdedi onu gosterir;
            Console.WriteLine(Comment.Replace("Hello","a"));                                                //Startwith  >>1cide durani 2 ciye menimset
            Console.WriteLine(Comment.Trim());                                                             //Startwith  >> sondan ve evvelden bosluqlari silir
            string[] arr = Comment.Split(' ');                                                            //solit boslqlari bir aray kimi yigir hello altinda world altind salam

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            int[] number = {1,3,4,5,6,7,8,9};                                                        //Join arrayi nece ayirmaq isteyirsen 1*2*3*4*5;
            Console.WriteLine(string.Join('*',number));

            Console.WriteLine(string.Compare(Comment,"Hello"));                                   // muqayise edir comment stringine beraberdise 2 ci 0 cixardir yoxsa -1


            if (string.IsNullOrEmpty(Name))                         //bos gonderirikse isnullorEmpty;
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }

            string NameSpace = " ";

            if (string.IsNullOrWhiteSpace(NameSpace))                         //bosLuqda gondersen  gonderirikse ;
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }




        }



    }
}