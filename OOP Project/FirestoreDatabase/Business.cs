using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;
using System;

namespace FirestoreDatabase
{
    public class Business
    {
        private const string FIREBASE_PROJID = "cashtransaction-2f8c9"; // Replace with your project ID
        private FirestoreDb db;

        public void InitFirestore()
        {
            try
            {
                // Specify the path to your service account key JSON file explicitly
                var credential = GoogleCredential.FromFile(@"C:\Users\VICTUS\OneDrive\UTP\SEP24\OO\FirestoreDatabase\FirestoreDatabase\oopwork-35d80-firebase-adminsdk-kf4i8-b1769c155e.json");

                // Initialize Firebase App with the specified credentials
                FirebaseApp.Create(new AppOptions()
                {
                    Credential = credential,
                    ProjectId = FIREBASE_PROJID
                });

                db = FirestoreDb.Create(FIREBASE_PROJID);
                Console.WriteLine("Created Cloud Firestore client with project ID: {0}", FIREBASE_PROJID);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error initializing Firestore: " + ex.Message);
            }
        }


    }
}
