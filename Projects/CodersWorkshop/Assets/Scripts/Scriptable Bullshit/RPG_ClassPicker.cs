using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RPG_ClassPicker : MonoBehaviour
{
    [SerializeField]
    private Text className = null;
    [SerializeField]
    private Text classType = null;
    [SerializeField]
    private Text healthPoints = null;
    [SerializeField]
    private Text magicPoints = null;
    [SerializeField]
    private Text strength = null;
    [SerializeField]
    private Text speed = null;
    [SerializeField]
    private Text difficulty = null;

    public void UpdateDisplayUI(RPG_ClassInfo classInfo)
    {
        className.text = "<b>Class Name: </b>" + classInfo.ClassName;
        classType.text = "<b>Class Type: </b>" + classInfo.ClassType.ToString();
        healthPoints.text = "<b>Health Points: </b>" + classInfo.HealthPoints.ToString();
        magicPoints.text = "<b>Magic Points: </b>" + classInfo.MagicPoints.ToString();
        strength.text = "<b>Strength: </b>" + classInfo.Strength.ToString();
        speed.text = "<b>Speed: </b>" + classInfo.Speed.ToString();
        difficulty.text = "<b>Difficulty: </b>" + classInfo.Difficulty.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
