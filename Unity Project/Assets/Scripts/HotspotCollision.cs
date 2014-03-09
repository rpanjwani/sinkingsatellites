using UnityEngine;
using System.Collections;

public enum HotspotState {city, inactiveHotspot, activeHotspot};

public class HotspotCollision : MonoBehaviour {

    public HotspotState state;

    public int health;

	void Start (){
	
	}
	
	void Update (){
	
	}

    void OnTriggerEnter2D(Collider2D otherCollider){

        SatelliteCollision satelliteCollision = otherCollider.gameObject.GetComponent<SatelliteCollision>();
        Stats stats = (GameObject.Find("Spawner")).GetComponent<Stats>();

        if (state == HotspotState.city){

            stats.Health = stats.Health - satelliteCollision.damage;
            if (stats.Health < 0) stats.Health = 0;

            // Change City Image
        }

        else if (state == HotspotState.activeHotspot){

            stats.Score += 100;
                
            // Change The Hotspot
        }
    }
}
