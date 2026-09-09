using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// NotificationOutput2
public class RESTST_968b59b0d969f443f958cd852a31dcb5Structure : AbstractRESTStructure<ST_968b59b0d969f443f958cd852a31dcb5Structure> {
[JsonProperty("id")]
public long? Attrid;

[JsonProperty("title")]
public string Attrtitle;

[JsonProperty("content")]
public string Attrcontent;

[JsonProperty("isread")]
public bool? Attrisread;

[JsonProperty("createdat")]
public String Attrcreatedat;

[JsonProperty("categoryclass")]
public string Attrcategoryclass;

public RESTST_968b59b0d969f443f958cd852a31dcb5Structure() { }

public RESTST_968b59b0d969f443f958cd852a31dcb5Structure (ST_968b59b0d969f443f958cd852a31dcb5Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attrid = (long?) s.ssid;
Attrtitle = ConvertToRestWithoutDefaults(s.sstitle, "");
Attrcontent = ConvertToRestWithoutDefaults(s.sscontent, "");
Attrisread = ConvertToRestWithoutDefaults(s.ssisread, false);
Attrcreatedat = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.sscreatedat, config.DateTimeFormat);
Attrcategoryclass = ConvertToRestWithoutDefaults(s.sscategoryclass, "");
  } else {
Attrid = (long?) s.ssid;
Attrtitle = s.sstitle;
Attrcontent = s.sscontent;
Attrisread = (bool?) s.ssisread;
Attrcreatedat = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.sscreatedat, config.DateTimeFormat);
Attrcategoryclass = s.sscategoryclass;
  }
}

public static ST_968b59b0d969f443f958cd852a31dcb5Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_968b59b0d969f443f958cd852a31dcb5Structure obj) { 
  ST_968b59b0d969f443f958cd852a31dcb5Structure s = new ST_968b59b0d969f443f958cd852a31dcb5Structure();
  if(obj != null) {
  s.ssid = obj.Attrid == null ? 0L : obj.Attrid.Value;
  s.sstitle = obj.Attrtitle == null ? "" : obj.Attrtitle;
  s.sscontent = obj.Attrcontent == null ? "" : obj.Attrcontent;
  s.ssisread = obj.Attrisread == null ? false : obj.Attrisread.Value;
  s.sscreatedat = obj.Attrcreatedat == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.Attrcreatedat, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.sscategoryclass = obj.Attrcategoryclass == null ? "" : obj.Attrcategoryclass;
  }
  return s;
}

public static Func<ST_968b59b0d969f443f958cd852a31dcb5Structure, ssConectaProveedores.RestRecords.RESTST_968b59b0d969f443f958cd852a31dcb5Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_968b59b0d969f443f958cd852a31dcb5Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_968b59b0d969f443f958cd852a31dcb5Structure FromStructure(ST_968b59b0d969f443f958cd852a31dcb5Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_968b59b0d969f443f958cd852a31dcb5Structure(s, config);
}

}


