using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioAccData
public class JSONST_6dc39d329f4b959722daa75bc2f62c1fStructure : AbstractRESTStructure<ST_6dc39d329f4b959722daa75bc2f62c1fStructure> {
[JsonProperty("OrderAccConceptID")]
[JsonPropertyName("OrderAccConceptID")]
public long? AttrOrderAccConceptID;

[JsonProperty("Ammount")]
[JsonPropertyName("Ammount")]
public decimal? AttrAmmount;

[JsonProperty("CurrencyID")]
[JsonPropertyName("CurrencyID")]
public string AttrCurrencyID;

[JsonProperty("PaymentDate")]
[JsonPropertyName("PaymentDate")]
public String AttrPaymentDate;

public JSONST_6dc39d329f4b959722daa75bc2f62c1fStructure() { }

public JSONST_6dc39d329f4b959722daa75bc2f62c1fStructure (ST_6dc39d329f4b959722daa75bc2f62c1fStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderAccConceptID = (long?) s.ssOrderAccConceptID;
AttrAmmount = (decimal?) s.ssAmmount;
AttrCurrencyID = s.ssCurrencyID;
AttrPaymentDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssPaymentDate);
  } else {
AttrOrderAccConceptID = (long?) s.ssOrderAccConceptID;
AttrAmmount = (decimal?) s.ssAmmount;
AttrCurrencyID = s.ssCurrencyID;
AttrPaymentDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssPaymentDate);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_6dc39d329f4b959722daa75bc2f62c1fStructure, ST_6dc39d329f4b959722daa75bc2f62c1fStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_6dc39d329f4b959722daa75bc2f62c1fStructure s) => ToStructure(s, config);
}
public static ST_6dc39d329f4b959722daa75bc2f62c1fStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_6dc39d329f4b959722daa75bc2f62c1fStructure obj, IBehaviorsConfiguration config) { 
  ST_6dc39d329f4b959722daa75bc2f62c1fStructure s = new ST_6dc39d329f4b959722daa75bc2f62c1fStructure();
  if(obj != null) {
  s.ssOrderAccConceptID = obj.AttrOrderAccConceptID == null ? 0L : obj.AttrOrderAccConceptID.Value;
  s.ssAmmount = obj.AttrAmmount == null ? 0.0M : obj.AttrAmmount.Value;
  s.ssCurrencyID = obj.AttrCurrencyID == null ? "" : obj.AttrCurrencyID;
  s.ssPaymentDate = obj.AttrPaymentDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrPaymentDate);
  }
  return s;
}

public static Func<ST_6dc39d329f4b959722daa75bc2f62c1fStructure, ssConectaProveedores.RestRecords.JSONST_6dc39d329f4b959722daa75bc2f62c1fStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_6dc39d329f4b959722daa75bc2f62c1fStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_6dc39d329f4b959722daa75bc2f62c1fStructure FromStructure(ST_6dc39d329f4b959722daa75bc2f62c1fStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_6dc39d329f4b959722daa75bc2f62c1fStructure(s, config);
}

}


