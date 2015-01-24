public class GameTitle {

	public string Title {get;set;}

	public SkillSet RequiredSkills {get;set;}

    public GameTitle()
    {
        RequiredSkills = new SkillSet();
    }

    public GameTitle(string title, SkillSet skillSet)
    {
        Title = title;
        RequiredSkills = skillSet;
    }
}
