using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FileExtendedRecord
public class JSONRC_6e3ea28d2c552bc2cc129f42297e5982 : AbstractRESTStructure<RC_6e3ea28d2c552bc2cc129f42297e5982> {
[JsonProperty("FileExtended")]
[JsonPropertyName("FileExtended")]
public ssConectaProveedores.RestRecords.JSONEN_dcebdd8ba305133f41b1e1804925997fEntityRecord AttrFileExtended;

public JSONRC_6e3ea28d2c552bc2cc129f42297e5982() { }

public JSONRC_6e3ea28d2c552bc2cc129f42297e5982 (RC_6e3ea28d2c552bc2cc129f42297e5982 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFileExtended = ConvertToRestWithoutDefaults(s.ssENFileExtended, new EN_dcebdd8ba305133f41b1e1804925997fEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_dcebdd8ba305133f41b1e1804925997fEntityRecord.FromStructure, config);
  } else {
AttrFileExtended = ssConectaProveedores.RestRecords.JSONEN_dcebdd8ba305133f41b1e1804925997fEntityRecord.FromStructure(s.ssENFileExtended, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_6e3ea28d2c552bc2cc129f42297e5982, RC_6e3ea28d2c552bc2cc129f42297e5982> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_6e3ea28d2c552bc2cc129f42297e5982 s) => ToStructure(s, config);
}
public static RC_6e3ea28d2c552bc2cc129f42297e5982 ToStructure(ssConectaProveedores.RestRecords.JSONRC_6e3ea28d2c552bc2cc129f42297e5982 obj, IBehaviorsConfiguration config) { 
  RC_6e3ea28d2c552bc2cc129f42297e5982 s = new RC_6e3ea28d2c552bc2cc129f42297e5982();
  if(obj != null) {
  s.ssENFileExtended = ssConectaProveedores.RestRecords.JSONEN_dcebdd8ba305133f41b1e1804925997fEntityRecord.ToStructure(obj.AttrFileExtended, config);
  }
  return s;
}

public static Func<RC_6e3ea28d2c552bc2cc129f42297e5982, ssConectaProveedores.RestRecords.JSONRC_6e3ea28d2c552bc2cc129f42297e5982> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6e3ea28d2c552bc2cc129f42297e5982 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_6e3ea28d2c552bc2cc129f42297e5982 FromStructure(RC_6e3ea28d2c552bc2cc129f42297e5982 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_6e3ea28d2c552bc2cc129f42297e5982(s, config);
}

}


