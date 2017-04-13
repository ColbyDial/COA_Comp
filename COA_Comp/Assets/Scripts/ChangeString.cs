using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeString : MonoBehaviour {
	public Text Sring;
	private int bus;
	// Use this for initialization
	void Start () {
		bus = 0;
		Sring.text = bus.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		Sring.text = bus.ToString();

		if (Input.GetKeyDown ("space")) {
			bus++;
		}
	}
}
