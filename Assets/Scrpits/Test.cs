using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        XLua.LuaEnv luaEnv = new XLua.LuaEnv();
        luaEnv.DoString("CS.UnityEngine.Debug.Log('hello world')");
        luaEnv.Dispose();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
