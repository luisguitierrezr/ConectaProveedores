using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DropdownOption
public class JSONST_60f22bd2e9b10a22278b8afe6d7f601aStructure : AbstractRESTStructure<ST_60f22bd2e9b10a22278b8afe6d7f601aStructure> {
[JsonProperty("value")]
[JsonPropertyName("value")]
public string AttrValue;

[JsonProperty("label")]
[JsonPropertyName("label")]
public string AttrLabel;

[JsonProperty("image_url_or_class")]
[JsonPropertyName("image_url_or_class")]
public string AttrImageUrlOrIconClass;

[JsonProperty("group_name")]
[JsonPropertyName("group_name")]
public string AttrGroupName;

[JsonProperty("description")]
[JsonPropertyName("description")]
public string AttrDescription;

public JSONST_60f22bd2e9b10a22278b8afe6d7f601aStructure() { }

public JSONST_60f22bd2e9b10a22278b8afe6d7f601aStructure (ST_60f22bd2e9b10a22278b8afe6d7f601aStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValue = s.ssValue;
AttrLabel = s.ssLabel;
AttrImageUrlOrIconClass = ConvertToRestWithoutDefaults(s.ssImageUrlOrIconClass, "");
AttrGroupName = ConvertToRestWithoutDefaults(s.ssGroupName, "");
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
  } else {
AttrValue = s.ssValue;
AttrLabel = s.ssLabel;
AttrImageUrlOrIconClass = s.ssImageUrlOrIconClass;
AttrGroupName = s.ssGroupName;
AttrDescription = s.ssDescription;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_60f22bd2e9b10a22278b8afe6d7f601aStructure, ST_60f22bd2e9b10a22278b8afe6d7f601aStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_60f22bd2e9b10a22278b8afe6d7f601aStructure s) => ToStructure(s, config);
}
public static ST_60f22bd2e9b10a22278b8afe6d7f601aStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_60f22bd2e9b10a22278b8afe6d7f601aStructure obj, IBehaviorsConfiguration config) { 
  ST_60f22bd2e9b10a22278b8afe6d7f601aStructure s = new ST_60f22bd2e9b10a22278b8afe6d7f601aStructure();
  if(obj != null) {
  s.ssValue = obj.AttrValue == null ? "" : obj.AttrValue;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssImageUrlOrIconClass = obj.AttrImageUrlOrIconClass == null ? "" : obj.AttrImageUrlOrIconClass;
  s.ssGroupName = obj.AttrGroupName == null ? "" : obj.AttrGroupName;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  }
  return s;
}

public static Func<ST_60f22bd2e9b10a22278b8afe6d7f601aStructure, ssConectaProveedores.RestRecords.JSONST_60f22bd2e9b10a22278b8afe6d7f601aStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_60f22bd2e9b10a22278b8afe6d7f601aStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_60f22bd2e9b10a22278b8afe6d7f601aStructure FromStructure(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_60f22bd2e9b10a22278b8afe6d7f601aStructure(s, config);
}

}


