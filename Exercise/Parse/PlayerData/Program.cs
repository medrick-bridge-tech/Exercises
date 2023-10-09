using System;
using System.Collections.Generic;
using Newtonsoft.Json;

public class PlayerData
{
    public string Username { get; set; }
    public int Level { get; set; }
    public string Guild { get; set; }
    public List<string> Items { get; set; }
    public int SkinId { get; set; }

    public PlayerData()
    {
        Items = new List<string>();
    }

    public PlayerData(string username, int level, string guild, List<string> items, int skinId )
    {
        Username = username;
        Level = level;
        Guild = guild;
        Items = items;
        SkinId = skinId;
     

    }
    

}

public class JsonParser
{
    public static PlayerData ParsePlayerDataFromJson(string jsonData)
    {
        try
        {
            PlayerData playerData = JsonConvert.DeserializeObject<PlayerData>(jsonData);
            return playerData;
        }
        catch (JsonException ex)
        {
           
            Console.WriteLine($"Error parsing JSON: {ex.Message}");
            return null;
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose a Number (1, 2, 3) or enter 'q' to quit:");
            string choice = Console.ReadLine();

            if (choice == "q")
            {
                break; 
            }

            switch (choice)
            {
                case "1":
                    DisplayExample(1);
                    break;
                case "2":
                    DisplayExample(2);
                    break;
                case "3":
                    DisplayExample(3);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1, 2, 3, or 'q' to quit.");
                    break;
            }
        }
    }

    static void DisplayExample(int exampleNumber)
    {
        string jsonData = GetJsonDataForExample(exampleNumber);
        if (jsonData != null)
        {
            PlayerData player = JsonParser.ParsePlayerDataFromJson(jsonData);
            if (player != null)
            {
                Console.WriteLine($"Player {exampleNumber}:");
                Console.WriteLine($"Username: {player.Username}");
                Console.WriteLine($"Level: {player.Level}");
                Console.WriteLine($"Guild: {player.Guild}");
                Console.WriteLine($"SkinId: {player.SkinId}");
                if (player.Items != null && player.Items.Count > 0)
                {
                    
                    foreach (string item in player.Items)
                    {
                        Console.WriteLine($"- {item}");
                    }
                }
                else
                {
                    Console.WriteLine("Items: 1");
                }
            }
        }
        else
        {
            Console.WriteLine($"Example {exampleNumber} not found.");
        }
    }

    static string GetJsonDataForExample(int exampleNumber)
    {
        switch (exampleNumber)
        {
            case 1:
                return "{\"username\":\"snake\",\"level\":10,\"items\":[\"MK 23\",\"Night Vision\"]}";
            case 2:
                return "{\"username\":\"link\",\"level\":15,\"guild\":\"Warriors\",\"skinId\":123}";
            case 3:
                return "{\"username\":\"leon\",\"coins\":100,\"questsCompleted\":5}";
            default:
                return null;
        }
    }
}

