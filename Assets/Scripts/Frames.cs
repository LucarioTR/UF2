using UnityEngine;

public class FrameCounter : MonoBehaviour
{
    [SerializeField] private int interval = 60;
    private int frameCount = 0;

    void Update()
    {
        frameCount++;

        if (frameCount % interval == 0)
        {
            Debug.Log($"Han passat {frameCount} frames en total.");
        }
    }
}