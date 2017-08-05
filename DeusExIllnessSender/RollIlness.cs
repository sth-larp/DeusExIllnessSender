using System;

namespace DeusExIllnessSender
{

  public class RollIlness: CharacterEvent
  {
    public string eventType { get; set; }

    public long timestamp { get; set; }

    public object data { get; set; } = new object();

    public RollIlness(string id)
    {
      eventType = "roll-illness";
      timestamp = (long) (DateTime.UtcNow.AddMinutes(5).Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds); //Ticks;
      characterId = id;
    }
  }

  public class CharacterEvent
  {
    public string characterId { get; set; }
  }

  public class StartIlness : CharacterEvent
  {
    public string eventType { get; set; }

    public long timestamp { get; set; }

    public object data { get; }

    public StartIlness(string id, object illnessName)
    {
      eventType = "start-illness";
      timestamp = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds); //Ticks;
      characterId = id;
      data = new {id = illnessName};
    }
  }
}
