using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ExcelRequisitionLogToExportRecord
public class RESTRC_cc70d98f5591c4042b4a1208b635d416 : AbstractRESTStructure<RC_cc70d98f5591c4042b4a1208b635d416> {
[JsonProperty("ExcelRequisitionLogToExport")]
public ssConectaProveedores.RestRecords.RESTST_83be973cab4e7f90c5adb2c45a579242Structure AttrExcelRequisitionLogToExport;

public RESTRC_cc70d98f5591c4042b4a1208b635d416() { }

public RESTRC_cc70d98f5591c4042b4a1208b635d416 (RC_cc70d98f5591c4042b4a1208b635d416 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrExcelRequisitionLogToExport = ConvertToRestWithoutDefaults(s.ssSTExcelRequisitionLogToExport, new ST_83be973cab4e7f90c5adb2c45a579242Structure(), ssConectaProveedores.RestRecords.RESTST_83be973cab4e7f90c5adb2c45a579242Structure.FromStructure, config);
  } else {
AttrExcelRequisitionLogToExport = ssConectaProveedores.RestRecords.RESTST_83be973cab4e7f90c5adb2c45a579242Structure.FromStructure(s.ssSTExcelRequisitionLogToExport, config);
  }
}

public static RC_cc70d98f5591c4042b4a1208b635d416 ToStructure(ssConectaProveedores.RestRecords.RESTRC_cc70d98f5591c4042b4a1208b635d416 obj) { 
  RC_cc70d98f5591c4042b4a1208b635d416 s = new RC_cc70d98f5591c4042b4a1208b635d416();
  if(obj != null) {
  s.ssSTExcelRequisitionLogToExport = ssConectaProveedores.RestRecords.RESTST_83be973cab4e7f90c5adb2c45a579242Structure.ToStructure(obj.AttrExcelRequisitionLogToExport);
  }
  return s;
}

public static Func<RC_cc70d98f5591c4042b4a1208b635d416, ssConectaProveedores.RestRecords.RESTRC_cc70d98f5591c4042b4a1208b635d416> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cc70d98f5591c4042b4a1208b635d416 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_cc70d98f5591c4042b4a1208b635d416 FromStructure(RC_cc70d98f5591c4042b4a1208b635d416 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_cc70d98f5591c4042b4a1208b635d416(s, config);
}

}


