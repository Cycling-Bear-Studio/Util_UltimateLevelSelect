using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EditorController : EditorWindow
{
    [MenuItem("Example/Display simple Window")]
    static void Initialize()
    {
        //EditorWindowTest window = (EditorWindowTest)EditorWindow.GetWindow(typeof(EditorWindowTest), true, "My Empty Window");
    }
}