using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ActivityStatusRecord
public class JSONRC_36a7d48575a55c39ace8b7f6b0cd3ac4 : AbstractRESTStructure<RC_36a7d48575a55c39ace8b7f6b0cd3ac4> {
[JsonProperty("ActivityStatus")]
[JsonPropertyName("ActivityStatus")]
public ssConectaProveedores.RestRecords.JSONENActivityStatusEntityRecord AttrActivityStatus;

public JSONRC_36a7d48575a55c39ace8b7f6b0cd3ac4() { }

public JSONRC_36a7d48575a55c39ace8b7f6b0cd3ac4 (RC_36a7d48575a55c39ace8b7f6b0cd3ac4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrActivityStatus = ConvertToRestWithoutDefaults(s.ssENActivityStatus, new ENActivityStatusEntityRecord(), ssConectaProveedores.RestRecords.JSONENActivityStatusEntityRecord.FromStructure, config);
  } else {
AttrActivityStatus = ssConectaProveedores.RestRecords.JSONENActivityStatusEntityRecord.FromStructure(s.ssENActivityStatus, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_36a7d48575a55c39ace8b7f6b0cd3ac4, RC_36a7d48575a55c39ace8b7f6b0cd3ac4> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_36a7d48575a55c39ace8b7f6b0cd3ac4 s) => ToStructure(s, config);
}
public static RC_36a7d48575a55c39ace8b7f6b0cd3ac4 ToStructure(ssConectaProveedores.RestRecords.JSONRC_36a7d48575a55c39ace8b7f6b0cd3ac4 obj, IBehaviorsConfiguration config) { 
  RC_36a7d48575a55c39ace8b7f6b0cd3ac4 s = new RC_36a7d48575a55c39ace8b7f6b0cd3ac4();
  if(obj != null) {
  s.ssENActivityStatus = ssConectaProveedores.RestRecords.JSONENActivityStatusEntityRecord.ToStructure(obj.AttrActivityStatus, config);
  }
  return s;
}

public static Func<RC_36a7d48575a55c39ace8b7f6b0cd3ac4, ssConectaProveedores.RestRecords.JSONRC_36a7d48575a55c39ace8b7f6b0cd3ac4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_36a7d48575a55c39ace8b7f6b0cd3ac4 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_36a7d48575a55c39ace8b7f6b0cd3ac4 FromStructure(RC_36a7d48575a55c39ace8b7f6b0cd3ac4 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_36a7d48575a55c39ace8b7f6b0cd3ac4(s, config);
}

}


