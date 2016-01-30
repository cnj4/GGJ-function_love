using UnityEngine;
using System.Collections;

public class Interpreter : MonoBehaviour {
    //TODO: fix delimiting
    private char[] delimiters = [' ','[',']','{','}','(',')',';','+','-','=','/'];
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
            
            if(String.Concat([currChar,
                              inCodeArray[i+1],
                              inCodeArray[i+2],
                              inCodeArray[i+3],
                              inCodeArray[i+4],
                              inCodeArray[i+5],
                              inCodeArray[i+6],
                              inCodeArray[i+7]) == "function"){

                //do stuff

                 }
            //TODO: Parse Chars

        }


    }

}
