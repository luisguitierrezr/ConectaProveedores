using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DropdownItem
public class JSONST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure : AbstractRESTStructure<ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure> {
[JsonProperty("Value")]
[JsonPropertyName("Value")]
public string AttrValue;

[JsonProperty("Text")]
[JsonPropertyName("Text")]
public string AttrText;

public JSONST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure() { }

public JSONST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure (ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValue = s.ssValue;
AttrText = s.ssText;
  } else {
AttrValue = s.ssValue;
AttrText = s.ssText;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure, ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure s) => ToStructure(s, config);
}
public static ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure obj, IBehaviorsConfiguration config) { 
  ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure s = new ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure();
  if(obj != null) {
  s.ssValue = obj.AttrValue == null ? "" : obj.AttrValue;
  s.ssText = obj.AttrText == null ? "" : obj.AttrText;
  }
  return s;
}

public static Func<ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure, ssConectaProveedores.RestRecords.JSONST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure FromStructure(ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure(s, config);
}

}


