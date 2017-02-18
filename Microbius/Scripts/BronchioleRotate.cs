using UnityEngine;
using System.Collections;

public class BronchioleRotate : MonoBehaviour {

	private float _currentRotation = InitRotation;
	private const float TargetRotation = 148f;
	private const float InitRotation = 138f;
	private const int FramesCount = 100;
	private const float AnimationTimeSeconds = 1.75f;
	private float _deltaTime = AnimationTimeSeconds/FramesCount;
	private float _dx = (TargetRotation - InitRotation)/FramesCount;
	private bool _posRotation = true;

	private IEnumerator Rotate()
	{
		while (true) {
			while (_posRotation) {
				_currentRotation += _dx;
				if (_currentRotation > TargetRotation) {
					_posRotation = false;
					_currentRotation = TargetRotation;
				}
//				transform.eulerAngles.y = Vector3.one * _currentRotation;
				yield return new WaitForSeconds (_deltaTime);
			}
			
			while (!_posRotation) {
				_currentRotation -= _dx;
				if (_currentRotation < InitRotation) {
					_posRotation = true;
					_currentRotation = InitRotation;
				}
//				transform.eulerAngles.y = Vector3.one * _currentRotation;
				yield return new WaitForSeconds (_deltaTime);
			}
		}
	}

	// Use this for initialization
	void Start () {
			StartCoroutine(Rotate());
	}
}
