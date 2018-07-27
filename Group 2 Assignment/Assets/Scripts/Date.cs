using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Date : MonoBehaviour {
   public  Text text;
    
	void Start ()
    {
        DateTime date = DateTime.Now;
        print(DateTime.Now);
        text.text = DateTime.Today.Date.ToString("yyyy/MM/dd");
    }
	


}
