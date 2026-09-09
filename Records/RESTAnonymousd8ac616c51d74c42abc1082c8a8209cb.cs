using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioRegionSeqRecord
public class RESTRC_ba02c963eabdf75d57d498152c3db2fa : AbstractRESTStructure<RC_ba02c963eabdf75d57d498152c3db2fa> {
[JsonProperty("FolioRegionSeq")]
public ssConectaProveedores.RestRecords.RESTEN_6d30d3f082837359d34a81528b515a59EntityRecord AttrFolioRegionSeq;

public RESTRC_ba02c963eabdf75d57d498152c3db2fa() { }

public RESTRC_ba02c963eabdf75d57d498152c3db2fa (RC_ba02c963eabdf75d57d498152c3db2fa s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioRegionSeq = ConvertToRestWithoutDefaults(s.ssENFolioRegionSeq, new EN_6d30d3f082837359d34a81528b515a59EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6d30d3f082837359d34a81528b515a59EntityRecord.FromStructure, config);
  } else {
AttrFolioRegionSeq = ssConectaProveedores.RestRecords.RESTEN_6d30d3f082837359d34a81528b515a59EntityRecord.FromStructure(s.ssENFolioRegionSeq, config);
  }
}

public static RC_ba02c963eabdf75d57d498152c3db2fa ToStructure(ssConectaProveedores.RestRecords.RESTRC_ba02c963eabdf75d57d498152c3db2fa obj) { 
  RC_ba02c963eabdf75d57d498152c3db2fa s = new RC_ba02c963eabdf75d57d498152c3db2fa();
  if(obj != null) {
  s.ssENFolioRegionSeq = ssConectaProveedores.RestRecords.RESTEN_6d30d3f082837359d34a81528b515a59EntityRecord.ToStructure(obj.AttrFolioRegionSeq);
  }
  return s;
}

public static Func<RC_ba02c963eabdf75d57d498152c3db2fa, ssConectaProveedores.RestRecords.RESTRC_ba02c963eabdf75d57d498152c3db2fa> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ba02c963eabdf75d57d498152c3db2fa s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_ba02c963eabdf75d57d498152c3db2fa FromStructure(RC_ba02c963eabdf75d57d498152c3db2fa s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_ba02c963eabdf75d57d498152c3db2fa(s, config);
}

}


