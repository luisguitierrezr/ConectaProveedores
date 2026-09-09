using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ExcelOrderLogToExportRecord
public class RESTRC_06efe9ed6a370dc0f5c291d28ffa3e14 : AbstractRESTStructure<RC_06efe9ed6a370dc0f5c291d28ffa3e14> {
[JsonProperty("ExcelOrderLogToExport")]
public ssConectaProveedores.RestRecords.RESTST_5fdc1be15c9e934a0a534eba5239d3c9Structure AttrExcelOrderLogToExport;

public RESTRC_06efe9ed6a370dc0f5c291d28ffa3e14() { }

public RESTRC_06efe9ed6a370dc0f5c291d28ffa3e14 (RC_06efe9ed6a370dc0f5c291d28ffa3e14 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrExcelOrderLogToExport = ConvertToRestWithoutDefaults(s.ssSTExcelOrderLogToExport, new ST_5fdc1be15c9e934a0a534eba5239d3c9Structure(), ssConectaProveedores.RestRecords.RESTST_5fdc1be15c9e934a0a534eba5239d3c9Structure.FromStructure, config);
  } else {
AttrExcelOrderLogToExport = ssConectaProveedores.RestRecords.RESTST_5fdc1be15c9e934a0a534eba5239d3c9Structure.FromStructure(s.ssSTExcelOrderLogToExport, config);
  }
}

public static RC_06efe9ed6a370dc0f5c291d28ffa3e14 ToStructure(ssConectaProveedores.RestRecords.RESTRC_06efe9ed6a370dc0f5c291d28ffa3e14 obj) { 
  RC_06efe9ed6a370dc0f5c291d28ffa3e14 s = new RC_06efe9ed6a370dc0f5c291d28ffa3e14();
  if(obj != null) {
  s.ssSTExcelOrderLogToExport = ssConectaProveedores.RestRecords.RESTST_5fdc1be15c9e934a0a534eba5239d3c9Structure.ToStructure(obj.AttrExcelOrderLogToExport);
  }
  return s;
}

public static Func<RC_06efe9ed6a370dc0f5c291d28ffa3e14, ssConectaProveedores.RestRecords.RESTRC_06efe9ed6a370dc0f5c291d28ffa3e14> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_06efe9ed6a370dc0f5c291d28ffa3e14 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_06efe9ed6a370dc0f5c291d28ffa3e14 FromStructure(RC_06efe9ed6a370dc0f5c291d28ffa3e14 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_06efe9ed6a370dc0f5c291d28ffa3e14(s, config);
}

}


