using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProcessTypeRecord
public class RESTRC_efc73b4c3b9559691917e7c2536af227 : AbstractRESTStructure<RC_efc73b4c3b9559691917e7c2536af227> {
[JsonProperty("ProcessType")]
public ssConectaProveedores.RestRecords.RESTEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord AttrProcessType;

public RESTRC_efc73b4c3b9559691917e7c2536af227() { }

public RESTRC_efc73b4c3b9559691917e7c2536af227 (RC_efc73b4c3b9559691917e7c2536af227 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProcessType = ConvertToRestWithoutDefaults(s.ssENProcessType, new EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.FromStructure, config);
  } else {
AttrProcessType = ssConectaProveedores.RestRecords.RESTEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.FromStructure(s.ssENProcessType, config);
  }
}

public static RC_efc73b4c3b9559691917e7c2536af227 ToStructure(ssConectaProveedores.RestRecords.RESTRC_efc73b4c3b9559691917e7c2536af227 obj) { 
  RC_efc73b4c3b9559691917e7c2536af227 s = new RC_efc73b4c3b9559691917e7c2536af227();
  if(obj != null) {
  s.ssENProcessType = ssConectaProveedores.RestRecords.RESTEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.ToStructure(obj.AttrProcessType);
  }
  return s;
}

public static Func<RC_efc73b4c3b9559691917e7c2536af227, ssConectaProveedores.RestRecords.RESTRC_efc73b4c3b9559691917e7c2536af227> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_efc73b4c3b9559691917e7c2536af227 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_efc73b4c3b9559691917e7c2536af227 FromStructure(RC_efc73b4c3b9559691917e7c2536af227 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_efc73b4c3b9559691917e7c2536af227(s, config);
}

}


