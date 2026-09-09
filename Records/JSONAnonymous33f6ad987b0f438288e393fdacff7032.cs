using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ExcelFolioLogToExportRecord
public class JSONRC_71a6039f6d90c4426aac574268306fe3 : AbstractRESTStructure<RC_71a6039f6d90c4426aac574268306fe3> {
[JsonProperty("ExcelFolioLogToExport")]
[JsonPropertyName("ExcelFolioLogToExport")]
public ssConectaProveedores.RestRecords.JSONST_2e562a380f69a76cb54ade40213e888fStructure AttrExcelFolioLogToExport;

public JSONRC_71a6039f6d90c4426aac574268306fe3() { }

public JSONRC_71a6039f6d90c4426aac574268306fe3 (RC_71a6039f6d90c4426aac574268306fe3 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrExcelFolioLogToExport = ConvertToRestWithoutDefaults(s.ssSTExcelFolioLogToExport, new ST_2e562a380f69a76cb54ade40213e888fStructure(), ssConectaProveedores.RestRecords.JSONST_2e562a380f69a76cb54ade40213e888fStructure.FromStructure, config);
  } else {
AttrExcelFolioLogToExport = ssConectaProveedores.RestRecords.JSONST_2e562a380f69a76cb54ade40213e888fStructure.FromStructure(s.ssSTExcelFolioLogToExport, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_71a6039f6d90c4426aac574268306fe3, RC_71a6039f6d90c4426aac574268306fe3> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_71a6039f6d90c4426aac574268306fe3 s) => ToStructure(s, config);
}
public static RC_71a6039f6d90c4426aac574268306fe3 ToStructure(ssConectaProveedores.RestRecords.JSONRC_71a6039f6d90c4426aac574268306fe3 obj, IBehaviorsConfiguration config) { 
  RC_71a6039f6d90c4426aac574268306fe3 s = new RC_71a6039f6d90c4426aac574268306fe3();
  if(obj != null) {
  s.ssSTExcelFolioLogToExport = ssConectaProveedores.RestRecords.JSONST_2e562a380f69a76cb54ade40213e888fStructure.ToStructure(obj.AttrExcelFolioLogToExport, config);
  }
  return s;
}

public static Func<RC_71a6039f6d90c4426aac574268306fe3, ssConectaProveedores.RestRecords.JSONRC_71a6039f6d90c4426aac574268306fe3> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_71a6039f6d90c4426aac574268306fe3 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_71a6039f6d90c4426aac574268306fe3 FromStructure(RC_71a6039f6d90c4426aac574268306fe3 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_71a6039f6d90c4426aac574268306fe3(s, config);
}

}


