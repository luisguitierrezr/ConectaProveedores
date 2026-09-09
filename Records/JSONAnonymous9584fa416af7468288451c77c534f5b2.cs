using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Z01_READ_TEXTReqRecord
public class JSONRC_0c0b0735f68bd3b21998309e63b78a99 : AbstractRESTStructure<RC_0c0b0735f68bd3b21998309e63b78a99> {
[JsonProperty("Z01_READ_TEXTReq")]
[JsonPropertyName("Z01_READ_TEXTReq")]
public ssConectaProveedores.RestRecords.JSONST_c4a97e6963b2cd0d749b56dde8d26a02Structure AttrZ01_READ_TEXTReq;

public JSONRC_0c0b0735f68bd3b21998309e63b78a99() { }

public JSONRC_0c0b0735f68bd3b21998309e63b78a99 (RC_0c0b0735f68bd3b21998309e63b78a99 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZ01_READ_TEXTReq = ConvertToRestWithoutDefaults(s.ssSTZ01_READ_TEXTReq, new ST_c4a97e6963b2cd0d749b56dde8d26a02Structure(), ssConectaProveedores.RestRecords.JSONST_c4a97e6963b2cd0d749b56dde8d26a02Structure.FromStructure, config);
  } else {
AttrZ01_READ_TEXTReq = ssConectaProveedores.RestRecords.JSONST_c4a97e6963b2cd0d749b56dde8d26a02Structure.FromStructure(s.ssSTZ01_READ_TEXTReq, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_0c0b0735f68bd3b21998309e63b78a99, RC_0c0b0735f68bd3b21998309e63b78a99> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_0c0b0735f68bd3b21998309e63b78a99 s) => ToStructure(s, config);
}
public static RC_0c0b0735f68bd3b21998309e63b78a99 ToStructure(ssConectaProveedores.RestRecords.JSONRC_0c0b0735f68bd3b21998309e63b78a99 obj, IBehaviorsConfiguration config) { 
  RC_0c0b0735f68bd3b21998309e63b78a99 s = new RC_0c0b0735f68bd3b21998309e63b78a99();
  if(obj != null) {
  s.ssSTZ01_READ_TEXTReq = ssConectaProveedores.RestRecords.JSONST_c4a97e6963b2cd0d749b56dde8d26a02Structure.ToStructure(obj.AttrZ01_READ_TEXTReq, config);
  }
  return s;
}

public static Func<RC_0c0b0735f68bd3b21998309e63b78a99, ssConectaProveedores.RestRecords.JSONRC_0c0b0735f68bd3b21998309e63b78a99> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0c0b0735f68bd3b21998309e63b78a99 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_0c0b0735f68bd3b21998309e63b78a99 FromStructure(RC_0c0b0735f68bd3b21998309e63b78a99 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_0c0b0735f68bd3b21998309e63b78a99(s, config);
}

}


