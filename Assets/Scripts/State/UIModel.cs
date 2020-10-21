using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UIModel
{
    public GameObject mainGUI;
    List<GameObject> subPanels = new List<GameObject>();
    public bool open { get; private set; } = false;

    public void RegisterSubPanel(GameObject subPanel)
    {
        subPanels.Add(subPanel);
    }

    public void OpenPanel(GameObject panel)
    {
        Debug.Log("opening panel");
        foreach (GameObject sub in subPanels) { sub.SetActive(false); }
        panel.SetActive(true);
        mainGUI.SetActive(true);
        open = true;
    }

    public void CloseUI()
    {
        mainGUI.SetActive(false);
        foreach (GameObject panel in subPanels) { panel.SetActive(false); }
        open = false;
    }
}
