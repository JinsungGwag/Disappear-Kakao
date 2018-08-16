using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exact_Hit : MonoBehaviour {

	// Use this for initialization
	void Start () {

        GetComponent<Image>().alphaHitTestMinimumThreshold = 0.1f;

	}
	
}
