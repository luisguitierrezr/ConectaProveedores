using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DepartmentRecord
public class RESTRC_a091342374a4b333cc44c9d3c7cd8caa : AbstractRESTStructure<RC_a091342374a4b333cc44c9d3c7cd8caa> {
[JsonProperty("Department")]
public ssConectaProveedores.RestRecords.RESTEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord AttrDepartment;

public RESTRC_a091342374a4b333cc44c9d3c7cd8caa() { }

public RESTRC_a091342374a4b333cc44c9d3c7cd8caa (RC_a091342374a4b333cc44c9d3c7cd8caa s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDepartment = ConvertToRestWithoutDefaults(s.ssENDepartment, new EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord.FromStructure, config);
  } else {
AttrDepartment = ssConectaProveedores.RestRecords.RESTEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord.FromStructure(s.ssENDepartment, config);
  }
}

public static RC_a091342374a4b333cc44c9d3c7cd8caa ToStructure(ssConectaProveedores.RestRecords.RESTRC_a091342374a4b333cc44c9d3c7cd8caa obj) { 
  RC_a091342374a4b333cc44c9d3c7cd8caa s = new RC_a091342374a4b333cc44c9d3c7cd8caa();
  if(obj != null) {
  s.ssENDepartment = ssConectaProveedores.RestRecords.RESTEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord.ToStructure(obj.AttrDepartment);
  }
  return s;
}

public static Func<RC_a091342374a4b333cc44c9d3c7cd8caa, ssConectaProveedores.RestRecords.RESTRC_a091342374a4b333cc44c9d3c7cd8caa> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a091342374a4b333cc44c9d3c7cd8caa s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a091342374a4b333cc44c9d3c7cd8caa FromStructure(RC_a091342374a4b333cc44c9d3c7cd8caa s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a091342374a4b333cc44c9d3c7cd8caa(s, config);
}

}


