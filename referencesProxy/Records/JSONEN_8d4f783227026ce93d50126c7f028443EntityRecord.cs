using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// Orientation
public class JSONEN_8d4f783227026ce93d50126c7f028443EntityRecord : AbstractRESTStructure<EN_8d4f783227026ce93d50126c7f028443EntityRecord> {
[JsonProperty("Orientation")]
[JsonPropertyName("Orientation")]
public string AttrOrientation;

public JSONEN_8d4f783227026ce93d50126c7f028443EntityRecord() { }

public JSONEN_8d4f783227026ce93d50126c7f028443EntityRecord (EN_8d4f783227026ce93d50126c7f028443EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrientation = s.ssOrientation;
  } else {
AttrOrientation = s.ssOrientation;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_8d4f783227026ce93d50126c7f028443EntityRecord, EN_8d4f783227026ce93d50126c7f028443EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_8d4f783227026ce93d50126c7f028443EntityRecord s) => ToStructure(s, config);
}
public static EN_8d4f783227026ce93d50126c7f028443EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_8d4f783227026ce93d50126c7f028443EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_8d4f783227026ce93d50126c7f028443EntityRecord s = new EN_8d4f783227026ce93d50126c7f028443EntityRecord();
  if(obj != null) {
  s.ssOrientation = obj.AttrOrientation == null ? "" : obj.AttrOrientation;
  }
  return s;
}

public static Func<EN_8d4f783227026ce93d50126c7f028443EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_8d4f783227026ce93d50126c7f028443EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_8d4f783227026ce93d50126c7f028443EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_8d4f783227026ce93d50126c7f028443EntityRecord FromStructure(EN_8d4f783227026ce93d50126c7f028443EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_8d4f783227026ce93d50126c7f028443EntityRecord(s, config);
}

}


