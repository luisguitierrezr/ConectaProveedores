using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ActivityStatusRecord
public class RESTRC_36a7d48575a55c39ace8b7f6b0cd3ac4 : AbstractRESTStructure<RC_36a7d48575a55c39ace8b7f6b0cd3ac4> {
[JsonProperty("ActivityStatus")]
public ssConectaProveedores.RestRecords.RESTENActivityStatusEntityRecord AttrActivityStatus;

public RESTRC_36a7d48575a55c39ace8b7f6b0cd3ac4() { }

public RESTRC_36a7d48575a55c39ace8b7f6b0cd3ac4 (RC_36a7d48575a55c39ace8b7f6b0cd3ac4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrActivityStatus = ConvertToRestWithoutDefaults(s.ssENActivityStatus, new ENActivityStatusEntityRecord(), ssConectaProveedores.RestRecords.RESTENActivityStatusEntityRecord.FromStructure, config);
  } else {
AttrActivityStatus = ssConectaProveedores.RestRecords.RESTENActivityStatusEntityRecord.FromStructure(s.ssENActivityStatus, config);
  }
}

public static RC_36a7d48575a55c39ace8b7f6b0cd3ac4 ToStructure(ssConectaProveedores.RestRecords.RESTRC_36a7d48575a55c39ace8b7f6b0cd3ac4 obj) { 
  RC_36a7d48575a55c39ace8b7f6b0cd3ac4 s = new RC_36a7d48575a55c39ace8b7f6b0cd3ac4();
  if(obj != null) {
  s.ssENActivityStatus = ssConectaProveedores.RestRecords.RESTENActivityStatusEntityRecord.ToStructure(obj.AttrActivityStatus);
  }
  return s;
}

public static Func<RC_36a7d48575a55c39ace8b7f6b0cd3ac4, ssConectaProveedores.RestRecords.RESTRC_36a7d48575a55c39ace8b7f6b0cd3ac4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_36a7d48575a55c39ace8b7f6b0cd3ac4 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_36a7d48575a55c39ace8b7f6b0cd3ac4 FromStructure(RC_36a7d48575a55c39ace8b7f6b0cd3ac4 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_36a7d48575a55c39ace8b7f6b0cd3ac4(s, config);
}

}


