using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Link for With functions: https://twitter.com/JfranMora/status/1130868678277439490

public static class RoseExtensions 
{
    #region With() Functions
    /*Purpose of functions is to replace element(s) in Vector2/3 and Color */

    public static Vector2 With(this Vector2 orig, float? x = null, float? y = null)
    {
        if(x.HasValue) orig.x = x.Value;
        if(y.HasValue) orig.y = y.Value;
        return orig;
    }

    public static Vector3 With(this Vector3 orig, float? x = null, float? y = null, float? z = null)
    {
        if(x.HasValue) orig.x = x.Value;
        if(y.HasValue) orig.y = y.Value;
        if(z.HasValue) orig.z = z.Value;
        return orig;
    }

    public static Color With(this Color orig, float? r = null, float? g = null, float? b = null, float? a = null)
    {
        if(r.HasValue) orig.r = r.Value;
        if(g.HasValue) orig.g = g.Value;
        if(b.HasValue) orig.b = b.Value;
        if(a.HasValue) orig.a = a.Value;
        return orig;
    }

    #endregion

    #region String extensions

    public static string Colored(this string message, Colors color)
    {
        return string.Format("<color={0}>{1}</color>", color.ToString(), message);
    }

    public static string Colored(this string message, string colorCode)
    {
        return string.Format("<color={0}>{1}</color>", colorCode, message);
    }

    public static string Sized(this string message, int size)
    {
        return string.Format("<size={0}>{1}</size>", size, message);
    }

    public static string Bold(this string message)
    {
        return string.Format("<i>{0}</i>", message);
    }

    public static string Italics(this string message)
    {
        return string.Format("<i>{0}</i>", message);
    }

    #endregion




}

public enum Colors{
    aqua,
	black,
	blue,
	brown,
	cyan,
	darkblue,
	fuchsia,
	green,
	grey,
	lightblue,
	lime,
	magenta,
	maroon,
	navy,
	olive,
	purple,
	red,
	silver,
	teal,
	white,
	yellow
}
