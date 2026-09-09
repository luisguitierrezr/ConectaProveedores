using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// VideoOptionalConfigs
public class RESTST_6510d2524fe77fcc6c285159d4000cfbStructure : AbstractRESTStructure<ST_6510d2524fe77fcc6c285159d4000cfbStructure> {
[JsonProperty("Autoplay")]
public bool? AttrAutoplay;

[JsonProperty("Loop")]
public bool? AttrLoop;

[JsonProperty("Muted")]
public bool? AttrMuted;

[JsonProperty("PosterURL")]
public string AttrPosterURL;

public RESTST_6510d2524fe77fcc6c285159d4000cfbStructure() { }

public RESTST_6510d2524fe77fcc6c285159d4000cfbStructure (ST_6510d2524fe77fcc6c285159d4000cfbStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAutoplay = ConvertToRestWithoutDefaults(s.ssAutoplay, false);
AttrLoop = ConvertToRestWithoutDefaults(s.ssLoop, false);
AttrMuted = ConvertToRestWithoutDefaults(s.ssMuted, false);
AttrPosterURL = ConvertToRestWithoutDefaults(s.ssPosterURL, "");
  } else {
AttrAutoplay = (bool?) s.ssAutoplay;
AttrLoop = (bool?) s.ssLoop;
AttrMuted = (bool?) s.ssMuted;
AttrPosterURL = s.ssPosterURL;
  }
}

public static ST_6510d2524fe77fcc6c285159d4000cfbStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_6510d2524fe77fcc6c285159d4000cfbStructure obj) { 
  ST_6510d2524fe77fcc6c285159d4000cfbStructure s = new ST_6510d2524fe77fcc6c285159d4000cfbStructure();
  if(obj != null) {
  s.ssAutoplay = obj.AttrAutoplay == null ? false : obj.AttrAutoplay.Value;
  s.ssLoop = obj.AttrLoop == null ? false : obj.AttrLoop.Value;
  s.ssMuted = obj.AttrMuted == null ? false : obj.AttrMuted.Value;
  s.ssPosterURL = obj.AttrPosterURL == null ? "" : obj.AttrPosterURL;
  }
  return s;
}

public static Func<ST_6510d2524fe77fcc6c285159d4000cfbStructure, ssConectaProveedores.RestRecords.RESTST_6510d2524fe77fcc6c285159d4000cfbStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_6510d2524fe77fcc6c285159d4000cfbStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_6510d2524fe77fcc6c285159d4000cfbStructure FromStructure(ST_6510d2524fe77fcc6c285159d4000cfbStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_6510d2524fe77fcc6c285159d4000cfbStructure(s, config);
}

}


