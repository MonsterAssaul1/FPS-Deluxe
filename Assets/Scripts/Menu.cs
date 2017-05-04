using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Menu : MonoBehaviour {
 	public bool menuScreen;
 	public string input;
 	public bool level;
 	public Controll cc;
	// Use this for initialization
	void Start () {
		cc = GetComponent<Controll>();
				level = true;
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnGUI() //Keypad som man skapar inom kod
    {
        	if (level)
            {
            	GUI.Box(new Rect(0, 0, 200, 25), "Press 'Esc' to open the menu"); //En låda som kommer fram när man trycker på e
                if(Input.GetKeyDown(KeyCode.Escape)) //Ifall man trycker på e
                { 
                	cc.enabled = false;
                    menuScreen = true; //Keypaden kommer fram
                    Cursor.visible = true;
                }
            }
 
            if(menuScreen) //Koden för keypaden
            { 

            	 GUI.Box(new Rect(515, 0, 320, 455), "");
                if (GUI.Button(new Rect(550, 35, 250, 50), "Resume")){
                	menuScreen = false;
					cc.enabled = true;
					Cursor.visible = false;

               	}
              
				if  (GUI.Button(new Rect(550, 100, 250, 50), "Connect")){
                	return;
               	}
 
                if (GUI.Button(new Rect(550, 245, 250, 50), "Quit")){ 
                	Application.LoadLevel (Application.loadedLevel);
               	}
               	GUI.Box(new Rect(550, 300, 250, 50), "Game Menu");
 
                
            }
        
    }
}
