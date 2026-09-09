using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// HTTPHeader
public class RESTST_3cf3b984041595af1703070620d6367bStructure : AbstractRESTStructure<ST_3cf3b984041595af1703070620d6367bStructure> {
[JsonProperty("Name")]
public string AttrName;

[JsonProperty("Value")]
public string AttrValue;

public RESTST_3cf3b984041595af1703070620d6367bStructure() { }

public RESTST_3cf3b984041595af1703070620d6367bStructure (ST_3cf3b984041595af1703070620d6367bStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrValue = ConvertToRestWithoutDefaults(s.ssValue, "");
  } else {
AttrName = s.ssName;
AttrValue = s.ssValue;
  }
}

public static ST_3cf3b984041595af1703070620d6367bStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_3cf3b984041595af1703070620d6367bStructure obj) { 
  ST_3cf3b984041595af1703070620d6367bStructure s = new ST_3cf3b984041595af1703070620d6367bStructure();
  if(obj != null) {
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssValue = obj.AttrValue == null ? "" : obj.AttrValue;
  }
  return s;
}

public static Func<ST_3cf3b984041595af1703070620d6367bStructure, ssConectaProveedores.RestRecords.RESTST_3cf3b984041595af1703070620d6367bStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_3cf3b984041595af1703070620d6367bStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_3cf3b984041595af1703070620d6367bStructure FromStructure(ST_3cf3b984041595af1703070620d6367bStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_3cf3b984041595af1703070620d6367bStructure(s, config);
}

}


