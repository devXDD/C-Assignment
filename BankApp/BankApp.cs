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
    //public List<string> FollowerList = new List<string>();
    public Dictionary<string, string> FollowerList = new Dictionary<string, string>();
    public Dictionary<string, string> FollowerMessage = new Dictionary<string, string>();
    public Dictionary<string, string> messageList = new Dictionary<string, string>();


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
        messageList.Add(username, message);
    }
    public void GetMessage(string username)
    {
        foreach (var s in messageList)
        {
            Console.WriteLine(messageList[username]);
        }
    }
    public void AddFollower(string username, string usernameToFollow)
    {
        FollowerList.Add(username, usernameToFollow);
    }
    public void GetFollowedMessages(string username)
    {
        var t = FollowerList[username];
        //string s = FollowerList.[username];
        foreach (var s in messageList)
        {
            Console.WriteLine(messageList[t]);
        }
        //messageList.ElementAt(i).Key, messageList.ElementAt(i).Value);
    }

    static void Main(string[] args)
    {
        Solution obj = new Solution("JohnSmith");
        obj.AddUser("JohnSmith");
        obj.AddMessage("JohnSmith", "Hello");
        obj.GetMessage("JohnSmith");

        obj.AddUser("JaneDoe");
        obj.AddMessage("JaneDoe", "Hello to you too");

        obj.AddFollower("JohnSmith", "JaneDoe");

        obj.GetFollowedMessages("JohnSmith");
    }
}
