namespace CodeWars.Lib._6kuy;

public class LikesClass
{
    /*
     *[]                                -->  "no one likes this"
       ["Peter"]                         -->  "Peter likes this"
       ["Jacob", "Alex"]                 -->  "Jacob and Alex like this"
       ["Max", "John", "Mark"]           -->  "Max, John and Mark like this"
       ["Alex", "Jacob", "Mark", "Max"]  -->  "Alex, Jacob and 2 others like this"
     *
     * 
     */
    public static string Likes(string[] name)
    {
        var str = string.Empty;
        switch (name.Length)
        {
            case 0:
                str = "no one likes this";
                break;
            case 1:
                str = $"{name[0]} likes this";
                break;
            case 2:
                str = $"{name[0]} and {name[1]} like this";
                break;
            case 3:
                str = $"{name[0]}, {name[1]} and {name[2]} like this";
                break;
            case >=4 :
                str = $"{name[0]}, {name[1]} and {name.Length -2} others like this";
                break;
        }

        return str;
    }
    public static string LikesBest(string[] names)
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
}