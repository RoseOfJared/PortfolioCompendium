using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;
    public GameObject gunPrefab;
    GameObject player;
    GameObject gunHolder;

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
        Debug.Log("Player Acquired");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GiveGun()
    {
        //Give the player the gun
        Instantiate(gunPrefab, gunHolder.transform.position, Quaternion.identity, gunHolder.transform);
    }
}
