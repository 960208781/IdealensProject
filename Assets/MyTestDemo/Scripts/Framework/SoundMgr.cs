//using UnityEngine;
//using System.Collections;
//
///// <summary>
///// 声音管理类
///// </summary>
//public class SoundMgr : MonoSingleton<SoundMgr>
//{
//	
//
//	private AudioSource m_BgMusic;
//	private AudioSource m_effectMusic;
//
//	public float BgVolume {
//		get { return m_BgMusic.volume; }
//		set { m_BgMusic.volume = value; }
//	}
//
//	public float EffectVolume {
//		get { return m_effectMusic.volume; }
//		set{ m_effectMusic.volume = value; }
//	}
//
//	protected override void Awake ()
//	{
//		base.Awake ();
//
//		m_BgMusic = gameObject.AddComponent<AudioSource> ();
//		m_BgMusic.loop = true;
//		m_BgMusic.playOnAwake = false;
//
//		m_effectMusic = gameObject.AddComponent<AudioSource> ();
//		m_effectMusic.loop = true;
//		m_effectMusic.playOnAwake = false;
//	}
//
//	private void PlayBgBase (object name, bool restart = false)
//	{
//		string curName = string.Empty;
//
//		if (m_BgMusic.clip != null) {
//			curName = m_BgMusic.clip.name;
//		}
//
//		AudioClip clip = ResourcesMgr.Instance.Load<AudioClip> (name);
//
//		if (clip != null) {
//
//			if (curName == clip.name && restart == false) {
//				return;
//			}
//
//			m_BgMusic.clip = clip;
//			m_BgMusic.Play ();
//		} else {
//			// 没有找到片段, 写日志!!!
//			print ("没有找到音频片段");
//		}
//	}
//
//	public void PlayBg (SoundType.Feeds name, bool restart = false)
//	{
//		PlayBgBase (name, restart);
//	}
//
//	public void PlayBg (SoundType.Items name, bool restart = false)
//	{
//		PlayBgBase (name, restart);
//	}
//
//	public void PlayBg (SoundType.Main name, bool restart = false)
//	{
//		PlayBgBase (name, restart);
//	}
//
//	public void PlayBg (SoundType.Monsters name, bool restart = false)
//	{
//		PlayBgBase (name, restart);
//	}
//
//	public void PlayBg (SoundType.Towers name, bool restart = false)
//	{
//		PlayBgBase (name, restart);
//	}
//
//
//	private void PlayEffectBase (object name, bool defAudio = true, float volume = 1f)
//	{
//		AudioClip clip = ResourcesMgr.Instance.Load<AudioClip> (name);
//		if (clip == null) {
//			print ("没有找到音频片段");
//			return;
//		}
//
//		if (defAudio) {
//			m_effectMusic.PlayOneShot (clip, volume);
//		} else {
//			AudioSource.PlayClipAtPoint (clip, Camera.main.transform.position, volume);
//		}
//	}
//
//	public void PlayEffect (SoundType.Feeds name, bool defAudio = true, float volume = 1f)
//	{
//		PlayEffectBase (name, defAudio, volume);
//	}
//
//	public void PlayEffect (SoundType.Items name, bool defAudio = true, float volume = 1f)
//	{
//		PlayEffectBase (name, defAudio, volume);
//	}
//
//	public void PlayEffect (SoundType.Main name, bool defAudio = true, float volume = 1f)
//	{
//		PlayEffectBase (name, defAudio, volume);
//	}
//
//	public void PlayEffect (SoundType.Monsters name, bool defAudio = true, float volume = 1f)
//	{
//		PlayEffectBase (name, defAudio, volume);
//	}
//
//	public void PlayEffect (SoundType.Towers name, bool defAudio = true, float volume = 1f)
//	{
//		PlayEffectBase (name, defAudio, volume);
//	}
//
//
//}
