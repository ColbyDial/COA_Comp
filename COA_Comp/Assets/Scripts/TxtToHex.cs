using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TxtToHex : MonoBehaviour {
	public Text fromText;
	public Text toText;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		toText.text = busScript.busVal.ToString ("X");
	}
}
