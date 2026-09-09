using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXFFIMF_OBT_TIP_CAMReq
public class RESTST_694abc44952847f050feca404fbee9c5Structure : AbstractRESTStructure<ST_694abc44952847f050feca404fbee9c5Structure> {
[JsonProperty("PI_FCURR")]
public string AttrPI_FCURR;

[JsonProperty("PI_GDATU")]
public string AttrPI_GDATU;

[JsonProperty("PI_KURST")]
public string AttrPI_KURST;

[JsonProperty("PI_TCURR")]
public string AttrPI_TCURR;

public RESTST_694abc44952847f050feca404fbee9c5Structure() { }

public RESTST_694abc44952847f050feca404fbee9c5Structure (ST_694abc44952847f050feca404fbee9c5Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_FCURR = s.ssPI_FCURR;
AttrPI_GDATU = s.ssPI_GDATU;
AttrPI_KURST = s.ssPI_KURST;
AttrPI_TCURR = s.ssPI_TCURR;
  } else {
AttrPI_FCURR = s.ssPI_FCURR;
AttrPI_GDATU = s.ssPI_GDATU;
AttrPI_KURST = s.ssPI_KURST;
AttrPI_TCURR = s.ssPI_TCURR;
  }
}

public static ST_694abc44952847f050feca404fbee9c5Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_694abc44952847f050feca404fbee9c5Structure obj) { 
  ST_694abc44952847f050feca404fbee9c5Structure s = new ST_694abc44952847f050feca404fbee9c5Structure();
  if(obj != null) {
  s.ssPI_FCURR = obj.AttrPI_FCURR == null ? "" : obj.AttrPI_FCURR;
  s.ssPI_GDATU = obj.AttrPI_GDATU == null ? "" : obj.AttrPI_GDATU;
  s.ssPI_KURST = obj.AttrPI_KURST == null ? "" : obj.AttrPI_KURST;
  s.ssPI_TCURR = obj.AttrPI_TCURR == null ? "" : obj.AttrPI_TCURR;
  }
  return s;
}

public static Func<ST_694abc44952847f050feca404fbee9c5Structure, ssConectaProveedores.RestRecords.RESTST_694abc44952847f050feca404fbee9c5Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_694abc44952847f050feca404fbee9c5Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_694abc44952847f050feca404fbee9c5Structure FromStructure(ST_694abc44952847f050feca404fbee9c5Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_694abc44952847f050feca404fbee9c5Structure(s, config);
}

}


