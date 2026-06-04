using UnityEngine;
using Winch.Core;

namespace FathomTheFathoms
{
	public class FathomTheFathoms : MonoBehaviour
	{
		public void Awake()
		{
			WinchCore.Log.Debug($"{nameof(FathomTheFathoms)} has loaded!");
		}
	}
}
