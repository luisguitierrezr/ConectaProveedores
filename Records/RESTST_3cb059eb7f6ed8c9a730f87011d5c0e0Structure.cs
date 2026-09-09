using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DropdownItem
public class RESTST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure : AbstractRESTStructure<ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure> {
[JsonProperty("Value")]
public string AttrValue;

[JsonProperty("Text")]
public string AttrText;

public RESTST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure() { }

public RESTST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure (ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValue = s.ssValue;
AttrText = s.ssText;
  } else {
AttrValue = s.ssValue;
AttrText = s.ssText;
  }
}

public static ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure obj) { 
  ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure s = new ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure();
  if(obj != null) {
  s.ssValue = obj.AttrValue == null ? "" : obj.AttrValue;
  s.ssText = obj.AttrText == null ? "" : obj.AttrText;
  }
  return s;
}

public static Func<ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure, ssConectaProveedores.RestRecords.RESTST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure FromStructure(ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure(s, config);
}

}


