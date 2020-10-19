using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Assets.Scripts.Map
{
    [System.Serializable]
    public class MapModel
    {
        public List<GameObject> maps { get; private set; } = new List<GameObject>();
        public GameObject initial;

        public void RegisterMap(GameObject map)
        {
            maps.Add(map);
        }
    }
}