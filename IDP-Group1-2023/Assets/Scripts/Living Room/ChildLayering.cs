using UnityEngine;

public class ChildLayering : MonoBehaviour
{
    public string sortingLayerName;

    void Start()
    {
        Renderer[] childRenderers = GetComponentsInChildren<Renderer>();
        foreach (Renderer renderer in childRenderers)
        {
            renderer.sortingLayerName = sortingLayerName;
        }
    }
}