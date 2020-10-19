using Assets.Scripts.Map;
using Assets.State;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    public MapModel model = GameState.GetModel<MapModel>();

    // Start is called before the first frame update
    void Start()
    {
        model.RegisterMap(model.initial);
        model.initial.SetActive(true);
    }

    public void ShowMap(GameObject map)
    {
        foreach (GameObject mp in model.maps)
        {
            mp.SetActive(false);
        }
        map.SetActive(true);
    }
}
