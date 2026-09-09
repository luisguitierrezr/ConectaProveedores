using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// BreakColumns
public class JSONEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord : AbstractRESTStructure<EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord> {
[JsonProperty("BreakColumns")]
[JsonPropertyName("BreakColumns")]
public string AttrBreakColumns;

public JSONEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord() { }

public JSONEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord (EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBreakColumns = s.ssBreakColumns;
  } else {
AttrBreakColumns = s.ssBreakColumns;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord, EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord s) => ToStructure(s, config);
}
public static EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord s = new EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord();
  if(obj != null) {
  s.ssBreakColumns = obj.AttrBreakColumns == null ? "" : obj.AttrBreakColumns;
  }
  return s;
}

public static Func<EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord FromStructure(EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord(s, config);
}

}


