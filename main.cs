using System;

class Program {
  public static void Main (string[] args) {
    
    double[] grades1 = new double[10];
    int[] grades2 = new int[5];
    
    string grdLttr ="";
    string grdLttrAvg ="";
    double sum = 0;
  
    for(int i =0; i<10; i++)
    {
      
      Console.WriteLine("Enter your "+i+" grade: ");
      string userInput = Console.ReadLine();
      double grd = double.Parse(userInput);
      grades1[i] = grd;

      if(grd<60)
      {
        grdLttr = "F";
        grades2[4]++;
      }
      else if(grd<70)
      {
        grdLttr = "D";
        grades2[3]++;
      }
      else if(grd<80)
      {
        grdLttr = "C";
        grades2[2]++;
      }
      else if(grd<90)
      {
        grdLttr = "B";
        grades2[1]++;
      }
      else if(grd<=100)
      {
        grdLttr = "A";
        grades2[0]++;
      }
      Console.WriteLine("You got an "+grdLttr+" on this test!");
      
      
    }
    Console.WriteLine("You Recieved "+grades2[0]+"A's on your 10 tests");
    
    Console.WriteLine("You Recieved "+grades2[1]+"B's on your 10 tests");
    
    Console.WriteLine("You Recieved "+grades2[2]+"C's on your 10 tests");
    
    Console.WriteLine("You Recieved "+grades2[3]+"D's on your 10 tests");
    
    Console.WriteLine("You Recieved "+grades2[4]+"F's on your 10 tests");
   
    for (int i = 0; i < grades1.Length; i++)
        {
            sum += grades1[i];
        }
    double average = (double)sum / grades1.Length;

    Console.WriteLine("Your test average is "+average);

    if(average<60)
      {
        grdLttrAvg = "F";
        
      }
      else if(average<70)
      {
        grdLttrAvg = "D";
        
      }
      else if(average<80)
      {
        grdLttrAvg = "C";
        
      }
      else if(average<90)
      {
        grdLttrAvg = "B";
        
      }
      else if(average<100)
      {
        grdLttrAvg = "A";
        
      }
    Console.WriteLine("Your grade letter for your average is: "+grdLttrAvg);
    
  }
}