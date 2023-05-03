using UnityEngine;
using UnityEditor;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Reflection;

public class FixerSetup: EditorWindow
{
        [MenuItem("Custom Menu/FixerSetup")]
        public static void ShowWindow()
        {
            GetWindow<FixerSetup>("FixerSetup");
        }

        private void OnGUI()
        {
            
        }

        private void OnInspectorUpdate()
        {
            
        }

        // Call to create a thin dividing line between Editor UI elements
        void GuiLine()
        {
            Rect rect = EditorGUILayout.GetControlRect(false, 1);
            rect.height = 1;
            EditorGUI.DrawRect(rect, new Color(0.5f, 0.5f, 0.5f, 1));
        }
}