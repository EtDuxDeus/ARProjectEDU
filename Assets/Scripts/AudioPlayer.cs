using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


namespace Tools
{
    public class AudioPlayer : MonoBehaviour
    {
        [SerializeField]
        private AudioSource _currentTrack;
        [SerializeField]
        private AudioClip[] _playlist;
        private int _positionInPlaylist;


        private void Awake()
        {
            _currentTrack = GetComponent<AudioSource>();
            _positionInPlaylist = 0;
            FirstStartMusic();
        }


        public void ResetMusic()
        {
            _positionInPlaylist = 0;
            _currentTrack.clip = _playlist[_positionInPlaylist];
            _currentTrack.Stop();
        }


        public void PlayNextTrack()
        {
            if (_positionInPlaylist < _playlist.Length - 1)
            {
                _positionInPlaylist++;
            }
            else
            {
                _positionInPlaylist = 0;
            }
            _currentTrack.clip = _playlist[_positionInPlaylist];
            PlayMusic();
        }


        public void PlayPreviousTrack()
        {
            if (_positionInPlaylist == 0)
            {
                _positionInPlaylist = _playlist.Length - 1;
            }
            else
            {
                _positionInPlaylist--;
            }
            _currentTrack.clip = _playlist[_positionInPlaylist];
            PlayMusic();
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
