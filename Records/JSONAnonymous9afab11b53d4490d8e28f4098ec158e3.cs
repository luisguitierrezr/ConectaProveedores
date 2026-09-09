using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ColumnSettingsRecord
public class JSONRC_25c6d4ad26c50e9400baa0d709166594 : AbstractRESTStructure<RC_25c6d4ad26c50e9400baa0d709166594> {
[JsonProperty("ColumnSettings")]
[JsonPropertyName("ColumnSettings")]
public ssConectaProveedores.RestRecords.JSONEN_b8682919578ddd4d17f9eb185aad3c49EntityRecord AttrColumnSettings;

public JSONRC_25c6d4ad26c50e9400baa0d709166594() { }

public JSONRC_25c6d4ad26c50e9400baa0d709166594 (RC_25c6d4ad26c50e9400baa0d709166594 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrColumnSettings = ConvertToRestWithoutDefaults(s.ssENColumnSettings, new EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b8682919578ddd4d17f9eb185aad3c49EntityRecord.FromStructure, config);
  } else {
AttrColumnSettings = ssConectaProveedores.RestRecords.JSONEN_b8682919578ddd4d17f9eb185aad3c49EntityRecord.FromStructure(s.ssENColumnSettings, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_25c6d4ad26c50e9400baa0d709166594, RC_25c6d4ad26c50e9400baa0d709166594> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_25c6d4ad26c50e9400baa0d709166594 s) => ToStructure(s, config);
}
public static RC_25c6d4ad26c50e9400baa0d709166594 ToStructure(ssConectaProveedores.RestRecords.JSONRC_25c6d4ad26c50e9400baa0d709166594 obj, IBehaviorsConfiguration config) { 
  RC_25c6d4ad26c50e9400baa0d709166594 s = new RC_25c6d4ad26c50e9400baa0d709166594();
  if(obj != null) {
  s.ssENColumnSettings = ssConectaProveedores.RestRecords.JSONEN_b8682919578ddd4d17f9eb185aad3c49EntityRecord.ToStructure(obj.AttrColumnSettings, config);
  }
  return s;
}

public static Func<RC_25c6d4ad26c50e9400baa0d709166594, ssConectaProveedores.RestRecords.JSONRC_25c6d4ad26c50e9400baa0d709166594> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_25c6d4ad26c50e9400baa0d709166594 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_25c6d4ad26c50e9400baa0d709166594 FromStructure(RC_25c6d4ad26c50e9400baa0d709166594 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_25c6d4ad26c50e9400baa0d709166594(s, config);
}

}


