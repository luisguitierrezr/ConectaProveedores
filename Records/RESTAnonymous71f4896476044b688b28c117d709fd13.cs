using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessProcessTypeRecord
public class RESTRC_9c2c2f8777df5db915ea9753325ce8dd : AbstractRESTStructure<RC_9c2c2f8777df5db915ea9753325ce8dd> {
[JsonProperty("ApprovalProcess")]
public ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord AttrApprovalProcess;

[JsonProperty("ProcessType")]
public ssConectaProveedores.RestRecords.RESTEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord AttrProcessType;

public RESTRC_9c2c2f8777df5db915ea9753325ce8dd() { }

public RESTRC_9c2c2f8777df5db915ea9753325ce8dd (RC_9c2c2f8777df5db915ea9753325ce8dd s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcess = ConvertToRestWithoutDefaults(s.ssENApprovalProcess, new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure, config);
AttrProcessType = ConvertToRestWithoutDefaults(s.ssENProcessType, new EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.FromStructure, config);
  } else {
AttrApprovalProcess = ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure(s.ssENApprovalProcess, config);
AttrProcessType = ssConectaProveedores.RestRecords.RESTEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.FromStructure(s.ssENProcessType, config);
  }
}

public static RC_9c2c2f8777df5db915ea9753325ce8dd ToStructure(ssConectaProveedores.RestRecords.RESTRC_9c2c2f8777df5db915ea9753325ce8dd obj) { 
  RC_9c2c2f8777df5db915ea9753325ce8dd s = new RC_9c2c2f8777df5db915ea9753325ce8dd();
  if(obj != null) {
  s.ssENApprovalProcess = ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.ToStructure(obj.AttrApprovalProcess);
  s.ssENProcessType = ssConectaProveedores.RestRecords.RESTEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.ToStructure(obj.AttrProcessType);
  }
  return s;
}

public static Func<RC_9c2c2f8777df5db915ea9753325ce8dd, ssConectaProveedores.RestRecords.RESTRC_9c2c2f8777df5db915ea9753325ce8dd> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9c2c2f8777df5db915ea9753325ce8dd s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_9c2c2f8777df5db915ea9753325ce8dd FromStructure(RC_9c2c2f8777df5db915ea9753325ce8dd s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_9c2c2f8777df5db915ea9753325ce8dd(s, config);
}

}


