using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Source link: https://twitter.com/BinaryImpactG/status/1128244218940592129

public class SimpleRotate : MonoBehaviour
{
    public Vector3 Pivot; //rotate around this point in local space

    public bool RotateX;
    public bool RotateY;
    public bool RotateZ;

    public float rotationSpeed; //negative for direction change
    public bool isMoving;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isMoving)
        {
            transform.position += (transform.rotation * Pivot);

            Vector3 rotationVector = new Vector3(RotateX ? 1f : 0f, RotateY ? 1f : 0f, RotateZ ? 1f : 0f);
            transform.rotation *= Quaternion.AngleAxis(rotationSpeed * Time.fixedDeltaTime, rotationVector);

            transform.position -= (transform.rotation * Pivot);

            Vector3 rot = transform.rotation.eulerAngles;

            transform.rotation = Quaternion.Euler(new Vector3(rot.x % 360f, rot.y % 360f, rot.z % 360f));
        }
    }
}
