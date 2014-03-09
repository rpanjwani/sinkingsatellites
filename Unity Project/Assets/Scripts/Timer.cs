using UnityEngine;
using System.Collections;

public class Timer {

	private double period;
	private double previousTime;
	private double currentTime;
	private double delta;

    #region
    public double Delta
    {

        get
        {
            return delta;
        }
    }

    public double Period
    {

        get
        {
            return period;
        }

        set
        {
            period = value;
        }
    }
    #endregion

	public Timer(){}

	public Timer(double period){

		this.period = period;
		this.previousTime = (double)(-1 * period);
	}

	public bool nextCycle(){
			
		currentTime = Time.time;
		delta = (currentTime - previousTime);

		if(delta >= period){

			previousTime = currentTime;
			return true;
		}

		return false;
	}
}