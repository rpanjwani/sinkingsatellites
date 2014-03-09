using UnityEngine;
using System;

public class HotspotMove : MonoBehaviour {

    public Vector2 velocity;

    void Start () {

        rigidbody2D.velocity = this.velocity;
	}
	
	void Update () {
	
	}

    void FixedUpdate(){

        Vector2 velocity = rigidbody2D.velocity;
        Vector3 position = rigidbody2D.transform.position;
        position = new Vector3(position.x, (float) Math.Abs(position.y), position.z);

        if(velocity.y != 0){
            
            if((position.y > 0 && position.y <= 3.5) || (position.y >= 9.3 && position.y < 9.8)){
                
                rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, -1 * rigidbody2D.velocity.y);
            }
        }
    }
}