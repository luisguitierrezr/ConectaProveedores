using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// HTTPHeaderRecord
public class RESTRC_71c4d11a939585674ac683863dab8f61 : AbstractRESTStructure<RC_71c4d11a939585674ac683863dab8f61> {
[JsonProperty("HTTPHeader")]
public ssConectaProveedores.RestRecords.RESTST_3cf3b984041595af1703070620d6367bStructure AttrHTTPHeader;

public RESTRC_71c4d11a939585674ac683863dab8f61() { }

public RESTRC_71c4d11a939585674ac683863dab8f61 (RC_71c4d11a939585674ac683863dab8f61 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrHTTPHeader = ConvertToRestWithoutDefaults(s.ssSTHTTPHeader, new ST_3cf3b984041595af1703070620d6367bStructure(), ssConectaProveedores.RestRecords.RESTST_3cf3b984041595af1703070620d6367bStructure.FromStructure, config);
  } else {
AttrHTTPHeader = ssConectaProveedores.RestRecords.RESTST_3cf3b984041595af1703070620d6367bStructure.FromStructure(s.ssSTHTTPHeader, config);
  }
}

public static RC_71c4d11a939585674ac683863dab8f61 ToStructure(ssConectaProveedores.RestRecords.RESTRC_71c4d11a939585674ac683863dab8f61 obj) { 
  RC_71c4d11a939585674ac683863dab8f61 s = new RC_71c4d11a939585674ac683863dab8f61();
  if(obj != null) {
  s.ssSTHTTPHeader = ssConectaProveedores.RestRecords.RESTST_3cf3b984041595af1703070620d6367bStructure.ToStructure(obj.AttrHTTPHeader);
  }
  return s;
}

public static Func<RC_71c4d11a939585674ac683863dab8f61, ssConectaProveedores.RestRecords.RESTRC_71c4d11a939585674ac683863dab8f61> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_71c4d11a939585674ac683863dab8f61 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_71c4d11a939585674ac683863dab8f61 FromStructure(RC_71c4d11a939585674ac683863dab8f61 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_71c4d11a939585674ac683863dab8f61(s, config);
}

}


