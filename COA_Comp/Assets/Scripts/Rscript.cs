using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Rscript : MonoBehaviour {
	public Toggle gra;
	public Toggle grb;
	public Toggle grc;

	public Text rtxt;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (gra.isOn) {
			rtxt.text = "a";
		} else {
			if (grb.isOn) {
				rtxt.text = "b";
			} else {
				if (grc.isOn) {
					rtxt.text = "c";
				} else {
					rtxt.text = "null";
				}
			}
		}
	}
		
}
