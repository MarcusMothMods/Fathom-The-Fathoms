using UnityEngine;

namespace FathomTheFathoms
{
	public class Loader
	{
		/// <summary>
		/// This method is run by Winch to initialize your mod
		/// </summary>
		public static void Initialize()
		{
			var gameObject = new GameObject(nameof(FathomTheFathoms));
			gameObject.AddComponent<FathomTheFathoms>();
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
}