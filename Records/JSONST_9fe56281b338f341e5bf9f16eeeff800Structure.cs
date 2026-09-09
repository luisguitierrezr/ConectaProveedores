using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TI_RETENCIONES_Out3
public class JSONST_9fe56281b338f341e5bf9f16eeeff800Structure : AbstractRESTStructure<ST_9fe56281b338f341e5bf9f16eeeff800Structure> {
[JsonProperty("WITHT")]
[JsonPropertyName("WITHT")]
public string AttrWITHT;

[JsonProperty("WT_WITHCD")]
[JsonPropertyName("WT_WITHCD")]
public string AttrWT_WITHCD;

[JsonProperty("WT_SUBJCT")]
[JsonPropertyName("WT_SUBJCT")]
public string AttrWT_SUBJCT;

public JSONST_9fe56281b338f341e5bf9f16eeeff800Structure() { }

public JSONST_9fe56281b338f341e5bf9f16eeeff800Structure (ST_9fe56281b338f341e5bf9f16eeeff800Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrWITHT = ConvertToRestWithoutDefaults(s.ssWITHT, "");
AttrWT_WITHCD = ConvertToRestWithoutDefaults(s.ssWT_WITHCD, "");
AttrWT_SUBJCT = ConvertToRestWithoutDefaults(s.ssWT_SUBJCT, "");
  } else {
AttrWITHT = s.ssWITHT;
AttrWT_WITHCD = s.ssWT_WITHCD;
AttrWT_SUBJCT = s.ssWT_SUBJCT;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_9fe56281b338f341e5bf9f16eeeff800Structure, ST_9fe56281b338f341e5bf9f16eeeff800Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_9fe56281b338f341e5bf9f16eeeff800Structure s) => ToStructure(s, config);
}
public static ST_9fe56281b338f341e5bf9f16eeeff800Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_9fe56281b338f341e5bf9f16eeeff800Structure obj, IBehaviorsConfiguration config) { 
  ST_9fe56281b338f341e5bf9f16eeeff800Structure s = new ST_9fe56281b338f341e5bf9f16eeeff800Structure();
  if(obj != null) {
  s.ssWITHT = obj.AttrWITHT == null ? "" : obj.AttrWITHT;
  s.ssWT_WITHCD = obj.AttrWT_WITHCD == null ? "" : obj.AttrWT_WITHCD;
  s.ssWT_SUBJCT = obj.AttrWT_SUBJCT == null ? "" : obj.AttrWT_SUBJCT;
  }
  return s;
}

public static Func<ST_9fe56281b338f341e5bf9f16eeeff800Structure, ssConectaProveedores.RestRecords.JSONST_9fe56281b338f341e5bf9f16eeeff800Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_9fe56281b338f341e5bf9f16eeeff800Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_9fe56281b338f341e5bf9f16eeeff800Structure FromStructure(ST_9fe56281b338f341e5bf9f16eeeff800Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_9fe56281b338f341e5bf9f16eeeff800Structure(s, config);
}

}


