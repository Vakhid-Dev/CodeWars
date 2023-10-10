﻿using System.Text;

namespace CodeWars.Lib._6kuy;

public class Wholikesit
{
    public static string Likes(string[] names)
    {
        string result = names.Length switch
        {
            0 => "no one likes this",
            1 => $"{names[0]} likes this",
            2 => $"{names[0]} and {names[1]} like this",
            3 => $"{names[0]}, {names[1]} and {names[2]} like this",
            _ => $"{names[0]}, {names[1]} and {names.Length - 2} others like this"
        };

        return result;
    }
    public static string Likes2(string[] name)
    {
        string[] pattern = { "no one likes this", "{0} likes this", "{0} and {1} like this", "{0}, {1} and {2} like this", "{0}, {1} and {2} others like this" };

        return name.Length < 4 ? string.Format(pattern[name.Length], name) : string.Format(pattern[4], name[0], name[1], name.Length - 2);
    }
    }
