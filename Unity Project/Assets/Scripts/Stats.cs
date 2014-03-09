using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour {

    public int score;
    public int health;

    public int Score {

        set { score = value; }
        get { return score; }      
    }

    public int Health {

        set { health = value;}
        get { return health; }
    }

    void Start(){

        score = 0;
        health = 100;
    }

    void Update(){
    
    
    }
}