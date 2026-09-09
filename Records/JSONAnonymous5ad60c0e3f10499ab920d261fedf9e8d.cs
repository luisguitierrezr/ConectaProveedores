using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderStatusOrdersImportRequestOrderMainTelcelDirectionDivisionRegionRecord
public class JSONRC_0ac0129639ce616349f284f107640b9e : AbstractRESTStructure<RC_0ac0129639ce616349f284f107640b9e> {
[JsonProperty("OrderStatus")]
[JsonPropertyName("OrderStatus")]
public ssConectaProveedores.RestRecords.JSONEN_5eda60810da752f579e01795bb7e0de0EntityRecord AttrOrderStatus;

[JsonProperty("OrdersImportRequest")]
[JsonPropertyName("OrdersImportRequest")]
public ssConectaProveedores.RestRecords.JSONEN_8c3668a93870461b8ea1216c2848f298EntityRecord AttrOrdersImportRequest;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("TelcelDirection")]
[JsonPropertyName("TelcelDirection")]
public ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord AttrTelcelDirection;

[JsonProperty("Division")]
[JsonPropertyName("Division")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrDivision;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_0ac0129639ce616349f284f107640b9e() { }

public JSONRC_0ac0129639ce616349f284f107640b9e (RC_0ac0129639ce616349f284f107640b9e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderStatus = ConvertToRestWithoutDefaults(s.ssENOrderStatus, new EN_5eda60810da752f579e01795bb7e0de0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5eda60810da752f579e01795bb7e0de0EntityRecord.FromStructure, config);
AttrOrdersImportRequest = ConvertToRestWithoutDefaults(s.ssENOrdersImportRequest, new EN_8c3668a93870461b8ea1216c2848f298EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_8c3668a93870461b8ea1216c2848f298EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrTelcelDirection = ConvertToRestWithoutDefaults(s.ssENTelcelDirection, new EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.FromStructure, config);
AttrDivision = ConvertToRestWithoutDefaults(s.ssENDivision, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrOrderStatus = ssConectaProveedores.RestRecords.JSONEN_5eda60810da752f579e01795bb7e0de0EntityRecord.FromStructure(s.ssENOrderStatus, config);
AttrOrdersImportRequest = ssConectaProveedores.RestRecords.JSONEN_8c3668a93870461b8ea1216c2848f298EntityRecord.FromStructure(s.ssENOrdersImportRequest, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrTelcelDirection = ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.FromStructure(s.ssENTelcelDirection, config);
AttrDivision = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENDivision, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_0ac0129639ce616349f284f107640b9e, RC_0ac0129639ce616349f284f107640b9e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_0ac0129639ce616349f284f107640b9e s) => ToStructure(s, config);
}
public static RC_0ac0129639ce616349f284f107640b9e ToStructure(ssConectaProveedores.RestRecords.JSONRC_0ac0129639ce616349f284f107640b9e obj, IBehaviorsConfiguration config) { 
  RC_0ac0129639ce616349f284f107640b9e s = new RC_0ac0129639ce616349f284f107640b9e();
  if(obj != null) {
  s.ssENOrderStatus = ssConectaProveedores.RestRecords.JSONEN_5eda60810da752f579e01795bb7e0de0EntityRecord.ToStructure(obj.AttrOrderStatus, config);
  s.ssENOrdersImportRequest = ssConectaProveedores.RestRecords.JSONEN_8c3668a93870461b8ea1216c2848f298EntityRecord.ToStructure(obj.AttrOrdersImportRequest, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENTelcelDirection = ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.ToStructure(obj.AttrTelcelDirection, config);
  s.ssENDivision = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrDivision, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_0ac0129639ce616349f284f107640b9e, ssConectaProveedores.RestRecords.JSONRC_0ac0129639ce616349f284f107640b9e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0ac0129639ce616349f284f107640b9e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_0ac0129639ce616349f284f107640b9e FromStructure(RC_0ac0129639ce616349f284f107640b9e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_0ac0129639ce616349f284f107640b9e(s, config);
}

}


