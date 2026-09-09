using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OnPremisesExtensionAttribute
public class RESTST_f5088e93197e1d0bc0e83e9a247c44fbStructure : AbstractRESTStructure<ST_f5088e93197e1d0bc0e83e9a247c44fbStructure> {
[JsonProperty("ExtensionAttribute1")]
public string AttrExtensionAttribute1;

public RESTST_f5088e93197e1d0bc0e83e9a247c44fbStructure() { }

public RESTST_f5088e93197e1d0bc0e83e9a247c44fbStructure (ST_f5088e93197e1d0bc0e83e9a247c44fbStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrExtensionAttribute1 = ConvertToRestWithoutDefaults(s.ssExtensionAttribute1, "");
  } else {
AttrExtensionAttribute1 = s.ssExtensionAttribute1;
  }
}

public static ST_f5088e93197e1d0bc0e83e9a247c44fbStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_f5088e93197e1d0bc0e83e9a247c44fbStructure obj) { 
  ST_f5088e93197e1d0bc0e83e9a247c44fbStructure s = new ST_f5088e93197e1d0bc0e83e9a247c44fbStructure();
  if(obj != null) {
  s.ssExtensionAttribute1 = obj.AttrExtensionAttribute1 == null ? "" : obj.AttrExtensionAttribute1;
  }
  return s;
}

public static Func<ST_f5088e93197e1d0bc0e83e9a247c44fbStructure, ssConectaProveedores.RestRecords.RESTST_f5088e93197e1d0bc0e83e9a247c44fbStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f5088e93197e1d0bc0e83e9a247c44fbStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_f5088e93197e1d0bc0e83e9a247c44fbStructure FromStructure(ST_f5088e93197e1d0bc0e83e9a247c44fbStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_f5088e93197e1d0bc0e83e9a247c44fbStructure(s, config);
}

}


