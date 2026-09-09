using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoicesReport48_5Files
public class RESTST_67affae36317a1bf9109868208ade0a8Structure : AbstractRESTStructure<ST_67affae36317a1bf9109868208ade0a8Structure> {
[JsonProperty("PdfName")]
public string AttrPdfName;

[JsonProperty("XmlName")]
public string AttrXmlName;

[JsonProperty("UUID")]
public string AttrUUID;

[JsonProperty("CostCenters")]
public string AttrCostCenters;

public RESTST_67affae36317a1bf9109868208ade0a8Structure() { }

public RESTST_67affae36317a1bf9109868208ade0a8Structure (ST_67affae36317a1bf9109868208ade0a8Structure s, IBehaviorsConfiguration config) {
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

public static ST_67affae36317a1bf9109868208ade0a8Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_67affae36317a1bf9109868208ade0a8Structure obj) { 
  ST_67affae36317a1bf9109868208ade0a8Structure s = new ST_67affae36317a1bf9109868208ade0a8Structure();
  if(obj != null) {
  s.ssPdfName = obj.AttrPdfName == null ? "" : obj.AttrPdfName;
  s.ssXmlName = obj.AttrXmlName == null ? "" : obj.AttrXmlName;
  s.ssUUID = obj.AttrUUID == null ? "" : obj.AttrUUID;
  s.ssCostCenters = obj.AttrCostCenters == null ? "" : obj.AttrCostCenters;
  }
  return s;
}

public static Func<ST_67affae36317a1bf9109868208ade0a8Structure, ssConectaProveedores.RestRecords.RESTST_67affae36317a1bf9109868208ade0a8Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_67affae36317a1bf9109868208ade0a8Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_67affae36317a1bf9109868208ade0a8Structure FromStructure(ST_67affae36317a1bf9109868208ade0a8Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_67affae36317a1bf9109868208ade0a8Structure(s, config);
}

}


