using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPG_Class : MonoBehaviour
{
    //[SerializeField]
    //private RPG_ClassInfo classInfo;
    [SerializeField]
    private GameEvent OnClassSelected = null; 

    private void OnMouseDown()
    {
        /*
            Debug.Log(classInfo.ClassName);
            Debug.Log(classInfo.ClassType.ToString());
            Debug.Log(classInfo.HealthPoints);
            Debug.Log(classInfo.MagicPoints);
            Debug.Log(classInfo.Strength.ToString());
            Debug.Log(classInfo.Speed.ToString());
            Debug.Log(classInfo.Difficulty.ToString());
        */
        OnClassSelected.Raise();
    }

}
