public class Spinner
 {
     private readonly int delay;
     private bool isRunning = false;
     private Thread thread;
     public Spinner(int delay = 25)
     {
         this.delay = delay;
     }

     public void Start()
     {
         if (!isRunning)
         {
             isRunning = true;
             thread = new Thread(Spin);
             thread.Start();
         }
     }
     public void Stop()
     {
         isRunning = false;
     }

     private void Spin()
     {
         while (isRunning)
         {
             Console.Write('.');
             Thread.Sleep(delay);
         }
     }
 }