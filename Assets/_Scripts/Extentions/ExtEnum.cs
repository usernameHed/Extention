﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class ExtEnum
{
    /// <summary>
    /// from a given enum value (with his type), return the right index
    /// use: GetINdexOfEnum<EnumType>(enumVariable);
    /// </summary>
    /// <typeparam name="T">enum type</typeparam>
    /// <param name="enumValue">enum value</param>
    /// <returns>index of enum</returns>
    public static int GetIndexOfEnum<T>(T enumValue)
    {
        int index = Array.IndexOf(Enum.GetValues(enumValue.GetType()), enumValue);
        return (index);
    }
    /// <summary>
    /// from a given string, return the value of the enum
    /// use: GetEnumValueFromString<EnumType>("value")
    /// </summary>
    /// <typeparam name="T">enum type</typeparam>
    /// <param name="value"></param>
    /// <param name="enumType"></param>
    /// <returns></returns>
    public static T GetEnumValueFromString<T>(string value)
    {
        T parsed_enum = (T)System.Enum.Parse(typeof(T), value);
        return (parsed_enum);
    }


    /// <summary>
    /// Converts a string to an enum
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="s"></param>
    /// <param name="ignoreCase">true to ignore casing in the string</param>
    public static T ToEnum<T>(this string s, bool ignoreCase) where T : struct
    {
        // exit if null
        if (s == null || s == "")
            return default(T);

        Type genericType = typeof(T);
        if (!genericType.IsEnum)
            return default(T);

        try
        {
            return (T)Enum.Parse(genericType, s, ignoreCase);
        }

        catch (Exception)
        {
            // couldn't parse, so try a different way of getting the enums
            Array ary = Enum.GetValues(genericType);
            foreach (T en in ary.Cast<T>()
                .Where(en =>
                    (string.Compare(en.ToString(), s, ignoreCase) == 0) ||
                    (string.Compare((en as Enum).ToString(), s, ignoreCase) == 0)))
            {
                return en;
            }

            return default(T);
        }
    }
}
