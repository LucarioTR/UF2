using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color newColor = Color.red;

    void Awake()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        if (meshRenderer != null)
        {
            meshRenderer.material.color = newColor;
        }
        else
        {
            Debug.LogWarning("No s'ha trobat cap MeshRenderer en aquest GameObject.");
        }
    }
}