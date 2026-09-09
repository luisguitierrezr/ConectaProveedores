using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ErrorMessage2Record
public class JSONRC_6d8d0ab8b7a86a24d5f4b91570ad61d9 : AbstractRESTStructure<RC_6d8d0ab8b7a86a24d5f4b91570ad61d9> {
[JsonProperty("ErrorMessage")]
[JsonPropertyName("ErrorMessage")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_50c794173b7ac3485b1cda7be99f6b43Structure AttrErrorMessage2;

public JSONRC_6d8d0ab8b7a86a24d5f4b91570ad61d9() { }

public JSONRC_6d8d0ab8b7a86a24d5f4b91570ad61d9 (RC_6d8d0ab8b7a86a24d5f4b91570ad61d9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrErrorMessage2 = ConvertToRestWithoutDefaults(s.ssSTErrorMessage2, new ST_50c794173b7ac3485b1cda7be99f6b43Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_50c794173b7ac3485b1cda7be99f6b43Structure.FromStructure, config);
  } else {
AttrErrorMessage2 = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_50c794173b7ac3485b1cda7be99f6b43Structure.FromStructure(s.ssSTErrorMessage2, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6d8d0ab8b7a86a24d5f4b91570ad61d9, RC_6d8d0ab8b7a86a24d5f4b91570ad61d9> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6d8d0ab8b7a86a24d5f4b91570ad61d9 s) => ToStructure(s, config);
}
public static RC_6d8d0ab8b7a86a24d5f4b91570ad61d9 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6d8d0ab8b7a86a24d5f4b91570ad61d9 obj, IBehaviorsConfiguration config) { 
  RC_6d8d0ab8b7a86a24d5f4b91570ad61d9 s = new RC_6d8d0ab8b7a86a24d5f4b91570ad61d9();
  if(obj != null) {
  s.ssSTErrorMessage2 = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_50c794173b7ac3485b1cda7be99f6b43Structure.ToStructure(obj.AttrErrorMessage2, config);
  }
  return s;
}

public static Func<RC_6d8d0ab8b7a86a24d5f4b91570ad61d9, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6d8d0ab8b7a86a24d5f4b91570ad61d9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6d8d0ab8b7a86a24d5f4b91570ad61d9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6d8d0ab8b7a86a24d5f4b91570ad61d9 FromStructure(RC_6d8d0ab8b7a86a24d5f4b91570ad61d9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6d8d0ab8b7a86a24d5f4b91570ad61d9(s, config);
}

}


