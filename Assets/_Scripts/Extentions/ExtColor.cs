using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtColor
{
    /// <summary>
    /// return a color from a string
    /// </summary>
    public static Color ColorHTML(string color)
    {
        Color newCol;
        ColorUtility.TryParseHtmlString(color, out newCol);
        return (newCol);
    }

    /// <summary>
    /// return a color, based on r, g, b, a variable from 0 to 255
    /// use: Color newColor = ExtColor.Color255(25, 255, 0, 1);
    /// </summary>
    /// <param name="r">from 0 to 255</param>
    /// <param name="g">from 0 to 255</param>
    /// <param name="b">from 0 to 255</param>
    /// <param name="a">from 0 to 1</param>
    /// <returns></returns>
    public static Color Color255(float r, float g, float b, float a)
    {
        return new Color(r / 255.0f, g / 255.0f, b / 255.0f, a);
    }

    /// <summary>
    /// only change the alpha of a color
    /// GUI.color = desiredColor.WithAlpha(0.5f);
    /// </summary>
    /// <param name="a">from 0 to 1</param>
    public static Color ChangeAlpha(this Color color, float alpha)
    {
        return new Color(color.r, color.g, color.b, alpha);
    }

    /// <summary>
    /// get a random color
    /// </summary>
    /// <returns></returns>
    public static Color GetRandomColor()
    {
        return (ExtRandom.GetRandomColor());
    }

    /// <summary>
    /// get a random color, with alpha 1
    /// </summary>
    /// <returns></returns>
    public static Color GetRandomColorSeed(System.Random randomSeed)
    {
        return (ExtRandom.GetRandomColorSeed(randomSeed));
    }
}
