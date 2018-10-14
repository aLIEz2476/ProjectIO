using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkManager : Photon.MonoBehaviour {
    Player m_SetPlayer; GUIPlayer m_SetGUI;
	// Use this for initialization
	void Start () {
        m_SetPlayer = GameManager.GetInstance().m_cPlayer;
        m_SetGUI = GameManager.GetInstance().m_cGUIPlayer;
	}
	

	// Update is called once per frame
	void Update () {
		


	}
}
