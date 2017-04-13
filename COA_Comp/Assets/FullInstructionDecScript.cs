using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FullInstructionDecScript : MonoBehaviour {
	public Text instruction;
	private string instructString;
	public Text decVersion;
	public int dec;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		instructString = instruction.text;
		dec = int.Parse (instructString, System.Globalization.NumberStyles.HexNumber);
		decVersion.text = dec.ToString ();
	}
}
