using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ReassignNotificationContent
public class RESTST_6fc999fa8f6e0055c73f2f167c4bad19Structure : AbstractRESTStructure<ST_6fc999fa8f6e0055c73f2f167c4bad19Structure> {
[JsonProperty("Email")]
public string AttrEmail;

[JsonProperty("Name")]
public string AttrName;

[JsonProperty("JobTitle")]
public string AttrJobTitle;

[JsonProperty("PhoneNumber")]
public string AttrPhoneNumber;

public RESTST_6fc999fa8f6e0055c73f2f167c4bad19Structure() { }

public RESTST_6fc999fa8f6e0055c73f2f167c4bad19Structure (ST_6fc999fa8f6e0055c73f2f167c4bad19Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEmail = ConvertToRestWithoutDefaults(s.ssEmail, "");
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrJobTitle = ConvertToRestWithoutDefaults(s.ssJobTitle, "");
AttrPhoneNumber = ConvertToRestWithoutDefaults(s.ssPhoneNumber, "");
  } else {
AttrEmail = s.ssEmail;
AttrName = s.ssName;
AttrJobTitle = s.ssJobTitle;
AttrPhoneNumber = s.ssPhoneNumber;
  }
}

public static ST_6fc999fa8f6e0055c73f2f167c4bad19Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_6fc999fa8f6e0055c73f2f167c4bad19Structure obj) { 
  ST_6fc999fa8f6e0055c73f2f167c4bad19Structure s = new ST_6fc999fa8f6e0055c73f2f167c4bad19Structure();
  if(obj != null) {
  s.ssEmail = obj.AttrEmail == null ? "" : obj.AttrEmail;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssJobTitle = obj.AttrJobTitle == null ? "" : obj.AttrJobTitle;
  s.ssPhoneNumber = obj.AttrPhoneNumber == null ? "" : obj.AttrPhoneNumber;
  }
  return s;
}

public static Func<ST_6fc999fa8f6e0055c73f2f167c4bad19Structure, ssConectaProveedores.RestRecords.RESTST_6fc999fa8f6e0055c73f2f167c4bad19Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_6fc999fa8f6e0055c73f2f167c4bad19Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_6fc999fa8f6e0055c73f2f167c4bad19Structure FromStructure(ST_6fc999fa8f6e0055c73f2f167c4bad19Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_6fc999fa8f6e0055c73f2f167c4bad19Structure(s, config);
}

}


