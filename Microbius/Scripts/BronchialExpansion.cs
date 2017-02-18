using UnityEngine;
using System.Collections;

public class BronchialExpansion : MonoBehaviour {

//	float scaleRate = 0.005f;
/*	public float scaleRate = 1f;
//	public float minScale = 0.2441881f;
	public float maxScale = 0.26f;
	public float waitTime;

*/	void Start (){
		StartCoroutine(Breathe());
	}

/*	IEnumerator Expand () {
		float timer = 0;
		
		while (true) {
			while (maxScale > transform.localScale.x) {
				timer += Time.deltaTime;
				transform.localScale += new Vector3 (1, 1, 1) * Time.deltaTime * scaleRate;
				yield return null;
			}

			yield return new WaitForSeconds (waitTime);
			
			timer = 0;
			while (1 < transform.localScale.x) {
				timer += Time.deltaTime;
				transform.localScale -= new Vector3 (1, 1, 1) * Time.deltaTime * scaleRate;
				yield return null;
			}
			
			timer = 0;
			yield return new WaitForSeconds (waitTime);
		}
	}
*/
	private float _currentScale = InitScale;
	private const float TargetScale = 0.19f;
	private const float InitScale = 0.189f;
	private const int FramesCount = 100;
	private const float AnimationTimeSeconds = 1.75f;
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


/*	IEnumerator Expand () {
		for (float i = 0.245f; i > minScale; i += 0.7f) {
			transform.localScale = Vector3.Lerp (this.transform.localScale, new Vector3 (maxScale, maxScale, maxScale), Time.deltaTime * scaleRate);
			yield return null;
		}
	}
*/

/*	public IEnumerator Expand() {
		transform.localScale = Vector3.Lerp(this.transform.localScale, new Vector3(maxScale,maxScale,maxScale), Time.deltaTime * scaleRate);
		yield return null;
//		yield return new WaitForSeconds(.5f);
	}
*/
/*	void Update (){
		transform.localScale = Vector3.Lerp (this.transform.localScale, new Vector3 (maxScale, maxScale, maxScale), Time.deltaTime * scaleRate);
	}
*/
/*	public void Main() {
	if(transform.localScale.x < minScale) {
		scaleRate = Mathf.Abs(scaleRate);
	}
	else if(transform.localScale.x > maxScale) {
		scaleRate = -Mathf.Abs(scaleRate);
		}
		Expand ();
	}

	// Update is called once per frame
	void Update () {
		Main ();
	}
*/
}
