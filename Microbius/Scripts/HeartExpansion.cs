using UnityEngine;
using System.Collections;

public class HeartExpansion : MonoBehaviour {

	private float _currentScale = InitScale;
	private const float TargetScale = 1600f;
	private const float InitScale = 1545.817f;
	private const int FramesCount = 28;
	private const float AnimationTimeSeconds = 0.1f;
	private float _deltaTime = AnimationTimeSeconds/FramesCount;
	private float _dx = (TargetScale - InitScale)/FramesCount;
	private bool _upScale = true;

	void Start (){
		StartCoroutine(HeartBeat());
	}

	private IEnumerator HeartBeat()
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
}
