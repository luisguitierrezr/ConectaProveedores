using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CompanyIdDocumentTypeIdRegionIdRecord
public class RESTRC_4d57f99d5ffffde65e439e566311a35e : AbstractRESTStructure<RC_4d57f99d5ffffde65e439e566311a35e> {
[JsonProperty("CompanyId")]
public ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrCompanyId;

[JsonProperty("DocumentTypeId")]
public ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrDocumentTypeId;

[JsonProperty("RegionId")]
public ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrRegionId;

public RESTRC_4d57f99d5ffffde65e439e566311a35e() { }

public RESTRC_4d57f99d5ffffde65e439e566311a35e (RC_4d57f99d5ffffde65e439e566311a35e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCompanyId = ConvertToRestWithoutDefaults(s.ssSTCompanyId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrDocumentTypeId = ConvertToRestWithoutDefaults(s.ssSTDocumentTypeId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrRegionId = ConvertToRestWithoutDefaults(s.ssSTRegionId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
  } else {
AttrCompanyId = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTCompanyId, config);
AttrDocumentTypeId = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTDocumentTypeId, config);
AttrRegionId = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTRegionId, config);
  }
}

public static RC_4d57f99d5ffffde65e439e566311a35e ToStructure(ssConectaProveedores.RestRecords.RESTRC_4d57f99d5ffffde65e439e566311a35e obj) { 
  RC_4d57f99d5ffffde65e439e566311a35e s = new RC_4d57f99d5ffffde65e439e566311a35e();
  if(obj != null) {
  s.ssSTCompanyId = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrCompanyId);
  s.ssSTDocumentTypeId = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrDocumentTypeId);
  s.ssSTRegionId = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrRegionId);
  }
  return s;
}

public static Func<RC_4d57f99d5ffffde65e439e566311a35e, ssConectaProveedores.RestRecords.RESTRC_4d57f99d5ffffde65e439e566311a35e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4d57f99d5ffffde65e439e566311a35e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_4d57f99d5ffffde65e439e566311a35e FromStructure(RC_4d57f99d5ffffde65e439e566311a35e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_4d57f99d5ffffde65e439e566311a35e(s, config);
}

}


