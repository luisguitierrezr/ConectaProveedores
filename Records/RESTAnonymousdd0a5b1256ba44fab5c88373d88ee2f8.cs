using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CurrencyOrderStatusOrderMainQuantidadeEntregadaQuantidadeTotalCompanyRecord
public class RESTRC_d14c83cafc2c8c4853d5f866ece1c59b : AbstractRESTStructure<RC_d14c83cafc2c8c4853d5f866ece1c59b> {
[JsonProperty("Currency")]
public ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord AttrCurrency;

[JsonProperty("OrderStatus")]
public ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord AttrOrderStatus;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("QuantidadeEntregada")]
public ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure AttrQuantidadeEntregada;

[JsonProperty("QuantidadeTotal")]
public ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure AttrQuantidadeTotal;

[JsonProperty("Company")]
public ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrCompany;

public RESTRC_d14c83cafc2c8c4853d5f866ece1c59b() { }

public RESTRC_d14c83cafc2c8c4853d5f866ece1c59b (RC_d14c83cafc2c8c4853d5f866ece1c59b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCurrency = ConvertToRestWithoutDefaults(s.ssENCurrency, new EN_327b52812b8badb247bde4975c10d441EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure, config);
AttrOrderStatus = ConvertToRestWithoutDefaults(s.ssENOrderStatus, new EN_5eda60810da752f579e01795bb7e0de0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrQuantidadeEntregada = ConvertToRestWithoutDefaults(s.ssSTQuantidadeEntregada, new ST_18874ac0b41f9a239dad794ccac4f8d3Structure(), ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure.FromStructure, config);
AttrQuantidadeTotal = ConvertToRestWithoutDefaults(s.ssSTQuantidadeTotal, new ST_18874ac0b41f9a239dad794ccac4f8d3Structure(), ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure.FromStructure, config);
AttrCompany = ConvertToRestWithoutDefaults(s.ssENCompany, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
  } else {
AttrCurrency = ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure(s.ssENCurrency, config);
AttrOrderStatus = ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord.FromStructure(s.ssENOrderStatus, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrQuantidadeEntregada = ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure.FromStructure(s.ssSTQuantidadeEntregada, config);
AttrQuantidadeTotal = ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure.FromStructure(s.ssSTQuantidadeTotal, config);
AttrCompany = ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENCompany, config);
  }
}

public static RC_d14c83cafc2c8c4853d5f866ece1c59b ToStructure(ssConectaProveedores.RestRecords.RESTRC_d14c83cafc2c8c4853d5f866ece1c59b obj) { 
  RC_d14c83cafc2c8c4853d5f866ece1c59b s = new RC_d14c83cafc2c8c4853d5f866ece1c59b();
  if(obj != null) {
  s.ssENCurrency = ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.ToStructure(obj.AttrCurrency);
  s.ssENOrderStatus = ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord.ToStructure(obj.AttrOrderStatus);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  s.ssSTQuantidadeEntregada = ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure.ToStructure(obj.AttrQuantidadeEntregada);
  s.ssSTQuantidadeTotal = ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure.ToStructure(obj.AttrQuantidadeTotal);
  s.ssENCompany = ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrCompany);
  }
  return s;
}

public static Func<RC_d14c83cafc2c8c4853d5f866ece1c59b, ssConectaProveedores.RestRecords.RESTRC_d14c83cafc2c8c4853d5f866ece1c59b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d14c83cafc2c8c4853d5f866ece1c59b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_d14c83cafc2c8c4853d5f866ece1c59b FromStructure(RC_d14c83cafc2c8c4853d5f866ece1c59b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_d14c83cafc2c8c4853d5f866ece1c59b(s, config);
}

}


