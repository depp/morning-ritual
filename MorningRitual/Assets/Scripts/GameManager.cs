﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	private static GameManager instanceValue;

	/// <summary>
	/// Get the global GameManager instance.
	/// </summary>
	public static GameManager Instance {
		get {
			if (!instanceValue) {
				var objs = FindObjectsOfType<GameManager>();
				Debug.Assert(objs.Length == 1);
				instanceValue = objs[0];
			}
			return instanceValue;
		}
	}

	public delegate void Action();
	public event Action ScoreDidChange;
	private int scoreValue;
	public int Score {
		get { return this.scoreValue; }
		set {
			if (value != this.scoreValue) {
				this.scoreValue = value;
				this.ScoreDidChange.Invoke();
			}
		}
	}

	// Use this for initialization
	void Start () {
		this.Score = 0;
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnDestroy() {
		if (this == instanceValue) {
			instanceValue = null;
		}
	}
}
