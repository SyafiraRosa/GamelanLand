using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(RoomManager))]
public class RoomManagerEditorScript : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        EditorGUILayout.HelpBox("THis Script is responsible for creating and joining room", MessageType.Info);

        RoomManager roomManager = (RoomManager)target;
        if (GUILayout.Button("Join Sanggar"))
        {
            roomManager.OnEnterButtonClicked_Sanggar();
        }
    }
}
