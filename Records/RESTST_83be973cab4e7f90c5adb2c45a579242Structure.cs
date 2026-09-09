using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ExcelRequisitionLogToExport
public class RESTST_83be973cab4e7f90c5adb2c45a579242Structure : AbstractRESTStructure<ST_83be973cab4e7f90c5adb2c45a579242Structure> {
[JsonProperty("RequisitionName")]
public string AttrRequisitionName;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("Message")]
public string AttrMessage;

public RESTST_83be973cab4e7f90c5adb2c45a579242Structure() { }

public RESTST_83be973cab4e7f90c5adb2c45a579242Structure (ST_83be973cab4e7f90c5adb2c45a579242Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionName = ConvertToRestWithoutDefaults(s.ssRequisitionName, "");
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
  } else {
AttrRequisitionName = s.ssRequisitionName;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrMessage = s.ssMessage;
  }
}

public static ST_83be973cab4e7f90c5adb2c45a579242Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_83be973cab4e7f90c5adb2c45a579242Structure obj) { 
  ST_83be973cab4e7f90c5adb2c45a579242Structure s = new ST_83be973cab4e7f90c5adb2c45a579242Structure();
  if(obj != null) {
  s.ssRequisitionName = obj.AttrRequisitionName == null ? "" : obj.AttrRequisitionName;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<ST_83be973cab4e7f90c5adb2c45a579242Structure, ssConectaProveedores.RestRecords.RESTST_83be973cab4e7f90c5adb2c45a579242Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_83be973cab4e7f90c5adb2c45a579242Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_83be973cab4e7f90c5adb2c45a579242Structure FromStructure(ST_83be973cab4e7f90c5adb2c45a579242Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_83be973cab4e7f90c5adb2c45a579242Structure(s, config);
}

}


