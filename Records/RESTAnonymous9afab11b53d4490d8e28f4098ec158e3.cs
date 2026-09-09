using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ColumnSettingsRecord
public class RESTRC_25c6d4ad26c50e9400baa0d709166594 : AbstractRESTStructure<RC_25c6d4ad26c50e9400baa0d709166594> {
[JsonProperty("ColumnSettings")]
public ssConectaProveedores.RestRecords.RESTEN_b8682919578ddd4d17f9eb185aad3c49EntityRecord AttrColumnSettings;

public RESTRC_25c6d4ad26c50e9400baa0d709166594() { }

public RESTRC_25c6d4ad26c50e9400baa0d709166594 (RC_25c6d4ad26c50e9400baa0d709166594 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrColumnSettings = ConvertToRestWithoutDefaults(s.ssENColumnSettings, new EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b8682919578ddd4d17f9eb185aad3c49EntityRecord.FromStructure, config);
  } else {
AttrColumnSettings = ssConectaProveedores.RestRecords.RESTEN_b8682919578ddd4d17f9eb185aad3c49EntityRecord.FromStructure(s.ssENColumnSettings, config);
  }
}

public static RC_25c6d4ad26c50e9400baa0d709166594 ToStructure(ssConectaProveedores.RestRecords.RESTRC_25c6d4ad26c50e9400baa0d709166594 obj) { 
  RC_25c6d4ad26c50e9400baa0d709166594 s = new RC_25c6d4ad26c50e9400baa0d709166594();
  if(obj != null) {
  s.ssENColumnSettings = ssConectaProveedores.RestRecords.RESTEN_b8682919578ddd4d17f9eb185aad3c49EntityRecord.ToStructure(obj.AttrColumnSettings);
  }
  return s;
}

public static Func<RC_25c6d4ad26c50e9400baa0d709166594, ssConectaProveedores.RestRecords.RESTRC_25c6d4ad26c50e9400baa0d709166594> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_25c6d4ad26c50e9400baa0d709166594 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_25c6d4ad26c50e9400baa0d709166594 FromStructure(RC_25c6d4ad26c50e9400baa0d709166594 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_25c6d4ad26c50e9400baa0d709166594(s, config);
}

}


