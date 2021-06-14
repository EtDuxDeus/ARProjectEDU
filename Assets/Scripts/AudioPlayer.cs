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
        private AudioClip[] _playlist;
        private bool isPlaying;
        private int _positionInPlaylist;


        private void Awake()
        {
            _currentTrack = GetComponent<AudioSource>();
            _positionInPlaylist = 0;
            FirstStartMusic();
        }


        private void Update()
        {
            if (_currentTrack.time >= _currentTrack.clip.length - 1 & _positionInPlaylist <= _playlist.Length)
            {
                _positionInPlaylist++;
                _currentTrack.clip = _playlist[_positionInPlaylist];
            }
        }


        public void PauseMusic()
        {
            _currentTrack.Pause();
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
            _currentTrack.clip = _playlist[_positionInPlaylist];
            PlayMusic();
        }
    }
}
