using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tools
{
    public class AnimationController : MonoBehaviour
    {
        public Animator _charAnimator;

        private readonly int _hashOpenTrigger = Animator.StringToHash("isDancing");


        public void ChangeAnimationState()
        {
            bool isDancing = _charAnimator.GetBool("isDancing");

            _charAnimator.SetBool(_hashOpenTrigger, !isDancing);
        }

    }
}
