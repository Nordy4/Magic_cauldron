using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;
    public bool player1Grabbing = false;
    public bool player2Grabbing = false;
    
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    public bool get_player1Grabbing(){
        return player1Grabbing;
    }

    public bool get_player2Grabbing(){
        return player2Grabbing;
    }

    public void set_player1Grabbing(bool grab){
        this.player1Grabbing = grab;
    }

    public void set_player2Grabbing(bool grab){
        this.player2Grabbing = grab;
    }

}
