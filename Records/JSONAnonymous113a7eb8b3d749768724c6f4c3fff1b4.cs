using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// LabelESCountRecord
public class JSONRC_95c68a20cdfa1714694774ffd45b1c33 : AbstractRESTStructure<RC_95c68a20cdfa1714694774ffd45b1c33> {
[JsonProperty("LabelES")]
[JsonPropertyName("LabelES")]
public string AttrLabelES;

[JsonProperty("Count")]
[JsonPropertyName("Count")]
public long? AttrCount;

public JSONRC_95c68a20cdfa1714694774ffd45b1c33() { }

public JSONRC_95c68a20cdfa1714694774ffd45b1c33 (RC_95c68a20cdfa1714694774ffd45b1c33 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLabelES = ConvertToRestWithoutDefaults(s.ssLabelES, "");
AttrCount = ConvertToRestWithoutDefaults(s.ssCount, 0L);
  } else {
AttrLabelES = s.ssLabelES;
AttrCount = (long?) s.ssCount;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_95c68a20cdfa1714694774ffd45b1c33, RC_95c68a20cdfa1714694774ffd45b1c33> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_95c68a20cdfa1714694774ffd45b1c33 s) => ToStructure(s, config);
}
public static RC_95c68a20cdfa1714694774ffd45b1c33 ToStructure(ssConectaProveedores.RestRecords.JSONRC_95c68a20cdfa1714694774ffd45b1c33 obj, IBehaviorsConfiguration config) { 
  RC_95c68a20cdfa1714694774ffd45b1c33 s = new RC_95c68a20cdfa1714694774ffd45b1c33();
  if(obj != null) {
  s.ssLabelES = obj.AttrLabelES == null ? "" : obj.AttrLabelES;
  s.ssCount = obj.AttrCount == null ? 0L : obj.AttrCount.Value;
  }
  return s;
}

public static Func<RC_95c68a20cdfa1714694774ffd45b1c33, ssConectaProveedores.RestRecords.JSONRC_95c68a20cdfa1714694774ffd45b1c33> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_95c68a20cdfa1714694774ffd45b1c33 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_95c68a20cdfa1714694774ffd45b1c33 FromStructure(RC_95c68a20cdfa1714694774ffd45b1c33 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_95c68a20cdfa1714694774ffd45b1c33(s, config);
}

}


