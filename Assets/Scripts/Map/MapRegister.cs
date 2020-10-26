using Assets.Scripts.Map;
using Assets.State;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapRegister : MonoBehaviour
{
    MapModel model = GameState.GetModel<MapModel>();

    // Start is called before the first frame update
    void Start()
    {
        model.RegisterMap(gameObject);
        gameObject.SetActive(false);
    }

}
