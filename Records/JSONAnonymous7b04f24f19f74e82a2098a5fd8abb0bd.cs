using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProcessStatusRecord
public class JSONRC_a7be5795c4af08fa8098110e55d36aff : AbstractRESTStructure<RC_a7be5795c4af08fa8098110e55d36aff> {
[JsonProperty("ProcessStatus")]
[JsonPropertyName("ProcessStatus")]
public ssConectaProveedores.RestRecords.JSONENProcessStatusEntityRecord AttrProcessStatus;

public JSONRC_a7be5795c4af08fa8098110e55d36aff() { }

public JSONRC_a7be5795c4af08fa8098110e55d36aff (RC_a7be5795c4af08fa8098110e55d36aff s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProcessStatus = ConvertToRestWithoutDefaults(s.ssENProcessStatus, new ENProcessStatusEntityRecord(), ssConectaProveedores.RestRecords.JSONENProcessStatusEntityRecord.FromStructure, config);
  } else {
AttrProcessStatus = ssConectaProveedores.RestRecords.JSONENProcessStatusEntityRecord.FromStructure(s.ssENProcessStatus, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_a7be5795c4af08fa8098110e55d36aff, RC_a7be5795c4af08fa8098110e55d36aff> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_a7be5795c4af08fa8098110e55d36aff s) => ToStructure(s, config);
}
public static RC_a7be5795c4af08fa8098110e55d36aff ToStructure(ssConectaProveedores.RestRecords.JSONRC_a7be5795c4af08fa8098110e55d36aff obj, IBehaviorsConfiguration config) { 
  RC_a7be5795c4af08fa8098110e55d36aff s = new RC_a7be5795c4af08fa8098110e55d36aff();
  if(obj != null) {
  s.ssENProcessStatus = ssConectaProveedores.RestRecords.JSONENProcessStatusEntityRecord.ToStructure(obj.AttrProcessStatus, config);
  }
  return s;
}

public static Func<RC_a7be5795c4af08fa8098110e55d36aff, ssConectaProveedores.RestRecords.JSONRC_a7be5795c4af08fa8098110e55d36aff> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a7be5795c4af08fa8098110e55d36aff s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_a7be5795c4af08fa8098110e55d36aff FromStructure(RC_a7be5795c4af08fa8098110e55d36aff s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_a7be5795c4af08fa8098110e55d36aff(s, config);
}

}


