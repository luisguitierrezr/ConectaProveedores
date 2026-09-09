using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CurrencyOrderStatusOrderMainQuantidadeEntregadaQuantidadeTotalCompanyRecord
public class JSONRC_d14c83cafc2c8c4853d5f866ece1c59b : AbstractRESTStructure<RC_d14c83cafc2c8c4853d5f866ece1c59b> {
[JsonProperty("Currency")]
[JsonPropertyName("Currency")]
public ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord AttrCurrency;

[JsonProperty("OrderStatus")]
[JsonPropertyName("OrderStatus")]
public ssConectaProveedores.RestRecords.JSONEN_5eda60810da752f579e01795bb7e0de0EntityRecord AttrOrderStatus;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("QuantidadeEntregada")]
[JsonPropertyName("QuantidadeEntregada")]
public ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure AttrQuantidadeEntregada;

[JsonProperty("QuantidadeTotal")]
[JsonPropertyName("QuantidadeTotal")]
public ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure AttrQuantidadeTotal;

[JsonProperty("Company")]
[JsonPropertyName("Company")]
public ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrCompany;

public JSONRC_d14c83cafc2c8c4853d5f866ece1c59b() { }

public JSONRC_d14c83cafc2c8c4853d5f866ece1c59b (RC_d14c83cafc2c8c4853d5f866ece1c59b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCurrency = ConvertToRestWithoutDefaults(s.ssENCurrency, new EN_327b52812b8badb247bde4975c10d441EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure, config);
AttrOrderStatus = ConvertToRestWithoutDefaults(s.ssENOrderStatus, new EN_5eda60810da752f579e01795bb7e0de0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5eda60810da752f579e01795bb7e0de0EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrQuantidadeEntregada = ConvertToRestWithoutDefaults(s.ssSTQuantidadeEntregada, new ST_18874ac0b41f9a239dad794ccac4f8d3Structure(), ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure.FromStructure, config);
AttrQuantidadeTotal = ConvertToRestWithoutDefaults(s.ssSTQuantidadeTotal, new ST_18874ac0b41f9a239dad794ccac4f8d3Structure(), ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure.FromStructure, config);
AttrCompany = ConvertToRestWithoutDefaults(s.ssENCompany, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
  } else {
AttrCurrency = ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure(s.ssENCurrency, config);
AttrOrderStatus = ssConectaProveedores.RestRecords.JSONEN_5eda60810da752f579e01795bb7e0de0EntityRecord.FromStructure(s.ssENOrderStatus, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrQuantidadeEntregada = ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure.FromStructure(s.ssSTQuantidadeEntregada, config);
AttrQuantidadeTotal = ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure.FromStructure(s.ssSTQuantidadeTotal, config);
AttrCompany = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENCompany, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_d14c83cafc2c8c4853d5f866ece1c59b, RC_d14c83cafc2c8c4853d5f866ece1c59b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_d14c83cafc2c8c4853d5f866ece1c59b s) => ToStructure(s, config);
}
public static RC_d14c83cafc2c8c4853d5f866ece1c59b ToStructure(ssConectaProveedores.RestRecords.JSONRC_d14c83cafc2c8c4853d5f866ece1c59b obj, IBehaviorsConfiguration config) { 
  RC_d14c83cafc2c8c4853d5f866ece1c59b s = new RC_d14c83cafc2c8c4853d5f866ece1c59b();
  if(obj != null) {
  s.ssENCurrency = ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.ToStructure(obj.AttrCurrency, config);
  s.ssENOrderStatus = ssConectaProveedores.RestRecords.JSONEN_5eda60810da752f579e01795bb7e0de0EntityRecord.ToStructure(obj.AttrOrderStatus, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssSTQuantidadeEntregada = ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure.ToStructure(obj.AttrQuantidadeEntregada, config);
  s.ssSTQuantidadeTotal = ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure.ToStructure(obj.AttrQuantidadeTotal, config);
  s.ssENCompany = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrCompany, config);
  }
  return s;
}

public static Func<RC_d14c83cafc2c8c4853d5f866ece1c59b, ssConectaProveedores.RestRecords.JSONRC_d14c83cafc2c8c4853d5f866ece1c59b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d14c83cafc2c8c4853d5f866ece1c59b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_d14c83cafc2c8c4853d5f866ece1c59b FromStructure(RC_d14c83cafc2c8c4853d5f866ece1c59b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_d14c83cafc2c8c4853d5f866ece1c59b(s, config);
}

}


