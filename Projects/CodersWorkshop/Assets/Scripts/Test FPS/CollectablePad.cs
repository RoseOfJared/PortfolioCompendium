using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablePad : MonoBehaviour
{
    public float height = 2f;
    public Vector3 rotationEulers = new Vector3(0, 30, 0);
    public float respawnDelay = 5.0f;

    //This is the object inside the pad we will perform the movements on
    public GameObject collectableHolder;
    private GameObject collectableObject;
    public Collectable collectable;
    private Vector3 _startingPosition;
    private bool isTaken = false;

    private void Start() {
        if(collectable)
        {
            collectableObject = Instantiate(collectable.CollectablePrefab, collectableHolder.transform.position, Quaternion.identity);
            _startingPosition = collectableHolder.transform.position; 
        }     
    }

    public void Init(Collectable collect)
    {
        collectable = collect;
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
            //TODO: Make collectable acquisition more generic
            GameManager.Instance.GiveGun(collectable.CollectablePrefab, collectable);
            isTaken = true;
            Invoke("SpawnCollectable", respawnDelay);
        }
    }

    void SpawnCollectable()
    {
        collectableObject = Instantiate(collectable.CollectablePrefab, collectableHolder.transform.position, Quaternion.identity);
        _startingPosition = collectableHolder.transform.position; 
        isTaken = false;
    }
}
