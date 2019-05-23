using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;
    GameObject player;
    GameObject gunHolder;
    private InventoryHandler inventory = null;

    private void Awake() {
        if(Instance == null)
        {
            Instance = this;
        }
        else if(Instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        gunHolder = player.transform.GetChild(0).GetChild(0).gameObject;

        //Set Inventory Manager on here
        inventory = this.gameObject.AddComponent(typeof(InventoryHandler)) as InventoryHandler;
        //Debug.Log("Inventory handler set");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Gonna make this a hell of a lot more complex, boy howdee
    public void GiveGun(GameObject gunPrefab, Collectable gunInfo)
    {
        //Check to see if player has the gun
        if(inventory.CompareGun((GunInfo)gunInfo))
        {
            //Else, give reserve ammo for player
            //TODO: give player ammo reserves
            Debug.Log("Ammo should be added to reserves");
        }
        else
        {
            //TODO: if gun isnt the same, overwrite the current one with the new one
            //if they dont, instantiate and give them it
            GameObject newGun = Instantiate(gunPrefab, gunHolder.transform.position, Quaternion.identity, gunHolder.transform) as GameObject;
            inventory.SetEquippedGun(newGun, (GunInfo)gunInfo);
        }
    }

    //Create interface to handle Collectable type
    public void GiveCollectable(GameObject prefab, CollectableType type)
    {
        //switch(type)
        //{
            //case CollectableType.Gun:
                //GiveGun(prefab, type);
                //break;
            //case CollectableType.Coin:
                //break;
        //}
    }
}
