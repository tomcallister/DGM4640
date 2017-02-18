using UnityEngine;
using System.Collections;

public class AlveolarExpansion : MonoBehaviour {

	private float _currentScale = InitScale;
	private const float TargetScale = 0.015f;
	private const float InitScale = 0.01f;
	private const int FramesCount = 50;
	private const float AnimationTimeSeconds = 1.5f;
	private float _deltaTime = AnimationTimeSeconds/FramesCount;
	private float _dx = (TargetScale - InitScale)/FramesCount;
	private bool _upScale = true;

	private IEnumerator Breathe()
	{
		while (true)
		{
			while (_upScale)
			{
				_currentScale += _dx;
				if (_currentScale > TargetScale)
				{
					_upScale = false;
					_currentScale = TargetScale;
				}
				transform.localScale = Vector3.one * _currentScale;
				yield return new WaitForSeconds(_deltaTime);
			}
			
			while (!_upScale)
			{
				_currentScale -= _dx;
				if (_currentScale < InitScale)
				{
					_upScale = true;
					_currentScale = InitScale;
				}
				transform.localScale = Vector3.one * _currentScale;
				yield return new WaitForSeconds(_deltaTime);
			}
		}
	}

	void Start (){
		StartCoroutine(Breathe());
	}
}
