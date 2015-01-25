using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameTitleGenerator {

	public static readonly GameTitle[] Settings = new GameTitle[]{
		new GameTitle("", new SkillSet() { }),
		new GameTitle("Fantasy", new SkillSet() { 
			WritingSkill = SkillSet.Get(0.4f), 
			ArtSkill = SkillSet.Get(0.4f), 
			CodingSkill = SkillSet.Get(0.0f), 
			AudioSkill = SkillSet.Get(0.0f), 
		}),
		new GameTitle("Medieval Heroic Cult", new SkillSet() { 
			WritingSkill = SkillSet.Get(0.3f), 
			ArtSkill = SkillSet.Get(0.3f), 
			CodingSkill = SkillSet.Get(0.0f), 
			AudioSkill = SkillSet.Get(0.0f), 
		}),
		new GameTitle("Romantic", new SkillSet() { 
			WritingSkill = SkillSet.Get(0.5f),
			ArtSkill = SkillSet.Get(0.5f), 
			CodingSkill = SkillSet.Get(0.0f), 
			AudioSkill = SkillSet.Get(0.0f), 
		}),
		new GameTitle("Horror", new SkillSet() { 
			WritingSkill = SkillSet.Get(0.3f), 
			ArtSkill = SkillSet.Get(0.2f),  
			CodingSkill = SkillSet.Get(0.0f), 
			AudioSkill = SkillSet.Get(7.0f), 
		}),
		new GameTitle("Post-Apocalyptic", new SkillSet() {
			WritingSkill = SkillSet.Get(0.2f), 
			ArtSkill = SkillSet.Get(0.3f), 
			CodingSkill = SkillSet.Get(0.0f), 
			AudioSkill = SkillSet.Get(1.0f), 
		}),
		new GameTitle("Space Opera", new SkillSet() { 
			WritingSkill = SkillSet.Get(0.1f),
			ArtSkill = SkillSet.Get(0.2f), 
			CodingSkill = SkillSet.Get(0.0f), 
			AudioSkill = SkillSet.Get(0.0f), 
		}),
	};

	public static readonly GameTitle[] Genres = new GameTitle[]{
		new GameTitle("Action", new SkillSet() { 
			WritingSkill = SkillSet.Get(0.1f), 
			ArtSkill = SkillSet.Get(0.0f), 
			CodingSkill = SkillSet.Get(0.2f), 
			AudioSkill = SkillSet.Get(0.1f), 
		}),
		new GameTitle("Role-playing", new SkillSet() {
			WritingSkill = SkillSet.Get(0.8f),  
			ArtSkill = SkillSet.Get(0.6f), 
			CodingSkill = SkillSet.Get(0.4f), 
			AudioSkill = SkillSet.Get(0.3f), 
		}),
		new GameTitle("Adventure", new SkillSet() { 
			WritingSkill = SkillSet.Get(0.7f), 
			ArtSkill = SkillSet.Get(0.7f), 
			CodingSkill = SkillSet.Get(0.0f), 
			AudioSkill = SkillSet.Get(0.3f), 
		}),
		new GameTitle("Art", new SkillSet() { 
			WritingSkill = SkillSet.Get(0.1f), 
			ArtSkill = SkillSet.Get(0.6f), 
			CodingSkill = SkillSet.Get(0.1f), 
			AudioSkill = SkillSet.Get(0.0f), 
		}),
		new GameTitle("Beat 'em up", new SkillSet() { 
			WritingSkill = SkillSet.Get(0.0f), 
			ArtSkill = SkillSet.Get(0.4f), 
			CodingSkill = SkillSet.Get(0.1f), 
			AudioSkill = SkillSet.Get(0.4f), 
		}),
		new GameTitle("Collectable Card Game", new SkillSet() {
			WritingSkill = SkillSet.Get(0.1f),  
			ArtSkill = SkillSet.Get(0.8f), 
			CodingSkill = SkillSet.Get(0.3f), 
			AudioSkill = SkillSet.Get(0.1f), 
		}),
		new GameTitle("Flight Simulator", new SkillSet() { 
			WritingSkill = SkillSet.Get(0.0f), 
			ArtSkill = SkillSet.Get(0.2f), 
			CodingSkill = SkillSet.Get(0.8f), 
			AudioSkill = SkillSet.Get(0.5f), 
		}),
		new GameTitle("Dating", new SkillSet() { 
			WritingSkill = SkillSet.Get(0.4f), 
			ArtSkill = SkillSet.Get(0.7f), 
			CodingSkill = SkillSet.Get(0.1f), 
			AudioSkill = SkillSet.Get(0.3f), 
		}),
		new GameTitle("Fighting", new SkillSet() { 
			WritingSkill = SkillSet.Get(0.0f),
			ArtSkill = SkillSet.Get(0.4f), 
			CodingSkill = SkillSet.Get(0.3f), 
			AudioSkill = SkillSet.Get(0.5f), 
		}),
		new GameTitle("Goverment Simulation", new SkillSet() { 
			WritingSkill = SkillSet.Get(0.1f), 
			ArtSkill = SkillSet.Get(0.1f), 
			CodingSkill = SkillSet.Get(0.3f), 
			AudioSkill = SkillSet.Get(0.1f), 
		}),
		new GameTitle("Racing", new SkillSet() { 
			WritingSkill = SkillSet.Get(0.0f), 
			ArtSkill = SkillSet.Get(0.3f), 
			CodingSkill = SkillSet.Get(0.3f), 
			AudioSkill = SkillSet.Get(0.5f), 
		}),
		new GameTitle("Puzzle", new SkillSet() { 
			WritingSkill = SkillSet.Get(0.0f), 
			ArtSkill = SkillSet.Get(0.5f), 
			CodingSkill = SkillSet.Get(0.2f), 
			AudioSkill = SkillSet.Get(0.2f), 
		}),
		new GameTitle("Platform", new SkillSet() { 
			WritingSkill = SkillSet.Get(0.1f), 
			ArtSkill = SkillSet.Get(0.4f), 
			CodingSkill = SkillSet.Get(0.2f), 
			AudioSkill = SkillSet.Get(0.3f), 
		}),
		new GameTitle("Rythm", new SkillSet(){ 
			WritingSkill = SkillSet.Get(0.0f), 
			ArtSkill = SkillSet.Get(0.4f), 
			CodingSkill = SkillSet.Get(0.1f), 
			AudioSkill = SkillSet.Get(0.7f), 
		}),
		new GameTitle("Shooter", new SkillSet(){ 
			WritingSkill = SkillSet.Get(0.1f), 
			ArtSkill = SkillSet.Get(0.4f), 
			CodingSkill = SkillSet.Get(0.4f), 
			AudioSkill = SkillSet.Get(0.3f), 
		}),
		new GameTitle("Sports", new SkillSet(){ 
			WritingSkill = SkillSet.Get(0.0f),
			ArtSkill = SkillSet.Get(0.5f), 
			CodingSkill = SkillSet.Get(0.4f), 
			AudioSkill = SkillSet.Get(0.3f), 
		}),
		new GameTitle("Strategy", new SkillSet(){
			WritingSkill = SkillSet.Get(0.3f),  
		}),
		new GameTitle("Tower Defense", new SkillSet(){
			WritingSkill = SkillSet.Get(0.0f),  
			ArtSkill = SkillSet.Get(0.4f), 
			CodingSkill = SkillSet.Get(0.2f), 
			AudioSkill = SkillSet.Get(0.1f), 
		}),
	};


	static GameTitle game = new GameTitle ("game", new SkillSet (){ });

    public static readonly GameTitle[] Envionments = new GameTitle[]{
		new GameTitle("at Victorian Era", new SkillSet(){
			WritingSkill = SkillSet.Get(0.3f),
			ArtSkill = SkillSet.Get(0.3f), 
			CodingSkill = SkillSet.Get(0.0f), 
			AudioSkill = SkillSet.Get(0.2f), 
		}),
		new GameTitle("at Nowdays", new SkillSet(){
			WritingSkill = SkillSet.Get(0.4f),  
			ArtSkill = SkillSet.Get(0.0f), 
			CodingSkill = SkillSet.Get(0.0f), 
			AudioSkill = SkillSet.Get(0.3f), 
		}),
		new GameTitle("at Wild West", new SkillSet(){
			WritingSkill = SkillSet.Get(0.3f),  
			ArtSkill = SkillSet.Get(0.2f), 
			CodingSkill = SkillSet.Get(0.0f), 
			AudioSkill = SkillSet.Get(0.1f), 
		}),
		new GameTitle("in Virtual Reality", new SkillSet(){ 
			WritingSkill = SkillSet.Get(0.2f), 
			ArtSkill = SkillSet.Get(0.3f), 
			CodingSkill = SkillSet.Get(0.2f), 
			AudioSkill = SkillSet.Get(0.2f), 
		}),
		new GameTitle("Under Water", new SkillSet(){ 
			WritingSkill = SkillSet.Get(0.2f), 
			ArtSkill = SkillSet.Get(0.2f), 
			CodingSkill = SkillSet.Get(0.2f), 
			AudioSkill = SkillSet.Get(0.4f), 
		}),
		new GameTitle("in Space", new SkillSet(){ 
			WritingSkill = SkillSet.Get(0.2f), 
			ArtSkill = SkillSet.Get(0.2f), 
			CodingSkill = SkillSet.Get(0.2f), 
			AudioSkill = SkillSet.Get(0.1f), 
		}),
		new GameTitle("in Siberia", new SkillSet(){ 
			WritingSkill = SkillSet.Get(0.1f), 
			ArtSkill = SkillSet.Get(0.0f), 
			CodingSkill = SkillSet.Get(0.0f), 
			AudioSkill = SkillSet.Get(0.2f), 
		}),
		new GameTitle("at Kung Fu Monastery", new SkillSet(){
			WritingSkill = SkillSet.Get(0.1f),  
			ArtSkill = SkillSet.Get(0.2f), 
			CodingSkill = SkillSet.Get(0.0f), 
			AudioSkill = SkillSet.Get(0.0f), 
		}),
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
