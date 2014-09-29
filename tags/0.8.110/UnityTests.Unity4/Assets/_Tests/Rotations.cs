﻿using DG.Tweening;
using System.Collections;
using UnityEngine;

public class Rotations : BrainBase
{
	public Transform[] ts;

	IEnumerator Start()
	{
		yield return new WaitForSeconds(0.5f);

		// Should take shortest rotation route
		DOTween.Sequence().SetLoops(-1, LoopType.Yoyo)
			.Append(ts[0].DORotate(new Vector3(0, -45, 0), 1))
			.Append(ts[0].DORotate(new Vector3(0, 0, 0), 1));

		// Should take longest rotation route (because Unity will change the start Vector when the first tween ends)
		DOTween.Sequence().SetLoops(-1, LoopType.Yoyo)
			.Append(ts[1].DORotate(new Vector3(0, -45, 0), 1, false))
			.Append(ts[1].DORotate(new Vector3(0, 0, 0), 1, false));

		DOTween.Sequence().SetLoops(-1, LoopType.Yoyo)
			.Append(ts[2].DORotate(new Vector3(0, -45, 0), 1)
				.SetRelative())
			.Append(ts[2].DORotate(new Vector3(0, 360, 0), 1)
				.SetRelative());

		////////////////////////////////////////
		// FROM ////////////////////////////////

		DOTween.Sequence().SetLoops(-1, LoopType.Yoyo)
			.Append(ts[3].DORotateFrom(new Vector3(0, -45, 0), 1))
			.Append(ts[3].DORotate(new Vector3(0, -45, 0), 1));

		DOTween.Sequence().SetLoops(-1, LoopType.Yoyo)
			.Append(ts[4].DORotateFrom(new Vector3(0, -45, 0), 1, false))
			.Append(ts[4].DORotate(new Vector3(0, -45, 0), 1, false));

		DOTween.Sequence().SetLoops(-1, LoopType.Yoyo)
			.Append(ts[5].DORotateFrom(new Vector3(0, -45, 0), 1)
				.SetRelative())
			.Append(ts[5].DORotate(new Vector3(0, -90, 0), 1)
				.SetRelative());
	}
}