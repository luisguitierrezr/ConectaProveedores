using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessProcessTypeRecord
public class JSONRC_9c2c2f8777df5db915ea9753325ce8dd : AbstractRESTStructure<RC_9c2c2f8777df5db915ea9753325ce8dd> {
[JsonProperty("ApprovalProcess")]
[JsonPropertyName("ApprovalProcess")]
public ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord AttrApprovalProcess;

[JsonProperty("ProcessType")]
[JsonPropertyName("ProcessType")]
public ssConectaProveedores.RestRecords.JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord AttrProcessType;

public JSONRC_9c2c2f8777df5db915ea9753325ce8dd() { }

public JSONRC_9c2c2f8777df5db915ea9753325ce8dd (RC_9c2c2f8777df5db915ea9753325ce8dd s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcess = ConvertToRestWithoutDefaults(s.ssENApprovalProcess, new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure, config);
AttrProcessType = ConvertToRestWithoutDefaults(s.ssENProcessType, new EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.FromStructure, config);
  } else {
AttrApprovalProcess = ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure(s.ssENApprovalProcess, config);
AttrProcessType = ssConectaProveedores.RestRecords.JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.FromStructure(s.ssENProcessType, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_9c2c2f8777df5db915ea9753325ce8dd, RC_9c2c2f8777df5db915ea9753325ce8dd> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_9c2c2f8777df5db915ea9753325ce8dd s) => ToStructure(s, config);
}
public static RC_9c2c2f8777df5db915ea9753325ce8dd ToStructure(ssConectaProveedores.RestRecords.JSONRC_9c2c2f8777df5db915ea9753325ce8dd obj, IBehaviorsConfiguration config) { 
  RC_9c2c2f8777df5db915ea9753325ce8dd s = new RC_9c2c2f8777df5db915ea9753325ce8dd();
  if(obj != null) {
  s.ssENApprovalProcess = ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.ToStructure(obj.AttrApprovalProcess, config);
  s.ssENProcessType = ssConectaProveedores.RestRecords.JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.ToStructure(obj.AttrProcessType, config);
  }
  return s;
}

public static Func<RC_9c2c2f8777df5db915ea9753325ce8dd, ssConectaProveedores.RestRecords.JSONRC_9c2c2f8777df5db915ea9753325ce8dd> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9c2c2f8777df5db915ea9753325ce8dd s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_9c2c2f8777df5db915ea9753325ce8dd FromStructure(RC_9c2c2f8777df5db915ea9753325ce8dd s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_9c2c2f8777df5db915ea9753325ce8dd(s, config);
}

}


