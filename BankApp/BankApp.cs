using System;
using System.Collections.Generic;
using System.Linq;
public class Solution
{
    public string username;
    public string message;

    public string follow;
    public string followMessage;

    public List<string> usernameList = new List<string>();
   // public Dictionary<string, string> FollowerMessage = new Dictionary<string, string>();
    public List<KeyValuePair<string, string>> messageList = new List<KeyValuePair<string, string>>();
    public List<KeyValuePair<string, string>> FollowerList = new List<KeyValuePair<string, string>>();

    public Solution(string username)
    {
        this.username = username;
    }
    public void AddUser(string username)
    {
        usernameList.Add(username);
    }
    public void AddMessage(string username, string message)
    {
       messageList.Add(new KeyValuePair<string, string>(username, message));
    }
    public void GetMessage(string username)
    {
        foreach (var element in messageList)
        {
            Console.WriteLine(element.Value);
        }
}
    public void AddFollower(string username, string usernameToFollow)
    {
        FollowerList.Add(new KeyValuePair<string, string>(username, usernameToFollow));
    }
    public void GetFollowedMessages(string username)
    {
        var t = (from kvp in FollowerList where kvp.Key == username select kvp.Value).ToList();
        foreach (var element in t)
        {
           foreach (var msg in messageList)
            {
                if(msg.Key == element)
                {
                    Console.WriteLine(msg.Value);
                }
            }
        }
    }

    static void Main(string[] args)
    {
        Solution obj = new Solution("JohnSmith");
        obj.AddUser("JohnSmith");
        obj.AddMessage("JohnSmith", "Hello");
        obj.AddMessage("JohnSmith", "Hello sir");
        obj.GetMessage("JohnSmith");

        obj.AddUser("JaneDoe");
        obj.AddUser("JaneFoe");

        obj.AddMessage("JaneDoe", "Hello to you too");
        obj.AddMessage("JaneDoe", "Hello to you too mam");

        obj.AddMessage("JaneFoe", "Hello to you tooo");

        obj.AddFollower("JohnSmith", "JaneDoe");
        obj.AddFollower("JohnSmith", "JaneFoe");

        obj.GetFollowedMessages("JohnSmith");
    }
}
