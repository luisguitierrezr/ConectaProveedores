using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// VideoState
public class RESTEN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord : AbstractRESTStructure<EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord> {
[JsonProperty("State")]
public string AttrState;

public RESTEN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord() { }

public RESTEN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord (EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrState = s.ssState;
  } else {
AttrState = s.ssState;
  }
}

public static EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord obj) { 
  EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord s = new EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord();
  if(obj != null) {
  s.ssState = obj.AttrState == null ? "" : obj.AttrState;
  }
  return s;
}

public static Func<EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord, ssConectaProveedores.RestRecords.RESTEN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord FromStructure(EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord(s, config);
}

}


