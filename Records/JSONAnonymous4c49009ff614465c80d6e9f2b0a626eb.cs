using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RecordCreatedUpdatedLogStructRecord
public class JSONRC_12cddf42302e28dc02ca66ca24756e12 : AbstractRESTStructure<RC_12cddf42302e28dc02ca66ca24756e12> {
[JsonProperty("RecordCreatedUpdatedLogStruct")]
[JsonPropertyName("RecordCreatedUpdatedLogStruct")]
public ssConectaProveedores.RestRecords.JSONST_26711e61541f079fb4510d8f9bfa1e3dStructure AttrRecordCreatedUpdatedLogStruct;

public JSONRC_12cddf42302e28dc02ca66ca24756e12() { }

public JSONRC_12cddf42302e28dc02ca66ca24756e12 (RC_12cddf42302e28dc02ca66ca24756e12 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRecordCreatedUpdatedLogStruct = ConvertToRestWithoutDefaults(s.ssSTRecordCreatedUpdatedLogStruct, new ST_26711e61541f079fb4510d8f9bfa1e3dStructure(), ssConectaProveedores.RestRecords.JSONST_26711e61541f079fb4510d8f9bfa1e3dStructure.FromStructure, config);
  } else {
AttrRecordCreatedUpdatedLogStruct = ssConectaProveedores.RestRecords.JSONST_26711e61541f079fb4510d8f9bfa1e3dStructure.FromStructure(s.ssSTRecordCreatedUpdatedLogStruct, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_12cddf42302e28dc02ca66ca24756e12, RC_12cddf42302e28dc02ca66ca24756e12> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_12cddf42302e28dc02ca66ca24756e12 s) => ToStructure(s, config);
}
public static RC_12cddf42302e28dc02ca66ca24756e12 ToStructure(ssConectaProveedores.RestRecords.JSONRC_12cddf42302e28dc02ca66ca24756e12 obj, IBehaviorsConfiguration config) { 
  RC_12cddf42302e28dc02ca66ca24756e12 s = new RC_12cddf42302e28dc02ca66ca24756e12();
  if(obj != null) {
  s.ssSTRecordCreatedUpdatedLogStruct = ssConectaProveedores.RestRecords.JSONST_26711e61541f079fb4510d8f9bfa1e3dStructure.ToStructure(obj.AttrRecordCreatedUpdatedLogStruct, config);
  }
  return s;
}

public static Func<RC_12cddf42302e28dc02ca66ca24756e12, ssConectaProveedores.RestRecords.JSONRC_12cddf42302e28dc02ca66ca24756e12> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_12cddf42302e28dc02ca66ca24756e12 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_12cddf42302e28dc02ca66ca24756e12 FromStructure(RC_12cddf42302e28dc02ca66ca24756e12 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_12cddf42302e28dc02ca66ca24756e12(s, config);
}

}


