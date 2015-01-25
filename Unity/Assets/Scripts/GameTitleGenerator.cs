using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameTitleGenerator {

	public static readonly GameTitle[] Settings = new GameTitle[]{
		new GameTitle("", new SkillSet()),
		new GameTitle("Fantasy", new SkillSet()),
		new GameTitle("Medieval Heroic Cult", new SkillSet()),
		new GameTitle("Romantic", new SkillSet()),
		new GameTitle("Horror", new SkillSet() { WritingSkill = SkillSet.Get(0.5f)}),
		new GameTitle("Post-Apocalyptic", new SkillSet()),
		new GameTitle("Space Opera", new SkillSet()),
	};

	public static readonly GameTitle[] Genres = new GameTitle[]{
		new GameTitle("Action", new SkillSet()),
		new GameTitle("Role-playing", new SkillSet()),
		new GameTitle("Adventure", new SkillSet()),
		new GameTitle("Art", new SkillSet()),
		new GameTitle("Beat 'em up", new SkillSet()),
		new GameTitle("Collectable Card Game", new SkillSet()),
		new GameTitle("Flight Simulator", new SkillSet()),
		new GameTitle("Dating", new SkillSet()),
		new GameTitle("Fighting", new SkillSet()),
		new GameTitle("Goverment Simulation", new SkillSet()),
		new GameTitle("Racing", new SkillSet()),
		new GameTitle("Puzzle", new SkillSet()),
		new GameTitle("Platform", new SkillSet()),
		new GameTitle("Rythm", new SkillSet()),
		new GameTitle("Shooter", new SkillSet()),
		new GameTitle("Sports", new SkillSet()),
		new GameTitle("Strategy", new SkillSet()),
		new GameTitle("Tower Defense", new SkillSet()),
	};


	static GameTitle game = new GameTitle ("game in ", new SkillSet ());

    public static readonly GameTitle[] Envionments = new GameTitle[]{
		new GameTitle("Victorian Era", new SkillSet(){WritingSkill = SkillSet.Get(0.5f)}),
		new GameTitle("Nowdays", new SkillSet()),
		new GameTitle("Wild West", new SkillSet()),
		new GameTitle("Virtual Reality", new SkillSet()),
		new GameTitle("Under Water", new SkillSet()),
		new GameTitle("Space", new SkillSet()),
		new GameTitle("Siberia", new SkillSet()),
		new GameTitle("Kung Fu Monastery", new SkillSet()),
	};

	public static GameTitle Generate()
	{
		var list = new List<GameTitle>(6);
		list.Add (Settings [(int)Random.Range (0, Settings.Length)]);
		list.Add (Genres [(int)Random.Range (0, Genres.Length)]);
		list.Add (game);
		list.Add (Envionments [(int)Random.Range (0, Envionments.Length)]);
		return new GameTitle(string.Join(" ", list.Select(_=>_.Title).ToArray ()), list.Select(_=>_.RequiredSkills).Sum().Cap(SkillSet.MaxSkillValue));
	}
}
