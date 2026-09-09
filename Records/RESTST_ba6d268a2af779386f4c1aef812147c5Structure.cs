using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Configuration2
public class RESTST_ba6d268a2af779386f4c1aef812147c5Structure : AbstractRESTStructure<ST_ba6d268a2af779386f4c1aef812147c5Structure> {
[JsonProperty("userid")]
public string Attruserid;

[JsonProperty("categoryid")]
public string Attrcategoryid;

[JsonProperty("isenabled")]
public bool? Attrisenabled;

[JsonProperty("notifybyemail")]
public bool? Attrnotifybyemail;

[JsonProperty("notifyinapp")]
public bool? Attrnotifyinapp;

[JsonProperty("categorydescription")]
public string Attrcategorydescription;

public RESTST_ba6d268a2af779386f4c1aef812147c5Structure() { }

public RESTST_ba6d268a2af779386f4c1aef812147c5Structure (ST_ba6d268a2af779386f4c1aef812147c5Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attruserid = s.ssuserid;
Attrcategoryid = s.sscategoryid;
Attrisenabled = ConvertToRestWithoutDefaults(s.ssisenabled, false);
Attrnotifybyemail = ConvertToRestWithoutDefaults(s.ssnotifybyemail, false);
Attrnotifyinapp = ConvertToRestWithoutDefaults(s.ssnotifyinapp, false);
Attrcategorydescription = ConvertToRestWithoutDefaults(s.sscategorydescription, "");
  } else {
Attruserid = s.ssuserid;
Attrcategoryid = s.sscategoryid;
Attrisenabled = (bool?) s.ssisenabled;
Attrnotifybyemail = (bool?) s.ssnotifybyemail;
Attrnotifyinapp = (bool?) s.ssnotifyinapp;
Attrcategorydescription = s.sscategorydescription;
  }
}

public static ST_ba6d268a2af779386f4c1aef812147c5Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_ba6d268a2af779386f4c1aef812147c5Structure obj) { 
  ST_ba6d268a2af779386f4c1aef812147c5Structure s = new ST_ba6d268a2af779386f4c1aef812147c5Structure();
  if(obj != null) {
  s.ssuserid = obj.Attruserid == null ? "" : obj.Attruserid;
  s.sscategoryid = obj.Attrcategoryid == null ? "" : obj.Attrcategoryid;
  s.ssisenabled = obj.Attrisenabled == null ? false : obj.Attrisenabled.Value;
  s.ssnotifybyemail = obj.Attrnotifybyemail == null ? false : obj.Attrnotifybyemail.Value;
  s.ssnotifyinapp = obj.Attrnotifyinapp == null ? false : obj.Attrnotifyinapp.Value;
  s.sscategorydescription = obj.Attrcategorydescription == null ? "" : obj.Attrcategorydescription;
  }
  return s;
}

public static Func<ST_ba6d268a2af779386f4c1aef812147c5Structure, ssConectaProveedores.RestRecords.RESTST_ba6d268a2af779386f4c1aef812147c5Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_ba6d268a2af779386f4c1aef812147c5Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_ba6d268a2af779386f4c1aef812147c5Structure FromStructure(ST_ba6d268a2af779386f4c1aef812147c5Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_ba6d268a2af779386f4c1aef812147c5Structure(s, config);
}

}


