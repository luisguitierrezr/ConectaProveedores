using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioOrderMainRegionRecord
public class RESTRC_bc05641ca90f5bed620129942456b69d : AbstractRESTStructure<RC_bc05641ca90f5bed620129942456b69d> {
[JsonProperty("Folio")]
public ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("Region")]
public ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public RESTRC_bc05641ca90f5bed620129942456b69d() { }

public RESTRC_bc05641ca90f5bed620129942456b69d (RC_bc05641ca90f5bed620129942456b69d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static RC_bc05641ca90f5bed620129942456b69d ToStructure(ssConectaProveedores.RestRecords.RESTRC_bc05641ca90f5bed620129942456b69d obj) { 
  RC_bc05641ca90f5bed620129942456b69d s = new RC_bc05641ca90f5bed620129942456b69d();
  if(obj != null) {
  s.ssENFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  s.ssENRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion);
  }
  return s;
}

public static Func<RC_bc05641ca90f5bed620129942456b69d, ssConectaProveedores.RestRecords.RESTRC_bc05641ca90f5bed620129942456b69d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bc05641ca90f5bed620129942456b69d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_bc05641ca90f5bed620129942456b69d FromStructure(RC_bc05641ca90f5bed620129942456b69d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_bc05641ca90f5bed620129942456b69d(s, config);
}

}


