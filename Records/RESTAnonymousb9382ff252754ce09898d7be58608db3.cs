using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DescriptionShortDescriptionTitleIsVideoStarIdRecord
public class RESTRC_5e1572d574f8fe1e39bbadd50daaa59c : AbstractRESTStructure<RC_5e1572d574f8fe1e39bbadd50daaa59c> {
[JsonProperty("Description")]
public string AttrDescription;

[JsonProperty("ShortDescription")]
public string AttrShortDescription;

[JsonProperty("Title")]
public string AttrTitle;

[JsonProperty("IsVideo")]
public bool? AttrIsVideo;

[JsonProperty("Star")]
public bool? AttrStar;

[JsonProperty("Id")]
public long? AttrId;

public RESTRC_5e1572d574f8fe1e39bbadd50daaa59c() { }

public RESTRC_5e1572d574f8fe1e39bbadd50daaa59c (RC_5e1572d574f8fe1e39bbadd50daaa59c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrShortDescription = ConvertToRestWithoutDefaults(s.ssShortDescription, "");
AttrTitle = ConvertToRestWithoutDefaults(s.ssTitle, "");
AttrIsVideo = ConvertToRestWithoutDefaults(s.ssIsVideo, false);
AttrStar = ConvertToRestWithoutDefaults(s.ssStar, false);
AttrId = ConvertToRestWithoutDefaults(s.ssId, 0L);
  } else {
AttrDescription = s.ssDescription;
AttrShortDescription = s.ssShortDescription;
AttrTitle = s.ssTitle;
AttrIsVideo = (bool?) s.ssIsVideo;
AttrStar = (bool?) s.ssStar;
AttrId = (long?) s.ssId;
  }
}

public static RC_5e1572d574f8fe1e39bbadd50daaa59c ToStructure(ssConectaProveedores.RestRecords.RESTRC_5e1572d574f8fe1e39bbadd50daaa59c obj) { 
  RC_5e1572d574f8fe1e39bbadd50daaa59c s = new RC_5e1572d574f8fe1e39bbadd50daaa59c();
  if(obj != null) {
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssShortDescription = obj.AttrShortDescription == null ? "" : obj.AttrShortDescription;
  s.ssTitle = obj.AttrTitle == null ? "" : obj.AttrTitle;
  s.ssIsVideo = obj.AttrIsVideo == null ? false : obj.AttrIsVideo.Value;
  s.ssStar = obj.AttrStar == null ? false : obj.AttrStar.Value;
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  }
  return s;
}

public static Func<RC_5e1572d574f8fe1e39bbadd50daaa59c, ssConectaProveedores.RestRecords.RESTRC_5e1572d574f8fe1e39bbadd50daaa59c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5e1572d574f8fe1e39bbadd50daaa59c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_5e1572d574f8fe1e39bbadd50daaa59c FromStructure(RC_5e1572d574f8fe1e39bbadd50daaa59c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_5e1572d574f8fe1e39bbadd50daaa59c(s, config);
}

}


