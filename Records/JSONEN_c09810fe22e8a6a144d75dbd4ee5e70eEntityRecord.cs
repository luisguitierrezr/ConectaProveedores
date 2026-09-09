using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// LegendPosition
public class JSONEN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord : AbstractRESTStructure<EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord> {
[JsonProperty("Position")]
[JsonPropertyName("Position")]
public string AttrPosition;

public JSONEN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord() { }

public JSONEN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord (EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPosition = s.ssPosition;
  } else {
AttrPosition = s.ssPosition;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord, EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord s) => ToStructure(s, config);
}
public static EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord s = new EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord();
  if(obj != null) {
  s.ssPosition = obj.AttrPosition == null ? "" : obj.AttrPosition;
  }
  return s;
}

public static Func<EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord, ssConectaProveedores.RestRecords.JSONEN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord FromStructure(EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord(s, config);
}

}


