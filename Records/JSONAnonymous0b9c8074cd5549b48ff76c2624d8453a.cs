using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// User_Extended_InternalRecord
public class JSONRC_d979b4500d349dbbb37ac9f2fd2a6d68 : AbstractRESTStructure<RC_d979b4500d349dbbb37ac9f2fd2a6d68> {
[JsonProperty("User_Extended_Internal")]
[JsonPropertyName("User_Extended_Internal")]
public ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord AttrUser_Extended_Internal;

public JSONRC_d979b4500d349dbbb37ac9f2fd2a6d68() { }

public JSONRC_d979b4500d349dbbb37ac9f2fd2a6d68 (RC_d979b4500d349dbbb37ac9f2fd2a6d68 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
  } else {
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_d979b4500d349dbbb37ac9f2fd2a6d68, RC_d979b4500d349dbbb37ac9f2fd2a6d68> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_d979b4500d349dbbb37ac9f2fd2a6d68 s) => ToStructure(s, config);
}
public static RC_d979b4500d349dbbb37ac9f2fd2a6d68 ToStructure(ssConectaProveedores.RestRecords.JSONRC_d979b4500d349dbbb37ac9f2fd2a6d68 obj, IBehaviorsConfiguration config) { 
  RC_d979b4500d349dbbb37ac9f2fd2a6d68 s = new RC_d979b4500d349dbbb37ac9f2fd2a6d68();
  if(obj != null) {
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal, config);
  }
  return s;
}

public static Func<RC_d979b4500d349dbbb37ac9f2fd2a6d68, ssConectaProveedores.RestRecords.JSONRC_d979b4500d349dbbb37ac9f2fd2a6d68> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d979b4500d349dbbb37ac9f2fd2a6d68 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_d979b4500d349dbbb37ac9f2fd2a6d68 FromStructure(RC_d979b4500d349dbbb37ac9f2fd2a6d68 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_d979b4500d349dbbb37ac9f2fd2a6d68(s, config);
}

}


