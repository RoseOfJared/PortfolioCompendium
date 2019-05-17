using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Class Info", menuName="Class Info")]
public class RPG_ClassInfo : ScriptableObject
{
    #region Member Variables
    [SerializeField]
    private string className = null;
    [SerializeField]
    private ClassType classType = ClassType.None;
    [SerializeField]
    private int healthPoints = 0;
    [SerializeField]
    private int magicPoints = 0;
    [SerializeField]
    private StrengthType strength = StrengthType.None;
    [SerializeField]
    private SpeedType speed = SpeedType.None;
    [SerializeField]
    private DifficultyType difficulty = DifficultyType.None;
    #endregion

    #region Getters
    public string ClassName
    {
        get
        {
            return className;
        }
    }
    public ClassType ClassType
    {
        get
        {
            return classType;
        }
    }
    public int HealthPoints
    {
        get
        {
            return healthPoints;
        }
    }
    public int MagicPoints
    {
        get
        {
            return magicPoints;
        }
    }
    public StrengthType Strength
    {
        get
        {
            return strength;
        }
    }
    public SpeedType Speed
    {
        get
        {
            return speed;
        }
    }
    public DifficultyType Difficulty
    {
        get
        {
            return difficulty;
        }
    }
    #endregion
}

public enum ClassType
{
    None,
    Tank,
    DPS,
    Support
}

public enum StrengthType
{
    None,
    Weak,
    Middling,
    Average,
    Strong,
    Buff
}

public enum SpeedType
{
    None,
    Slow,
    Average, 
    Fast
}

public enum DifficultyType
{
    None, 
    Easy,
    Normal,
    Hard,
    Impossible
}