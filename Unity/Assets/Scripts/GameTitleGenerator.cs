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

    public static readonly GameTitle[] Envionments = new GameTitle[]{
        new GameTitle("Victorian Era", new SkillSet()),
    };
}
