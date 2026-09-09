using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TI_ITEM_Out
public class JSONST_3b61de88b81d785d0616b445a04890fdStructure : AbstractRESTStructure<ST_3b61de88b81d785d0616b445a04890fdStructure> {
[JsonProperty("INVOICE_DOC_ITEM")]
[JsonPropertyName("INVOICE_DOC_ITEM")]
public int? AttrINVOICE_DOC_ITEM;

[JsonProperty("PO_NUMBER")]
[JsonPropertyName("PO_NUMBER")]
public string AttrPO_NUMBER;

[JsonProperty("PO_ITEM")]
[JsonPropertyName("PO_ITEM")]
public int? AttrPO_ITEM;

[JsonProperty("REF_DOC")]
[JsonPropertyName("REF_DOC")]
public string AttrREF_DOC;

[JsonProperty("REF_DOC_YEAR")]
[JsonPropertyName("REF_DOC_YEAR")]
public int? AttrREF_DOC_YEAR;

[JsonProperty("REF_DOC_IT")]
[JsonPropertyName("REF_DOC_IT")]
public int? AttrREF_DOC_IT;

[JsonProperty("TAX_CODE")]
[JsonPropertyName("TAX_CODE")]
public string AttrTAX_CODE;

[JsonProperty("ITEM_AMOUNT")]
[JsonPropertyName("ITEM_AMOUNT")]
public decimal? AttrITEM_AMOUNT;

[JsonProperty("QUANTITY")]
[JsonPropertyName("QUANTITY")]
public decimal? AttrQUANTITY;

[JsonProperty("PO_UNIT")]
[JsonPropertyName("PO_UNIT")]
public string AttrPO_UNIT;

public JSONST_3b61de88b81d785d0616b445a04890fdStructure() { }

public JSONST_3b61de88b81d785d0616b445a04890fdStructure (ST_3b61de88b81d785d0616b445a04890fdStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrINVOICE_DOC_ITEM = ConvertToRestWithoutDefaults(s.ssINVOICE_DOC_ITEM, -2147483648);
AttrPO_NUMBER = ConvertToRestWithoutDefaults(s.ssPO_NUMBER, "");
AttrPO_ITEM = ConvertToRestWithoutDefaults(s.ssPO_ITEM, -2147483648);
AttrREF_DOC = ConvertToRestWithoutDefaults(s.ssREF_DOC, "");
AttrREF_DOC_YEAR = ConvertToRestWithoutDefaults(s.ssREF_DOC_YEAR, -2147483648);
AttrREF_DOC_IT = ConvertToRestWithoutDefaults(s.ssREF_DOC_IT, -2147483648);
AttrTAX_CODE = ConvertToRestWithoutDefaults(s.ssTAX_CODE, "");
AttrITEM_AMOUNT = ConvertToRestWithoutDefaults(s.ssITEM_AMOUNT, -79228162514264337593543950335m);
AttrQUANTITY = ConvertToRestWithoutDefaults(s.ssQUANTITY, -79228162514264337593543950335m);
AttrPO_UNIT = ConvertToRestWithoutDefaults(s.ssPO_UNIT, "");
  } else {
AttrINVOICE_DOC_ITEM = (int?) s.ssINVOICE_DOC_ITEM;
AttrPO_NUMBER = s.ssPO_NUMBER;
AttrPO_ITEM = (int?) s.ssPO_ITEM;
AttrREF_DOC = s.ssREF_DOC;
AttrREF_DOC_YEAR = (int?) s.ssREF_DOC_YEAR;
AttrREF_DOC_IT = (int?) s.ssREF_DOC_IT;
AttrTAX_CODE = s.ssTAX_CODE;
AttrITEM_AMOUNT = (decimal?) s.ssITEM_AMOUNT;
AttrQUANTITY = (decimal?) s.ssQUANTITY;
AttrPO_UNIT = s.ssPO_UNIT;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_3b61de88b81d785d0616b445a04890fdStructure, ST_3b61de88b81d785d0616b445a04890fdStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_3b61de88b81d785d0616b445a04890fdStructure s) => ToStructure(s, config);
}
public static ST_3b61de88b81d785d0616b445a04890fdStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_3b61de88b81d785d0616b445a04890fdStructure obj, IBehaviorsConfiguration config) { 
  ST_3b61de88b81d785d0616b445a04890fdStructure s = new ST_3b61de88b81d785d0616b445a04890fdStructure();
  if(obj != null) {
  s.ssINVOICE_DOC_ITEM = obj.AttrINVOICE_DOC_ITEM == null ? -2147483648 : obj.AttrINVOICE_DOC_ITEM.Value;
  s.ssPO_NUMBER = obj.AttrPO_NUMBER == null ? "" : obj.AttrPO_NUMBER;
  s.ssPO_ITEM = obj.AttrPO_ITEM == null ? -2147483648 : obj.AttrPO_ITEM.Value;
  s.ssREF_DOC = obj.AttrREF_DOC == null ? "" : obj.AttrREF_DOC;
  s.ssREF_DOC_YEAR = obj.AttrREF_DOC_YEAR == null ? -2147483648 : obj.AttrREF_DOC_YEAR.Value;
  s.ssREF_DOC_IT = obj.AttrREF_DOC_IT == null ? -2147483648 : obj.AttrREF_DOC_IT.Value;
  s.ssTAX_CODE = obj.AttrTAX_CODE == null ? "" : obj.AttrTAX_CODE;
  s.ssITEM_AMOUNT = obj.AttrITEM_AMOUNT == null ? -79228162514264337593543950335m : obj.AttrITEM_AMOUNT.Value;
  s.ssQUANTITY = obj.AttrQUANTITY == null ? -79228162514264337593543950335m : obj.AttrQUANTITY.Value;
  s.ssPO_UNIT = obj.AttrPO_UNIT == null ? "" : obj.AttrPO_UNIT;
  }
  return s;
}

public static Func<ST_3b61de88b81d785d0616b445a04890fdStructure, ssConectaProveedores.RestRecords.JSONST_3b61de88b81d785d0616b445a04890fdStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_3b61de88b81d785d0616b445a04890fdStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_3b61de88b81d785d0616b445a04890fdStructure FromStructure(ST_3b61de88b81d785d0616b445a04890fdStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_3b61de88b81d785d0616b445a04890fdStructure(s, config);
}

}


