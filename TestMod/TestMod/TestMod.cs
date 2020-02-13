using BurningKnight.assets;
using BurningKnight.assets.mod;
using Lens.graphics;
using Lens.util;
using Microsoft.Xna.Framework;

namespace TestMod {
	public class TestMod : Mod {
		private float t;
	
		public TestMod() {
			Prefix = "tm";
		}
		
		public override void Init() {
			Log.Info("YOY");
		}

		public override void Destroy() {
			Log.Info("Bye!");
		}

		public override void Update(float dt) {
			t += dt;
		}

		public override void Render() {
			Graphics.Print($"{t}", Font.Small, new Vector2(4));
		}
	}
}