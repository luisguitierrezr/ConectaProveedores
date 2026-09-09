using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DropdownOption
public class RESTST_60f22bd2e9b10a22278b8afe6d7f601aStructure : AbstractRESTStructure<ST_60f22bd2e9b10a22278b8afe6d7f601aStructure> {
[JsonProperty("Value")]
public string AttrValue;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("ImageUrlOrIconClass")]
public string AttrImageUrlOrIconClass;

[JsonProperty("GroupName")]
public string AttrGroupName;

[JsonProperty("Description")]
public string AttrDescription;

public RESTST_60f22bd2e9b10a22278b8afe6d7f601aStructure() { }

public RESTST_60f22bd2e9b10a22278b8afe6d7f601aStructure (ST_60f22bd2e9b10a22278b8afe6d7f601aStructure s, IBehaviorsConfiguration config) {
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

public static ST_60f22bd2e9b10a22278b8afe6d7f601aStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_60f22bd2e9b10a22278b8afe6d7f601aStructure obj) { 
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

public static Func<ST_60f22bd2e9b10a22278b8afe6d7f601aStructure, ssConectaProveedores.RestRecords.RESTST_60f22bd2e9b10a22278b8afe6d7f601aStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_60f22bd2e9b10a22278b8afe6d7f601aStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_60f22bd2e9b10a22278b8afe6d7f601aStructure FromStructure(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_60f22bd2e9b10a22278b8afe6d7f601aStructure(s, config);
}

}


