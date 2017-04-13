using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class resetClock : MonoBehaviour {
	public Text clock;
	private ClockScript _clock;


	// Use this for initialization
	void Start () {
		_clock = clock.GetComponent<ClockScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ResetClock(){
		_clock.clearClock();
		Debug.Log ("Reseting Clock");
	}
}
