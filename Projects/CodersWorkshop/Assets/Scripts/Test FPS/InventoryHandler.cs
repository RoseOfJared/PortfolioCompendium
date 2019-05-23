using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Handles player inventory, and will handle gun stuff for the time being
public class InventoryHandler : MonoBehaviour
{
    public GameObject equippedGun = null;
    [SerializeField]
    private GunInfo equippedGunInfo = null;
    [SerializeField]
    private PlayerInfo playerInfo = null;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Indeed, inventory is set!");
        playerInfo = new PlayerInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetEquippedGun(GameObject newGun, GunInfo gunInfo)
    {
        equippedGun = newGun;
        equippedGunInfo = gunInfo;
    }

    public bool CompareGun(GunInfo newInfo)
    {
        if(equippedGun == null)
            return false;
        else if(equippedGunInfo.GunName == newInfo.GunName)
            return true;
        
        return false;
    }
}

//TODO: Expand PlayerInfo class with more pertinent info
public class PlayerInfo
{
    public int ammoReserves = 10;
    public int currentMag = 5;
} 