using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// UserExtension
public class JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord : AbstractRESTStructure<EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

[JsonProperty("CorrespondentExternalEmail")]
[JsonPropertyName("CorrespondentExternalEmail")]
public string AttrCorrespondentExternalEmail;

[JsonProperty("Emailto")]
[JsonPropertyName("Emailto")]
public string AttrEmailto;

public JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord() { }

public JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord (EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
AttrCorrespondentExternalEmail = ConvertToRestWithoutDefaults(s.ssCorrespondentExternalEmail, "");
AttrEmailto = ConvertToRestWithoutDefaults(s.ssEmailto, "");
  } else {
AttrId = s.ssId;
AttrCorrespondentExternalEmail = s.ssCorrespondentExternalEmail;
AttrEmailto = s.ssEmailto;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord, EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord s) => ToStructure(s, config);
}
public static EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord s = new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  s.ssCorrespondentExternalEmail = obj.AttrCorrespondentExternalEmail == null ? "" : obj.AttrCorrespondentExternalEmail;
  s.ssEmailto = obj.AttrEmailto == null ? "" : obj.AttrEmailto;
  }
  return s;
}

public static Func<EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord FromStructure(EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord(s, config);
}

}


