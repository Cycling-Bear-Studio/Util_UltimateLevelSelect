using UnityEngine;
using UnityEditor;
using System.IO;

[InitializeOnLoad]
public class EditorController : EditorWindow
{
    private bool packageDownloaded;
    private static EditorController window;

    static EditorController()
    {
        window = (EditorController)GetWindow(typeof(EditorController));
    }

    private void OnGUI()
    {
        packageDownloaded = Directory.Exists("Assets/Hyper Casyal Package");
        EditorController window = (EditorController)GetWindow(typeof(EditorController));

        if (!packageDownloaded)
        {
            window.Show();
            GUILayout.BeginVertical(EditorStyles.helpBox);
            {
                GUILayout.Label("To start working with HC_Package files, you need to import them into the project.", EditorStyles.boldLabel);
                GUILayout.Space(5f);

                if (GUILayout.Button("Import"))
                {
                    AssetDatabase.ImportPackage("Packages/HC_Package/Editor/HC_Package.unitypackage", false);  //In real package
                    //AssetDatabase.ImportPackage("Assets/HC_Package.unitypackage", false);   //To test

                    window.Close();
                }
                GUILayout.Space(5f);
            }
            GUILayout.EndVertical();
        }
        else
        {
            window.Close();
        }
    }
}