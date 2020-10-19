using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.State { 
        static class InstanceRegister<T> where T : class, new()
        {
            public static T instance = new T();
        }
}