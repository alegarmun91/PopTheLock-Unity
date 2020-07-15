using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GameData))]
public class GameDataEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        
        GameData data = target as GameData;
        if (GUILayout.Button("Reset"))
        {
            if (data != null) data.ResetRunData();
        }
    }
}
