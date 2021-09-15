using UnityEngine;
using UnityEditor;

public class EditorWindowController : EditorWindow
{
    [MenuItem("HC_Package/Import files")]
    static void Init()
    {
        EditorWindowController window = (EditorWindowController)EditorWindow.GetWindow(typeof(EditorWindowController));
        window.Show();
    }

    void OnGUI()
    {
        GUILayout.Label("To start working with HC_Package files, you need to import them into the project.", EditorStyles.label);

        if(GUILayout.Button("Import"))
        {
            AssetDatabase.ImportPackage("Packages/HC_Package/Editor/Scripts/HC_Package.unitypackage", false);
            //AssetDatabase.ImportPackage("Assets/HC_Package.unitypackage", false);
        }
    }
}