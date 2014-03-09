using UnityEngine;
using System.Collections;

public class SatelliteCollision : MonoBehaviour {

    public int damage;

    void OnTriggerEnter2D(Collider2D otherCollider){

        HotspotCollision hotspotCollision = otherCollider.gameObject.GetComponent<HotspotCollision>();

        if(hotspotCollision.state == HotspotState.city){
            
            // Satellite Destruction Animation
            Destroy(gameObject);
        }

        else if(hotspotCollision.state == HotspotState.inactiveHotspot){
    
            rigidbody2D.velocity = new Vector2(-1 * rigidbody2D.velocity.x, rigidbody2D.velocity.y);
        }

        else if(hotspotCollision.state == HotspotState.activeHotspot){
            
            Destroy(gameObject);
        }
    }
}
