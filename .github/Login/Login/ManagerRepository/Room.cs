using System;

public class Room
{
	public enum Type
	{
		OperatingRoom,
		ExaminationRoom,
		BreakRoom
	}

	public string type;
	public int id;


	public Room(int id, string type)
    {
		this.type = type;
		this.id = id;
    }

	public string ToFile()
    {
		return id.ToString() + "|" + type;
	} 
}
