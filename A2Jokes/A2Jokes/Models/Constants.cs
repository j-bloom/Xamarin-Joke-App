using System;
using System.Collections.Generic;
using System.Text;

namespace A2Jokes
{
    public static class Constants
    {
        public const string AnyJoke = "https://v2.jokeapi.dev/joke/Any?blacklistFlags=nsfw,religious,racist,sexist,explicit&type=single";
        public const string ProgrammingJokes = "https://v2.jokeapi.dev/joke/Programming?blacklistFlags=nsfw,religious,racist,sexist,explicit&type=single";
        public const string PunJokes = "https://v2.jokeapi.dev/joke/Pun?blacklistFlags=nsfw,religious,racist,sexist,explicit&type=single";
    }
}
