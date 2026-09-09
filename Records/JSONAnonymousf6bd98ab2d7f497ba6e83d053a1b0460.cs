using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ExcelInvoiceLogToExportRecord
public class JSONRC_72ebc67e31662560b8d31a972a3fab67 : AbstractRESTStructure<RC_72ebc67e31662560b8d31a972a3fab67> {
[JsonProperty("ExcelInvoiceLogToExport")]
[JsonPropertyName("ExcelInvoiceLogToExport")]
public ssConectaProveedores.RestRecords.JSONST_dcf36ec11d8d763002f3a9a106379cf7Structure AttrExcelInvoiceLogToExport;

public JSONRC_72ebc67e31662560b8d31a972a3fab67() { }

public JSONRC_72ebc67e31662560b8d31a972a3fab67 (RC_72ebc67e31662560b8d31a972a3fab67 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrExcelInvoiceLogToExport = ConvertToRestWithoutDefaults(s.ssSTExcelInvoiceLogToExport, new ST_dcf36ec11d8d763002f3a9a106379cf7Structure(), ssConectaProveedores.RestRecords.JSONST_dcf36ec11d8d763002f3a9a106379cf7Structure.FromStructure, config);
  } else {
AttrExcelInvoiceLogToExport = ssConectaProveedores.RestRecords.JSONST_dcf36ec11d8d763002f3a9a106379cf7Structure.FromStructure(s.ssSTExcelInvoiceLogToExport, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_72ebc67e31662560b8d31a972a3fab67, RC_72ebc67e31662560b8d31a972a3fab67> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_72ebc67e31662560b8d31a972a3fab67 s) => ToStructure(s, config);
}
public static RC_72ebc67e31662560b8d31a972a3fab67 ToStructure(ssConectaProveedores.RestRecords.JSONRC_72ebc67e31662560b8d31a972a3fab67 obj, IBehaviorsConfiguration config) { 
  RC_72ebc67e31662560b8d31a972a3fab67 s = new RC_72ebc67e31662560b8d31a972a3fab67();
  if(obj != null) {
  s.ssSTExcelInvoiceLogToExport = ssConectaProveedores.RestRecords.JSONST_dcf36ec11d8d763002f3a9a106379cf7Structure.ToStructure(obj.AttrExcelInvoiceLogToExport, config);
  }
  return s;
}

public static Func<RC_72ebc67e31662560b8d31a972a3fab67, ssConectaProveedores.RestRecords.JSONRC_72ebc67e31662560b8d31a972a3fab67> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_72ebc67e31662560b8d31a972a3fab67 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_72ebc67e31662560b8d31a972a3fab67 FromStructure(RC_72ebc67e31662560b8d31a972a3fab67 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_72ebc67e31662560b8d31a972a3fab67(s, config);
}

}


