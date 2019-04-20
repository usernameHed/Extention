using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtNumbers
{
    /// <summary>
    /// get une string et essai de renvoyer une couleur à partir de cette string...
    /// </summary>
    public static float GetAverageOfNumbers(float [] arrayNumber)
    {
        if (arrayNumber.Length == 0)
            return (0);

        float sum = 0;
        for (int i = 0; i < arrayNumber.Length; i++)
        {
            sum += arrayNumber[i];
        }
        return (sum / arrayNumber.Length);
    }
}
