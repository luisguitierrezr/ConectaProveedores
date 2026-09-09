using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ExcelFolioLogToExportRecord
public class RESTRC_71a6039f6d90c4426aac574268306fe3 : AbstractRESTStructure<RC_71a6039f6d90c4426aac574268306fe3> {
[JsonProperty("ExcelFolioLogToExport")]
public ssConectaProveedores.RestRecords.RESTST_2e562a380f69a76cb54ade40213e888fStructure AttrExcelFolioLogToExport;

public RESTRC_71a6039f6d90c4426aac574268306fe3() { }

public RESTRC_71a6039f6d90c4426aac574268306fe3 (RC_71a6039f6d90c4426aac574268306fe3 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrExcelFolioLogToExport = ConvertToRestWithoutDefaults(s.ssSTExcelFolioLogToExport, new ST_2e562a380f69a76cb54ade40213e888fStructure(), ssConectaProveedores.RestRecords.RESTST_2e562a380f69a76cb54ade40213e888fStructure.FromStructure, config);
  } else {
AttrExcelFolioLogToExport = ssConectaProveedores.RestRecords.RESTST_2e562a380f69a76cb54ade40213e888fStructure.FromStructure(s.ssSTExcelFolioLogToExport, config);
  }
}

public static RC_71a6039f6d90c4426aac574268306fe3 ToStructure(ssConectaProveedores.RestRecords.RESTRC_71a6039f6d90c4426aac574268306fe3 obj) { 
  RC_71a6039f6d90c4426aac574268306fe3 s = new RC_71a6039f6d90c4426aac574268306fe3();
  if(obj != null) {
  s.ssSTExcelFolioLogToExport = ssConectaProveedores.RestRecords.RESTST_2e562a380f69a76cb54ade40213e888fStructure.ToStructure(obj.AttrExcelFolioLogToExport);
  }
  return s;
}

public static Func<RC_71a6039f6d90c4426aac574268306fe3, ssConectaProveedores.RestRecords.RESTRC_71a6039f6d90c4426aac574268306fe3> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_71a6039f6d90c4426aac574268306fe3 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_71a6039f6d90c4426aac574268306fe3 FromStructure(RC_71a6039f6d90c4426aac574268306fe3 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_71a6039f6d90c4426aac574268306fe3(s, config);
}

}


