using System.Collections.Generic;

namespace DeusExIllnessSender
{
  public class AliceModel
  {
    public string _id { get; set; }
    public string profileType { get; set; }
    public bool isAlive { get; set; }
    public bool inGame { get; set; }
    public int totalSpentInVR { get; set; }
    public List<AliceModifier> modifiers { get; set; }
  }
}