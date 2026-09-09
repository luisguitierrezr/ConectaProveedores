using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderResult
public class RESTST_5a17d82af8397abda9cf3915ce9c082fStructure : AbstractRESTStructure<ST_5a17d82af8397abda9cf3915ce9c082fStructure> {
[JsonProperty("OrderNumber")]
public string AttrOrderNumber;

[JsonProperty("HasSuccess")]
public bool? AttrHasSuccess;

[JsonProperty("ErrorMessage")]
public string AttrErrorMessage;

public RESTST_5a17d82af8397abda9cf3915ce9c082fStructure() { }

public RESTST_5a17d82af8397abda9cf3915ce9c082fStructure (ST_5a17d82af8397abda9cf3915ce9c082fStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderNumber = s.ssOrderNumber;
AttrHasSuccess = (bool?) s.ssHasSuccess;
AttrErrorMessage = ConvertToRestWithoutDefaults(s.ssErrorMessage, "");
  } else {
AttrOrderNumber = s.ssOrderNumber;
AttrHasSuccess = (bool?) s.ssHasSuccess;
AttrErrorMessage = s.ssErrorMessage;
  }
}

public static ST_5a17d82af8397abda9cf3915ce9c082fStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_5a17d82af8397abda9cf3915ce9c082fStructure obj) { 
  ST_5a17d82af8397abda9cf3915ce9c082fStructure s = new ST_5a17d82af8397abda9cf3915ce9c082fStructure();
  if(obj != null) {
  s.ssOrderNumber = obj.AttrOrderNumber == null ? "" : obj.AttrOrderNumber;
  s.ssHasSuccess = obj.AttrHasSuccess == null ? false : obj.AttrHasSuccess.Value;
  s.ssErrorMessage = obj.AttrErrorMessage == null ? "" : obj.AttrErrorMessage;
  }
  return s;
}

public static Func<ST_5a17d82af8397abda9cf3915ce9c082fStructure, ssConectaProveedores.RestRecords.RESTST_5a17d82af8397abda9cf3915ce9c082fStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_5a17d82af8397abda9cf3915ce9c082fStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_5a17d82af8397abda9cf3915ce9c082fStructure FromStructure(ST_5a17d82af8397abda9cf3915ce9c082fStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_5a17d82af8397abda9cf3915ce9c082fStructure(s, config);
}

}


