using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SeriesType
public class RESTEN_12004a480323e1caa1d0e9cb95ddd993EntityRecord : AbstractRESTStructure<EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord> {
[JsonProperty("Type")]
public string AttrType;

public RESTEN_12004a480323e1caa1d0e9cb95ddd993EntityRecord() { }

public RESTEN_12004a480323e1caa1d0e9cb95ddd993EntityRecord (EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrType = s.ssType;
  } else {
AttrType = s.ssType;
  }
}

public static EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_12004a480323e1caa1d0e9cb95ddd993EntityRecord obj) { 
  EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord s = new EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord();
  if(obj != null) {
  s.ssType = obj.AttrType == null ? "" : obj.AttrType;
  }
  return s;
}

public static Func<EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord, ssConectaProveedores.RestRecords.RESTEN_12004a480323e1caa1d0e9cb95ddd993EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_12004a480323e1caa1d0e9cb95ddd993EntityRecord FromStructure(EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_12004a480323e1caa1d0e9cb95ddd993EntityRecord(s, config);
}

}


