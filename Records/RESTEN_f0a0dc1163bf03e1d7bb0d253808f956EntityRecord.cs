using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AccordionIconType
public class RESTEN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord : AbstractRESTStructure<EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord> {
[JsonProperty("Id")]
public string AttrId;

public RESTEN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord() { }

public RESTEN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord (EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
  } else {
AttrId = s.ssId;
  }
}

public static EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord obj) { 
  EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord s = new EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  }
  return s;
}

public static Func<EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord, ssConectaProveedores.RestRecords.RESTEN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord FromStructure(EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord(s, config);
}

}


