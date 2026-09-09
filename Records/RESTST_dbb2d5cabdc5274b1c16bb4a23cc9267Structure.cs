using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ValidationReportItem
public class RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure : AbstractRESTStructure<ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure> {
[JsonProperty("Position")]
public int? AttrPosition;

[JsonProperty("Article")]
public string AttrArticle;

[JsonProperty("Description")]
public string AttrDescription;

[JsonProperty("EntryNumber")]
public int? AttrEntryNumber;

[JsonProperty("EntryDate")]
public String AttrEntryDate;

[JsonProperty("MaterialCode")]
public string AttrMaterialCode;

[JsonProperty("Quantity")]
public int? AttrQuantity;

[JsonProperty("UnitPrice")]
public string AttrUnitPrice;

[JsonProperty("TotalAmount")]
public string AttrTotalAmount;

[JsonProperty("Currency")]
public string AttrCurrency;

public RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure() { }

public RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure (ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPosition = ConvertToRestWithoutDefaults(s.ssPosition, 0);
AttrArticle = ConvertToRestWithoutDefaults(s.ssArticle, "");
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrEntryNumber = ConvertToRestWithoutDefaults(s.ssEntryNumber, 0);
AttrEntryDate = ConvertDateToRestWithoutDefaults(s.ssEntryDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrMaterialCode = ConvertToRestWithoutDefaults(s.ssMaterialCode, "");
AttrQuantity = ConvertToRestWithoutDefaults(s.ssQuantity, 0);
AttrUnitPrice = ConvertToRestWithoutDefaults(s.ssUnitPrice, "");
AttrTotalAmount = ConvertToRestWithoutDefaults(s.ssTotalAmount, "");
AttrCurrency = ConvertToRestWithoutDefaults(s.ssCurrency, "");
  } else {
AttrPosition = (int?) s.ssPosition;
AttrArticle = s.ssArticle;
AttrDescription = s.ssDescription;
AttrEntryNumber = (int?) s.ssEntryNumber;
AttrEntryDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssEntryDate);
AttrMaterialCode = s.ssMaterialCode;
AttrQuantity = (int?) s.ssQuantity;
AttrUnitPrice = s.ssUnitPrice;
AttrTotalAmount = s.ssTotalAmount;
AttrCurrency = s.ssCurrency;
  }
}

public static ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure obj) { 
  ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure s = new ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure();
  if(obj != null) {
  s.ssPosition = obj.AttrPosition == null ? 0 : obj.AttrPosition.Value;
  s.ssArticle = obj.AttrArticle == null ? "" : obj.AttrArticle;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssEntryNumber = obj.AttrEntryNumber == null ? 0 : obj.AttrEntryNumber.Value;
  s.ssEntryDate = obj.AttrEntryDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrEntryDate);
  s.ssMaterialCode = obj.AttrMaterialCode == null ? "" : obj.AttrMaterialCode;
  s.ssQuantity = obj.AttrQuantity == null ? 0 : obj.AttrQuantity.Value;
  s.ssUnitPrice = obj.AttrUnitPrice == null ? "" : obj.AttrUnitPrice;
  s.ssTotalAmount = obj.AttrTotalAmount == null ? "" : obj.AttrTotalAmount;
  s.ssCurrency = obj.AttrCurrency == null ? "" : obj.AttrCurrency;
  }
  return s;
}

public static Func<ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure, ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure FromStructure(ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure(s, config);
}

}


