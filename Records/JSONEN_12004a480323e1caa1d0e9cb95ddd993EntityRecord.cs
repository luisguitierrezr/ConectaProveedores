using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SeriesType
public class JSONEN_12004a480323e1caa1d0e9cb95ddd993EntityRecord : AbstractRESTStructure<EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord> {
[JsonProperty("Type")]
[JsonPropertyName("Type")]
public string AttrType;

public JSONEN_12004a480323e1caa1d0e9cb95ddd993EntityRecord() { }

public JSONEN_12004a480323e1caa1d0e9cb95ddd993EntityRecord (EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrType = s.ssType;
  } else {
AttrType = s.ssType;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_12004a480323e1caa1d0e9cb95ddd993EntityRecord, EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_12004a480323e1caa1d0e9cb95ddd993EntityRecord s) => ToStructure(s, config);
}
public static EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_12004a480323e1caa1d0e9cb95ddd993EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord s = new EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord();
  if(obj != null) {
  s.ssType = obj.AttrType == null ? "" : obj.AttrType;
  }
  return s;
}

public static Func<EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord, ssConectaProveedores.RestRecords.JSONEN_12004a480323e1caa1d0e9cb95ddd993EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_12004a480323e1caa1d0e9cb95ddd993EntityRecord FromStructure(EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_12004a480323e1caa1d0e9cb95ddd993EntityRecord(s, config);
}

}


