using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Newtonsoft.Json;
using SQLite;

namespace A2Jokes
{
    public class JokeRepository
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("joke")]
        public string Joke { get; set; }
    }
}
