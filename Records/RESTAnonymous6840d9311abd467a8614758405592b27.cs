using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ManualFileRecord
public class RESTRC_6d042e8f6faf9c16a51afdc5d65092dd : AbstractRESTStructure<RC_6d042e8f6faf9c16a51afdc5d65092dd> {
[JsonProperty("ManualFile")]
public ssConectaProveedores.RestRecords.RESTEN_d89d65949fc0664870ebc65ca42d2f63EntityRecord AttrManualFile;

public RESTRC_6d042e8f6faf9c16a51afdc5d65092dd() { }

public RESTRC_6d042e8f6faf9c16a51afdc5d65092dd (RC_6d042e8f6faf9c16a51afdc5d65092dd s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrManualFile = ConvertToRestWithoutDefaults(s.ssENManualFile, new EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d89d65949fc0664870ebc65ca42d2f63EntityRecord.FromStructure, config);
  } else {
AttrManualFile = ssConectaProveedores.RestRecords.RESTEN_d89d65949fc0664870ebc65ca42d2f63EntityRecord.FromStructure(s.ssENManualFile, config);
  }
}

public static RC_6d042e8f6faf9c16a51afdc5d65092dd ToStructure(ssConectaProveedores.RestRecords.RESTRC_6d042e8f6faf9c16a51afdc5d65092dd obj) { 
  RC_6d042e8f6faf9c16a51afdc5d65092dd s = new RC_6d042e8f6faf9c16a51afdc5d65092dd();
  if(obj != null) {
  s.ssENManualFile = ssConectaProveedores.RestRecords.RESTEN_d89d65949fc0664870ebc65ca42d2f63EntityRecord.ToStructure(obj.AttrManualFile);
  }
  return s;
}

public static Func<RC_6d042e8f6faf9c16a51afdc5d65092dd, ssConectaProveedores.RestRecords.RESTRC_6d042e8f6faf9c16a51afdc5d65092dd> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6d042e8f6faf9c16a51afdc5d65092dd s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_6d042e8f6faf9c16a51afdc5d65092dd FromStructure(RC_6d042e8f6faf9c16a51afdc5d65092dd s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_6d042e8f6faf9c16a51afdc5d65092dd(s, config);
}

}


