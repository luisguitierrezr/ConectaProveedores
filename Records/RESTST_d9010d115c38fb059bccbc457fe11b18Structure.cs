using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderRequestFileStruct
public class RESTST_d9010d115c38fb059bccbc457fe11b18Structure : AbstractRESTStructure<ST_d9010d115c38fb059bccbc457fe11b18Structure> {
[JsonProperty("OrderRequestFile")]
public ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord AttrOrderRequestFile;

[JsonProperty("Binary")]
public byte[] AttrBinary;

public RESTST_d9010d115c38fb059bccbc457fe11b18Structure() { }

public RESTST_d9010d115c38fb059bccbc457fe11b18Structure (ST_d9010d115c38fb059bccbc457fe11b18Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderRequestFile = ConvertToRestWithoutDefaults(s.ssOrderRequestFile, new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.FromStructure, config);
AttrBinary = ConvertToRestWithoutDefaults(s.ssBinary);
  } else {
AttrOrderRequestFile = ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.FromStructure(s.ssOrderRequestFile, config);
AttrBinary = s.ssBinary;
  }
}

public static ST_d9010d115c38fb059bccbc457fe11b18Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_d9010d115c38fb059bccbc457fe11b18Structure obj) { 
  ST_d9010d115c38fb059bccbc457fe11b18Structure s = new ST_d9010d115c38fb059bccbc457fe11b18Structure();
  if(obj != null) {
  s.ssOrderRequestFile = ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.ToStructure(obj.AttrOrderRequestFile);
  s.ssBinary = obj.AttrBinary == null ? new byte[] {} : obj.AttrBinary;
  }
  return s;
}

public static Func<ST_d9010d115c38fb059bccbc457fe11b18Structure, ssConectaProveedores.RestRecords.RESTST_d9010d115c38fb059bccbc457fe11b18Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_d9010d115c38fb059bccbc457fe11b18Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_d9010d115c38fb059bccbc457fe11b18Structure FromStructure(ST_d9010d115c38fb059bccbc457fe11b18Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_d9010d115c38fb059bccbc457fe11b18Structure(s, config);
}

}


