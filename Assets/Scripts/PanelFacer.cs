using UnityEngine;

public class PanelFacer : MonoBehaviour
{
    private Camera VRCamera;
    private void Start()
    {
        VRCamera = Camera.main;
    }
    void Update()
    {
        // Get the direction from the panel to the VR camera
        Vector3 direction = VRCamera.transform.position - transform.position;

        // Rotate the panel to face the VR camera
        transform.rotation = Quaternion.LookRotation(direction*-1);
    }
}