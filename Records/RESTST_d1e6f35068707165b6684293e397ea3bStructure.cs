using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Step
public class RESTST_d1e6f35068707165b6684293e397ea3bStructure : AbstractRESTStructure<ST_d1e6f35068707165b6684293e397ea3bStructure> {
[JsonProperty("Order")]
public int? AttrOrder;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("ExtendedClass")]
public string AttrExtendedClass;

[JsonProperty("UnderLabel")]
public string AttrUnderLabel;

[JsonProperty("UnderLabelNChar")]
public int? AttrUnderLabelNChar;

public RESTST_d1e6f35068707165b6684293e397ea3bStructure() { }

public RESTST_d1e6f35068707165b6684293e397ea3bStructure (ST_d1e6f35068707165b6684293e397ea3bStructure s, IBehaviorsConfiguration config) {
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

public static ST_d1e6f35068707165b6684293e397ea3bStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_d1e6f35068707165b6684293e397ea3bStructure obj) { 
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

public static Func<ST_d1e6f35068707165b6684293e397ea3bStructure, ssConectaProveedores.RestRecords.RESTST_d1e6f35068707165b6684293e397ea3bStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_d1e6f35068707165b6684293e397ea3bStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_d1e6f35068707165b6684293e397ea3bStructure FromStructure(ST_d1e6f35068707165b6684293e397ea3bStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_d1e6f35068707165b6684293e397ea3bStructure(s, config);
}

}


