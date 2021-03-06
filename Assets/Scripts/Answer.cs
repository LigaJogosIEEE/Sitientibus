﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Answer : MonoBehaviour {

	InputField iField;
	string answer;
	public GameObject wrong;

	void Start(){
		iField = GetComponent<InputField>();
	}
     
    public void VerifyAnswer()
    {
		answer = iField.text.ToLower();
		wrong.SetActive(false);

		if(answer.Contains("anarquia") && answer.Contains("sexo")) {
			SceneManager.LoadScene(2);
		} 
		else if(answer.Contains("breaking bad") && answer.Contains("game of thrones") && answer.Contains("chico")){
			SceneManager.LoadScene(3);
		}
		else if(answer.Contains("mundo maldito")) {
			SceneManager.LoadScene(4);
		}
		else {
			wrong.SetActive(true);
		}
    }

}
