using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Vector2 _mouseAbsolute;
    Vector2 _mouseSmooth;

    public Vector2 clampInDegrees = new Vector2(360, 180);
    public bool lockCursor;
    public Vector2 sensitivity = new Vector2(2,2);
    public Vector2 smoothing = new Vector2(3,3);
    public Vector2 targetDirection;
    public Vector2 targetCharacterDirection;

    public GameObject characterBody;

    Vector2 rotation = Vector2.zero;
    public float turnSpeed = 3;

    // Start is called before the first frame update
    void Start()
    {
        targetDirection = transform.localRotation.eulerAngles;

        if(characterBody)
            targetCharacterDirection = characterBody.transform.localRotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        rotation.y += Input.GetAxis("Mouse X");
        rotation.x += -Input.GetAxis("Mouse Y");
        rotation.x = Mathf.Clamp(rotation.x, -15f, 15f);

        transform.eulerAngles = new Vector2(0, rotation.y)* turnSpeed;
        Camera.main.transform.localRotation = Quaternion.Euler(rotation.x * turnSpeed, 0, 0);
        */
        if(lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        var targetOrientation = Quaternion.Euler(targetDirection);
        //var target

    }
}
