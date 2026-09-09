using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// User_Extended_InternalDepartmentRecord
public class JSONRC_b29687471c7561fc031c1c100f2316ce : AbstractRESTStructure<RC_b29687471c7561fc031c1c100f2316ce> {
[JsonProperty("User_Extended_Internal")]
[JsonPropertyName("User_Extended_Internal")]
public ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord AttrUser_Extended_Internal;

[JsonProperty("Department")]
[JsonPropertyName("Department")]
public ssConectaProveedores.RestRecords.JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord AttrDepartment;

public JSONRC_b29687471c7561fc031c1c100f2316ce() { }

public JSONRC_b29687471c7561fc031c1c100f2316ce (RC_b29687471c7561fc031c1c100f2316ce s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
AttrDepartment = ConvertToRestWithoutDefaults(s.ssENDepartment, new EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord.FromStructure, config);
  } else {
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
AttrDepartment = ssConectaProveedores.RestRecords.JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord.FromStructure(s.ssENDepartment, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_b29687471c7561fc031c1c100f2316ce, RC_b29687471c7561fc031c1c100f2316ce> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_b29687471c7561fc031c1c100f2316ce s) => ToStructure(s, config);
}
public static RC_b29687471c7561fc031c1c100f2316ce ToStructure(ssConectaProveedores.RestRecords.JSONRC_b29687471c7561fc031c1c100f2316ce obj, IBehaviorsConfiguration config) { 
  RC_b29687471c7561fc031c1c100f2316ce s = new RC_b29687471c7561fc031c1c100f2316ce();
  if(obj != null) {
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal, config);
  s.ssENDepartment = ssConectaProveedores.RestRecords.JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord.ToStructure(obj.AttrDepartment, config);
  }
  return s;
}

public static Func<RC_b29687471c7561fc031c1c100f2316ce, ssConectaProveedores.RestRecords.JSONRC_b29687471c7561fc031c1c100f2316ce> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b29687471c7561fc031c1c100f2316ce s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_b29687471c7561fc031c1c100f2316ce FromStructure(RC_b29687471c7561fc031c1c100f2316ce s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_b29687471c7561fc031c1c100f2316ce(s, config);
}

}


