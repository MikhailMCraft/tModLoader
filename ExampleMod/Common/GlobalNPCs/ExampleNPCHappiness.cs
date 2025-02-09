﻿using Terraria.ID;
using Terraria.ModLoader;

namespace ExampleMod.Common.GlobalNPCs
{
	public class ExampleNPCHappiness : GlobalNPC 
	{
		public override void SetStaticDefaults() {
			int examplePersonType = ModContent.NPCType<Content.NPCs.ExamplePerson>(); // Get ExamplePerson's type
			var guideHappiness = NPCHappiness.Get(NPCID.Guide); // Get the key into The Guide's happiness

			guideHappiness.LoveNPC(examplePersonType); // Make the Guide love ExamplePerson!
		}
	}
}
