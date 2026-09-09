using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioRegionSeqRecord
public class JSONRC_ba02c963eabdf75d57d498152c3db2fa : AbstractRESTStructure<RC_ba02c963eabdf75d57d498152c3db2fa> {
[JsonProperty("FolioRegionSeq")]
[JsonPropertyName("FolioRegionSeq")]
public ssConectaProveedores.RestRecords.JSONEN_6d30d3f082837359d34a81528b515a59EntityRecord AttrFolioRegionSeq;

public JSONRC_ba02c963eabdf75d57d498152c3db2fa() { }

public JSONRC_ba02c963eabdf75d57d498152c3db2fa (RC_ba02c963eabdf75d57d498152c3db2fa s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioRegionSeq = ConvertToRestWithoutDefaults(s.ssENFolioRegionSeq, new EN_6d30d3f082837359d34a81528b515a59EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6d30d3f082837359d34a81528b515a59EntityRecord.FromStructure, config);
  } else {
AttrFolioRegionSeq = ssConectaProveedores.RestRecords.JSONEN_6d30d3f082837359d34a81528b515a59EntityRecord.FromStructure(s.ssENFolioRegionSeq, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_ba02c963eabdf75d57d498152c3db2fa, RC_ba02c963eabdf75d57d498152c3db2fa> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_ba02c963eabdf75d57d498152c3db2fa s) => ToStructure(s, config);
}
public static RC_ba02c963eabdf75d57d498152c3db2fa ToStructure(ssConectaProveedores.RestRecords.JSONRC_ba02c963eabdf75d57d498152c3db2fa obj, IBehaviorsConfiguration config) { 
  RC_ba02c963eabdf75d57d498152c3db2fa s = new RC_ba02c963eabdf75d57d498152c3db2fa();
  if(obj != null) {
  s.ssENFolioRegionSeq = ssConectaProveedores.RestRecords.JSONEN_6d30d3f082837359d34a81528b515a59EntityRecord.ToStructure(obj.AttrFolioRegionSeq, config);
  }
  return s;
}

public static Func<RC_ba02c963eabdf75d57d498152c3db2fa, ssConectaProveedores.RestRecords.JSONRC_ba02c963eabdf75d57d498152c3db2fa> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ba02c963eabdf75d57d498152c3db2fa s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_ba02c963eabdf75d57d498152c3db2fa FromStructure(RC_ba02c963eabdf75d57d498152c3db2fa s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_ba02c963eabdf75d57d498152c3db2fa(s, config);
}

}


