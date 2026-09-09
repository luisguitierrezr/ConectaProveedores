using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderStatusOrdersImportRequestOrderMainTelcelDirectionDivisionRegionRecord
public class RESTRC_0ac0129639ce616349f284f107640b9e : AbstractRESTStructure<RC_0ac0129639ce616349f284f107640b9e> {
[JsonProperty("OrderStatus")]
public ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord AttrOrderStatus;

[JsonProperty("OrdersImportRequest")]
public ssConectaProveedores.RestRecords.RESTEN_8c3668a93870461b8ea1216c2848f298EntityRecord AttrOrdersImportRequest;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("TelcelDirection")]
public ssConectaProveedores.RestRecords.RESTEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord AttrTelcelDirection;

[JsonProperty("Division")]
public ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrDivision;

[JsonProperty("Region")]
public ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public RESTRC_0ac0129639ce616349f284f107640b9e() { }

public RESTRC_0ac0129639ce616349f284f107640b9e (RC_0ac0129639ce616349f284f107640b9e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderStatus = ConvertToRestWithoutDefaults(s.ssENOrderStatus, new EN_5eda60810da752f579e01795bb7e0de0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord.FromStructure, config);
AttrOrdersImportRequest = ConvertToRestWithoutDefaults(s.ssENOrdersImportRequest, new EN_8c3668a93870461b8ea1216c2848f298EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_8c3668a93870461b8ea1216c2848f298EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrTelcelDirection = ConvertToRestWithoutDefaults(s.ssENTelcelDirection, new EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.FromStructure, config);
AttrDivision = ConvertToRestWithoutDefaults(s.ssENDivision, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrOrderStatus = ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord.FromStructure(s.ssENOrderStatus, config);
AttrOrdersImportRequest = ssConectaProveedores.RestRecords.RESTEN_8c3668a93870461b8ea1216c2848f298EntityRecord.FromStructure(s.ssENOrdersImportRequest, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrTelcelDirection = ssConectaProveedores.RestRecords.RESTEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.FromStructure(s.ssENTelcelDirection, config);
AttrDivision = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENDivision, config);
AttrRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static RC_0ac0129639ce616349f284f107640b9e ToStructure(ssConectaProveedores.RestRecords.RESTRC_0ac0129639ce616349f284f107640b9e obj) { 
  RC_0ac0129639ce616349f284f107640b9e s = new RC_0ac0129639ce616349f284f107640b9e();
  if(obj != null) {
  s.ssENOrderStatus = ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord.ToStructure(obj.AttrOrderStatus);
  s.ssENOrdersImportRequest = ssConectaProveedores.RestRecords.RESTEN_8c3668a93870461b8ea1216c2848f298EntityRecord.ToStructure(obj.AttrOrdersImportRequest);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  s.ssENTelcelDirection = ssConectaProveedores.RestRecords.RESTEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.ToStructure(obj.AttrTelcelDirection);
  s.ssENDivision = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrDivision);
  s.ssENRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion);
  }
  return s;
}

public static Func<RC_0ac0129639ce616349f284f107640b9e, ssConectaProveedores.RestRecords.RESTRC_0ac0129639ce616349f284f107640b9e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0ac0129639ce616349f284f107640b9e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_0ac0129639ce616349f284f107640b9e FromStructure(RC_0ac0129639ce616349f284f107640b9e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_0ac0129639ce616349f284f107640b9e(s, config);
}

}


