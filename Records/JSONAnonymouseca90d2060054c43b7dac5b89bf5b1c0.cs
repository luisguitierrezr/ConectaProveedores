using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioSAPDataFolioRecord
public class JSONRC_77e758d8dd6b0d691548b18323e10e77 : AbstractRESTStructure<RC_77e758d8dd6b0d691548b18323e10e77> {
[JsonProperty("FolioSAPData")]
[JsonPropertyName("FolioSAPData")]
public ssConectaProveedores.RestRecords.JSONEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord AttrFolioSAPData;

[JsonProperty("Folio")]
[JsonPropertyName("Folio")]
public ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

public JSONRC_77e758d8dd6b0d691548b18323e10e77() { }

public JSONRC_77e758d8dd6b0d691548b18323e10e77 (RC_77e758d8dd6b0d691548b18323e10e77 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioSAPData = ConvertToRestWithoutDefaults(s.ssENFolioSAPData, new EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
  } else {
AttrFolioSAPData = ssConectaProveedores.RestRecords.JSONEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord.FromStructure(s.ssENFolioSAPData, config);
AttrFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_77e758d8dd6b0d691548b18323e10e77, RC_77e758d8dd6b0d691548b18323e10e77> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_77e758d8dd6b0d691548b18323e10e77 s) => ToStructure(s, config);
}
public static RC_77e758d8dd6b0d691548b18323e10e77 ToStructure(ssConectaProveedores.RestRecords.JSONRC_77e758d8dd6b0d691548b18323e10e77 obj, IBehaviorsConfiguration config) { 
  RC_77e758d8dd6b0d691548b18323e10e77 s = new RC_77e758d8dd6b0d691548b18323e10e77();
  if(obj != null) {
  s.ssENFolioSAPData = ssConectaProveedores.RestRecords.JSONEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord.ToStructure(obj.AttrFolioSAPData, config);
  s.ssENFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio, config);
  }
  return s;
}

public static Func<RC_77e758d8dd6b0d691548b18323e10e77, ssConectaProveedores.RestRecords.JSONRC_77e758d8dd6b0d691548b18323e10e77> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_77e758d8dd6b0d691548b18323e10e77 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_77e758d8dd6b0d691548b18323e10e77 FromStructure(RC_77e758d8dd6b0d691548b18323e10e77 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_77e758d8dd6b0d691548b18323e10e77(s, config);
}

}


