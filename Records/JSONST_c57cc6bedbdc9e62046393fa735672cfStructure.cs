using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UpdateUserResult
public class JSONST_c57cc6bedbdc9e62046393fa735672cfStructure : AbstractRESTStructure<ST_c57cc6bedbdc9e62046393fa735672cfStructure> {
[JsonProperty("Success")]
[JsonPropertyName("Success")]
public bool? AttrSuccess;

[JsonProperty("UserPhotoURL")]
[JsonPropertyName("UserPhotoURL")]
public string AttrUserPhotoURL;

[JsonProperty("UpdateUserFailureReason")]
[JsonPropertyName("UpdateUserFailureReason")]
public ssConectaProveedores.RestRecords.JSONST_6f88d6be05f2234ba151435ee8bf2cd4Structure AttrUpdateUserFailureReason;

public JSONST_c57cc6bedbdc9e62046393fa735672cfStructure() { }

public JSONST_c57cc6bedbdc9e62046393fa735672cfStructure (ST_c57cc6bedbdc9e62046393fa735672cfStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSuccess = ConvertToRestWithoutDefaults(s.ssSuccess, false);
AttrUserPhotoURL = ConvertToRestWithoutDefaults(s.ssUserPhotoURL, "");
AttrUpdateUserFailureReason = ConvertToRestWithoutDefaults(s.ssUpdateUserFailureReason, new ST_6f88d6be05f2234ba151435ee8bf2cd4Structure(), ssConectaProveedores.RestRecords.JSONST_6f88d6be05f2234ba151435ee8bf2cd4Structure.FromStructure, config);
  } else {
AttrSuccess = (bool?) s.ssSuccess;
AttrUserPhotoURL = s.ssUserPhotoURL;
AttrUpdateUserFailureReason = ssConectaProveedores.RestRecords.JSONST_6f88d6be05f2234ba151435ee8bf2cd4Structure.FromStructure(s.ssUpdateUserFailureReason, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_c57cc6bedbdc9e62046393fa735672cfStructure, ST_c57cc6bedbdc9e62046393fa735672cfStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_c57cc6bedbdc9e62046393fa735672cfStructure s) => ToStructure(s, config);
}
public static ST_c57cc6bedbdc9e62046393fa735672cfStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_c57cc6bedbdc9e62046393fa735672cfStructure obj, IBehaviorsConfiguration config) { 
  ST_c57cc6bedbdc9e62046393fa735672cfStructure s = new ST_c57cc6bedbdc9e62046393fa735672cfStructure();
  if(obj != null) {
  s.ssSuccess = obj.AttrSuccess == null ? false : obj.AttrSuccess.Value;
  s.ssUserPhotoURL = obj.AttrUserPhotoURL == null ? "" : obj.AttrUserPhotoURL;
  s.ssUpdateUserFailureReason = ssConectaProveedores.RestRecords.JSONST_6f88d6be05f2234ba151435ee8bf2cd4Structure.ToStructure(obj.AttrUpdateUserFailureReason, config);
  }
  return s;
}

public static Func<ST_c57cc6bedbdc9e62046393fa735672cfStructure, ssConectaProveedores.RestRecords.JSONST_c57cc6bedbdc9e62046393fa735672cfStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_c57cc6bedbdc9e62046393fa735672cfStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_c57cc6bedbdc9e62046393fa735672cfStructure FromStructure(ST_c57cc6bedbdc9e62046393fa735672cfStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_c57cc6bedbdc9e62046393fa735672cfStructure(s, config);
}

}


