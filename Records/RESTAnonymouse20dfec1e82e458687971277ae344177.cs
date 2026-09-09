using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FileExtendedRecord
public class RESTRC_6e3ea28d2c552bc2cc129f42297e5982 : AbstractRESTStructure<RC_6e3ea28d2c552bc2cc129f42297e5982> {
[JsonProperty("FileExtended")]
public ssConectaProveedores.RestRecords.RESTEN_dcebdd8ba305133f41b1e1804925997fEntityRecord AttrFileExtended;

public RESTRC_6e3ea28d2c552bc2cc129f42297e5982() { }

public RESTRC_6e3ea28d2c552bc2cc129f42297e5982 (RC_6e3ea28d2c552bc2cc129f42297e5982 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFileExtended = ConvertToRestWithoutDefaults(s.ssENFileExtended, new EN_dcebdd8ba305133f41b1e1804925997fEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_dcebdd8ba305133f41b1e1804925997fEntityRecord.FromStructure, config);
  } else {
AttrFileExtended = ssConectaProveedores.RestRecords.RESTEN_dcebdd8ba305133f41b1e1804925997fEntityRecord.FromStructure(s.ssENFileExtended, config);
  }
}

public static RC_6e3ea28d2c552bc2cc129f42297e5982 ToStructure(ssConectaProveedores.RestRecords.RESTRC_6e3ea28d2c552bc2cc129f42297e5982 obj) { 
  RC_6e3ea28d2c552bc2cc129f42297e5982 s = new RC_6e3ea28d2c552bc2cc129f42297e5982();
  if(obj != null) {
  s.ssENFileExtended = ssConectaProveedores.RestRecords.RESTEN_dcebdd8ba305133f41b1e1804925997fEntityRecord.ToStructure(obj.AttrFileExtended);
  }
  return s;
}

public static Func<RC_6e3ea28d2c552bc2cc129f42297e5982, ssConectaProveedores.RestRecords.RESTRC_6e3ea28d2c552bc2cc129f42297e5982> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6e3ea28d2c552bc2cc129f42297e5982 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_6e3ea28d2c552bc2cc129f42297e5982 FromStructure(RC_6e3ea28d2c552bc2cc129f42297e5982 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_6e3ea28d2c552bc2cc129f42297e5982(s, config);
}

}


