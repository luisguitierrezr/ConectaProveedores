using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OnPremisesExtensionAttribute
public class JSONST_f5088e93197e1d0bc0e83e9a247c44fbStructure : AbstractRESTStructure<ST_f5088e93197e1d0bc0e83e9a247c44fbStructure> {
[JsonProperty("extensionAttribute1")]
[JsonPropertyName("extensionAttribute1")]
public string AttrExtensionAttribute1;

public JSONST_f5088e93197e1d0bc0e83e9a247c44fbStructure() { }

public JSONST_f5088e93197e1d0bc0e83e9a247c44fbStructure (ST_f5088e93197e1d0bc0e83e9a247c44fbStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrExtensionAttribute1 = ConvertToRestWithoutDefaults(s.ssExtensionAttribute1, "");
  } else {
AttrExtensionAttribute1 = s.ssExtensionAttribute1;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_f5088e93197e1d0bc0e83e9a247c44fbStructure, ST_f5088e93197e1d0bc0e83e9a247c44fbStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_f5088e93197e1d0bc0e83e9a247c44fbStructure s) => ToStructure(s, config);
}
public static ST_f5088e93197e1d0bc0e83e9a247c44fbStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_f5088e93197e1d0bc0e83e9a247c44fbStructure obj, IBehaviorsConfiguration config) { 
  ST_f5088e93197e1d0bc0e83e9a247c44fbStructure s = new ST_f5088e93197e1d0bc0e83e9a247c44fbStructure();
  if(obj != null) {
  s.ssExtensionAttribute1 = obj.AttrExtensionAttribute1 == null ? "" : obj.AttrExtensionAttribute1;
  }
  return s;
}

public static Func<ST_f5088e93197e1d0bc0e83e9a247c44fbStructure, ssConectaProveedores.RestRecords.JSONST_f5088e93197e1d0bc0e83e9a247c44fbStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f5088e93197e1d0bc0e83e9a247c44fbStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_f5088e93197e1d0bc0e83e9a247c44fbStructure FromStructure(ST_f5088e93197e1d0bc0e83e9a247c44fbStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_f5088e93197e1d0bc0e83e9a247c44fbStructure(s, config);
}

}


