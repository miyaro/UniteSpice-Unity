using UnityEngine;

public class SimpleSingleTone<T> : MonoBehaviour where T : SimpleSingleTone<T>
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance != null) return instance;

            var type = typeof(T);
            instance = FindObjectOfType(type) as T;
            return instance;
        }
    }

    private void OnDestroy()
    {
        instance = null;
    }
}