using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// HTTPRequest
public class JSONST_ea2141f4206e3eb2cd0fdd847e008166Structure : AbstractRESTStructure<ST_ea2141f4206e3eb2cd0fdd847e008166Structure> {
[JsonProperty("BaseURL")]
[JsonPropertyName("BaseURL")]
public string AttrBaseURL;

[JsonProperty("URLPath")]
[JsonPropertyName("URLPath")]
public string AttrURLPath;

[JsonProperty("URLQueryParameters")]
[JsonPropertyName("URLQueryParameters")]
public ssConectaProveedores.RestRecords.JSONST_f9be77c0ae9485d53ded05b1557548f9Structure[] AttrURLQueryParameters;

[JsonProperty("HTTPMethod")]
[JsonPropertyName("HTTPMethod")]
public string AttrHTTPMethod;

[JsonProperty("Headers")]
[JsonPropertyName("Headers")]
public ssConectaProveedores.RestRecords.JSONST_3cf3b984041595af1703070620d6367bStructure[] AttrHeaders;

[JsonProperty("RequestText")]
[JsonPropertyName("RequestText")]
public string AttrRequestText;

[JsonProperty("RequestBinary")]
[JsonPropertyName("RequestBinary")]
public byte[] AttrRequestBinary;

public JSONST_ea2141f4206e3eb2cd0fdd847e008166Structure() { }

public JSONST_ea2141f4206e3eb2cd0fdd847e008166Structure (ST_ea2141f4206e3eb2cd0fdd847e008166Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBaseURL = ConvertToRestWithoutDefaults(s.ssBaseURL, "");
AttrURLPath = ConvertToRestWithoutDefaults(s.ssURLPath, "");
AttrURLQueryParameters = s.ssURLQueryParameters.Length == 0 ? null : s.ssURLQueryParameters.ToArray<ssConectaProveedores.RestRecords.JSONST_f9be77c0ae9485d53ded05b1557548f9Structure>(ssConectaProveedores.RestRecords.JSONST_f9be77c0ae9485d53ded05b1557548f9Structure.FromStructureDelegate(config));
AttrHTTPMethod = ConvertToRestWithoutDefaults(s.ssHTTPMethod, "");
AttrHeaders = s.ssHeaders.Length == 0 ? null : s.ssHeaders.ToArray<ssConectaProveedores.RestRecords.JSONST_3cf3b984041595af1703070620d6367bStructure>(ssConectaProveedores.RestRecords.JSONST_3cf3b984041595af1703070620d6367bStructure.FromStructureDelegate(config));
AttrRequestText = ConvertToRestWithoutDefaults(s.ssRequestText, "");
AttrRequestBinary = ConvertToRestWithoutDefaults(s.ssRequestBinary);
  } else {
AttrBaseURL = s.ssBaseURL;
AttrURLPath = s.ssURLPath;
AttrURLQueryParameters = s.ssURLQueryParameters.ToArray<ssConectaProveedores.RestRecords.JSONST_f9be77c0ae9485d53ded05b1557548f9Structure>(ssConectaProveedores.RestRecords.JSONST_f9be77c0ae9485d53ded05b1557548f9Structure.FromStructureDelegate(config));
AttrHTTPMethod = s.ssHTTPMethod;
AttrHeaders = s.ssHeaders.ToArray<ssConectaProveedores.RestRecords.JSONST_3cf3b984041595af1703070620d6367bStructure>(ssConectaProveedores.RestRecords.JSONST_3cf3b984041595af1703070620d6367bStructure.FromStructureDelegate(config));
AttrRequestText = s.ssRequestText;
AttrRequestBinary = s.ssRequestBinary;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_ea2141f4206e3eb2cd0fdd847e008166Structure, ST_ea2141f4206e3eb2cd0fdd847e008166Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_ea2141f4206e3eb2cd0fdd847e008166Structure s) => ToStructure(s, config);
}
public static ST_ea2141f4206e3eb2cd0fdd847e008166Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_ea2141f4206e3eb2cd0fdd847e008166Structure obj, IBehaviorsConfiguration config) { 
  ST_ea2141f4206e3eb2cd0fdd847e008166Structure s = new ST_ea2141f4206e3eb2cd0fdd847e008166Structure();
  if(obj != null) {
  s.ssBaseURL = obj.AttrBaseURL == null ? "" : obj.AttrBaseURL;
  s.ssURLPath = obj.AttrURLPath == null ? "" : obj.AttrURLPath;
  s.ssURLQueryParameters = RL_09d38ca4875adba9fe0bf71f298f1c3d.ToList(obj.AttrURLQueryParameters, ssConectaProveedores.RestRecords.JSONST_f9be77c0ae9485d53ded05b1557548f9Structure.ToStructureDelegate(config));
  s.ssHTTPMethod = obj.AttrHTTPMethod == null ? "" : obj.AttrHTTPMethod;
  s.ssHeaders = RL_c06bca3d168b84039f4414ae52f271eb.ToList(obj.AttrHeaders, ssConectaProveedores.RestRecords.JSONST_3cf3b984041595af1703070620d6367bStructure.ToStructureDelegate(config));
  s.ssRequestText = obj.AttrRequestText == null ? "" : obj.AttrRequestText;
  s.ssRequestBinary = obj.AttrRequestBinary == null ? new byte[] {} : obj.AttrRequestBinary;
  }
  return s;
}

public static Func<ST_ea2141f4206e3eb2cd0fdd847e008166Structure, ssConectaProveedores.RestRecords.JSONST_ea2141f4206e3eb2cd0fdd847e008166Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_ea2141f4206e3eb2cd0fdd847e008166Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_ea2141f4206e3eb2cd0fdd847e008166Structure FromStructure(ST_ea2141f4206e3eb2cd0fdd847e008166Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_ea2141f4206e3eb2cd0fdd847e008166Structure(s, config);
}

}


