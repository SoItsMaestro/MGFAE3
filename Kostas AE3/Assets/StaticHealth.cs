using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticHealth
{
    private static int Health;
    private static string Level;

    public static int health

    {
        get
        {
            return Health;
        }
        set
        {
            Health = value;
        }
    }

    public static string level
    {
        get
        {
            return Level;
        }
        set
        {
            Level = value;
        }
    }
}
