using System;


 public class Time1
{
   private int hour; //0-23
   private int minute; // 0-59
   private int second; //0- 59

   public void SetTime(int h, int m, int s)
   {
     //validate hour, minute and second
     if ((h >= 0 && h < 24) && (m >= 0 && m < 60) && (s >= 0 && s < 60))
     {
       hour = h;
       minute = m;
       second = s;
     }
     else
       throw new ArgumentOutOfRangeException();
   }//end method SetTime
   //Convert to string in universal-time format (HH:MM:SS)
   public string ToUniversalString()
   {
     return string.Format("{0:D2}:{1:D2}:{2:D2}", hour, minute, second );
   }//end method ToUniversalString
   //Convert to string in standard-time format (H:MM:SS AM or PM)
   public override string ToString()
   {
 	 return string.Format("{0}:{1:D2}:{2:D2} {3}", ((hour == 0 || hour == 12) ? 12 : hour % 12), 
       minute, second, (hour < 12 ? "AM" : "PM"));
   }//end method ToString
   
}

