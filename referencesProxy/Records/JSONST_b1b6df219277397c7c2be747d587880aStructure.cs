using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// Return
public class JSONST_b1b6df219277397c7c2be747d587880aStructure : AbstractRESTStructure<ST_b1b6df219277397c7c2be747d587880aStructure> {
[JsonProperty("IsSuccess")]
[JsonPropertyName("IsSuccess")]
public bool? AttrIsSuccess;

[JsonProperty("Message")]
[JsonPropertyName("Message")]
public string AttrMessage;

public JSONST_b1b6df219277397c7c2be747d587880aStructure() { }

public JSONST_b1b6df219277397c7c2be747d587880aStructure (ST_b1b6df219277397c7c2be747d587880aStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIsSuccess = ConvertToRestWithoutDefaults(s.ssIsSuccess, false);
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
  } else {
AttrIsSuccess = (bool?) s.ssIsSuccess;
AttrMessage = s.ssMessage;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b1b6df219277397c7c2be747d587880aStructure, ST_b1b6df219277397c7c2be747d587880aStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b1b6df219277397c7c2be747d587880aStructure s) => ToStructure(s, config);
}
public static ST_b1b6df219277397c7c2be747d587880aStructure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b1b6df219277397c7c2be747d587880aStructure obj, IBehaviorsConfiguration config) { 
  ST_b1b6df219277397c7c2be747d587880aStructure s = new ST_b1b6df219277397c7c2be747d587880aStructure();
  if(obj != null) {
  s.ssIsSuccess = obj.AttrIsSuccess == null ? false : obj.AttrIsSuccess.Value;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<ST_b1b6df219277397c7c2be747d587880aStructure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b1b6df219277397c7c2be747d587880aStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b1b6df219277397c7c2be747d587880aStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b1b6df219277397c7c2be747d587880aStructure FromStructure(ST_b1b6df219277397c7c2be747d587880aStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b1b6df219277397c7c2be747d587880aStructure(s, config);
}

}


