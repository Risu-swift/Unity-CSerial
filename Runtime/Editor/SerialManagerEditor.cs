using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

[CustomEditor(typeof(SerialManager))]
public class SerialManagerEditor : Editor
{
    private SerialManager serialManager;
    private SerialPortHandler serialPortHandler;
    private bool isMonitoring = false;
    private string receivedData = "";
    private Vector2 scrollPosition;
    private bool autoScroll = true;
    private string messageToSend = "";
    private bool showEvents = false; // Track foldout state

    private void OnEnable()
    {
        serialManager = (SerialManager)target;
    }

    private void OnDisable()
    {
        StopMonitoring();
    }

    public override void OnInspectorGUI()
    {
        GUILayout.Space(5); // Add space above the header
        EditorGUILayout.LabelField("Serial Port Settings", EditorStyles.boldLabel);
        

        serialManager.SetPortName(EditorGUILayout.TextField("Port Name", serialManager.GetPortName()));
        serialManager.SetBaudRate(EditorGUILayout.IntField("Baud Rate", serialManager.GetBaudRate()));
        GUILayout.Space(10); // Add space above the new header

        // Foldout for events
        showEvents = EditorGUILayout.Foldout(showEvents, "Events");
        if (showEvents)
        {
            GUILayout.Space(10); // Add space above the new header

            // Add event-related code here
            SerializedProperty onDataReceivedProperty = serializedObject.FindProperty("onDataReceived");
            EditorGUILayout.PropertyField(onDataReceivedProperty);

            SerializedProperty onConnectionStatusChangedProperty = serializedObject.FindProperty("onConnectionStatusChanged");
            EditorGUILayout.PropertyField(onConnectionStatusChangedProperty);
        }
        GUILayout.Space(10); // Add space above the new header

        if (GUILayout.Button(isMonitoring ? "Stop Monitoring" : "Start Monitoring"))
        {
            if (isMonitoring)
            {
                StopMonitoring();
            }
            else
            {
                StartMonitoring();
            }
        }

        if (isMonitoring)
        {
            GUILayout.Space(10); // Add space above the new header

            // Create a GUIStyle for the monitoring section
            GUIStyle monitorStyle = new GUIStyle(GUI.skin.box);
            monitorStyle.normal.background = MakeTex(2, 2, new Color(0.15f, 0.15f, 0.15f, 1.0f));
            monitorStyle.padding = new RectOffset(10, 10, 10, 10);

            EditorGUILayout.BeginVertical(monitorStyle);

            GUILayout.Space(10); // Add space above the header
            EditorGUILayout.LabelField("Serial Monitor", EditorStyles.boldLabel);

            // Create a GUIStyle for the box
            GUIStyle boxStyle = new GUIStyle(GUI.skin.box);
            boxStyle.normal.background = MakeTex(2, 2, new Color(0.2f, 0.2f, 0.2f, 1.0f));
            boxStyle.normal.textColor = Color.white;
            boxStyle.wordWrap = true;
            boxStyle.alignment = TextAnchor.UpperLeft; // Left align text

            // Add a scroll view with fixed box size (75% of inspector width)
            float boxWidth = EditorGUIUtility.currentViewWidth * 0.95f;
            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, GUILayout.Width(boxWidth), GUILayout.Height(150), GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true));
            EditorGUILayout.TextArea(receivedData, boxStyle, GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true));
            EditorGUILayout.EndScrollView();

            // Horizontal layout for TextField and Button
            EditorGUILayout.BeginHorizontal();
            messageToSend = EditorGUILayout.TextField(messageToSend, GUILayout.ExpandWidth(true));
            if (GUILayout.Button("Send", GUILayout.Width(50)))
            {
                if (serialPortHandler != null && serialPortHandler.isConnected)
                {
                    serialPortHandler.Write(messageToSend);
                    messageToSend = ""; // Clear the text field after sending
                    GUI.FocusControl(null); // Remove focus from the text field to update it
                }
                else
                {
                    Debug.LogWarning("Serial port handler is not initialized or not connected");
                }
            }
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.Space(10); // Add space below the horizontal layout

            // Header for Serial Monitor Options
            EditorGUILayout.LabelField("Serial Monitor Options", EditorStyles.boldLabel);

            // Toggle for auto scroll
            autoScroll = EditorGUILayout.Toggle("Auto Scroll", autoScroll);

            EditorGUILayout.EndVertical();
        }



        serializedObject.ApplyModifiedProperties();
    }

    private void StartMonitoring()
    {
        isMonitoring = true;
        serialPortHandler = new SerialPortHandler(serialManager.GetPortName(), serialManager.GetBaudRate());
        serialPortHandler.listener.OnDataReceived += OnDataReceived;
        serialPortHandler.Connect();
        EditorApplication.update += OnEditorUpdate;
    }

    private void StopMonitoring()
    {
        if(!isMonitoring)
        {
            return;
        }
        isMonitoring = false;
        serialPortHandler.Stop();
        serialPortHandler.listener.OnDataReceived -= OnDataReceived;
        EditorApplication.update -= OnEditorUpdate;
        receivedData = "";
    }

    private void OnDataReceived(string data)
    {
        receivedData += data + "\n";
        if (autoScroll)
        {
            scrollPosition.y = float.MaxValue;
        }
    }

    private void OnEditorUpdate()
    {
        Repaint();
    }

    private Texture2D MakeTex(int width, int height, Color col)
    {
        Color[] pix = new Color[width * height];
        for (int i = 0; i < pix.Length; i++)
        {
            pix[i] = col;
        }
        Texture2D result = new Texture2D(width, height);
        result.SetPixels(pix);
        result.Apply();
        return result;
    }
}