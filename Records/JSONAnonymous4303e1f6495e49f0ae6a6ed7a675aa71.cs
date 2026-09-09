using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CodeIdClassDescriptionLabelOrderNumberOrderDateCountTotalAmountRecord
public class JSONRC_6fe7a87544f5e670c064f35599cfc737 : AbstractRESTStructure<RC_6fe7a87544f5e670c064f35599cfc737> {
[JsonProperty("Code")]
[JsonPropertyName("Code")]
public string AttrCode;

[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Class")]
[JsonPropertyName("Class")]
public string AttrClass;

[JsonProperty("Description")]
[JsonPropertyName("Description")]
public string AttrDescription;

[JsonProperty("Label")]
[JsonPropertyName("Label")]
public string AttrLabel;

[JsonProperty("OrderNumber")]
[JsonPropertyName("OrderNumber")]
public string AttrOrderNumber;

[JsonProperty("OrderDate")]
[JsonPropertyName("OrderDate")]
public String AttrOrderDate;

[JsonProperty("Count")]
[JsonPropertyName("Count")]
public long? AttrCount;

[JsonProperty("TotalAmount")]
[JsonPropertyName("TotalAmount")]
public decimal? AttrTotalAmount;

public JSONRC_6fe7a87544f5e670c064f35599cfc737() { }

public JSONRC_6fe7a87544f5e670c064f35599cfc737 (RC_6fe7a87544f5e670c064f35599cfc737 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCode = ConvertToRestWithoutDefaults(s.ssCode, "");
AttrId = ConvertToRestWithoutDefaults(s.ssId, 0L);
AttrClass = ConvertToRestWithoutDefaults(s.ssClass, "");
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrLabel = ConvertToRestWithoutDefaults(s.ssLabel, "");
AttrOrderNumber = ConvertToRestWithoutDefaults(s.ssOrderNumber, "");
AttrOrderDate = ConvertDateToRestWithoutDefaults(s.ssOrderDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrCount = ConvertToRestWithoutDefaults(s.ssCount, 0L);
AttrTotalAmount = ConvertToRestWithoutDefaults(s.ssTotalAmount, 0.0M);
  } else {
AttrCode = s.ssCode;
AttrId = (long?) s.ssId;
AttrClass = s.ssClass;
AttrDescription = s.ssDescription;
AttrLabel = s.ssLabel;
AttrOrderNumber = s.ssOrderNumber;
AttrOrderDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssOrderDate);
AttrCount = (long?) s.ssCount;
AttrTotalAmount = (decimal?) s.ssTotalAmount;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_6fe7a87544f5e670c064f35599cfc737, RC_6fe7a87544f5e670c064f35599cfc737> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_6fe7a87544f5e670c064f35599cfc737 s) => ToStructure(s, config);
}
public static RC_6fe7a87544f5e670c064f35599cfc737 ToStructure(ssConectaProveedores.RestRecords.JSONRC_6fe7a87544f5e670c064f35599cfc737 obj, IBehaviorsConfiguration config) { 
  RC_6fe7a87544f5e670c064f35599cfc737 s = new RC_6fe7a87544f5e670c064f35599cfc737();
  if(obj != null) {
  s.ssCode = obj.AttrCode == null ? "" : obj.AttrCode;
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssClass = obj.AttrClass == null ? "" : obj.AttrClass;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrderNumber = obj.AttrOrderNumber == null ? "" : obj.AttrOrderNumber;
  s.ssOrderDate = obj.AttrOrderDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrOrderDate);
  s.ssCount = obj.AttrCount == null ? 0L : obj.AttrCount.Value;
  s.ssTotalAmount = obj.AttrTotalAmount == null ? 0.0M : obj.AttrTotalAmount.Value;
  }
  return s;
}

public static Func<RC_6fe7a87544f5e670c064f35599cfc737, ssConectaProveedores.RestRecords.JSONRC_6fe7a87544f5e670c064f35599cfc737> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6fe7a87544f5e670c064f35599cfc737 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_6fe7a87544f5e670c064f35599cfc737 FromStructure(RC_6fe7a87544f5e670c064f35599cfc737 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_6fe7a87544f5e670c064f35599cfc737(s, config);
}

}


