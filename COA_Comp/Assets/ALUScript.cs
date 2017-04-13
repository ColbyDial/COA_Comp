using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ALUScript : MonoBehaviour {
	static public int ALUVal;
	public Text ALUtxt;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ALUtxt.text = ("ALU " + ALUVal.ToString ());
	}

	public int getALUVal(){
		return ALUVal;
	}
}
