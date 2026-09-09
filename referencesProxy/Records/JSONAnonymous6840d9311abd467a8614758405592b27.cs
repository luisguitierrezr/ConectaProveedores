using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ManualFileRecord
public class JSONRC_6d042e8f6faf9c16a51afdc5d65092dd : AbstractRESTStructure<RC_6d042e8f6faf9c16a51afdc5d65092dd> {
[JsonProperty("ManualFile")]
[JsonPropertyName("ManualFile")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_d89d65949fc0664870ebc65ca42d2f63EntityRecord AttrManualFile;

public JSONRC_6d042e8f6faf9c16a51afdc5d65092dd() { }

public JSONRC_6d042e8f6faf9c16a51afdc5d65092dd (RC_6d042e8f6faf9c16a51afdc5d65092dd s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrManualFile = ConvertToRestWithoutDefaults(s.ssENManualFile, new EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_d89d65949fc0664870ebc65ca42d2f63EntityRecord.FromStructure, config);
  } else {
AttrManualFile = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_d89d65949fc0664870ebc65ca42d2f63EntityRecord.FromStructure(s.ssENManualFile, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6d042e8f6faf9c16a51afdc5d65092dd, RC_6d042e8f6faf9c16a51afdc5d65092dd> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6d042e8f6faf9c16a51afdc5d65092dd s) => ToStructure(s, config);
}
public static RC_6d042e8f6faf9c16a51afdc5d65092dd ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6d042e8f6faf9c16a51afdc5d65092dd obj, IBehaviorsConfiguration config) { 
  RC_6d042e8f6faf9c16a51afdc5d65092dd s = new RC_6d042e8f6faf9c16a51afdc5d65092dd();
  if(obj != null) {
  s.ssENManualFile = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_d89d65949fc0664870ebc65ca42d2f63EntityRecord.ToStructure(obj.AttrManualFile, config);
  }
  return s;
}

public static Func<RC_6d042e8f6faf9c16a51afdc5d65092dd, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6d042e8f6faf9c16a51afdc5d65092dd> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6d042e8f6faf9c16a51afdc5d65092dd s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6d042e8f6faf9c16a51afdc5d65092dd FromStructure(RC_6d042e8f6faf9c16a51afdc5d65092dd s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6d042e8f6faf9c16a51afdc5d65092dd(s, config);
}

}


