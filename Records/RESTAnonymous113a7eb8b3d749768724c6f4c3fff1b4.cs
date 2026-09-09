using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// LabelESCountRecord
public class RESTRC_95c68a20cdfa1714694774ffd45b1c33 : AbstractRESTStructure<RC_95c68a20cdfa1714694774ffd45b1c33> {
[JsonProperty("LabelES")]
public string AttrLabelES;

[JsonProperty("Count")]
public long? AttrCount;

public RESTRC_95c68a20cdfa1714694774ffd45b1c33() { }

public RESTRC_95c68a20cdfa1714694774ffd45b1c33 (RC_95c68a20cdfa1714694774ffd45b1c33 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLabelES = ConvertToRestWithoutDefaults(s.ssLabelES, "");
AttrCount = ConvertToRestWithoutDefaults(s.ssCount, 0L);
  } else {
AttrLabelES = s.ssLabelES;
AttrCount = (long?) s.ssCount;
  }
}

public static RC_95c68a20cdfa1714694774ffd45b1c33 ToStructure(ssConectaProveedores.RestRecords.RESTRC_95c68a20cdfa1714694774ffd45b1c33 obj) { 
  RC_95c68a20cdfa1714694774ffd45b1c33 s = new RC_95c68a20cdfa1714694774ffd45b1c33();
  if(obj != null) {
  s.ssLabelES = obj.AttrLabelES == null ? "" : obj.AttrLabelES;
  s.ssCount = obj.AttrCount == null ? 0L : obj.AttrCount.Value;
  }
  return s;
}

public static Func<RC_95c68a20cdfa1714694774ffd45b1c33, ssConectaProveedores.RestRecords.RESTRC_95c68a20cdfa1714694774ffd45b1c33> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_95c68a20cdfa1714694774ffd45b1c33 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_95c68a20cdfa1714694774ffd45b1c33 FromStructure(RC_95c68a20cdfa1714694774ffd45b1c33 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_95c68a20cdfa1714694774ffd45b1c33(s, config);
}

}


