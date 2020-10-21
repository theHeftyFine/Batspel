using Assets.State;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.UI {
    public class DialogCloseButton : MonoBehaviour
    {

        UIModel model = GameState.GetModel<UIModel>();

        public void OnButtonPress()
        {
            model.CloseUI();
        }
    }
}