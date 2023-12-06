using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GlobalEventManager
{

    public static UnityEvent<string> EndLevel = new UnityEvent<string>();


      public static void SendResultLevel(string result)
    {
        EndLevel.Invoke(result);
    }
}
