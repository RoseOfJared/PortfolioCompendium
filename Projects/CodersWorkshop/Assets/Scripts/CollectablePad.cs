using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablePad : MonoBehaviour
{
    public float height = 2f;
    public Vector3 rotationEulers = new Vector3(0, 30, 0);

    //This is the object inside the pad we will perform the movements on
    public GameObject collectablePrefab;
    public GameObject collectableHolder;
    public GameObject collectableObject;
    public GunInfo testGunInfo;
    private Vector3 _startingPosition;
    private bool isTaken = false;

    private void Start() {
        if(testGunInfo)
        {
            //testGunInfo.DebugGunInfo(); 
            collectableObject = Instantiate(testGunInfo.CollectablePrefab, collectableHolder.transform.position, Quaternion.identity);
            _startingPosition = collectableHolder.transform.position; 
        }     
    }

    // Update is called once per frame
    void Update()
    {
        if(!isTaken)
        {
            if(collectableObject)
            {
                float newY = Mathf.Sin(Time.time) / height;
                collectableObject.transform.position = _startingPosition + new Vector3(0, newY, 0);
                collectableObject.transform.Rotate(rotationEulers * Time.deltaTime);
            }   
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player" && isTaken == false)
        {
            //Move gun from collectableHolder to gunHolder
            Debug.Log("Gun acquired");
            Destroy(collectableObject);
            GameManager.Instance.GiveGun();
            isTaken = true;
        }
    }
}
