using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ReassignNotificationContent
public class JSONST_6fc999fa8f6e0055c73f2f167c4bad19Structure : AbstractRESTStructure<ST_6fc999fa8f6e0055c73f2f167c4bad19Structure> {
[JsonProperty("Email")]
[JsonPropertyName("Email")]
public string AttrEmail;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("JobTitle")]
[JsonPropertyName("JobTitle")]
public string AttrJobTitle;

[JsonProperty("PhoneNumber")]
[JsonPropertyName("PhoneNumber")]
public string AttrPhoneNumber;

public JSONST_6fc999fa8f6e0055c73f2f167c4bad19Structure() { }

public JSONST_6fc999fa8f6e0055c73f2f167c4bad19Structure (ST_6fc999fa8f6e0055c73f2f167c4bad19Structure s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.RestRecords.JSONST_6fc999fa8f6e0055c73f2f167c4bad19Structure, ST_6fc999fa8f6e0055c73f2f167c4bad19Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_6fc999fa8f6e0055c73f2f167c4bad19Structure s) => ToStructure(s, config);
}
public static ST_6fc999fa8f6e0055c73f2f167c4bad19Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_6fc999fa8f6e0055c73f2f167c4bad19Structure obj, IBehaviorsConfiguration config) { 
  ST_6fc999fa8f6e0055c73f2f167c4bad19Structure s = new ST_6fc999fa8f6e0055c73f2f167c4bad19Structure();
  if(obj != null) {
  s.ssEmail = obj.AttrEmail == null ? "" : obj.AttrEmail;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssJobTitle = obj.AttrJobTitle == null ? "" : obj.AttrJobTitle;
  s.ssPhoneNumber = obj.AttrPhoneNumber == null ? "" : obj.AttrPhoneNumber;
  }
  return s;
}

public static Func<ST_6fc999fa8f6e0055c73f2f167c4bad19Structure, ssConectaProveedores.RestRecords.JSONST_6fc999fa8f6e0055c73f2f167c4bad19Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_6fc999fa8f6e0055c73f2f167c4bad19Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_6fc999fa8f6e0055c73f2f167c4bad19Structure FromStructure(ST_6fc999fa8f6e0055c73f2f167c4bad19Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_6fc999fa8f6e0055c73f2f167c4bad19Structure(s, config);
}

}


