using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ExcelInvoiceLogToExportRecord
public class RESTRC_72ebc67e31662560b8d31a972a3fab67 : AbstractRESTStructure<RC_72ebc67e31662560b8d31a972a3fab67> {
[JsonProperty("ExcelInvoiceLogToExport")]
public ssConectaProveedores.RestRecords.RESTST_dcf36ec11d8d763002f3a9a106379cf7Structure AttrExcelInvoiceLogToExport;

public RESTRC_72ebc67e31662560b8d31a972a3fab67() { }

public RESTRC_72ebc67e31662560b8d31a972a3fab67 (RC_72ebc67e31662560b8d31a972a3fab67 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrExcelInvoiceLogToExport = ConvertToRestWithoutDefaults(s.ssSTExcelInvoiceLogToExport, new ST_dcf36ec11d8d763002f3a9a106379cf7Structure(), ssConectaProveedores.RestRecords.RESTST_dcf36ec11d8d763002f3a9a106379cf7Structure.FromStructure, config);
  } else {
AttrExcelInvoiceLogToExport = ssConectaProveedores.RestRecords.RESTST_dcf36ec11d8d763002f3a9a106379cf7Structure.FromStructure(s.ssSTExcelInvoiceLogToExport, config);
  }
}

public static RC_72ebc67e31662560b8d31a972a3fab67 ToStructure(ssConectaProveedores.RestRecords.RESTRC_72ebc67e31662560b8d31a972a3fab67 obj) { 
  RC_72ebc67e31662560b8d31a972a3fab67 s = new RC_72ebc67e31662560b8d31a972a3fab67();
  if(obj != null) {
  s.ssSTExcelInvoiceLogToExport = ssConectaProveedores.RestRecords.RESTST_dcf36ec11d8d763002f3a9a106379cf7Structure.ToStructure(obj.AttrExcelInvoiceLogToExport);
  }
  return s;
}

public static Func<RC_72ebc67e31662560b8d31a972a3fab67, ssConectaProveedores.RestRecords.RESTRC_72ebc67e31662560b8d31a972a3fab67> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_72ebc67e31662560b8d31a972a3fab67 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_72ebc67e31662560b8d31a972a3fab67 FromStructure(RC_72ebc67e31662560b8d31a972a3fab67 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_72ebc67e31662560b8d31a972a3fab67(s, config);
}

}


