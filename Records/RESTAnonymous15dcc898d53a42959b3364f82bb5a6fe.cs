using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ErrorNumberRecord
public class RESTRC_1f579c47758735b50f415dd5b367a40b : AbstractRESTStructure<RC_1f579c47758735b50f415dd5b367a40b> {
[JsonProperty("Error")]
public string AttrError;

[JsonProperty("Number")]
public string AttrNumber;

public RESTRC_1f579c47758735b50f415dd5b367a40b() { }

public RESTRC_1f579c47758735b50f415dd5b367a40b (RC_1f579c47758735b50f415dd5b367a40b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrError = ConvertToRestWithoutDefaults(s.ssError, "");
AttrNumber = ConvertToRestWithoutDefaults(s.ssNumber, "");
  } else {
AttrError = s.ssError;
AttrNumber = s.ssNumber;
  }
}

public static RC_1f579c47758735b50f415dd5b367a40b ToStructure(ssConectaProveedores.RestRecords.RESTRC_1f579c47758735b50f415dd5b367a40b obj) { 
  RC_1f579c47758735b50f415dd5b367a40b s = new RC_1f579c47758735b50f415dd5b367a40b();
  if(obj != null) {
  s.ssError = obj.AttrError == null ? "" : obj.AttrError;
  s.ssNumber = obj.AttrNumber == null ? "" : obj.AttrNumber;
  }
  return s;
}

public static Func<RC_1f579c47758735b50f415dd5b367a40b, ssConectaProveedores.RestRecords.RESTRC_1f579c47758735b50f415dd5b367a40b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1f579c47758735b50f415dd5b367a40b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_1f579c47758735b50f415dd5b367a40b FromStructure(RC_1f579c47758735b50f415dd5b367a40b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_1f579c47758735b50f415dd5b367a40b(s, config);
}

}


