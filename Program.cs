namespace MoodAnalyser1
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sad or Happy");
            
            string input = Console.ReadLine();

            MoodAnalyse analyse = new MoodAnalyse(input);
            Console.WriteLine(analyse.Analyse);
            Console.WriteLine(analyse.Analyse1);
            Console.WriteLine(analyse.Analyse2);

            
           
             
        }
    }
}