using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Step
public class JSONST_d1e6f35068707165b6684293e397ea3bStructure : AbstractRESTStructure<ST_d1e6f35068707165b6684293e397ea3bStructure> {
[JsonProperty("Order")]
[JsonPropertyName("Order")]
public int? AttrOrder;

[JsonProperty("Label")]
[JsonPropertyName("Label")]
public string AttrLabel;

[JsonProperty("ExtendedClass")]
[JsonPropertyName("ExtendedClass")]
public string AttrExtendedClass;

[JsonProperty("UnderLabel")]
[JsonPropertyName("UnderLabel")]
public string AttrUnderLabel;

[JsonProperty("UnderLabelNChar")]
[JsonPropertyName("UnderLabelNChar")]
public int? AttrUnderLabelNChar;

public JSONST_d1e6f35068707165b6684293e397ea3bStructure() { }

public JSONST_d1e6f35068707165b6684293e397ea3bStructure (ST_d1e6f35068707165b6684293e397ea3bStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrder = ConvertToRestWithoutDefaults(s.ssOrder, 0);
AttrLabel = ConvertToRestWithoutDefaults(s.ssLabel, "");
AttrExtendedClass = ConvertToRestWithoutDefaults(s.ssExtendedClass, "");
AttrUnderLabel = ConvertToRestWithoutDefaults(s.ssUnderLabel, "");
AttrUnderLabelNChar = ConvertToRestWithoutDefaults(s.ssUnderLabelNChar, 0);
  } else {
AttrOrder = (int?) s.ssOrder;
AttrLabel = s.ssLabel;
AttrExtendedClass = s.ssExtendedClass;
AttrUnderLabel = s.ssUnderLabel;
AttrUnderLabelNChar = (int?) s.ssUnderLabelNChar;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_d1e6f35068707165b6684293e397ea3bStructure, ST_d1e6f35068707165b6684293e397ea3bStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_d1e6f35068707165b6684293e397ea3bStructure s) => ToStructure(s, config);
}
public static ST_d1e6f35068707165b6684293e397ea3bStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_d1e6f35068707165b6684293e397ea3bStructure obj, IBehaviorsConfiguration config) { 
  ST_d1e6f35068707165b6684293e397ea3bStructure s = new ST_d1e6f35068707165b6684293e397ea3bStructure();
  if(obj != null) {
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  s.ssUnderLabel = obj.AttrUnderLabel == null ? "" : obj.AttrUnderLabel;
  s.ssUnderLabelNChar = obj.AttrUnderLabelNChar == null ? 0 : obj.AttrUnderLabelNChar.Value;
  }
  return s;
}

public static Func<ST_d1e6f35068707165b6684293e397ea3bStructure, ssConectaProveedores.RestRecords.JSONST_d1e6f35068707165b6684293e397ea3bStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_d1e6f35068707165b6684293e397ea3bStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_d1e6f35068707165b6684293e397ea3bStructure FromStructure(ST_d1e6f35068707165b6684293e397ea3bStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_d1e6f35068707165b6684293e397ea3bStructure(s, config);
}

}


