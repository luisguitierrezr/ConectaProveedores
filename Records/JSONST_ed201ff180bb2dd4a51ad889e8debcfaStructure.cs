using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EntryOrderRequestCancel
public class JSONST_ed201ff180bb2dd4a51ad889e8debcfaStructure : AbstractRESTStructure<ST_ed201ff180bb2dd4a51ad889e8debcfaStructure> {
[JsonProperty("OrderNumber")]
[JsonPropertyName("OrderNumber")]
public string AttrOrderNumber;

[JsonProperty("OrderPosition")]
[JsonPropertyName("OrderPosition")]
public string AttrOrderPosition;

[JsonProperty("GroupFolio")]
[JsonPropertyName("GroupFolio")]
public string AttrGroupFolio;

[JsonProperty("SMDocMaterial")]
[JsonPropertyName("SMDocMaterial")]
public string AttrSMDocMaterial;

[JsonProperty("SMDocYear")]
[JsonPropertyName("SMDocYear")]
public string AttrSMDocYear;

[JsonProperty("EMDocMaterial")]
[JsonPropertyName("EMDocMaterial")]
public string AttrEMDocMaterial;

[JsonProperty("EMDocYear")]
[JsonPropertyName("EMDocYear")]
public string AttrEMDocYear;

public JSONST_ed201ff180bb2dd4a51ad889e8debcfaStructure() { }

public JSONST_ed201ff180bb2dd4a51ad889e8debcfaStructure (ST_ed201ff180bb2dd4a51ad889e8debcfaStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderNumber = ConvertToRestWithoutDefaults(s.ssOrderNumber, "");
AttrOrderPosition = ConvertToRestWithoutDefaults(s.ssOrderPosition, "");
AttrGroupFolio = ConvertToRestWithoutDefaults(s.ssGroupFolio, "");
AttrSMDocMaterial = ConvertToRestWithoutDefaults(s.ssSMDocMaterial, "");
AttrSMDocYear = ConvertToRestWithoutDefaults(s.ssSMDocYear, "");
AttrEMDocMaterial = ConvertToRestWithoutDefaults(s.ssEMDocMaterial, "");
AttrEMDocYear = ConvertToRestWithoutDefaults(s.ssEMDocYear, "");
  } else {
AttrOrderNumber = s.ssOrderNumber;
AttrOrderPosition = s.ssOrderPosition;
AttrGroupFolio = s.ssGroupFolio;
AttrSMDocMaterial = s.ssSMDocMaterial;
AttrSMDocYear = s.ssSMDocYear;
AttrEMDocMaterial = s.ssEMDocMaterial;
AttrEMDocYear = s.ssEMDocYear;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_ed201ff180bb2dd4a51ad889e8debcfaStructure, ST_ed201ff180bb2dd4a51ad889e8debcfaStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_ed201ff180bb2dd4a51ad889e8debcfaStructure s) => ToStructure(s, config);
}
public static ST_ed201ff180bb2dd4a51ad889e8debcfaStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_ed201ff180bb2dd4a51ad889e8debcfaStructure obj, IBehaviorsConfiguration config) { 
  ST_ed201ff180bb2dd4a51ad889e8debcfaStructure s = new ST_ed201ff180bb2dd4a51ad889e8debcfaStructure();
  if(obj != null) {
  s.ssOrderNumber = obj.AttrOrderNumber == null ? "" : obj.AttrOrderNumber;
  s.ssOrderPosition = obj.AttrOrderPosition == null ? "" : obj.AttrOrderPosition;
  s.ssGroupFolio = obj.AttrGroupFolio == null ? "" : obj.AttrGroupFolio;
  s.ssSMDocMaterial = obj.AttrSMDocMaterial == null ? "" : obj.AttrSMDocMaterial;
  s.ssSMDocYear = obj.AttrSMDocYear == null ? "" : obj.AttrSMDocYear;
  s.ssEMDocMaterial = obj.AttrEMDocMaterial == null ? "" : obj.AttrEMDocMaterial;
  s.ssEMDocYear = obj.AttrEMDocYear == null ? "" : obj.AttrEMDocYear;
  }
  return s;
}

public static Func<ST_ed201ff180bb2dd4a51ad889e8debcfaStructure, ssConectaProveedores.RestRecords.JSONST_ed201ff180bb2dd4a51ad889e8debcfaStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_ed201ff180bb2dd4a51ad889e8debcfaStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_ed201ff180bb2dd4a51ad889e8debcfaStructure FromStructure(ST_ed201ff180bb2dd4a51ad889e8debcfaStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_ed201ff180bb2dd4a51ad889e8debcfaStructure(s, config);
}

}


