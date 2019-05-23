using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collectable : ScriptableObject
{
    [Header("Collectable Variables")]
    [SerializeField]
    private GameObject collectablePrefab = null;
    [SerializeField]
    private CollectableType type = CollectableType.None;

    public GameObject CollectablePrefab
    { 
        get { return collectablePrefab; }
    }

    public CollectableType Type{
        get{return type;}
    }
}

public enum CollectableType
{
    Gun,
    Coin,
    None
}
