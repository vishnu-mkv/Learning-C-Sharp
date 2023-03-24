using System;
using System.Collections.Generic;
using System.Linq;

class ChocolateMachine
{
    readonly List<string> chocolates = new();
    readonly string[] colors = { "green", "silver", "blue", "crimson", "purple", "red", "pink" };

    void AddChocolates(string color, int count)
    {
        for (int i = 0; i < count; i++)
        {
            chocolates.Insert(0, color);
        }
    }

    List<string> RemoveChocolates(int number)
    {
        List<string> removedChocolates = new List<string>();
        for (int i = 0; i < number && chocolates.Count > 0; i++)
        {
            removedChocolates.Add(chocolates[0]);
            chocolates.RemoveAt(0);
        }
        return removedChocolates;
    }

    List<string> DispenseChocolates(int number)
    {
        List<string> dispensedChocolates = new List<string>();
        for (int i = 0; i < number && chocolates.Count > 0; i++)
        {
            dispensedChocolates.Add(chocolates[chocolates.Count - 1]);
            chocolates.RemoveAt(chocolates.Count - 1);
        }
        return dispensedChocolates;
    }

    List<string> DispenseChocolatesOfColor(int number, string color)
    {
        List<string> dispensedChocolates = new List<string>();
        for (int i = chocolates.Count - 1; i >= 0 && dispensedChocolates.Count < number; i--)
        {
            if (chocolates[i] == color)
            {
                dispensedChocolates.Add(chocolates[i]);
                chocolates.RemoveAt(i);
            }
        }
        return dispensedChocolates;
    }

    int[] NoOfChocolates()
    {
        int[] counts = new int[7];
        foreach (string color in chocolates)
        {
            counts[Array.IndexOf(colors, color)]++;
        }
        return counts;
    }

    void SortChocolateBasedOnCount()
    {
        Dictionary<string, int> countMap = new Dictionary<string, int>();
        foreach (string color in chocolates)
        {
            if (countMap.ContainsKey(color))
            {
                countMap[color]++;
            }
            else
            {
                countMap[color] = 1;
            }
        }
        chocolates.Sort((c1, c2) => countMap[c2].CompareTo(countMap[c1]));
    }

    public void changeChocolateColor(int number, string color, string finalColor)
    {
        int count = 0;

        for (int i = chocolates.Count - 1; i >= 0; i--)
        {
            if (chocolates[i] == color)
            {
                chocolates[i] = finalColor;
                count++;

                if (count == number) // if we have changed the desired number of chocolates, we can stop iterating
                {
                    break;
                }
            }
        }
    }


    public object[] ChangeChocolateColorAllOfxCount(string color, string finalColor)
    {
        int finalColorCount = 0;

        for(int i=0; i<chocolates.Count; i++)
        {
            if (chocolates[i]  == color || chocolates[i] == finalColor)
            {
                chocolates[i] = finalColor;
                finalColorCount++;
            }
        }

        return new object[] { finalColorCount, chocolates };  
    }

    public void RemoveChocolateOfColor(string color)
    {

        int index = -1;

        for(int i=0; i<chocolates.Count; i++)
        {
            if (chocolates[i] == color)
            {
                index=i; break; 
            }
        }

        if (index == -1) return;

        chocolates.RemoveAt(index);
    }


    public int DispenseRainbowChocolates(int n)
    {
        int rainbowCount = 0;
        int currentColorCount = 0;
        string currentColor = "";

        for (int i = 0; i < n && i < chocolates.Count; i++)
        {
            // Get a chocolate from the bottom of the dispenser
            string chocolate = chocolates[i];

            // If it's a different color from the previous chocolate,
            // reset the current color count and update the current color
            if (chocolate != currentColor)
            {
                currentColorCount = 0;
                currentColor = chocolate;
            }

            // Increment the current color count
            currentColorCount++;

            // If we've dispensed 3 chocolates of the same color,
            // dispense a rainbow chocolate and reset the count
            if (currentColorCount == 3)
            {
                rainbowCount++;
                currentColorCount = 0;
            }

        }

        return rainbowCount;
    }

    public static void Main()
    {

        ChocolateMachine C = new ChocolateMachine();
    }
}