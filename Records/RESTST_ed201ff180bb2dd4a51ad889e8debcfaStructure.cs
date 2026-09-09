using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EntryOrderRequestCancel
public class RESTST_ed201ff180bb2dd4a51ad889e8debcfaStructure : AbstractRESTStructure<ST_ed201ff180bb2dd4a51ad889e8debcfaStructure> {
[JsonProperty("OrderNumber")]
public string AttrOrderNumber;

[JsonProperty("OrderPosition")]
public string AttrOrderPosition;

[JsonProperty("GroupFolio")]
public string AttrGroupFolio;

[JsonProperty("SMDocMaterial")]
public string AttrSMDocMaterial;

[JsonProperty("SMDocYear")]
public string AttrSMDocYear;

[JsonProperty("EMDocMaterial")]
public string AttrEMDocMaterial;

[JsonProperty("EMDocYear")]
public string AttrEMDocYear;

public RESTST_ed201ff180bb2dd4a51ad889e8debcfaStructure() { }

public RESTST_ed201ff180bb2dd4a51ad889e8debcfaStructure (ST_ed201ff180bb2dd4a51ad889e8debcfaStructure s, IBehaviorsConfiguration config) {
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

public static ST_ed201ff180bb2dd4a51ad889e8debcfaStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_ed201ff180bb2dd4a51ad889e8debcfaStructure obj) { 
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

public static Func<ST_ed201ff180bb2dd4a51ad889e8debcfaStructure, ssConectaProveedores.RestRecords.RESTST_ed201ff180bb2dd4a51ad889e8debcfaStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_ed201ff180bb2dd4a51ad889e8debcfaStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_ed201ff180bb2dd4a51ad889e8debcfaStructure FromStructure(ST_ed201ff180bb2dd4a51ad889e8debcfaStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_ed201ff180bb2dd4a51ad889e8debcfaStructure(s, config);
}

}


