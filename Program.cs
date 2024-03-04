internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // Task classi Microsoft .NET Framework 4.0 ile teqdim edilib.
        // 2010-cu ilin aprelinde buraxılan texnologiyadır.
        // O vaxtdan bu yana Task classi C# ve diger .NET dillerinde asinxron proqramlasdırma ücün standart struktura olub.
        // Task classi default olaraq thread-in eksine background thread istifade edir. 
        // Threadpooldan thread goturur.
        // Adeten asinxron proqramlasdirmada ve paralel proqramlasdirmada istifade olunur
        // Bir nece thread-i asinxron formada ise salmaq ucun yazilir
        /* Ve threadin eksine tamamile emeliyyat sisteminin kontrolundan cixib, 
         daha ust seviyeli interfacelerle idare olunur, testingler edile bilir */
        // Task bize Thread-in eksine netice return ede bilir ve ya exception vere bilir.
        // ContinueWith(), Wait(), WaitAll(), WaitAny() ve Result kimi ozellikleri movcuddur


        //way 1

        //Task task = Task.Run(() =>
        //{
        //    Console.WriteLine("I am a task :))");
        //});



        //way 2
        var task = new Task (()=> { Console.WriteLine("I am a task :)))"); });

        task.Start();


        var taskresult = task.Id;
        //var taskresult = task.Status;
        //var taskresult = task.GetHashCode;
        //var taskresult = task.GetType;
        //var taskresult = task.Equals;
        //var taskresult = task.CreationOptions;
        //var taskresult = task.IsFaulted;

        Console.WriteLine(taskresult);

    }
}