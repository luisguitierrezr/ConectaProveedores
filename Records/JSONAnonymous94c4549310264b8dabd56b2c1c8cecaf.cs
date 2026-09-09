using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserUser_Extended_InternalRecord
public class JSONRC_34272dae45b4de5e1332f46c6e8700b9 : AbstractRESTStructure<RC_34272dae45b4de5e1332f46c6e8700b9> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("User_Extended_Internal")]
[JsonPropertyName("User_Extended_Internal")]
public ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord AttrUser_Extended_Internal;

public JSONRC_34272dae45b4de5e1332f46c6e8700b9() { }

public JSONRC_34272dae45b4de5e1332f46c6e8700b9 (RC_34272dae45b4de5e1332f46c6e8700b9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_34272dae45b4de5e1332f46c6e8700b9, RC_34272dae45b4de5e1332f46c6e8700b9> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_34272dae45b4de5e1332f46c6e8700b9 s) => ToStructure(s, config);
}
public static RC_34272dae45b4de5e1332f46c6e8700b9 ToStructure(ssConectaProveedores.RestRecords.JSONRC_34272dae45b4de5e1332f46c6e8700b9 obj, IBehaviorsConfiguration config) { 
  RC_34272dae45b4de5e1332f46c6e8700b9 s = new RC_34272dae45b4de5e1332f46c6e8700b9();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal, config);
  }
  return s;
}

public static Func<RC_34272dae45b4de5e1332f46c6e8700b9, ssConectaProveedores.RestRecords.JSONRC_34272dae45b4de5e1332f46c6e8700b9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_34272dae45b4de5e1332f46c6e8700b9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_34272dae45b4de5e1332f46c6e8700b9 FromStructure(RC_34272dae45b4de5e1332f46c6e8700b9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_34272dae45b4de5e1332f46c6e8700b9(s, config);
}

}


