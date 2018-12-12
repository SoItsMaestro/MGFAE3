using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticHealth
{
    private static int Health;
   
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
}
