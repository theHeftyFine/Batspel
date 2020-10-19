using Assets.State;
using Assets.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSelector : MonoBehaviour
{

    UIModel model = GameState.GetModel<UIModel>();
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        model.RegisterSubPanel(panel);
    }

    public void OnMouseDown()
    {
        model.OpenPanel(panel);
    }
}
