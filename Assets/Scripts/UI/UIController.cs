using Assets.State;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.UI
{
    public class UIController : MonoBehaviour
    {
        public UIModel model = GameState.GetModel<UIModel>();
        

        public static bool hidden { get; private set; } = true;


        private void Start()
        {
            model.mainGUI.SetActive(false);
        }

        public void CloseUI ()
        {
            model.CloseUI();
        }
    }
}