using UnityEngine;
using System.Collections;

/// <summary>
/// 资源管理类
/// </summary>
public class ResourcesMgr : Singleton<ResourcesMgr>
{
	public T Load<T> (object enumName) where T:Object
	{
		string enumType = enumName.GetType ().Name;

		string filePath = string.Empty;

		switch (enumType) {
			case "Main":
				{
					filePath = "Music/Main/" + enumName.ToString ();
					break;
				}
			case "Feeds":
				{
					filePath = "Music/Feeds/" + enumName.ToString ();
					break;
				}
			case "Items":
				{
					filePath = "Music/Items/" + enumName.ToString ();
					break;
				}
			case "Monsters":
				{
					filePath = "Music/Monsters/" + enumName.ToString ();
					break;
				}
			case "Towers":
				{
					filePath = "Music/Towers/" + enumName.ToString ();
					break;
				}
			case "WindowsType":
				{
					filePath = "Windows/" + enumName.ToString ();
					break;
				}
			case "EnemyType":
				{
					filePath = "Enemy/" + enumName.ToString ();
					break;
				}
			case "ItemsType":
				{
					filePath = "Items/" + enumName.ToString ();
					break;
				}
			default:
				{
					break;
				}
		}

		return Resources.Load<T> (filePath);
	}

}
