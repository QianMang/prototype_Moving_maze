using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty_control : MonoBehaviour {
    public enum Difficulty{
        first_time=1,
        easy=2,
        hard=3,
        Challenger = 4,
    }
    public Difficulty difficulty = new Difficulty();
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
