using UnityEngine;
using System.Collections;

public class Interpreter : MonoBehaviour {
    //TODO: fix delimiting
    private char[] delimiters = [' ','[',']','{','}','(',')',';','+','-','=','/',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '];
    private string[] keywords = ["function", "for", "while", "int", "bool", "string", "flaot"];
    public string incode = ""
/*
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
*/
    string Parse (inCode){

        char[] inCodeArray = inCode.ToCharArray();

        for(int i = 0; i < inCodeArray.Length(); i++){
            char currChar = inCodeArray[i];

            //TODO: Parse Chars

        }


    }

}
