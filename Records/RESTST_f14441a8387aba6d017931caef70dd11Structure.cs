using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// StepUsers
public class RESTST_f14441a8387aba6d017931caef70dd11Structure : AbstractRESTStructure<ST_f14441a8387aba6d017931caef70dd11Structure> {
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

public RESTST_f14441a8387aba6d017931caef70dd11Structure() { }

public RESTST_f14441a8387aba6d017931caef70dd11Structure (ST_f14441a8387aba6d017931caef70dd11Structure s, IBehaviorsConfiguration config) {
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

public static ST_f14441a8387aba6d017931caef70dd11Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_f14441a8387aba6d017931caef70dd11Structure obj) { 
  ST_f14441a8387aba6d017931caef70dd11Structure s = new ST_f14441a8387aba6d017931caef70dd11Structure();
  if(obj != null) {
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssExtendedClass = obj.AttrExtendedClass == null ? "" : obj.AttrExtendedClass;
  s.ssUnderLabel = obj.AttrUnderLabel == null ? "" : obj.AttrUnderLabel;
  s.ssUnderLabelNChar = obj.AttrUnderLabelNChar == null ? 0 : obj.AttrUnderLabelNChar.Value;
  }
  return s;
}

public static Func<ST_f14441a8387aba6d017931caef70dd11Structure, ssConectaProveedores.RestRecords.RESTST_f14441a8387aba6d017931caef70dd11Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f14441a8387aba6d017931caef70dd11Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_f14441a8387aba6d017931caef70dd11Structure FromStructure(ST_f14441a8387aba6d017931caef70dd11Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_f14441a8387aba6d017931caef70dd11Structure(s, config);
}

}


