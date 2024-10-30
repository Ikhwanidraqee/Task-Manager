using System;

namespace FirestoreDatabase 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Business business = new Business();
            business.InitFirestore();
        }
    }
}

