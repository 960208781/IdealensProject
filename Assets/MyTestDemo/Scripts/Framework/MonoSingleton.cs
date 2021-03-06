using UnityEngine;
using System.Collections;

/// <summary>
/// Mono单例类
/// </summary>
public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
	private static T instance;

	public static T Instance {
		get {
			if (instance == null) {
				GameObject obj = new GameObject (typeof(T).Name);
				instance = obj.AddComponent<T> ();
			}
			return instance;
		}
	}

	protected virtual void  Awake ()
	{
		instance = this as T;
	}
}
