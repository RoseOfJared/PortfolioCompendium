using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablePadManager : MonoBehaviour
{
    [SerializeField]
    private GameObject collectablePrefab = null;
    [SerializeField]
    private List<Transform> spawnPoints = new List<Transform>(); 
    [SerializeField]
    private List<GameObject> collectPads = new List<GameObject>();
    [SerializeField]
    private List<CollectablePad> collectComponents = new List<CollectablePad>();
    [SerializeField]
    private List<Collectable> collectables = new List<Collectable>();

    private void Awake() {
        //Making sure we dont run into errors
        if(!(spawnPoints.Count == 0) && spawnPoints.Count == collectables.Count)
        {
            for(int i = 0; i < spawnPoints.Count; i++)
            {
                GameObject pad = Instantiate(collectablePrefab, spawnPoints[i].position, Quaternion.identity) as GameObject;
                collectPads.Add(pad);
                collectComponents.Add(pad.GetComponent<CollectablePad>());
                collectComponents[i].Init(collectables[i]);
            }
        } 
        //Make error messages to pinpoint problem? 
    }

    //TODO: Maybe handle collectable giving in here?

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
