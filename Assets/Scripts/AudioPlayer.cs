using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UI
{
    public class AudioPlayer : MonoBehaviour
    {
        [SerializeField]
        private AudioSource _currentTrack;
        [SerializeField]
        private AudioClip[] _playList;
        private Animator _charAnimator;

        private void Awake()
        {
            _currentTrack = GetComponent<AudioSource>();
            FirstStartMusic();
        }


        public void PauseMusic()
        {
            _currentTrack.Pause();
            Debug.Log(_currentTrack.time);
        }


        public void UnPauseMusic()
        {
            _currentTrack.UnPause();

        }


        public void PlayMusic()
        {
            _currentTrack.Play();
        }


        public void FirstStartMusic()
        {
            _currentTrack.clip = _playList[0];
            PlayMusic();
        }
    }
}
