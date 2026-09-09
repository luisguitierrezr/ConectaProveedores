using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// HTTPHeaderRecord
public class JSONRC_71c4d11a939585674ac683863dab8f61 : AbstractRESTStructure<RC_71c4d11a939585674ac683863dab8f61> {
[JsonProperty("HTTPHeader")]
[JsonPropertyName("HTTPHeader")]
public ssConectaProveedores.RestRecords.JSONST_3cf3b984041595af1703070620d6367bStructure AttrHTTPHeader;

public JSONRC_71c4d11a939585674ac683863dab8f61() { }

public JSONRC_71c4d11a939585674ac683863dab8f61 (RC_71c4d11a939585674ac683863dab8f61 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrHTTPHeader = ConvertToRestWithoutDefaults(s.ssSTHTTPHeader, new ST_3cf3b984041595af1703070620d6367bStructure(), ssConectaProveedores.RestRecords.JSONST_3cf3b984041595af1703070620d6367bStructure.FromStructure, config);
  } else {
AttrHTTPHeader = ssConectaProveedores.RestRecords.JSONST_3cf3b984041595af1703070620d6367bStructure.FromStructure(s.ssSTHTTPHeader, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_71c4d11a939585674ac683863dab8f61, RC_71c4d11a939585674ac683863dab8f61> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_71c4d11a939585674ac683863dab8f61 s) => ToStructure(s, config);
}
public static RC_71c4d11a939585674ac683863dab8f61 ToStructure(ssConectaProveedores.RestRecords.JSONRC_71c4d11a939585674ac683863dab8f61 obj, IBehaviorsConfiguration config) { 
  RC_71c4d11a939585674ac683863dab8f61 s = new RC_71c4d11a939585674ac683863dab8f61();
  if(obj != null) {
  s.ssSTHTTPHeader = ssConectaProveedores.RestRecords.JSONST_3cf3b984041595af1703070620d6367bStructure.ToStructure(obj.AttrHTTPHeader, config);
  }
  return s;
}

public static Func<RC_71c4d11a939585674ac683863dab8f61, ssConectaProveedores.RestRecords.JSONRC_71c4d11a939585674ac683863dab8f61> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_71c4d11a939585674ac683863dab8f61 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_71c4d11a939585674ac683863dab8f61 FromStructure(RC_71c4d11a939585674ac683863dab8f61 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_71c4d11a939585674ac683863dab8f61(s, config);
}

}


