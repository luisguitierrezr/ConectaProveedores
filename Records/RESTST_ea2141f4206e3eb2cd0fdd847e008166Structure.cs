using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// HTTPRequest
public class RESTST_ea2141f4206e3eb2cd0fdd847e008166Structure : AbstractRESTStructure<ST_ea2141f4206e3eb2cd0fdd847e008166Structure> {
[JsonProperty("BaseURL")]
public string AttrBaseURL;

[JsonProperty("URLPath")]
public string AttrURLPath;

[JsonProperty("URLQueryParameters")]
public RestList<ssConectaProveedores.RestRecords.RESTST_f9be77c0ae9485d53ded05b1557548f9Structure> AttrURLQueryParameters;

[JsonProperty("HTTPMethod")]
public string AttrHTTPMethod;

[JsonProperty("Headers")]
public RestList<ssConectaProveedores.RestRecords.RESTST_3cf3b984041595af1703070620d6367bStructure> AttrHeaders;

[JsonProperty("RequestText")]
public string AttrRequestText;

[JsonProperty("RequestBinary")]
public byte[] AttrRequestBinary;

public RESTST_ea2141f4206e3eb2cd0fdd847e008166Structure() { }

public RESTST_ea2141f4206e3eb2cd0fdd847e008166Structure (ST_ea2141f4206e3eb2cd0fdd847e008166Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBaseURL = ConvertToRestWithoutDefaults(s.ssBaseURL, "");
AttrURLPath = ConvertToRestWithoutDefaults(s.ssURLPath, "");
AttrURLQueryParameters = s.ssURLQueryParameters.Length == 0 ? null : s.ssURLQueryParameters.ToRestList<ssConectaProveedores.RestRecords.RESTST_f9be77c0ae9485d53ded05b1557548f9Structure>(ssConectaProveedores.RestRecords.RESTST_f9be77c0ae9485d53ded05b1557548f9Structure.FromStructureDelegate(config));
AttrHTTPMethod = ConvertToRestWithoutDefaults(s.ssHTTPMethod, "");
AttrHeaders = s.ssHeaders.Length == 0 ? null : s.ssHeaders.ToRestList<ssConectaProveedores.RestRecords.RESTST_3cf3b984041595af1703070620d6367bStructure>(ssConectaProveedores.RestRecords.RESTST_3cf3b984041595af1703070620d6367bStructure.FromStructureDelegate(config));
AttrRequestText = ConvertToRestWithoutDefaults(s.ssRequestText, "");
AttrRequestBinary = ConvertToRestWithoutDefaults(s.ssRequestBinary);
  } else {
AttrBaseURL = s.ssBaseURL;
AttrURLPath = s.ssURLPath;
AttrURLQueryParameters = s.ssURLQueryParameters.ToRestList<ssConectaProveedores.RestRecords.RESTST_f9be77c0ae9485d53ded05b1557548f9Structure>(ssConectaProveedores.RestRecords.RESTST_f9be77c0ae9485d53ded05b1557548f9Structure.FromStructureDelegate(config));
AttrHTTPMethod = s.ssHTTPMethod;
AttrHeaders = s.ssHeaders.ToRestList<ssConectaProveedores.RestRecords.RESTST_3cf3b984041595af1703070620d6367bStructure>(ssConectaProveedores.RestRecords.RESTST_3cf3b984041595af1703070620d6367bStructure.FromStructureDelegate(config));
AttrRequestText = s.ssRequestText;
AttrRequestBinary = s.ssRequestBinary;
  }
}

public static ST_ea2141f4206e3eb2cd0fdd847e008166Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_ea2141f4206e3eb2cd0fdd847e008166Structure obj) { 
  ST_ea2141f4206e3eb2cd0fdd847e008166Structure s = new ST_ea2141f4206e3eb2cd0fdd847e008166Structure();
  if(obj != null) {
  s.ssBaseURL = obj.AttrBaseURL == null ? "" : obj.AttrBaseURL;
  s.ssURLPath = obj.AttrURLPath == null ? "" : obj.AttrURLPath;
  s.ssURLQueryParameters = RL_09d38ca4875adba9fe0bf71f298f1c3d.FromRestList(obj.AttrURLQueryParameters, ssConectaProveedores.RestRecords.RESTST_f9be77c0ae9485d53ded05b1557548f9Structure.ToStructure);
  s.ssHTTPMethod = obj.AttrHTTPMethod == null ? "" : obj.AttrHTTPMethod;
  s.ssHeaders = RL_c06bca3d168b84039f4414ae52f271eb.FromRestList(obj.AttrHeaders, ssConectaProveedores.RestRecords.RESTST_3cf3b984041595af1703070620d6367bStructure.ToStructure);
  s.ssRequestText = obj.AttrRequestText == null ? "" : obj.AttrRequestText;
  s.ssRequestBinary = obj.AttrRequestBinary == null ? new byte[] {} : obj.AttrRequestBinary;
  }
  return s;
}

public static Func<ST_ea2141f4206e3eb2cd0fdd847e008166Structure, ssConectaProveedores.RestRecords.RESTST_ea2141f4206e3eb2cd0fdd847e008166Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_ea2141f4206e3eb2cd0fdd847e008166Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_ea2141f4206e3eb2cd0fdd847e008166Structure FromStructure(ST_ea2141f4206e3eb2cd0fdd847e008166Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_ea2141f4206e3eb2cd0fdd847e008166Structure(s, config);
}

}


