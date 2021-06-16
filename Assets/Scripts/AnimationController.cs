using UnityEngine;

namespace Tools
{
	public class AnimationController : MonoBehaviour
	{
		[SerializeField]
		private Animator _charAnimator;


		public void PauseAnimation()
		{
			_charAnimator.speed = 0;
		}


		public void ContinueAnimation()
		{
			_charAnimator.speed = 1;
		}
	}
}
