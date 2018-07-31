using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RockPaperScissorsApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace RockPaperScissorsApp.Core
{
    public class FileWriter
    {
        /// <summary>
        /// Writes the player to file.
        /// Works by reading the whole file, serializing it as a list of players, adding the new entry, and writing it all back.
        /// Useful for maintaining JSON Formatting
        /// </summary>
        /// <param name="player">The player.</param>
        public static void WritePlayerToFile(PlayerModel player)
        {
            List<PlayerModel> playerList = new List<PlayerModel>();
            var path = "C:/Users/Jaco/People.txt";
            if (File.Exists(path))
            {
                var jsonData = File.ReadAllText(path);
                playerList = JsonConvert.DeserializeObject<List<PlayerModel>>(jsonData)
                          ?? new List<PlayerModel>();
            } else
            {
                var file = File.Create(path);
                file.Close();
            }
            playerList.Add(player);
            
            var serializerSettings = new JsonSerializerSettings();
            serializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var json = JsonConvert.SerializeObject(playerList, serializerSettings);
            File.WriteAllText(path, json);
        }
    }
}