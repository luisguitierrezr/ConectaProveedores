using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioRegionSeq
public class RESTEN_6d30d3f082837359d34a81528b515a59EntityRecord : AbstractRESTStructure<EN_6d30d3f082837359d34a81528b515a59EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("RegionId")]
public long? AttrRegionId;

[JsonProperty("SeqValue")]
public int? AttrSeqValue;

public RESTEN_6d30d3f082837359d34a81528b515a59EntityRecord() { }

public RESTEN_6d30d3f082837359d34a81528b515a59EntityRecord (EN_6d30d3f082837359d34a81528b515a59EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrRegionId = ConvertToRestWithoutDefaults(s.ssRegionId, 0L);
AttrSeqValue = ConvertToRestWithoutDefaults(s.ssSeqValue, 0);
  } else {
AttrId = (long?) s.ssId;
AttrRegionId = (long?) s.ssRegionId;
AttrSeqValue = (int?) s.ssSeqValue;
  }
}

public static EN_6d30d3f082837359d34a81528b515a59EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_6d30d3f082837359d34a81528b515a59EntityRecord obj) { 
  EN_6d30d3f082837359d34a81528b515a59EntityRecord s = new EN_6d30d3f082837359d34a81528b515a59EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssRegionId = obj.AttrRegionId == null ? 0L : obj.AttrRegionId.Value;
  s.ssSeqValue = obj.AttrSeqValue == null ? 0 : obj.AttrSeqValue.Value;
  }
  return s;
}

public static Func<EN_6d30d3f082837359d34a81528b515a59EntityRecord, ssConectaProveedores.RestRecords.RESTEN_6d30d3f082837359d34a81528b515a59EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_6d30d3f082837359d34a81528b515a59EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_6d30d3f082837359d34a81528b515a59EntityRecord FromStructure(EN_6d30d3f082837359d34a81528b515a59EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_6d30d3f082837359d34a81528b515a59EntityRecord(s, config);
}

}


