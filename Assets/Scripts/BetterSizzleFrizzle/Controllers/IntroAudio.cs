using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BetterSizzleFrizzle.Controllers
{
	[RequireComponent(typeof(AudioSource))]
	public class IntroAudio : MonoBehaviour
	{
		public List<AudioClip> audioToPlay;
		public string sceneToLoad;

		private int _currentlyPlayingIndex;
		private AudioSource _audioSource;
		private bool _finished;

		private void Awake()
		{
			_audioSource = GetComponent<AudioSource>();
			InitializeAudio();
		}

		private void InitializeAudio()
		{
			_currentlyPlayingIndex = 0;
			PlayCurrentAudio();
		}

		private void PlayCurrentAudio()
		{
			_audioSource.PlayOneShot(audioToPlay[_currentlyPlayingIndex]);
		}

		private void Update()
		{
			PlayingCheck();
		}

		private void PlayingCheck()
		{
			if (_audioSource.isPlaying) return;

			if (_currentlyPlayingIndex == audioToPlay.Count - 1)
			{
				SceneManager.LoadScene(sceneToLoad);
				return;
			}

			_currentlyPlayingIndex++;
			PlayCurrentAudio();
		}
		
	}
}