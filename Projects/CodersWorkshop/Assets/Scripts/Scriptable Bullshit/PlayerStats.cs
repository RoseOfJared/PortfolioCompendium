using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New PlayerStats", menuName="Player Stats")]
public class PlayerStats : ScriptableObject
{
    [SerializeField]
    private string className;
    [SerializeField]
    private string description;
    [SerializeField]
    private Sprite icon;
    [SerializeField]
    private int startingGold;
    [SerializeField]
    private int physicalAttack;
    [SerializeField]
    private int magicalAttack;
}
