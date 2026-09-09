using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionVersion
public class JSONEN_74284c742ed8c8eb5a05978b570ef620EntityRecord : AbstractRESTStructure<EN_74284c742ed8c8eb5a05978b570ef620EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("OriginalRequisitionId")]
[JsonPropertyName("OriginalRequisitionId")]
public long? AttrOriginalRequisitionId;

[JsonProperty("NewRequisitionId")]
[JsonPropertyName("NewRequisitionId")]
public long? AttrNewRequisitionId;

[JsonProperty("Version")]
[JsonPropertyName("Version")]
public int? AttrVersion;

public JSONEN_74284c742ed8c8eb5a05978b570ef620EntityRecord() { }

public JSONEN_74284c742ed8c8eb5a05978b570ef620EntityRecord (EN_74284c742ed8c8eb5a05978b570ef620EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrOriginalRequisitionId = ConvertToRestWithoutDefaults(s.ssOriginalRequisitionId, 0L);
AttrNewRequisitionId = ConvertToRestWithoutDefaults(s.ssNewRequisitionId, 0L);
AttrVersion = ConvertToRestWithoutDefaults(s.ssVersion, 0);
  } else {
AttrId = (long?) s.ssId;
AttrOriginalRequisitionId = (long?) s.ssOriginalRequisitionId;
AttrNewRequisitionId = (long?) s.ssNewRequisitionId;
AttrVersion = (int?) s.ssVersion;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_74284c742ed8c8eb5a05978b570ef620EntityRecord, EN_74284c742ed8c8eb5a05978b570ef620EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_74284c742ed8c8eb5a05978b570ef620EntityRecord s) => ToStructure(s, config);
}
public static EN_74284c742ed8c8eb5a05978b570ef620EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_74284c742ed8c8eb5a05978b570ef620EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_74284c742ed8c8eb5a05978b570ef620EntityRecord s = new EN_74284c742ed8c8eb5a05978b570ef620EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssOriginalRequisitionId = obj.AttrOriginalRequisitionId == null ? 0L : obj.AttrOriginalRequisitionId.Value;
  s.ssNewRequisitionId = obj.AttrNewRequisitionId == null ? 0L : obj.AttrNewRequisitionId.Value;
  s.ssVersion = obj.AttrVersion == null ? 0 : obj.AttrVersion.Value;
  }
  return s;
}

public static Func<EN_74284c742ed8c8eb5a05978b570ef620EntityRecord, ssConectaProveedores.RestRecords.JSONEN_74284c742ed8c8eb5a05978b570ef620EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_74284c742ed8c8eb5a05978b570ef620EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_74284c742ed8c8eb5a05978b570ef620EntityRecord FromStructure(EN_74284c742ed8c8eb5a05978b570ef620EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_74284c742ed8c8eb5a05978b570ef620EntityRecord(s, config);
}

}


