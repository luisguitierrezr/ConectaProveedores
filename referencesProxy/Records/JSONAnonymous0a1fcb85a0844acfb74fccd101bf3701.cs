using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// DepartmentRecord
public class JSONRC_a091342374a4b333cc44c9d3c7cd8caa : AbstractRESTStructure<RC_a091342374a4b333cc44c9d3c7cd8caa> {
[JsonProperty("Department")]
[JsonPropertyName("Department")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord AttrDepartment;

public JSONRC_a091342374a4b333cc44c9d3c7cd8caa() { }

public JSONRC_a091342374a4b333cc44c9d3c7cd8caa (RC_a091342374a4b333cc44c9d3c7cd8caa s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDepartment = ConvertToRestWithoutDefaults(s.ssENDepartment, new EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord.FromStructure, config);
  } else {
AttrDepartment = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord.FromStructure(s.ssENDepartment, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a091342374a4b333cc44c9d3c7cd8caa, RC_a091342374a4b333cc44c9d3c7cd8caa> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a091342374a4b333cc44c9d3c7cd8caa s) => ToStructure(s, config);
}
public static RC_a091342374a4b333cc44c9d3c7cd8caa ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a091342374a4b333cc44c9d3c7cd8caa obj, IBehaviorsConfiguration config) { 
  RC_a091342374a4b333cc44c9d3c7cd8caa s = new RC_a091342374a4b333cc44c9d3c7cd8caa();
  if(obj != null) {
  s.ssENDepartment = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord.ToStructure(obj.AttrDepartment, config);
  }
  return s;
}

public static Func<RC_a091342374a4b333cc44c9d3c7cd8caa, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a091342374a4b333cc44c9d3c7cd8caa> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a091342374a4b333cc44c9d3c7cd8caa s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a091342374a4b333cc44c9d3c7cd8caa FromStructure(RC_a091342374a4b333cc44c9d3c7cd8caa s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a091342374a4b333cc44c9d3c7cd8caa(s, config);
}

}


