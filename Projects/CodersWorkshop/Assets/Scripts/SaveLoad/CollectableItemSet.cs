using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//GameGrind - Advanced Saving Part 1


public class CollectibleItemSet : MonoBehaviour{
    public HashSet<string> CollectedItems {get; private set;} = new HashSet<string>();
}