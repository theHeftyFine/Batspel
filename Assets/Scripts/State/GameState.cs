using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.State
{
    public static partial class GameState
    {
        static public T GetModel<T>() where T : class, new()
        {
            return InstanceRegister<T>.instance;
        }

    }
}