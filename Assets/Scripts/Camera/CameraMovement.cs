using Assets.State;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;

[RequireComponent(typeof(Camera))]
public class CameraMovement : MonoBehaviour
{
    Camera cam;
    Grid map;
    Tilemap tm;

    public GameObject dockPanel;

    [SerializeField]
    int scrollArea = 10;

    [SerializeField]
    [Range(1, 50)]
    float scrollSpeed;

    void OnEnable()
    {
        if (cam == null)
        {
            cam = GetComponent<Camera>();
        }
        if (map == null)
        {
            map = FindObjectOfType<Grid>();
            Tilemap[] tilemaps = map.GetComponentsInChildren<Tilemap>();

            tm = tilemaps.ToList().Find((t) => t.name == "Buildings");
        }
    }

    void Update()
    {
        var mPosX = Input.mousePosition.x;
        var mPosY = Input.mousePosition.y;

        if (mPosX < scrollArea) cam.transform.Translate(Vector3.right * -scrollSpeed * Time.deltaTime);
        if (mPosX >= Screen.width - scrollArea) cam.transform.Translate(Vector3.right * scrollSpeed * Time.deltaTime);
        if (mPosY < scrollArea) cam.transform.Translate(Vector3.up * -scrollSpeed * Time.deltaTime);
        if (mPosY >= Screen.height - scrollArea) cam.transform.Translate(Vector3.up * scrollSpeed * Time.deltaTime);

        if (Input.mouseScrollDelta.y != 0)
        {
            float scroll = Input.mouseScrollDelta.y;
            cam.orthographicSize -= scroll*scrollSpeed*Time.deltaTime;
            cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, 0.5f, 45f);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouse = Input.mousePosition;
            Vector3 clickpos = cam.ScreenToWorldPoint(mouse);

            var tile = tm.GetTile(Vector3Int.FloorToInt(clickpos));
            //if(tile != null)
            //{
                //GameState.GetModel<UIModel>().OpenPanel(dockPanel);
            //}
        }
    }
}
