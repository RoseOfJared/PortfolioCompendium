using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collectable : ScriptableObject
{
    [Header("Collectable Variables")]
    [SerializeField]
    private GameObject collectablePrefab = null;

    public GameObject CollectablePrefab
    { 
        get {
            return collectablePrefab;
            }
    }
}
