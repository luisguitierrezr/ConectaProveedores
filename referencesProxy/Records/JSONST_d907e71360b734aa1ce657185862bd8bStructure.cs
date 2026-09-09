using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// OptionalConfigs
public class JSONST_d907e71360b734aa1ce657185862bd8bStructure : AbstractRESTStructure<ST_d907e71360b734aa1ce657185862bd8bStructure> {
[JsonProperty("disableLoadingAnimation")]
[JsonPropertyName("disableLoadingAnimation")]
public bool? AttrDisableLoadingAnimation;

public JSONST_d907e71360b734aa1ce657185862bd8bStructure() { }

public JSONST_d907e71360b734aa1ce657185862bd8bStructure (ST_d907e71360b734aa1ce657185862bd8bStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDisableLoadingAnimation = ConvertToRestWithoutDefaults(s.ssDisableLoadingAnimation, false);
  } else {
AttrDisableLoadingAnimation = (bool?) s.ssDisableLoadingAnimation;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_d907e71360b734aa1ce657185862bd8bStructure, ST_d907e71360b734aa1ce657185862bd8bStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_d907e71360b734aa1ce657185862bd8bStructure s) => ToStructure(s, config);
}
public static ST_d907e71360b734aa1ce657185862bd8bStructure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_d907e71360b734aa1ce657185862bd8bStructure obj, IBehaviorsConfiguration config) { 
  ST_d907e71360b734aa1ce657185862bd8bStructure s = new ST_d907e71360b734aa1ce657185862bd8bStructure();
  if(obj != null) {
  s.ssDisableLoadingAnimation = obj.AttrDisableLoadingAnimation == null ? false : obj.AttrDisableLoadingAnimation.Value;
  }
  return s;
}

public static Func<ST_d907e71360b734aa1ce657185862bd8bStructure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_d907e71360b734aa1ce657185862bd8bStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_d907e71360b734aa1ce657185862bd8bStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_d907e71360b734aa1ce657185862bd8bStructure FromStructure(ST_d907e71360b734aa1ce657185862bd8bStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_d907e71360b734aa1ce657185862bd8bStructure(s, config);
}

}


