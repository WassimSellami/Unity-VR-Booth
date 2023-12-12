using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine;
using Unity.XR.CoreUtils;

public class movement : MonoBehaviour
{
   
    public XRNode inputSource;
    [SerializeField]
    private float speed;
    private XROrigin rig;
    private CharacterController character;
    private Vector2 inputAxis;

    void Start()
    {        
        rig = GetComponent<XROrigin>();
        character = GetComponent<CharacterController>();
    }

    void Update()
    {
        InputDevice device = InputDevices.GetDeviceAtXRNode(inputSource);
        device.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis);
        Debug.Log(inputAxis);
    }
    private void FixedUpdate()
    {
        Quaternion headYaw = Quaternion.Euler(0, rig.Camera.transform.eulerAngles.y, 0);
        Vector3 direction = headYaw * new Vector3(inputAxis.x, 0, inputAxis.y);
        character.Move(direction * speed * Time.deltaTime);
    }


}
