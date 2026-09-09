using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedMoreCharges
public class RESTEN_a9440c310249b67518f0615139b4c690EntityRecord : AbstractRESTStructure<EN_a9440c310249b67518f0615139b4c690EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("InvoiceId")]
public long? AttrInvoiceId;

[JsonProperty("NombreConcepto")]
public string AttrNombreConcepto;

[JsonProperty("Value")]
public decimal? AttrValue;

public RESTEN_a9440c310249b67518f0615139b4c690EntityRecord() { }

public RESTEN_a9440c310249b67518f0615139b4c690EntityRecord (EN_a9440c310249b67518f0615139b4c690EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrInvoiceId = ConvertToRestWithoutDefaults(s.ssInvoiceId, 0L);
AttrNombreConcepto = ConvertToRestWithoutDefaults(s.ssNombreConcepto, "");
AttrValue = ConvertToRestWithoutDefaults(s.ssValue, 0.0M);
  } else {
AttrId = (long?) s.ssId;
AttrInvoiceId = (long?) s.ssInvoiceId;
AttrNombreConcepto = s.ssNombreConcepto;
AttrValue = (decimal?) s.ssValue;
  }
}

public static EN_a9440c310249b67518f0615139b4c690EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_a9440c310249b67518f0615139b4c690EntityRecord obj) { 
  EN_a9440c310249b67518f0615139b4c690EntityRecord s = new EN_a9440c310249b67518f0615139b4c690EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssInvoiceId = obj.AttrInvoiceId == null ? 0L : obj.AttrInvoiceId.Value;
  s.ssNombreConcepto = obj.AttrNombreConcepto == null ? "" : obj.AttrNombreConcepto;
  s.ssValue = obj.AttrValue == null ? 0.0M : obj.AttrValue.Value;
  }
  return s;
}

public static Func<EN_a9440c310249b67518f0615139b4c690EntityRecord, ssConectaProveedores.RestRecords.RESTEN_a9440c310249b67518f0615139b4c690EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_a9440c310249b67518f0615139b4c690EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_a9440c310249b67518f0615139b4c690EntityRecord FromStructure(EN_a9440c310249b67518f0615139b4c690EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_a9440c310249b67518f0615139b4c690EntityRecord(s, config);
}

}


