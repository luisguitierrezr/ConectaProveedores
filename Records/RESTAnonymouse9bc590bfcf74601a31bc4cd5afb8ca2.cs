using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DescriptionShortDescriptionTitleStarIdRecord
public class RESTRC_0601d361b69aac23601da3c9e115bec5 : AbstractRESTStructure<RC_0601d361b69aac23601da3c9e115bec5> {
[JsonProperty("Description")]
public string AttrDescription;

[JsonProperty("ShortDescription")]
public string AttrShortDescription;

[JsonProperty("Title")]
public string AttrTitle;

[JsonProperty("Star")]
public bool? AttrStar;

[JsonProperty("Id")]
public long? AttrId;

public RESTRC_0601d361b69aac23601da3c9e115bec5() { }

public RESTRC_0601d361b69aac23601da3c9e115bec5 (RC_0601d361b69aac23601da3c9e115bec5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrShortDescription = ConvertToRestWithoutDefaults(s.ssShortDescription, "");
AttrTitle = ConvertToRestWithoutDefaults(s.ssTitle, "");
AttrStar = ConvertToRestWithoutDefaults(s.ssStar, false);
AttrId = ConvertToRestWithoutDefaults(s.ssId, 0L);
  } else {
AttrDescription = s.ssDescription;
AttrShortDescription = s.ssShortDescription;
AttrTitle = s.ssTitle;
AttrStar = (bool?) s.ssStar;
AttrId = (long?) s.ssId;
  }
}

public static RC_0601d361b69aac23601da3c9e115bec5 ToStructure(ssConectaProveedores.RestRecords.RESTRC_0601d361b69aac23601da3c9e115bec5 obj) { 
  RC_0601d361b69aac23601da3c9e115bec5 s = new RC_0601d361b69aac23601da3c9e115bec5();
  if(obj != null) {
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssShortDescription = obj.AttrShortDescription == null ? "" : obj.AttrShortDescription;
  s.ssTitle = obj.AttrTitle == null ? "" : obj.AttrTitle;
  s.ssStar = obj.AttrStar == null ? false : obj.AttrStar.Value;
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  }
  return s;
}

public static Func<RC_0601d361b69aac23601da3c9e115bec5, ssConectaProveedores.RestRecords.RESTRC_0601d361b69aac23601da3c9e115bec5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0601d361b69aac23601da3c9e115bec5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_0601d361b69aac23601da3c9e115bec5 FromStructure(RC_0601d361b69aac23601da3c9e115bec5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_0601d361b69aac23601da3c9e115bec5(s, config);
}

}


