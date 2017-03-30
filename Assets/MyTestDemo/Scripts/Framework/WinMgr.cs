//using UnityEngine;
//using System.Collections;
//
///// <summary>
///// 窗口管理类
///// </summary>
//public class WinMgr : Singleton<WinMgr>
//{
//	// 存放窗口对象.
//	private Hashtable m_winPreTable;
//
//	// 构造方法
//	public WinMgr ()
//	{
//		m_winPreTable = new Hashtable ();
//	}
//
//	// 面向用户的核心方法
//	public GameObject LoadWin (
//		WindowsType win, 
//		HangPointType hangPoint,
//		CanvasType canvas = CanvasType.NormalCanvas,
//		bool isCache = false)
//	{
//		GameObject winObj = null;
//
//		string winName = win.ToString ();
//
//		// 找到Canvas
//		GameObject can = GameObject.Find ("/" + canvas.ToString ());
//		if (can == null) {
//			can = GameObject.Find ("/" + canvas.ToString () + "(Clone)");
//		}
//
//		// 加载窗口
//		if (m_winPreTable.Contains (winName) && isCache) {
//			winObj = m_winPreTable [winName] as GameObject;
//		} else {
//			winObj = ResourcesMgr.Instance.Load<GameObject> (win);
//			if (isCache && !m_winPreTable.Contains (winName)) {
//				m_winPreTable.Add (winName, winObj);
//			}
//		}
//
//		// 实例化窗口
//		winObj = GameObject.Instantiate (winObj) as GameObject;
//
//		// 设置中心点
//		Vector2 pivot = new Vector2 (0.5f, 0.5f);
//
//		switch (hangPoint) {
//			case HangPointType.LeftTop:
//				{
//					pivot = new Vector2 (0f, 1f);
//					break;
//				}
//			case HangPointType.LeftMid:
//				{
//					pivot = new Vector2 (0f, 0.5f);
//					break;
//				}
//			case HangPointType.LeftBottom:
//				{
//					pivot = new Vector2 (0f, 0f);
//					break;
//				}
//			case HangPointType.MidTop:
//				{
//					pivot = new Vector2 (0.5f, 1f);
//					break;
//				}
//			case HangPointType.Center:
//				{
//					pivot = new Vector2 (0.5f, 0.5f);
//					break;
//				}
//			case HangPointType.MidBottom:
//				{
//					pivot = new Vector2 (0.5f, 0f);
//					break;
//				}
//			case HangPointType.RightTop:
//				{
//					pivot = new Vector2 (1f, 1f);
//					break;
//				}
//			case HangPointType.RightMid:
//				{
//					pivot = new Vector2 (1f, 0.5f);
//					break;
//				}
//			case HangPointType.RightBottom:
//				{
//					pivot = new Vector2 (1f, 0f);
//					break;
//				}
//					
//			default:
//				{
//					break;
//				}
//		}
//
//		// 设置中心点
//		winObj.GetComponent<RectTransform> ().pivot = pivot;
//
//		// 设置挂点(父物体)
//		Transform parnet = can.transform.Find (hangPoint.ToString ());
//
//		// 设置属性
//		winObj.transform.SetParent (parnet);
//		winObj.transform.localScale = Vector3.one;
//		winObj.transform.localPosition = Vector3.zero;
//	
//		winObj.transform.parent.SetSiblingIndex (100);
//
//		return winObj;
//	}
//
//}
