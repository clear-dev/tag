﻿using Sandbox;
using Sandbox.UI;
using System;

namespace TagGame
{
	public partial class TagUI : HudEntity<RootPanel>
	{
		public TagUI()
		{
			if ( !IsClient ) return;
			RootPanel.StyleSheet.Load( "/ui/styles.scss" );
			RootPanel.AddChild<ChatBox>();
			RootPanel.AddChild<NameTags>();
			RootPanel.AddChild<Scoreboard<ScoreboardEntry>>();
			Panel UI = RootPanel.AddChild<UI>();
			UI.AddChild<UITeam>();
		}
	}
}
