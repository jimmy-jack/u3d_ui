using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Expand_func {

	[MenuItem("Assets/My Tools/Tools 1",false,2)]    static void MyTools1()    {        Debug.Log("MyTools1");    }    [MenuItem("Assets/My Tools/Tools 2",false,1)]    static void MyTools2()    {        Debug.Log(Selection.activeObject.name);    }

    //拓展布局，按键
    //[InitializeOnLoadMethod]
    //static void InitializeOnLoadMethod()
    //{
    //    EditorApplication.projectWindowItemOnGUI = delegate (string guid, Rect selectionRect) {    //     //…略    //    if (GUI.Button(selectionRect, "click"))    //    {    //        Debug.LogFormat("click : {0}", Selection.activeObject.name);    //    }    //   };
    //}
}
