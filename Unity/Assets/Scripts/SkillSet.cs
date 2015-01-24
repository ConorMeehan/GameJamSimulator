using UnityEngine;
using System.Collections;

public class SkillSet {
	public const float MinSkillValue = 0;
	public const float MaxSkillValue = 100;

	public static float Get(float k)
	{
		return MinSkillValue + (MaxSkillValue - MinSkillValue) * k;
	}

	private float codingSkill = MinSkillValue;
	private float artSkill = MinSkillValue;
	private float audioSkill= MinSkillValue;
	private float writingSkill = MinSkillValue;	

	public float CodingSkill {
		get {
			return codingSkill;
		}
		set {
			codingSkill = value;
		}
	}

	public float ArtSkill {
		get {
			return artSkill;
		}
		set {
			artSkill = value;
		}
	}

	public float AudioSkill {
		get {
			return audioSkill;
		}
		set {
			audioSkill = value;
		}
	}

	public float WritingSkill {
		get {
			return writingSkill;
		}
		set {
			writingSkill = value;
		}
	}
}
