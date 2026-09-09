using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProcessStatusRecord
public class RESTRC_a7be5795c4af08fa8098110e55d36aff : AbstractRESTStructure<RC_a7be5795c4af08fa8098110e55d36aff> {
[JsonProperty("ProcessStatus")]
public ssConectaProveedores.RestRecords.RESTENProcessStatusEntityRecord AttrProcessStatus;

public RESTRC_a7be5795c4af08fa8098110e55d36aff() { }

public RESTRC_a7be5795c4af08fa8098110e55d36aff (RC_a7be5795c4af08fa8098110e55d36aff s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProcessStatus = ConvertToRestWithoutDefaults(s.ssENProcessStatus, new ENProcessStatusEntityRecord(), ssConectaProveedores.RestRecords.RESTENProcessStatusEntityRecord.FromStructure, config);
  } else {
AttrProcessStatus = ssConectaProveedores.RestRecords.RESTENProcessStatusEntityRecord.FromStructure(s.ssENProcessStatus, config);
  }
}

public static RC_a7be5795c4af08fa8098110e55d36aff ToStructure(ssConectaProveedores.RestRecords.RESTRC_a7be5795c4af08fa8098110e55d36aff obj) { 
  RC_a7be5795c4af08fa8098110e55d36aff s = new RC_a7be5795c4af08fa8098110e55d36aff();
  if(obj != null) {
  s.ssENProcessStatus = ssConectaProveedores.RestRecords.RESTENProcessStatusEntityRecord.ToStructure(obj.AttrProcessStatus);
  }
  return s;
}

public static Func<RC_a7be5795c4af08fa8098110e55d36aff, ssConectaProveedores.RestRecords.RESTRC_a7be5795c4af08fa8098110e55d36aff> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a7be5795c4af08fa8098110e55d36aff s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a7be5795c4af08fa8098110e55d36aff FromStructure(RC_a7be5795c4af08fa8098110e55d36aff s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a7be5795c4af08fa8098110e55d36aff(s, config);
}

}


