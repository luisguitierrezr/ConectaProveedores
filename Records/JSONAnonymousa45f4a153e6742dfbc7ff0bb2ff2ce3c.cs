using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ExcelProposalLogToExportRecord
public class JSONRC_8a90e407fd43eda7eb201f767dcc2beb : AbstractRESTStructure<RC_8a90e407fd43eda7eb201f767dcc2beb> {
[JsonProperty("ExcelProposalLogToExport")]
[JsonPropertyName("ExcelProposalLogToExport")]
public ssConectaProveedores.RestRecords.JSONST_d9d3688bd2889652b9e8e27acc05ba6cStructure AttrExcelProposalLogToExport;

public JSONRC_8a90e407fd43eda7eb201f767dcc2beb() { }

public JSONRC_8a90e407fd43eda7eb201f767dcc2beb (RC_8a90e407fd43eda7eb201f767dcc2beb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrExcelProposalLogToExport = ConvertToRestWithoutDefaults(s.ssSTExcelProposalLogToExport, new ST_d9d3688bd2889652b9e8e27acc05ba6cStructure(), ssConectaProveedores.RestRecords.JSONST_d9d3688bd2889652b9e8e27acc05ba6cStructure.FromStructure, config);
  } else {
AttrExcelProposalLogToExport = ssConectaProveedores.RestRecords.JSONST_d9d3688bd2889652b9e8e27acc05ba6cStructure.FromStructure(s.ssSTExcelProposalLogToExport, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_8a90e407fd43eda7eb201f767dcc2beb, RC_8a90e407fd43eda7eb201f767dcc2beb> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_8a90e407fd43eda7eb201f767dcc2beb s) => ToStructure(s, config);
}
public static RC_8a90e407fd43eda7eb201f767dcc2beb ToStructure(ssConectaProveedores.RestRecords.JSONRC_8a90e407fd43eda7eb201f767dcc2beb obj, IBehaviorsConfiguration config) { 
  RC_8a90e407fd43eda7eb201f767dcc2beb s = new RC_8a90e407fd43eda7eb201f767dcc2beb();
  if(obj != null) {
  s.ssSTExcelProposalLogToExport = ssConectaProveedores.RestRecords.JSONST_d9d3688bd2889652b9e8e27acc05ba6cStructure.ToStructure(obj.AttrExcelProposalLogToExport, config);
  }
  return s;
}

public static Func<RC_8a90e407fd43eda7eb201f767dcc2beb, ssConectaProveedores.RestRecords.JSONRC_8a90e407fd43eda7eb201f767dcc2beb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8a90e407fd43eda7eb201f767dcc2beb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_8a90e407fd43eda7eb201f767dcc2beb FromStructure(RC_8a90e407fd43eda7eb201f767dcc2beb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_8a90e407fd43eda7eb201f767dcc2beb(s, config);
}

}


