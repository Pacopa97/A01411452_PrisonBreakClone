using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {
    MusicPlayer instance;
	// Use this for initialization
	void Start () {
        if (instance == null)
        {
            instance = new MusicPlayer();
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(instance);
        }
	}
	

}
