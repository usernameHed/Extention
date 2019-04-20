using UnityEngine;
using UnityEditor;

public class SceneViewCameraFunction : ScriptableObject
{
    public static void ViewportPanZoomIn(float zoom = 5f)
    {
        if (SceneView.lastActiveSceneView.size > zoom)
        {
            SceneView.lastActiveSceneView.size = zoom;
            //SceneView.lastActiveSceneView.pivot = ;
        }
        
        SceneView.lastActiveSceneView.Repaint();
    }
}