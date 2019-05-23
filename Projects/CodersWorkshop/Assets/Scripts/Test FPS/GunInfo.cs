using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO: Create Collectable class, have GunInfo inherit from it
[CreateAssetMenu(fileName="New Gun Info", menuName="Test FPS/Gun Info")]
public class GunInfo : Collectable
{
    [Header("GunInfo Variables")]
    [SerializeField]
    private string gunName = string.Empty;
    [SerializeField]
    private int damage = 0;
    [SerializeField]
    private float fireRate = 0;
    [SerializeField]
    private int magazineSize = 0;
    [SerializeField]
    private int reserveAmmo = 0;
    [SerializeField]
    private float reloadSpeed = 0;
    [SerializeField]
    private AmmoRarityType ammoRarity = AmmoRarityType.Common;

    #region public getters

    public string GunName
    {
        get{return gunName;}
    }
    public int Damage
    {
        get{return damage;}
    }
    public float FireRate
    {
        get{return fireRate;}
    }
    public int MagazineSize
    {
        get{return magazineSize;}
    }
    public int ReserveAmmo
    {
        get{return reserveAmmo;}
    }
    public float ReloadSpeed
    {
        get{return reloadSpeed;}
    }
    public AmmoRarityType AmmoRarity
    {
        get{return ammoRarity;}
    }

    #endregion
    //Purely to make sure everything is up to board
    public void DebugGunInfo()
    {
        Debug.Log("Gun Name: " + gunName);
        Debug.Log("Damage: " + damage.ToString());
        Debug.Log("Fire Rate: " + fireRate.ToString());
        Debug.Log("magazineSize: " + magazineSize.ToString());
        Debug.Log("Reserve Ammo: " + reserveAmmo.ToString());
        Debug.Log("Reload Speed: " + reloadSpeed.ToString());
        Debug.Log("Ammo Rarity: " + ammoRarity.ToString());
    }
}

public enum AmmoRarityType
{
    Common,
    Uncommon,
    Rare,
    Scarce
}
