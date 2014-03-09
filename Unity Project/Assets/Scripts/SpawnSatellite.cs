using UnityEngine;
using System.Collections;

public class SpawnSatellite : MonoBehaviour {

	public Rigidbody2D smallSatellite;
	public Rigidbody2D satellite;
	public Rigidbody2D largeSatellite;

    private int level; 
	private int maxSatellites;
	private int satelliteCount;

	private Timer timer;
	private double launchPeriod;

	void Start () {

		satelliteCount = 0;
		maxSatellites = 3;
		launchPeriod = 3.0;

		timer = new Timer (launchPeriod);
	}

	void Update () {
	

	}

	void FixedUpdate(){

		if (timer.nextCycle ()) {

			launchSatellite(satellite);
		}

	}

	void launchSatellite(Rigidbody2D currentSatellite){
	
		Rigidbody2D newSatellite = (Rigidbody2D)Instantiate (currentSatellite, transform.position, transform.rotation);
		newSatellite.velocity = newSatellite.GetComponent<SatelliteMove>().vel * 5;

		satelliteCount++;
	}
}