using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipPreview : MonoBehaviour
{

    Image shipImage;
    Sprite[] sprites;
    // Start is called before the first frame update
    void Start()
    {
        shipImage = GetComponent<Image>();
        sprites = Resources.LoadAll<Sprite>("Sprites/Ships");
    }

    public void ChangeShipPreview(int ship)
    {
        shipImage.sprite = sprites[ship];
    }
}
