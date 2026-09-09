using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ZMXFFIMF_CONTA_FACTURASReq
public class JSONST_012aef00497ef6b298e25799608b1289Structure : AbstractRESTStructure<ST_012aef00497ef6b298e25799608b1289Structure> {
[JsonProperty("PI_BUS_AREA")]
[JsonPropertyName("PI_BUS_AREA")]
public string AttrPI_BUS_AREA;

[JsonProperty("PI_COMP_CODE")]
[JsonPropertyName("PI_COMP_CODE")]
public string AttrPI_COMP_CODE;

[JsonProperty("PI_DB_CR_IND")]
[JsonPropertyName("PI_DB_CR_IND")]
public string AttrPI_DB_CR_IND;

[JsonProperty("PI_GL_ACCOUNT")]
[JsonPropertyName("PI_GL_ACCOUNT")]
public string AttrPI_GL_ACCOUNT;

[JsonProperty("PI_HEADER")]
[JsonPropertyName("PI_HEADER")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f4885e4f480f4a52f6c05031eda6ef37Structure AttrPI_HEADER;

[JsonProperty("PI_INVOICE_DOC_ITEM")]
[JsonPropertyName("PI_INVOICE_DOC_ITEM")]
public int? AttrPI_INVOICE_DOC_ITEM;

[JsonProperty("PI_ITEM_AMOUNT")]
[JsonPropertyName("PI_ITEM_AMOUNT")]
public decimal? AttrPI_ITEM_AMOUNT;

[JsonProperty("PI_UUID")]
[JsonPropertyName("PI_UUID")]
public string AttrPI_UUID;

[JsonProperty("TI_ITEM_In")]
[JsonPropertyName("TI_ITEM_In")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_8d8928c3b1d6b9b5123f6c51624c56b2Structure[] AttrTI_ITEM_In;

[JsonProperty("TI_WXD_In")]
[JsonPropertyName("TI_WXD_In")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_a8dbb50321f7e9ee99b69f05907922f9Structure[] AttrTI_WXD_In;

public JSONST_012aef00497ef6b298e25799608b1289Structure() { }

public JSONST_012aef00497ef6b298e25799608b1289Structure (ST_012aef00497ef6b298e25799608b1289Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_BUS_AREA = ConvertToRestWithoutDefaults(s.ssPI_BUS_AREA, "");
AttrPI_COMP_CODE = ConvertToRestWithoutDefaults(s.ssPI_COMP_CODE, "");
AttrPI_DB_CR_IND = ConvertToRestWithoutDefaults(s.ssPI_DB_CR_IND, "");
AttrPI_GL_ACCOUNT = ConvertToRestWithoutDefaults(s.ssPI_GL_ACCOUNT, "");
AttrPI_HEADER = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f4885e4f480f4a52f6c05031eda6ef37Structure.FromStructure(s.ssPI_HEADER, config);
AttrPI_INVOICE_DOC_ITEM = ConvertToRestWithoutDefaults(s.ssPI_INVOICE_DOC_ITEM, 0);
AttrPI_ITEM_AMOUNT = ConvertToRestWithoutDefaults(s.ssPI_ITEM_AMOUNT, 0.0M);
AttrPI_UUID = ConvertToRestWithoutDefaults(s.ssPI_UUID, "");
AttrTI_ITEM_In = s.ssTI_ITEM_In.Length == 0 ? null : s.ssTI_ITEM_In.ToArray<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_8d8928c3b1d6b9b5123f6c51624c56b2Structure>(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_8d8928c3b1d6b9b5123f6c51624c56b2Structure.FromStructureDelegate(config));
AttrTI_WXD_In = s.ssTI_WXD_In.Length == 0 ? null : s.ssTI_WXD_In.ToArray<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_a8dbb50321f7e9ee99b69f05907922f9Structure>(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_a8dbb50321f7e9ee99b69f05907922f9Structure.FromStructureDelegate(config));
  } else {
AttrPI_BUS_AREA = s.ssPI_BUS_AREA;
AttrPI_COMP_CODE = s.ssPI_COMP_CODE;
AttrPI_DB_CR_IND = s.ssPI_DB_CR_IND;
AttrPI_GL_ACCOUNT = s.ssPI_GL_ACCOUNT;
AttrPI_HEADER = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f4885e4f480f4a52f6c05031eda6ef37Structure.FromStructure(s.ssPI_HEADER, config);
AttrPI_INVOICE_DOC_ITEM = (int?) s.ssPI_INVOICE_DOC_ITEM;
AttrPI_ITEM_AMOUNT = (decimal?) s.ssPI_ITEM_AMOUNT;
AttrPI_UUID = s.ssPI_UUID;
AttrTI_ITEM_In = s.ssTI_ITEM_In.ToArray<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_8d8928c3b1d6b9b5123f6c51624c56b2Structure>(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_8d8928c3b1d6b9b5123f6c51624c56b2Structure.FromStructureDelegate(config));
AttrTI_WXD_In = s.ssTI_WXD_In.ToArray<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_a8dbb50321f7e9ee99b69f05907922f9Structure>(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_a8dbb50321f7e9ee99b69f05907922f9Structure.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_012aef00497ef6b298e25799608b1289Structure, ST_012aef00497ef6b298e25799608b1289Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_012aef00497ef6b298e25799608b1289Structure s) => ToStructure(s, config);
}
public static ST_012aef00497ef6b298e25799608b1289Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_012aef00497ef6b298e25799608b1289Structure obj, IBehaviorsConfiguration config) { 
  ST_012aef00497ef6b298e25799608b1289Structure s = new ST_012aef00497ef6b298e25799608b1289Structure();
  if(obj != null) {
  s.ssPI_BUS_AREA = obj.AttrPI_BUS_AREA == null ? "" : obj.AttrPI_BUS_AREA;
  s.ssPI_COMP_CODE = obj.AttrPI_COMP_CODE == null ? "" : obj.AttrPI_COMP_CODE;
  s.ssPI_DB_CR_IND = obj.AttrPI_DB_CR_IND == null ? "" : obj.AttrPI_DB_CR_IND;
  s.ssPI_GL_ACCOUNT = obj.AttrPI_GL_ACCOUNT == null ? "" : obj.AttrPI_GL_ACCOUNT;
  s.ssPI_HEADER = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f4885e4f480f4a52f6c05031eda6ef37Structure.ToStructure(obj.AttrPI_HEADER, config);
  s.ssPI_INVOICE_DOC_ITEM = obj.AttrPI_INVOICE_DOC_ITEM == null ? 0 : obj.AttrPI_INVOICE_DOC_ITEM.Value;
  s.ssPI_ITEM_AMOUNT = obj.AttrPI_ITEM_AMOUNT == null ? 0.0M : obj.AttrPI_ITEM_AMOUNT.Value;
  s.ssPI_UUID = obj.AttrPI_UUID == null ? "" : obj.AttrPI_UUID;
  s.ssTI_ITEM_In = RL_1c06eebb48d1b54a899c0d33bdf93a52.ToList(obj.AttrTI_ITEM_In, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_8d8928c3b1d6b9b5123f6c51624c56b2Structure.ToStructureDelegate(config));
  s.ssTI_WXD_In = RL_f2d9c802fb1adc89fda1ad392c027309.ToList(obj.AttrTI_WXD_In, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_a8dbb50321f7e9ee99b69f05907922f9Structure.ToStructureDelegate(config));
  }
  return s;
}

public static Func<ST_012aef00497ef6b298e25799608b1289Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_012aef00497ef6b298e25799608b1289Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_012aef00497ef6b298e25799608b1289Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_012aef00497ef6b298e25799608b1289Structure FromStructure(ST_012aef00497ef6b298e25799608b1289Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_012aef00497ef6b298e25799608b1289Structure(s, config);
}

}


