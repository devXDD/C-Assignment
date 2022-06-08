//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace BankApp
//{
//    class Solution
//    {
//        public string username;
//        private string message;
//        public List<string> usernameList = new List<string>();
//        private Dictionary<string, string> messageList = new Dictionary<string, string>();


//        public Solution(string username)
//        {
//            this.username = username;
//        }

//       public void AddUser(string username)
//        {
//            usernameList.Add(username);
//        }

//     public   void AddMessage(string username, string message)
//        {
//            messageList.Add(username, message);
//        }

//     public   void GetMessage(string username)
//        {
//            foreach (var s in messageList)
//            {
//                Console.WriteLine(messageList[username]);
//            }
//        }

//        void AddFollower(string username, string usernameToFollow)
//        {

//        }

//        void GetFollowedMessages(string username)
//        {

//        }

//        static void Main(string [] args)
//        {
//            Solution obj = new Solution("Dev");
//            obj.AddUser("Dev");
//            obj.AddMessage("Dev", "Hey");
//            obj.GetMessage("Dev");
//        }
//    }
//}


