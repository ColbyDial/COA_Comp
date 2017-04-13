using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClockScript : MonoBehaviour {
	public int clockVal = 0;

	public Text clock;
	// Use this for initialization
	void Start () {
		clock.text = "Clock: " + clockVal.ToString ();

	}
	
	// Update is called once per frame
	void Update () {
		clock.text = "Clock: " + clockVal.ToString ();

	}

	public void incClock(){
		clockVal++;
	}

	public void clearClock(){
		clockVal = 0;
	}
	public int getClockVal(){
		return clockVal;
	}
}
