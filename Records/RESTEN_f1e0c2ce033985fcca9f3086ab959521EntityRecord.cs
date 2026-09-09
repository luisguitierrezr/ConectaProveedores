using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserExtension
public class RESTEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord : AbstractRESTStructure<EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord> {
[JsonProperty("Id")]
public string AttrId;

[JsonProperty("CorrespondentExternalEmail")]
public string AttrCorrespondentExternalEmail;

[JsonProperty("Emailto")]
public string AttrEmailto;

public RESTEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord() { }

public RESTEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord (EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord obj) { 
  EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord s = new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  s.ssCorrespondentExternalEmail = obj.AttrCorrespondentExternalEmail == null ? "" : obj.AttrCorrespondentExternalEmail;
  s.ssEmailto = obj.AttrEmailto == null ? "" : obj.AttrEmailto;
  }
  return s;
}

public static Func<EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord, ssConectaProveedores.RestRecords.RESTEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord FromStructure(EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord(s, config);
}

}


