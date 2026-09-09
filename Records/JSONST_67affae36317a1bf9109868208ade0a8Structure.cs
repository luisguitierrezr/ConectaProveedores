using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoicesReport48_5Files
public class JSONST_67affae36317a1bf9109868208ade0a8Structure : AbstractRESTStructure<ST_67affae36317a1bf9109868208ade0a8Structure> {
[JsonProperty("PdfName")]
[JsonPropertyName("PdfName")]
public string AttrPdfName;

[JsonProperty("XmlName")]
[JsonPropertyName("XmlName")]
public string AttrXmlName;

[JsonProperty("UUID")]
[JsonPropertyName("UUID")]
public string AttrUUID;

[JsonProperty("CostCenters")]
[JsonPropertyName("CostCenters")]
public string AttrCostCenters;

public JSONST_67affae36317a1bf9109868208ade0a8Structure() { }

public JSONST_67affae36317a1bf9109868208ade0a8Structure (ST_67affae36317a1bf9109868208ade0a8Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPdfName = ConvertToRestWithoutDefaults(s.ssPdfName, "");
AttrXmlName = ConvertToRestWithoutDefaults(s.ssXmlName, "");
AttrUUID = ConvertToRestWithoutDefaults(s.ssUUID, "");
AttrCostCenters = ConvertToRestWithoutDefaults(s.ssCostCenters, "");
  } else {
AttrPdfName = s.ssPdfName;
AttrXmlName = s.ssXmlName;
AttrUUID = s.ssUUID;
AttrCostCenters = s.ssCostCenters;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_67affae36317a1bf9109868208ade0a8Structure, ST_67affae36317a1bf9109868208ade0a8Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_67affae36317a1bf9109868208ade0a8Structure s) => ToStructure(s, config);
}
public static ST_67affae36317a1bf9109868208ade0a8Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_67affae36317a1bf9109868208ade0a8Structure obj, IBehaviorsConfiguration config) { 
  ST_67affae36317a1bf9109868208ade0a8Structure s = new ST_67affae36317a1bf9109868208ade0a8Structure();
  if(obj != null) {
  s.ssPdfName = obj.AttrPdfName == null ? "" : obj.AttrPdfName;
  s.ssXmlName = obj.AttrXmlName == null ? "" : obj.AttrXmlName;
  s.ssUUID = obj.AttrUUID == null ? "" : obj.AttrUUID;
  s.ssCostCenters = obj.AttrCostCenters == null ? "" : obj.AttrCostCenters;
  }
  return s;
}

public static Func<ST_67affae36317a1bf9109868208ade0a8Structure, ssConectaProveedores.RestRecords.JSONST_67affae36317a1bf9109868208ade0a8Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_67affae36317a1bf9109868208ade0a8Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_67affae36317a1bf9109868208ade0a8Structure FromStructure(ST_67affae36317a1bf9109868208ade0a8Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_67affae36317a1bf9109868208ade0a8Structure(s, config);
}

}


