// Update MainThreadDispatcher.cs
using System;
using System.Collections.Concurrent;
using UnityEngine;

public class MainThreadDispatcher : MonoBehaviour
{
    private static readonly ConcurrentQueue<Action> _executionQueue = new ConcurrentQueue<Action>();

    void Awake()
    {
        ApplicationState.IsPlaying = Application.isPlaying;
    }

    void OnDestroy()
    {
        ApplicationState.IsPlaying = false;
    }

    public void Update()
    {
        while (_executionQueue.TryDequeue(out var action))
        {
            action?.Invoke();
        }
    }

    public static void Enqueue(Action action)
    {
        if (action == null)
        {
            throw new ArgumentNullException(nameof(action));
        }

        _executionQueue.Enqueue(action);
    }
}

// Create ApplicationState.cs
public static class ApplicationState
{
    public static bool IsPlaying { get; set; }
}