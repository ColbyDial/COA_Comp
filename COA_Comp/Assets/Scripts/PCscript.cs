using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PCscript : MonoBehaviour {


	static public int pcVal = 0;
	public Text pctxt;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {



		pctxt.text = "PC " + pcVal.ToString();
	}

	public int getPCVal(){
		return pcVal;
	}
}
