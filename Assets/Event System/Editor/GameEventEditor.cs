using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GameEvent))]
public class GameEventEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.enabled = Application.isPlaying;
        
        GameEvent e = target as GameEvent;
        if (GUILayout.Button("Raise"))
        {
            if (e != null) e.Raise();
        }
    }
}
