using UnityEditor;
using System.IO;

[InitializeOnLoad]
public class EditorController : EditorWindow
{
    static EditorController()
    {
        if (!Directory.Exists("Assets/Hyper Casyal Package"))
        {
            AssetDatabase.ImportPackage("Packages/com.hc_package.unitypackage/Editor/HC_Package.unitypackage", false);  //In real package
            //AssetDatabase.ImportPackage("Assets/HC_Package.unitypackage", false);   //To test
        }
    }
}