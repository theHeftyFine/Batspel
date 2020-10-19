using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Assets.State;
using Assets.UI;

public class HitRenderer : MonoBehaviour
{
    Collider2D interCollider;
    MeshRenderer highlightRenderer;
    UIModel model = GameState.GetModel<UIModel>();

    public Vector3 translate;
    public Material highlightMaterial;

    private void Start()
    {
        interCollider = GetComponent<Collider2D>();
        Mesh mesh = interCollider.CreateMesh(false, false);

        // Set up game object with mesh;
        var meshRenderer = gameObject.AddComponent<MeshRenderer>();
        meshRenderer.material = highlightMaterial;

        var filter = gameObject.AddComponent<MeshFilter>();
        filter.mesh = mesh;
        highlightRenderer = GetComponent<MeshRenderer>();
        highlightRenderer.enabled = false;
    }

    private void OnMouseEnter()
    {
        highlightRenderer.enabled = !model.open && true;
    }

    private void OnMouseExit()
    {
        highlightRenderer.enabled = false;
    }
}
