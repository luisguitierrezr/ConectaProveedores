using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ExcelOrderEntriesLogToExportRecord
public class JSONRC_769d8d99752cec679c1c2bc7970a5749 : AbstractRESTStructure<RC_769d8d99752cec679c1c2bc7970a5749> {
[JsonProperty("ExcelOrderEntriesLogToExport")]
[JsonPropertyName("ExcelOrderEntriesLogToExport")]
public ssConectaProveedores.RestRecords.JSONST_8a84c0565c68734bf5e2c1c8f79fe30cStructure AttrExcelOrderEntriesLogToExport;

public JSONRC_769d8d99752cec679c1c2bc7970a5749() { }

public JSONRC_769d8d99752cec679c1c2bc7970a5749 (RC_769d8d99752cec679c1c2bc7970a5749 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrExcelOrderEntriesLogToExport = ConvertToRestWithoutDefaults(s.ssSTExcelOrderEntriesLogToExport, new ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure(), ssConectaProveedores.RestRecords.JSONST_8a84c0565c68734bf5e2c1c8f79fe30cStructure.FromStructure, config);
  } else {
AttrExcelOrderEntriesLogToExport = ssConectaProveedores.RestRecords.JSONST_8a84c0565c68734bf5e2c1c8f79fe30cStructure.FromStructure(s.ssSTExcelOrderEntriesLogToExport, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_769d8d99752cec679c1c2bc7970a5749, RC_769d8d99752cec679c1c2bc7970a5749> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_769d8d99752cec679c1c2bc7970a5749 s) => ToStructure(s, config);
}
public static RC_769d8d99752cec679c1c2bc7970a5749 ToStructure(ssConectaProveedores.RestRecords.JSONRC_769d8d99752cec679c1c2bc7970a5749 obj, IBehaviorsConfiguration config) { 
  RC_769d8d99752cec679c1c2bc7970a5749 s = new RC_769d8d99752cec679c1c2bc7970a5749();
  if(obj != null) {
  s.ssSTExcelOrderEntriesLogToExport = ssConectaProveedores.RestRecords.JSONST_8a84c0565c68734bf5e2c1c8f79fe30cStructure.ToStructure(obj.AttrExcelOrderEntriesLogToExport, config);
  }
  return s;
}

public static Func<RC_769d8d99752cec679c1c2bc7970a5749, ssConectaProveedores.RestRecords.JSONRC_769d8d99752cec679c1c2bc7970a5749> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_769d8d99752cec679c1c2bc7970a5749 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_769d8d99752cec679c1c2bc7970a5749 FromStructure(RC_769d8d99752cec679c1c2bc7970a5749 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_769d8d99752cec679c1c2bc7970a5749(s, config);
}

}


