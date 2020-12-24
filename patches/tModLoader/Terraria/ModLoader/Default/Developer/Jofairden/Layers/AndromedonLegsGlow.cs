﻿using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;

namespace Terraria.ModLoader.Default.Developer.Jofairden
{
	internal class AndromedonLegsGlow : AndromedonGlow
	{
		private static Asset<Texture2D> _glowTexture;

		public override DrawDataInfo GetData(PlayerDrawSet info) {
			_glowTexture ??= ModContent.GetTexture("ModLoader/Developer.Jofairden.PowerRanger_Legs_Legs_Glow");

			return GetLegDrawDataInfo(info, _glowTexture.Value);
		}

		public override Position GetDefaultPosition() => new After(PlayerDrawLayers.Leggings);
	}
}