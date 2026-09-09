using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DisplayNameJobTitleIsNotMappedRecord
public class RESTRC_2dabb9c9cbdbc6ba6572314572d54c39 : AbstractRESTStructure<RC_2dabb9c9cbdbc6ba6572314572d54c39> {
[JsonProperty("DisplayName")]
public string AttrDisplayName;

[JsonProperty("JobTitle")]
public string AttrJobTitle;

[JsonProperty("IsNotMapped")]
public bool? AttrIsNotMapped;

public RESTRC_2dabb9c9cbdbc6ba6572314572d54c39() { }

public RESTRC_2dabb9c9cbdbc6ba6572314572d54c39 (RC_2dabb9c9cbdbc6ba6572314572d54c39 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDisplayName = ConvertToRestWithoutDefaults(s.ssDisplayName, "");
AttrJobTitle = ConvertToRestWithoutDefaults(s.ssJobTitle, "");
AttrIsNotMapped = ConvertToRestWithoutDefaults(s.ssIsNotMapped, false);
  } else {
AttrDisplayName = s.ssDisplayName;
AttrJobTitle = s.ssJobTitle;
AttrIsNotMapped = (bool?) s.ssIsNotMapped;
  }
}

public static RC_2dabb9c9cbdbc6ba6572314572d54c39 ToStructure(ssConectaProveedores.RestRecords.RESTRC_2dabb9c9cbdbc6ba6572314572d54c39 obj) { 
  RC_2dabb9c9cbdbc6ba6572314572d54c39 s = new RC_2dabb9c9cbdbc6ba6572314572d54c39();
  if(obj != null) {
  s.ssDisplayName = obj.AttrDisplayName == null ? "" : obj.AttrDisplayName;
  s.ssJobTitle = obj.AttrJobTitle == null ? "" : obj.AttrJobTitle;
  s.ssIsNotMapped = obj.AttrIsNotMapped == null ? false : obj.AttrIsNotMapped.Value;
  }
  return s;
}

public static Func<RC_2dabb9c9cbdbc6ba6572314572d54c39, ssConectaProveedores.RestRecords.RESTRC_2dabb9c9cbdbc6ba6572314572d54c39> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2dabb9c9cbdbc6ba6572314572d54c39 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_2dabb9c9cbdbc6ba6572314572d54c39 FromStructure(RC_2dabb9c9cbdbc6ba6572314572d54c39 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_2dabb9c9cbdbc6ba6572314572d54c39(s, config);
}

}


