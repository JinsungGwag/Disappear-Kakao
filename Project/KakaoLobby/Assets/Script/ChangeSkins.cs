using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSkins : MonoBehaviour {

    public Image[] imgs;

	public void Click () {
        imgs[0].gameObject.SetActive(true);
		for(int i=1; i<imgs.Length; i++)
        {
            imgs[i].gameObject.SetActive(false);
        }
	}
}
