using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ExcelProposalLogToExportRecord
public class RESTRC_8a90e407fd43eda7eb201f767dcc2beb : AbstractRESTStructure<RC_8a90e407fd43eda7eb201f767dcc2beb> {
[JsonProperty("ExcelProposalLogToExport")]
public ssConectaProveedores.RestRecords.RESTST_d9d3688bd2889652b9e8e27acc05ba6cStructure AttrExcelProposalLogToExport;

public RESTRC_8a90e407fd43eda7eb201f767dcc2beb() { }

public RESTRC_8a90e407fd43eda7eb201f767dcc2beb (RC_8a90e407fd43eda7eb201f767dcc2beb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrExcelProposalLogToExport = ConvertToRestWithoutDefaults(s.ssSTExcelProposalLogToExport, new ST_d9d3688bd2889652b9e8e27acc05ba6cStructure(), ssConectaProveedores.RestRecords.RESTST_d9d3688bd2889652b9e8e27acc05ba6cStructure.FromStructure, config);
  } else {
AttrExcelProposalLogToExport = ssConectaProveedores.RestRecords.RESTST_d9d3688bd2889652b9e8e27acc05ba6cStructure.FromStructure(s.ssSTExcelProposalLogToExport, config);
  }
}

public static RC_8a90e407fd43eda7eb201f767dcc2beb ToStructure(ssConectaProveedores.RestRecords.RESTRC_8a90e407fd43eda7eb201f767dcc2beb obj) { 
  RC_8a90e407fd43eda7eb201f767dcc2beb s = new RC_8a90e407fd43eda7eb201f767dcc2beb();
  if(obj != null) {
  s.ssSTExcelProposalLogToExport = ssConectaProveedores.RestRecords.RESTST_d9d3688bd2889652b9e8e27acc05ba6cStructure.ToStructure(obj.AttrExcelProposalLogToExport);
  }
  return s;
}

public static Func<RC_8a90e407fd43eda7eb201f767dcc2beb, ssConectaProveedores.RestRecords.RESTRC_8a90e407fd43eda7eb201f767dcc2beb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8a90e407fd43eda7eb201f767dcc2beb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_8a90e407fd43eda7eb201f767dcc2beb FromStructure(RC_8a90e407fd43eda7eb201f767dcc2beb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_8a90e407fd43eda7eb201f767dcc2beb(s, config);
}

}


