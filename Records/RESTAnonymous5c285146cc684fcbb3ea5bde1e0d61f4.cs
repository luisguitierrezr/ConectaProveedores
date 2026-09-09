using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// File3Record
public class RESTRC_e5232dda8695a6b53d7aafcc3b6d847f : AbstractRESTStructure<RC_e5232dda8695a6b53d7aafcc3b6d847f> {
[JsonProperty("File3")]
public ssConectaProveedores.RestRecords.RESTEN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord AttrFile3;

public RESTRC_e5232dda8695a6b53d7aafcc3b6d847f() { }

public RESTRC_e5232dda8695a6b53d7aafcc3b6d847f (RC_e5232dda8695a6b53d7aafcc3b6d847f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFile3 = ConvertToRestWithoutDefaults(s.ssENFile3, new EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord.FromStructure, config);
  } else {
AttrFile3 = ssConectaProveedores.RestRecords.RESTEN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord.FromStructure(s.ssENFile3, config);
  }
}

public static RC_e5232dda8695a6b53d7aafcc3b6d847f ToStructure(ssConectaProveedores.RestRecords.RESTRC_e5232dda8695a6b53d7aafcc3b6d847f obj) { 
  RC_e5232dda8695a6b53d7aafcc3b6d847f s = new RC_e5232dda8695a6b53d7aafcc3b6d847f();
  if(obj != null) {
  s.ssENFile3 = ssConectaProveedores.RestRecords.RESTEN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord.ToStructure(obj.AttrFile3);
  }
  return s;
}

public static Func<RC_e5232dda8695a6b53d7aafcc3b6d847f, ssConectaProveedores.RestRecords.RESTRC_e5232dda8695a6b53d7aafcc3b6d847f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e5232dda8695a6b53d7aafcc3b6d847f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_e5232dda8695a6b53d7aafcc3b6d847f FromStructure(RC_e5232dda8695a6b53d7aafcc3b6d847f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_e5232dda8695a6b53d7aafcc3b6d847f(s, config);
}

}


