using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ProcessTypeRecord
public class JSONRC_efc73b4c3b9559691917e7c2536af227 : AbstractRESTStructure<RC_efc73b4c3b9559691917e7c2536af227> {
[JsonProperty("ProcessType")]
[JsonPropertyName("ProcessType")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord AttrProcessType;

public JSONRC_efc73b4c3b9559691917e7c2536af227() { }

public JSONRC_efc73b4c3b9559691917e7c2536af227 (RC_efc73b4c3b9559691917e7c2536af227 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProcessType = ConvertToRestWithoutDefaults(s.ssENProcessType, new EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.FromStructure, config);
  } else {
AttrProcessType = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.FromStructure(s.ssENProcessType, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_efc73b4c3b9559691917e7c2536af227, RC_efc73b4c3b9559691917e7c2536af227> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_efc73b4c3b9559691917e7c2536af227 s) => ToStructure(s, config);
}
public static RC_efc73b4c3b9559691917e7c2536af227 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_efc73b4c3b9559691917e7c2536af227 obj, IBehaviorsConfiguration config) { 
  RC_efc73b4c3b9559691917e7c2536af227 s = new RC_efc73b4c3b9559691917e7c2536af227();
  if(obj != null) {
  s.ssENProcessType = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.ToStructure(obj.AttrProcessType, config);
  }
  return s;
}

public static Func<RC_efc73b4c3b9559691917e7c2536af227, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_efc73b4c3b9559691917e7c2536af227> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_efc73b4c3b9559691917e7c2536af227 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_efc73b4c3b9559691917e7c2536af227 FromStructure(RC_efc73b4c3b9559691917e7c2536af227 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_efc73b4c3b9559691917e7c2536af227(s, config);
}

}


