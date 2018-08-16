using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

    public void GoCapsule()
    {
        SceneManager.LoadScene("Capsule");
    }

	public void GoCombine()
    {
        SceneManager.LoadScene("Combine");
    }

}
