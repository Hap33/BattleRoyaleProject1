using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class CheckPlayers : MonoBehaviour {
    public static CheckPlayers Singleton;
    //public int PlayerNmb;
    public Text Players;

    private void Awake()
    {
        if (Singleton != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Singleton = this;
        }
        
    }

    /*private void Start()
    {
        PlayerNmb = NetworkServer.connections.Count;
    }*/

    private void Update()
    {
        Players.text = "joueurs restants :  : " + NetworkServer.connections.Count;
    }
}
